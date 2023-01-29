using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace House.Data.Configuration
{
    public class ServiceEntityConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder
                .HasKey(e => e.ID);

            builder
                .Property(e => e.ServiceName)
                .HasColumnType("nvarchar(255)").IsRequired();

            builder
                .Property(i => i.Description)
                .HasColumnType("nvarchar(255)").IsRequired();
        }
    }
}
