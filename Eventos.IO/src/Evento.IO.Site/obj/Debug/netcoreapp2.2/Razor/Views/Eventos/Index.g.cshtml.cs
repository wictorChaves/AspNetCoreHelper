#pragma checksum "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9df99521c92c0d596f23d9cdf92dcd9e9e9ac95b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_Index), @"mvc.1.0.view", @"/Views/Eventos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/Index.cshtml", typeof(AspNetCore.Views_Eventos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df99521c92c0d596f23d9cdf92dcd9e9e9ac95b", @"/Views/Eventos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27042730e1dc485dd0a36906cbe3825301933ca6", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eventos.IO.Application.ViewModels.EventoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(125, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
  
    ViewData["Title"] = "Lista dos Próximos Eventos";

#line default
#line hidden
            BeginContext(189, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(196, 17, false);
#line 8 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(213, 91, true);
            WriteLiteral("</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(305, 40, false);
#line 13 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(345, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(401, 46, false);
#line 16 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(447, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(503, 43, false);
#line 19 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataFim));

#line default
#line hidden
            EndContext();
            BeginContext(546, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(602, 41, false);
#line 22 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(643, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(699, 42, false);
#line 25 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Online));

#line default
#line hidden
            EndContext();
            BeginContext(741, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(876, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(937, 39, false);
#line 35 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(976, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1044, 29, false);
#line 38 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
               Write(item.DataInicio.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1141, 26, false);
#line 41 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
               Write(item.DataFim.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 44 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
                      
                        if (item.Gratuito)
                        {
                            

#line default
#line hidden
            BeginContext(1338, 28, false);
#line 47 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
                       Write(Html.DisplayName("Gratuito"));

#line default
#line hidden
            EndContext();
#line 47 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
                                                         ;
                        }
                        else
                        {
                            

#line default
#line hidden
            BeginContext(1482, 40, false);
#line 51 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
#line 51 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
                                                                     ;
                        }
                    

#line default
#line hidden
            BeginContext(1575, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1641, 41, false);
#line 56 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Online));

#line default
#line hidden
            EndContext();
            BeginContext(1682, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1749, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df99521c92c0d596f23d9cdf92dcd9e9e9ac95b10606", async() => {
                BeginContext(1821, 110, true);
                WriteLiteral("\r\n                        <span class=\"glyphicons glyphicons-search\"></span>Ver Detalhes\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1935, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 64 "C:\Users\wictor\Documents\Wictor\Workspace\Github\Eventos.IO\src\Evento.IO.Site\Views\Eventos\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1990, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eventos.IO.Application.ViewModels.EventoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
