using Atida.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atida.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        Task<User> GetByTz(string tz);
        Task<User> Add(User user);
        int GetNotVaccinated();

    }
}
