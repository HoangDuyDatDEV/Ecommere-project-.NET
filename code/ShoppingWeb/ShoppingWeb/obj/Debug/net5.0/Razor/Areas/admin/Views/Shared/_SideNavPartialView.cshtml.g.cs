#pragma checksum "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\Shared\_SideNavPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1bf02cd6d7debb3b7ede32eb31868775b454e57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Shared__SideNavPartialView), @"mvc.1.0.view", @"/Areas/admin/Views/Shared/_SideNavPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1bf02cd6d7debb3b7ede32eb31868775b454e57", @"/Areas/admin/Views/Shared/_SideNavPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aac4d92dc9ba1d3f4c722e8dbc6fee9426bd99a0", @"/Areas/admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_admin_Views_Shared__SideNavPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminCustomers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminAccounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminTinDangs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminPages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""side-nav"">
    <div class=""side-nav-inner"">
        <ul class=""side-nav-menu scrollable"">
            <li class=""nav-item "">
                <a class=""dropdown-toggle"" href=""/admin/Home/Index"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-dashboard""></i>
                    </span>
                    <span class=""title"">Dashboard</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
             
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-appstore""></i>
                    </span>
                    <span class=""title"">Quản lý đơn hàng</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
           ");
            WriteLiteral(@"         </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""app-chat.html"">Chat</a>
                    </li>
                    <li>
                        <a href=""app-file-manager.html"">File Manager</a>
                    </li>
                    <li>
                        <a href=""app-mail.html"">Mail</a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a href=""javascript:void(0);"">
                            <span>Projects</span>
                            <span class=""arrow"">
                                <i class=""arrow-icon""></i>
                            </span>
                        </a>
                        <ul class=""dropdown-menu"">
                            <li>
                                <a href=""app-project-list.html"">Project List</a>
                            </li>
                            <li>
                  ");
            WriteLiteral(@"              <a href=""app-project-details.html"">Project Details</a>
                            </li>
                        </ul>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a href=""javascript:void(0);"">
                            <span>E-commerce</span>
                            <span class=""arrow"">
                                <i class=""arrow-icon""></i>
                            </span>
                        </a>
                        <ul class=""dropdown-menu"">
                            <li>
                                <a href=""app-e-commerce-order-list.html"">Orders List</a>
                            </li>
                            <li>
                                <a href=""app-e-commerce-products.html"">Products</a>
                            </li>
                            <li>
                                <a href=""app-e-commerce-products-list.html"">Products List</a>
                            <");
            WriteLiteral(@"/li>
                            <li>
                                <a href=""app-e-commerce-products-edit.html"">Products Edit</a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-build""></i>
                    </span>
                    <span class=""title"">Quản lý sản phẩm </span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1bf02cd6d7debb3b7ede32eb31868775b454e579534", async() => {
                WriteLiteral("Danh sách sản phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>

                    
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-hdd""></i>
                    </span>
                    <span class=""title"">Quản lý khách hàng</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1bf02cd6d7debb3b7ede32eb31868775b454e5711784", async() => {
                WriteLiteral("Danh sách khách hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1bf02cd6d7debb3b7ede32eb31868775b454e5713444", async() => {
                WriteLiteral("Tìm kiếm khách hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-form""></i>
                    </span>
                    <span class=""title"">Quản lý doanh số</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""form-elements.html"">Form Elements</a>
                    </li>
                    <li>
                        <a href=""form-layouts.html"">Form Layouts</a>
                    </li>
                    <li>
                        <a href=""form-validation.html"">Form Validation</a>
                    </li>
                </ul>
            </li>
            <li class=");
            WriteLiteral(@"""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-table""></i>
                    </span>
                    <span class=""title"">Quản lý hệ thống</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""basic-table.html"">Quản lý danh mục</a>
                    </li>
                    <li>
                        <a href=""/admin/AdminRoles/Index"">Quản lý quyền truy cập</a>
                    </li>
                    <li>
                        <a href=""data-table.html"">Quản lý Tỉnh/thành</a>
                    </li>
                    <li>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1bf02cd6d7debb3b7ede32eb31868775b454e5717069", async() => {
                WriteLiteral("Quản lý tài khoản ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-pie-chart""></i>
                    </span>
                    <span class=""title"">Quản lý tin tức</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1bf02cd6d7debb3b7ede32eb31868775b454e5719299", async() => {
                WriteLiteral("Danh sách tin đăng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>                  
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-file""></i>
                    </span>
                    <span class=""title"">Quản lý Pages</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1bf02cd6d7debb3b7ede32eb31868775b454e5721536", async() => {
                WriteLiteral("Danh sách Page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-lock""></i>
                    </span>
                    <span class=""title"">Quản lý Shipper</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""login-1.html"">Login 1</a>
                    </li>
                    <li>
                        <a href=""login-2.html"">Login 2</a>
                    </li>
                    <li>
                        <a href=""login-3.html"">Login 3</a>
                    </li>
                    <li>
                        <a href=""sign-up-1.html"">Sign Up 1</a>
              ");
            WriteLiteral(@"      </li>
                    <li>
                        <a href=""sign-up-2.html"">Sign Up 2</a>
                    </li>
                    <li>
                        <a href=""sign-up-3.html"">Sign Up 3</a>
                    </li>
                    <li>
                        <a href=""error-1.html"">Error 1</a>
                    </li>
                    <li>
                        <a href=""error-2.html"">Error 2</a>
                    </li>
                </ul>
            </li>
        </ul>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
