using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BenimZamanlarim.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult ParSearch()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult ParRecentImages()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult ParCommentForm()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult ParAuthor()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult ParShareArticle()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}