using ApplicationContextDB;
using AuthorizationService.Controllers;
using EntitiesRepositories;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddControllers();

services.AddSingleton<ILogger>(s => s.GetService<ILogger<AuthController>>()!);


var app = builder.Build();

builder.Configuration.AddJsonFile("appsettings.json");

app.MapControllers();

app.Run();
