#pragma checksum "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8f99e4bea10f54ed5bea6a6277c13dd04a13981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Views\_ViewImports.cshtml"
using YCProduction.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Views\_ViewImports.cshtml"
using YCProduction.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f99e4bea10f54ed5bea6a6277c13dd04a13981", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4d0169f17ef362daab9a3ba68048e1cab380ed7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login-out"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OutLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "项目管理系统";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- 布 局 框 架 -->
<div class=""layui-layout layui-layout-admin layui-hide layui-load"">
    <div class=""layui-header header"">
        <div class=""layui-logo"">
            <a href=""#"">
                <img src=""http://easyadmin.99php.cn/static/admin/images/head.jpg"" alt=""logo"" />
                <h1>项目管理系统</h1>
            </a>
        </div>
        <a>
            <div class=""layuimini-tool""><i title=""展开"" class=""fa fa-outdent"" data-side-fold=""1""></i></div>
        </a>
        <ul class=""layui-nav layui-layout-left layui-header-menu layui-header-pc-menu mobile layui-hide-xs""></ul>
        <ul class=""layui-nav layui-layout-left layui-header-menu mobile layui-hide-sm"">
            <li class=""layui-nav-item"">
                <a href=""javascript:;""><i class=""fa fa-list-ul""></i> 选择模块</a>
                <dl class=""layui-nav-child layui-header-mini-menu""></dl>
            </li>
        </ul>
        <ul class=""layui-nav layui-layout-right"">
            <li class=""layui-nav-item"">
              ");
            WriteLiteral(@"  <a href=""javascript:;"" data-refresh=""刷新""><i class=""fa fa-refresh""></i></a>
            </li>
            <li class=""layui-nav-item"" style=""height:70px;display:inline-flex;"">
                <!--天气信息-->
                <div id=""tp-weather-widget""></div>
            </li>
            <li class=""layui-nav-item"" style=""padding-left:50px;margin-right:-10px;"">
                ");
#nullable restore
#line 33 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Views\Home\Index.cshtml"
           Write(Html.Raw(ViewBag.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n            <li class=\"layui-nav-item layuimini-setting\">\r\n                <a href=\"javascript:;\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Views\Home\Index.cshtml"
               Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </a>
                <dl class=""layui-nav-child"">
                    <dd>
                        <a href=""javascript:;"" data-icon=""fa fa-gears"" id=""info"">个人信息</a>
                    </dd>
                    <dd>
                        <a href=""javascript:;"" data-iframe-tab=""/System/User/EditPwd"" data-title=""修改密码"" data-icon=""fa fa-gears"">修改密码</a>
                    </dd>
                    <dd>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8f99e4bea10f54ed5bea6a6277c13dd04a139816923", async() => {
                WriteLiteral("退出登录");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </dd>
                </dl>
            </li>
            <li class=""layui-nav-item layuimini-select-bgcolor mobile layui-hide-xs"">
                <a href=""javascript:;"" data-bgcolor=""配色方案""><i class=""fa fa-ellipsis-v""></i></a>
            </li>
        </ul>
    </div>
    <div class=""layui-side layui-bg-black"">
        <div class=""layui-side-scroll layui-left-menu"">
        </div>
    </div>
    <div class=""layui-body"">
        <div class=""layui-tab"" lay-filter=""layuiminiTab"" id=""top_tabs_box"">
            <ul class=""layui-tab-title"" id=""top_tabs"">
                <li class=""layui-this"" id=""layuiminiHomeTabId""");
            BeginWriteAttribute("lay-id", " lay-id=\"", 2817, "\"", 2826, 0);
            EndWriteAttribute();
            WriteLiteral(@"></li>
            </ul>
            <ul class=""layui-nav closeBox"">
                <li class=""layui-nav-item"">
                    <a href=""javascript:;""> <i class=""fa fa-dot-circle-o""></i> 页面操作</a>
                    <dl class=""layui-nav-child"">
                        <dd><a href=""javascript:;"" data-page-close=""other""><i class=""fa fa-window-close""></i> 关闭其他</a></dd>
                        <dd><a href=""javascript:;"" data-page-close=""all""><i class=""fa fa-window-close-o""></i> 关闭全部</a></dd>
                    </dl>
                </li>
            </ul>
            <div class=""layui-tab-content clildFrame"">
                <div id=""layuiminiHomeTabIframe"" class=""layui-tab-item layui-show"">
                </div>
            </div>
        </div>
    </div>
</div>
<!-- 加 载 动 画 -->
<div class=""loader-main"">
    <!-- 动 画 对 象 -->
    <div class=""loader""></div>
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
