using Microsoft.AspNetCore.Mvc;

namespace _01_MVC.Controllers
{
    public class StudentController : Controller
    {
        //ActionResult: Bir html tasarımı döndürmek için kullanılan bir sınıftır.
        public IActionResult Index()
        {
            return View();
        }
    }
}
