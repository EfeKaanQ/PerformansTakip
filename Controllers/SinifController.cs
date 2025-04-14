using Microsoft.AspNetCore.Mvc;
using PerformansTakip.Models;
using System.Collections.Generic;
using System.Linq;

namespace PerformansTakip.Controllers
{
    public class SinifController : Controller
    {
        // Örnek veri
        private static List<Sinif> Siniflar = new List<Sinif>
        {
            new Sinif
            {
                Id = 1,
                Ad = "10A",
                Ogrenciler = new List<Ogrenci>
                {
                    new Ogrenci { Id = 1, Ad = "Ali", Soyad = "Yılmaz" },
                    new Ogrenci { Id = 2, Ad = "Ayşe", Soyad = "Kara" }
                }
            },
            new Sinif
            {
                Id = 2,
                Ad = "11B",
                Ogrenciler = new List<Ogrenci>
                {
                    new Ogrenci { Id = 3, Ad = "Mehmet", Soyad = "Demir" },
                    new Ogrenci { Id = 4, Ad = "Fatma", Soyad = "Çelik" }
                }
            }
        };

        public IActionResult Index()
        {
            // Sınıf listesini gönder
            return View(Siniflar);
        }

        public IActionResult Detay(int id)
        {
            // Seçilen sınıfın öğrencilerini bul
            var sinif = Siniflar.FirstOrDefault(s => s.Id == id);
            if (sinif == null) return NotFound();

            return View(sinif);
        }
    }
}