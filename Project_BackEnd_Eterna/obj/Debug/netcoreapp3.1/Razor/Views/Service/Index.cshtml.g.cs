#pragma checksum "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6c5b1fd99c3f833f7d87bb9cd1123b22504f52c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\_ViewImports.cshtml"
using Project_BackEnd_Eterna.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\_ViewImports.cshtml"
using Project_BackEnd_Eterna.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6c5b1fd99c3f833f7d87bb9cd1123b22504f52c", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3cf928e4a08b5a8a7c423c32ba8799d3540ec48", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<main>\r\n        <section id=\"cards\">\r\n            <div class=\"container\">\r\n                <div class=\"row mt-5\">\r\n");
#nullable restore
#line 12 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                  foreach (Cart cart in Model.Carts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <div class=\"col-lg-4 col-md-6 col-sm-12\">\r\n                    <div class=\"box mt-4\">\r\n                        <div class=\"basket mt-5\">\r\n                            <div class=\"icon\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 492, "\"", 510, 1);
#nullable restore
#line 18 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
WriteAttributeValue("", 500, cart.Icon, 500, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>                              \r\n                            </div>                          \r\n                           <div class=\"title mt-4\">\r\n                            <h2>");
#nullable restore
#line 21 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                           Write(cart.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                           </div>\r\n                           <div class=\"text mt-2\">\r\n                            <p>");
#nullable restore
#line 24 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                          Write(cart.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                           </div>        \r\n                        </div>\r\n                    </div>\r\n                  </div>\n");
#nullable restore
#line 29 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

                
            </div>
        </section>


        <section id=""skills"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""our mt-5"">
                        <h4>
                            ");
#nullable restore
#line 43 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                       Write(Model.Statistics.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("             \r\n                        </h4>\r\n                         <div class=\"xet d-flex justify-content-center\">\r\n                            <hr >\r\n                           </div>\r\n                        <p>\r\n                            ");
#nullable restore
#line 49 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                       Write(Model.Statistics.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>
            </div>
        </section>
          
        
        <section id=""progres-bar"" >
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""images"">
                         <img src=""./assets/img/skills-img.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1997, "\"", 2003, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                     </div>\r\n \r\n                     <div class=\"col-lg-6 progre\">\r\n \r\n                         <div class=\"title \">\r\n                             <h2>\r\n                                 ");
#nullable restore
#line 70 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                            Write(Model.Statistics.MainText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                             </h2>\r\n \r\n                             <i>");
#nullable restore
#line 73 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                           Write(Model.Statistics.AnotherText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</i>
                         </div>
                      
                         <div class=""progress"">
                             <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"">
                             ");
#nullable restore
#line 78 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                        Write(layoutservice.GetDatas().Result.FirstOrDefault(p=>p.Key.ToLower().Trim() == "html").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%
                             </div>
                           </div>
                           <span>HTML</span>
                           <div class=""progress"">
                             <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 90%"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""> ");
#nullable restore
#line 83 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                                                                                                                                                            Write(layoutservice.GetDatas().Result.FirstOrDefault(p=>p.Key.ToLower().Trim() == "css").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</div>
                           </div>
                           <span>CSS</span>
                           <div class=""progress"">
                             <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""> ");
#nullable restore
#line 87 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                                                                                                                                                            Write(layoutservice.GetDatas().Result.FirstOrDefault(p=>p.Key.ToLower().Trim() == "javascript").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</div>
                           </div>
                           <span>JAVASCRIPT</span>
                           <div class=""progress"">
                             <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 55%"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""> ");
#nullable restore
#line 91 "C:\Users\Ali\source\repos\Project_BackEnd_Eterna\Project_BackEnd_Eterna\Views\Service\Index.cshtml"
                                                                                                                                                            Write(layoutservice.GetDatas().Result.FirstOrDefault(p=>p.Key.ToLower().Trim() == "photoshop").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</div>
                           </div>
                           <span>PHOTOSHOP</span>
                     </div>
                
                </div>
            </div>
        </section>
                
                   
          

        <section id=""newsletter"">
          <div class=""container"">
            <div class=""row"">
                <div class=""email mt-5 d-flex justify-content-between"">
                    <div class=""title m-5  "">
                        <h2>Our Newsletter</h2>  
                        <p>Tamen quem nulla quae legam multos aute sint culpa legam noster magna</p>            
                    </div>
                    <div class=""search mt-5"">
                        <form");
            BeginWriteAttribute("action", " action=\"", 4735, "\"", 4744, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"email\"");
            BeginWriteAttribute("name", " name=\"", 4795, "\"", 4802, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4803, "\"", 4808, 0);
            EndWriteAttribute();
            WriteLiteral("> <button class=\"btn btn-danger \">Subscribe</button>\r\n                        </form> \r\n                    </div>\r\n                </div>\r\n            </div>\r\n          </div>\r\n        </section>\r\n\r\n    </main>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Project_BackEnd_Eterna.Services.LayoutService layoutservice { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
