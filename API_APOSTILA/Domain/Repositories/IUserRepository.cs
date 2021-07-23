using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_APOSTILA.Domain.Models;

namespace API_APOSTILA.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ListAsync();
        Task AddAsync(User User);

        Task<User> FindByIdAsync(int id);
        Task<User> FirstOrDefaultAsync(String login, String password);

        void Update(User user);
        void Remove(User user);
    }
}
