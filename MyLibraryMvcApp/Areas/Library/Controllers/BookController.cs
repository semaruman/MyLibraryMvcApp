using Microsoft.AspNetCore.Mvc;
using MyLibraryMvcApp.Areas.Library.Models;

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
        [HttpGet]
        public IActionResult Add()
        {
            return View(new Book());
        }

        [Route("{area}/Add")]
        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                BookDb db = new BookDb();
                db.AddBook(book);
                Book.sId++;
                return RedirectToAction("Success");
            }
            
            return View(book);
        }

        [Route("{area}/Success")]
        public IActionResult Success()
        {
            return View();
        }

        [Route("{area}/Remove")]
        [HttpGet]
        public IActionResult Remove()
        {
            return View(new Book());
        }

        [Route("{area}/Remove")]
        [HttpPost]
        public IActionResult Remove(Book book)
        {
            if (ModelState.IsValid)
            {
                BookDb db = new BookDb();
                db.RemoveBook(book);
                return RedirectToAction("RemoveSuccess");
            }

            return View(book);
        }

        [Route("{area}/RemoveSuccess")]
        public IActionResult RemoveSuccess()
        {
            return View();
        }
    }
}
