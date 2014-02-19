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
            var individuals = db.Individual.OrderByDescending(ind => ind.DateAdded);

            var recordsCurrentYear = db.Individual.Where(ind => ind.DateOfDeath.Year.Equals(DateTime.Today.Year));
            ViewBag.recordsModifiedCurrentYear = recordsCurrentYear.Count();

            float floatRecsCurrentYear = recordsCurrentYear.Count();
            float dayOfYear = DateTime.Today.DayOfYear;
            float projectedRecords = (floatRecsCurrentYear / dayOfYear) * 365;
            ViewBag.totalRecords = db.Individual.Count();
            ViewBag.projectedRecords = Convert.ToInt32(projectedRecords);
            ViewBag.Username = User.Identity.Name.First().ToString().ToUpper() + String.Join("", User.Identity.Name.Skip(1));


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
            ViewBag.Username = User.Identity.Name.First().ToString().ToUpper() + String.Join("", User.Identity.Name.Skip(1));
            ViewBag.Message = "Your application descriptions page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Username = User.Identity.Name.First().ToString().ToUpper() + String.Join("", User.Identity.Name.Skip(1));
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}