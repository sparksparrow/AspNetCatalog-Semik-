#pragma checksum "D:\C++ projects\AspNetCatalog-Semik-\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8f2e72b99dc23f7c3251065a06476b17ba249fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "D:\C++ projects\AspNetCatalog-Semik-\Views\_ViewImports.cshtml"
using GnomShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C++ projects\AspNetCatalog-Semik-\Views\_ViewImports.cshtml"
using GnomShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C++ projects\AspNetCatalog-Semik-\Views\_ViewImports.cshtml"
using GnomShop.Models.DbEntities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C++ projects\AspNetCatalog-Semik-\Views\_ViewImports.cshtml"
using GnomShop.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8f2e72b99dc23f7c3251065a06476b17ba249fb", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"569de12bf148dc5bfc624aaeb8d69c062d445b80", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/About/AboutImage.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("О Нас"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section class=""bg-success py-5"">
    <div class=""container"">
        <div class=""row align-items-center py-5"">
            <div class=""col-md-8 text-white"">
                <h1 style=""font-size: 600%;"">О нас</h1>
                <h1>
                    Мы - фабричный производитель, отшиваем женскую одежду больших размеров в Италии, Турции и Китае. 
                    Разработка моделей производится нашими дизайнерами, все фото соответствуют действительности.
                </h1>                
            </div>
            <div class=""col-md-4"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8f2e72b99dc23f7c3251065a06476b17ba249fb4688", async() => {
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
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>
<section class=""container py-5"">
    <div class=""row text-center pt-5 pb-3"">
        <div class=""col-lg-6 m-auto"">
            <h1 class=""h1"">Наши сервисы</h1>
            <p>
                Нам доверяют
            </p>
        </div>
    </div>
    <div class=""row"">

        <div class=""col-md-6 col-lg-3 pb-5"">
            <div class=""h-100 py-5 services-icon-wap shadow"">
                <div class=""h1 text-success text-center""><i class=""fa fa-truck fa-lg""></i></div>
                <h2 class=""h5 mt-4 text-center"">Доставка</h2>
            </div>
        </div>

        <div class=""col-md-6 col-lg-3 pb-5"">
            <div class=""h-100 py-5 services-icon-wap shadow"">
                <div class=""h1 text-success text-center""><i class=""fas fa-exchange-alt""></i></div>
                <h2 class=""h5 mt-4 text-center"">Возврат</h2>
            </div>
        </div>

        <div class=""col-md-6 col-lg-3 pb-5"">
            <div ");
            WriteLiteral(@"class=""h-100 py-5 services-icon-wap shadow"">
                <div class=""h1 text-success text-center""><i class=""fa fa-percent""></i></div>
                <h2 class=""h5 mt-4 text-center"">Акции и скидки</h2>
            </div>
        </div>

        <div class=""col-md-6 col-lg-3 pb-5"">
            <div class=""h-100 py-5 services-icon-wap shadow"">
                <div class=""h1 text-success text-center""><i class=""fa fa-user""></i></div>
                <h2 class=""h5 mt-4 text-center"">Всегда на связи</h2>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
