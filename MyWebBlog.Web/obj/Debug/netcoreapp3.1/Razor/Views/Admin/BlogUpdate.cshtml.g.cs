#pragma checksum "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\Admin\BlogUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc9c2470f41c65c0d73b13ab9a7d9e16a9331569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BlogUpdate), @"mvc.1.0.view", @"/Views/Admin/BlogUpdate.cshtml")]
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
#line 1 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\_ViewImports.cshtml"
using MyWebBlog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\_ViewImports.cshtml"
using MyWebBlog.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc9c2470f41c65c0d73b13ab9a7d9e16a9331569", @"/Views/Admin/BlogUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b27b7d6d3dacdd6444f0758d58eb085efde097", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_BlogUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWebBlog.ViewModel.BlogDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\Admin\BlogUpdate.cshtml"
  
    ViewData["Title"] = "BlogUpdate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>BlogUpdate</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\Admin\BlogUpdate.cshtml"
 using (Html.BeginForm("BlogUpdate", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\Admin\BlogUpdate.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-control\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\Admin\BlogUpdate.cshtml"
   Write(Html.LabelFor(m => m.writer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\Admin\BlogUpdate.cshtml"
   Write(Html.TextBoxFor(m => m.writer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-control\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\Admin\BlogUpdate.cshtml"
   Write(Html.LabelFor(m => m.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\Admin\BlogUpdate.cshtml"
   Write(Html.TextBoxFor(m => m.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-control\">\r\n        ");
#nullable restore
#line 19 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\Admin\BlogUpdate.cshtml"
   Write(Html.LabelFor(m => m.body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\Admin\BlogUpdate.cshtml"
   Write(Html.TextAreaFor(m => m.body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <input type=\"submit\" value=\"Submit\"/>\r\n");
#nullable restore
#line 23 "C:\Users\Yoonkun Lee\Desktop\projects\MyBlog\MyWebBlog.Web\Views\Admin\BlogUpdate.cshtml"
}

#line default
#line hidden
#nullable disable
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