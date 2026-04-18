using System.Net.Http;

var Client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
var BaseUrl = "http://192.168.100.175:8769";

Console.WriteLine($"=== COMPANION CHECK {DateTime.Now:HH:mm:ss} ===");

var Endpoints = new[] { "/status", "/logs", "/state", "/token", "/logcat", "/accessibility", "/", "/api/logs", "/api/status", "/api/token" };

foreach (var Ep in Endpoints)
{
    try
    {
        var R = Client.GetAsync($"{BaseUrl}{Ep}").Result;
        var Body = R.Content.ReadAsStringAsync().Result;
        if (Body.Length > 200) Body = Body[..200] + "...";
        Console.WriteLine($"{Ep} -> {R.StatusCode}: {Body}");
    }
    catch (Exception Ex)
    {
        Console.WriteLine($"{Ep} -> ERROR: {Ex.InnerException?.Message ?? Ex.Message}");
    }
}
