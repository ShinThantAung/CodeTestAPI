using Am.Infrastructure.Dto.WeatherInfo;
using Am.Infrastructure.Entities;
using Am.Infrastructure.IRepositories;

namespace Am.Repository.Ef.Repository
{
    public class WeatherRepository : IWeatherRepository
    {

        #region private
        private readonly ApplicationDbContext _context;
        #endregion
        public WeatherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //public async Task<bool> AddAsync(RequestModel model)
        //{
        //    _context.Add(model);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}

        public async Task<bool> AddAsync(WeatherInfo payloadList)
        {
            _context.Add(payloadList);
            await _context.SaveChangesAsync();
            return true;
        }
    }
    }
