using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kintai.Models;

namespace Kintai.Controllers
{
    public class KintaiController : Controller
    {
        private KintaiContext db = new KintaiContext();

        //
        // GET: /Kintai/

        public ActionResult Index()
        {
            return View(db.AttendanceMonths.ToList());
        }

        //
        // GET: /Kintai/Details/5

        public ActionResult Details(int id = 0)
        {
            AttendanceMonth attendancemonth = db.AttendanceMonths.Find(id);
            if (attendancemonth == null)
            {
                return HttpNotFound();
            }
            return View(attendancemonth);
        }

        //
        // GET: /Kintai/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Kintai/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AttendanceMonth attendancemonth)
        {
            if (ModelState.IsValid)
            {
                db.AttendanceMonths.Add(attendancemonth);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(attendancemonth);
        }

        //
        // GET: /Kintai/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AttendanceMonth attendancemonth = db.AttendanceMonths.Find(id);
            if (attendancemonth == null)
            {
                return HttpNotFound();
            }
            return View(attendancemonth);
        }

        //
        // POST: /Kintai/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AttendanceMonth attendancemonth)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendancemonth).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attendancemonth);
        }

        //
        // GET: /Kintai/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AttendanceMonth attendancemonth = db.AttendanceMonths.Find(id);
            if (attendancemonth == null)
            {
                return HttpNotFound();
            }
            return View(attendancemonth);
        }

        //
        // POST: /Kintai/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AttendanceMonth attendancemonth = db.AttendanceMonths.Find(id);
            db.AttendanceMonths.Remove(attendancemonth);
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