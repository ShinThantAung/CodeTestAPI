using Am.Infrastructure.Dto.WeatherInfo;

namespace Am.Infrastructure.IServices
{
    public interface IWeatherService
    {
        Task<bool> AddAsync(RequestModel payloadList);
    }
}
