using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.System;

namespace YCProduction.IRepository.Map
{
    public class SysRoleMenuActionMap : IEntityTypeConfiguration<SysRoleMenuAction>
    {
        public void Configure(EntityTypeBuilder<SysRoleMenuAction> builder)
        {
            builder.ToTable("Sys_RoleMenuAction");
            builder.HasKey(hh => hh.Id);
        }
    }
}
