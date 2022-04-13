using System.Collections.Generic;

namespace Bookstore.Catalog.Api.Entities
{
    public class Language
    {
        public int LanguageID { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
