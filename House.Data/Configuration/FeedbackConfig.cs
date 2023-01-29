using House.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace House.Data.Configuration
{
    public class FeedbackEntityConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder
                 .HasKey(e => e.ID);

            builder
                 .Property(e => e.Comment)
                 .HasColumnType("nvarchar(2000)");

            builder
                .HasOne(p => p.Supplier)
                .WithMany(b => b.Feedbacks)
                .HasForeignKey(p => p.SupplierID);
        }
    }
}
