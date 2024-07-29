using friends_gallery.Data;
using friends_gallery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace friends_gallery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplictaionDbContext _context;

        public HomeController(ApplictaionDbContext dbContext)
        {
            _context = dbContext;
        }
    

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Index()
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
