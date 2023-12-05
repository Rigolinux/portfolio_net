﻿using Microsoft.AspNetCore.Mvc;
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

        private List<Proyect> GetProjects()
        {
            return new List<Proyect>()
            {
                new Proyect
                {
                    Title = "Project 1",
                    Description = "list and create an E-comerce with ASP.NET Core",
                    Link = "http://example.com",
                    ImageURL = "/images/amazon.png"
                },
                new Proyect
                {
                    Title = "Project 2",
                    Description = "list and create an E-comerce with ASP.NET Core",
                    Link = "http://example.com",
                    ImageURL = "/images/nyt.png"
                },
                new Proyect
                {
                    Title = "Project 3",
                    Description = "list and create an E-comerce with ASP.NET Core",
                    Link = "http://example.com",
                    ImageURL = "/images/reddit.png"
                }
            };
        }

        public IActionResult Index()
        {
            //ViewBag.Name = "Rigoberto";

            // var persona = new Persona()
            // { Name= "Rigoberto", LastName = "Portillo", Age= 16 };

            var proyect = GetProjects().Take(3).ToList();

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