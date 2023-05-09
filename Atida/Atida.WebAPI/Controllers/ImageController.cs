using Atida.Repositories.Intefaces;
using Atida.Services.Interfaces;
using Atida.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atida.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IUserService _userService;
        public ImageController(IUserService userService)
        {
            _userService = userService;
        }

        // GET api/<ImageController>/5
        [HttpGet("{imageName}")]
        public IActionResult GetImage(string imageName)
        {
            // Check if the image exists in the storage system
            if (!ImageExists(imageName))
            {
                return NotFound("Image not found.");
            }

            // Read the image file from the storage system
            var filePath = GetImagePath(imageName);
            var fileBytes = System.IO.File.ReadAllBytes(filePath);

            // Determine the content type based on the file extension
            var contentType = GetContentType(imageName);

            // Return the image as a file response
            return File(fileBytes, contentType);
        }

        private bool ImageExists(string imageName)
        {
            // Set the base directory path where the images are stored
            var baseDirectory = "C:\\Users\\97250\\Desktop\\אילה\\אילה תכנות\\Atida\\Atida\\Atida.WebAPI\\images";

            // Combine the base directory path with the image name to get the full file path
            var filePath = Path.Combine(baseDirectory, imageName);

            // Check if the file exists
            return System.IO.File.Exists(filePath);
        }


        private string GetImagePath(string imageName)
        {
            // Set the base directory path where the images are stored
            var baseDirectory = "C:\\Users\\97250\\Desktop\\אילה\\אילה תכנות\\Atida\\Atida\\Atida.WebAPI\\images";

            // Combine the base directory path with the image name to get the full file path
            var filePath = Path.Combine(baseDirectory, imageName);

            // Ensure the file exists before returning the file path
            if (System.IO.File.Exists(filePath))
            {
                return filePath;
            }

            // If the file does not exist, return null or handle the scenario accordingly
            return null;
        }


        private string GetContentType(string imageName)
        {
            var fileExtension = Path.GetExtension(imageName);

            // Define a mapping of file extensions to content types
            var contentTypeMappings = new Dictionary<string, string>
            {
                { ".jpg", "image/jpeg" },
                { ".jpeg", "image/jpeg" },
                { ".png", "image/png" },
                { ".gif", "image/gif" },
            };

            // Look up the content type based on the file extension
            if (contentTypeMappings.ContainsKey(fileExtension))
            {
                return contentTypeMappings[fileExtension];
            }

            // If the file extension is not recognized, return a default content type
            return "application/octet-stream";
        }

        // POST api/<ImageController>
        [HttpPost]
        public async Task<IActionResult> UploadImage([FromForm] ImageModel model)
        {
            if (model.ImageFile == null || model.ImageFile.Length == 0)
            {
                return BadRequest("No image file uploaded.");
            }

            // Save the image file
            var filePath = Path.Combine("images", model.Name);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await model.ImageFile.CopyToAsync(stream);
            }

            return Ok("Image uploaded successfully.");
        }

    }
}
