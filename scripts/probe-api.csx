using System.Net.Http;
using System.Text;

var Client = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };

// Test various path combinations on api.psr-it.com
var Urls = new[] {
    \"https://api.psr-it.com/api/v2/market/order/toph\",
    \"https://api.psr-it.com/order/toph\",
    \"https://api.psr-it.com/v2/market/order/toph\",
    \"https://api.psr-it.com/market/order/toph\",
    \"https://api.psr-it.com/api/v2/device/status/toph\",
    \"https://api.psr-it.com/device/status/toph\",
};

foreach (var Url in Urls)
{
    try
    {
        var R = Client.PostAsync(Url, new StringContent(\"{}\", Encoding.UTF8, \"application/json\")).Result;
        Console.WriteLine(Url + \" -> \" + (int)R.StatusCode);
    }
    catch (Exception Ex)
    {
        Console.WriteLine(Url + \" -> ERROR: \" + (Ex.InnerException?.Message ?? Ex.Message));
    }
}
