using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisVozila.Controllers
{
    public class PocetnaController : Controller
    {
       [AllowAnonymous]
        public ActionResult Pocetna()
        {
            ViewBag.Title = "VBL Servis vozila";
            ViewBag.Message = "Čakovec";
            ViewBag.Description = "S vama od 2020.";
            return View();
        }
        [AllowAnonymous]
        public ActionResult Onama()
        {
            ViewBag.Title = "O nama";
            return View();
        }


        [AllowAnonymous]
        public ActionResult Kontakt()
        {
            ViewBag.Title = "Kontakt";
            return View();
        }
        [AllowAnonymous]
        public ActionResult RadnoVrijeme()
        {
            ViewBag.Title = "Radno vrijeme";
            return View();
        }

    }
}