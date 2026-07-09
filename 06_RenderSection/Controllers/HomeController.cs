using _06_RenderSection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _06_RenderSection.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ilanlar()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
