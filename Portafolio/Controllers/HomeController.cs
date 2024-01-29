using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoryProjects instanceRepoProyects;
       

        public HomeController(ILogger<HomeController> logger, IRepositoryProjects InstanceRepoProyects)
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

            _logger.LogInformation("login data");
            _logger.LogCritical("Unexpected somethin");

            var proyect = instanceRepoProyects.GetProjects().Take(3).ToList();

           

            var model = new HomeIndexViewModel() { 
                Proyects = proyect,

            };

           // ViewBag.age = "32";
          //  return View("Index2");
            return View(model);
        }
        // this is a action 
        public IActionResult Proyects()
        {
            var proyect = instanceRepoProyects.GetProjects();

            return View(proyect);
        }

  
        public IActionResult Contact()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            return RedirectToAction("Thanks");        
        }

        public IActionResult Thanks()
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