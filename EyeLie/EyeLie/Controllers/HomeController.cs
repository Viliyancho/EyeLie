using EyeLie.Data;
using EyeLie.Models;
using EyeLie.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EyeLie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Messages()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var userId = HttpContext.Session.GetInt32("UserId"); 
            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var user = _context.Users.FirstOrDefault(u => u.Id == userId.ToString());

            if (user == null)
            {
                // Handle the case where the user is not found
                return NotFound(); 
            }
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}