using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using EPortfolio.Models.Domain;

namespace EPortfolio.Data.Mappers
{
    internal class PersonConfiguration : IEntityTypeConfiguration <Person>
    {
        public void Configure(EntityTypeBuilder <Person> builder)
        {
            builder.ToTable("Person");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.HasOne(t => t.MBTI).WithOne();
            builder.HasOne(t => t.Offman).WithOne();

            builder.HasMany(t => t.Realistaties)
                   .WithOne()
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(t => t.Talen)
                   .WithOne()
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}