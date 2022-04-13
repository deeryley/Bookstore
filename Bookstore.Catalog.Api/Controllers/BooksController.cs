using Bookstore.Catalog.Api.Contexts;
using Bookstore.Catalog.Api.Dto.Books;
using Bookstore.Catalog.Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Catalog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly CatalogDbContext _context;

        public BooksController(CatalogDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookResponse>>> Get()
        {
            var books = await _context.Books
                .Include(x=> x.Publisher)
                .Include(x=> x.Language)
                .Include(x=> x.Authors)
                   .ThenInclude(x => x.Author)
                .Include(x=> x.Genres)
                  .ThenInclude(x=> x.Genre)
                .ToListAsync();

            var bookResponses = books.Select(x => new BookResponse()
            {
                BookID = x.BookID,
                ISBN = x.ISBN,
                Title = x.Title,
                Year = x.Year,
                Price = x.Price,
                LanguageID = x.LanguageID,
                LanguageName = x.Language.Name,
                PublisherID = x.PublisherID,
                PublisherCompanyName = x.Publisher.CompanyName,
                Authors = x.Authors.Select(a => new BookAuthorResponse()
                {
                    AuthorID = a.AuthorID,
                    AuthorFirstName = a.Author.FirstName,
                    AuthorLastName = a.Author.LastName
                }).ToList(),
                Genres = x.Genres.Select(g => new BookGenreResponse()
                {
                    GenreID = g.GenreID,
                    GenreName = g.Genre.Name,
                }).ToList()

            });
            
            return Ok(bookResponses);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> Post(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { id = book.BookID }, book);
        }
    }
}
