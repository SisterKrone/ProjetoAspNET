#pragma checksum "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f426852fc52e5628f55e63c833a14cbe73a4713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Prevention), @"mvc.1.0.view", @"/Views/Home/Prevention.cshtml")]
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
#line 1 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\_ViewImports.cshtml"
using COVID19;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\_ViewImports.cshtml"
using COVID19.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f426852fc52e5628f55e63c833a14cbe73a4713", @"/Views/Home/Prevention.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661781ad4aea6c045ade5d12be0eb520952815c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Prevention : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<COVID19.Models.Tips>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml"
    Layout = "_Layout"; ViewBag.Title = "Dicas de Prevenção!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 6 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div id=\"carouselExampleCaptions\" style= \"width: 60%;  margin-left: 10rem; margin-top: 2rem;\" class=\"carousel slide\" data-ride=\"carousel\">\r\n  \r\n  <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 11 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml"
     for(var i=0; i< Model.Count(); i++){                
        if(i==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"carousel-item active\">    \r\n                <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 491, "\"", 526, 1);
#nullable restore
#line 14 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml"
WriteAttributeValue("", 497, Model.ElementAt(i).LinkImage, 497, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>");
#nullable restore
#line 16 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml"
                   Write(Model.ElementAt(i).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p>");
#nullable restore
#line 17 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml"
                  Write(Model.ElementAt(i).Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n           </div>   \r\n");
#nullable restore
#line 20 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml"
        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 871, "\"", 906, 1);
#nullable restore
#line 22 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml"
WriteAttributeValue("", 877, Model.ElementAt(i).LinkImage, 877, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>");
#nullable restore
#line 24 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml"
                   Write(Model.ElementAt(i).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p>");
#nullable restore
#line 25 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml"
                  Write(Model.ElementAt(i).Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\Hugo\Desktop\Projetos\ProjetoAspNET\COVID19\Views\Home\Prevention.cshtml"
        }          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    
  </div>
  <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Previous</span>
  </a>
  <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Next</span>
  </a>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<COVID19.Models.Tips>> Html { get; private set; }
    }
}
#pragma warning restore 1591
