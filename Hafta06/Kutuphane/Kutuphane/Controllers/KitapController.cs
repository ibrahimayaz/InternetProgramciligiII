using Kutuphane.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kutuphane.Controllers
{
    public class KitapController:Controller
    {
        public static List<Kitap> kitaplar = new();
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Kitap k)
        {
            kitaplar.Add(k);
            return View("Liste", kitaplar);
        }

        public IActionResult Liste()
        {
            return View(kitaplar);
        }

    }
}
