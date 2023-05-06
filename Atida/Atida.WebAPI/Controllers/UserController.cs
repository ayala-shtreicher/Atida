using Atida.Repositories.Entities;
using Atida.Services.Interfaces;
using Atida.WebAPI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atida.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService,IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<List<UserModel>> Get()
        {
            return _mapper.Map<List<UserModel>>(await _userService.GetAll()); 
        }

        //[HttpGet]
        //public int GetNotVaccinated()
        //{
        //    return _userService.GetNotVaccinated(); 
        //}

        // POST api/<UserController>
        [HttpPost]
        public async Task<UserModel> Post([FromBody] UserModel userModel)
        {
            return _mapper.Map<UserModel>(await _userService.Add(_mapper.Map<User>(userModel)));
        }

    }
}
