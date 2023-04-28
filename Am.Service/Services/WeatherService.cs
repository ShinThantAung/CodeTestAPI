using Am.Infrastructure.Dto.WeatherInfo;
using Am.Infrastructure.Entities;
using Am.Infrastructure.IRepositories;
using Am.Infrastructure.IServices;
using AutoMapper;

namespace Am.Service.Services
{
    public class WeatherService : IWeatherService
    {
        #region Private
        private readonly IMapper _mapper;
        private readonly IWeatherRepository _WeatherRepository;
        #endregion
        public WeatherService(IWeatherRepository WeatherRepository,
            IMapper mapper)
        {

            _WeatherRepository = WeatherRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(RequestModel payloadList)
        {
            //var model = _mapper.Map<Transaction>(viewModel);
            ////model.CreatedDate = DateTime.UtcNow;
            //model.UpdatedDate = DateTime.UtcNow;
            //model.IsActive = true;
            WeatherInfo info = new WeatherInfo();
            info.IsActive = true;
            info.CreatedBy = "User";
            info.CreatedDate= DateTime.Now;
            info.Humidity = payloadList.data.humidity ?? 0;
            info.Temperature = payloadList.data.temperature ?? 0;
            bool occupancyValue = payloadList.data.occupancy ?? false;
            info.Occupancy = occupancyValue;
            await _WeatherRepository.AddAsync(info);
            return true;
        }


        //public async Task<bool> AddAsync(RequestModel payloadList)
        //{
        //    //var model = _mapper.Map<Transaction>(viewModel);
        //    ////model.CreatedDate = DateTime.UtcNow;
        //    //model.UpdatedDate = DateTime.UtcNow;
        //    //model.IsActive = true;

        //    await _WeatherRepository.AddAsync(payloadList);
        //    return true;
        //}


    }
}
