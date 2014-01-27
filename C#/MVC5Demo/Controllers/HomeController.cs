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
        private IndividualsContext db = new IndividualsContext();

        public ActionResult Index()
        {
            ViewBag.Username = User.Identity.Name;

            var individuals = db.Individual.OrderByDescending(ind => ind.DateAdded);

            return View(individuals.ToList().GetRange(0,5));
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