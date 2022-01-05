using DataTransfer.Weather.Responses;
using Dominio.Weather.Entidades;

namespace DataTransfer.Weather.Aplicacao.Servicos.Interfaces
{
    public interface IWeatherAppServico
    {
        IEnumerable<WeatherForecastResponse> Recuperar();
    }
}
