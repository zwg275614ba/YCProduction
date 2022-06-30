using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using YCProduction.Model.Entitys.Interface;

namespace YCProduction.Model.Entitys
{
    public class AggregateRoot : IPrimaryKey<int>, ISoftUpdate, ISoftCreate
    {
        public int Id { get; set; }
        public int? UpdateBy { get; set; }
        [DisplayName("更新时间")]
        public DateTime? UpdateDate { get; set; }
        public int? CreateBy { get; set; }
        [DisplayName("创建时间")]
        public DateTime? CreateDate { get; set; }
    }
}
