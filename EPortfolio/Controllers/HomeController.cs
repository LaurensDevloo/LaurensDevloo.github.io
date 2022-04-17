using EPortfolio.Models;
using EPortfolio.Models.Domain;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Diagnostics;
using System.Globalization;

namespace EPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger <HomeController> _logger;
        private  Person Person;
        private  MBTI IBMTI;
        private Offman _offman;
        private Realisatie Realisatie;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            this.PrepareEverythingForDefault();
        }

        public IActionResult Index ()
        {
            
            return View(this.Person);
        }

        public IActionResult Privacy ()
        {
            return View();
        }

        public IActionResult MBTI ()
        {
            

            return View(this.Person);
        }

        public IActionResult Offman ()
        {
            return View(this.Person);
        }

        public IActionResult Realisaties ()
        {
            return View(this.Person);
        }

        public IActionResult Talen ()
        {
            return View(this.Person);
        }

        public IActionResult CV ()
        {
            return View(this.Person);
        }

        public IActionResult ProgrammeerTalen ()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void PrepareEverythingForDefault ()
        {
            this.Person = new Person ("Devloo", "Laurens", "Sint-Jobstraat", "054317913", "0487571163",
                                      "Aalst", "laurensdevloobe@laurensdevloo.be",
                                      DateTime.Parse("09/11/2000"), 9300);
            this.IBMTI = new MBTI ();
            this._offman = new Offman ();
            this.Realisatie = new Realisatie (DateTime.ParseExact("15/07/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                                              DateTime.Parse("31/08/2020"),
                                              "Kledij stock managemnt system",
                                              "Een systeem dat al mijn kledij trackt zodat dit gemakkelijker kan worden opgevolgd.");
            Realisatie realistatie1 = new Realisatie (DateTime.Parse("08/03/2021"),
                                                      DateTime.Parse("21/05/2021"),
                                                      "Eportfolio",
                                                      "Deze website.");
            realistatie1.Link = "http://www.laurensdevloo.be";
            this.Person.MBTI = this.IBMTI;
            this.Person.Offman = this._offman;

            this.PrepareMBTI ();
            this.PrepareLanguages ();

            this.Person.Realistaties.Add (this.Realisatie);
            this.Person.Realistaties.Add (realistatie1);
        }

        private void PrepareMBTI ()
        {
            this.Person.MBTI.Type.Add("I");
            this.Person.MBTI.Type.Add("S");
            this.Person.MBTI.Type.Add("T");
            this.Person.MBTI.Type.Add("P");
        }

        private void PrepareLanguages()
        {
            Taal nederlands = new Taal("Nederlands", "Moedertaal");
            Taal frans = new Taal ("Frans", "B2");
            Taal engels = new Taal("Engels", "C1");
            Taal duits = new Taal("Duits", "B1");
            Taal spaans = new Taal("Spaans", "A1");
            Taal italiaans = new Taal("Italiaans", "A1");

            this.Person.Talen.Add(nederlands);
            this.Person.Talen.Add(frans);
            this.Person.Talen.Add(engels);
            this.Person.Talen.Add(duits);
            this.Person.Talen.Add(spaans);
            this.Person.Talen.Add(italiaans);
        }
    }
}