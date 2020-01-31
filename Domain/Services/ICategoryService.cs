
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet.Domain.Models;

namespace dotnet.Models.Services {
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}