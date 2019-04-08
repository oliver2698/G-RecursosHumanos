using Proyectofinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Proyectofinal.Controllers
{
    public class CargoInfoController : Controller
    {
        public Formulario db = new Formulario();

        // GET: CargoInfo
        public ActionResult Index(String cargos)
        {
            var Cargo = db.Cargo.Include(a => a.id );
            
            if (!String.IsNullOrEmpty(cargos))
            {
                Cargo = Cargo.Where(tabla => tabla.Cargo1 == cargos);
            }

            return View(db.Cargo.ToList());
        }
    }
}