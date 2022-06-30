using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using YCProduction.Model.Entitys.Values;

namespace YCProduction.Model.Entitys.System
{
    public class SysAction: AggregateRoot
    {
        public string ActionCode { get; set; }
        [DisplayName("按钮名称")]
        public string ActionName { get; set; }
        [DisplayName("图标")]
        public string Icon { get; set; }
        [DisplayName("方法")]
        public string Method { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
        [DisplayName("排序")]
        public int? OrderBy { get; set; }
        [DisplayName("样式")]
        public string ClassName { get; set; }
        [DisplayName("显示位置")]
        public ButtonPosition? Position { get; set; }
    }
}
