#pragma checksum "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\MusteriYok.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70fccce9f00efb3fda366c24db75376e697fac68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cagri_MusteriYok), @"mvc.1.0.view", @"/Views/Cagri/MusteriYok.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70fccce9f00efb3fda366c24db75376e697fac68", @"/Views/Cagri/MusteriYok.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d591fdb3f46b5c4c5401c7b6ed22fa5ab51811b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cagri_MusteriYok : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\MusteriYok.cshtml"
  
    ViewData["Title"] = "MusteriYok";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Müşterisi Olmayan Personel Listesi</h2>\r\n<br />\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n\r\n        <th>ID</th>\r\n        <th>Ad</th>\r\n        <th>Soyad</th>\r\n        <th>Musteri</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\MusteriYok.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\MusteriYok.cshtml"
           Write(x.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\MusteriYok.cshtml"
           Write(x.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\MusteriYok.cshtml"
           Write(x.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n\r\n\r\n\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 496, "\"", 519, 2);
            WriteAttributeValue("", 503, "/Cagri/Sil/", 503, 11, true);
#nullable restore
#line 29 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\MusteriYok.cshtml"
WriteAttributeValue("", 514, x.ID, 514, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 571, "\"", 603, 2);
            WriteAttributeValue("", 578, "/Cagri/CalisanGetir/", 578, 20, true);
#nullable restore
#line 30 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\MusteriYok.cshtml"
WriteAttributeValue("", 598, x.ID, 598, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 661, "\"", 691, 2);
            WriteAttributeValue("", 668, "/Cagri/MusteriSec/", 668, 18, true);
#nullable restore
#line 31 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\MusteriYok.cshtml"
WriteAttributeValue("", 686, x.ID, 686, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\">Müşteri Değiştir</a>\r\n\r\n\r\n\r\n\r\n\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\MusteriYok.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 804, "\"", 838, 1);
#nullable restore
#line 43 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Cagri\MusteriYok.cshtml"
WriteAttributeValue("", 811, Url.Action("Index","Home"), 811, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" style=\"color:#ffffff\">Vazgeç</a>\r\n\r\n");
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