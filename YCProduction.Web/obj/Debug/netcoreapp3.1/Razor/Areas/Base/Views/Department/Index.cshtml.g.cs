#pragma checksum "C:\Users\Administrator\source\repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0845343557da4cf86c795bda6675ffe77e26051d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Base_Views_Department_Index), @"mvc.1.0.view", @"/Areas/Base/Views/Department/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\YCProduction\YCProduction.Web\Areas\Base\Views\_ViewImports.cshtml"
using YCProduction.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\YCProduction\YCProduction.Web\Areas\Base\Views\_ViewImports.cshtml"
using YCProduction.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0845343557da4cf86c795bda6675ffe77e26051d", @"/Areas/Base/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4d0169f17ef362daab9a3ba68048e1cab380ed7", @"/Areas/Base/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Base_Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutList.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!----------------查 询------------------->\r\n<div class=\"layui-card\">\r\n    <div class=\"layui-card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0845343557da4cf86c795bda6675ffe77e26051d4906", async() => {
                WriteLiteral("\r\n            <div class=\"layui-form-item\">\r\n                <div>\r\n                    ");
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\Index.cshtml"
               Write(Html.TopToolBarHtml(ViewData["ActionFormRightTop"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
<!-------------表格--------------->
<div class=""layui-card"">
    <div class=""layui-card-body"">
        <table id=""department-table"" lay-filter=""department-table""></table>
    </div>
</div>
<!------------------工具栏------------------------->
<script type=""text/html"" id=""toolBar"">
    ");
#nullable restore
#line 27 "C:\Users\Administrator\source\repos\YCProduction\YCProduction.Web\Areas\Base\Views\Department\Index.cshtml"
Write(Html.ToolBarHtml(ViewData["ActionList"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</script>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        layui.use(['form', 'common', 'treetable', 'table'], function () {
            var form = layui.form,
                common = layui.common,
                table = layui.table,
                treetable = layui.treetable;
            $ = layui.$;
            //渲染表格
            treetable.render({
                treeColIndex: 1,
                treeSpid: -1,
                treeIdName: 'Id',
                height: 'full-110',
                toolbar: true,
                treePidName: 'ParentId',
                elem: '#department-table',
                url: '/Base/department/GetDepartmentList',
                page: false,
                cols: [[
                    { field: 'DepartmentId', title: '部门ID', width: 150 },
                    { field: 'DepartmentName', title: '部门名称', width: 200 },
                    { field: 'Duty', title: '职责', width: 400 },
                    { field: 'Remarks', title: '备注', width: 180 },
                ");
                WriteLiteral(@"    { field: '', title: '操作', toolbar: '#toolBar', width: 260 }
                ]]
            });
            //添加
            $('#btnAdd').on('click', function () {
                common.openTop({
                    title: '添加部门', w: '600px', h: '500px', content: '/Base/department/AddDepartment/'
                });
            });
            //监听工具栏
            table.on('tool(department-table)', function (obj) {
                var data = obj.data;
                //编辑
                if (obj.event === 'edit') {
                    common.openTop({
                        title: '编辑部门', w: '600px', h: '500px', content: '/Base/department/EditDepartment/' + data.Id
                    });
                }//删除
                else if (obj.event === 'del') {
                    layer.confirm('确定要删除该记录', function (index) {
                        $.post('/Base/department/DelInfo', { id: data.Id }, function (data) {
                            if (data.State) {
                         ");
                WriteLiteral(@"       obj.del();//删除这一行
                                tipSuccess(data.Message);
                            }
                            else {
                                tipError(data.Message);
                            }
                            layer.close(index);//关闭弹框
                        });
                    });
                }
            });
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
