using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Model.Entitys.Interface
{
    public interface ISoftCreate
    {
        int? CreateBy { get; set; }
        DateTime? CreateDate { get; set; }
    }
}
