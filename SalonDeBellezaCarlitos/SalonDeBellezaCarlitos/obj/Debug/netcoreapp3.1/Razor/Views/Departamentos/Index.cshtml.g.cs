#pragma checksum "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75fcdbf1ad31fab63846ca32c601008c822fc4cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamentos_Index), @"mvc.1.0.view", @"/Views/Departamentos/Index.cshtml")]
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
#line 1 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\_ViewImports.cshtml"
using SalonDeBellezaCarlitos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\_ViewImports.cshtml"
using SalonDeBellezaCarlitos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75fcdbf1ad31fab63846ca32c601008c822fc4cb", @"/Views/Departamentos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6f4560db9d7800b9d0fbbb243439c632f66939", @"/Views/_ViewImports.cshtml")]
    public class Views_Departamentos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalonDeBellezaCarlitos.WebUI.Models.DepartamentoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-top: 1.0%; font-size: 10px; height:25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/App/Salon/Departamentos.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 101, "\"", 123, 1);
#nullable restore
#line 3 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
WriteAttributeValue("", 109, ViewBag.Toast, 109, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"toast\" />\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row text-center"">
    <div class=""col"">
        <h1 class=""text-center"">LISTADO DEPARTAMENTOS</h1>
        <hr />
    </div>
</div>

<div class=""row mb-3 text-center"">
    <div class=""col"">
        <button class=""btn btn-primary"" onclick=""AbrirModalCreate()"">Agregar un Departamento</button>
    </div>
</div>
<table id=""example"" class=""table dataTable compact hover stripe"" style=""width: 100%;"" aria-describedby=""example_info"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 25 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.depa_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.depa_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-end\">\r\n                    <button style=\"padding-top: 1.0%; font-size: 10px; height:25px;\" type=\"button\" id=\"btnEditar\" class=\"btn btn-outline-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1478, "\"", 1560, 7);
            WriteAttributeValue("", 1488, "AbrirModalEdit(\'", 1488, 16, true);
#nullable restore
#line 44 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
WriteAttributeValue("", 1504, item.depa_Id, 1504, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1517, ",", 1517, 1, true);
#nullable restore
#line 44 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
WriteAttributeValue("", 1518, item.depa_Descripcion, 1518, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1540, ",", 1540, 1, true);
#nullable restore
#line 44 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
WriteAttributeValue("", 1541, item.depa_Codigo, 1541, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1558, "\')", 1558, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button> |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75fcdbf1ad31fab63846ca32c601008c822fc4cb9848", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
                                                                                                                                           WriteLiteral(item.depa_Id);

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
            WriteLiteral(" |\r\n                    <button style=\"padding-top: 1.0%; font-size: 10px; height:25px;\" type=\"button\" id=\"btnEliminar\" class=\"btn btn-outline-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1916, "\"", 1959, 3);
            WriteAttributeValue("", 1926, "AbrirModalDelete(\'", 1926, 18, true);
#nullable restore
#line 46 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
WriteAttributeValue("", 1944, item.depa_Id, 1944, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1957, "\')", 1957, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
#nullable restore
#line 54 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
Write(Html.Partial("_DepartamentosCreateViewPartial", new SalonDeBellezaCarlitos.WebUI.Models.DepartamentoViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
Write(Html.Partial("_DepartamentosEditViewPartial", new SalonDeBellezaCarlitos.WebUI.Models.DepartamentoViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\Auxiliar.Operaciones\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Departamentos\Index.cshtml"
Write(Html.Partial("_DepartamentosDeleteViewPartial", new SalonDeBellezaCarlitos.WebUI.Models.DepartamentoViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75fcdbf1ad31fab63846ca32c601008c822fc4cb14635", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalonDeBellezaCarlitos.WebUI.Models.DepartamentoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
