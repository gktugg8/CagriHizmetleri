#pragma checksum "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c67f0bc7278c4a105cf43db4b3a91523a9126b38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cagri_Index), @"mvc.1.0.view", @"/Views/Cagri/Index.cshtml")]
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
#line 1 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\_ViewImports.cshtml"
using CagriHizmetleri;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\_ViewImports.cshtml"
using CagriHizmetleri.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c67f0bc7278c4a105cf43db4b3a91523a9126b38", @"/Views/Cagri/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d591fdb3f46b5c4c5401c7b6ed22fa5ab51811b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cagri_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CagriOperatorleri>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Müşterisi Olan Personel Listesi</h2>\r\n<br />\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n\r\n        <th>ID</th>\r\n        <th>Ad</th>\r\n        <th>Soyad</th>\r\n        <th>Musteri</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\Index.cshtml"
           Write(x.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\Index.cshtml"
           Write(x.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\Index.cshtml"
           Write(x.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\Index.cshtml"
           Write(x.musteri.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 538, "\"", 561, 2);
            WriteAttributeValue("", 545, "/Cagri/Sil/", 545, 11, true);
#nullable restore
#line 28 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\Index.cshtml"
WriteAttributeValue("", 556, x.ID, 556, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 613, "\"", 645, 2);
            WriteAttributeValue("", 620, "/Cagri/CalisanGetir/", 620, 20, true);
#nullable restore
#line 29 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\Index.cshtml"
WriteAttributeValue("", 640, x.ID, 640, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 703, "\"", 733, 2);
            WriteAttributeValue("", 710, "/Cagri/MusteriSec/", 710, 18, true);
#nullable restore
#line 30 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\Index.cshtml"
WriteAttributeValue("", 728, x.ID, 728, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\">Müşteri Ekle</a>\r\n\r\n\r\n\r\n\r\n\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Cagri/Ekle\" class=\"btn btn-primary\">Çalışan Ekle</a>\r\n<a href=\"/Cagri/MusteriYok\" class=\"btn btn-primary\">Müşterisi Olmayanları Listele</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CagriOperatorleri>> Html { get; private set; }
    }
}
#pragma warning restore 1591