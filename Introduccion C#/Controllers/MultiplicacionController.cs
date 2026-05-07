using Introduccion_C_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introduccion_C_.Controllers
{
    public class MultiplicacionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MultiplicacionSuma m)
        {
            m.Calcular();

            return View(m);
        }
    }
}
