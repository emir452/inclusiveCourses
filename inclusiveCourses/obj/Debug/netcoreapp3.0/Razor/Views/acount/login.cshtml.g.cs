#pragma checksum "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c412b94fc098af377a0e32692502ec395ee7bd09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_acount_login), @"mvc.1.0.view", @"/Views/acount/login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c412b94fc098af377a0e32692502ec395ee7bd09", @"/Views/acount/login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9188f6dad508e8355a778f6cfa1c12221e4f405", @"/Views/_ViewImports.cshtml")]
    public class Views_acount_login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml"
  
    ViewData["Title"] = "ingresar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">login</h1>\r\n</div>\r\n");
#nullable restore
#line 10 "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml"
 using (Html.BeginForm("login", "Acount", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml"
Write(Html.LabelFor(x => x.email, "email"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml"
                                         ; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml"
                                      Write(Html.TextBoxFor(x => x.email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml"
                                                                         ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml"
Write(Html.LabelFor(x => x.password, "contraseña"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml"
                                                 ; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml"
                                              Write(Html.TextBoxFor(x => x.password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml"
                                                                                    ;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Enviar\" />\r\n");
#nullable restore
#line 16 "D:\inclusiveCourses\inclusiveCourses\Views\acount\login.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
