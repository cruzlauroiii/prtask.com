using System.Net.Http;
using System.Text;

Console.WriteLine("Step 1: Fresh JWT");
var AuthClient = new HttpClient();
var AuthBody = "{\"device_model\":\"SM-S928B\",\"device_brand\":\"samsung\",\"package_name\":\"com.gcash.business.pocketpay\",\"time_zone_offset\":28800000,\"password\":\"75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5\",\"app_version\":\"1.0.30\",\"login\":\"639568564236\",\"fcmtoken\":\"browser\",\"android_id\":\"e14ceab085867eab\"}";
AuthClient.DefaultRequestHeaders.Add("platform", "Android");
AuthClient.DefaultRequestHeaders.Add("versionName", "1.0.30");
AuthClient.DefaultRequestHeaders.Add("versionCode", "110304");
var R1 = AuthClient.PostAsync("https://pulsar.psr-it.com/api/v3/authorize", new StringContent(AuthBody, Encoding.UTF8, "application/json")).Result;
var Token = R1.Content.ReadAsStringAsync().Result.Trim();
Console.WriteLine("  Auth: " + (int)R1.StatusCode);

Console.WriteLine("\nStep 2: status/toph on mobilecashier.ru (should work)");
var Client = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };
Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Token);
Client.DefaultRequestHeaders.Add("AndroidId", "e14ceab085867eab");
Client.DefaultRequestHeaders.Add("platform", "Android");
Client.DefaultRequestHeaders.Add("versionName", "1.0.30");
Client.DefaultRequestHeaders.Add("versionCode", "110304");

var StatusBody = "{\"user_id\":\"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94\",\"device_uuid\":\"a29e8f74-e57b-46cf-80a9-a5dff92f49a2\",\"mid\":\"177397344332991\",\"tid\":\"SFT07056\"}";
var R2 = Client.PostAsync("https://mobilecashier.ru/api/v2/device/status/toph", new StringContent(StatusBody, Encoding.UTF8, "application/json")).Result;
Console.WriteLine("  Status: " + (int)R2.StatusCode);

Console.WriteLine("\nStep 3: order/toph on mobilecashier.ru (v2/market path)");
var OrderBody = "{\"user_id\":\"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94\",\"phone\":\"639568564236\",\"fio\":\"\",\"inn\":\"\",\"region_id\":0}";
try
{
    var R3 = Client.PostAsync("https://mobilecashier.ru/api/v2/market/order/toph", new StringContent(OrderBody, Encoding.UTF8, "application/json")).Result;
    var Body3 = R3.Content.ReadAsStringAsync().Result;
    if (Body3.Length > 500) Body3 = Body3.Substring(0, 500);
    Console.WriteLine("  Status: " + (int)R3.StatusCode + " Body: " + Body3);
}
catch (Exception Ex) { Console.WriteLine("  FAILED: " + (Ex.InnerException?.Message ?? Ex.Message)); }

Console.WriteLine("\nStep 4: order/toph on mobilecashier.ru (v3/market path)");
try
{
    var R4 = Client.PostAsync("https://mobilecashier.ru/api/v3/market/order/toph", new StringContent(OrderBody, Encoding.UTF8, "application/json")).Result;
    var Body4 = R4.Content.ReadAsStringAsync().Result;
    if (Body4.Length > 500) Body4 = Body4.Substring(0, 500);
    Console.WriteLine("  Status: " + (int)R4.StatusCode + " Body: " + Body4);
}
catch (Exception Ex) { Console.WriteLine("  FAILED: " + (Ex.InnerException?.Message ?? Ex.Message)); }

Console.WriteLine("\nStep 5: Try with Host header spoofed to mobilecashier.psr-it.com");
var Client2 = new HttpClient(new SocketsHttpHandler()) { Timeout = TimeSpan.FromSeconds(15) };
Client2.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Token);
Client2.DefaultRequestHeaders.Add("AndroidId", "e14ceab085867eab");
Client2.DefaultRequestHeaders.Add("platform", "Android");
Client2.DefaultRequestHeaders.Add("versionName", "1.0.30");
Client2.DefaultRequestHeaders.Add("versionCode", "110304");
Client2.DefaultRequestHeaders.Host = "mobilecashier.psr-it.com";
try
{
    var R5 = Client2.PostAsync("https://mobilecashier.ru/api/v2/market/order/toph", new StringContent(OrderBody, Encoding.UTF8, "application/json")).Result;
    var Body5 = R5.Content.ReadAsStringAsync().Result;
    if (Body5.Length > 500) Body5 = Body5.Substring(0, 500);
    Console.WriteLine("  Status: " + (int)R5.StatusCode + " Body: " + Body5);
}
catch (Exception Ex) { Console.WriteLine("  FAILED: " + (Ex.InnerException?.Message ?? Ex.Message)); }
