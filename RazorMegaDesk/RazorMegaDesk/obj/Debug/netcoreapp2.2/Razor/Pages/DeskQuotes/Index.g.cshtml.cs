#pragma checksum "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f83d4e624c1994f8214c5fcd239a8cad4ebf8c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorMegaDesk.Pages.DeskQuotes.Pages_DeskQuotes_Index), @"mvc.1.0.razor-page", @"/Pages/DeskQuotes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/DeskQuotes/Index.cshtml", typeof(RazorMegaDesk.Pages.DeskQuotes.Pages_DeskQuotes_Index), null)]
namespace RazorMegaDesk.Pages.DeskQuotes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\_ViewImports.cshtml"
using RazorMegaDesk;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f83d4e624c1994f8214c5fcd239a8cad4ebf8c1", @"/Pages/DeskQuotes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e94965409c5a913580e1c6ce614d411397ae60d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DeskQuotes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f83d4e624c1994f8214c5fcd239a8cad4ebf8c14694", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 61, false);
#line 17 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeskQuote[0].DeskMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(318, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(374, 57, false);
#line 20 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeskQuote[0].RushDays));

#line default
#line hidden
            EndContext();
            BeginContext(431, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(487, 61, false);
#line 23 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeskQuote[0].CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(548, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(604, 58, false);
#line 26 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeskQuote[0].QuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(662, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(718, 59, false);
#line 29 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeskQuote[0].QuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(777, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(833, 54, false);
#line 32 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeskQuote[0].Width));

#line default
#line hidden
            EndContext();
            BeginContext(887, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(943, 54, false);
#line 35 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeskQuote[0].Depth));

#line default
#line hidden
            EndContext();
            BeginContext(997, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1053, 64, false);
#line 38 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeskQuote[0].NumberOfDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
 foreach (var item in Model.DeskQuote) {

#line default
#line hidden
            BeginContext(1245, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1294, 47, false);
#line 47 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeskMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1397, 43, false);
#line 50 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RushDays));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1496, 47, false);
#line 53 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1599, 44, false);
#line 56 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1699, 45, false);
#line 59 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1800, 40, false);
#line 62 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Width));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1896, 40, false);
#line 65 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(1936, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1992, 50, false);
#line 68 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumberOfDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(2042, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2097, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f83d4e624c1994f8214c5fcd239a8cad4ebf8c113758", async() => {
                BeginContext(2142, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2150, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2170, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f83d4e624c1994f8214c5fcd239a8cad4ebf8c116125", async() => {
                BeginContext(2218, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2229, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2249, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f83d4e624c1994f8214c5fcd239a8cad4ebf8c118498", async() => {
                BeginContext(2296, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2306, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 76 "Z:\Visual Studio 2019 Projects\RazorMegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2345, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorMegaDesk.Pages.DeskQuotes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorMegaDesk.Pages.DeskQuotes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorMegaDesk.Pages.DeskQuotes.IndexModel>)PageContext?.ViewData;
        public RazorMegaDesk.Pages.DeskQuotes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591