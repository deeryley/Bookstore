using Bookstore.Catalog.Api.Dto.Books;
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





}

