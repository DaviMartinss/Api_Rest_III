using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_APOSTILA.Domain.Models;
using API_APOSTILA.Domain.Services.Communication;

namespace API_APOSTILA.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();

         Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);
       
    }
}
