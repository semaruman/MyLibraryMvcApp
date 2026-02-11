using Microsoft.AspNetCore.Mvc;

namespace MyLibraryMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("Library");
        }
    }
}
