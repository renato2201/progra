using Microsoft.AspNetCore.Mvc;
using PROGRA.Models;

namespace PROGRA.Controllers
{
    public class ContactoController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewData["Message"] = "El contacto ya se ha registrado";
            return View("Index");
        }
    }
}