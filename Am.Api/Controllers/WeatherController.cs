using Am.Infrastructure.Dto.WeatherInfo;
using Am.Infrastructure.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Am.Api.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class WeatherController : ControllerBase
    {
        #region Private
        private readonly IWeatherService _WeatherService;
        private readonly ILogger<WeatherController> _logger;
        #endregion

        // TODO: Add Centralize Logging
        public WeatherController(IWeatherService WeatherService,
            ILogger<WeatherController> logger)
        {
            _WeatherService = WeatherService;
            _logger = logger;
        }


        [HttpPost]
        public async Task<ActionResult> WeatherInfo(RequestModel payloadList)
        {
            // Log the request JSON data
            _logger.LogInformation("Request JSON data: {WeatherData}", JsonConvert.SerializeObject(payloadList));
            await _WeatherService.AddAsync(payloadList);
            // Log the response 
            _logger.LogInformation("Success");
            return Ok();
        }


    }
}