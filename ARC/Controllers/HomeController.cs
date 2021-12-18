using ARC.Models;
using ARC.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ARC.Controllers
{
    public class HomeController : AppController
    {
        public HomeController(IRepo Repo, IConfiguration configuration, ILogger<HomeController> logge)
            :base(Repo,configuration,logge)
        {
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

        [ActionName("Blogs")]
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
