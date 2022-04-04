using AutoMapper;
using TUTAPI.DomainModels;
using DataModels = TUTAPI.Models;

namespace TUTAPI.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>()
                .ReverseMap();
            CreateMap<DataModels.Gender, Gender>()
                .ReverseMap();
            CreateMap<DataModels.Address, Address>()
                .ReverseMap();
        }
    }
}
