using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace House.Data.Configuration
{
    public class StatusrderEntityConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder
                .HasKey(e => e.ID);

            builder
                .Property(e => e.Name)
                .HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
