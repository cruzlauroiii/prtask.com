using System.Net.Http;
using System.Text;

Console.WriteLine("Step 1: Get fresh JWT from pulsar.psr-it.com");
var AuthClient = new HttpClient();
var AuthBody = "{\"device_model\":\"SM-S928B\",\"device_brand\":\"samsung\",\"package_name\":\"com.gcash.business.pocketpay\",\"time_zone_offset\":28800000,\"password\":\"75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5\",\"app_version\":\"1.0.30\",\"login\":\"639568564236\",\"fcmtoken\":\"browser\",\"android_id\":\"e14ceab085867eab\"}";
AuthClient.DefaultRequestHeaders.Add("platform", "Android");
AuthClient.DefaultRequestHeaders.Add("versionName", "1.0.30");
AuthClient.DefaultRequestHeaders.Add("versionCode", "110304");
var R1 = AuthClient.PostAsync("https://pulsar.psr-it.com/api/v3/authorize", new StringContent(AuthBody, Encoding.UTF8, "application/json")).Result;
var JwtResponse = R1.Content.ReadAsStringAsync().Result;
Console.WriteLine("  Status: " + (int)R1.StatusCode);

var Token = JwtResponse.Trim();
foreach (var H in R1.Headers)
{
    if (H.Key.ToLower().Contains("auth") || H.Key.ToLower().Contains("token") || H.Key.ToLower().Contains("bearer"))
        Console.WriteLine("  Header: " + H.Key + ": " + string.Join(", ", H.Value));
}
Console.WriteLine("  Token (first 50): " + Token.Substring(0, Math.Min(50, Token.Length)));

Console.WriteLine("\nStep 2: status/toph with fresh JWT");
var Client = new HttpClient();
Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Token);
Client.DefaultRequestHeaders.Add("AndroidId", "e14ceab085867eab");
Client.DefaultRequestHeaders.Add("platform", "Android");
Client.DefaultRequestHeaders.Add("versionName", "1.0.30");
Client.DefaultRequestHeaders.Add("versionCode", "110304");

var StatusBody = "{\"user_id\":\"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94\",\"device_uuid\":\"a29e8f74-e57b-46cf-80a9-a5dff92f49a2\",\"mid\":\"177397344332991\",\"tid\":\"SFT07056\"}";
var R2 = Client.PostAsync("https://mobilecashier.ru/api/v2/device/status/toph", new StringContent(StatusBody, Encoding.UTF8, "application/json")).Result;
Console.WriteLine("  Status: " + (int)R2.StatusCode);

Console.WriteLine("\nStep 3: order/toph immediately");
var OrderBody = "{\"user_id\":\"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94\",\"phone\":\"639568564236\",\"fio\":\"\",\"inn\":\"\",\"region_id\":0}";
var R3 = Client.PostAsync("https://mobilecashier.ru/api/v3/market/order/toph", new StringContent(OrderBody, Encoding.UTF8, "application/json")).Result;
var Body3 = R3.Content.ReadAsStringAsync().Result;
if (Body3.Length > 500) Body3 = Body3.Substring(0, 500);
Console.WriteLine("  Status: " + (int)R3.StatusCode + " Body: " + Body3);
foreach (var H in R3.Headers)
    Console.WriteLine("  " + H.Key + ": " + string.Join(", ", H.Value));
