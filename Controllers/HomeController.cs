using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gabmvcdemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Welcome to the 2017 Global Azure Bootcamp";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Info";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
