using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApi.Domain.Models;

namespace BlogApi.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}