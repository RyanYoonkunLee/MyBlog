#pragma checksum "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c12f34397d04d17fa3230f2013daaca5c1f9ce1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetail), @"mvc.1.0.view", @"/Views/Blog/BlogDetail.cshtml")]
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
#line 1 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\_ViewImports.cshtml"
using MyWebBlog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\_ViewImports.cshtml"
using MyWebBlog.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c12f34397d04d17fa3230f2013daaca5c1f9ce1a", @"/Views/Blog/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b27b7d6d3dacdd6444f0758d58eb085efde097", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWebBlog.ViewModel.BlogDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/BlogDetail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/prism.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("floatLeft"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/left.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 20px; height:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("floatRight"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/right.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:20px; height:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/prism.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
  
    ViewData["Title"] = "BlogDetail";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c12f34397d04d17fa3230f2013daaca5c1f9ce1a6900", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c12f34397d04d17fa3230f2013daaca5c1f9ce1a8014", async() => {
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
            WriteLiteral("\r\n<div>\r\n    <div class=\"title\">\r\n        <h6 class=\"titleDetail\">");
#nullable restore
#line 9 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
                           Write(Model.writer);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 9 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
                                           Write(Model.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h1>");
#nullable restore
#line 10 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
       Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"blogBody\">\r\n        ");
#nullable restore
#line 13 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
   Write(Html.Raw(Model.body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"recommendBox\">\r\n    <h3 class=\"textCenter\">Recommend</h3>\r\n    <div class=\"floatLeft\">\r\n");
#nullable restore
#line 20 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
         if (Model.previous.Title != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"recommendBoxArrowMargin\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c12f34397d04d17fa3230f2013daaca5c1f9ce1a10743", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h6 class=\"floatLeft\">Previous</h6>\r\n            </div>\r\n            <div>\r\n                <a");
            BeginWriteAttribute("href", " href=", 835, "", 906, 1);
#nullable restore
#line 27 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 841, Url.Action("BlogDetail", "Blog", new { id = Model.previous.Id }), 841, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 933, "\"", 964, 1);
#nullable restore
#line 28 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 939, Model.previous.Thumbnail, 939, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"imageFullSize\" />\r\n                    <div class=\"textDecorationNone\">");
#nullable restore
#line 29 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
                                               Write(Model.previous.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"floatRight giveWidth\">\r\n");
#nullable restore
#line 35 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
         if (Model.next.Title != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"recommendBoxArrowMargin\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c12f34397d04d17fa3230f2013daaca5c1f9ce1a13905", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h6 class=\"floatRight\">Next</h6>\r\n            </div>\r\n            <div>\r\n                <a");
            BeginWriteAttribute("href", " href=", 1489, "", 1556, 1);
#nullable restore
#line 42 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 1495, Url.Action("BlogDetail", "Blog", new { id = Model.next.Id }), 1495, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1583, "\"", 1610, 1);
#nullable restore
#line 43 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 1589, Model.next.Thumbnail, 1589, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"imageFullSize \" />\r\n                    <div class=\"textDecorationNone\">");
#nullable restore
#line 44 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
                                               Write(Model.next.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c12f34397d04d17fa3230f2013daaca5c1f9ce1a16702", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebBlog.ViewModel.BlogDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
