using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApi.Domain.Models;

namespace BlogApi.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}