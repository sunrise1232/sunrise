#pragma checksum "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2170aa42af35fe5b96d48d583a220067f557524"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Buy), @"mvc.1.0.view", @"/Views/Catalog/Buy.cshtml")]
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
#line 1 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
using Sunrise2._0.Storage.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2170aa42af35fe5b96d48d583a220067f557524", @"/Views/Catalog/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d7a57cff10fa8647bf5bbb3ec2b981f9db562fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tour>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Catalog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal__close"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tour.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
  
    ViewData["Title"] = Model.Hotel.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"tour\">\r\n    <div class=\"container\">\r\n        <div class=\"tour__dialog\">\r\n            <div class=\"tour__right\">\r\n                <div class=\"modalCarousel tour__carousel\">\r\n");
#nullable restore
#line 13 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                     foreach (var i in ViewBag.Images)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel__item\">\r\n                            ");
#nullable restore
#line 16 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                       Write(Html.Raw("<img src=\"data:image/jpeg;base64,"
                                + Convert.ToBase64String(i.Data) + "\" />"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 19 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"tour__title\">");
#nullable restore
#line 21 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                    Write(Model.Hotel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"tour__city\">");
#nullable restore
#line 22 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                   Write(Model.Hotel.Town.Region.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 22 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                                                  Write(Model.Hotel.Town.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"tour__descr\">");
#nullable restore
#line 23 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"tour__rating\">");
#nullable restore
#line 24 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                     Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"far fa-heart\"></i></div>\r\n\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"tour__left\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2170aa42af35fe5b96d48d583a220067f5575247575", async() => {
                WriteLiteral("\r\n\r\n                    <div class=\"tour__option\">\r\n                        <label for=\"date-dep\">День:</label>\r\n                        <input id=\"date-dep\" required type=\"date\"");
                BeginWriteAttribute("min", " min=\"", 1259, "\"", 1301, 1);
#nullable restore
#line 36 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
WriteAttributeValue("", 1265, DateTime.Now.ToString("yyyy-MM-dd"), 1265, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"DateDep\"");
                BeginWriteAttribute("value", " value=\"", 1317, "\"", 1325, 0);
                EndWriteAttribute();
                WriteLiteral(@" />

                    </div>

                    <div class=""tour__option"">
                        <label for=""nights"">Ночей:</label>
                        <input id=""nights"" type=""number"" min=""1"" max=""30"" name=""Nights"" value=""1"" />
                    </div>

                    <div class=""tour__option"">
                        <label for=""adults"">Взрослых:</label>
                        <input id=""adults"" type=""number"" min=""1"" max=""30"" name=""Adults"" value=""1"" />
                    </div>

                    <div class=""tour__option"">
                        <label for=""children"">Детей:</label>
                        <input id=""children"" type=""number"" min=""0"" max=""30"" name=""Children"" value=""0"" />
                    </div>





                    <div class=""tour__option"">
                        <input id=""meals"" name=""Meals"" type=""checkbox"" value=""true"" />
                        <input name=""Meals"" type=""hidden"" value=""false"" />
                        <label for=""me");
                WriteLiteral(@"als"">
                            Питание:
                            <div>
                                <i class=""fas fa-check""></i>
                            </div>
                        </label>

                    </div>



                    <div class=""tour__option"">
                        <input id=""wifi"" name=""Wifi"" type=""checkbox"" value=""true"" />
                        <input name=""Wifi"" type=""hidden"" value=""false"" />
                        <label for=""wifi"">
                            Wi-fi:
                            <div>
                                <i class=""fas fa-check""></i>
                            </div>
                        </label>
                    </div>



                    <div class=""tour__option"" name=""AirlineId"">
                        <span>Авиакомпания:</span>

");
#nullable restore
#line 89 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                         foreach (var i in ViewBag.Airlines)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"tour__radio\">\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3404, "\"", 3430, 1);
#nullable restore
#line 92 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
WriteAttributeValue("", 3412, i.PriceMultiplier, 3412, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input required name=\"AirlineId\"");
                BeginWriteAttribute("id", " id=\"", 3498, "\"", 3510, 1);
#nullable restore
#line 93 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
WriteAttributeValue("", 3503, i.Name, 3503, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("value", " value=\"", 3524, "\"", 3537, 1);
#nullable restore
#line 93 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
WriteAttributeValue("", 3532, i.Id, 3532, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <label");
                BeginWriteAttribute("for", " for=\"", 3579, "\"", 3592, 1);
#nullable restore
#line 94 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
WriteAttributeValue("", 3585, i.Name, 3585, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 94 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                                Write(i.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                            </span>\r\n");
#nullable restore
#line 96 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div>\r\n\r\n\r\n\r\n                    <input type=\"hidden\" name=\"TourId\"");
                BeginWriteAttribute("value", " value=\"", 3767, "\"", 3784, 1);
#nullable restore
#line 103 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
WriteAttributeValue("", 3775, Model.Id, 3775, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" id=\"tour-price\"");
                BeginWriteAttribute("value", " value=\"", 3846, "\"", 3866, 1);
#nullable restore
#line 104 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
WriteAttributeValue("", 3854, Model.Price, 3854, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                    <div class=\"tour__price\">\r\n                        <div>");
#nullable restore
#line 107 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
                        Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <span>РУБ</span>\r\n                        <input type=\"hidden\" name=\"Price\"");
                BeginWriteAttribute("value", " value=\"", 4069, "\"", 4089, 1);
#nullable restore
#line 109 "C:\sunrise\Sunrise2.0\Views\Catalog\Buy.cshtml"
WriteAttributeValue("", 4077, Model.Price, 4077, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n\r\n                    <button type=\"submit\" class=\"button tour__button\">Заказать</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2170aa42af35fe5b96d48d583a220067f55752415876", async() => {
                WriteLiteral("<i class=\"fas fa-times\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2170aa42af35fe5b96d48d583a220067f55752417105", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tour> Html { get; private set; }
    }
}
#pragma warning restore 1591
