using Proyectofinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Proyectofinal.Controllers
{
    public class DepartamentoinfoController : Controller
    {
        private Formulario db = new Formulario();
        // GET: Departamentoinfo
        public ActionResult Index(String departamento)
        {
            var Departamento = db.Departamento.Include(p => p.CodigoDepatamento);

            if (!String.IsNullOrEmpty(departamento))
            {
                Departamento = Departamento.Where(tabla => tabla.Nombre == departamento);
            }

            return View(db.Departamento.ToList());
        }
    }
}