using System.Net.Http;

var C = new HttpClient { Timeout = TimeSpan.FromSeconds(3) };
try
{
    var R = C.GetAsync("http://192.168.100.175:8769/status").Result;
    Console.WriteLine($"Companion: {R.Content.ReadAsStringAsync().Result}");
}
catch (Exception E)
{
    Console.WriteLine($"Companion offline: {E.InnerException?.Message ?? E.Message}");
}

try
{
    var R2 = C.GetAsync("http://localhost:5400/api/status").Result;
    Console.WriteLine($"Backoffice proxy: {R2.Content.ReadAsStringAsync().Result}");
}
catch (Exception E)
{
    Console.WriteLine($"Backoffice offline: {E.InnerException?.Message ?? E.Message}");
}
