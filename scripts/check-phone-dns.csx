using System.Net.Http;

var CompanionUrl = "http://192.168.100.103:8769";
var Client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

try
{
    var Status = Client.GetStringAsync($"{CompanionUrl}/status").Result;
    Console.WriteLine("Companion: " + Status);
}
catch (Exception Ex)
{
    Console.WriteLine("Companion offline: " + Ex.InnerException?.Message ?? Ex.Message);
    Console.WriteLine("Will try ADB instead...");
}

Console.WriteLine("\nChecking DNS from PC:");
var Domains = new[] { "mobilecashier.psr-it.com", "mobilecashier.ru", "api.psr-it.com", "pulsar.psr-it.com" };
foreach (var Domain in Domains)
{
    try
    {
        var Addresses = System.Net.Dns.GetHostAddresses(Domain);
        Console.WriteLine($"  {Domain} -> {string.Join(", ", Addresses.Select(a => a.ToString()))}");
    }
    catch (Exception Ex)
    {
        Console.WriteLine($"  {Domain}: NO RESOLVE - {Ex.InnerException?.Message ?? Ex.Message}");
    }
}
