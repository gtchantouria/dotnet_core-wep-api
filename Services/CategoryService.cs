using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet.Domain.Models;
using dotnet.Domain.Repositories;
using dotnet.Models.Services;

namespace dotnet.Servicess
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository; 
        public CategoryService(ICategoryRepository repository) {
            this._categoryRepository = repository;
        }

        public async Task<IEnumerable<Category>> ListAsync() {
            return await _categoryRepository.ListAsync();
        }
    }
}