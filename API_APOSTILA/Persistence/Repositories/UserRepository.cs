using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_APOSTILA.Domain.Repositories;
using API_APOSTILA.Domain.Models;
using API_APOSTILA.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;


namespace API_APOSTILA.Persistence.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

         public async Task<IEnumerable<User>> ListAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task AddAsync(User User)
        {
            await _context.AddAsync(User);
        }

        public async Task<User> FindByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
        public async Task<User> FirstOrDefaultAsync(String login, String password)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Login == login && x.Password == password);
        }

         public void Update(User user)
        {
            _context.Users.Update(user);
        }
    
        public void Remove(User user)
        {
            _context.Users.Remove(user);
        }
    }
}
