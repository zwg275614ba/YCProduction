#pragma checksum "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\AllotRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aee4c7cc3a3e12a8ba8536c59ab81e80a55ea5c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_System_Views_User_AllotRole), @"mvc.1.0.view", @"/Areas/System/Views/User/AllotRole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aee4c7cc3a3e12a8ba8536c59ab81e80a55ea5c8", @"/Areas/System/Views/User/AllotRole.cshtml")]
    #nullable restore
    public class Areas_System_Views_User_AllotRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\AllotRole.cshtml"
  
    ViewData["Title"] = "AllotRole";
    Layout = "~/Views/Shared/_LayoutForm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<form class=\"layui-form\" id=\"formForm\"");
            BeginWriteAttribute("action", " action=\"", 136, "\"", 145, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">角色</label>\r\n        <div class=\"layui-input-block\">\r\n            ");
#nullable restore
#line 10 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\AllotRole.cshtml"
       Write(Html.Raw(ViewBag.RoleNames));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"hidden\" name=\"Id\" id=\"hiId\"");
            BeginWriteAttribute("value", " value=\"", 371, "\"", 394, 1);
#nullable restore
#line 11 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\User\AllotRole.cshtml"
WriteAttributeValue("", 379, ViewBag.UserId, 379, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-input-block\">\r\n        <button type=\"button\" class=\"layui-btn layui-btn-primary\" id=\"btnClose\">取消</button>\r\n        <button");
            BeginWriteAttribute("lay-submit", " lay-submit=\"", 571, "\"", 584, 0);
            EndWriteAttribute();
            WriteLiteral(@" lay-filter=""btnSubmit"" class=""layui-btn layui-btn-normal"">保存</button>
    </div>
</form>
<script type=""text/javascript"">
    layui.use(['form', 'common'], function () {
        var $ = layui.$,
            form = layui.form,
            common = layui.common;
        //关闭
        $('#btnClose').on('click', function () {
            var index = parent.layer.getFrameIndex(window.name);
            parent.layer.close(index);
        });
        //保存
        form.on('submit(btnSubmit)', function () {
            var arrids = [];
            $(""input[type='checkbox']:checked"").each(function () {
                arrids.push($(this).val());
            });
            $.post('/System/User/AllotRole', { userId: $('#hiId').val(), ids: arrids.join(',') }, function (data) {
                if (data.State) {
                    common.msgSuccess(data.Message);
                    setTimeout(function () {
                        var index = parent.layer.getFrameIndex(window.name);
                ");
            WriteLiteral(@"        parent.layer.close(index);
                    }, 1000);
                }
                else {
                    common.msgError(data.Message);
                }
            });
            return false;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591