#pragma checksum "C:\Users\Derya\source\repos\Kutuphane_Projesi\Kutuphane_Projesi\Views\Home\YeniKitap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4e192f14e4c1202d589bdebf253576993045281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_YeniKitap), @"mvc.1.0.view", @"/Views/Home/YeniKitap.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4e192f14e4c1202d589bdebf253576993045281", @"/Views/Home/YeniKitap.cshtml")]
    public class Views_Home_YeniKitap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kutuphane_Projesi.Models.Kitap>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Derya\source\repos\Kutuphane_Projesi\Kutuphane_Projesi\Views\Home\YeniKitap.cshtml"
  
    ViewData["Title"] = "YeniKitap";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form class=\"form-select\" method=\"post\">\r\n    \r\n    <b>Kitap Adı</b>\r\n    <br />\r\n    ");
#nullable restore
#line 11 "C:\Users\Derya\source\repos\Kutuphane_Projesi\Kutuphane_Projesi\Views\Home\YeniKitap.cshtml"
Write(Html.TextBoxFor(x => x.KitapAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <b>Yazar</b>\r\n    <br />\r\n    ");
#nullable restore
#line 15 "C:\Users\Derya\source\repos\Kutuphane_Projesi\Kutuphane_Projesi\Views\Home\YeniKitap.cshtml"
Write(Html.TextBoxFor(x => x.Yazar, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <b>Türü</b>\r\n    <br />\r\n    ");
#nullable restore
#line 19 "C:\Users\Derya\source\repos\Kutuphane_Projesi\Kutuphane_Projesi\Views\Home\YeniKitap.cshtml"
Write(Html.TextBoxFor(x => x.Tur, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <b>Baskı Yılı</b>\r\n    <br />\r\n    ");
#nullable restore
#line 23 "C:\Users\Derya\source\repos\Kutuphane_Projesi\Kutuphane_Projesi\Views\Home\YeniKitap.cshtml"
Write(Html.TextBoxFor(x => x.BaskiYili, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <button class=\"btn btn-info\">Kitap Ekle</button>\r\n</form>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kutuphane_Projesi.Models.Kitap> Html { get; private set; }
    }
}
#pragma warning restore 1591
