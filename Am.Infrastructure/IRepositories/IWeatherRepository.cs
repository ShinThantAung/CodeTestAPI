using Am.Infrastructure.Dto.WeatherInfo;
using Am.Infrastructure.Entities;

namespace Am.Infrastructure.IRepositories
{
    public interface IWeatherRepository : IRepository<WeatherInfo>
    {

        Task<bool> AddAsync(WeatherInfo payloadList);
    }
}
