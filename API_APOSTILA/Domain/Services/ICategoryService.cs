using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_APOSTILA.Domain.Services.Communication;
using API_APOSTILA.Domain.Models;

namespace API_APOSTILA.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
