using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.Base;

namespace YCProduction.IRepository.Map.Base
{
    public class BasePositionalTitleMap : IEntityTypeConfiguration<BasePositionalTitle>
    {
        public void Configure(EntityTypeBuilder<BasePositionalTitle> builder)
        {
            builder.ToTable("Base_PositionalTitle");
            builder.HasKey(hh=>hh.Id);
            builder.Property(hh=>hh.Code).HasMaxLength(50);
            builder.Property(hh => hh.Name).HasMaxLength(50);
        }
    }
}
