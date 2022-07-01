using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.Model.Entitys.Base;

namespace YCProduction.IRepository.Map.Base
{
    public class BaseCustomerInfoMap : IEntityTypeConfiguration<BaseCustomerInfo>
    {
        public void Configure(EntityTypeBuilder<BaseCustomerInfo> builder)
        {
            builder.ToTable("Base_CustomerInfo");
            builder.HasKey(hh => hh.Id);
            builder.Property(hh => hh.CustomerId).HasMaxLength(50);
            builder.Property(hh => hh.CustomerCompany).HasMaxLength(200);
            builder.Property(hh => hh.LegalPerson).HasMaxLength(50);
            builder.Property(hh => hh.Phone).HasMaxLength(50);
            builder.Property(hh => hh.Contact).HasMaxLength(50);
            builder.Property(hh => hh.Position).HasMaxLength(50);
            builder.Property(hh => hh.Bank).HasMaxLength(50);
            builder.Property(hh => hh.OpenAccount).HasMaxLength(50);
        }
    }
}
