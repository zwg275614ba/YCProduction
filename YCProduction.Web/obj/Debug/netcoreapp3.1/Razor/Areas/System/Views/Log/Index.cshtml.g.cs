#pragma checksum "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Log\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2673ee0f66bdcfd6282b9d05c22d7dae6c36defc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_System_Views_Log_Index), @"mvc.1.0.view", @"/Areas/System/Views/Log/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2673ee0f66bdcfd6282b9d05c22d7dae6c36defc", @"/Areas/System/Views/Log/Index.cshtml")]
    #nullable restore
    public class Areas_System_Views_Log_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YCProduction.Model.Entitys.System.SysLog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Log\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutList.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main\">\r\n    <!------------------查询-------------------------->\r\n    <fieldset class=\"table-search-fieldset\">\r\n        <legend>搜索信息</legend>\r\n        <div class=\"divQuery\">\r\n            <form class=\"layui-form\"");
            BeginWriteAttribute("action", " action=\"", 363, "\"", 372, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""formSearch"">
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">操作人</label>
                    <div class=""layui-input-inline"">
                        <input type=""text"" name=""UserName"" placeholder=""操作人"" class=""layui-input"">
                    </div>
                    <label class=""layui-form-label"">类型</label>
                    <div class=""layui-input-inline"">
                        ");
#nullable restore
#line 20 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Log\Index.cshtml"
                   Write(Html.DrownHtml("LogType"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <label class=""layui-form-label"">时间</label>
                    <div class=""layui-input-inline"">
                        <input type=""text"" name=""StateTime"" id=""StateTime"" placeholder=""时间"" class=""layui-input"">
                    </div>
                    <div class=""layui-input-inline btn"">
                        <a href=""javascript:;"" class=""layui-btn layui-btn-sm"" id=""btnQuery"" data-type=""reload"">
                            查询
                        </a>
                        <button type=""reset"" class=""layui-btn layui-btn-primary layui-btn-sm"">重置</button>
                    </div>
                    <div class=""btn-right"">
                        ");
#nullable restore
#line 33 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Log\Index.cshtml"
                   Write(Html.TopToolBarHtml(ViewData["ActionFormRightTop"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </form>
        </div>
    </fieldset>
        <!------------------表格-------------------------->
        <div class=""divTable"">
            <div class=""content"">
                <table id=""defaultTable"" lay-filter=""LogTable""></table>
            </div>
        </div>
        <!--------------------工具栏表格内------------------->
        <script type=""text/html"" id=""toolBar"">
            ");
#nullable restore
#line 47 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Log\Index.cshtml"
       Write(Html.ToolBarHtml(ViewData["ActionList"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </script>
</div>

<script type=""text/javascript"">
    layui.use(['form', 'common', 'table', 'laydate'], function () {
        var form = layui.form,
            common = layui.common,
            $ = layui.$,
            table = layui.table,
            laydate = layui.laydate;
        //渲染时间控件
        laydate.render({
            elem: '#StateTime',
            range: true
        });
        //渲染表格
        table.render({
            id: 'defaultReload',
            elem: '#defaultTable',
            height: 'full-110',
            url: '/System/Log/GetLogList',
            toolbar: '#toolBar',
            page: true,
            cols: [[
                 { type: 'checkbox', fixed: 'left' },
                 { field: 'Id', title: '");
#nullable restore
#line 73 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Log\Index.cshtml"
                                   Write(Html.DisplayNameFor(a=>a.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', sort: true,width:70 },\r\n                 { field: \'UserName\', title: \'");
#nullable restore
#line 74 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Log\Index.cshtml"
                                         Write(Html.DisplayNameFor(a=>a.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', sort: true },\r\n                 {\r\n                     field: \'LogType\', title: \'");
#nullable restore
#line 76 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Log\Index.cshtml"
                                          Write(Html.DisplayNameFor(a=>a.LogType));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', sort: true, templet: function (res) {
                         switch (res.LogType) {
                             case 1: return ""退出""; break;
                             case 3: return ""新增""; break;
                             case 4: return ""删除""; break;
                             case 5: return ""编辑""; break;
                             case 8: return ""登录""; break;
                             default: return """"; break;
                         }
                     }
                 },
                 { field: 'Description', title: '");
#nullable restore
#line 87 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Log\Index.cshtml"
                                            Write(Html.DisplayNameFor(a=>a.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', sort: true },\r\n                { field: \'CreateDate\', title: \'");
#nullable restore
#line 88 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Log\Index.cshtml"
                                          Write(Html.DisplayNameFor(a => a.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', sort: true, templet: '<div>{{__subDateTime(d.CreateDate)}}</div>' }
            ]]
        });
        var active = {
            reload: function () {
                var jsonWhere = urlToJson($(""#formSearch"").serialize());
                //执行重载
                table.reload('defaultReload', {
                    page: {
                        curr: 1 //重新从第 1 页开始
                    }
                  , where: jsonWhere
                });
            }
        };
        //服务器排序
        table.on('sort(LogTable)', function (obj) {
            table.reload('defaultReload', {
                initSort: obj
              , where: { //请求参数
                  field: obj.field //排序字段
                , order: obj.type //排序方式
              }
            });
        });
        //查询
        $(""#btnQuery"").on('click', function () {
            var type = $(this).data('type');
            active[type] ? active[type].call(this) : '';
        });
        //监控工具栏
        table.on('toolba");
            WriteLiteral(@"r(LogTable)', function (obj) {
            if (obj.event === 'del') {
                var checkStatus = table.checkStatus('defaultReload');
                if (checkStatus.data.length > 0) {
                    var data = checkStatus.data;
                    var arr = [];
                    for (var i = 0; i < data.length; i++) {
                        arr.push(data[i].Id);
                    }
                    $.post('/System/Log/AllDel', { ids: arr.join(',') }, function (data) {
                        if (data.State) {
                            setTimeout(function () {
                                window.location.reload();
                            }, 1000);
                            common.msgSuccess(data.Message);
                        }
                        else {
                            common.msgError(data.Message);
                        }
                    });
                }
                else {
                    common.msgError(""未选中任何行"");
  ");
            WriteLiteral("              }\r\n            }\r\n        });\r\n    });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YCProduction.Model.Entitys.System.SysLog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
