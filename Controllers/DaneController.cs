using Microsoft.AspNetCore.Mvc;
using Formularz.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Formularz.Controllers
{
    public class DaneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else return View();

        }

        public IActionResult Wynik(Dane dane)
        {

            return View(dane);
        }

    }
}