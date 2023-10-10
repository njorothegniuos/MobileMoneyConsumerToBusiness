using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ConsumerToBusinessConfiguration : IEntityTypeConfiguration<ConsumerToBusiness>
    {
        public void Configure(EntityTypeBuilder<ConsumerToBusiness> builder)
        {
            builder.ToTable("ConsumerToBusiness");
            builder.HasKey(x => x.ConsumerToBusinessId);

            builder.Property(x => x.TransactionType).HasMaxLength(100);
            builder.Property(x => x.TransID).HasMaxLength(30);
            builder.Property(x => x.BillRefNumber).HasMaxLength(300);
        }
    }
}
