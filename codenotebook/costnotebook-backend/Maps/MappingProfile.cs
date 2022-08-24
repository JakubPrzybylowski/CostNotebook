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
            CreateMap<Transaction, TransactionDto>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.TransactionId))
                .ForMember(dest => dest.Date,opt=>opt.MapFrom(src=>src.Date))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount));
            CreateMap<TransactionDto, Transaction>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount));
        }
    }
}
