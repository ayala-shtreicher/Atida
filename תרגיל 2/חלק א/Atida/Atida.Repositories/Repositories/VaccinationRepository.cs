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
    public class VaccinationRepository : IVaccinationRepository
    {
        private readonly IContext _context;
        private readonly IUserRepository _userRepository;
        private const int MaxVaccination = 4;

        public VaccinationRepository(IContext context,IUserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
        }

        public async Task<Vaccination> Add(Vaccination vaccination,string tz)
        {
            int vaccinationCount = _context.Vaccinations.Count(a => a.UserId == vaccination.UserId);
            if (vaccinationCount < MaxVaccination)
            {
                vaccination.UserId=_userRepository.GetUserIdByTz(tz).Id;
                _context.Vaccinations.AddAsync(vaccination);
                await _context.SaveChangesAsync();
            }
            return null;
        }

        public async Task<List<Vaccination>> GetAll()
        {
            return await _context.Vaccinations.ToListAsync();
        }
        public async Task<int> NotVaccinated()
        {

            return await _context.Users.CountAsync() - await _context.Vaccinations.GroupBy(v => v.UserId).CountAsync();
        }

    }
}
