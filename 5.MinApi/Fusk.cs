


//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<EndPointApiGet>();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new()
//    {
//        Title = builder.Environment.ApplicationName,
//        Version = "v1"
//    });
//});

//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.MapGet("/data", (EndPointApiGet data) => data.GetAll());
//app.MapGet("/data/{id}", (EndPointApiGet data, int id) => data.Get(id));

//app.UseSwagger();
//app.UseSwaggerUI(c =>
//{
//    c.RoutePrefix = "api";
//    c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{builder.Environment.ApplicationName} v1");
//});

//app.Run();

