#pragma checksum "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Shared\NotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08f6971703bb6ff12568d192fbaecd79cab2cae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NotFound), @"mvc.1.0.view", @"/Views/Shared/NotFound.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/NotFound.cshtml", typeof(AspNetCore.Views_Shared_NotFound))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08f6971703bb6ff12568d192fbaecd79cab2cae2", @"/Views/Shared/NotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27042730e1dc485dd0a36906cbe3825301933ca6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_NotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Shared\NotFound.cshtml"
  
    ViewData["Title"] = "Não Encontrado!";

#line default
#line hidden
            BeginContext(51, 40, true);
            WriteLiteral("\r\n<header>\r\n    <h1 class=\"text-danger\">");
            EndContext();
            BeginContext(92, 17, false);
#line 6 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Shared\NotFound.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(109, 92, true);
            WriteLiteral("</h1>\r\n    <p class=\"text-danger\">A página que tentou acessar não existe :(</p>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
