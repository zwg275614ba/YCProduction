using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using YCProduction.Model.Entitys.Values;

namespace YCProduction.Model.Entitys.System
{
    public class SysMenu : AggregateRoot
    {
        [DisplayName("菜单")]
        public string MenuName { get; set; }
        [DisplayName("Url")]
        public string MenuUrl { get; set; }
        [DisplayName("图标")]
        public string MenuIccon { get; set; }
        [DisplayName("父级")]
        public int? ParentId { get; set; }
        [DisplayName("排序")]
        public int? OrderNo { get; set; }
        [DisplayName("状态")]
        public MenuStatus? Status { get; set; }
        [DisplayName("级别")]
        public int? MenuLevel { get; set; }
    }
}
