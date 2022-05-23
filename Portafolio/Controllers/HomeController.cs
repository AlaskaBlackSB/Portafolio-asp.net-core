using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*
             ViewBag sirve para pasar informacion (modelo sin tipado)  del controlador a la vista
              Ejemplo:
                ViewBag.Nombre = "Agner Amador";
                ViewBag.Descripcion = "Soy un desarrollador full stack especializado en .net y javascript";
            */

            //Se pasa a la vista un objeto
            Person person = new Person() 
            { 
                Name = "Agner Amador", 
                Description = "Soy un desarrollador full stack especializado en .net y javascript" 
            };
            return View(person);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}