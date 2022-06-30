using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using YCProduction.Model.Entitys.Values;

namespace YCProduction.Model.Entitys.System
{
    public class SysRole : AggregateRoot
    {
        [DisplayName("角色名称")]
        public string RoleName { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
        [DisplayName("状态")]
        public RoleStatus? Status { get; set; }
    }
}
