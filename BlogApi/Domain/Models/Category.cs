using System.Collections.Generic;

namespace BlogApi.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Article> Articles { get; set; } = new List<Article>();
    }
}