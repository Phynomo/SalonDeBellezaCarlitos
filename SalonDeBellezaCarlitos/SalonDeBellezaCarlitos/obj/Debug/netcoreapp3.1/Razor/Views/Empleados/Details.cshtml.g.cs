#pragma checksum "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bfc606c5bb978587d7abc4d52a23dbaa8b01a94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Details), @"mvc.1.0.view", @"/Views/Empleados/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bfc606c5bb978587d7abc4d52a23dbaa8b01a94", @"/Views/Empleados/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6f4560db9d7800b9d0fbbb243439c632f66939", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalonDeBellezaCarlitos.WebUI.Models.EmpleadoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Detalles</h1>\r\n\r\n\r\n");
            WriteLiteral("\r\n<div>\r\n    <h4 class=\"text-center\">Empleados</h4>\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5bfc606c5bb978587d7abc4d52a23dbaa8b01a945538", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 25 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.empl_Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                                      WriteLiteral(ViewBag.empl_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 28 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.empl_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label>");
#nullable restore
#line 29 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.empl_Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 32 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.empl_Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label>");
#nullable restore
#line 33 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.empl_Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 38 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.empl_Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label>");
#nullable restore
#line 39 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.empl_Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 42 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.sucu_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label>");
#nullable restore
#line 43 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.sucu_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">Departamento</label><br />\r\n            <label>");
#nullable restore
#line 49 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.depa_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">Municipio</label><br />\r\n            <label>");
#nullable restore
#line 53 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.muni_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">Estado civil</label><br />\r\n            <label>");
#nullable restore
#line 59 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.estc_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">Cargo</label><br />\r\n            <label>");
#nullable restore
#line 63 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.carg_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 68 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.empl_Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label>");
#nullable restore
#line 69 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.empl_Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 72 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.empl_CorreoElectronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label>");
#nullable restore
#line 73 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.empl_CorreoElectronico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 78 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.empl_FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label>");
#nullable restore
#line 79 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.empl_FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 82 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.empl_FechaContratacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label>");
#nullable restore
#line 83 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.empl_FechaContratacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 88 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.empl_DireccionExacta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label>");
#nullable restore
#line 89 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
              Write(ViewBag.empl_DireccionExacta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col d-flex justify-content-end\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bfc606c5bb978587d7abc4d52a23dbaa8b01a9417342", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                                                                WriteLiteral(ViewBag.empl_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bfc606c5bb978587d7abc4d52a23dbaa8b01a9419672", async() => {
                WriteLiteral("Regresar al listado");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
#line 117 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                       Write(ViewBag.UsuarioCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 118 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                       Write(ViewBag.FechaCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Modificado</td>\r\n                        <td>");
#nullable restore
#line 122 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                       Write(ViewBag.UsuarioModificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 123 "C:\Users\LAB01\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Empleados\Details.cshtml"
                       Write(ViewBag.FechaModificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SalonDeBellezaCarlitos.WebUI.Models.EmpleadoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
