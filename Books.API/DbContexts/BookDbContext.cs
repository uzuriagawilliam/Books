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
            _ = modelBuilder.Entity<Book>().HasData(
                new(Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9123"), "The Alchemist", "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna"),
                new(Guid.Parse("8e7e76fa-6095-11ee-8c99-0242ac120002"), "THINGS FALL APART", "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna"),
                new(Guid.Parse("8e7e79b6-6095-11ee-8c99-0242ac120002"), "PRIDE AND PREJUDICE ", "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna"),

                new(Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "A Brief History of Humankind", "Quisque iaculis lobortis porta"),
                new(Guid.Parse("8e7e7c4a-6095-11ee-8c99-0242ac120002"), "A Brief History of Humankind", "Quisque iaculis lobortis porta"),
                new(Guid.Parse("48754f0c-609b-11ee-8c99-0242ac120002"), "A Brief History of Humankind", "Quisque iaculis lobortis porta"),

                new(Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Untamed", "Pellentesque vel suscipit metus."),
                new(Guid.Parse("8e7e82f8-6095-11ee-8c99-0242ac120002"), "Untamed", "Pellentesque vel suscipit metus."),
                new(Guid.Parse("8e7e841a-6095-11ee-8c99-0242ac120002"), "Untamed", "Pellentesque vel suscipit metus."),


                new(Guid.Parse("c19099ed-94db-44ba-885b-0ad7205d5e40"), "Beloved", "In quis purus facilisis, vehicula magna at, aliquam orci"),
                new(Guid.Parse("48754840-609b-11ee-8c99-0242ac120002"), "Beloved", "In quis purus facilisis, vehicula magna at, aliquam orci"),
                new(Guid.Parse("48754afc-609b-11ee-8c99-0242ac120002"), "Beloved", "In quis purus facilisis, vehicula magna at, aliquam orci")
                );

            _ = modelBuilder.Entity<Author>().HasData(
               new(Guid.Parse("34dfab3c-5ec4-11ee-8c99-0242ac120002"), "Paulo Coelho", "Brasil"),
               new(Guid.Parse("34dfae16-5ec4-11ee-8c99-0242ac120002"), "Yuval Noah Harari", "Israel"),
               new(Guid.Parse("34dfaf74-5ec4-11ee-8c99-0242ac120002"), "Glennon Doyle", "USA"),
               new(Guid.Parse("34dfb30c-5ec4-11ee-8c99-0242ac120002"), "Toni Morrison", "USA")               
               
               );

            _ = modelBuilder
            .Entity<Author>()
            .HasMany(a => a.Books)
            .WithMany(b => b.Authors)
            .UsingEntity(e => e.HasData(
                new { AuthorsId = Guid.Parse("34dfab3c-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9123") },
                new { AuthorsId = Guid.Parse("34dfab3c-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("8e7e76fa-6095-11ee-8c99-0242ac120002") },
                new { AuthorsId = Guid.Parse("34dfab3c-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("8e7e79b6-6095-11ee-8c99-0242ac120002") },

                new { AuthorsId = Guid.Parse("34dfae16-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35") },
                new { AuthorsId = Guid.Parse("34dfae16-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("8e7e7c4a-6095-11ee-8c99-0242ac120002") },
                new { AuthorsId = Guid.Parse("34dfae16-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("48754f0c-609b-11ee-8c99-0242ac120002") },

                new { AuthorsId = Guid.Parse("34dfaf74-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96") },
                new { AuthorsId = Guid.Parse("34dfaf74-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("8e7e82f8-6095-11ee-8c99-0242ac120002") },
                new { AuthorsId = Guid.Parse("34dfaf74-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("8e7e841a-6095-11ee-8c99-0242ac120002") },

                new { AuthorsId = Guid.Parse("34dfb30c-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("c19099ed-94db-44ba-885b-0ad7205d5e40") },
                new { AuthorsId = Guid.Parse("34dfb30c-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("48754840-609b-11ee-8c99-0242ac120002") },
                new { AuthorsId = Guid.Parse("34dfb30c-5ec4-11ee-8c99-0242ac120002"), BooksId = Guid.Parse("48754afc-609b-11ee-8c99-0242ac120002") }
                ));

            base.OnModelCreating(modelBuilder);
        }
    }
}
