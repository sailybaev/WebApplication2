
using Microsoft.AspNetCore.Mvc;

using Moq;
using WebApplication2.Controllers;
using WebApplication2.Models;
using WebApplication2.Services;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var service = new WeatherService();

        var res = service.GetWeather("London");

        Assert.Equal("London", res.City);
    }

    [Fact]
    public void Test2()
    {
        var mock = new Mock<IWeatherService>();
        mock.Setup(w => w.GetWeather("London"))
            .Returns(new WeatherResponse
            {
                City = "London",
                Temperature = 15,
                Description = "Raining"
            });


        var controller = new WeatherController(mock.Object);

        var res = controller.Get("London");

        Assert.NotNull(res);

        var okResult = Assert.IsType<OkObjectResult>(res.Result);
        var data = Assert.IsType<WeatherResponse>(okResult.Value);
        Assert.Equal("Raining", data.Description);

    }
}

