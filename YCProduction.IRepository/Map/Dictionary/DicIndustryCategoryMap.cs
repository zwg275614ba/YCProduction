using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.Dictionary;

namespace YCProduction.IRepository.Map.Dictionary
{
    public class DicIndustryCategoryMap : IEntityTypeConfiguration<DicIndustryCategory>
    {
        public void Configure(EntityTypeBuilder<DicIndustryCategory> builder)
        {
            builder.ToTable("Dic_IndustryCategory");
            builder.HasKey(hh => hh.Id);
            builder.Property(hh => hh.IndustryCategoryId).HasMaxLength(50);
            builder.Property(hh => hh.IndustryCategory).HasMaxLength(100);
        }
    }
}
