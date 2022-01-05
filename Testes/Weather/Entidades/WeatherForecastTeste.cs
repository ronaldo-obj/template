using Dominio.Weather.Entidades;
using FizzWare.NBuilder;
using System;
using Testes.Util;
using Xunit;
using FluentAssertions;

namespace Testes.Weather.Entidades
{
    public class WeatherForecastTeste
    {
        private WeatherForecast sut;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastTeste()
        {
            sut = ClassesEstaticas.WeatherForecast.Entidade;
        }

        public class Contructor : WeatherForecastTeste
        {
            [Fact]
            public void Teste()
            {
                var data = DateTime.Now;
                var random = Random.Shared.Next(-20, 55);
                var sumarry = Summaries[Random.Shared.Next(Summaries.Length)];

                sut = new(
                    data, 
                    random,
                    sumarry
                    );

                sut.Date.Should().Be(data);
                sut.TemperatureC.Should().Be(random);
                sut.Summary.Should().Be(sumarry);
            }
        }
    }
}
