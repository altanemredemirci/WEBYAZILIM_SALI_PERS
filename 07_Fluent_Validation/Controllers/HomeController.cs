using _07_Fluent_Validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _07_Fluent_Validation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product p)
        {
            if (ModelState.IsValid)
            {
                //Database de Product tablosuna kayıt
            }
            return View(p);
        }
    }
}
