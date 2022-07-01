using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.Base;

namespace YCProduction.IRepository.Map.Base
{
    public class BaseDepartmentMap : IEntityTypeConfiguration<BaseDepartment>
    {
        public void Configure(EntityTypeBuilder<BaseDepartment> builder)
        {
            builder.ToTable("Base_Department");
            builder.HasKey(hh=>hh.Id);
            builder.Property(hh => hh.DepartmentId).HasMaxLength(50);
            builder.Property(hh=>hh.DepartmentName).HasMaxLength(50);
        }
    }
}
