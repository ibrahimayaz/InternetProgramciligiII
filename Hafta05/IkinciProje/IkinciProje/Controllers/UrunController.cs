using IkinciProje.Models;
using Microsoft.AspNetCore.Mvc;

namespace IkinciProje.Controllers
{
    public class UrunController : Controller
    {
        public static List<Urun> urunler = new();
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Urun u)
        {
            urunler.Add(u);
            return View("Liste",urunler);
        }
        public IActionResult Liste()
        {
            return View(urunler);
        }
    }
}
