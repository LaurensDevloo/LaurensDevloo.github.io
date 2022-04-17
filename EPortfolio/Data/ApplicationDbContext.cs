using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using EPortfolio.Models.Domain;
using EPortfolio.Data.Mappers;

namespace EPortfolio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet <Person> Persons { get; set; }
        public DbSet <MBTI> MBTIs { get; set; }
        public DbSet <Taal>  Talen { get; set; }
        public DbSet <Offman> Offmans { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = @"Server=.;Database=Eportfolio;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionstring);
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new PersonConfiguration());
            builder.ApplyConfiguration(new MBTIConfiguration());
            builder.ApplyConfiguration(new TaalConfiguration());
            builder.ApplyConfiguration(new OffmanConfiguration());
            builder.ApplyConfiguration(new RealisatieConfiguration());
        }
    }
}