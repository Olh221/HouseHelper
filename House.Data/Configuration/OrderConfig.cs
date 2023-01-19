using House.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace WebAppHouseHelper.Data.Configuration
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
             .HasKey(e => e.ID);

            builder
            .Property(e => e.User)
            .ValueGeneratedOnAdd()
            .IsRequired();

            builder
            .Property(e => e.OrderDate)
            .ValueGeneratedOnAdd()
            .HasColumnType("datetime").IsRequired();
        }
    }
    
}
