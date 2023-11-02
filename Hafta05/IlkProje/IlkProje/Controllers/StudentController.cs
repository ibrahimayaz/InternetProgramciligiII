using Microsoft.AspNetCore.Mvc;

namespace IlkProje.Controllers
{
    public class StudentController : Controller
    {
        public String Index()
        {
            return "Merhaba Dünya";
        }
        public ViewResult Index2()
        {
            return View();
        }

        public IActionResult Index3()
        {
            return Content("Merhaba Bitlis !");
        }

    }
}
