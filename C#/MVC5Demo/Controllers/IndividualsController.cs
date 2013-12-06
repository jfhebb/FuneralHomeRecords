using MVC5Demo.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MVC5Demo.Controllers
{
    public class IndividualsController : Controller
    {
        private IndividualsContext db = new IndividualsContext();

        //
        // GET: /Individuals/
        public ActionResult Index()
        {
            return View(db.Individual.ToList());
        }

        //
        // GET: /Individuals/Details/5
        public ActionResult Details(Int32 id)
        {
            Individual individual = db.Individual.Find(id);
            if (individual == null)
            {
                return HttpNotFound();
            }
            return View(individual);
        }

        //
        // GET: /Individuals/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Individuals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Individual individual)
        {
            if (ModelState.IsValid)
            {
                db.Individual.Add(individual);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(individual);
        }

        //
        // GET: /Individuals/Edit/5
        public ActionResult Edit(Int32 id)
        {
            Individual individual = db.Individual.Find(id);
            if (individual == null)
            {
                return HttpNotFound();
            }
            return View(individual);
        }

        //
        // POST: /Individuals/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Individual individual)
        {
            if (ModelState.IsValid)
            {
                db.Entry(individual).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(individual);
        }

        //
        // GET: /Individuals/Delete/5
        public ActionResult Delete(Int32 id)
        {
            Individual individual = db.Individual.Find(id);
            if (individual == null)
            {
                return HttpNotFound();
            }
            return View(individual);
        }

        //
        // POST: /Individuals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int32 id)
        {
            Individual individual = db.Individual.Find(id);
            db.Individual.Remove(individual);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
