using System;

namespace EPortfolio.Models.Domain
{
    public class Realisatie
    {
        private static int IdCount = 0;
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Begin { get; set; }
        public string End { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        protected Realisatie () {}

        public Realisatie(string begin, string end, string name, string discription)
        {
            this.Id = Realisatie.IdCount++;
            this.Name = name;
            this.Begin = begin;
            this.End = end;
            this.Description = discription;
            this.Link = "";
        }
    }
}