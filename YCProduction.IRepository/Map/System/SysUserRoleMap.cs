using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.System;

namespace YCProduction.IRepository.Map
{
    public class SysUserRoleMap : IEntityTypeConfiguration<SysUserRole>
    {
        public void Configure(EntityTypeBuilder<SysUserRole> builder)
        {
            builder.ToTable("Sys_UserRole");
            builder.HasKey(hh => hh.Id);
        }
    }
}
