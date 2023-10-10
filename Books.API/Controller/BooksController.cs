using AutoMapper;
using Books.Api.Entities;
using Books.API.Models;
using Books.API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
namespace Books.API.Controller
{
    [ApiController]
    [Route("api/books")]
    [Authorize]
    public class BooksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IBookRepo bookRepo;

        public BooksController(IMapper _mapper, IBookRepo _bookRepo) 
        {            
            mapper = _mapper;
            bookRepo = _bookRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<BookDto>>> GetBooks()
        {            
            var books = await bookRepo.GetBooks();

            if (books == null)
            {
                return NoContent();
            }

            return Ok(mapper.Map<List<BookDto>>(books));
        }

        [HttpGet("{id}", Name = "BookById")]
        public async Task<Results<NotFound, Ok<BookDto>>> GetBookById(Guid id)
        {

            var book = await bookRepo.GetBookById(id);

            if (book == null)
            {
                return TypedResults.NotFound();
            }            

            return TypedResults.Ok(mapper.Map<BookDto>(book));
        }

        [HttpPost]
        public ActionResult<Guid> AddBook(AddBookDto addBook)
        {
            var tmpBook = mapper.Map<Book>(addBook);

            bookRepo.AddBook(tmpBook);       

            return CreatedAtRoute("BookById", new { id = tmpBook.Id }, tmpBook);
        }        

    }
}
