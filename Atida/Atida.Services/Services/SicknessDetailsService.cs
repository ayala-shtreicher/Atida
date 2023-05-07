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
    public class SicknessDetailsService : ISicknessDetailsService
    {
        private readonly ISicknessDetailsRepository _sicknessDetailsRepository;
        public SicknessDetailsService(ISicknessDetailsRepository sicknessDetailsRepository)
        {
            _sicknessDetailsRepository = sicknessDetailsRepository;
        }

        public async Task<SicknessDetails> Add(SicknessDetails sicknessDetails, string tz)
        {
            return await _sicknessDetailsRepository.Add(sicknessDetails, tz);
        }

        public async Task<List<SicknessDetails>> GetAll()
        {
            return await _sicknessDetailsRepository.GetAll();
        }
    }
}
