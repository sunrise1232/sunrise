#pragma checksum "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30df35bff2c300622a4141a649a3766d2ad30329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_BuyResult), @"mvc.1.0.view", @"/Views/Catalog/BuyResult.cshtml")]
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
#line 1 "C:\sunrise\Sunrise2.0\Views\_ViewImports.cshtml"
using Sunrise2._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\sunrise\Sunrise2.0\Views\_ViewImports.cshtml"
using Sunrise2._0.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
using Sunrise2._0.Storage.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30df35bff2c300622a4141a649a3766d2ad30329", @"/Views/Catalog/BuyResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d7a57cff10fa8647bf5bbb3ec2b981f9db562fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_BuyResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
  
    ViewData["Title"] = Model.Tour.Hotel.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""buy-result"">
    <div class=""container"">
        <div class=""buy-result__wrapper"">
            <h3 class=""buy-result__title"">Ваш тур:</h3>
            <hr>
            <ul class=""buy-result__list"">
                <li>
                    <span class=""buy-result__key"">Email:</span>
                    <span class=""buy-result__value"">");
#nullable restore
#line 17 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Client.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Имя:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 21 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Client.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Фамилия:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 25 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Client.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Отчество:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 29 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Client.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n\r\n                <li>\r\n                    <span class=\"buy-result__key\">Регион:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 34 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Tour.Hotel.Town.Region.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Город:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 38 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Tour.Hotel.Town.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Отель:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 42 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Tour.Hotel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Авиакомпания:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 46 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Airline.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Дата вылета:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 50 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.DateDep.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Количество ночей:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 54 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Nights);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Количество взрослых:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 58 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Adults);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Количество детей:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 62 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Children);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Wi-fi:</span>\r\n                    <span class=\"buy-result__value\">\r\n");
#nullable restore
#line 67 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                         if (Model.Wifi == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>+</span>\r\n");
#nullable restore
#line 70 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>-</span>\r\n");
#nullable restore
#line 74 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Питание:</span>\r\n                    <span class=\"buy-result__value\">\r\n");
#nullable restore
#line 80 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                         if (Model.Meals == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>+</span>\r\n");
#nullable restore
#line 83 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>-</span>\r\n");
#nullable restore
#line 87 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Дата заказа:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 92 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li>\r\n                    <span class=\"buy-result__key\">Цена:</span>\r\n                    <span class=\"buy-result__value\">");
#nullable restore
#line 96 "C:\sunrise\Sunrise2.0\Views\Catalog\BuyResult.cshtml"
                                               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" руб.</span>\r\n                </li>\r\n\r\n\r\n            </ul>\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
