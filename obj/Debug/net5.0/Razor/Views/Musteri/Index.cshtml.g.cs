#pragma checksum "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297935b43716defde36a6c7a521c2e15149d549b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musteri_Index), @"mvc.1.0.view", @"/Views/Musteri/Index.cshtml")]
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
#line 1 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
using CagriHizmetleri.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"297935b43716defde36a6c7a521c2e15149d549b", @"/Views/Musteri/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d591fdb3f46b5c4c5401c7b6ed22fa5ab51811b", @"/Views/_ViewImports.cshtml")]
    public class Views_Musteri_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Musteriler>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Müşteriler Listesi</h2>\r\n<br />\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n\r\n        <th>ID</th>\r\n        <th>Ad</th>\r\n        <th>Soyad</th>\r\n        <th>Mail</th>\r\n        <th>Telefon</th>\r\n        <th>Sorun</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
           Write(x.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
           Write(x.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
           Write(x.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
           Write(x.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
           Write(x.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
           Write(x.Sorun);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            \r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 663, "\"", 688, 2);
            WriteAttributeValue("", 670, "/Musteri/Sil/", 670, 13, true);
#nullable restore
#line 31 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
WriteAttributeValue("", 683, x.ID, 683, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 740, "\"", 774, 2);
            WriteAttributeValue("", 747, "/Musteri/MusteriGetir/", 747, 22, true);
#nullable restore
#line 32 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
WriteAttributeValue("", 769, x.ID, 769, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a>\r\n               \r\n\r\n\r\n\r\n\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Musteri/Ekle/\" class=\"btn btn-primary\">Müşteri Ekle</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 963, "\"", 997, 1);
#nullable restore
#line 45 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\Index.cshtml"
WriteAttributeValue("", 970, Url.Action("Index","Home"), 970, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" style=\"color:#ffffff\">Ana Sayfa</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Musteriler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
