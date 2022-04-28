// See https://aka.ms/new-console-template for more information
using System.Net.Http.Json;

Console.WriteLine("Hello, World!");

using(var client  = new HttpClient())
{
    var r = await client.GetFromJsonAsync<WeatherForecast[]>("https://localhost:7170/WeatherForecast/");
    foreach (var item in r)
    {
        Console.WriteLine(item);
    }

    try
    {
        await client.GetFromJsonAsync<WeatherForecast[]>("https://localhost:7170/WeatherForecast/problem");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Exception:");
        Console.WriteLine(ex.Message);
        Console.ReadLine();
    }

    try
    {
        await client.GetFromJsonAsync<WeatherForecast[]>("https://localhost:7170/WeatherForecast/bad");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Exception:");
        Console.WriteLine(ex.Message);
        Console.ReadLine();
    }
}
Console.WriteLine("done");
Console.ReadLine();




public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF { get; set; }   

    public string? Summary { get; set; }
}