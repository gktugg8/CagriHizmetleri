#pragma checksum "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\MusteriGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ada23fe844a52e2909c32fd6807d72fbeac16986"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musteri_MusteriGetir), @"mvc.1.0.view", @"/Views/Musteri/MusteriGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ada23fe844a52e2909c32fd6807d72fbeac16986", @"/Views/Musteri/MusteriGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d591fdb3f46b5c4c5401c7b6ed22fa5ab51811b", @"/Views/_ViewImports.cshtml")]
    public class Views_Musteri_MusteriGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CagriHizmetleri.Models.Musteriler>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\MusteriGetir.cshtml"
  
    ViewData["Title"] = "MusteriGetir";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\MusteriGetir.cshtml"
 using (Html.BeginForm("Guncelle", "Musteri", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>ID:</b>\r\n");
#nullable restore
#line 10 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\MusteriGetir.cshtml"
Write(Html.TextBoxFor(x => x.ID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Adı:</b>\r\n");
#nullable restore
#line 13 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\MusteriGetir.cshtml"
Write(Html.TextBoxFor(x => x.Ad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Soyadı: </b>\r\n");
#nullable restore
#line 16 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\MusteriGetir.cshtml"
Write(Html.TextBoxFor(x => x.Soyad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Mail: </b>\r\n");
#nullable restore
#line 19 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\MusteriGetir.cshtml"
Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Telefon: </b>\r\n");
#nullable restore
#line 22 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\MusteriGetir.cshtml"
Write(Html.TextBoxFor(x => x.Telefon, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Sorun: </b>\r\n");
#nullable restore
#line 25 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\MusteriGetir.cshtml"
Write(Html.TextBoxFor(x => x.Sorun, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\MusteriGetir.cshtml"
                                                                   
    

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<button class=\"btn btn-info\">Kişiyi Güncelle</button>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 867, "\"", 904, 1);
#nullable restore
#line 31 "C:\Users\gktug\source\repos\CagriHizmetleri\Views\Musteri\MusteriGetir.cshtml"
WriteAttributeValue("", 874, Url.Action("Index","Musteri"), 874, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Geri Dön</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CagriHizmetleri.Models.Musteriler> Html { get; private set; }
    }
}
#pragma warning restore 1591
