using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace House.Data.Configuration
{
    public class SupplierEntityConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder
             .HasKey(e => e.ID);

            builder
             .Property(i => i.User)
             .IsRequired();

            builder
             .Property(e => e.Service)
             .IsRequired();

            builder
             .Property(e => e.Feedbacks)
             .IsRequired();
        }
    }
}
