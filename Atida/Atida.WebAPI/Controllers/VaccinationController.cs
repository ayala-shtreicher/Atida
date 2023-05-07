using Atida.Repositories.Entities;
using Atida.Services.Interfaces;
using Atida.Services.Services;
using Atida.WebAPI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atida.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationController : ControllerBase
    {
        private readonly IVaccinationService _vaccinationService;
        private readonly IMapper _mapper;

        public VaccinationController(IVaccinationService vaccinationService, IMapper mapper)
        {
            _vaccinationService = vaccinationService;
            _mapper = mapper;
        }
        //GET
        [HttpGet]
        public async Task<List<VaccinationModel>> Get()
        {
            return _mapper.Map<List<VaccinationModel>>(await _vaccinationService.GetAll());
        }

        // POST api/<VaccinationController>
        [HttpPost]
        public async Task<VaccinationModel> Post([FromBody] VaccinationModel vaccinationModel,string tz)
        {
            return _mapper.Map<VaccinationModel>(await _vaccinationService.Add(_mapper.Map<Vaccination>(vaccinationModel),tz));
        }

      
    }
}
