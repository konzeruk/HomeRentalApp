
/*using ApplicationContextDB.Contexts;
using Microsoft.Extensions.Configuration;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();

using (var db = new ContextHomeDB(config, true))
{

}*/

using DTO.Models;
using System.Net.Http.Json;
using System.Text.Json;
var _x = new List<ReservationModel> { new ReservationModel()
    {
        StartDate = "fdfs",
        EndDate = "fdfs",
    } };
var test = new HomeModel()
{
    Id = 0,
    City = "Test1",
    District = "Test1D",
    Price = 300,
};

test.Reservations = _x;
var json = JsonContent.Create(test);

HttpClient client = new();

var resp = await client.SendAsync(new HttpRequestMessage()
{
    RequestUri = new Uri(@"http://localhost:3232/api/HomeStorage/postHome"),
    Method = HttpMethod.Post,
    Content = json
});

var x = 5;