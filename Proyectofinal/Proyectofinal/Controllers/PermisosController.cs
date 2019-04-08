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
    public class PermisosController : Controller
    {
        private Formulario db = new Formulario();

        // GET: Permisos
        public ActionResult Index(String Nombre)
        {
            var permisos = db.Permisos.Include(p => p.Empleado1);
            if (!String.IsNullOrEmpty(Nombre))
            {
                permisos = permisos.Where(tabla => tabla.Empleado == Nombre);
            }
            return View(permisos.ToList());
        }

        // GET: Permisos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permisos permisos = db.Permisos.Find(id);
            if (permisos == null)
            {
                return HttpNotFound();
            }
            return View(permisos);
        }

        // GET: Permisos/Create
        public ActionResult Create()
        {
            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre");
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Empleado,Desde,Hasta,Comentario,Codigo_Empleado")] Permisos permisos)
        {
            if (ModelState.IsValid)
            {
                db.Permisos.Add(permisos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre", permisos.Codigo_Empleado);
            return View(permisos);
        }

        // GET: Permisos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permisos permisos = db.Permisos.Find(id);
            if (permisos == null)
            {
                return HttpNotFound();
            }
            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre", permisos.Codigo_Empleado);
            return View(permisos);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Empleado,Desde,Hasta,Comentario,Codigo_Empleado")] Permisos permisos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(permisos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Codigo_Empleado = new SelectList(db.Empleado, "id", "Nombre", permisos.Codigo_Empleado);
            return View(permisos);
        }

        // GET: Permisos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permisos permisos = db.Permisos.Find(id);
            if (permisos == null)
            {
                return HttpNotFound();
            }
            return View(permisos);
        }

        // POST: Permisos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Permisos permisos = db.Permisos.Find(id);
            db.Permisos.Remove(permisos);
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
