namespace Atida.WebAPI.Models
{
    public class ImageModel
    {
        public int ImageId { get; set; }
        public string Name { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
