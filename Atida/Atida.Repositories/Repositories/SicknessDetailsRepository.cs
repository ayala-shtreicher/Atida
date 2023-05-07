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
    public class SicknessDetailsRepository : ISicknessDetailsRepository
    {
        private readonly IUserRepository _userRepository;
        private readonly IContext _context;

        public SicknessDetailsRepository(IUserRepository userRepository, IContext context)
        {
            _userRepository = userRepository;
            _context = context;
        }

        public async Task<SicknessDetails> Add(SicknessDetails sicknessDetails,string tz)
        {
            sicknessDetails.UserId = _userRepository.GetUserIdByTz(tz).Id;
            _context.SicknessDetails.AddAsync(sicknessDetails);
            await _context.SaveChangesAsync();
            return sicknessDetails;
        }

        public async Task<List<SicknessDetails>> GetAll()
        {
            return await _context.SicknessDetails.ToListAsync();
        }
    }
}
