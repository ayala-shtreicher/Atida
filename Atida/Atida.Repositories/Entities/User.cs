using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atida.Repositories.Entities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        //  public Adress adress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public Vaccination[] VaccinationTimes { get; set; } = new Vaccination[4];
        public DateTime PositiveResultTime { get; set; }
        public DateTime RecoveryTime { get; set; }
        public static int notVaccinated { get; set; }
        public User(string firstName, string lastName, string tz, DateTime dateOfBirth, string phone, string mobilePhone, DateTime positiveResultTime, DateTime recoveryTime)
        {
            FirstName = firstName;
            LastName = lastName;
            Tz = tz;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            MobilePhone = mobilePhone;
            PositiveResultTime = positiveResultTime;
            RecoveryTime = recoveryTime;
            if (VaccinationTimes[0]==null)
                notVaccinated++;
        }
    }
}
