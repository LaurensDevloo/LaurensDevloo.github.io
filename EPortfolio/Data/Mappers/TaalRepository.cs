using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using EPortfolio.Models.Domain;

namespace EPortfolio.Data.Mappers
{
    internal class TaalConfiguration : IEntityTypeConfiguration <Taal>
    {
        public void Configure (EntityTypeBuilder <Taal> builder)
        {
            builder.ToTable("Taal");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Naam);
            builder.Property(t => t.Niveau);
        }
    }
}