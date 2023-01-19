using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace House.Data.Configuration
{
    public class StatusrderEntityConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder
             .HasKey(e => e.ID);

            builder
            .Property(e => e.SupplierOrder)
            .ValueGeneratedOnAdd()
            .IsRequired();

            builder
            .Property(e => e.Name)
            .ValueGeneratedOnAdd()
            .HasColumnType("nvarchar(255)").IsRequired();
        }
    }
}
