using DataTransfer.Weather.Aplicacao.Servicos.Interfaces;
using DataTransfer.Weather.Responses;
using Microsoft.AspNetCore.Mvc;

namespace template.API.Controllers.Weather
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherAppServico weatherAppServico;
        private readonly ILogger<WeatherForecastController> logger;

        public WeatherForecastController(
            IWeatherAppServico weatherAppServico, 
            ILogger<WeatherForecastController> logger)
        {
            this.weatherAppServico = weatherAppServico;
            this.logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecastResponse> Get()
        {
            var retorno = weatherAppServico.Recuperar();
            logger.LogInformation("Template Criado");
            return retorno;
        }
    }
}