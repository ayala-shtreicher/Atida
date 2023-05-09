using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Atida.Repositories.Entities
{
    public class Vaccination
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime ReciveTime { get; set; }
        public string Manufacturer { get; set; }

        public Vaccination(int id, int userId, DateTime reciveTime, string manufacturer)
        {
            Id = id;
            UserId = userId;
            ReciveTime = reciveTime;
            Manufacturer = manufacturer;
        }
    }
}
