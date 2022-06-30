#pragma checksum "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\EditPwd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85ac6f9dd0aea5d34bdb584a948d909f0a1d21fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_System_Views_User_EditPwd), @"mvc.1.0.view", @"/Areas/System/Views/User/EditPwd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ac6f9dd0aea5d34bdb584a948d909f0a1d21fe", @"/Areas/System/Views/User/EditPwd.cshtml")]
    #nullable restore
    public class Areas_System_Views_User_EditPwd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YCProduction.Model.ViewModel.ModifyPwdEntity>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\EditPwd.cshtml"
  
    ViewData["Title"] = "EditPwd";
    Layout = "~/Views/Shared/_LayoutList.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style type=""text/css"">
    .layui-input-inline {
        width: 350px !important;
    }

    .pwd {
        background-image: url('../../images/pwd-1.png');
        width: 179px;
        height: 14px;
        position: absolute;
        bottom: 0;
        left: 120px;
    }

    .pwd2 {
        background-image: url('../../images/pwd-2.png');
        height: 14px;
        position: absolute;
        bottom: 0px;
        left: 120px;
    }

    .txt {
        width: 180px;
        height: 20px;
        margin-top: 20px;
        margin-left: 120px;
    }

        .txt span {
            display: block;
            float: left;
            color: #707070;
            font-size: 12px;
            text-align: center;
            width: 60px;
        }
</style>
<div class=""divContent"">
    <form class=""layui-form""");
            BeginWriteAttribute("action", " action=\"", 1008, "\"", 1017, 0);
            EndWriteAttribute();
            WriteLiteral(" method=\"post\" id=\"formForm2\">\r\n        <div class=\"layui-form-item\">\r\n            <label class=\"layui-form-label\">\r\n                ");
#nullable restore
#line 49 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\EditPwd.cshtml"
           Write(Html.DisplayNameFor(h => h.OldPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n            <div class=\"layui-input-inline\">\r\n                ");
#nullable restore
#line 52 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\EditPwd.cshtml"
           Write(Html.PasswordFor(model => model.OldPassword, new Dictionary<string, object>() { { "class", "layui-input" }, { "placeholder", "原密码" }, { "lay-verify", "OldPassword" }, { "lay-vertype", "tips" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-item\">\r\n            <label class=\"layui-form-label\">\r\n                ");
#nullable restore
#line 57 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\EditPwd.cshtml"
           Write(Html.DisplayNameFor(h => h.NewPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n            <div class=\"layui-input-inline\">\r\n                ");
#nullable restore
#line 60 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\EditPwd.cshtml"
           Write(Html.PasswordFor(model => model.NewPassword, new Dictionary<string, object>() { { "class", "layui-input" }, { "placeholder", "新密码" }, { "lay-verify", "NewPassword" }, { "lay-vertype", "tips" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""layui-form-item"" style=""position:relative;"">
            <div class=""pwd""> </div>
            <div class=""pwd2""> </div>
        </div>
        <div class=""layui-form-item"" style=""margin-bottom:0 !important"">
            <div class=""txt"">
                <span>弱</span>
                <span>中</span>
                <span>强</span>
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">
                ");
#nullable restore
#line 76 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\EditPwd.cshtml"
           Write(Html.DisplayNameFor(h => h.NewPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n            <div class=\"layui-input-inline\">\r\n                ");
#nullable restore
#line 79 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\EditPwd.cshtml"
           Write(Html.PasswordFor(model => model.ConfirmPassword, new Dictionary<string, object>() { { "class", "layui-input" }, { "placeholder", "确认密码" }, { "lay-verify", "ConfirmPassword" }, { "lay-vertype", "tips" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-item\">\r\n            <div class=\"layui-input-block\">\r\n                <button");
            BeginWriteAttribute("lay-submit", " lay-submit=\"", 2945, "\"", 2958, 0);
            EndWriteAttribute();
            WriteLiteral(" lay-filter=\"btnSubmit\" class=\"layui-btn layui-btn-normal\">保存</button>\r\n            </div>\r\n        </div>\r\n    </form>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85ac6f9dd0aea5d34bdb584a948d909f0a1d21fe8104", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    layui.use(['form', 'common'], function () {
        var $ = layui.$,
            form = layui.form,
            common = layui.common;
        //自定义验证
        form.verify({
            OldPassword: function (value) {
                if (!$.trim(value))
                    return ""请输入原密码""
            },
            NewPassword: function (value) {
                if (!$.trim(value))
                    return ""请输入新密码""
            },
            ConfirmPassword: function (value) {
                if (!$.trim(value)) {
                    return ""请输入确认密码""
                }
                if ($('#NewPassword').val() != value) {
                    return ""二次输入的密码不一致""
                }
            }
        });
        //保存
        form.on('submit(btnSubmit)', function () {
            var formData = $('form').serialize();
            $.post('/System/User/EditPwd', formData, function (res) {
                if (res.State) {
                    comm");
            WriteLiteral(@"on.msgSuccess(res.Message);
                }
                else {
                    common.msgError(res.Message);
                }
            });
            return false;
        });
    });

    $(function () {
        /******密码强度提示******/
        $('#NewPassword').keyup(function () {
            var strongRegex = new RegExp(""^(?=.{8,})(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*\\W).*$"", ""g"");
            var mediumRegex = new RegExp(""^(?=.{7,})(((?=.*[A-Z])(?=.*[a-z]))|((?=.*[A-Z])(?=.*[0-9]))|((?=.*[a-z])(?=.*[0-9]))).*$"", ""g"");
            var enoughRegex = new RegExp(""(?=.{6,}).*"", ""g"");
            if (false == enoughRegex.test($(this).val())) {
                //密码小于六位的时候，密码强度图片都为灰色
                $('.pwd2').css({ ""width"": ""0"" });
            }
            else if (strongRegex.test($(this).val())) {
                //密码为八位及以上并且字母数字特殊字符三项都包括,强度最强
                $('.pwd2').css({ ""width"": ""180"" });
            }
            else if (mediumRegex.test($(this).val())) {
        ");
            WriteLiteral(@"        //密码为七位及以上并且字母、数字、特殊字符三项中有两项，强度是中等
                $('.pwd2').css({ ""width"": ""120"" });
            }
            else {
                //如果密码为6为及以下，就算字母、数字、特殊字符三项都包括，强度也是弱的
                $('.pwd2').css({ ""width"": ""60"" });
            }
        });
    });
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YCProduction.Model.ViewModel.ModifyPwdEntity> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
