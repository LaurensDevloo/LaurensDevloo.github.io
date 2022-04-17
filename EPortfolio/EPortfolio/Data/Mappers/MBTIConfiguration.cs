using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using EPortfolio.Models.Domain;

namespace EPortfolio.Data.Mappers
{
    internal class MBTIConfiguration : IEntityTypeConfiguration <MBTI>
    {
        public void Configure (EntityTypeBuilder <MBTI> builder)
        {
            builder.ToTable("MBTI");

            builder.HasKey(t => t.Id);

            builder.HasMany(t => t.Type)
                   .WithOne()
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}