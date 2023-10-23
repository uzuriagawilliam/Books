namespace Books.API.Models
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        //public required string Author { get; set; }
        public List<string> AutorsList { get; set; }
    }
}
//public List<string> Booklist { get; set; }