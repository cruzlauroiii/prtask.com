using System.Net.Http;
using System.Text;
using System.Text.Json;

Console.WriteLine("Step 1: Login to get JWT");
var AuthClient = new HttpClient();
var AuthBody = "{\"device_model\":\"SM-S928B\",\"device_brand\":\"samsung\",\"package_name\":\"com.gcash.business.pocketpay\",\"time_zone_offset\":28800000,\"password\":\"75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5\",\"app_version\":\"1.0.30\",\"login\":\"639568564236\",\"fcmtoken\":\"browser\",\"android_id\":\"e14ceab085867eab\"}";
AuthClient.DefaultRequestHeaders.Add("platform", "Android");
AuthClient.DefaultRequestHeaders.Add("versionName", "1.0.30");
AuthClient.DefaultRequestHeaders.Add("versionCode", "110304");
var R1 = AuthClient.PostAsync("https://pulsar.psr-it.com/api/v3/authorize", new StringContent(AuthBody, Encoding.UTF8, "application/json")).Result;
var Token = R1.Content.ReadAsStringAsync().Result.Trim();
Console.WriteLine("  JWT: " + (int)R1.StatusCode + " len=" + Token.Length);

Console.WriteLine("\nStep 2: Get ToPH token via /api/v2/market/tid/toph");
var Client = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };
Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Token);
Client.DefaultRequestHeaders.Add("platform", "Android");
Client.DefaultRequestHeaders.Add("versionName", "1.0.30");
Client.DefaultRequestHeaders.Add("versionCode", "110304");

var TophBody = JsonSerializer.Serialize(new { phone = 639568564236L });
try
{
    var R2 = Client.PostAsync("https://pulsar.psr-it.com/api/v2/market/tid/toph", new StringContent(TophBody, Encoding.UTF8, "application/json")).Result;
    var Body2 = R2.Content.ReadAsStringAsync().Result;
    Console.WriteLine("  Status: " + (int)R2.StatusCode);
    Console.WriteLine("  Body: " + (Body2.Length > 500 ? Body2[..500] : Body2));
}
catch (Exception Ex) { Console.WriteLine("  Error: " + (Ex.InnerException?.Message ?? Ex.Message)); }

Console.WriteLine("\nStep 3: Try /api/v3/market/tid/toph");
try
{
    var R3 = Client.PostAsync("https://pulsar.psr-it.com/api/v3/market/tid/toph", new StringContent(TophBody, Encoding.UTF8, "application/json")).Result;
    var Body3 = R3.Content.ReadAsStringAsync().Result;
    Console.WriteLine("  Status: " + (int)R3.StatusCode);
    Console.WriteLine("  Body: " + (Body3.Length > 500 ? Body3[..500] : Body3));
}
catch (Exception Ex) { Console.WriteLine("  Error: " + (Ex.InnerException?.Message ?? Ex.Message)); }
