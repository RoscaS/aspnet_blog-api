using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApi.Domain.Models;
using BlogApi.Domain.Repositories;
using BlogApi.Domain.Services;

namespace BlogApi.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) {
            _categoryRepository = categoryRepository;
        }
        
        public async Task<IEnumerable<Category>> ListAsync() {
            return await _categoryRepository.ListAsync();
        }
    }
}