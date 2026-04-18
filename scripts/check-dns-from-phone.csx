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
    Console.WriteLine("Companion offline: " + Ex.Message);
    return;
}

Console.WriteLine("\nChecking DNS from PC:");
try
{
    var Addresses = System.Net.Dns.GetHostAddresses("mobilecashier.psr-it.com");
    foreach (var Addr in Addresses)
        Console.WriteLine("  mobilecashier.psr-it.com -> " + Addr);
}
catch (Exception Ex)
{
    Console.WriteLine("  mobilecashier.psr-it.com: " + Ex.Message);
}

try
{
    var Addresses = System.Net.Dns.GetHostAddresses("mobilecashier.ru");
    foreach (var Addr in Addresses)
        Console.WriteLine("  mobilecashier.ru -> " + Addr);
}
catch (Exception Ex)
{
    Console.WriteLine("  mobilecashier.ru: " + Ex.Message);
}

try
{
    var Addresses = System.Net.Dns.GetHostAddresses("pulsar.psr-it.com");
    foreach (var Addr in Addresses)
        Console.WriteLine("  pulsar.psr-it.com -> " + Addr);
}
catch (Exception Ex)
{
    Console.WriteLine("  pulsar.psr-it.com: " + Ex.Message);
}

Console.WriteLine("\nTrying to reach mobilecashier.psr-it.com directly:");
try
{
    var R = Client.GetAsync("https://mobilecashier.psr-it.com/").Result;
    Console.WriteLine("  Status: " + (int)R.StatusCode);
}
catch (Exception Ex)
{
    Console.WriteLine("  FAILED: " + Ex.InnerException?.Message ?? Ex.Message);
}

Console.WriteLine("\nTrying mobilecashier.ru/api/v2/market/order/toph (the sendOrder base URL might be here):");
try
{
    var R = Client.GetAsync("https://mobilecashier.ru/api/v2/market/order/toph").Result;
    Console.WriteLine("  Status: " + (int)R.StatusCode);
    Console.WriteLine("  Body: " + R.Content.ReadAsStringAsync().Result.Substring(0, Math.Min(200, (int)R.Content.Headers.ContentLength.GetValueOrDefault(0))));
}
catch (Exception Ex)
{
    Console.WriteLine("  " + (Ex.InnerException?.Message ?? Ex.Message));
}
