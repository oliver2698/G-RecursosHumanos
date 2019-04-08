using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Proyectofinal.Models;

namespace Proyectofinal.Controllers
{
    public class SalidaInfoController : Controller
    {
        private Formulario db = new Formulario();

        // GET: Salida
        public ActionResult Index()
        {
        
            return View(db.Inactivos.ToList());
        }
    }
}