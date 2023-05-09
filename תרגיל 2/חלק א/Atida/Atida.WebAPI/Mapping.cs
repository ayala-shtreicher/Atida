using Atida.Repositories.Entities;
using Atida.WebAPI.Models;
using AutoMapper;

namespace Atida.WebAPI
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Vaccination, VaccinationModel>().ReverseMap();
            CreateMap<SicknessDetails, SicknessDetailsModel>().ReverseMap();
            CreateMap<Address, AddressModel>().ReverseMap();
        }
    }
}
