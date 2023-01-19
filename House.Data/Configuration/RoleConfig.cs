using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace House.Data.Configuration
{
    public class RoleEntityConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder
                .HasNoKey();

            builder
            .Property(e => e.User)
            .ValueGeneratedOnAdd()
            .IsRequired();

            builder
            .Property(e => e.Name)
            .HasColumnType("nvarchar(255)").IsRequired();
        }
    }
}
