using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.Dictionary;

namespace YCProduction.IRepository.Map.Dictionary
{
    public class DicSetUpProjectCategoryMap : IEntityTypeConfiguration<DicSetUpProjectCategory>
    {
        public void Configure(EntityTypeBuilder<DicSetUpProjectCategory> builder)
        {
            builder.ToTable("Dic_SetUpProjectCategory");
            builder.HasKey(hh => hh.Id);
            builder.Property(hh => hh.CategoryId).HasMaxLength(50);
            builder.Property(hh => hh.Category).HasMaxLength(50);
        }
    }
}
