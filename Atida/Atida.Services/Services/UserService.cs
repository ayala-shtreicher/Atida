using Atida.Repositories.Entities;
using Atida.Repositories.Intefaces;
using Atida.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atida.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Add(User user)
        {
            return await _userRepository.Add(user);
        }

        public async Task<List<User>> GetAll()
        {
            return await _userRepository.GetAll();  
        }

        public async Task<User> GetByTz(string tz)
        {
            return await _userRepository.GetUserIdByTz(tz);
        }

        public int GetNotVaccinated()
        {
            return _userRepository.GetNotVaccinated();
        }

    }
}
