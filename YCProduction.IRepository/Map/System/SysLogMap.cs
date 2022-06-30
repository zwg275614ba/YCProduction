using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.System;

namespace YCProduction.IRepository.Map
{
    public class SysLogMap : IEntityTypeConfiguration<SysLog>
    {
        public void Configure(EntityTypeBuilder<SysLog> builder)
        {
            builder.ToTable("Sys_Log");
            builder.HasKey(hh=>hh.Id);
            builder.Property(hh => hh.UserName).HasMaxLength(50);
        }
    }
}
