namespace EPortfolio.Models.Domain
{
    public class Offman
    {
        private static int IdCount = 0;
        
        public int Id { get; set; }
        public string CoreQuality { get; set; }
        public string Pitfall { get; set; }
        public string Challenge { get; set; }
        public string Allergy { get; set; }

        public Offman ()
        {
            this.Id = Offman.IdCount++;

            this.CoreQuality = "Diplomatiek";
            this.Pitfall = "Afstandelijk";
            this.Challenge = "Openheid";
            this.Allergy = "Directheid";
        }

        public Offman (string coreQuality, string pitfall, string challenge, string allergy)
        {
            this.CoreQuality = coreQuality;
            this.Pitfall = pitfall;
            this.Challenge = challenge;
            this.Allergy = allergy;
        }
    }
}