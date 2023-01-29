using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace House.Data.Configuration
{
    public class RoleEntityConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder
                .HasKey(p => p.ID);

            builder
                .Property(e => e.Name)
                .HasColumnType("nvarchar(50").IsRequired();
        }
    }
}
