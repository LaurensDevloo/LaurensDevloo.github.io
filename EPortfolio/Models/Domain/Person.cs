using System;
using System.Collections.Generic;

namespace EPortfolio.Models.Domain
{
    public class Person
    {        
        public int Id { get; set; }
        public int Postcode { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public MBTI MBTI { get; set; }
        public Offman Offman { get; set; }

        public List <Realisatie> Realistaties { get; set; }
        public List <Taal> Talen { get; set; }

        protected Person () {}

        public Person (string naam, string firstName, string address, string telefone,
                       string cell, string city, string email, DateTime bDay, int pstcode)
                      : this()
        {
            this.Name = naam;
            this.FirstName = firstName;
            this.Address = address;
            this.TelephoneNumber = telefone;
            this.CellNumber = cell;
            this.City = city;
            this.BirthDay = bDay;
            this.Postcode = pstcode;
            this.Email = email;

            this.MBTI = new MBTI ();
            this.Offman = new Offman ();

            this.Realistaties = new List <Realisatie> ();
            this.Talen = new List <Taal> ();
        }

        public void AddRealisatie (Realisatie realisatie)
        {
            this.Realistaties.Add(realisatie);
        }

        public void RemoveRealisatie (Realisatie realisatie)
        {
            this.Realistaties.Remove(realisatie);
        }

        public void AddTaal (Taal taal)
        {
            this.Talen.Add(taal);
        }

        public void RemoveTaal (Taal taal)
        {
            this.Talen.Remove(taal);
        }

        public string GetPathToImage ()
        {
            return "/img/" + this.FirstName + "_" + this.Name + ".png";
        }

        public string GetPathToCv ()
        {
            return "/bestanden/" + this.FirstName + "_" + this.Name + ".pdf";
        }

        public int BerekenLeeftijd ()
        {
            return DateTime.Now.Year - BirthDay.Year;
        }
    }
}