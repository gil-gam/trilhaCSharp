#pragma checksum "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe1ca07a237dc0c77c20c458184ed330e6001805"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_Index), @"mvc.1.0.view", @"/Views/Supplier/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe1ca07a237dc0c77c20c458184ed330e6001805", @"/Views/Supplier/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7e24eb1a6cbde786ff81dfbbfb9bc74915b034", @"/Views/_ViewImports.cshtml")]
    public class Views_Supplier_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginationViewModel<SupplierViewModel>>
    {
        private global::AspNetCore.Views_Supplier_Index.__Generated__PaginationViewComponentTagHelper __PaginationViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SupplierController", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
  
    ViewData["Title"] = "Suppliers";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<br />\n<br />\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1ca07a237dc0c77c20c458184ed330e60018059710", async() => {
                WriteLiteral("\n    <div class=\"form-row\">\n        <div class=\"form-group col-md-2\">\n            <select name=\"pageSize\" id=\"pageSize\"");
                BeginWriteAttribute("value", " value=\"", 325, "\"", 350, 1);
#nullable restore
#line 13 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
WriteAttributeValue("", 333, TempData["Size"], 333, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1ca07a237dc0c77c20c458184ed330e600180510581", async() => {
                    WriteLiteral("10");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1ca07a237dc0c77c20c458184ed330e600180511815", async() => {
                    WriteLiteral("50");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1ca07a237dc0c77c20c458184ed330e600180513049", async() => {
                    WriteLiteral("All");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
                   WriteLiteral(int.MaxValue);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </select>\n        </div>\n        <div class=\"form-group col-md-4\"></div>\n\n        <div class=\"form-group col-md-5\">\n            <input type=\"text\" class=\"form-control\" name=\"query\" id=\"query\"");
                BeginWriteAttribute("value", " value=\"", 730, "\"", 756, 1);
#nullable restore
#line 22 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
WriteAttributeValue("", 738, TempData["Query"], 738, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Search for Name, Cpf, E-mail\" />\n        </div>\n        <div class=\"form-group col-md-1\">\n            <button type=\"submit\" class=\"btn-primary\">Search</button>            \n        </div>\n\n");
#nullable restore
#line 28 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
         if (User.Identity.Name.Contains("@admin.com"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group col-md-1\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1ca07a237dc0c77c20c458184ed330e600180516069", async() => {
                    WriteLiteral("Add Supplier");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                <br />\n                <br />\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1ca07a237dc0c77c20c458184ed330e600180517444", async() => {
                    WriteLiteral("Report");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                <br />\n                <br />\n            </div>\n");
#nullable restore
#line 38 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        \n\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Fantasy Name</th>
            <th scope=""col"">CompanyName/Name</th>
            <th scope=""col"">Cnpj/Cpf</th>
            <th scope=""col"">Registration</th>
            <th scope=""col"">Actions</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 59 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
         foreach (var item in Model.List)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th>");
#nullable restore
#line 62 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
               Write(item.FantasyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 63 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
               Write(item.GetFullNameOrCompanyName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 64 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
               Write(item.GetCnpjOrCpf());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                \n                <td>");
#nullable restore
#line 65 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
               Write(item.InsertDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1ca07a237dc0c77c20c458184ed330e600180522752", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1ca07a237dc0c77c20c458184ed330e600180525072", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1ca07a237dc0c77c20c458184ed330e600180527401", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 72 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:pagination", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1ca07a237dc0c77c20c458184ed330e600180530045", async() => {
            }
            );
            __PaginationViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Supplier_Index.__Generated__PaginationViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PaginationViewComponentTagHelper);
#nullable restore
#line 76 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Supplier\Index.cshtml"
__PaginationViewComponentTagHelper.modelPagination = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model-pagination", __PaginationViewComponentTagHelper.modelPagination, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginationViewModel<SupplierViewModel>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:pagination")]
        public class __Generated__PaginationViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__PaginationViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public WebSupplier.WebApp.Models.IPageViewModel modelPagination { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Pagination", new { modelPagination });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
