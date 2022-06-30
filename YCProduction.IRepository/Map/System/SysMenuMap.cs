using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.System;

namespace YCProduction.IRepository.Map
{
    public class SysMenuMap : IEntityTypeConfiguration<SysMenu>
    {
        public void Configure(EntityTypeBuilder<SysMenu> builder)
        {
            builder.ToTable("Sys_Menu");
            builder.HasKey(hh=>hh.Id);
            builder.Property(hh => hh.MenuName).HasMaxLength(50);
            builder.Property(hh => hh.MenuIccon).HasMaxLength(50);
        }
    }
}
