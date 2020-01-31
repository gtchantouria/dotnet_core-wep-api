using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet.Domain.Models;

namespace dotnet.Domain.Repositories
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}