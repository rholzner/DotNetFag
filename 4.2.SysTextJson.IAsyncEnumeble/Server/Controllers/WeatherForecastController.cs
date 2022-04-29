using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }


    [HttpGet(Name = "GetWeatherForecast")]
    public IAsyncEnumerable<WeatherForecast> GetWeatherForecastStream()
    {
        return streamWeatherForecastsAsync();
    }

    private async IAsyncEnumerable<WeatherForecast> streamWeatherForecastsAsync()
    {
        for (int daysFromToday = 1; daysFromToday <= 10; daysFromToday++)
        {
            await Task.Delay(1000);
            yield return new WeatherForecast
            {
                Date = DateTime.Now.AddDays(daysFromToday),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };
        };
    }
}
