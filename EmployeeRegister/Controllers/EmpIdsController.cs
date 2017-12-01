using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeRegister.DataAccessLayer;
using EmployeeRegister.Models;

namespace EmployeeRegister.Controllers
{
    public class EmpIdsController : Controller
    {
        private RegisterContext db = new RegisterContext();

        // GET: EmpIds
        public ActionResult Index()
        {
            var model = db.EmpIds.ToList();
            return View(model);
           // return View(db.EmpIds.ToList());
        }

        public ActionResult India()
        {
            var model = db.EmpIds.Where(p => p.Country == "India").ToList();
            return View(model);
        }


        // GET: EmpIds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpId empId = db.EmpIds.Find(id);
            if (empId == null)
            {
                return HttpNotFound();
            }
            return View(empId);
        }

        // GET: EmpIds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpIds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdNumber,country")] EmpId empId)
        {
            if (ModelState.IsValid)
            {
                db.EmpIds.Add(empId);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empId);
        }

        // GET: EmpIds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpId empId = db.EmpIds.Find(id);
            if (empId == null)
            {
                return HttpNotFound();
            }
            return View(empId);
        }

        // POST: EmpIds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdNumber,country")] EmpId empId)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empId).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empId);
        }

        // GET: EmpIds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpId empId = db.EmpIds.Find(id);
            if (empId == null)
            {
                return HttpNotFound();
            }
            return View(empId);
        }

        // POST: EmpIds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpId empId = db.EmpIds.Find(id);
            db.EmpIds.Remove(empId);
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
