using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atida.Repositories.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
       // public Vaccination[] VaccinationTimes { get; set; } = new Vaccination[4];
        public List<Vaccination> VaccinationTimes { get; set; }
        public DateTime PositiveResultTime { get; set; }
        public DateTime RecoveryTime { get; set; }
        public static int notVaccinated { get; set; }
        public User()
        {

        }
        public User(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Tz = user.Tz;
            City = user.City;
            Street = user.Street;
            BuildingNumber = user.BuildingNumber;
            DateOfBirth = user.DateOfBirth;
            Phone = user.Phone;
            MobilePhone = user.MobilePhone;
            VaccinationTimes = user.VaccinationTimes;
            PositiveResultTime = user.PositiveResultTime;
            RecoveryTime = user.RecoveryTime;
            if (user.VaccinationTimes.Count ==0)
                notVaccinated++;
        }
    }
}
