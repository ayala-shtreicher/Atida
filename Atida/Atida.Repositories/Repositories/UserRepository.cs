using Atida.Repositories.Entities;
using Atida.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atida.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }
        public async Task<User> Add(User user)
        {
            _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public int GetNotVaccinated()
        {
            return User.notVaccinated;
        }
    }
}
