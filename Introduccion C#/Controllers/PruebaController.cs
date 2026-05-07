using Introduccion_C_.Models;
using Introduccion_C_.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introduccion_C_.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Suma(){
            return View();
        }

        [HttpPost]
        public ActionResult Suma(string x, string y, string r1)
        {
            int resultado = Convert.ToInt16(x) + Convert.ToInt16(y);
            ViewBag.Rest=Convert.ToString(resultado);
            return View();
        }
        public ActionResult MuestraPeliculas()
        {
            var PeliculaService = new PeliculaService();
            var model = PeliculaService.ObtenerPelicula();
            return View(model);
        }
        public ActionResult Calculadora(OperacionesBasicas op)
        {
            op.Suma();

            return View(op);
        }

    }
}