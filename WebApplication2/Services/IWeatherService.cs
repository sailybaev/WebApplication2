using WebApplication2.Models;

namespace WebApplication2.Services;

public interface IWeatherService
{
    WeatherResponse GetWeather(string city);
}