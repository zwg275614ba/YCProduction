using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YCProduction.Model.Entitys.Base
{
    public class BaseDepartment : PrimaryKey<int>
    {
        [DisplayName("部门ID")]
        public string DepartmentId { get; set; }
        [DisplayName("部门名称")]
        public string DepartmentName { get; set; }
        [DisplayName("人数")]
        public int? Counts { get; set; }
        [DisplayName("职责")]
        public string Duty { get; set; }
        [DisplayName("考核指标")]
        public string Assessment { get; set; }
        [DisplayName("备注")]
        public string Remarks { get; set; }
        public int? ParentId { get; set; }
    }
}
