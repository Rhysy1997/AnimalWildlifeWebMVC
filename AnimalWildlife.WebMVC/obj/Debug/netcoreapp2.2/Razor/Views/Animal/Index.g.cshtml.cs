#pragma checksum "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad3f173b3419760e277d2f193829c1d9ab17ed6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_Index), @"mvc.1.0.view", @"/Views/Animal/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animal/Index.cshtml", typeof(AspNetCore.Views_Animal_Index))]
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
#line 1 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\_ViewImports.cshtml"
using AnimalWildlife.WebMVC;

#line default
#line hidden
#line 2 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\_ViewImports.cshtml"
using AnimalWildlife.WebMVC.Models;

#line default
#line hidden
#line 2 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad3f173b3419760e277d2f193829c1d9ab17ed6a", @"/Views/Animal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d294b881597d57ec323092941953903916a2023", @"/Views/_ViewImports.cshtml")]
    public class Views_Animal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AnimalWildlife.Data.Animals.Animal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(151, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(194, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(223, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad3f173b3419760e277d2f193829c1d9ab17ed6a4127", async() => {
                BeginContext(246, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(260, 105, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n           \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(366, 40, false);
#line 19 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(406, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(462, 40, false);
#line 22 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(502, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(558, 41, false);
#line 25 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(599, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(655, 42, false);
#line 28 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(697, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(753, 39, false);
#line 31 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(792, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(848, 47, false);
#line 34 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(895, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(951, 41, false);
#line 37 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(992, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1127, 74, true);
            WriteLiteral("            <tr>\r\n            \r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1202, 39, false);
#line 48 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1309, 39, false);
#line 51 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1416, 40, false);
#line 54 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1524, 41, false);
#line 57 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1565, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1633, 38, false);
#line 60 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1739, 46, false);
#line 63 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 71, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1856, "\"", 1903, 1);
#line 66 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
WriteAttributeValue("", 1862, Html.DisplayFor(modelItem => item.Image), 1862, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1904, 124, true);
            WriteLiteral(" align=\"middle\" class=\"img-fluid\" alt=\"Responsive image\">\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2029, 53, false);
#line 69 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2082, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2107, 59, false);
#line 70 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2166, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2191, 57, false);
#line 71 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2248, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 74 "F:\Magee\Final year\Enterprise computing\AnimalWildlife\AnimalWildlife.WebMVC\Views\Animal\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2303, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AnimalWildlife.Data.Animals.Animal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
