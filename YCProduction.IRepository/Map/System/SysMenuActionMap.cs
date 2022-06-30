using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.System;

namespace YCProduction.IRepository.Map
{
    public class SysMenuActionMap : IEntityTypeConfiguration<SysMenuAction>
    {
        public void Configure(EntityTypeBuilder<SysMenuAction> builder)
        {
            builder.ToTable("Sys_MenuAction");
            builder.HasKey(hh => hh.Id);
        }
    }
}
