using System.ComponentModel.DataAnnotations;

namespace Atida.WebAPI.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [StringLength(9,ErrorMessage ="Tz length can't be more than 9")]
        [MinLength(9,ErrorMessage = "Tz length can't be less than 9")]
        public string Tz { get; set; }
        public AddressModel Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Phone]
        public string MobilePhone { get; set; }
        public UserModel()
        {

        }
    }
}
