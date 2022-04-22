using System.Collections;
using System.Collections.Generic;

namespace Bookstore.Catalog.Api.Dto.Books
{
    public class BookResponse
    {
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int PublisherID { get; set; }
        public int LanguageID { get; set; } 
        public decimal Price { get; set; }
        public string LanguageName { get; set; }
        public string PublisherCompanyName { get; set; }
        public ICollection<BookAuthorResponse> Authors { get; set; }
        public ICollection<BookGenreResponse> Genres { get; set; }

    }
}
