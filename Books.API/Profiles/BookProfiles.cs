using AutoMapper;
using Books.Api.Entities;
using Books.API.Models;

namespace Books.API.Profiles
{
    public class BookProfiles : Profile
    {
        public BookProfiles()
        {
            CreateMap<AddBookDto, Book>();
            CreateMap<Book, BookDto>()
            .ForMember(b => b.AutorsList, opt => opt.MapFrom(
                src => src.Authors.Select(
                    author => author.Name
                    )
                )
            );        
        }

    }
}
