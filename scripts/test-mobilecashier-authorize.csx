using System.Net.Http;
using System.Text;

var Client = new HttpClient();
Client.DefaultRequestHeaders.Add("AndroidId", "e14ceab085867eab");

var AuthBody = "{\"device_model\":\"SM-S928B\",\"device_brand\":\"samsung\",\"package_name\":\"com.gcash.business.pocketpay\",\"time_zone_offset\":28800000,\"password\":\"75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5\",\"app_version\":\"1.0.30\",\"login\":\"639568564236\",\"fcmtoken\":\"browser\",\"android_id\":\"e14ceab085867eab\"}";

Console.WriteLine("=== POST mobilecashier.ru/api/v3/authorize ===");
var R = Client.PostAsync("https://mobilecashier.ru/api/v3/authorize", new StringContent(AuthBody, Encoding.UTF8, "application/json")).Result;
Console.WriteLine("Status: " + (int)R.StatusCode);
var Content = R.Content.ReadAsStringAsync().Result;
if (Content.Length > 500) Content = Content.Substring(0, 500);
Console.WriteLine("Body: " + Content);
foreach (var H in R.Headers)
    Console.WriteLine("  " + H.Key + ": " + string.Join(", ", H.Value));
