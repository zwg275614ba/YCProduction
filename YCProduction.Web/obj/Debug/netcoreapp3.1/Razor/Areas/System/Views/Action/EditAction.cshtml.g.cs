#pragma checksum "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fbc9703e0004c8c876ef44b0fd0df5d55058b38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_System_Views_Action_EditAction), @"mvc.1.0.view", @"/Areas/System/Views/Action/EditAction.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fbc9703e0004c8c876ef44b0fd0df5d55058b38", @"/Areas/System/Views/Action/EditAction.cshtml")]
    #nullable restore
    public class Areas_System_Views_Action_EditAction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml"
  
    ViewData["Title"] = "EditAction";
    Layout = "~/Views/Shared/_LayoutForm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form class=\"layui-form\"");
            BeginWriteAttribute("action", " action=\"", 125, "\"", 134, 0);
            EndWriteAttribute();
            WriteLiteral(" method=\"post\" id=\"formForm\">\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">按钮名称</label>\r\n        <div class=\"layui-input-inline\">\r\n            <input type=\"text\" name=\"ActionName\"");
            BeginWriteAttribute("value", " value=\"", 345, "\"", 370, 1);
#nullable restore
#line 11 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml"
WriteAttributeValue("", 353, Model.ActionName, 353, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" lay-verify=\"required\" class=\"layui-input\" autocomplete=\"off\" lay-vertype=\"tips\" placeholder=\"按钮名称\">\r\n            <input type=\"hidden\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 515, "\"", 532, 1);
#nullable restore
#line 12 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml"
WriteAttributeValue("", 523, Model.Id, 523, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">标识</label>\r\n        <div class=\"layui-input-inline\">\r\n            <input type=\"text\" class=\"layui-input\"");
            BeginWriteAttribute("value", " value=\"", 743, "\"", 768, 1);
#nullable restore
#line 18 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml"
WriteAttributeValue("", 751, Model.ActionCode, 751, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""ActionCode"" autocomplete=""off"" placeholder=""标识"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">图标</label>
        <div class=""layui-input-inline"">
            <input type=""text"" id=""Icon"" readonly=""readonly""");
            BeginWriteAttribute("value", " value=\"", 1043, "\"", 1062, 1);
#nullable restore
#line 24 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml"
WriteAttributeValue("", 1051, Model.Icon, 1051, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Icon\" class=\"layui-input\" placeholder=\"图标\">\r\n        </div>\r\n        <div style=\"line-height:40px;float:left;\">\r\n            <a id=\"sltIcon\" href=\"javascript:;\" style=\"color:blue;\">选择图片</a><span id=\"spnIcon\"");
            BeginWriteAttribute("class", " class=\"", 1277, "\"", 1299, 2);
            WriteAttributeValue("", 1285, "fa", 1285, 2, true);
#nullable restore
#line 27 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml"
WriteAttributeValue(" ", 1287, Model.Icon, 1288, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></span><a href=""javascript:;"" id=""clearIcon"">清除</a>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">方法</label>
        <div class=""layui-input-inline"">
            <input type=""text"" class=""layui-input""");
            BeginWriteAttribute("value", " value=\"", 1561, "\"", 1582, 1);
#nullable restore
#line 33 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml"
WriteAttributeValue("", 1569, Model.Method, 1569, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Method"" autocomplete=""off"" placeholder=""方法"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">样式</label>
        <div class=""layui-input-inline"">
            <input type=""text"" class=""layui-input""");
            BeginWriteAttribute("value", " value=\"", 1843, "\"", 1867, 1);
#nullable restore
#line 39 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml"
WriteAttributeValue("", 1851, Model.ClassName, 1851, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""ClassName"" autocomplete=""off"" placeholder=""样式"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">排序ID</label>
        <div class=""layui-input-inline"">
            <input type=""number"" min=""0"" max=""100"" maxlength=""3""");
            BeginWriteAttribute("value", " value=\"", 2147, "\"", 2169, 1);
#nullable restore
#line 45 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml"
WriteAttributeValue("", 2155, Model.OrderBy, 2155, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""layui-input"" name=""OrderBy"" lay-verify=""OrderNo"" lay-vertype=""tips"" autocomplete=""off"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">显示位置</label>
        <div class=""layui-input-inline"">
            ");
#nullable restore
#line 51 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml"
       Write(Html.SelectHtml((int)Model?.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">备注</label>\r\n        <div class=\"layui-input-inline\">\r\n            <textarea name=\"Remark\" rows=\"5\" cols=\"50\">");
#nullable restore
#line 57 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\EditAction.cshtml"
                                                  Write(Model.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <div class=\"layui-input-block\">\r\n            <button");
            BeginWriteAttribute("lay-submit", " lay-submit=\"", 2839, "\"", 2852, 0);
            EndWriteAttribute();
            WriteLiteral(@" lay-filter=""btnSubmit"" class=""layui-btn layui-btn-normal"">保存</button>
            <button type=""reset"" class=""layui-btn layui-btn-primary"">重置</button>
        </div>
    </div>
</form>
<script type=""text/javascript"">
    layui.use(['form', 'common', 'layer'], function () {
        var $ = layui.$,
            form = layui.form,
            layer = layui.layer,
            common = layui.common;
        //选择图标
        $(""#sltIcon"").on(""click"", function () {
            openSetIcon();
        });
        //清除图标
        $('#clearIcon').on('click', function () {
            $('#Icon').val("""");
            $('#spnIcon').attr(""class"", """");
        });
        //提交数据
        form.on('submit(btnSubmit)', function () {
            var formData = $('#formForm').serialize();
            $.post('/System/Action/EditAction', formData, function (res) {
                if (res.State) {
                    common.msgSuccess(res.Message);
                    setTimeout(CloseWin, 1500);
             ");
            WriteLiteral("   }\r\n                else {\r\n                    common.msgError(res.Message);\r\n                }\r\n            });\r\n            return false;\r\n        });\r\n    });\r\n</script>\r\n\r\n");
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
