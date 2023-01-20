using House.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebAppHouseHelper.Data.Configuration
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                 .HasKey(e => e.ID);

            builder
                .Property(e => e.OrderDate)
                .ValueGeneratedOnAdd()
                .HasColumnType("datetime").IsRequired();

            builder
                 .HasOne(p => p.User)
                 .WithMany(b => b.Orders)
                .HasForeignKey(p => p.UserID);
        }
    }
    
}
