#pragma checksum "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b038c84681630d01f47284ea635ac36a021f5f02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\_ViewImports.cshtml"
using COVID19;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\_ViewImports.cshtml"
using COVID19.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b038c84681630d01f47284ea635ac36a021f5f02", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661781ad4aea6c045ade5d12be0eb520952815c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<COVID19.Models.ToDo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    
    h1{
        font-size: 56px;
        text-align: center;
        color: #111111;
        font-family: Arial Bold, Helvetica, sans-serif;
    }
    h2{
        font-size: 34px;
        text-align: start;
        color: #0C326F;
        font-family: Arial Bold, sans-serif;
    }
    .p{
        font-size: 20px;
        text-align: justify;
        color: #333333;
        font-family: Arial Bold, Helvetica, sans-serif;
    }
</style>

");
#nullable restore
#line 24 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "#FiqueEmCasa";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 27 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
 <br>
  <br>
  <h2>
       Mas o que fazer em casa?
  </h2>
<p class=""p"">
    As medidas de quarentena adotadas para conter o novo coronavírus, como fechamento do comércio
    e estímulo ao home office, deixaram milhões de brasileiros em casa.
    Tal situação pode gerar muita ansiedade e é bom poder se distrair. Por isso listamos aqui 
    algumas coisas que você pode fazer direto de sua casa.
</p>
<br>
<div id=""carouselExampleCaptions"" style= ""width: 60%;  margin-left: 10rem; margin-top: 2rem;"" class=""carousel slide"" data-ride=""carousel"">
  
  <div class=""carousel-inner"">
");
#nullable restore
#line 43 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
     for(var i=0; i< Model.Count(); i++){                
        if(i==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"carousel-item active\">    \r\n                <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1361, "\"", 1396, 1);
#nullable restore
#line 46 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
WriteAttributeValue("", 1367, Model.ElementAt(i).LinkImage, 1367, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>");
#nullable restore
#line 48 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
                   Write(Model.ElementAt(i).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <a href=\"https://localhost:5001/Home/Single\" class=\"secondary\" role=\"button\">Click for more</a>\r\n                    \r\n                </div>\r\n           </div>   \r\n");
#nullable restore
#line 53 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1824, "\"", 1859, 1);
#nullable restore
#line 55 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
WriteAttributeValue("", 1830, Model.ElementAt(i).LinkImage, 1830, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>");
#nullable restore
#line 57 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
                   Write(Model.ElementAt(i).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <a href=\"https://localhost:5001/Home/Single\" class=\"secondary\" role=\"button\">Click for more</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 61 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<COVID19.Models.ToDo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
