using System;
using System.Collections.Generic;

namespace Bookstore.Catalog.Api.Entities
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public byte[] Photo { get; set; }
        public int BirthYear { get; set; }
        public string Nationality { get; set; }
        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
        public ICollection<BookAuthor> Books { get; set; }
    }
}
