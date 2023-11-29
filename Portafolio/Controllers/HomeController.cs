using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // this is a action 

        public IActionResult Index()
        {
            //ViewBag.Name = "Rigoberto";

            var persona = new Persona()
            { Name= "Rigoberto", LastName = "Portillo", Age= 16 };


            ViewBag.age = "32";
            return View(persona);
          //  return View("Index2");
        }
        // this is a action 
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