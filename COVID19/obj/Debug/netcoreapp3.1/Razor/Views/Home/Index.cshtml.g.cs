#pragma checksum "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c48d84c08a64609db69d3c3d086de6266101256"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c48d84c08a64609db69d3c3d086de6266101256", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661781ad4aea6c045ade5d12be0eb520952815c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APIConsume.Models.Cases>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
   Layout = "_Layout"; ViewBag.Title = "Casos no Brasil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section");
            BeginWriteAttribute("class", " class=\"", 117, "\"", 125, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <header class=""d-flex justify-content-center"">
        <div class=""d-flex justify-content-start"">
            <img src=""https://image.flaticon.com/icons/svg/2585/2585189.svg"" alt=""Coronavirus"" class=""bg-warning rounded-pill"" style=""width: 200px; height: 200px; padding: 20px; position: absolute;"" />
            <div class=""bg-white rounded-pill"" style=""width: 100%; text-align: center; margin-left: 100px; margin-top: 25px;"">
                <h1 class=""font-weight-bolder text-primary"" style=""padding: 45px; margin-left: 60px; "">CORONAVÍRUS NO BRASIL</h1>
            </div>
        </div>
    </header>
    <div style=""margin: 100px 250px 250px 250px"">
                <div class=""bg-light d-flex bd-highlight mb-3 rounded-pill"">
                <h2 class=""font-weight-bolder text-primary align-self-center"" style=""margin-left: 50px"">CONFIRMADOS</h2>
                <div class=""bg-dark ml-auto p-2 bd-highlight rounded-pill"" style=""width: 35%; text-align: center;"">
                    <h4 class=""font-");
            WriteLiteral("weight-bolder ml-auto p-2 bd-highlight align-self-center text-white\" style=\"font-size: 24pt\">");
#nullable restore
#line 18 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
                                                                                                                            Write(Model.ElementAt(Model.Count()-1).Confirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>
            </div>

            <div class=""bg-light d-flex bd-highlight mb-3 rounded-pill"">
                <h2 class=""font-weight-bolder text-primary align-self-center"" style=""margin-left: 50px"">ÓBITOS</h2>
                <div class=""bg-danger ml-auto p-2 bd-highlight rounded-pill"" style=""width: 35%; text-align: center;"">
                    <h4 class=""font-weight-bolder ml-auto p-2 bd-highlight align-self-center text-white"" style=""font-size: 24pt"">");
#nullable restore
#line 25 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
                                                                                                                            Write(Model.ElementAt(Model.Count()-1).Deaths);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>
            </div>

            <div class=""bg-light d-flex bd-highlight mb-3 rounded-pill"">
                <h2 class=""font-weight-bolder text-primary align-self-center"" style=""margin-left: 50px"">DOENTES</h2>
                <div class=""bg-warning ml-auto p-2 bd-highlight rounded-pill"" style=""width: 35%; text-align: center;"">
                    <h4 class=""font-weight-bolder ml-auto p-2 bd-highlight align-self-center text-white"" style=""font-size: 24pt"">");
#nullable restore
#line 32 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
                                                                                                                            Write(Model.ElementAt(Model.Count()-1).Active);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>
            </div>

            <div class=""bg-light d-flex bd-highlight mb-3 rounded-pill"">
                <h2 class=""font-weight-bolder text-primary align-self-center"" style=""margin-left: 50px"">CURADOS</h2>
                <div class=""bg-success ml-auto p-2 bd-highlight rounded-pill"" style=""width: 35%; text-align: center;"">
                    <h4 class=""font-weight-bolder ml-auto p-2 bd-highlight align-self-center text-white"" style=""font-size: 24pt"">");
#nullable restore
#line 39 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
                                                                                                                            Write(Model.ElementAt(Model.Count()-1).Recovered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n            </div>\r\n            <p class=\"font-weight-bolder text-white\" style=\"text-align: center;\">Atualizado em: ");
#nullable restore
#line 42 "C:\Users\Roberto\Documents\ProjetoAspNET\COVID19\Views\Home\Index.cshtml"
                                                                                           Write(Model.ElementAt(Model.Count()-1).Date.Remove(10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<APIConsume.Models.Cases>> Html { get; private set; }
    }
}
#pragma warning restore 1591
