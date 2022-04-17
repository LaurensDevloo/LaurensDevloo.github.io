using System;
using System.Collections.Generic;

namespace EPortfolio.Models.Domain
{
    public class MBTI
    {
        private static int IdCount = 0;

        public int Id { get; set; }
        public List <string> Type { get; set; }

        public MBTI ()
        {
            this.Id = MBTI.IdCount++;

            this.Type = new List <string> ();
        }

        public MBTI (string first, string second, string thrid, string fourth)
        {
            this.Type = new List<string>();

            this.CheckFirst(first);
            this.CheckSecond(second);
            this.CheckThird(thrid);
            this.CheckFourth(fourth);

            this.Type.Add(first);
            this.Type.Add(second);
            this.Type.Add(thrid);
            this.Type.Add(fourth);
        }

        public string GiveADescribtion ()
        {
            string output;

            output = GiveEverything() + "\n\n";
            output += GiveDescriptionFirst() + "\n\n" + GiveDescriptionSecond() + "\n" + GiveDescriptionThird() + "\n" + GiveDescriptionFourth();

            return output;
        }

        private string GiveDescriptionFirst()
        {
            string input = this.Type[0];
            string output;

            if (input == "E")
            {
                output = "Extrovert:\nDit wilt zeggen dat ik mijn energie haal uit andere en buiten mezelf.\n";
            } else
            {
                output = "Introvert:\nDit wilt zeggen dat ik mijn energie eerder uit mezelf haal en uit interne zaken dan uit mijn omgeving.\n";
            }

            return output;
        }

        private string GiveDescriptionSecond()
        {
            string input = this.Type[1];
            string output;

            if (input == "S")
            {
                output = "Sensing:\nDit wilt zeggen dat ik mij vooral focus op feitelijke concrete informatie rondom mij. Hiervoor maak ik gebruik van mijn voorgaande ervaringen en eerder opgenomen informatie.\n";
            }
            else
            {
                output = "Introvert:\nDit wilt zeggen dat ik mij vooral focus op de grote lijnen en gebruik maak van inspiratie en mogelijkheden uit de toekomst. Ik focus me dus in andere woorden op de toekomst.\n";
            }

            return output;
        }

        private string GiveDescriptionThird()
        {
            string input = this.Type[2];
            string output;

            if (input == "T")
            {
                output = "Thinking:\nDit wilt zeggen dat ik bij het nemen van beslissingen vooral focus op logica en het afwegen van inhoudelijke argumenten.\n";
            }
            else
            {
                output = "Feeling:\nDit wilt zeggen dat ik bij het nemen van beslissingen vooral focus op mijn eigen normen en waarden naast de impact, die de beslissing zal hebben op de betrokkenen.\n";
            }

            return output;
        }

        private string GiveDescriptionFourth()
        {
            string input = this.Type[3];
            string output;

            if (input == "J")
            {
                output = "Judging:\nHiermee wil ik zeggen dat ik een planmatige en geordende manier het aangenaamste vind om mee te werken. Zodat ik mijn zaken kan afronden.\n";
            }
            else
            {
                output = "Perceiving:\nIk werk het liefste op een flexibele en spontane manier. Hiermee hou ik mijn opties open.\n";
            }

            return output;
        }

        public string GiveEverything ()
        {
            string output = "";


            foreach(string t in this.Type)
            {
                output += t;
            }

            output += "\n";

            return output;
        }

        private void CheckFirst (string str)
        {
            if (str != "E" || str != "I")
            {
                throw new ArgumentException("The first letter should be an E or an I.");
            }
        }

        private void CheckSecond (string str)
        {
            if (str != "S" || str != "N")
            {
                throw new ArgumentException("The second letter should be a S or a N.");
            }
        }

        private void CheckThird(string str)
        {
            if (str != "T" || str != "F")
            {
                throw new ArgumentException("The third letter should be a T or a F.");
            }
        }

        private void CheckFourth(string str)
        {
            if (str != "J" || str != "P")
            {
                throw new ArgumentException("The fourth letter should be a J or a P.");
            }
        }
    }
}
