using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.System;

namespace YCProduction.IRepository.Map
{
    public class SysRoleMap : IEntityTypeConfiguration<SysRole>
    {
        public void Configure(EntityTypeBuilder<SysRole> builder)
        {
            builder.ToTable("Sys_Role");
            builder.HasKey(hh => hh.Id);
            builder.Property(hh => hh.RoleName).HasMaxLength(50);
        }
    }
}
