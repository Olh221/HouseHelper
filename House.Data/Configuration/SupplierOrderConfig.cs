using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace House.Data.Configuration
{
    public class SupplierOrderEntityConfiguration : IEntityTypeConfiguration<SupplierOrder>
    {
        public void Configure(EntityTypeBuilder<SupplierOrder> builder)
        {
            builder
                .HasNoKey();
            builder
            .Property(i => i.Order)
            .IsRequired();

            builder
            .Property(i => i.Service)
            .IsRequired();

            builder
            .Property(e => e.Feedback)
            .ValueGeneratedOnAdd()
            .IsRequired();

            builder
            .Property(e => e.Status)
            .ValueGeneratedOnAdd()
            .IsRequired();

            builder
            .Property(e => e.OrderPrice)
            .HasColumnType("numeric").IsRequired();
        }
    }
}
