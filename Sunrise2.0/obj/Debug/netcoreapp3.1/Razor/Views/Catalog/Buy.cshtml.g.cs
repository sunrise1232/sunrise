#pragma checksum "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45cc6a0828655bac713bb5ff3a498d9d831b5ab9"
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
#line 1 "D:\3333\SUNR1SE\Sunrise2.0\Views\_ViewImports.cshtml"
using Sunrise2._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\3333\SUNR1SE\Sunrise2.0\Views\_ViewImports.cshtml"
using Sunrise2._0.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
using Sunrise2._0.Storage.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45cc6a0828655bac713bb5ff3a498d9d831b5ab9", @"/Views/Catalog/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d7a57cff10fa8647bf5bbb3ec2b981f9db562fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tour>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/promo/hill.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/slider/slide1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
  
    ViewData["Title"] = Model.Hotel.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"tour\">\r\n    <div class=\"container\">\r\n        <div class=\"tour__dialog\">\r\n            <div class=\"tour__right\">\r\n                <div class=\"modalCarousel tour__carousel\">\r\n                    <div class=\"carousel__item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45cc6a0828655bac713bb5ff3a498d9d831b5ab95414", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                    <div class=\"carousel__item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45cc6a0828655bac713bb5ff3a498d9d831b5ab96584", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                    <div class=\"carousel__item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45cc6a0828655bac713bb5ff3a498d9d831b5ab97754", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"tour__title\">");
#nullable restore
#line 17 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                    Write(Model.Hotel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"tour__city\">");
#nullable restore
#line 18 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                   Write(Model.Hotel.Town.Region.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 18 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                                                  Write(Model.Hotel.Town.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"tour__descr\">");
#nullable restore
#line 19 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"tour__rating\">");
#nullable restore
#line 20 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                     Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"far fa-heart\"></i></div>\r\n                \r\n            </div>\r\n\r\n\r\n            <div class=\"tour__left\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45cc6a0828655bac713bb5ff3a498d9d831b5ab910431", async() => {
                WriteLiteral("\r\n\r\n                    <div class=\"tour__option\">\r\n                        <label>День:</label>\r\n                        <input type=\"date\"");
                BeginWriteAttribute("min", " min=\"", 1194, "\"", 1213, 1);
#nullable restore
#line 31 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
WriteAttributeValue("", 1200, DateTime.Now, 1200, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"DateDep\"");
                BeginWriteAttribute("value", " value=\"", 1229, "\"", 1237, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>

                    <div class=""tour__option"">
                        <label>Взрослых:</label>
                        <input type=""number"" name=""Adults"" value=""1"" />
                    </div>

                    <div class=""tour__option"">
                        <label>Детей:</label>
                        <input type=""number"" name=""Adults"" value=""0"" />
                    </div>

                    <div class=""tour__option"">
                        <label>Ночей:</label>
                        <input type=""number"" name=""Nights"" value=""1"" />
                    </div>

                    <div class=""tour__option"">
                        <label>Питание:</label>
                        <input type=""checkbox"" name=""Meals"" value=""1"" />
                    </div>

                    <div class=""tour__option"">
                        <label>Wi-fi:</label>
                        <input type=""checkbox"" name=""Wifi"" value=""1"" />
                    </d");
                WriteLiteral("iv>\r\n\r\n                    <select name=\"AirlineId\">\r\n");
#nullable restore
#line 60 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
                         foreach(var i in ViewBag.Airlines)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45cc6a0828655bac713bb5ff3a498d9d831b5ab912801", async() => {
#nullable restore
#line 62 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                             Write(i.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
                               WriteLiteral(i.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 62 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                                                  ;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n\r\n                    <input type=\"hidden\" name=\"TourId\"");
                BeginWriteAttribute("value", " value=\"", 2587, "\"", 2604, 1);
#nullable restore
#line 66 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
WriteAttributeValue("", 2595, Model.Id, 2595, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n\r\n                    <div class=\"tour__price\">");
#nullable restore
#line 68 "D:\3333\SUNR1SE\Sunrise2.0\Views\Catalog\Buy.cshtml"
                                        Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span>РУБ</span></div>\r\n\r\n                    <button type=\"submit\" class=\"button tour__button\">Заказать</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        <i class=\"fas fa-times modal__close\"></i>\r\n    </div>\r\n     </div>\r\n</div>");
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
