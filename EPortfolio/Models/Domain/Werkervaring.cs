namespace EPortfolio.Models.Domain
{
    public class Werkervaring
    {
        private static int IdCount = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Begin { get; set; }
        public string End { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        protected Werkervaring() { }

        public Werkervaring(string begin, string end, string name, string discription)
        {
            this.Id = Werkervaring.IdCount++;
            this.Name = name;
            this.Begin = begin;
            this.End = end;
            this.Description = discription;
            this.Link = "";
        }
    }
}
