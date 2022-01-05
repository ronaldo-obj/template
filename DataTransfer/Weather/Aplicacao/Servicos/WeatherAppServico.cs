using AutoMapper;
using DataTransfer.Weather.Aplicacao.Servicos.Interfaces;
using DataTransfer.Weather.Responses;
using Dominio.Weather.Entidades;
using Dominio.Weather.Servicos.Interfaces;

namespace DataTransfer.Weather.Aplicacao.Servicos
{
    public class WeatherAppServico: IWeatherAppServico
    {
        private readonly IWeatherServico weatherServico;
        private readonly IMapper mapper;

        public WeatherAppServico(
            IWeatherServico weatherServico,
            IMapper mapper
            ) 
        {
            this.weatherServico = weatherServico;
            this.mapper = mapper;
        }

        public IEnumerable<WeatherForecastResponse> Recuperar()
        {
            return mapper.Map<IEnumerable<WeatherForecastResponse>>(weatherServico.Recuperar());
        }
    }
}
