using AutoMapper;
using costnotebook_backend.Models;
using costnotebook_backend.Models.Dto;

namespace costnotebook_backend.Maps
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        { 
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
