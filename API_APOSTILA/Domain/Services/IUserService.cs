using System;
using API_APOSTILA.Domain.Services.Communication;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_APOSTILA.Domain.Models;

namespace API_APOSTILA.Domain.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> ListAsync();
        Task<UserResponse> SaveAsync(User user);
        Task<UserResponse> UpdateAsync(User user, int id);
        Task<UserResponse> DeleteAsync(int id);
        Task<UserResponse> FirstOrDefaultAsync(String login, String password);
    }
}
