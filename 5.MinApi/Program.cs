var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<EndPointApiGet>();



var app = builder.Build();


app.Run();




