using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _service;
    
    public WeatherController(IWeatherService service)
        {
        _service = service;
        }

    [HttpGet]
    public ActionResult<WeatherResponse> Get(string city)
    {
                var res = _service.GetWeather(city);
                return Ok(res);
    }
}