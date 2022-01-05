using AutoMapper;
using DataTransfer.Weather.Responses;
using Dominio.Weather.Entidades;

namespace DataTransfer.Weather.Aplicacao.Profiles
{
    public class WeatherForecastProfile : Profile
    {
        public WeatherForecastProfile()
        {
            CreateMap<WeatherForecast, WeatherForecastResponse>();
            CreateMap<WeatherForecastResponse, WeatherForecast>();
        }
    }
}
