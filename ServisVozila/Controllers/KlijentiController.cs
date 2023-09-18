using ServisVozila.Misc;
using ServisVozila.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ServisVozila.Controllers
{
    [Authorize(Roles = OvlastiKorisnik.Administrator)]

    public class KlijentiController : Controller
    {
        BazaDbContext bazaPodataka = new BazaDbContext();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult PopisKlijenata(string prezime)
        {
            var klijent = bazaPodataka.PopisKlijenata.ToList();

            if (!String.IsNullOrWhiteSpace(prezime))
            {
                klijent = klijent.Where(x => x.prezime.ToUpper().Contains(prezime.ToUpper())).ToList();
            }




            return View(klijent);
        }
        public ActionResult Detalji(int? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Klijenti klijent = bazaPodataka.PopisKlijenata.FirstOrDefault(x => x.id == id);

            if (klijent == null)
            {
                return HttpNotFound();
            }
            return View(klijent);
        }

        public ActionResult Azuriraj(int? id)
        {
            Klijenti klijenti = null;
            if (!id.HasValue)
            {
                klijenti = new Klijenti();
                ViewBag.Title = "Kreiranje klijenta";
                ViewBag.Novi = true;
                
            }
            else
            {
                klijenti = bazaPodataka.PopisKlijenata
                    .FirstOrDefault(k => k.id == id);

                if (klijenti == null)
                {
                    return HttpNotFound();
                }

                ViewBag.Title = "Ažuriranje postojećeg klijenta";
                ViewBag.Novi = false;
            }

            var kvar = bazaPodataka.PopisUsluga.OrderBy(x => x.nazivKvar).ToList();
            kvar.Insert(0, new kvar { idKvar = "", nazivKvar = "Nedefinirano" });
            ViewBag.Usluge=kvar;

            var automobil = bazaPodataka.PopisAutomobila.OrderBy(x => x.idAutomobil).ToList();
            automobil.Insert(0, new Automobil { idAutomobil = "Nedefinirano", modelVozila = "Nedefinirano", markaVozila="Audi", bojaVozila = "Nedefinirano", brojSasije= "Nedefinirano", godProizvodnje=DateTime.Now, kilometri=0, regTablice= "Nedefinirano" });
            ViewBag.Automobil = automobil;

            return View(klijenti);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Azuriraj(Klijenti k)
        {
            if (ModelState.IsValid)
            {
                if (k.id != 0)
                    bazaPodataka.Entry(k).State = System.Data.Entity.EntityState.Modified;
                else
                    bazaPodataka.PopisKlijenata.Add(k);
                bazaPodataka.SaveChanges();

                return RedirectToAction("PopisKlijenata");
            }

            if (k.id != 0)
            {
                ViewBag.Title = "Ažuriranje klijenta";
                ViewBag.Novi = false;
               
            }
            else
            {
                ViewBag.Title = "Kreiranje novog klijenta";
              
                ViewBag.Novi = true;
            }
            var kvar = bazaPodataka.PopisUsluga.OrderBy(x => x.nazivKvar).ToList();
            kvar.Insert(0, new kvar { idKvar = "", nazivKvar = "Nedefinirano" });
            ViewBag.Usluge = kvar;

            var automobil = bazaPodataka.PopisAutomobila.OrderBy(x => x.idAutomobil).ToList();
            automobil.Insert(0, new Automobil { idAutomobil = "Nedefinirano", modelVozila = "Nedefinirano", markaVozila = "Audi", bojaVozila = "Nedefinirano", brojSasije = "Nedefinirano", godProizvodnje = DateTime.Now, kilometri = 0, regTablice = "Nedefinirano" });
            ViewBag.Automobil = automobil;


            return View(k);
        }

        public ActionResult Brisi(int? id)
        {
            if (id == null)
                return RedirectToAction("PopisKlijenata");
            Klijenti k = bazaPodataka.PopisKlijenata.FirstOrDefault(x => x.id == id);
            if (k == null)
                return HttpNotFound();
            ViewBag.Title = "Potvrda brisanja klijenta";
            return View(k);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Brisi(int id)
        {
            Klijenti s = bazaPodataka.PopisKlijenata
                .FirstOrDefault(x => x.id == id);
            if (s == null)
                return HttpNotFound();
            bazaPodataka.PopisKlijenata.Remove(s);
            bazaPodataka.SaveChanges();
            return View("BrisiStatus");
        }


        public ActionResult Automobil(string id)
        {
            if (id==null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Automobil automobil = bazaPodataka.PopisAutomobila.FirstOrDefault(x => x.idAutomobil == id);

            if (automobil == null)
            {
                return HttpNotFound();
            }
            return View(automobil);
        }

        public ActionResult DetaljiOKvaru(string id)
        {
            if (id==null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            kvar k = bazaPodataka.PopisUsluga.FirstOrDefault(x => x.idKvar == id);

            if (k == null)
            {
                return HttpNotFound();
            }
            return View(k);
        }






    }
}