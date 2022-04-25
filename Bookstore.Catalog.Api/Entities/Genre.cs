using System.Collections.Generic;

namespace Bookstore.Catalog.Api.Entities
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string Name { get; set; }
        public ICollection<BookGenre> Books { get; set; }
    }
}
