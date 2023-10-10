namespace Books.API.Models
{
    public class AuthorDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Country { get; set; }
        public List<string> Booklist { get; set; }
    }
}
