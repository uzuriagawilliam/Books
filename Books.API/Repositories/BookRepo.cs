using AutoMapper;
using Books.Api.DbContexts;
using Books.Api.Entities;
using Books.API.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Books.API.Repositories
{
    public class BookRepo : IBookRepo
    {
        private readonly BookDbContext bookDb;
        public BookRepo(BookDbContext _bookDb)
        {
            bookDb = _bookDb;
        }
        public async Task<Book> GetBookById(Guid id)
        {
            var book = await bookDb.Books.FirstOrDefaultAsync(b => b.Id == id);
            return book;
        }

        public async Task<List<Book>> GetBooks()
        {
            var books = await bookDb.Books.Include(b => b.Authors).ToListAsync();
            
            return books;
        }
        
        public void AddBook(Book addBook)
        {

            var book = bookDb.Books.Add(addBook);

            bookDb.SaveChanges();

        }
    }
}
