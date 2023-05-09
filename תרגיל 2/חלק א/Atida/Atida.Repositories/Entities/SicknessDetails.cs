using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atida.Repositories.Entities
{
    public class SicknessDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime PositiveResultTime { get; set; }
        public DateTime RecoveryTime { get; set; }
    }
}
