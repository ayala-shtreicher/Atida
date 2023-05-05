using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atida.Repositories.Entities
{
    public class Adress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
    }
}
