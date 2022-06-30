using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.System;

namespace YCProduction.IRepository.Map
{
    public class SysUserMap : IEntityTypeConfiguration<SysUser>
    {
        public void Configure(EntityTypeBuilder<SysUser> builder)
        {
            builder.ToTable("Sys_User");
            builder.HasKey(hh=>hh.Id);
            builder.Property(hh => hh.UserName).HasMaxLength(50);
            builder.Property(hh => hh.PassWord).HasMaxLength(50);
        }
    }
}
