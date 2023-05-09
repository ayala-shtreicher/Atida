namespace Atida.WebAPI.Models
{
    public class SicknessDetailsModel
    {
        public int UserId { get; set; }
        public DateTime PositiveResultTime { get; set; }
        public DateTime RecoveryTime { get; set; }
    }
}
