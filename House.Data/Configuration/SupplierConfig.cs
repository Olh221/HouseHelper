using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace House.Data.Configuration
{
    public class SupplierEntityConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder
                .HasKey(e => e.ID);

            builder
                .HasOne(p => p.Service)
                .WithMany(b => b.Suppliers)
                .HasForeignKey(p => p.ServiceID);

            builder
               .HasOne(p => p.User)
               .WithMany(b => b.Suppliers)
               .HasForeignKey(p => p.UserID);
        }
    }
}
