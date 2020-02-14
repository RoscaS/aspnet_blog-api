namespace BlogApi.Domain.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}