#pragma checksum "/Users/admin/WebSecondCurs/sixthtask/Forth/Forth/Views/Home/ExplicitLoadingIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3f1a48831442f31b79ac1ed40a5f6a869bd1d61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ExplicitLoadingIndex), @"mvc.1.0.view", @"/Views/Home/ExplicitLoadingIndex.cshtml")]
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
#line 1 "/Users/admin/WebSecondCurs/sixthtask/Forth/Forth/Views/_ViewImports.cshtml"
using Forth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/WebSecondCurs/sixthtask/Forth/Forth/Views/_ViewImports.cshtml"
using Forth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3f1a48831442f31b79ac1ed40a5f6a869bd1d61", @"/Views/Home/ExplicitLoadingIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc6275c46bc3d6f4ab0d830a8dc4ab7cd3ca6bae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ExplicitLoadingIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/admin/WebSecondCurs/sixthtask/Forth/Forth/Views/Home/ExplicitLoadingIndex.cshtml"
  
    ViewData["Title"] = "Product Catalog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Explicit loading</h2>\n\n<table width=\"100%\" class=\"table table-striped table-bordered table-hover\">\n    <tr>\n        <th>Category</th>\n        <th>Amount</th>\n        <th>Brand</th>\n    </tr>\n    \n");
#nullable restore
#line 14 "/Users/admin/WebSecondCurs/sixthtask/Forth/Forth/Views/Home/ExplicitLoadingIndex.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 17 "/Users/admin/WebSecondCurs/sixthtask/Forth/Forth/Views/Home/ExplicitLoadingIndex.cshtml"
           Write(product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 18 "/Users/admin/WebSecondCurs/sixthtask/Forth/Forth/Views/Home/ExplicitLoadingIndex.cshtml"
           Write(product.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 19 "/Users/admin/WebSecondCurs/sixthtask/Forth/Forth/Views/Home/ExplicitLoadingIndex.cshtml"
           Write(product.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 21 "/Users/admin/WebSecondCurs/sixthtask/Forth/Forth/Views/Home/ExplicitLoadingIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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