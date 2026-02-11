using Microsoft.AspNetCore.Mvc;

namespace MyLibraryMvcApp.Areas.Library.Controllers
{
    [Area("Library")]
    public class BookController : Controller
    {
        [Route("{area}/Books")]
        [Route("{area}")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{area}/Add")]
        public IActionResult Add()
        {
            return View();
        }
    }
}
