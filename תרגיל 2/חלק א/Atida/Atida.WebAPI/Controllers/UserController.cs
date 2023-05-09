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

        // GET api/<ValuesController>/5
        [HttpGet("{tz}")]
        public async Task<UserModel> GetByTz(string tz)
        {
            return _mapper.Map<UserModel>(await _userService.GetByTz(tz));
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<UserModel> Post([FromBody] UserModel userModel,string city,string street,int buildingNumber)
        {
            AddressModel a=new AddressModel(city,street,buildingNumber);
            userModel.Address = a;
            return _mapper.Map<UserModel>(await _userService.Add(_mapper.Map<User>(userModel)));
        }

    }
}
