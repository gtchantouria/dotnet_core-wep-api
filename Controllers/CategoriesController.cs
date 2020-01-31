using Microsoft.AspNetCore.Mvc;
using dotnet.Models.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using dotnet.Domain.Models;

namespace dotnet.Controllers {

    [Route("/api/[controller]")]
    public class CategoriesController : Controller {
        private readonly ICategoryService _categoryService; 

        public CategoriesController(ICategoryService service) {
            _categoryService = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync() {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}