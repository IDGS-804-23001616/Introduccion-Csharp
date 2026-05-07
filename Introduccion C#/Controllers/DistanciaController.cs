using Introduccion_C_.Models;
using System.Web.Mvc;

namespace Introduccion_C_.Controllers
{
    public class DistanciaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(DistanciaPuntos d)
        {
            d.CalcularDistancia();

            return View(d);
        }
    }
}