using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.Interface;

namespace YCProduction.Model.Entitys.System
{
    public class SysUserRole : IPrimaryKey<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
