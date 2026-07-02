using _05_LayoutPage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _05_LayoutPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }
    }
}
