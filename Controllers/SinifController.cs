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
    // 9. Sınıflar
    new Sinif
    {
        Id = 1,
        Ad = "9A",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 1, Ad = "Ahmet", Soyad = "Öztürk" },
            new Ogrenci { Id = 2, Ad = "Zeynep", Soyad = "Can" }
        }
    },
    new Sinif
    {
        Id = 2,
        Ad = "9B",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 3, Ad = "Kemal", Soyad = "Güven" },
            new Ogrenci { Id = 4, Ad = "Emine", Soyad = "Sarı" }
        }
    },
    new Sinif
    {
        Id = 3,
        Ad = "9C",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 5, Ad = "Baran", Soyad = "Kılıç" },
            new Ogrenci { Id = 6, Ad = "Duru", Soyad = "Koç" }
        }
    },
    new Sinif
    {
        Id = 4,
        Ad = "9D",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 7, Ad = "Selim", Soyad = "Yıldız" },
            new Ogrenci { Id = 8, Ad = "Büşra", Soyad = "Demir" }
        }
    },
    new Sinif
    {
        Id = 5,
        Ad = "9E",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 9, Ad = "Furkan", Soyad = "Aydın" },
            new Ogrenci { Id = 10, Ad = "Melis", Soyad = "Gök" }
        }
    },

    // 10. Sınıflar
    new Sinif
    {
        Id = 6,
        Ad = "10A",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 11, Ad = "Ali", Soyad = "Yılmaz" },
            new Ogrenci { Id = 12, Ad = "Ayşe", Soyad = "Kara" }
        }
    },
    new Sinif
    {
        Id = 7,
        Ad = "10B",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 13, Ad = "Mehmet", Soyad = "Demir" },
            new Ogrenci { Id = 14, Ad = "Fatma", Soyad = "Çelik" }
        }
    },
    new Sinif
    {
        Id = 8,
        Ad = "10C",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 15, Ad = "Serkan", Soyad = "Kara" },
            new Ogrenci { Id = 16, Ad = "Ela", Soyad = "Aydın" }
        }
    },
    new Sinif
    {
        Id = 9,
        Ad = "10D",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 17, Ad = "Cem", Soyad = "Kurt" },
            new Ogrenci { Id = 18, Ad = "Zeynep", Soyad = "Sarı" }
        }
    },
    new Sinif
    {
        Id = 10,
        Ad = "10E",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 19, Ad = "Murat", Soyad = "Güzel" },
            new Ogrenci { Id = 20, Ad = "Nisan", Soyad = "Gök" }
        }
    },

    // 11. Sınıflar
    new Sinif
    {
        Id = 11,
        Ad = "11A",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 21, Ad = "Ahmet", Soyad = "Öztürk" },
            new Ogrenci { Id = 22, Ad = "Ayşe", Soyad = "Kara" }
        }
    },
    new Sinif
    {
        Id = 12,
        Ad = "11B",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 23, Ad = "Mehmet", Soyad = "Demir" },
            new Ogrenci { Id = 24, Ad = "Fatma", Soyad = "Çelik" }
        }
    },
    new Sinif
    {
        Id = 13,
        Ad = "11C",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 25, Ad = "Serkan", Soyad = "Kara" },
            new Ogrenci { Id = 26, Ad = "Ela", Soyad = "Aydın" }
        }
    },
    new Sinif
    {
        Id = 14,
        Ad = "11D",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 27, Ad = "Cem", Soyad = "Kurt" },
            new Ogrenci { Id = 28, Ad = "Zeynep", Soyad = "Sarı" }
        }
    },
    new Sinif
    {
        Id = 15,
        Ad = "11E",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 29, Ad = "Murat", Soyad = "Güzel" },
            new Ogrenci { Id = 30, Ad = "Nisan", Soyad = "Gök" }
        }
    },

    // 12. Sınıflar
    new Sinif
    {
        Id = 16,
        Ad = "12A",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 31, Ad = "Baran", Soyad = "Kılıç" },
            new Ogrenci { Id = 32, Ad = "Duru", Soyad = "Koç" }
        }
    },
    new Sinif
    {
        Id = 17,
        Ad = "12B",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 33, Ad = "Selim", Soyad = "Yıldız" },
            new Ogrenci { Id = 34, Ad = "Büşra", Soyad = "Demir" }
        }
    },
    new Sinif
    {
        Id = 18,
        Ad = "12C",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 35, Ad = "Furkan", Soyad = "Aydın" },
            new Ogrenci { Id = 36, Ad = "Melis", Soyad = "Gök" }
        }
    },
    new Sinif
    {
        Id = 19,
        Ad = "12D",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 37, Ad = "Yusuf", Soyad = "Kurt" },
            new Ogrenci { Id = 38, Ad = "Ayşe", Soyad = "Sarı" }
        }
    },
    new Sinif
    {
        Id = 20,
        Ad = "12E",
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 39, Ad = "Emine", Soyad = "Yıldız" },
            new Ogrenci { Id = 40, Ad = "Ali", Soyad = "Öztürk" }
        }
    }
};


         public IActionResult Index()
    {
        return View(Siniflar);
    }

    // Detay sayfası (Seçilen sınıfın öğrencilerini gösterir)
    public IActionResult Detay(int id)
    {
        // Seçilen sınıfı bul
        var sinif = Siniflar.FirstOrDefault(s => s.Id == id);
        if (sinif == null) return NotFound();

        // Sınıf bilgisi ve öğrenci listesiyle birlikte gönder
        return View(sinif);
    }
}
}