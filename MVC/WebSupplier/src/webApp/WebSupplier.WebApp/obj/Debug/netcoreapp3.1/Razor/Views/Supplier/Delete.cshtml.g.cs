#pragma checksum "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59942e2022ef2f664ae001d2f2329ba4b219f2d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_Delete), @"mvc.1.0.view", @"/Views/Supplier/Delete.cshtml")]
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
#line 1 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\_ViewImports.cshtml"
using WebSupplier.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\_ViewImports.cshtml"
using WebSupplier.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\_ViewImports.cshtml"
using WebSupplier.WebApp.Models.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\_ViewImports.cshtml"
using WebSupplier.WebApp.Models.Supplier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\_ViewImports.cshtml"
using WebSupplier.WebApp.Models.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59942e2022ef2f664ae001d2f2329ba4b219f2d4", @"/Views/Supplier/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7e24eb1a6cbde786ff81dfbbfb9bc74915b034", @"/Views/_ViewImports.cshtml")]
    public class Views_Supplier_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SupplierViewModel>
    {
        private global::AspNetCore.Views_Supplier_Delete.__Generated__SummaryViewComponentTagHelper __SummaryViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
   ViewData["Title"] = "Delete Supplier: " + @Model.FantasyName; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 4 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<br />\n<br />\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:summary", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59942e2022ef2f664ae001d2f2329ba4b219f2d46817", async() => {
            }
            );
            __SummaryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Supplier_Delete.__Generated__SummaryViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__SummaryViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<table>\n    <tr>\n        <td>Person : </td>\n        <td><label>");
#nullable restore
#line 12 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
              Write(Model.PersonType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\n    </tr>\n    <tr>\n        <td>Fantasy Name : </td>\n        <td><label>");
#nullable restore
#line 16 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
              Write(Model.FantasyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\n    </tr>\n\n");
#nullable restore
#line 19 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
     if (Model.PersonType == SupplierViewModel.Physical)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n    <td>Name : </td>\n    <td><label>");
#nullable restore
#line 23 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
          Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\n    </tr>\n        <tr>\n            <td>Cpf : </td>\n            <td><label>");
#nullable restore
#line 27 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
                  Write(Model.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\n        </tr>\n        <tr>\n            <td>Birthdate : </td>\n            <td><label>");
#nullable restore
#line 31 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
                  Write(Model.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\n        </tr> ");
#nullable restore
#line 32 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
              }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>Company Name : </td>\n            <td><label>");
#nullable restore
#line 37 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
                  Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\n        </tr>\n        <tr>\n            <td>Cnpj : </td>\n            <td><label>");
#nullable restore
#line 41 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
                  Write(Model.Cnpj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\n        </tr>\n        <tr>\n            <td>Open date : </td>\n            <td><label>");
#nullable restore
#line 45 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
                  Write(Model.OpenDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\n        </tr>\n");
#nullable restore
#line 47 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <tr>\n        <td>Cellphone : </td>\n        <td><label>");
#nullable restore
#line 52 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
              Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\n    </tr>    \n    <tr>\n        <td>Address : </td>\n        <td><label>");
#nullable restore
#line 56 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
              Write(Model.Address?.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\n    </tr>\n</table>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59942e2022ef2f664ae001d2f2329ba4b219f2d412549", async() => {
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59942e2022ef2f664ae001d2f2329ba4b219f2d412812", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 61 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59942e2022ef2f664ae001d2f2329ba4b219f2d414652", async() => {
                    WriteLiteral("Back to the list");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SupplierViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:summary")]
        public class __Generated__SummaryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__SummaryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Summary", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
