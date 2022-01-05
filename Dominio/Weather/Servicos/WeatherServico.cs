using Dominio.Weather.Servicos.Interfaces;
using Dominio.Weather.Entidades;

namespace Dominio.Weather.Servicos
{
    public class WeatherServico : IWeatherServico
    {

        public WeatherServico()
        {

        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> Recuperar()
        {
            return Enumerable.Range(1, 5).Select(index => 
            new WeatherForecast(
                DateTime.Now.AddDays(index),
                Random.Shared.Next(-20, 55), 
                Summaries[Random.Shared.Next(Summaries.Length)]
                )).ToArray();
        } 
    }
}
