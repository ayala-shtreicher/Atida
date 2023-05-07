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
    public class SicknessDetailsController : ControllerBase
    {

        private readonly ISicknessDetailsService _sicknessDetailsService;
        private readonly IMapper _mapper;

        public SicknessDetailsController(ISicknessDetailsService sicknessDetailsService, IMapper mapper)
        {
            _sicknessDetailsService = sicknessDetailsService;
            _mapper = mapper;
        }


        // GET: api/<SicknessDetailsController>
        [HttpGet]
        public async Task<List<SicknessDetailsModel>> Get()
        {
            return _mapper.Map<List<SicknessDetailsModel>>(await _sicknessDetailsService.GetAll());   
        }

       
        // POST api/<SicknessDetailsController>
        [HttpPost]
        public async Task<SicknessDetailsModel> Post([FromBody] SicknessDetailsModel sicknessDetailsModel,string tz)
        {
            return _mapper.Map<SicknessDetailsModel>(await _sicknessDetailsService.Add(_mapper.Map<SicknessDetails>(sicknessDetailsModel), tz));
        }

    }
}
