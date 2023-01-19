using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace House.Data.Configuration
{
    public class ServiceEntityConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder
             .HasKey(e => e.ID);

            builder
             .Property(i => i.Suppliers)
             .ValueGeneratedOnAdd()
             .IsRequired();

            builder
             .Property(e => e.ServiceName)
             .HasColumnType("nvarchar(255)").IsRequired();

            builder
            .Property(i => i.ServicePrice)
            .HasColumnType("numeric").IsRequired();

            builder
             .Property(i => i.Description)
             .HasColumnType("nvarchar(255)").IsRequired();
        }
    }
}
