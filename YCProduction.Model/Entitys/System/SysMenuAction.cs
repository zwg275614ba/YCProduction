using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.Interface;

namespace YCProduction.Model.Entitys.System
{
    public class SysMenuAction : IPrimaryKey<int>
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public int ActionId { get; set; }
    }
}
