#pragma checksum "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fedf05d435cac0d19683d2ef08e8aa7107ea9935"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fedf05d435cac0d19683d2ef08e8aa7107ea9935", @"/Views/Shared/MetatagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"569de12bf148dc5bfc624aaeb8d69c062d445b80", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
  
    EntityBase pageTitle = ViewBag.PageTitle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
 if (pageTitle != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
     if (pageTitle.Title != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <title>");
#nullable restore
#line 8 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
          Write(pageTitle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 9 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <title>");
#nullable restore
#line 12 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
          Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 13 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
     if (pageTitle.MetaDescription != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 324, "\"", 360, 1);
#nullable restore
#line 16 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 334, pageTitle.MetaDescription, 334, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 17 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
     if (pageTitle.MetaKeywords != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 449, "\"", 482, 1);
#nullable restore
#line 20 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 459, pageTitle.MetaKeywords, 459, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 21 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
     
}
else
{    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 25 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 26 "D:\C++ projects\AspNetCatalog-Semik-\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<meta charset=\"utf-8\">\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n");
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
