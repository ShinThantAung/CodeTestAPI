using Am.Infrastructure.Dto.WeatherInfo;
using Am.Infrastructure.Entities;
using AutoMapper;

namespace Am.Service
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            //CreateMap<RequestModel, WeatherInfo>()
            //.ForMember(dest => dest.Humidity, opt => opt.MapFrom(src => (int)src.data.humidity))
            //.ForMember(dest => dest.Temperature, opt => opt.MapFrom(src => (int)src.data.temperature))
            //.ForMember(dest => dest.Occupancy, opt => opt.MapFrom(src => (bool)src.data.occupancy));

            //CreateMap<Infrastructure.Dto.Transaction.TransactionRequestViewModel, Infrastructure.Entities.WeatherInfo>();


        }
    }
}
