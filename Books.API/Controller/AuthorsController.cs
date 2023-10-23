using AutoMapper;
using Books.Api.DbContexts;
using Books.Api.Entities;
using Books.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Books.API.Controller
{
    [ApiController]
    [Route("api/authors")]
    //[Authorize]
    public class AuthorsController : ControllerBase
    {
        private readonly BookDbContext bookDb;
        private readonly IMapper mapper;
        public AuthorsController(BookDbContext context, IMapper _mapper)
        {
            bookDb = context;
            mapper = _mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<AuthorDto>>> GetAuthors()
        {
            var authors = await bookDb.Authors.Include(author => author.Books).ToListAsync();
            if (authors == null)
            {
                return NoContent();
            }

            return Ok(mapper.Map<List<AuthorDto>>(authors));
        }

        [HttpGet("{serchedAuthor}")]
        public async Task<ActionResult<List<AuthorDto>>> GetAuthors(string? serchedAuthor)
        {
            var authors = await bookDb.Authors.Include(author => author.Books).Where(a => a.Name.Contains(serchedAuthor) ).ToListAsync();
            if (authors == null)
            {
                return NoContent();
            }

            return Ok(mapper.Map<List<AuthorDto>>(authors));
        }

        [HttpGet("{id:Guid}", Name = "AuthorById")]
        public async Task<Results<NotFound, Ok<AuthorDto>>> GetAuthorById(Guid id)
        {
            var author = await bookDb.Authors.Include(author => author.Books).FirstOrDefaultAsync(a => a.Id == id);

            if (author == null)
            {
                return TypedResults.NotFound();
            }

            return TypedResults.Ok(mapper.Map<AuthorDto>(author));
        }
    }
}
