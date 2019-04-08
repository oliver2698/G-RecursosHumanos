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
    public class ActivosController : Controller
    {
        private Formulario db = new Formulario();

        // GET: Activos
        public ActionResult Index()
        {
            ViewBag.TotalSalario = db.Activos.Sum(a => a.salario);
            ViewBag.TotalEmpleados = db.Activos.Count();

          
            db.SaveChanges();
            return View(db.Activos.ToList());
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
