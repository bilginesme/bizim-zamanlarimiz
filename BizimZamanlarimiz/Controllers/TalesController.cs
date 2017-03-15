using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BenimZamanlarim.Controllers
{
    public class TalesController : Controller
    {
        // GET: Tales
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TeksasTommiks()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Boncuk()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BizimZamanlarimiz()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Zonguldak()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BirZamanlarTurkFutbolu()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BagdatCaddesi()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}