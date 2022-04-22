using Bookstore.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bookstore.Web.Controllers
{
    public class BooksController : Controller
    {
        private BookCatalogService _bookCatalog;

        public BooksController(BookCatalogService bookCatalog)
        {
            _bookCatalog = bookCatalog;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _bookCatalog.GetAllBooks();

            return View(books);
        }
    }
}
