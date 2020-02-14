using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApi.Domain.Models;
using BlogApi.Domain.Repositories;
using BlogApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Category>> ListAsync() {
            return await _context.Categories.ToListAsync();
        }
    }
}