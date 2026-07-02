using _04_ViewToController.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _04_ViewToController.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //İki farklı method çeşiti vardır.
        //1.GET method:View sayfasını ekrana getirir.
        //2.POST method: View sayfasından controller a data taşınmasını sağlar.
        //Tanımlanmazsa bütün IActionResult lar default olrak GET methoda sahiptir.

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string adsoyad)
        {
            return View();
        }

        #region 1.Yol
        //public IActionResult Register()
        //{
        //    //Ad,Soyad,Email,Password

        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Register(string ad,string soyad,string email,string password)
        //{
        //    User user = new User();
        //    user.Surname = soyad;
        //    user.Email = email;
        //    user.Name = ad;
        //    user.Password = password;

        //    //Database kaydını yaparsınız
        //    return View();
        //}
        #endregion

        #region 2.Yol
        public IActionResult Register1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register1(User user)
        {
            //Database Kayıdı Yapılır
            return View();
        }
        #endregion


        public IActionResult Register2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register2(User user)
        {
            //Database Kayıdı Yapılır
            return View();
        }
    }
}
