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
    public class SalidasController : Controller
    {
        private Formulario db = new Formulario();

        // GET: Salidas
        public ActionResult Index()
        {
            var salida = db.Salida.Include(s => s.Empleado1);
            return View(salida.ToList());
        }

        // GET: Salidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salida salida = db.Salida.Find(id);
            if (salida == null)
            {
                return HttpNotFound();
            }
            return View(salida);
        }

        // GET: Salidas/Create
        public ActionResult Create()
        {
            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre");
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Empleado,TipoDesalida,motivo,fechaDesalida,Codigo_Empleado")] Salida salida)
        {
            if (ModelState.IsValid)
            {
                db.Salida.Add(salida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre", salida.Codigo_Empleado);
            return View(salida);
        }

        // GET: Salidas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salida salida = db.Salida.Find(id);
            if (salida == null)
            {
                return HttpNotFound();
            }
            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre", salida.Codigo_Empleado);
            return View(salida);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Empleado,TipoDesalida,motivo,fechaDesalida,Codigo_Empleado")] Salida salida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre", salida.Codigo_Empleado);
            return View(salida);
        }

        // GET: Salidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salida salida = db.Salida.Find(id);
            if (salida == null)
            {
                return HttpNotFound();
            }
            return View(salida);
        }

        // POST: Salidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Salida salida = db.Salida.Find(id);
            db.Salida.Remove(salida);
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
