#pragma checksum "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3abcd69e38541d27fd0e9533dc6af76e8e33df03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sucursal_Details), @"mvc.1.0.view", @"/Views/Sucursal/Details.cshtml")]
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
#line 1 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\_ViewImports.cshtml"
using SalonDeBellezaCarlitos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\_ViewImports.cshtml"
using SalonDeBellezaCarlitos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3abcd69e38541d27fd0e9533dc6af76e8e33df03", @"/Views/Sucursal/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f9bb711f94afd7a2306e49a75b072ee601889b", @"/Views/_ViewImports.cshtml")]
    public class Views_Sucursal_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalonDeBellezaCarlitos.WebUI.Models.VWSucursalesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/App/Salon/Sucursales.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
   ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 7 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"text-center\">Detalles</h1>\n");
            WriteLiteral(@"                <div>
                    <h4 class=""text-center"">Sucursales</h4>
                    <hr />

                    <div class=""row"">
                        <div class=""col"">
                            <label class=""text-black font-weight-bold"">");
#nullable restore
#line 18 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                                                  Write(Html.DisplayNameFor(model => item.sucu_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\n                            <label>");
#nullable restore
#line 19 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                              Write(Html.DisplayFor(model => item.sucu_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        </div>\n                        <div class=\"col\">\n                            <label class=\"text-black font-weight-bold\"> ");
#nullable restore
#line 22 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                                                   Write(Html.DisplayNameFor(model => item.sucu_DireccionExacta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\n                            <label>");
#nullable restore
#line 23 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                              Write(Html.DisplayFor(model => item.sucu_DireccionExacta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        </div>\n                    </div>\n                    <div class=\"row\">\n                        <div class=\"col\">\n                            <label class=\"text-black font-weight-bold\"> ");
#nullable restore
#line 28 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                                                   Write(Html.DisplayNameFor(model => item.depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\n                            <label>");
#nullable restore
#line 29 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                              Write(Html.DisplayFor(model => item.depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        </div>\n                        <div class=\"col\">\n                            <label class=\"text-black font-weight-bold\"> ");
#nullable restore
#line 32 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                                                   Write(Html.DisplayNameFor(model => item.muni_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\n                            <label>");
#nullable restore
#line 33 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                              Write(Html.DisplayFor(model => item.muni_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        </div>\n                    </div>\n\n                    <div class=\"row\">\n                        <div class=\"col d-flex justify-content-end\">\n                            <button  class=\"btn btn-warning btn-sm mx-1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1877, "\"", 1996, 11);
            WriteAttributeValue("", 1887, "AbrirModalEdit(\'", 1887, 16, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
WriteAttributeValue("", 1903, item.sucu_Descripcion, 1903, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1925, ",", 1925, 1, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
WriteAttributeValue("", 1926, item.depa_Id, 1926, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1939, ",", 1939, 1, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
WriteAttributeValue("", 1940, item.muni_Id, 1940, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1953, ",", 1953, 1, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
WriteAttributeValue("", 1954, item.sucu_DireccionExacta, 1954, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1980, ",", 1980, 1, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
WriteAttributeValue("", 1981, item.sucu_Id, 1981, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1994, "\')", 1994, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3abcd69e38541d27fd0e9533dc6af76e8e33df0311256", async() => {
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
#line 61 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                       Write(ViewBag.UsuarioCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 62 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                       Write(Html.DisplayFor(model => item.sucu_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    </tr>\n                                    <tr>\n                                        <td>Modificado</td>\n                                        <td>");
#nullable restore
#line 66 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                       Write(ViewBag.UsuarioModificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 67 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                       Write(Html.DisplayFor(model => item.sucu_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    </tr>\n                                </tbody>\n                            </table>\n                        </div>\n                    </div>\n\n\n                </div>");
#nullable restore
#line 75 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 78 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
Write(Html.Partial("_SucursalEditModalViewPartial", new SalonDeBellezaCarlitos.WebUI.Models.SucursalViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3abcd69e38541d27fd0e9533dc6af76e8e33df0315882", async() => {
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
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalonDeBellezaCarlitos.WebUI.Models.VWSucursalesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
