using Microsoft.AspNetCore.Mvc;

namespace _6.DiContoller.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly WeatherForecastService weatherForecastService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastService weatherForecastService)
    {
        _logger = logger;
        this.weatherForecastService = weatherForecastService;
    }

    [HttpGet("")]
    public ActionResult<IEnumerable<WeatherForecast>> Og()
    {
        return Ok(weatherForecastService.GetAll());
    }

    [HttpGet("v1")]
    public ActionResult<IEnumerable<WeatherForecast>> v1([FromServices] WeatherForecastService weatherForecastService)
    {
       return Ok(weatherForecastService.GetAll());
    }

    [HttpGet("v2")]
    //Kommer snart
    public ActionResult v2(WeatherForecastService weatherForecastService)
    {
        return Ok(weatherForecastService.GetAll());
    }
}
