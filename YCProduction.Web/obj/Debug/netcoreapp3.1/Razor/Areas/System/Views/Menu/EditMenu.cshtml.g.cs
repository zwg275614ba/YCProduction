#pragma checksum "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Menu\EditMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d78bcb9a0eabab57cb5dd7b8950a41edd74298be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_System_Views_Menu_EditMenu), @"mvc.1.0.view", @"/Areas/System/Views/Menu/EditMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d78bcb9a0eabab57cb5dd7b8950a41edd74298be", @"/Areas/System/Views/Menu/EditMenu.cshtml")]
    #nullable restore
    public class Areas_System_Views_Menu_EditMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Menu\EditMenu.cshtml"
  
    ViewData["Title"] = "EditMenu";
    Layout = "~/Views/Shared/_LayoutForm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style type=\"text/css\">\r\n    .box-line {\r\n        border-bottom: solid 1px #ccc;\r\n        height: 30px;\r\n    }\r\n\r\n    .layui-input-inline span {\r\n        cursor: pointer;\r\n    }\r\n</style>\r\n<form class=\"layui-form\"");
            BeginWriteAttribute("action", " action=\"", 312, "\"", 321, 0);
            EndWriteAttribute();
            WriteLiteral(" method=\"post\" id=\"formForm\">\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">菜单名称</label>\r\n        <div class=\"layui-input-inline\">\r\n            <input type=\"text\" name=\"MenuName\" lay-verify=\"MenuName\"");
            BeginWriteAttribute("value", " value=\"", 552, "\"", 575, 1);
#nullable restore
#line 21 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Menu\EditMenu.cshtml"
WriteAttributeValue("", 560, Model.MenuName, 560, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"layui-input\" autocomplete=\"off\" lay-vertype=\"tips\" placeholder=\"菜单名称\">\r\n            <input type=\"hidden\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 698, "\"", 715, 1);
#nullable restore
#line 22 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Menu\EditMenu.cshtml"
WriteAttributeValue("", 706, Model.Id, 706, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">父级</label>\r\n        <div class=\"layui-input-inline box-line\">\r\n            <span id=\"spNmae\">");
#nullable restore
#line 28 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Menu\EditMenu.cshtml"
                         Write(ViewBag.ParentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <input type=\"hidden\" autocomplete=\"off\" name=\"ParentId\" id=\"txtParentId\"");
            BeginWriteAttribute("value", " value=\"", 1027, "\"", 1050, 1);
#nullable restore
#line 29 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Menu\EditMenu.cshtml"
WriteAttributeValue("", 1035, Model.ParentId, 1035, 15, false);

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
        <label class=""layui-form-label"">菜单URL</label>
        <div class=""layui-input-inline"">
            <input type=""text"" class=""layui-input"" name=""MenuUrl""");
            BeginWriteAttribute("value", " value=\"", 1439, "\"", 1461, 1);
#nullable restore
#line 38 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Menu\EditMenu.cshtml"
WriteAttributeValue("", 1447, Model.MenuUrl, 1447, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" autocomplete=""off"" placeholder=""菜单url"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">菜单图标</label>
        <div class=""layui-input-inline"">
            <input type=""text"" id=""Icon"" readonly=""readonly"" name=""MenuIccon""");
            BeginWriteAttribute("value", " value=\"", 1740, "\"", 1764, 1);
#nullable restore
#line 44 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Menu\EditMenu.cshtml"
WriteAttributeValue("", 1748, Model.MenuIccon, 1748, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"layui-input\" placeholder=\"菜单图标\">\r\n        </div>\r\n        <div style=\"line-height:40px;float:left;\">\r\n            <a id=\"sltIcon\" href=\"javascript:;\" style=\"color:blue;\">选择图片</a><span id=\"spnIcon\"");
            BeginWriteAttribute("class", " class=\"", 1969, "\"", 1996, 2);
            WriteAttributeValue("", 1977, "fa", 1977, 2, true);
#nullable restore
#line 47 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Menu\EditMenu.cshtml"
WriteAttributeValue(" ", 1979, Model.MenuIccon, 1980, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></span><a href=""javascript:;"" id=""clearIcon"">清除</a>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">排序ID</label>
        <div class=""layui-input-inline"">
            <input type=""number"" min=""0"" max=""100"" maxlength=""3""");
            BeginWriteAttribute("value", " value=\"", 2274, "\"", 2296, 1);
#nullable restore
#line 53 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Menu\EditMenu.cshtml"
WriteAttributeValue("", 2282, Model.OrderNo, 2282, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""layui-input"" name=""OrderNo"" lay-verify=""OrderNo"" lay-vertype=""tips"" autocomplete=""off"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">状态</label>
        <div class=""layui-input-inline"">
            ");
#nullable restore
#line 59 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Menu\EditMenu.cshtml"
       Write(Html.StateRadioHtml((int)Model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <div class=\"layui-input-block\">\r\n            <button");
            BeginWriteAttribute("lay-submit", " lay-submit=\"", 2727, "\"", 2740, 0);
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
        //验证
        form.verify({
            MenuName: function (value) {
                if (!$.trim(value))
                    return ""请输入菜单名称"";
            },
            OrderNo: function (value) {
                if (!$.trim(value)) {
                    return ""请输入排序ID"";
                }
            }
        });
        //加载");
            WriteLiteral(@"树
        $('#spQuery').on('click', function () {
            html = ""<ul id=\""tree\"" class=\""ztree\""></ul>"";
            var index = layer.open({
                type: 1,
                content: html,
                title: '选择菜单',
                maxmin: false,
                area: ['450px', '350px']
            });
            $.ajax({
                url: '/System/Menu/GetMenuTree',
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
     ");
            WriteLiteral(@"                   },
                        callback: {
                            onClick: function (event, treeId, treeNode) {
                                $('#spNmae').html(treeNode.name);
                                $('#txtParentId').val(treeNode.id);
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
            $.post('/System/Menu/EditMenu', formData, function (res) {
                if (res.State) {
                    common.msgSuccess(res.Message);
                    setTimeout(CloseWin, 1500);
                }
                else {
                    common.msgError(res.Message);
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