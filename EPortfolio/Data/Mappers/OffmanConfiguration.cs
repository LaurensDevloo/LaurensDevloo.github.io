using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using EPortfolio.Models.Domain;

namespace EPortfolio.Data.Mappers
{
    internal class OffmanConfiguration : IEntityTypeConfiguration <Offman>
    {
        public void Configure (EntityTypeBuilder <Offman> builder)
        {
            builder.ToTable("Offman");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.CoreQuality);
            builder.Property(t => t.Pitfall);
            builder.Property(t => t.Challenge);
            builder.Property(t => t.Allergy);
        }
    }
}