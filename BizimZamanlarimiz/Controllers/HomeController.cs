using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recaptcha.Web;
using Recaptcha.Web.Mvc;

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

        public ActionResult ImagesIPicked()
        {
            ViewBag.Message = "Arşiv";

            return View();
        }

        public ActionResult TermsOfUse()
        {
            ViewBag.Message = "Terms of use here.";

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
        [HttpPost]
        public PartialViewResult _ParCommentFormSave(string strArticleName, bool? saveToDB, FormCollection values)
        {
            ViewBag.Message = "Your application description page.";
            System.Threading.Thread.Sleep(1000); // REMOVE THIS AFTERWARDS

            if (saveToDB.HasValue && saveToDB.Value== true)
            {
                RecaptchaVerificationHelper recaptchaHelper = this.GetRecaptchaVerificationHelper();
                if (String.IsNullOrEmpty(recaptchaHelper.Response))
                {
                    ModelState.AddModelError("", "Captcha answer cannot be empty.");
                    //return View(model);
                }
                else
                {
                    RecaptchaVerificationResult recaptchaResult = recaptchaHelper.VerifyRecaptchaResponse();
                    if (recaptchaResult != RecaptchaVerificationResult.Success)
                    {
                        ModelState.AddModelError("", "Incorrect captcha answer.");
                    }
                }
            }

            return PartialView();
        }
        public ActionResult ParCommentForm()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult ParCommentFormAjax()
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