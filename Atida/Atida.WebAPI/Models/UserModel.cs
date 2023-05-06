using System.ComponentModel.DataAnnotations;

namespace Atida.WebAPI.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        //[StringLength(9,ErrorMessage ="Tz length can't be more than 9")]
       // [MinLength(9,ErrorMessage = "Tz length can't be less than 9")]
        public string Tz { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
       // [Phone]
        public string Phone { get; set; }
      //  [Phone]
        public string MobilePhone { get; set; }
       // public VaccinationModel[] VaccinationTimes { get; set; }=new VaccinationModel[4];
        public List<VaccinationModel> VaccinationTimes { get; set; }
        public DateTime PositiveResultTime { get; set; }
        public DateTime RecoveryTime { get; set; }
        public static int notVaccinatedModel { get; set; }
        public UserModel()
        {

        }
    }
}
