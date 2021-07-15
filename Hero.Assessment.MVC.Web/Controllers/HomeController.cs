using Hero.Assessment.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace Hero.Assessment.MVC.Web.Controllers
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

        public ActionResult ContactUs()
        {
            ViewBag.Message = "Contact Us.";

            return View();
        }

        /// <summary>
        /// It's not necesary to add validation to prevant XSS, moderm version of ASP.Net does it OTB
        /// if we want to add more security layers we can use AntiXSS and validate each field
        /// We can use Action Filter as clean implementation.
        /// </summary>
        /// <param name="model">ContactUs</param>
        /// <returns>ActionResult</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContactUs(ContactUs model)
        {
            ViewBag.Message = "Contact Us.";

            if (!ModelState.IsValid)
            {
                var modelErrors = new List<string>();
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var modelError in modelState.Errors)
                    {
                        modelErrors.Add(modelError.ErrorMessage);
                    }
                }
                ViewBag.ErrorMessages = modelErrors;
                return View();
            }

            //TODO: Add logic to save contact information here

            return RedirectToAction("ThankYou", model);
        }

        public ActionResult ThankYou(ContactUs model)
        {
            return View(model);
        }
    }
}