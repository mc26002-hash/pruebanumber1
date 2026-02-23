using Microsoft.AspNetCore.Mvc;

namespace JAMC23022026AppMVC.Controllers
{
    public class JosePromedioController : Controller
    {
        // GET
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Index(double nota1, double nota2, double nota3, double nota4)
        {
            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            ViewBag.Promedio = promedio;

            ViewBag.Nota1 = nota1;
            ViewBag.Nota2 = nota2;
            ViewBag.Nota3 = nota3;
            ViewBag.Nota4 = nota4;

            return View();
        }
    }
}