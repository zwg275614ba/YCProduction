#pragma checksum "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "179cec2f439fba9ae12e4eab869b5cb0d478ad85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_System_Views_Action_Index), @"mvc.1.0.view", @"/Areas/System/Views/Action/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179cec2f439fba9ae12e4eab869b5cb0d478ad85", @"/Areas/System/Views/Action/Index.cshtml")]
    #nullable restore
    public class Areas_System_Views_Action_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YCProduction.Model.Entitys.System.SysAction>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutList.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main\">\r\n    <!------------------查询-------------------------->\r\n    <fieldset class=\"table-search-fieldset\">\r\n        <legend>搜索信息</legend>\r\n        <div class=\"divQuery\">\r\n            <form class=\"layui-form\"");
            BeginWriteAttribute("action", " action=\"", 366, "\"", 375, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""formSearch"">
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">按钮名称</label>
                    <div class=""layui-input-inline"">
                        <input type=""text"" name=""ActionName"" placeholder=""按钮名称"" class=""layui-input"">
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
#line 25 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\Index.cshtml"
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
                <table id=""defaultTable"" lay-filter=""ActionTable""></table>
            </div>
        </div>
        <!------------------工具栏------------------------->
        <script type=""text/html"" id=""toolBar"">
            ");
#nullable restore
#line 39 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\Index.cshtml"
       Write(Html.ToolBarHtml(ViewData["ActionList"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </script>
</div>


<script type=""text/javascript"">
    layui.use(['form', 'table', 'common'], function () {
        var form = layui.form,
            common = layui.common,
            table = layui.table,
            $ = layui.$;
        //渲染表格
        table.render({
            id: 'defaultReload',
            elem: '#defaultTable',
            height: 'full-140',
            url: '/System/Action/GetActionList',
            toolbar: true,
            page: true,
            cols: [[
                 { field: 'Id', title: '");
#nullable restore
#line 59 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\Index.cshtml"
                                   Write(Html.DisplayNameFor(a=>a.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', sort: true, width: 100 },\r\n                { field: \'ActionName\', title: \'");
#nullable restore
#line 60 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\Index.cshtml"
                                          Write(Html.DisplayNameFor(a=>a.ActionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', sort: true, },\r\n                {\r\n                    field: \'Icon\', title: \'");
#nullable restore
#line 62 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\Index.cshtml"
                                      Write(Html.DisplayNameFor(a=>a.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', sort: true, templet: function (res) {\r\n                        return `<i class=\'fa ${res.Icon}\'></i>`\r\n                    }\r\n                },\r\n                 { field: \'Method\', title: \'");
#nullable restore
#line 66 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\Index.cshtml"
                                       Write(Html.DisplayNameFor(a=>a.Method));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', sort: true},\r\n                 { field: \'OrderBy\', title: \'");
#nullable restore
#line 67 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\Index.cshtml"
                                        Write(Html.DisplayNameFor(a=>a.OrderBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', sort: true },\r\n                { field: \'CreateDate\', title: \'");
#nullable restore
#line 68 "C:\Users\Administrator\Source\Repos\YCProduction\YCProduction.Web\Areas\System\Views\Action\Index.cshtml"
                                          Write(Html.DisplayNameFor(a => a.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', sort: true, templet: '<div>{{__subDateTime(d.CreateDate)}}</div>' },
                 { field: '', title: '操作', toolbar: '#toolBar', width: 180 }
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
        table.on('sort(ActionTable)', function (obj) {
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
            active[type] ? act");
            WriteLiteral(@"ive[type].call(this) : '';
        });
        //添加
        $('#btnAdd').on('click', function () {
            common.openTop({
                title: '添加功能', w: '600px', h: '650px', content: '/System/Action/AddAction/'
            });
        });
        //监听工具栏
        table.on('tool(ActionTable)', function (obj) {
            var data = obj.data;
            //编辑
            if (obj.event === 'edit') {
                common.openTop({
                    title: '编辑功能', w: '600px', h: '650px', content: '/System/Action/EditAction/' + data.Id
                });
            }//删除
            else if (obj.event === 'del') {
                layer.confirm('确定要删除该记录', function (index) {
                    $.post('/System/Action/DelInfo', { id: data.Id }, function (data) {
                        if (data.State) {
                            obj.del();//删除这一行
                            tipSuccess(data.Message);
                        }
                        else {
                    ");
            WriteLiteral("        tipError(data.Message);\r\n                        }\r\n                        layer.close(index);//关闭弹框\r\n                    });\r\n                });\r\n            }\r\n        });\r\n    });\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YCProduction.Model.Entitys.System.SysAction> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
