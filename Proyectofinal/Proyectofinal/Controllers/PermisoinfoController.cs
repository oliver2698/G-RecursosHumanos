using Proyectofinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Proyectofinal.Controllers
{
    public class PermisoinfoController : Controller
    {
        private Formulario db = new Formulario();

        // GET: Permisoinfo
        public ActionResult Index(String Nombre)
        {
            var permisos = db.Permisos.Include(p => p.Empleado1);
            if (!String.IsNullOrEmpty(Nombre))
            {
                permisos = permisos.Where(tabla => tabla.Empleado == Nombre);
            }
            return View(permisos.ToList());
        }
        
    }
}