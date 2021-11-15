using System.Collections.Generic;

namespace DefaultWebAPI.Application.Forecasting
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}
