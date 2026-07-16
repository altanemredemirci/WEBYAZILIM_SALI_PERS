using _09_Dependency_Injection.Models;
using _09_Dependency_Injection.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _09_Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService _studentService;

        //Injection
        public HomeController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            List<Student> students = _studentService.GetAll();

            return View(students);
        }

     
    }
}
