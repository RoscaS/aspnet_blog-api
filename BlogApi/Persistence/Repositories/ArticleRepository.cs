using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApi.Domain.Models;
using BlogApi.Domain.Repositories;
using BlogApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Persistence.Repositories
{
    public class ArticleRepository : BaseRepository, IArticleRepository
    {
        public ArticleRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Article>> ListAsync() {
            return await _context.Articles.ToListAsync();
        }
    }
}