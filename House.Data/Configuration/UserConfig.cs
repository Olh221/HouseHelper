using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

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
               .Property(i => i.PasswordHash)
               .HasColumnType("varchar(255)").IsRequired();

            builder
               .Property(i => i.PhoneNumber)
               .HasColumnType("varchar(15)").IsRequired();

            builder
                .HasOne(p => p.Role)
                .WithMany(b => b.Users)
                .HasForeignKey(p => p.RoleID);
        }
    }
}
