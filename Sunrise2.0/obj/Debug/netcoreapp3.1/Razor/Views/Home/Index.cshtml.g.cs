#pragma checksum "C:\sunrise — копия\Sunrise2.0\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a5a83345e9abe2f637acf713408a52e6b70895d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\sunrise — копия\Sunrise2.0\Views\_ViewImports.cshtml"
using Sunrise2._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\sunrise — копия\Sunrise2.0\Views\_ViewImports.cshtml"
using Sunrise2._0.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\sunrise — копия\Sunrise2.0\Views\Home\Index.cshtml"
using Sunrise2._0.Storage.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a5a83345e9abe2f637acf713408a52e6b70895d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d7a57cff10fa8647bf5bbb3ec2b981f9db562fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tour>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Catalog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("carousel__item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\sunrise — копия\Sunrise2.0\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Sunrise";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""promo"">
    <div class=""container"">

        <div class=""promo__inner"">
            <div class=""promo__content"">
                <h1 class=""promo__title"">Лучшие туры по России</h1>
                <div class=""promo__descr"">
                    <p>Подарите себе незабывемое путешествие по городам России! Лучшие отели, популярные направления, горящие туры и не только. Спешите забронировать путевку.</p>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a5a83345e9abe2f637acf713408a52e6b70895d5294", async() => {
                WriteLiteral("Перейти в каталог");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

            <div class=""promo__images"">
                <img src=""img/promo/hill.png"" alt=""hill"">
                <img src=""img/promo/house.png"" alt=""house"">
                <img src=""img/promo/sun.png"" alt=""sun"">
                <img src=""img/promo/birds1.png"" alt=""birds"">
                <img src=""img/promo/birds2.png"" alt=""birds2"">
            </div>
        </div>

    </div>
</section>



<section id=""advantages"" class=""advantages"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-md-4"">
                <div class=""advantage"">
                    <div class=""advantage__img"">
                        <img src=""img/home/icon1.png""");
            BeginWriteAttribute("alt", " alt=\"", 1382, "\"", 1388, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""advantage__title"">Надежно</div>
                    <div class=""advantage__text"">
                        <p>В Sunrise работают профессионалы с многолетним опытом, которым вы можете доверить свой долгожданный отдых.</p>
                    </div>
                </div>
            </div>

            <div class=""col-md-4"">
                <div class=""advantage"">
                    <div class=""advantage__img"">
                        <img src=""img/home/icon2.png""");
            BeginWriteAttribute("alt", " alt=\"", 1929, "\"", 1935, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""advantage__title"">Выгодно</div>
                    <div class=""advantage__text"">
                        <p>Среди предложений Sunrise множество акций, которые помогут сделать ваш отдых наиболее выгодным.</p>
                    </div>
                </div>
            </div>

            <div class=""col-md-4"">
                <div class=""advantage"">
                    <div class=""advantage__img"">
                        <img src=""img/home/icon3.png""");
            BeginWriteAttribute("alt", " alt=\"", 2465, "\"", 2471, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>                        <div class=""advantage__title"">Большой выбор</div>
                    <div class=""advantage__text"">
                        <p>Sunrise предлагает туры на любой вкус: пляжные, экскурсионные, комбинированные, горнолыжные, корпоративные, элитные. </p>
                    </div>
                </div>
            </div>

        </div>
    </div>
</section>

<div id=""cases"" class=""service"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-lg-6"">
                <div class=""service__left"">
                    <h3 class=""service__title"">Испытай удачу</h3>
                    <div class=""service__descr"">Сделай свое путешествие по-настоящему незабываемым</div>
                </div>
            </div>

            <div class=""col-lg-6"">
                <div class=""service__right"">
                    <button class=""button"">Попробовать</button>
                    <div class=""service__img"">
                ");
            WriteLiteral("        <img src=\"img/home/icon4.png\" style=\"width: 130px\"");
            BeginWriteAttribute("alt", " alt=\"", 3554, "\"", 3560, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>




<section id=""popular-tours"" class=""popular-tours"">
    <div class=""container"">
        <div class=""popular-tours__title"">Популярные направления</div>

        <div class=""carousel popular-tours__carousel"">
");
#nullable restore
#line 110 "C:\sunrise — копия\Sunrise2.0\Views\Home\Index.cshtml"
             foreach (var i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a5a83345e9abe2f637acf713408a52e6b70895d10673", async() => {
                WriteLiteral("\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 4049, "\"", 4097, 1);
#nullable restore
#line 113 "C:\sunrise — копия\Sunrise2.0\Views\Home\Index.cshtml"
WriteAttributeValue("", 4055, Url.Action("GetImage", new { id = i.Id }), 4055, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"tour\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3995, "~/Catalog/Buy?TourId=", 3995, 21, true);
#nullable restore
#line 112 "C:\sunrise — копия\Sunrise2.0\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4016, i.Id, 4016, 5, false);

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
#line 115 "C:\sunrise — копия\Sunrise2.0\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tour>> Html { get; private set; }
    }
}
#pragma warning restore 1591
