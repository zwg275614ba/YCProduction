using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.Dictionary;

namespace YCProduction.IRepository.Map.Dictionary
{
    public class DicProjectCategoryMap : IEntityTypeConfiguration<DicProjectCategory>
    {
        public void Configure(EntityTypeBuilder<DicProjectCategory> builder)
        {
            builder.ToTable("Dic_ProjectCategory");
            builder.HasKey(hh => hh.Id);
            builder.Property(hh => hh.ProjectCategoryId).HasMaxLength(100);
            builder.Property(hh => hh.ProjectCategory).HasMaxLength(100);
            builder.Property(hh => hh.IndustryCategoryId).HasMaxLength(100);
        }
    }
}
