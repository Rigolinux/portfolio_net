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
        private readonly DelimtedServices delimtedServices;
        private readonly UniqueServices uniqueServices;
        private readonly TransitoryService transitoryService;

        public HomeController(ILogger<HomeController> logger, IRepositoryProjects InstanceRepoProyects,
            DelimtedServices  delimtedServices,
            UniqueServices uniqueServices,
            TransitoryService transitoryService
            )
        {
            _logger = logger;
            instanceRepoProyects = InstanceRepoProyects;
            this.delimtedServices = delimtedServices;
            this.uniqueServices = uniqueServices;
            this.transitoryService = transitoryService;
        }
        // this is a action 

        

        public IActionResult Index()
        {
            //ViewBag.Name = "Rigoberto";

            // var persona = new Persona()
            // { Name= "Rigoberto", LastName = "Portillo", Age= 16 };

            

            var proyect = instanceRepoProyects.GetProjects().Take(3).ToList();

            var guidViewModel = new ExampleGUIViewModel()
            {
                Delimited = delimtedServices.GetGuid,
                Unique = uniqueServices.GetGuid,
                Transitory = transitoryService.GetGuid
            };

            var model = new HomeIndexViewModel() { 
                Proyects = proyect,
                ExampleGUI = guidViewModel
            };

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