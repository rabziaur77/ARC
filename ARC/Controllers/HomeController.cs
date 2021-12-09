using ARC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ARC.Controllers
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
            return View();
        }
        public IActionResult Residential()
        {
            return View();
        }

        public IActionResult Comercial()
        {
            return View();
        }
        public IActionResult WorkDetails(string work)
        {
            ViewData["work"] = work;
            return View();
        }

        public IActionResult ComercialProjectDetails()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        [ActionName("BlogDetails")]
        public IActionResult Blogs()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult ResidentialBlog()
        {
            return View();
        }
        public IActionResult ComercialBlog()
        {
            return View();
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
