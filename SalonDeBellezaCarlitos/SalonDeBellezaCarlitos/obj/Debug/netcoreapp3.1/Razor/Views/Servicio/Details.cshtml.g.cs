#pragma checksum "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71ee62b49c1b8bdcc4a61f5ce4cca604d152dc8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicio_Details), @"mvc.1.0.view", @"/Views/Servicio/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71ee62b49c1b8bdcc4a61f5ce4cca604d152dc8f", @"/Views/Servicio/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6f4560db9d7800b9d0fbbb243439c632f66939", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicio_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalonDeBellezaCarlitos.WebUI.Models.ServicioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>tbServicios</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.serv_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.serv_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.serv_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.serv_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.serv_Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.serv_Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.serv_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.serv_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.serv_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.serv_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.serv_Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.serv_Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 56 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.serv_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label></label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 60 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.serv_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label></label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 66 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.serv_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label></label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 70 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.serv_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label></label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 76 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.serv_Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label></label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 80 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.serv_Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label></label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 86 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.serv_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label></label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 90 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.serv_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label></label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 96 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.serv_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label></label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 100 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.serv_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label></label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 106 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.serv_Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <label></label>\r\n        </div>\r\n        <div class=\"col\">\r\n            <label class=\"text-black font-weight-bold\">");
#nullable restore
#line 110 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.serv_Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label><br />
            <label></label>
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
#line 131 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                       Write(ViewBag.UsuarioCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 132 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                       Write(ViewBag.FechaCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Modificado</td>\r\n                        <td>");
#nullable restore
#line 136 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                       Write(ViewBag.UsuarioModificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 137 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                       Write(ViewBag.FechaModificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71ee62b49c1b8bdcc4a61f5ce4cca604d152dc8f17911", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 146 "C:\Users\LAB01.DESKTOP-36LBO8D\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Servicio\Details.cshtml"
                           WriteLiteral(Model.serv_Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71ee62b49c1b8bdcc4a61f5ce4cca604d152dc8f20127", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SalonDeBellezaCarlitos.WebUI.Models.ServicioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
