using Atida.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atida.Services.Interfaces
{
    public interface IVaccinationService
    {
        Task<List<Vaccination>> GetAll();

        Task<Vaccination> Add(Vaccination vaccination,string tz);
    }
}
