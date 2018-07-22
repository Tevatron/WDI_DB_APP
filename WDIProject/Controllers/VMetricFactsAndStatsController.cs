using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WDIProject.Models;

namespace WDIProject.Controllers
{
    public class VMetricFactsAndStatsController : Controller
    {
        private CS564Entities db = new CS564Entities();

        // GET: VMetricFactsAndStats
        public ActionResult Index()
        {
            return View(db.VMetricFactsAndStats.ToList());
        }

        // GET: VMetricFactsAndStats/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VMetricFactsAndStat vMetricFactsAndStat = db.VMetricFactsAndStats.Find(id);
            if (vMetricFactsAndStat == null)
            {
                return HttpNotFound();
            }
            return View(vMetricFactsAndStat);
        }

        // GET: VMetricFactsAndStats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VMetricFactsAndStats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CountryCode,IndicatorCode,Topic,IndicatorName,UnitOfMeasure,OtherNotes,AggregationMethod,LimitationsAndExceptions,Year,Value,p5,p10,p25,p50,p75,p90,p95,Average,Min,Max,Size,ranking,CollectionMethodByYear")] VMetricFactsAndStat vMetricFactsAndStat)
        {
            if (ModelState.IsValid)
            {
                db.VMetricFactsAndStats.Add(vMetricFactsAndStat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vMetricFactsAndStat);
        }

        // GET: VMetricFactsAndStats/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VMetricFactsAndStat vMetricFactsAndStat = db.VMetricFactsAndStats.Find(id);
            if (vMetricFactsAndStat == null)
            {
                return HttpNotFound();
            }
            return View(vMetricFactsAndStat);
        }

        // POST: VMetricFactsAndStats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CountryCode,IndicatorCode,Topic,IndicatorName,UnitOfMeasure,OtherNotes,AggregationMethod,LimitationsAndExceptions,Year,Value,p5,p10,p25,p50,p75,p90,p95,Average,Min,Max,Size,ranking,CollectionMethodByYear")] VMetricFactsAndStat vMetricFactsAndStat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vMetricFactsAndStat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vMetricFactsAndStat);
        }

        // GET: VMetricFactsAndStats/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VMetricFactsAndStat vMetricFactsAndStat = db.VMetricFactsAndStats.Find(id);
            if (vMetricFactsAndStat == null)
            {
                return HttpNotFound();
            }
            return View(vMetricFactsAndStat);
        }

        // POST: VMetricFactsAndStats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            VMetricFactsAndStat vMetricFactsAndStat = db.VMetricFactsAndStats.Find(id);
            db.VMetricFactsAndStats.Remove(vMetricFactsAndStat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
