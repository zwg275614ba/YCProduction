#pragma checksum "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Role\EditRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bfe9809be78ea5d0f21030aa2945faf026380cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_System_Views_Role_EditRole), @"mvc.1.0.view", @"/Areas/System/Views/Role/EditRole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bfe9809be78ea5d0f21030aa2945faf026380cb", @"/Areas/System/Views/Role/EditRole.cshtml")]
    #nullable restore
    public class Areas_System_Views_Role_EditRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Role\EditRole.cshtml"
  
    ViewData["Title"] = "EditRole";
    Layout = "~/Views/Shared/_LayoutForm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form id=\"formForm\"");
            BeginWriteAttribute("action", " action=\"", 118, "\"", 127, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"layui-form\">\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">\r\n            角色名称\r\n        </label>\r\n        <div class=\"layui-input-inline\">\r\n            <input type=\"text\" name=\"RoleName\" class=\"layui-input\"");
            BeginWriteAttribute("value", " value=\"", 371, "\"", 394, 1);
#nullable restore
#line 13 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Role\EditRole.cshtml"
WriteAttributeValue("", 379, Model.RoleName, 379, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" lay-verify=\"required\" lay-vertype=\"tips\" placeholder=\"角色名称\">\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 490, "\"", 507, 1);
#nullable restore
#line 14 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Role\EditRole.cshtml"
WriteAttributeValue("", 498, Model.Id, 498, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Id\">\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">\r\n            状态\r\n        </label>\r\n        <div class=\"layui-input-inline\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Role\EditRole.cshtml"
       Write(Html.StateRadioHtml((int)Model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">\r\n            备注\r\n        </label>\r\n        <div class=\"layui-input-inline\">\r\n            <textarea name=\"Remark\" rows=\"5\" cols=\"60\">");
#nullable restore
#line 30 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Role\EditRole.cshtml"
                                                  Write(Model.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <div class=\"layui-input-block\">\r\n            <button");
            BeginWriteAttribute("lay-submit", " lay-submit=\"", 1140, "\"", 1153, 0);
            EndWriteAttribute();
            WriteLiteral(@" lay-filter=""btnSubmit"" class=""layui-btn layui-btn-normal"">保存</button>
            <button type=""reset"" class=""layui-btn layui-btn-primary"">重置</button>
        </div>
    </div>
</form>

<script type=""text/javascript"">
    layui.use([""form"", ""common""], function () {
        var form = layui.form,
            common = layui.common,
            $ = layui.$;
        //提交
        form.on('submit(btnSubmit)', function () {
            var formData = $('#formForm').serialize();
            $.post('/System/Role/EditInfo', formData, function (res) {
                if (res.State) {
                    setTimeout(CloseWin, 1500);
                    window.parent.tipSuccess(res.Message);
                }
                else {
                    window.parent.tipError(res.Message);
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
