using WebApplication2.Models;

namespace WebApplication2.Services;

public class WeatherService : IWeatherService
{
    public WeatherResponse GetWeather(string city)
    {
        return new WeatherResponse
        {
            City = city,
            Temperature = 10,
            Description = "Cloudy"
        };
    }
}

