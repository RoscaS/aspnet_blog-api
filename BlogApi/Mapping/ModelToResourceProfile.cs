using AutoMapper;
using BlogApi.Domain.Models;
using BlogApi.Resources;

namespace BlogApi.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile() {
            // classes properties have the same names and types,
            // so there is no need for special configuration.
            CreateMap<Category, CategoryResource>();
            CreateMap<Article, ArticleResource>();
        }
        
    }
}