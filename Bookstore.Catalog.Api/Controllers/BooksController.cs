using AutoMapper;
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
        private readonly IMapper _mapper;

        public BooksController(CatalogDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

           var bookResponses = _mapper.Map<List<BookResponse>>(books);

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

            var bookResponse = _mapper.Map<BookResponse>(book);

            return Ok(bookResponse);
        }

        [HttpPost]
        public async Task<ActionResult<BookResponse>> Post(BookRequest bookRequest)
        {
            var book = _mapper.Map<Book>(bookRequest);
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            var bookResponse = _mapper.Map<BookResponse>(book);

            return CreatedAtAction("Get", new { id = bookResponse.BookID }, bookResponse);
        }
    }
}
