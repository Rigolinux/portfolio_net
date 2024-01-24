using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositoryProjects instanceRepoProyects;

        public HomeController(ILogger<HomeController> logger, RepositoryProjects InstanceRepoProyects)
        {
            _logger = logger;
            instanceRepoProyects = InstanceRepoProyects;
        }
        // this is a action 

        

        public IActionResult Index()
        {
            //ViewBag.Name = "Rigoberto";

            // var persona = new Persona()
            // { Name= "Rigoberto", LastName = "Portillo", Age= 16 };

            

            var proyect = instanceRepoProyects.GetProjects().Take(3).ToList();

            var model = new HomeIndexViewModel() { Proyects = proyect };

           // ViewBag.age = "32";
          //  return View("Index2");
            return View(model);
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