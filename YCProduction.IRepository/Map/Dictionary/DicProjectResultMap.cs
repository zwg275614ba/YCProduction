using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.Dictionary;

namespace YCProduction.IRepository.Map.Dictionary
{
    public class DicProjectResultMap : IEntityTypeConfiguration<DicProjectResult>
    {
        public void Configure(EntityTypeBuilder<DicProjectResult> builder)
        {
            builder.ToTable("Dic_ProjectResult");
            builder.HasKey(hh => hh.Id);
            builder.Property(hh => hh.ResultId).HasMaxLength(50);
        }
    }
}
