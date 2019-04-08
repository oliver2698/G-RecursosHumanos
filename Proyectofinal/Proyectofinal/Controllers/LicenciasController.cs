using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyectofinal.Models;

namespace Proyectofinal.Controllers
{
    public class LicenciasController : Controller
    {
        private Formulario db = new Formulario();

        // GET: Licencias
        public ActionResult Index()
        {
            var licencia = db.Licencia.Include(l => l.Empleado1);
            return View(licencia.ToList());
        }

        // GET: Licencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Licencia licencia = db.Licencia.Find(id);
            if (licencia == null)
            {
                return HttpNotFound();
            }
            return View(licencia);
        }

        // GET: Licencias/Create
        public ActionResult Create()
        {
            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre");
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Empleado,Desde,Hasta,Motivo,Comentario,Codigo_Empleado")] Licencia licencia)
        {
            if (ModelState.IsValid)
            {
                db.Licencia.Add(licencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre", licencia.Codigo_Empleado);
            return View(licencia);
        }

        // GET: Licencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Licencia licencia = db.Licencia.Find(id);
            if (licencia == null)
            {
                return HttpNotFound();
            }
            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre", licencia.Codigo_Empleado);
            return View(licencia);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Empleado,Desde,Hasta,Motivo,Comentario,Codigo_Empleado")] Licencia licencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(licencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre", licencia.Codigo_Empleado);
            return View(licencia);
        }

        // GET: Licencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Licencia licencia = db.Licencia.Find(id);
            if (licencia == null)
            {
                return HttpNotFound();
            }
            return View(licencia);
        }

        // POST: Licencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Licencia licencia = db.Licencia.Find(id);
            db.Licencia.Remove(licencia);
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
