using System.Net.Http;
using System.Text;

Console.WriteLine("DNS check:");
foreach (var Domain in new[] { "mob-gcash.t2ph.psr-it.com", "pin-gcash.t2ph.psr-it.com" })
{
    try
    {
        var Addresses = System.Net.Dns.GetHostAddresses(Domain);
        Console.WriteLine($"  {Domain} -> {string.Join(", ", Addresses.Select(a => a.ToString()))}");
    }
    catch (Exception Ex)
    {
        Console.WriteLine($"  {Domain}: NO RESOLVE");
    }
}

Console.WriteLine("\nStep 1: Fresh JWT");
var AuthClient = new HttpClient();
var AuthBody = "{\"device_model\":\"SM-S928B\",\"device_brand\":\"samsung\",\"package_name\":\"com.gcash.business.pocketpay\",\"time_zone_offset\":28800000,\"password\":\"75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5\",\"app_version\":\"1.0.30\",\"login\":\"639568564236\",\"fcmtoken\":\"browser\",\"android_id\":\"e14ceab085867eab\"}";
AuthClient.DefaultRequestHeaders.Add("platform", "Android");
AuthClient.DefaultRequestHeaders.Add("versionName", "1.0.30");
AuthClient.DefaultRequestHeaders.Add("versionCode", "110304");
var R1 = AuthClient.PostAsync("https://pulsar.psr-it.com/api/v3/authorize", new StringContent(AuthBody, Encoding.UTF8, "application/json")).Result;
var Token = R1.Content.ReadAsStringAsync().Result.Trim();
Console.WriteLine("  Auth: " + (int)R1.StatusCode);

Console.WriteLine("\nStep 2: GET /api/mt/info/jwt on mob-gcash.t2ph.psr-it.com");
var Client = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };
Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Token);
Client.DefaultRequestHeaders.Add("User-Agent", "mobile_cashier_android");
try
{
    var R2 = Client.GetAsync("https://mob-gcash.t2ph.psr-it.com/api/mt/info/jwt").Result;
    var Body2 = R2.Content.ReadAsStringAsync().Result;
    if (Body2.Length > 500) Body2 = Body2.Substring(0, 500);
    Console.WriteLine("  Status: " + (int)R2.StatusCode + " Body: " + Body2);
    foreach (var H in R2.Headers)
        Console.WriteLine("  " + H.Key + ": " + string.Join(", ", H.Value));
}
catch (Exception Ex) { Console.WriteLine("  FAILED: " + (Ex.InnerException?.Message ?? Ex.Message)); }

Console.WriteLine("\nStep 3: GET /api/mt/terminal/balance");
try
{
    var R3 = Client.GetAsync("https://mob-gcash.t2ph.psr-it.com/api/mt/terminal/balance").Result;
    var Body3 = R3.Content.ReadAsStringAsync().Result;
    if (Body3.Length > 500) Body3 = Body3.Substring(0, 500);
    Console.WriteLine("  Status: " + (int)R3.StatusCode + " Body: " + Body3);
}
catch (Exception Ex) { Console.WriteLine("  FAILED: " + (Ex.InnerException?.Message ?? Ex.Message)); }

Console.WriteLine("\nStep 4: POST /api/mt/activations (empty body)");
try
{
    var R4 = Client.PostAsync("https://mob-gcash.t2ph.psr-it.com/api/mt/activations", new StringContent("{}", Encoding.UTF8, "application/json")).Result;
    var Body4 = R4.Content.ReadAsStringAsync().Result;
    if (Body4.Length > 500) Body4 = Body4.Substring(0, 500);
    Console.WriteLine("  Status: " + (int)R4.StatusCode + " Body: " + Body4);
}
catch (Exception Ex) { Console.WriteLine("  FAILED: " + (Ex.InnerException?.Message ?? Ex.Message)); }
