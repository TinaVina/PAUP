using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisVozila.Controllers
{
    public class PocetnaController : Controller
    {
        // GET: Pocetna
        public ActionResult Pocetna()
        {
            ViewBag.Title = "VBL Servis vozila";
            ViewBag.Message = "Čakovec";
            ViewBag.Description = "S vama od 2020.";
            return View();
        }

        public ActionResult Onama()
        {
            ViewBag.Title = "O nama";
            return View();
        }


        public ActionResult Usluge()
        {
            ViewBag.Title = "Usluge servisa";
            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Title = "Kontakt";
            return View();
        }

        public ActionResult RadnoVrijeme()
        {
            ViewBag.Title = "Radno vrijeme";
            return View();
        }

    }
}