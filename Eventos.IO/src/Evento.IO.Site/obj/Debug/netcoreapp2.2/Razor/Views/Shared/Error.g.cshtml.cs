#pragma checksum "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e76d48edcde3f92013b7756984c25e783eabfc38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\_ViewImports.cshtml"
using Evento.IO.Site;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e76d48edcde3f92013b7756984c25e783eabfc38", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27042730e1dc485dd0a36906cbe3825301933ca6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Ocorreu um erro!";

#line default
#line hidden
            BeginContext(52, 26, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">");
            EndContext();
            BeginContext(79, 17, false);
#line 5 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Shared\Error.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(96, 101, true);
            WriteLiteral("</h1>\r\n<h2 class=\"text-danger\">Ocorreu um erro, tente novamente ou contate um administrador.</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Shared\Error.cshtml"
  
    if (ViewData["MensagemErro"] != null)
    {

#line default
#line hidden
            BeginContext(251, 48, true);
            WriteLiteral("        <br />\r\n        <h2 class=\"text-danger\">");
            EndContext();
            BeginContext(300, 24, false);
#line 12 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Shared\Error.cshtml"
                           Write(ViewData["MensagemErro"]);

#line default
#line hidden
            EndContext();
            BeginContext(324, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 13 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Shared\Error.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591