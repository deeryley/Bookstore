namespace Bookstore.Catalog.Api.Entities
{
    public class BookGenre
    {
        public int BookID { get; set; }
        public int GenreID { get; set; }
        
        public Book Book { get; set; }
        public Genre Genre {get; set;}
        //Version 5 not required
    }
}
