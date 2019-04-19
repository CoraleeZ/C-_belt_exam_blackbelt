using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using belt_exam.Models;
/////
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
////

namespace belt_exam.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        //////////////////////////////////////////////////
        [Route("")]
        [HttpGet]
        public IActionResult Start()
        {
            return RedirectToAction("Index");
        }

        [Route("signin")]
        [HttpGet]
        public IActionResult Index()
        {
            Login_Register_wrapper wrapper=new Login_Register_wrapper();
            return View(wrapper);
        }

        [HttpPost("process_register")]
        public IActionResult Process_Register(User reg)
        {
            // Check initial ModelState
            if(ModelState.IsValid)
            {
                // If a User exists with provided email
                if(dbContext.Useres.Any(u => u.Email == reg.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already exist!");
                    
                    // You may consider returning to the View at this point
                    Login_Register_wrapper wrapper=new Login_Register_wrapper();
                    return View("Index",wrapper);
                }
                else{
                    HttpContext.Session.SetString("Name", reg.Name);
                    //////
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    reg.Password = Hasher.HashPassword(reg, reg.Password);
                    //////
                    dbContext.Add(reg);
                    dbContext.SaveChanges(); 
                    User newuser=dbContext.Useres
                    .FirstOrDefault(u=>u.Email==reg.Email);
                    HttpContext.Session.SetInt32("id",newuser.UserId);
                    return RedirectToAction("Dashboard");
                }
            }else{
                Login_Register_wrapper wrapper=new Login_Register_wrapper();
                return View("Index",wrapper);
            }
            // other code
        } 

        [HttpPost("process_login")]
        public IActionResult Process_Login(Login log)
        {
            if(ModelState.IsValid)
            {
               
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Useres.FirstOrDefault(u => u.Email == log.logEmail);
                // If no user exists with provided email          
                if(userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("logEmail", "Invalid Email/Password");
                    Login_Register_wrapper wrapper=new Login_Register_wrapper();
                    return View("Index",wrapper);
                }else{
                    // Initialize hasher object
                    var hasher = new PasswordHasher<Login>();
                    
                    // varify provided password against hash stored in db
                    var result = hasher.VerifyHashedPassword(log, userInDb.Password, log.logPassword);
                    
                    // result can be compared to 0 for failure    
                    if(result == 0)
                    { 
                      
                        // handle failure (this should be similar to how "existing email" is handled)
                        ModelState.AddModelError("logPassword", "Invalid Email/Password");
                        Login_Register_wrapper wrapper=new Login_Register_wrapper();
                        return View("Index",wrapper);              
                    }
                    else{                
                       
                        HttpContext.Session.SetString("Name", userInDb.Name);
                        HttpContext.Session.SetInt32("id",userInDb.UserId);
                        return RedirectToAction("Dashboard"); 
                    }
                }
            }else{
                Login_Register_wrapper wrapper=new Login_Register_wrapper();
                return View("Index",wrapper);
            }

        }
        
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Name");
            HttpContext.Session.Remove("id");

            return RedirectToAction("Index");
        }


//////////////////////////////////////////////////////////////////////////////
        // [HttpGet("dashboard")]
        // public IActionResult Dashboard()
        // {
        //     if(HttpContext.Session.GetString("Name")!=null){
             
        //         return View();
        //     }else{
        //         return RedirectToAction("Index");
        //     }
        // }

         [HttpGet("home")]
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetString("Name")!=null){
                List<Plan> OldPlan=dbContext.Planes
                .Include(w=>w.Guests)
                .Include(w=>w.Creator)
                .ToList();

                List<Plan> Plans=new List<Plan>();
                List<Plan> P=new List<Plan>();
                foreach(Plan x in OldPlan)
                {
                    if(DateTime.ParseExact(x.Date, "MM/dd/yyyy",System.Globalization.CultureInfo.InvariantCulture).Add(DateTime.ParseExact(x.Time,"hh:mm tt",System.Globalization.CultureInfo.InvariantCulture).TimeOfDay)>=DateTime.Now)
                    {
                        P.Add(x);
                    }
                }
                /////////////////
                List<sort> forsort=new List<sort>();
                foreach(Plan x in P)
                {
                    sort sort=new sort();
                    sort.PlanId=x.PlanId;
                    sort.TotalTime=DateTime.ParseExact(x.Date, "MM/dd/yyyy",System.Globalization.CultureInfo.InvariantCulture).Add(DateTime.ParseExact(x.Time,"hh:mm tt",System.Globalization.CultureInfo.InvariantCulture).TimeOfDay);
                    forsort.Add(sort);
                    System.Console.WriteLine("id:"+sort.PlanId+"time"+sort.TotalTime);
                };

                for(int v=forsort.Count-1; v>0;v--)
                {
                    for(int z=forsort.Count-1;z>0;z--)
                    {
                        if(forsort[z].TotalTime>forsort[z-1].TotalTime)
                        {
                            sort temp=forsort[z];
                            forsort[z]=forsort[z-1];
                            forsort[z-1]=temp;
                        }
                    }
                }

                for(int o=forsort.Count-1;o>=0;o--)
                {
                    foreach(Plan y in P)
                    {
                        if(y.PlanId==forsort[o].PlanId)
                        {
                            Plans.Add(y);
                            System.Console.WriteLine("id:"+y.PlanId+"time"+y.Date+y.Time);
                        }
                    }
                }
                /////////////
                User user=dbContext.Useres
                .Include(u=>u.Join)
                .FirstOrDefault(u=>u.UserId==(int)HttpContext.Session.GetInt32("id"));

                Dashboard_wrapper Dashboard_wrapper=new Dashboard_wrapper
                {
                    AllPlan=Plans,
                    User=user
                };
                return View(Dashboard_wrapper);
            }else{
                return RedirectToAction("Index");
            }
        }

         [HttpGet("un-rsvp/{PlanId}")]
        public IActionResult Unrsvp(int PlanId)
        {
            if(HttpContext.Session.GetString("Name")!=null){
                List<Resevation> reservations=dbContext.Resevationes.Where(r=>r.PlanId==PlanId).ToList();
                int reservetionId=0;
                foreach(Resevation x in reservations){
                    if(x.UserId==(int)HttpContext.Session.GetInt32("id"))
                    {
                        reservetionId=x.ResevationId;
                    }
                }
                Resevation reserv=dbContext.Resevationes.FirstOrDefault(r=>r.ResevationId==reservetionId);
                dbContext.Resevationes.Remove(reserv);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }else{
                return RedirectToAction("Index");
            }
        }

        [HttpGet("rsvp/{PlanId}")]
        public IActionResult Rsvp(int PlanId)
        {
            if(HttpContext.Session.GetString("Name")!=null){
                Resevation reservation=new Resevation();
                reservation.UserId=(int)HttpContext.Session.GetInt32("id");
                reservation.PlanId=PlanId;
                dbContext.Resevationes.Add(reservation);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }else{
                return RedirectToAction("Index");
            }
        }

        
        [HttpGet("delete/{PlanId}")]
        public IActionResult Delete(int PlanId)
        {
            if(HttpContext.Session.GetString("Name")!=null){
                Plan plan=dbContext.Planes.FirstOrDefault(p=>p.PlanId==PlanId);
                dbContext.Planes.Remove(plan);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }else{
                return RedirectToAction("Index");
            }

        }

/////////////////////////////////////
        [HttpPost("process_newplan")]
        public IActionResult Process_newplan(NewPlan_wrapper Plan)
        {
            if(HttpContext.Session.GetString("Name")!=null){
                if(ModelState.IsValid)
                {   
                    if(DateTime.ParseExact(Plan.Date.ToString()+" "+Plan.Time.ToString(), "yyyy-MM-dd HH:mm",System.Globalization.CultureInfo.InvariantCulture)<DateTime.Now){
                        ModelState.AddModelError("Date", "Can not be ealy than now!");
                        ModelState.AddModelError("Time", "Can not be ealy than now!");
                        return View("AddPlan");
                    }

                    Plan NewPlan= new Plan();
                    NewPlan.Title=Plan.Title;
                    NewPlan.Date=DateTime.ParseExact(Plan.Date, "yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
                    NewPlan.Time=DateTime.ParseExact(Plan.Time,"HH:mm",System.Globalization.CultureInfo.InvariantCulture).ToString("hh:mm tt");
                    NewPlan.Duration=Plan.Duration_time+" "+Plan.Duration_set;
                    NewPlan.Description=Plan.Description;
                    NewPlan.UserId=(int)HttpContext.Session.GetInt32("id");
                    dbContext.Planes.Add(NewPlan);
                    dbContext.SaveChanges();

                    int newplanid=dbContext.Planes
                    .Select(p=>p.PlanId).Last();
                    return RedirectToAction("Dashboard",new{PlanId=newplanid});
                    
                }else{
                    return View("AddPlan");
                }
            }else{
                return RedirectToAction("Index");
            }
        }

        [HttpGet("new")]
        public IActionResult AddPlan()
        {
            if(HttpContext.Session.GetString("Name")!=null){
                return View();
            }else{
                return RedirectToAction("Index");
            }
        }
        ////////////////////
          [HttpGet("activity/{PlanId}")]
        public IActionResult Display_Plan_Detail(int PlanId)
        {
             if(HttpContext.Session.GetString("Name")!=null){
             
                List<Resevation> guest=dbContext.Resevationes
                .Include(r=>r.User)
                .Where(r=>r.PlanId==PlanId)
                .ToList();            
                

                Plan oneplan=dbContext.Planes
                .Include(p=>p.Creator)
                .Include(p=>p.Guests)
                .FirstOrDefault(w=>w.PlanId==PlanId);
                foreach(var x in oneplan.Guests)
                {
                    System.Console.WriteLine(x.UserId);
                }

                int userid=(int)HttpContext.Session.GetInt32("id");

                System.Console.WriteLine("List resevation:"+oneplan.Guests.Where(u=>u.UserId==userid).Count());
                Display_one_plan Display_one_plan=new Display_one_plan
                {
                    Guest=guest,
                    Oneplan=oneplan,
                    Userid=userid
                };

                return View(Display_one_plan);
            }else{
                return RedirectToAction("Index");
            }
        }



    }
}
