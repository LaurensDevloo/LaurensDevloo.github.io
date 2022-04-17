using System;
using System.Linq;

namespace EPortfolio.Models.Domain
{
    public class Taal
    {
        private static int IdCount = 0;
       
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Niveau { get; set; }

        protected Taal () {}

        public Taal (string naam, string niveau): this()
        {
            this.Id = Taal.IdCount++;
            
            this.Naam = naam;

            this.CheckNiveau(niveau);

            this.Niveau = niveau;
        }

        private void CheckNiveau (string niveau)
        {
            string[] mogelijkheden = { "A1", "A2", "B1", "B2", "C1", "C2", "Moedertaal" };

            if (!mogelijkheden.Contains(niveau))
            {
                throw new ArgumentException("Your level is not legit.");
            }
        }
    }
}