using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisVozila.Controllers
{
    public class KlijentiController : Controller
    {
        // GET: Klijenti
        public ActionResult Index()
        {
            return View();
        }
    }
}