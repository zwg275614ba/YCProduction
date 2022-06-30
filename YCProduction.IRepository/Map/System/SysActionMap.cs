using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.System;

namespace YCProduction.IRepository.Map
{
    public class SysActionMap : IEntityTypeConfiguration<SysAction>
    {
        public void Configure(EntityTypeBuilder<SysAction> builder)
        {
            builder.ToTable("Sys_Action");
            builder.HasKey(hh => hh.Id);
            builder.Property(hh => hh.ActionCode).HasMaxLength(20);
            builder.Property(hh => hh.ActionName).HasMaxLength(50);
            builder.Property(hh => hh.Icon).HasMaxLength(50);
            builder.Property(hh => hh.Method).HasMaxLength(50);
            builder.Property(hh => hh.ClassName).HasMaxLength(50);
        }
    }
}
