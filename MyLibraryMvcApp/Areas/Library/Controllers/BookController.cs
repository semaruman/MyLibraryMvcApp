using Microsoft.AspNetCore.Mvc;

namespace MyLibraryMvcApp.Areas.Library.Controllers
{
    [Area("Library")]
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
