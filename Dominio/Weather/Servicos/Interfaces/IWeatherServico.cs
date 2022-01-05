using Dominio.Weather.Entidades;

namespace Dominio.Weather.Servicos.Interfaces
{
    public interface IWeatherServico
    {
        IEnumerable<WeatherForecast> Recuperar();
    }
}
