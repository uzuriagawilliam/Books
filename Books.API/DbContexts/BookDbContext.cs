using Books.Api.Entities;
using Books.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Books.Api.DbContexts
{
    public class BookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Book>()
                .HasData(
                new(Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9123"), "The Alchemist", "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna"),
                new(Guid.Parse("8e7e76fa-6095-11ee-8c99-0242ac120002"), "THINGS FALL APART", "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna"),
                new(Guid.Parse("8e7e79b6-6095-11ee-8c99-0242ac120002"), "PRIDE AND PREJUDICE ", "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna")                
                );

            _ = modelBuilder.Entity<Author>().HasData(
               new(Guid.Parse("34dfab3c-5ec4-11ee-8c99-0242ac120002"), "Paulo Coelho", "Brasil"),
               new(Guid.Parse("34dfaf74-5ec4-11ee-8c99-0242ac120002"), "Glennon Doyle", "USA"),
               new(Guid.Parse("34dfb30c-5ec4-11ee-8c99-0242ac120002"), "Toni Morrison", "USA")                              
               );

            _ = modelBuilder
            .Entity<Author>()
            .HasMany(a => a.Books)
            .WithMany(b => b.Authors)
            .UsingEntity(e => e.HasData(
                new { AuthorsId = Guid.Parse("34dfab3c-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9123") },//pc-alc
                new { AuthorsId = Guid.Parse("34dfab3c-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("8e7e76fa-6095-11ee-8c99-0242ac120002") },//pc-pc
                new { AuthorsId = Guid.Parse("34dfaf74-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("8e7e79b6-6095-11ee-8c99-0242ac120002") },//gd-pp
                new { AuthorsId = Guid.Parse("34dfaf74-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9123") },//gd-alc
                new { AuthorsId = Guid.Parse("34dfb30c-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("8e7e76fa-6095-11ee-8c99-0242ac120002") }//tm-tfa
                ));

            // _ = modelBuilder
            //.Entity<Book>()
            //.HasMany(b => b.Authors)
            //.WithMany(a => a.Books)
            //.UsingEntity(e => e.HasData(
            //    new { BooksId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9123"), AuthorsId = Guid.Parse("34dfab3c-5ec4-11ee-8c99-0242ac120002"), },//alc-pc
            //    new { BooksId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9123"), AuthorsId = Guid.Parse("34dfaf74-5ec4-11ee-8c99-0242ac120002"), },//ald-gd
            //    new { BooksId = Guid.Parse("8e7e76fa-6095-11ee-8c99-0242ac120002"), AuthorsId = Guid.Parse("34dfb30c-5ec4-11ee-8c99-0242ac120002"), },//tfa-tm
            //    new { BooksId = Guid.Parse("8e7e76fa-6095-11ee-8c99-0242ac120002"), AuthorsId = Guid.Parse("34dfab3c-5ec4-11ee-8c99-0242ac120002"), },//tfa-pc
            //    new { BooksId = Guid.Parse("8e7e79b6-6095-11ee-8c99-0242ac120002"), AuthorsId = Guid.Parse("34dfaf74-5ec4-11ee-8c99-0242ac120002"), }//pp-gd
            //    ));

            base.OnModelCreating(modelBuilder);
        }
    }
}
