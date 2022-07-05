using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YCProduction.Model.Entitys.Dictionary
{
    public class DicProjectCategory : PrimaryKey<int>
    {
        [DisplayName("项目类别ID")]
        public string ProjectCategoryId { get; set; }
        [DisplayName("行业类别ID")]
        public string IndustryCategoryId { get; set; }
        [DisplayName("项目类别")]
        public string ProjectCategory { get; set; }
        [DisplayName("备注")]
        public string Remarks { get; set; }
    }
}
