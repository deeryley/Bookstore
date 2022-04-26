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

        public async Task<IActionResult> Authors()
        {
            var authors = await _bookCatalog.GetAllAuthors();
            return View(authors);
        }

        ///
        public async Task<IActionResult> Author(int id)
        {
            var author = await _bookCatalog.GetAuthor(id);
            return View(author);
        }

        public async Task<IActionResult> Book(int id)
        {
            var book = await _bookCatalog.GetBook(id);
            return View(book);
        }

    }
}
