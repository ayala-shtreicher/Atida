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
    public class VaccinationService : IVaccinationService
    {
        private readonly IVaccinationRepository _vaccinationRepository;

        public VaccinationService(IVaccinationRepository vaccinationRepository)
        {
            _vaccinationRepository = vaccinationRepository;
        }
        public async Task<Vaccination> Add(Vaccination vaccination,string tz)
        {
            return await _vaccinationRepository.Add(vaccination, tz);
        }

        public async Task<List<Vaccination>> GetAll()
        {
            return await _vaccinationRepository.GetAll();
        }

    }
}
