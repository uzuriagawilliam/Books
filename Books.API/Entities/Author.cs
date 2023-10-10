using System.Diagnostics.CodeAnalysis;

namespace Books.Api.Entities
{
    public class Author
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }
        public required string Country { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();


        public Author()
        {            
        }
        [SetsRequiredMembers]
        public Author(Guid id, string name, string country)
        {
            Id = id;
            Name = name;
            Country = country;
        }
    }
}