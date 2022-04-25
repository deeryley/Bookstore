using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Catalog.Api.Dto.Books
{
    public class GenreResponse
    {
        public int GenreID { get; set; }
        public string Name { get; set; }

        public ICollection<BookResponse> Books { get; set; }
    }
}
