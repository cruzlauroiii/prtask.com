using System.Net.Http;

var Client = new HttpClient { Timeout = TimeSpan.FromSeconds(5) };
var Base = "http://192.168.100.175:8769";
var Endpoints = new[] { "/status", "/logs", "/token", "/state", "/events", "/screen" };

foreach (var Ep in Endpoints)
{
    try
    {
        var R = Client.GetAsync($"{Base}{Ep}").Result;
        var Body = R.Content.ReadAsStringAsync().Result;
        if (Body.Length > 300) Body = Body[..300] + "...";
        Console.WriteLine($"{Ep} -> {R.StatusCode}: {Body}");
    }
    catch (Exception Ex)
    {
        Console.WriteLine($"{Ep} -> ERROR: {Ex.InnerException?.Message ?? Ex.Message}");
    }
    Console.WriteLine();
}
