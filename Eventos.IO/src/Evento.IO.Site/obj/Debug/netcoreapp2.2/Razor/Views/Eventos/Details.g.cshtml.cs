#pragma checksum "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b761220079296694501775edf8ae253a211999d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_Details), @"mvc.1.0.view", @"/Views/Eventos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/Details.cshtml", typeof(AspNetCore.Views_Eventos_Details))]
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
#line 1 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
using Eventos.IO.Application.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b761220079296694501775edf8ae253a211999d3", @"/Views/Eventos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27042730e1dc485dd0a36906cbe3825301933ca6", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
  
    ViewData["Title"] = @Model.Nome;

#line default
#line hidden
            BeginContext(113, 33, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h2>");
            EndContext();
            BeginContext(147, 17, false);
#line 8 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(164, 15, true);
            WriteLiteral("</h2>\r\n    <h4>");
            EndContext();
            BeginContext(180, 20, false);
#line 9 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
   Write(Model.DescricaoCurta);

#line default
#line hidden
            EndContext();
            BeginContext(200, 92, true);
            WriteLiteral("</h4>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div>\r\n        <div class=\"row\">\r\n            ");
            EndContext();
            BeginContext(293, 50, false);
#line 15 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
       Write(Html.DisplayFor(modelItem => Model.DescricaoLonga));

#line default
#line hidden
            EndContext();
            BeginContext(343, 123, true);
            WriteLiteral("\r\n        </div>\r\n        <hr />\r\n        <br />\r\n        <div class=\"row\">\r\n            <b>Quando:</b><br />\r\n            ");
            EndContext();
            BeginContext(467, 30, false);
#line 21 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
       Write(Model.DataInicio.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(497, 5, true);
            WriteLiteral(" até ");
            EndContext();
            BeginContext(503, 27, false);
#line 21 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
                                           Write(Model.DataFim.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(530, 94, true);
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <b>Valor:</b><br />\r\n");
            EndContext();
#line 26 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
              
                if (Model.Gratuito)
                {
                    

#line default
#line hidden
            BeginContext(717, 28, false);
#line 29 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayName("Gratuito"));

#line default
#line hidden
            EndContext();
#line 29 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
                                                 
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(828, 41, false);
#line 33 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Valor));

#line default
#line hidden
            EndContext();
#line 33 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
                                                              
                }
            

#line default
#line hidden
            BeginContext(905, 101, true);
            WriteLiteral("        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <b>Tipo de Evento:</b><br />\r\n");
            EndContext();
#line 40 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
              
                var categoria = new CategoriaViewModel().ListarCategorias().FirstOrDefault(c => c.Id == Model.CategoriaId);
                

#line default
#line hidden
            BeginContext(1164, 24, false);
#line 42 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
           Write(Html.Raw(categoria.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 113, true);
            WriteLiteral("        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <b>Organizado por:</b><br />\r\n            ");
            EndContext();
            BeginContext(1319, 47, false);
#line 48 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
       Write(Html.DisplayFor(modelItem => Model.NomeEmpresa));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 93, true);
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <b>Onde?</b><br />\r\n");
            EndContext();
#line 53 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
              
                if (Model.Online)
                {
                    

#line default
#line hidden
            BeginContext(1550, 33, false);
#line 56 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayName("Evento Online"));

#line default
#line hidden
            EndContext();
#line 56 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
                                                      
                }
                else
                {

#line default
#line hidden
            BeginContext(1645, 85, true);
            WriteLiteral("                    <iframe width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1730, "\"", 1851, 3);
            WriteAttributeValue("", 1736, "https://www.google.com/maps/embed/v1/place?q=", 1736, 45, true);
#line 60 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
WriteAttributeValue("", 1781, Model.Endereco.ToString(), 1781, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 1807, "&key=AIzaSyAP0WKpL7uTRHGKWyakgQXbW6FUhrrA5pE", 1807, 44, true);
            EndWriteAttribute();
            BeginContext(1852, 28, true);
            WriteLiteral(" allowfullscreen></iframe>\r\n");
            EndContext();
#line 61 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Details.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1914, 136, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div>\r\n        <a href=\"javascript:history.go(-1)\" class=\"btn btn-info\">Voltar</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591