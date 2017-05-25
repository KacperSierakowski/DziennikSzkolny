using DziennikSzkolny3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DziennikSzkolny3.Controllers
{
    public class HomeController : Controller
    {
        DziennikSzkolny3_DB Nasza_Baza = new DziennikSzkolny3_DB();

        public ActionResult Index()
        {
            var model = Nasza_Baza.Frekwencja_DB.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /////////////
        protected override void Dispose(bool disposing)
        {
            if (Nasza_Baza != null)
            {
                Nasza_Baza.Dispose();
            }
            base.Dispose(disposing);
        }



    }
}