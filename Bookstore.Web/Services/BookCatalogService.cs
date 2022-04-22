using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bookstore.Web.Services
{
    public class BookCatalogService
    {
        public HttpClient Client { get; set; }
        public BookCatalogService(HttpClient client)
        {
            this.Client = client;
        }

        public async Task<List<BookResponse>> GetAllBooks()
        {
            var booksResponse = await Client.GetAsync("books");
            booksResponse.EnsureSuccessStatusCode();

            var stream = await booksResponse.Content.ReadAsStreamAsync();
            var books = await JsonSerializer.DeserializeAsync<List<BookResponse>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            return books;
        }

    }


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
    }


}

