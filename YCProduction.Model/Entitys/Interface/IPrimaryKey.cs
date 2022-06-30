using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Model.Entitys.Interface
{
    public interface IPrimaryKey<T>
    {
        T Id { get; set; }
    }
}
