namespace Dominio.Weather.Entidades
{
    public class WeatherForecast
    {
        public virtual DateTime Date { get; protected set; }

        public virtual int TemperatureC { get; protected set; }

        public virtual int TemperatureF { get; protected set; }

        public virtual string? Summary { get; protected set; }

        public WeatherForecast() { }

        public WeatherForecast(
            DateTime date,
            int temperatureC,
            string? summary
            )
        {
            SetDate(date);
            SetTemperatureC(temperatureC);
            SetTemperatureF();
            SetSummary(summary);
        }

        public virtual void SetDate(DateTime date)
        {
            Date = date;
        }

        public virtual void SetTemperatureC(int temperatureC)
        {
            TemperatureC = temperatureC;
        }

        public virtual void SetTemperatureF() 
        {
            TemperatureF = 32 + (int)(TemperatureC / 0.5556);
        }

        public virtual void SetSummary(string? summary)
        {
            Summary = summary;
        }
    }
}
