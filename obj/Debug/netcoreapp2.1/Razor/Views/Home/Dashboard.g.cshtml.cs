#pragma checksum "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c10759c5f336c5e39873a8e449d0b6fb8e47eef2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10759c5f336c5e39873a8e449d0b6fb8e47eef2", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ede5520864f7369b9a1226860671520e8e6fbcf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dashboard_wrapper>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 121, true);
            WriteLiteral("<h1 style=\"display:inline-block;\">Dojo Activity Center</h1>\r\n<p style=\"display:inline-block;margin-left:200px\"> Welcome, ");
            EndContext();
            BeginContext(148, 15, false);
#line 3 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                                                       Write(Model.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(163, 797, true);
            WriteLiteral(@" !</p>
<a href=""/logout"" style=""margin-left:40px;"">Logout</a>
<hr>
<center>
        <table class=""table table-striped col-sm-10 border"">

            <thead>
                <tr>
                    <th class='border-left border-right' scope=""col-2"">Activity</th>
                    <th class='border-left border-right' scope=""col-1"">Date and Time</th>
                    <th class='border-left border-right' scope=""col-1"">Duration</th>
                    <th class='border-left border-right' scope=""col-1"">Event Coordinator</th>
                    <th class='border-left border-right' scope=""col-1"">No. of Participants</th>
                    <th class='border-left border-right' scope=""col-1"">Actions</th>
                </tr>
            </thead>

            <tbody>

");
            EndContext();
#line 22 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
               foreach(var x in @Model.AllPlan){


#line default
#line hidden
            BeginContext(1012, 122, true);
            WriteLiteral("                    <tr>   \r\n                        <td class=\'border-left border-right\'>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1134, "\"", 1160, 2);
            WriteAttributeValue("", 1141, "/activity/", 1141, 10, true);
#line 26 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1151, x.PlanId, 1151, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1161, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1163, 7, false);
#line 26 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                                                     Write(x.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1170, 98, true);
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td class=\'border-left border-right\'>");
            EndContext();
            BeginContext(1269, 6, false);
#line 28 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                                                        Write(x.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1275, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1277, 2, true);
            WriteLiteral("@ ");
            EndContext();
            BeginContext(1280, 6, false);
#line 28 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                                                                   Write(x.Time);

#line default
#line hidden
            EndContext();
            BeginContext(1286, 68, true);
            WriteLiteral("</td>\r\n                        <td class=\'border-left border-right\'>");
            EndContext();
            BeginContext(1355, 10, false);
#line 29 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                                                        Write(x.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1365, 69, true);
            WriteLiteral("</td> \r\n                        <td class=\'border-left border-right\'>");
            EndContext();
            BeginContext(1435, 14, false);
#line 30 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                                                        Write(x.Creator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1449, 69, true);
            WriteLiteral("</td> \r\n                        <td class=\'border-left border-right\'>");
            EndContext();
            BeginContext(1519, 14, false);
#line 31 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                                                        Write(x.Guests.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1533, 89, true);
            WriteLiteral("</td> \r\n                \r\n                        <td class=\'border-left border-right\'>\r\n");
            EndContext();
#line 34 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                         if(x.UserId==@Model.User.UserId){

#line default
#line hidden
            BeginContext(1682, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1716, "\"", 1740, 2);
            WriteAttributeValue("", 1723, "/delete/", 1723, 8, true);
#line 35 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1731, x.PlanId, 1731, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1741, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 36 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                        }else{
                            

#line default
#line hidden
#line 37 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                             if(x.Guests.Any(r=>r.UserId==@Model.User.UserId)){

#line default
#line hidden
            BeginContext(1867, 38, true);
            WriteLiteral("                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1905, "\"", 1930, 2);
            WriteAttributeValue("", 1912, "/un-rsvp/", 1912, 9, true);
#line 38 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1921, x.PlanId, 1921, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1931, 12, true);
            WriteLiteral(">Leave</a>\r\n");
            EndContext();
#line 39 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                            }else{

#line default
#line hidden
            BeginContext(1979, 38, true);
            WriteLiteral("                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2017, "\"", 2039, 2);
            WriteAttributeValue("", 2024, "/rsvp/", 2024, 6, true);
#line 40 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2030, x.PlanId, 2030, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2040, 11, true);
            WriteLiteral(">Join</a>\r\n");
            EndContext();
#line 41 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                            }

#line default
#line hidden
#line 41 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                             
                        }

#line default
#line hidden
            BeginContext(2109, 59, true);
            WriteLiteral("                        </td> \r\n                    </tr>\r\n");
            EndContext();
#line 45 "C:\Users\little silver\Desktop\C#-stack\Asp.net\belt_exam\Views\Home\Dashboard.cshtml"
                }

#line default
#line hidden
            BeginContext(2187, 113, true);
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n    </center>\r\n    <button><a href=\"/new\">Add New Activity</a></button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dashboard_wrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
