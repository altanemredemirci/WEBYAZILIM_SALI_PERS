using _05_LayoutPage_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _05_LayoutPage_3.Controllers
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

        
    }
}
