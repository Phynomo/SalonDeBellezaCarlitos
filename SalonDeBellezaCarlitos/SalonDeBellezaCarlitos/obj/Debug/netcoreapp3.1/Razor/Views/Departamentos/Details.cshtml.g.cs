#pragma checksum "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6489db8de19a448d4c28987af780a4e5076eba3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamentos_Details), @"mvc.1.0.view", @"/Views/Departamentos/Details.cshtml")]
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
#line 1 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\_ViewImports.cshtml"
using SalonDeBellezaCarlitos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\_ViewImports.cshtml"
using SalonDeBellezaCarlitos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6489db8de19a448d4c28987af780a4e5076eba3e", @"/Views/Departamentos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6f4560db9d7800b9d0fbbb243439c632f66939", @"/Views/_ViewImports.cshtml")]
    public class Views_Departamentos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalonDeBellezaCarlitos.WebUI.Models.DepartamentoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Details</h1>\r\n");
#nullable restore
#line 10 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h4>Departamentos</h4>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 17 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                                                      Write(Html.DisplayNameFor(model => model.depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                <label>");
#nullable restore
#line 18 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                  Write(Html.DisplayFor(model => item.depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col\">\r\n                <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 21 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                                                      Write(Html.DisplayNameFor(model => model.depa_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                <label>");
#nullable restore
#line 22 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                  Write(Html.DisplayFor(model => item.depa_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 27 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                                                      Write(Html.DisplayNameFor(model => model.depa_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                <label>");
#nullable restore
#line 28 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                  Write(Html.DisplayFor(model => item.depa_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col\">\r\n                <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 31 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                                                      Write(Html.DisplayNameFor(model => model.depa_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                <label>");
#nullable restore
#line 32 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                  Write(Html.DisplayFor(model => item.depa_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 37 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                                                      Write(Html.DisplayNameFor(model => model.depa_Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                <label>");
#nullable restore
#line 38 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                  Write(Html.DisplayFor(model => item.depa_Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
            </div>
        </div>

        <div class=""card mt-4"">
            <div class=""card-header"" style=""background-color:#2a0637;"">
                <h3 class=""text-white "">Auditoria</h3>
            </div>
            <div class=""card-body"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Accion</th>
                            <th>Usuario</th>
                            <th>Fecha</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Creado</td>
                            <td>");
#nullable restore
#line 58 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                           Write(ViewBag.UsuarioCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 59 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                           Write(ViewBag.FechaCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Modificado</td>\r\n                            <td>");
#nullable restore
#line 63 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                           Write(ViewBag.UsuarioModificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 64 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
                           Write(ViewBag.FechaModificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div>\r\n");
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6489db8de19a448d4c28987af780a4e5076eba3e11436", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 75 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalonDeBellezaCarlitos.WebUI.Models.DepartamentoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
