using Books.Api.Entities;
using Books.API.Models;

namespace Books.API.Repositories
{
    public interface IBookRepo
    {
        Task<Book> GetBookById(Guid id);
        Task<List<Book>> GetBooks();
        void AddBook(Book addBook);
    }
}
