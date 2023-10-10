using Books.Api.Entities;

namespace Books.API.Models
{
    public class AddBookDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
    }
}