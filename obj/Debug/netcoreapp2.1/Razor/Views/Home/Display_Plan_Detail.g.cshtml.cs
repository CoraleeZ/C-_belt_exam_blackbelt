#pragma checksum "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "857a3a3cb781084934c05636f39e29a78e83f356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Display_Plan_Detail), @"mvc.1.0.view", @"/Views/Home/Display_Plan_Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Display_Plan_Detail.cshtml", typeof(AspNetCore.Views_Home_Display_Plan_Detail))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\_ViewImports.cshtml"
using belt_exam;

#line default
#line hidden
#line 2 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\_ViewImports.cshtml"
using belt_exam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"857a3a3cb781084934c05636f39e29a78e83f356", @"/Views/Home/Display_Plan_Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ede5520864f7369b9a1226860671520e8e6fbcf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Display_Plan_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Display_one_plan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 183, true);
            WriteLiteral("\r\n<h1 style=\"display:inline-block;\">Dojo Activity Center</h1>\r\n<a href=\"/home\" style=\"margin-left:40px;\">Home</a>\r\n<a href=\"/logout\" style=\"margin-left:40px;\">Logout</a>\r\n<hr>\r\n\r\n<h1>");
            EndContext();
            BeginContext(209, 19, false);
#line 8 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
Write(Model.Oneplan.Title);

#line default
#line hidden
            EndContext();
            BeginContext(228, 35, true);
            WriteLiteral("</h1>\r\n<br>\r\n<p>Event Coordinator: ");
            EndContext();
            BeginContext(264, 26, false);
#line 10 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
                 Write(Model.Oneplan.Creator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(290, 22, true);
            WriteLiteral("</p>\r\n<p>Description: ");
            EndContext();
            BeginContext(313, 25, false);
#line 11 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
           Write(Model.Oneplan.Description);

#line default
#line hidden
            EndContext();
            BeginContext(338, 62, true);
            WriteLiteral(" </p>\r\n<br>\r\n<p>Participants:</p>\r\n<div class=\"offset-sm-1\">\r\n");
            EndContext();
#line 15 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
      
        foreach(var x in @Model.Guest)
        {

#line default
#line hidden
            BeginContext(459, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(475, 11, false);
#line 18 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
          Write(x.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(486, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 19 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
        }
    

#line default
#line hidden
            BeginContext(510, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
            EndContext();
#line 24 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
 if(@Model.Oneplan.Creator.UserId==@Model.Userid){

#line default
#line hidden
            BeginContext(574, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 580, "\"", 618, 2);
            WriteAttributeValue("", 587, "/activity/", 587, 10, true);
#line 25 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
WriteAttributeValue("", 597, Model.Oneplan.PlanId, 597, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(619, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 26 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
}else{
    

#line default
#line hidden
#line 27 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
     if(@Model.Oneplan.Guests.Any(r=>r.UserId==@Model.Userid)){

#line default
#line hidden
            BeginContext(705, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 715, "\"", 752, 2);
            WriteAttributeValue("", 722, "/un-rsvp/", 722, 9, true);
#line 28 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
WriteAttributeValue("", 731, Model.Oneplan.PlanId, 731, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(753, 12, true);
            WriteLiteral(">Leave</a>\r\n");
            EndContext();
#line 29 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
    }else{

#line default
#line hidden
            BeginContext(777, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 787, "\"", 821, 2);
            WriteAttributeValue("", 794, "/rsvp/", 794, 6, true);
#line 30 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
WriteAttributeValue("", 800, Model.Oneplan.PlanId, 800, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(822, 11, true);
            WriteLiteral(">Join</a>\r\n");
            EndContext();
#line 31 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
    }

#line default
#line hidden
#line 31 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Display_Plan_Detail.cshtml"
     
}

#line default
#line hidden
            BeginContext(843, 4, true);
            WriteLiteral("\r\n  ");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Display_one_plan> Html { get; private set; }
    }
}
#pragma warning restore 1591