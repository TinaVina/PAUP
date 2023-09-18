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
 

    public class UslugeController : Controller
    {
      


        BazaDbContext bazaPodataka = new BazaDbContext();
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }


        [AllowAnonymous]
        public ActionResult PopisUsluga()
        {
            var kvar = bazaPodataka.PopisUsluga.ToList();

            return View(kvar);
           
        }


        [OverrideAuthorization]
        [Authorize]
        public ActionResult Brisi(string id)
        {
            if (id == null)

            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            kvar k = bazaPodataka.PopisUsluga.Find(id);
            if (k == null)
            {
                return HttpNotFound();
               
            }
            return View(k);
        }

        [HttpPost, ActionName("Brisi")]
        [Authorize ]
        public ActionResult BrisiStatus(string id)
        {
            kvar k = bazaPodataka.PopisUsluga.Find(id);
            bazaPodataka.PopisUsluga.Remove(k);
            bazaPodataka.SaveChanges();
            return View("PopisUsluga");
        }

      



    }
}