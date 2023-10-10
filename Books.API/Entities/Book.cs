using System.Diagnostics.CodeAnalysis;

namespace Books.Api.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; } 
        
        public List<Author> Authors  { get; set; } = new List<Author>();

        public Book()
        {
            
        }
        [SetsRequiredMembers]
        public Book(Guid id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
