#pragma checksum "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2a029450cc9e08c0f0ae556ea726ce519c63bab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facturas_Index), @"mvc.1.0.view", @"/Views/Facturas/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2a029450cc9e08c0f0ae556ea726ce519c63bab", @"/Views/Facturas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f9bb711f94afd7a2306e49a75b072ee601889b", @"/Views/_ViewImports.cshtml")]
    public class Views_Facturas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalonDeBellezaCarlitos.WebUI.Models.FacturasViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2a029450cc9e08c0f0ae556ea726ce519c63bab4857", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fact_Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fact_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fact_Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.clie_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 29 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.empl_Id_Atendido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 32 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.empl_Id_Caja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 35 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.metp_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 41 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 44 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fact_Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 47 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fact_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 50 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fact_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 53 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fact_Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 56 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.clie_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 59 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.empl_Id_Atendido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 62 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.empl_Id_Caja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 65 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.metp_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2a029450cc9e08c0f0ae556ea726ce519c63bab11928", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
                                       WriteLiteral(item.fact_Id);

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
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2a029450cc9e08c0f0ae556ea726ce519c63bab14146", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
                                          WriteLiteral(item.fact_Id);

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
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2a029450cc9e08c0f0ae556ea726ce519c63bab16370", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
                                         WriteLiteral(item.fact_Id);

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
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 73 "C:\Users\danie\Documents\GitHub\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\SalonDeBellezaCarlitos\Views\Facturas\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalonDeBellezaCarlitos.WebUI.Models.FacturasViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
