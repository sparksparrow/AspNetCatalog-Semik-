#pragma checksum "D:\C++ projects\GnomShop\Views\Products\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd65fa9e31b562a1f7198f316b678588b183fec2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Show), @"mvc.1.0.view", @"/Views/Products/Show.cshtml")]
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
#line 1 "D:\C++ projects\GnomShop\Views\_ViewImports.cshtml"
using GnomShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C++ projects\GnomShop\Views\_ViewImports.cshtml"
using GnomShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C++ projects\GnomShop\Views\_ViewImports.cshtml"
using GnomShop.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd65fa9e31b562a1f7198f316b678588b183fec2", @"/Views/Products/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30c8352211aafabe98317c98cea2a42a56b916e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductItem>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/DefaultImages/Soon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("В процессе добавления."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
  
    ViewBag.Title = Model.Title;
    ViewBag.Description = Model.MetaDescription;
    ViewBag.Keywords = Model.MetaKeywords;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1>\r\n        ");
#nullable restore
#line 10 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <div>\r\n");
#nullable restore
#line 13 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
         if (Model.Images.Any())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
             foreach (Image image in Model.Images)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd65fa9e31b562a1f7198f316b678588b183fec24850", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 355, "~/images/ProductItems/", 355, 22, true);
#nullable restore
#line 17 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
AddHtmlAttributeValue("", 377, image.ProductItemId, 377, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 397, "/", 397, 1, true);
#nullable restore
#line 17 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
AddHtmlAttributeValue("", 398, image.Name, 398, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
AddHtmlAttributeValue("", 416, image.Alt, 416, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd65fa9e31b562a1f7198f316b678588b183fec27380", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div>\r\n        <h4>");
#nullable restore
#line 26 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 27 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
         if (Model.Discount == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5>");
#nullable restore
#line 29 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 30 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <s>");
#nullable restore
#line 33 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</s>\r\n            <h5>");
#nullable restore
#line 34 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
           Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h6>Скидка ");
#nullable restore
#line 35 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
                  Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h6>\r\n");
#nullable restore
#line 36 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div>\r\n");
#nullable restore
#line 39 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
         if (Model.Sizes.Any())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
             foreach (Size size in Model.Sizes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 44 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
               Write(size.SizeValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 46 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 51 "D:\C++ projects\GnomShop\Views\Products\Show.cshtml"
Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
