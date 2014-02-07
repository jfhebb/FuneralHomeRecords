using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Demo.Models;

namespace MVC5Demo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private static int RECORDS_RETURNED = 5;
        private IndividualsContext db = new IndividualsContext();

        public ActionResult Index()
        {
            ViewBag.Username = User.Identity.Name;

            var individuals = db.Individual.OrderByDescending(ind => ind.DateAdded);

            int return_count = 0;
            if (individuals.ToList().Count() < 5)
            {
                return_count = individuals.ToList().Count();
            }
            else
            {
                return_count = RECORDS_RETURNED;
            }
            return View(individuals.ToList().GetRange(0,return_count));
        }

        public ActionResult About()
        {
            ViewBag.Username = User.Identity.Name;
            ViewBag.Message = "Your application descriptions page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Username = User.Identity.Name;
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}