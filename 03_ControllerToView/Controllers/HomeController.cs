using _03_ControllerToView.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _03_ControllerToView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product p = new Product();
            p.Id = 1;
            p.Name = "Elma";
            p.Price = 10000.5m;
            p.Stock = 100;
            p.ImageUrl = "resim1.webp";

            //ViewBag,ViewData ve TempData
            ViewBag.message = "Bu ViewBag ile gelen bir mesajdır";
            //ViewBag sadece bir sayfa için kullanılabilir.O sayfada yönlendirildiği sayfa olmalıdır.

            ViewData["mesaj"] = "ViewData ile gelen bir mesajdır.";
            //ViewData sadece bir sayfa için kullanılabilir.O sayfada yönlendirildiği sayfa olmalıdır.

            TempData["adsoyad"] = "Altan Emre Demirci";

            return View(p);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
