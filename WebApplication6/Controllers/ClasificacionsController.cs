﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6;

namespace WebApplication6.Controllers
{
    public class ClasificacionsController : Controller
    {
        private Cines3Entities db = new Cines3Entities();

        // GET: Clasificacions
        public ActionResult Index()
        {
            return View(db.Clasificacion.ToList());
        }

        // GET: Clasificacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clasificacion clasificacion = db.Clasificacion.Find(id);
            if (clasificacion == null)
            {
                return HttpNotFound();
            }
            return View(clasificacion);
        }

        // GET: Clasificacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clasificacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_clasificacion,nombre_clasificacion")] Clasificacion clasificacion)
        {
            if (ModelState.IsValid)
            {
                db.Clasificacion.Add(clasificacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clasificacion);
        }

        // GET: Clasificacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clasificacion clasificacion = db.Clasificacion.Find(id);
            if (clasificacion == null)
            {
                return HttpNotFound();
            }
            return View(clasificacion);
        }

        // POST: Clasificacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_clasificacion,nombre_clasificacion")] Clasificacion clasificacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clasificacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clasificacion);
        }

        // GET: Clasificacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clasificacion clasificacion = db.Clasificacion.Find(id);
            if (clasificacion == null)
            {
                return HttpNotFound();
            }
            return View(clasificacion);
        }

        // POST: Clasificacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Clasificacion clasificacion = db.Clasificacion.Find(id);
            db.Clasificacion.Remove(clasificacion);
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
