#pragma checksum "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7614d46676c323fae33ddfadcd96c59bd672dd9"
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
#line 1 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\_ViewImports.cshtml"
using SalonDeBellezaCarlitos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\_ViewImports.cshtml"
using SalonDeBellezaCarlitos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7614d46676c323fae33ddfadcd96c59bd672dd9", @"/Views/Sucursal/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6f4560db9d7800b9d0fbbb243439c632f66939", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
   ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"text-center\">Detalles</h1>\r\n");
            WriteLiteral(@"                <div>
                    <h4 class=""text-center"">Sucursales</h4>
                    <hr />

                    <div class=""row"">
                        <div class=""col"">
                            <label class=""text-black font-weight-bold"">");
#nullable restore
#line 18 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                                                  Write(Html.DisplayNameFor(model => item.sucu_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                            <label>");
#nullable restore
#line 19 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                              Write(Html.DisplayFor(model => item.sucu_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col\">\r\n                            <label class=\"text-black font-weight-bold\"> ");
#nullable restore
#line 22 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                                                   Write(Html.DisplayNameFor(model => item.sucu_DireccionExacta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                            <label>");
#nullable restore
#line 23 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                              Write(Html.DisplayFor(model => item.sucu_DireccionExacta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col\">\r\n                            <label class=\"text-black font-weight-bold\"> ");
#nullable restore
#line 28 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                                                   Write(Html.DisplayNameFor(model => item.depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                            <label>");
#nullable restore
#line 29 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                              Write(Html.DisplayFor(model => item.depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col\">\r\n                            <label class=\"text-black font-weight-bold\"> ");
#nullable restore
#line 32 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                                                   Write(Html.DisplayNameFor(model => item.muni_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                            <label>");
#nullable restore
#line 33 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                              Write(Html.DisplayFor(model => item.muni_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col d-flex justify-content-end\">\r\n                            <button  class=\"btn btn-warning btn-sm mx-1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1915, "\"", 2034, 11);
            WriteAttributeValue("", 1925, "AbrirModalEdit(\'", 1925, 16, true);
#nullable restore
#line 39 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
WriteAttributeValue("", 1941, item.sucu_Descripcion, 1941, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1963, ",", 1963, 1, true);
#nullable restore
#line 39 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
WriteAttributeValue("", 1964, item.depa_Id, 1964, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1977, ",", 1977, 1, true);
#nullable restore
#line 39 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
WriteAttributeValue("", 1978, item.muni_Id, 1978, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1991, ",", 1991, 1, true);
#nullable restore
#line 39 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
WriteAttributeValue("", 1992, item.sucu_DireccionExacta, 1992, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2018, ",", 2018, 1, true);
#nullable restore
#line 39 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
WriteAttributeValue("", 2019, item.sucu_Id, 2019, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2032, "\')", 2032, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7614d46676c323fae33ddfadcd96c59bd672dd911318", async() => {
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
                        <div class=""card-header"" style=""background-color:#8e618d;"">
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
#line 61 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                       Write(ViewBag.UsuarioCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 62 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                       Write(Html.DisplayFor(model => item.sucu_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Modificado</td>\r\n                                        <td>");
#nullable restore
#line 66 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                       Write(ViewBag.UsuarioModificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 67 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                                       Write(Html.DisplayFor(model => item.sucu_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                </div>");
#nullable restore
#line 75 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 78 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Sucursal\Details.cshtml"
Write(Html.Partial("_SucursalEditModalViewPartial", new SalonDeBellezaCarlitos.WebUI.Models.SucursalViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7614d46676c323fae33ddfadcd96c59bd672dd916000", async() => {
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
            WriteLiteral("\r\n");
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
