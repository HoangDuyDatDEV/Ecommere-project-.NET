#pragma checksum "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminRoles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a98a448be0eb6b5adce32067a7c26c270af0e4d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_AdminRoles_Details), @"mvc.1.0.view", @"/Areas/admin/Views/AdminRoles/Details.cshtml")]
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
#line 1 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\_ViewImports.cshtml"
using ShoppingWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\_ViewImports.cshtml"
using ShoppingWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a98a448be0eb6b5adce32067a7c26c270af0e4d5", @"/Areas/admin/Views/AdminRoles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aac4d92dc9ba1d3f4c722e8dbc6fee9426bd99a0", @"/Areas/admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_admin_Views_AdminRoles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingWeb.Models.Role>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminRoles\Details.cshtml"
  
    ViewData["Title"] = "Thông tin quyền truy cập";
    Layout = "~/Areas/admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-header"">

    <div class=""header-sub-title"">
        <nav class=""breadcrumb breadcrumb-dash"">
            <a href=""/admin/Home/Index"" class=""breadcrumb-item""><i class=""anticon anticon-home m-r-5""></i>Home</a>
            <a class=""breadcrumb-item"" href=""/admin/AdminRoles/Index"">Danh sách quyền truy cập</a>
            <span class=""breadcrumb-item active"">Thông tin quyền truy cập</span>
        </nav>
    </div>
</div>
<div class=""card"">
    <div class=""card-body"">
        <h4 class=""card-title"">Thông tin quyền truy cập</h4>
        <div class=""table-responsive"">
            <table class=""product-info-table m-t-20"">
                <tbody>
                    <tr>
                        <td>ID:</td>
                        <td class=""text-dark font-weight-semibold"">");
#nullable restore
#line 25 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminRoles\Details.cshtml"
                                                              Write(Model.RoleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Tên quyền truy cập: </td>\r\n                        <td>");
#nullable restore
#line 29 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminRoles\Details.cshtml"
                       Write(Model.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Mô tả:</td>\r\n                        <td>");
#nullable restore
#line 33 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminRoles\Details.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                   \r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingWeb.Models.Role> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
