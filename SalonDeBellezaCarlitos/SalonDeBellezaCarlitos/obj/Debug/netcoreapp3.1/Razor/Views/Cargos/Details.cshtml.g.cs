#pragma checksum "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "340ea1abd21f3f98a09abbeef88ec241bc7aa4a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cargos_Details), @"mvc.1.0.view", @"/Views/Cargos/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340ea1abd21f3f98a09abbeef88ec241bc7aa4a1", @"/Views/Cargos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6f4560db9d7800b9d0fbbb243439c632f66939", @"/Views/_ViewImports.cshtml")]
    public class Views_Cargos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalonDeBellezaCarlitos.WebUI.Models.CargoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/App/Salon/Cargos.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
   ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Detalles</h1>\r\n");
#nullable restore
#line 7 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h4 class=\"text-center\">Cargos</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 15 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.carg_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label> ");
#nullable restore
#line 16 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
               Write(Html.DisplayFor(model => item.carg_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
        </div>
        <div class=""col"">
            <label class=""text-black font-weight-bold""></label><br />
            <label></label>
        </div>
    </div>


    <div class=""row"">
        <div class=""col d-flex justify-content-end"">
            <button class=""btn btn-warning mx-1"" type=""button"" id=""btnEditar""");
            BeginWriteAttribute("onclick", " onclick=\"", 875, "\"", 939, 5);
            WriteAttributeValue("", 885, "AbrirModalEdit(\'", 885, 16, true);
#nullable restore
#line 27 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
WriteAttributeValue("", 901, item.carg_Id, 901, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 914, ",", 914, 1, true);
#nullable restore
#line 27 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
WriteAttributeValue("", 915, item.carg_Descripcion, 915, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 937, "\')", 937, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button> \r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340ea1abd21f3f98a09abbeef88ec241bc7aa4a17437", async() => {
                WriteLiteral("Regresar al listado");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
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
#line 49 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
                       Write(ViewBag.UsuarioCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
                       Write(Html.DisplayFor(model => item.carg_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Modificado</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
                       Write(ViewBag.UsuarioModificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
                       Write(Html.DisplayFor(model => item.carg_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>            \r\n");
#nullable restore
#line 62 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 66 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Cargos\Details.cshtml"
Write(Html.Partial("_CargosEditViewPartial", new SalonDeBellezaCarlitos.WebUI.Models.CargoViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340ea1abd21f3f98a09abbeef88ec241bc7aa4a111622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalonDeBellezaCarlitos.WebUI.Models.CargoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
