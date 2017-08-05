using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Core.Respositories;
using Core.Models.Database;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserRepository _userRepository;
        public HomeController(DatabaseContext databaseContext)
        {
            _userRepository = new UserRepository(databaseContext);
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            var email = "testtt@user.com";
            var user = _userRepository.GetByEmail(email);
            
            return View(user);
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
