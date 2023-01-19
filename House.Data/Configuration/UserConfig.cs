using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace House.Data.Configuration
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(e => e.ID);

            builder
                .Property(i => i.FirstName)
                .HasColumnType("nvarchar(255)").IsRequired();
            builder
               .Property(i => i.LastName)
               .HasColumnType("nvarchar(255)").IsRequired();
            builder
               .Property(i => i.Email)
               .HasColumnType("nvarchar(255)").IsRequired();
            builder
               .Property(i => i.CompanyName)
               .HasColumnType("nvarchar(255)").IsRequired();
            builder
               .Property(i => i.PhoneNumber)
               .HasColumnType("varchar(15)").IsRequired();

            builder
            .Property(e => e.Role)
            .ValueGeneratedOnAdd()
            .IsRequired();
        }
    }
}
