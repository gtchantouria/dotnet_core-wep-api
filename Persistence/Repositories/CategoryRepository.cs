
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnet.Domain.Models;
using dotnet.Domain.Repositories;
using dotnet.Persistence.Contexts;

namespace dotnet.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}