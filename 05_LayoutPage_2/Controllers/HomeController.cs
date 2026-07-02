using _05_LayoutPage_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _05_LayoutPage_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Book()
        {
            return View();
        }
    }
}
