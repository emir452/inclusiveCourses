#pragma checksum "D:\inclusiveCourses\inclusiveCourses\Views\acount\profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1384aa542bf5983e553dabac5bed46bd75c595cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_acount_profile), @"mvc.1.0.view", @"/Views/acount/profile.cshtml")]
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
#line 1 "D:\inclusiveCourses\inclusiveCourses\Views\_ViewImports.cshtml"
using inclusiveCourses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\inclusiveCourses\inclusiveCourses\Views\_ViewImports.cshtml"
using inclusiveCourses.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1384aa542bf5983e553dabac5bed46bd75c595cf", @"/Views/acount/profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9188f6dad508e8355a778f6cfa1c12221e4f405", @"/Views/_ViewImports.cshtml")]
    public class Views_acount_profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\inclusiveCourses\inclusiveCourses\Views\acount\profile.cshtml"
  
    ViewData["Title"] = "profile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\inclusiveCourses\inclusiveCourses\Views\acount\profile.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n<h1>profile</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591