// See https://aka.ms/new-console-template for more information
using System.Text.Json;

Console.WriteLine("Hello, World!");

using (var client = new HttpClient())
{
    var response = await client.GetAsync("https://localhost:7041/WeatherForecast/", HttpCompletionOption.ResponseHeadersRead);

    using var stream = Console.OpenStandardOutput();
    await response.Content.CopyToAsync(stream);
    
}
Console.WriteLine("done");
Console.ReadLine();


