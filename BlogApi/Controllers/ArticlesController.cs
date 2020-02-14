using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BlogApi.Domain.Models;
using BlogApi.Domain.Services;
using BlogApi.Resources;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    public class ArticlesController : Controller
    {
        private readonly IArticleService _categoryService;
        private readonly IMapper _mapper;

        public ArticlesController(IArticleService categoryService, IMapper mapper) {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ArticleResource>> GetAllAsync() {
            var articles = await _categoryService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Article>, IEnumerable<ArticleResource>>(articles);
            return resources;
        }
    }
}