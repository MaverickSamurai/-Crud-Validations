#pragma checksum "C:\Users\mieam\Desktop\Crud-Validations\Crud-Validations\EntityFrameworkProject\Areas\AdminArea\Views\Social\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b22df096671e66f204ebea31458c5e2fc224dcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Social_Detail), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Social/Detail.cshtml")]
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
#line 1 "C:\Users\mieam\Desktop\Crud-Validations\Crud-Validations\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b22df096671e66f204ebea31458c5e2fc224dcf", @"/Areas/AdminArea/Views/Social/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4472e57ccb85564f0ed85bc069dcc9853bd128a9", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_Social_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Social>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mieam\Desktop\Crud-Validations\Crud-Validations\EntityFrameworkProject\Areas\AdminArea\Views\Social\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid my-3 mx-3"">
    <div class=""table-responsive pt-3"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>
                        Name
                    </th>
                    <th>
                        Url
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        ");
#nullable restore
#line 23 "C:\Users\mieam\Desktop\Crud-Validations\Crud-Validations\EntityFrameworkProject\Areas\AdminArea\Views\Social\Detail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 26 "C:\Users\mieam\Desktop\Crud-Validations\Crud-Validations\EntityFrameworkProject\Areas\AdminArea\Views\Social\Detail.cshtml"
                   Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Social> Html { get; private set; }
    }
}
#pragma warning restore 1591
