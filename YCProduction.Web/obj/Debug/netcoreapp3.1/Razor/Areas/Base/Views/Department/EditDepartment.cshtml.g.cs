#pragma checksum "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\EditDepartment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad3d1d73b6391872aa97729d654e260f76627ccf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Base_Views_Department_EditDepartment), @"mvc.1.0.view", @"/Areas/Base/Views/Department/EditDepartment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad3d1d73b6391872aa97729d654e260f76627ccf", @"/Areas/Base/Views/Department/EditDepartment.cshtml")]
    #nullable restore
    public class Areas_Base_Views_Department_EditDepartment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\EditDepartment.cshtml"
  
    ViewData["Title"] = "EditDepartment";
    Layout = "~/Views/Shared/_LayoutForm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style type=\"text/css\">\r\n    .box-line {\r\n        border-bottom: solid 1px #ccc;\r\n        height: 30px;\r\n    }\r\n\r\n    .layui-input-inline span {\r\n        cursor: pointer;\r\n    }\r\n</style>\r\n<form class=\"layui-form\"");
            BeginWriteAttribute("action", " action=\"", 318, "\"", 327, 0);
            EndWriteAttribute();
            WriteLiteral(" method=\"post\" id=\"formForm\">\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">部门名称</label>\r\n        <div class=\"layui-input-inline\">\r\n            <input type=\"text\" name=\"DepartmentName\" lay-verify=\"DepartmentName\"");
            BeginWriteAttribute("value", " value=\"", 570, "\"", 599, 1);
#nullable restore
#line 21 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\EditDepartment.cshtml"
WriteAttributeValue("", 578, Model.DepartmentName, 578, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"layui-input\" autocomplete=\"off\" lay-vertype=\"tips\" placeholder=\"部门名称\">\r\n            <input type=\"hidden\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 722, "\"", 739, 1);
#nullable restore
#line 22 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\EditDepartment.cshtml"
WriteAttributeValue("", 730, Model.Id, 730, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">部门ID</label>\r\n        <div class=\"layui-input-inline\">\r\n            <input type=\"text\" name=\"DepartmentId\" lay-verify=\"DepartmentId\"");
            BeginWriteAttribute("value", " value=\"", 978, "\"", 1005, 1);
#nullable restore
#line 28 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\EditDepartment.cshtml"
WriteAttributeValue("", 986, Model.DepartmentId, 986, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""layui-input"" autocomplete=""off"" lay-vertype=""tips"" placeholder=""部门ID"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">父级</label>
        <div class=""layui-input-inline box-line"">
            <span id=""spNmae"">");
#nullable restore
#line 34 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\EditDepartment.cshtml"
                         Write(ViewBag.ParentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <input type=\"hidden\" autocomplete=\"off\" name=\"ParentId\" id=\"txtParentId\"");
            BeginWriteAttribute("value", " value=\"", 1394, "\"", 1417, 1);
#nullable restore
#line 35 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\EditDepartment.cshtml"
WriteAttributeValue("", 1402, Model.ParentId, 1402, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""layui-input"">
        </div>
        <div style=""line-height:40px;float:left;"">
            <span class=""fa fa-search"" title=""查询"" id=""spQuery""></span>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">人数</label>
        <div class=""layui-input-inline"">
            <input type=""text"" class=""layui-input""");
            BeginWriteAttribute("value", " value=\"", 1788, "\"", 1809, 1);
#nullable restore
#line 44 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\EditDepartment.cshtml"
WriteAttributeValue("", 1796, Model.Counts, 1796, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Counts"" autocomplete=""off"" placeholder=""人数"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">职责</label>
        <div class=""layui-input-inline"">
            <input type=""text"" class=""layui-input"" name=""Duty""");
            BeginWriteAttribute("value", " value=\"", 2082, "\"", 2101, 1);
#nullable restore
#line 50 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\EditDepartment.cshtml"
WriteAttributeValue("", 2090, Model.Duty, 2090, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" autocomplete=""off"" placeholder=""职责"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">备注</label>
        <div class=""layui-input-inline"">
            <input type=""text"" class=""layui-input"" name=""Remarks""");
            BeginWriteAttribute("value", " value=\"", 2363, "\"", 2385, 1);
#nullable restore
#line 56 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\EditDepartment.cshtml"
WriteAttributeValue("", 2371, Model.Remarks, 2371, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" autocomplete=\"off\" placeholder=\"备注\">\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <div class=\"layui-input-block\">\r\n            <button");
            BeginWriteAttribute("lay-submit", " lay-submit=\"", 2548, "\"", 2561, 0);
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
        //验证
        form.verify({
            DepartmentName: function (value) {
                if (!$.trim(value))
                    return ""请输入部门名称"";
            },
            DepartmentId: function (value) {
                if (!$.trim(value)) {
                    return ""请输入部门ID"";
                }
            }
        });
        //加载树
        $('#spQuery').on('click', function () {
            html = ""<ul id=\""tree\"" class=\""ztree\""></ul>"";
            var index = layer.open({
                type: 1,
                content: html,
                title: '选择部门',
             ");
            WriteLiteral(@"   maxmin: false,
                area: ['450px', '350px']
            });
            $.ajax({
                url: '/Base/Department/GetDepartmentTree',
                type: 'post',
                dataType: 'json',
                success: function (data) {
                    $.fn.zTree.init($(""#tree""), {
                        view: { selectedMulti: false },
                        data: {
                            simpleData: {
                                enable: true,
                                idKey: ""id"",
                                pIdKey: ""pId"",
                                rootPId: 0
                            }
                        },
                        async: {
                            enable: false
                        },
                        callback: {
                            onClick: function (event, treeId, treeNode) {
                                $('#spNmae').html(treeNode.name);
                                $('#txtPar");
            WriteLiteral(@"entId').val(treeNode.id);
                                layer.close(index);
                            }
                        }
                    }, data);
                }
            });
        });
        //提交数据
        form.on('submit(btnSubmit)', function () {
            var formData = $('#formForm').serialize();
            $.post('/Base/Department/EditDepartment', formData, function (res) {
                if (res.State) {
                    window.parent.tipSuccess(res.Message);
                    setTimeout(CloseWin, 1500);
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
