using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YCProduction.Model.Entitys.System;
using YCProduction.Model.Entitys.Values;

namespace Microsoft.AspNetCore.Mvc
{
    public static class MyExtHtmlLabel
    {
        /// <summary>
        /// 表单内工具栏
        /// </summary>
        /// <param name="helper"></param>
        /// <returns></returns>
        public static HtmlString ToolBarHtml(this IHtmlHelper helper, dynamic _list = null)
        {
            StringBuilder sb = new StringBuilder();
            var list = _list as List<SysAction>;
            if (list != null && list.Count > 0)
            {
                foreach (var v in list)
                {
                    var _icon = string.IsNullOrEmpty(v.Icon) ? "" : string.Format("<i class='fa {0}'></i>", v.Icon);
                    sb.AppendFormat("<a class='layui-btn layui-btn-xs {0}' lay-event='{1}'>{3}{2}</a>", v.ClassName, v.Method, v.ActionName, _icon);
                }
            }
            return new HtmlString(sb.ToString());
        }

        /// <summary>
        /// 表单外工具栏
        /// </summary>
        /// <param name="helper"></param>
        /// <returns></returns>
        public static HtmlString TopToolBarHtml(this IHtmlHelper helper, dynamic _list = null, string initTxt = null)
        {
            StringBuilder sb = new StringBuilder();
            var list = _list as List<SysAction>;
            if (list != null && list.Count > 0)
            {
                foreach (var v in list)
                {
                    //sb.AppendFormat(@"<a href='javascript:;' class='layui-btn layui-btn-sm {0}' id='btn{1}'>
                    //        <i class='fa {2}'></i> {3}
                    //    </a>", v.ClassName, v.ActionCode, v.Icon, initTxt == null ? v.ActionName : initTxt);
                    sb.Append($"<a href='javascript:;' class='pear-btn pear-btn-primary pear-btn-md' id='btn{v.ActionCode}' lay-event='add'> <i class='layui-icon layui-icon-add-1'></i>{v.ActionName} </a>");
                }
            }
            return new HtmlString(sb.ToString());
        }

        /// <summary>
        /// 日记类型下拉框
        /// </summary>
        /// <param name="help"></param>
        /// <param name="_name"></param>
        /// <returns></returns>
        public static HtmlString DrownHtml(this IHtmlHelper help, dynamic _name = null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<select name={0}>", _name));
            sb.Append("<option value=''>请选择</option>");
            sb.Append("<option value='8'>登录</option>");
            sb.Append("<option value='1'>退出</option>");
            sb.Append("<option value='3'>添加</option>");
            sb.Append("<option value='5'>编辑</option>");
            sb.Append("<option value='3'>删除</option>");
            sb.Append("</select>");
            return new HtmlString(sb.ToString());
        }
        /// <summary>
        /// 登录状态下拉框
        /// </summary>
        /// <param name="help"></param>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static HtmlString LoginDownHtml(this IHtmlHelper help, string txt, string _name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(" <select name={0}>", _name));
            sb.Append(string.Format("<option value=''>{0}</option>", txt));
            sb.Append(string.Format("<option value='1'>是</option><option value='0'>否</option></select>"));
            return new HtmlString(sb.ToString());
        }

        /// <summary>
        /// 性别单选框
        /// </summary>
        /// <returns></returns>
        public static HtmlString GenderRadioHtml(this IHtmlHelper help, dynamic ckeckedVal = null)
        {
            var check = ckeckedVal == 0 ? "checked" : "";
            var check2 = ckeckedVal == 0 ? "" : "checked";
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<input type=\"radio\" name=\"Gender\" value=\"0\" title=\"男\" {0}>", check));
            sb.Append(string.Format("<input type=\"radio\" name=\"Gender\" value=\"1\" title=\"女\" {0}>", check2));
            return new HtmlString(sb.ToString());
        }

        /// <summary>
        /// 状态单选框
        /// </summary>
        /// <param name="help"></param>
        /// <param name="ckeckedVal"></param>
        /// <returns></returns>
        public static HtmlString StateRadioHtml(this IHtmlHelper help, int ckeckedVal = 0)
        {
            var check = ckeckedVal == 0 ? "" : "checked";
            var check2 = ckeckedVal == 0 ? "checked" : "";
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<input type=\"radio\" name=\"Status\" value=\"1\" title=\"关闭\" {0}>", check));
            sb.Append(string.Format("<input type=\"radio\" name=\"Status\" value=\"0\" title=\"开启\" {0}>", check2));
            return new HtmlString(sb.ToString());
        }

        /// <summary>
        /// 显示位置下拉框
        /// </summary>
        /// <param name="help"></param>
        /// <param name="selectedVal"></param>
        /// <returns></returns>
        public static HtmlString SelectHtml(this IHtmlHelper help, int selectedVal)
        {
            var selected1 = selectedVal == 0 ? "selected" : "";
            var selected2 = selectedVal == 0 ? "" : "selected";
            StringBuilder sb = new StringBuilder();
            sb.Append(" <select name=\"Position\" lay-verify=\"Position\" lay-vertype=\"tips\"><option value=''>请选择</option>");
            sb.Append(string.Format("<option value='0' {0}>表内</option>", selected1));
            sb.Append(string.Format("<option value='1' {0}>表外</option>", selected2));
            return new HtmlString(sb.ToString());
        }
    }
}

