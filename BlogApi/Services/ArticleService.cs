using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApi.Domain.Models;
using BlogApi.Domain.Repositories;
using BlogApi.Domain.Services;

namespace BlogApi.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository categoryRepository) {
            _articleRepository = categoryRepository;
        }
        
        public async Task<IEnumerable<Article>> ListAsync() {
            return await _articleRepository.ListAsync();
        }
    }
}