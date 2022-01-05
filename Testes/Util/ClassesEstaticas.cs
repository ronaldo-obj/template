using Dominio.Weather.Entidades;
using FizzWare.NBuilder;
using System;

namespace Testes.Util
{
    public class ClassesEstaticas
    {
        public class ItemEstatico<T>
        {
            public Func<T> Factory { get; set; }
            public T Entidade
            {
                get { return Factory.Invoke(); }
            }

            public ItemEstatico(Func<T> funcaoGerarEntidade)
            {
                this.Factory = funcaoGerarEntidade;
            }
        }

        #region WeatherForecast
        public static ItemEstatico<WeatherForecast> WeatherForecast => new(() => Builder<WeatherForecast>.CreateNew().Build());
        #endregion
    }
}
