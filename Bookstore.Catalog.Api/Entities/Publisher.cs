using System.Collections.Generic;

namespace Bookstore.Catalog.Api.Entities
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        public string CompanyName { get; set; }   
        public string Country { get; set; }
        public string Website { get; set; } 

        public ICollection <Book> Books { get; set; }
    }
}
