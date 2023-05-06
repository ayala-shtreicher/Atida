using Atida.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atida.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadAPIUploadController : ControllerBase
    {
        public static IWebHostEnvironment _environment;
        public FileUploadAPIUploadController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpPost]
        public Task<common> Post([FromForm] FileUploadAPI objFile)
        {
            common obj = new common();
            obj.LstUsers = new List<UserModel>();
            obj._fileAPI = new FileUploadAPI();
            try
            {
                List<UserModel> list = JsonConvert.DeserializeObject<List<UserModel>>(objFile.Users);
                obj.LstUsers = list;
                obj._fileAPI.ImgID = objFile.ImgID;
                obj._fileAPI.ImgName = "\\Upload\\" + objFile.files.FileName;
                if (objFile.files.Length > 0)
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream filestream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(filestream);
                        filestream.Flush();
                        //  return "\\Upload\\" + objFile.files.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            return Task.FromResult(obj);
        }
    }
}
