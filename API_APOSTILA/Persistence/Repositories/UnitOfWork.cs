using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_APOSTILA.Domain.Repositories;
using API_APOSTILA.Persistence.Contexts;

namespace API_APOSTILA.Persistence.Repositories
{
    public class UnitOfWork : IUnityOfWork
    {

        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
