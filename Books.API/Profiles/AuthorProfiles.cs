using AutoMapper;
using Books.Api.Entities;
using Books.API.Models;

namespace Books.API.Profiles
{
    public class AuthorProfiles : Profile
    {
        public AuthorProfiles()
        {

            CreateMap<Author, AuthorDto>()
                .ForMember(a => a.Booklist,
                    opt => opt.MapFrom(
                src => src.Books.Select(
                            book => book.Title
                            )
                        )
            );
        }
    }
}
