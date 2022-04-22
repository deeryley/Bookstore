using AutoMapper;
using Bookstore.Catalog.Api.Dto.Books;
using Bookstore.Catalog.Api.Entities;

namespace Bookstore.Catalog.Api.Mapping
{
    public class CatalogMappingProfile : Profile
    {
        public CatalogMappingProfile()
        {
            CreateMap<Book, BookResponse>().ReverseMap();
            CreateMap<BookAuthor, BookAuthorResponse>().ReverseMap();
            CreateMap<BookGenre, BookGenreResponse>().ReverseMap();
            CreateMap<Genre, GenreResponse>().ReverseMap();

        }
    }
}
