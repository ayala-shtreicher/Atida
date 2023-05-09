using Atida.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atida.Services.Interfaces
{
    public interface ISicknessDetailsService
    {
        Task<List<SicknessDetails>> GetAll();
        Task<SicknessDetails> Add(SicknessDetails sicknessDetails, string tz);
    }
}
