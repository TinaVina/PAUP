using ServisVozila.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using ServisVozila.Misc;

namespace ServisVozila.Controllers
{
    [Authorize(Roles = OvlastiKorisnik.Administrator)]

    public class RadnikController : Controller
    {
        BazaDbContext bazaPodataka = new BazaDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PopisRadnika()
        {
            var radnik = bazaPodataka.PopisRadnika.ToList();

            return View(radnik);
        }

        public ActionResult Detalji(int? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            radnik radnici = bazaPodataka.PopisRadnika.FirstOrDefault(x => x.idRadnik == id);

            if (radnici == null)
            {
                return HttpNotFound();
            }
            return View(radnici);
        }


        public ActionResult Brisi(int? id)
        {
            if (id == null)
                return RedirectToAction("PopisRadnika");
            radnik r = bazaPodataka.PopisRadnika.FirstOrDefault(x => x.idRadnik == id);
            if (r == null)
                return HttpNotFound();
            ViewBag.Title = "Potvrda brisanja radnika";
            return View(r);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Brisi(int id)
        {
            radnik ra = bazaPodataka.PopisRadnika
                .FirstOrDefault(x => x.idRadnik == id);
            if (ra == null)
                return HttpNotFound();
            bazaPodataka.PopisRadnika.Remove(ra);
            bazaPodataka.SaveChanges();
            return View("BrisiStatus");
        }


        public ActionResult DetaljiOOdjelu(int? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            odjel o = bazaPodataka.PopisOdjela.FirstOrDefault(x => x.idOdjel == id);

            if (o == null)
            {
                return HttpNotFound();
            }
            return View(o);
        }




        public ActionResult Azuriraj(int? id)
        {
            radnik r = null;
            if (!id.HasValue)
            {
                r = new radnik();
                ViewBag.Title = "Kreiranje radnika";
                ViewBag.Novi = true;

            }
            else
            {
                r = bazaPodataka.PopisRadnika
                    .FirstOrDefault(k => k.idRadnik == id);

                if (r == null)
                {
                    return HttpNotFound();
                }

                ViewBag.Title = "Ažuriranje postojećeg radnika";
                ViewBag.Novi = false;
            }



            return View(r);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Azuriraj(radnik r)
        {
            if (ModelState.IsValid)
            {
                if (r.idRadnik != 0)

                    bazaPodataka.Entry(r).State = System.Data.Entity.EntityState.Modified;

                else
                    bazaPodataka.PopisRadnika.Add(r);
                bazaPodataka.SaveChanges();
                return RedirectToAction("PopisRadnika");
            }

            if (r.idRadnik != 0)
            {
                ViewBag.Title = "Ažuriranje radnika";
                ViewBag.Novi = false;

            }
            else
            {
                ViewBag.Title = "Kreiranje novog radnika";

                ViewBag.Novi = true;
            }
            return View(r);
        }




    }
}