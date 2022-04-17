using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using EPortfolio.Models.Domain;

namespace EPortfolio.Data.Mappers
{
    internal class RealisatieConfiguration : IEntityTypeConfiguration <Realisatie>
    {
        public void Configure(EntityTypeBuilder <Realisatie> builder)
        {
            builder.ToTable("Realisatie");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Begin);
            builder.Property(t => t.End);
            builder.Property(t => t.Description);
            builder.Property(t => t.Link);
        }
    }
}