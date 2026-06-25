using _02_RazorSyntax.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _02_RazorSyntax.Controllers
{
    public class HomeController : Controller
    {
        public static List<Product> products = new List<Product>()
        {
            new Product { Id = 1,Name = "Product 1", Price = 10.99m, ImageUrl = "resim1.webp",CategoryId=1 },
            new Product { Id = 2,Name = "Product 2", Price = 10.99m, ImageUrl = "resim2.webp",CategoryId=1 },
            new Product { Id = 3,Name = "Product 3", Price = 10.99m, ImageUrl = "resim3.webp",CategoryId=2 },
            new Product { Id = 4,Name = "Product 4", Price = 10.99m, ImageUrl = "resim4.webp",CategoryId=3 },
            new Product { Id = 5,Name = "Product 5", Price = 10.99m, ImageUrl = "resim5.webp",CategoryId=4 },
            new Product { Id = 6,Name = "Product 6", Price = 10.99m, ImageUrl = "resim6.webp",CategoryId=5 }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult ProductsByCategory(int id)
        {
            var urunler = products.Where(i => i.CategoryId == id).ToList(); 
            return View(urunler);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
