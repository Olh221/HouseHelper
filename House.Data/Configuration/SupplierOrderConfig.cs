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
               .HasKey(e => e.ID);

            builder
                .Property(e => e.OrderPrice)
                .IsRequired();

            builder
               .HasOne(p => p.Service)
               .WithMany(b => b.SupplierOrders)
               .HasForeignKey(p => p.ServiceID);

            builder
               .HasOne(p => p.Order)
               .WithMany(b => b.SupplierOrders)
               .HasForeignKey(p => p.OrderID);

            builder
               .HasOne(p => p.Feedback)
               .WithMany(b => b.SupplierOrders)
               .HasForeignKey(p => p.FeedbackID);

            builder
               .HasOne(p => p.Status)
               .WithMany(b => b.SupplierOrders)
               .HasForeignKey(p => p.StatusID);
        }
    }
}
