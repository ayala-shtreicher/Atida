using Atida.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atida.Repositories.Intefaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
        Task<User> Add(User user);
        int GetNotVaccinated();

    }
}
