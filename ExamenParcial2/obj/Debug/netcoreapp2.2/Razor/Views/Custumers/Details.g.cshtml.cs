#pragma checksum "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ef532e8d4501e766cce3801f7bfb4d51d5a474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Custumers_Details), @"mvc.1.0.view", @"/Views/Custumers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Custumers/Details.cshtml", typeof(AspNetCore.Views_Custumers_Details))]
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
#line 1 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\_ViewImports.cshtml"
using ExamenParcial2;

#line default
#line hidden
#line 2 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\_ViewImports.cshtml"
using ExamenParcial2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ef532e8d4501e766cce3801f7bfb4d51d5a474", @"/Views/Custumers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e4009adf074b5a2aa6c4801c9a59e0fc7eaf67d", @"/Views/_ViewImports.cshtml")]
    public class Views_Custumers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamenParcial2.Models.Custumers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(85, 132, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Custumers</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(218, 48, false);
#line 14 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerTile));

#line default
#line hidden
            EndContext();
            BeginContext(266, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(330, 44, false);
#line 17 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerTile));

#line default
#line hidden
            EndContext();
            BeginContext(374, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(437, 53, false);
#line 20 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(490, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(554, 49, false);
#line 23 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(603, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(666, 52, false);
#line 26 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(718, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(782, 48, false);
#line 29 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(830, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(893, 47, false);
#line 32 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(940, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1004, 43, false);
#line 35 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1110, 57, false);
#line 38 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1231, 53, false);
#line 41 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1347, 55, false);
#line 44 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1466, 51, false);
#line 47 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1580, 59, false);
#line 50 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressSCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1703, 55, false);
#line 53 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressSCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1758, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1821, 61, false);
#line 56 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1946, 57, false);
#line 59 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2003, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2066, 56, false);
#line 62 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2122, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2186, 52, false);
#line 65 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2238, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2301, 53, false);
#line 68 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2354, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2418, 49, false);
#line 71 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2467, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2530, 57, false);
#line 74 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerMobibletPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2587, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2651, 53, false);
#line 77 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerMobibletPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2704, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2767, 55, false);
#line 80 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2822, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2886, 51, false);
#line 83 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
       Write(Html.DisplayFor(model => model.ContactEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2937, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2984, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50ef532e8d4501e766cce3801f7bfb4d51d5a47414686", async() => {
                BeginContext(3038, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 88 "c:\Users\mando\Documents\desappnet\ExamenParcial2\Views\Custumers\Details.cshtml"
                           WriteLiteral(Model.CustomerId);

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
            BeginContext(3046, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3054, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50ef532e8d4501e766cce3801f7bfb4d51d5a47417017", async() => {
                BeginContext(3076, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(3092, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamenParcial2.Models.Custumers> Html { get; private set; }
    }
}
#pragma warning restore 1591
