#pragma checksum "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9681a410ae2d4a83735619c3c91c519a6929f7f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pagination_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pagination/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9681a410ae2d4a83735619c3c91c519a6929f7f3", @"/Views/Shared/Components/Pagination/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7e24eb1a6cbde786ff81dfbbfb9bc74915b034", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pagination_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Previous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n^");
#nullable restore
#line 3 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
    
    var prevDisable = Model.PageIndex == 1 ? "disabled" : "";
    var nextDisable = Model.PageIndex == (int)Model.TotalPages ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav>\r\n    <ul class=\"pagination pagination-rounded mb-0\">\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 253, "\"", 283, 2);
            WriteAttributeValue("", 261, "page-item", 261, 9, true);
#nullable restore
#line 10 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
WriteAttributeValue(" ", 270, prevDisable, 271, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9681a410ae2d4a83735619c3c91c519a6929f7f36315", async() => {
                WriteLiteral("\r\n                <span aria-hidden=\"true\">&laquo;</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                 WriteLiteral(Model.ReferenceAction);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageSize", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                             WriteLiteral(Model.PageSize);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                                    WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                                                                            WriteLiteral(Model.Query);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-query", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 15 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
         for (var i = 1; i < Model.TotalPages + 1; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9681a410ae2d4a83735619c3c91c519a6929f7f311710", async() => {
                WriteLiteral(" ");
#nullable restore
#line 19 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                                                                                                               Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                  WriteLiteral(Model.ReferenceAction);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageSize", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                              WriteLiteral(Model.PageSize);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                                                                    WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                                                                                         WriteLiteral(Model.Query);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-query", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9681a410ae2d4a83735619c3c91c519a6929f7f317431", async() => {
                WriteLiteral(" ");
#nullable restore
#line 23 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                                                                                                        Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                           WriteLiteral(Model.ReferenceAction);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageSize", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                       WriteLiteral(Model.PageSize);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                                                             WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                                                                                  WriteLiteral(Model.Query);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-query", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 24 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 1209, "\"", 1239, 2);
            WriteAttributeValue("", 1217, "page-item", 1217, 9, true);
#nullable restore
#line 27 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
WriteAttributeValue(" ", 1226, nextDisable, 1227, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9681a410ae2d4a83735619c3c91c519a6929f7f323614", async() => {
                WriteLiteral("\r\n                <span aria-hidden=\"true\">&raquo;</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                 WriteLiteral(Model.ReferenceAction);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageSize", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                             WriteLiteral(Model.PageSize);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                                    WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\GILBERTO\Gilberto\docs\NTT Data\trilha dev c#\exercicios\trilhaCSharp\MVC\WebSupplier\src\webApp\WebSupplier.WebApp\Views\Shared\Components\Pagination\Default.cshtml"
                                                                                                                                                            WriteLiteral(Model.Query);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-query", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>        \r\n    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591