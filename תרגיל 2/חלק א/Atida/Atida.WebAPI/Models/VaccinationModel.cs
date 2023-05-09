namespace Atida.WebAPI.Models
{
    public class VaccinationModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime ReciveTime { get; set; }
        public string Manufacturer { get; set; }
    }
}
