using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.Interface;

namespace YCProduction.Model.Entitys
{
    public class PrimaryKey<T> : IPrimaryKey<T>
    {
        public T Id { get; set; }
    }
}
