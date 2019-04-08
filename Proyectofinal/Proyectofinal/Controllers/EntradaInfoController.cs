using Proyectofinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyectofinal.Controllers
{
    public class EntradaInfoController : Controller
    {
        private Formulario db = new Formulario();

        // GET: EntradaInfo
        public ActionResult Index()
        {
            return View(db.Activos.ToList());
        }
    }
}