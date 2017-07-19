using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var potato = "potato";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "The cool about page.";
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
