namespace Atida.WebAPI.Models
{
    public class FileUploadAPI
    {
        public int ImgID { get; set; }
        public string? Users { get; set; }
        public IFormFile? files { get; set; }
        public string ImgName { get; set; }
    }
    public class common
    {
        public FileUploadAPI _fileAPI { get; set; }
        public UserModel User { get; set; }
        public List<UserModel> LstUsers { get; set; }
    }
}
