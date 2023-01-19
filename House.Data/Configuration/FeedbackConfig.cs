using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Graph;
using System.Reflection.Emit;

namespace House.Data.Configuration
{
    public class FeedbackEntityConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder
                .HasKey(e => e.ID);

            builder
             .Property(e => e.Supplier)
             .IsRequired();

            builder
             .Property(i => i.Rate)
             .HasColumnType("numeric");

            builder
             .Property(e => e.Comment)
             .HasColumnType("nvarchar(255)");

            builder
            .HasOne(p => p.Supplier)
            .WithMany(b => b.Feedbacks);
        }
    }
}
