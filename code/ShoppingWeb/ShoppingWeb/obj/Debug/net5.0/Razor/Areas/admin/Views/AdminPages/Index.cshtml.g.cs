#pragma checksum "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b237aa20c92b53adb650ea396256fab92294686c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_AdminPages_Index), @"mvc.1.0.view", @"/Areas/admin/Views/AdminPages/Index.cshtml")]
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
#nullable restore
#line 1 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b237aa20c92b53adb650ea396256fab92294686c", @"/Areas/admin/Views/AdminPages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aac4d92dc9ba1d3f4c722e8dbc6fee9426bd99a0", @"/Areas/admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_admin_Views_AdminPages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<ShoppingWeb.Models.Page>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminPages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
  
    int CurrentPage = ViewBag.CurrentPage;
    ViewData["Title"] = "Danh sách Page" + CurrentPage;
    Layout = "~/Areas/admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"main-content\">\r\n    <div class=\"page-header\">\r\n        <div class=\"header-sub-title\">\r\n            <nav class=\"breadcrumb breadcrumb-dash\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b237aa20c92b53adb650ea396256fab92294686c6675", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <span class=\"breadcrumb-item active\">Danh sách Page:page ");
#nullable restore
#line 13 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
                                                                     Write(CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </nav>
        </div>
    </div>
    
    
    <div class=""card"">
        <div class=""card-body"">
            <div class=""row m-b-30"">
                <div class=""col-lg-8""></div>
                <div class=""col-lg-4 text-right"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b237aa20c92b53adb650ea396256fab92294686c9026", async() => {
                WriteLiteral(" <i class=\"anticon anticon-plus-circle m-r-5\"></i>Add Page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""table-responsive"">
                <table class=""table table-hover e-commerce-table"">
                    <thead>
                        <tr>

                            <th>ID</th>
                            <th>Page Name</th>
                            <th>Trạng thái</th>
                            <th>#</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 39 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
                         if (Model != null)
                        {
                            foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n                                    <td>");
#nullable restore
#line 45 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
                                   Write(item.PageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 46 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
                                   Write(item.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 47 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
                                         if(item.Published==true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""d-flex align-items-center"">
                                            <div class=""badge badge-success badge-dot m-r-10""></div>
                                            <div>Public</div>
                                        </div>
");
#nullable restore
#line 53 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""d-flex align-items-center"">
                                            <div class=""badge badge-success badge-dot m-r-10""></div>
                                            <div>Non-Public</div>
                                        </div>
");
#nullable restore
#line 60 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-primary m-r-5\"");
            BeginWriteAttribute("href", " href=\"", 2909, "\"", 2954, 2);
            WriteAttributeValue("", 2916, "/admin/AdminPages/Details/", 2916, 26, true);
#nullable restore
#line 63 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
WriteAttributeValue("", 2942, item.PageId, 2942, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a>\r\n                                        <a class=\"btn btn-danger m-r-5\"");
            BeginWriteAttribute("href", " href=\"", 3037, "\"", 3081, 2);
            WriteAttributeValue("", 3044, "/admin/AdminPages/Delete/", 3044, 25, true);
#nullable restore
#line 64 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
WriteAttributeValue("", 3069, item.PageId, 3069, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                                        <a class=\"btn btn-secondary m-r-5\"");
            BeginWriteAttribute("href", " href=\"", 3169, "\"", 3211, 2);
            WriteAttributeValue("", 3176, "/admin/AdminPages/Edit/", 3176, 23, true);
#nullable restore
#line 65 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
WriteAttributeValue("", 3199, item.PageId, 3199, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 68 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n                <div aria-label=\"Page navigation example\">\r\n                    <ul>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b237aa20c92b53adb650ea396256fab92294686c16067", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#nullable restore
#line 76 "D:\DOT NET\WEB ban hang\code\ShoppingWeb\ShoppingWeb\Areas\admin\Views\AdminPages\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspArea = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<ShoppingWeb.Models.Page>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
