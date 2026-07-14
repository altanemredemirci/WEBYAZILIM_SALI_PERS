using _08_Code_First_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _08_Code_First_2.Controllers
{
    public class HomeController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult Index()
        {
            //Tüm Öğrenciler
            //List<Ogrenci> ogrenciler = context.Ogrenciler.ToList();

            //Soyadı Demirci olan Öğrenciler
            //List<Ogrenci> ogrenciler = context.Ogrenciler.Where(i=> i.Soyad=="Demirci").ToList();

            //Id değeri 3 olan Öğrenci
            //Ogrenci ogrenci = context.Ogrenciler.Where(i => i.Id == 3).FirstOrDefault();
            //Ogrenci ogrenci = context.Ogrenciler.FirstOrDefault(i => i.Id == 3);
            //Ogrenci ogrenci = context.Ogrenciler.Find(3);

            //List<Ogrenci> ogrenciler = context.Ogrenciler.ToList();
            //List<Ogrenci> ogrenciler = context.Ogrenciler.Include(i=> i.Sinif).ToList();

            //return View(ogrenciler);


            //List<Sinif> siniflar = context.Siniflar.Include(i=> i.Ogrenciler).ToList();

            //return View(siniflar);


            List<Bolum> bolumler = context.Bolumler.Include(i => i.Siniflar).ThenInclude(i => i.Ogrenciler).ToList();

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
