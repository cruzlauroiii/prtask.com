using System.Net.Http;
using System.Text;
using System.Text.Json;

Console.WriteLine("1. Get JWT");
var AuthClient = new HttpClient();
var AuthBody = "{\"device_model\":\"SM-S928B\",\"device_brand\":\"samsung\",\"package_name\":\"com.gcash.business.pocketpay\",\"time_zone_offset\":28800000,\"password\":\"75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5\",\"app_version\":\"1.0.30\",\"login\":\"639568564236\",\"fcmtoken\":\"browser\",\"android_id\":\"e14ceab085867eab\"}";
AuthClient.DefaultRequestHeaders.Add("platform", "Android");
var R1 = AuthClient.PostAsync("https://pulsar.psr-it.com/api/v3/authorize", new StringContent(AuthBody, Encoding.UTF8, "application/json")).Result;
var Jwt = R1.Content.ReadAsStringAsync().Result.Trim();
Console.WriteLine("  JWT: " + (int)R1.StatusCode);

Console.WriteLine("2. Get ToPH token");
var C2 = new HttpClient();
C2.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Jwt);
C2.DefaultRequestHeaders.Add("platform", "Android");
var R2 = C2.PostAsync("https://pulsar.psr-it.com/api/v2/market/tid/toph", new StringContent("{\"phone\":639568564236}", Encoding.UTF8, "application/json")).Result;
var TophResp = R2.Content.ReadAsStringAsync().Result;
var TophToken = JsonDocument.Parse(TophResp).RootElement.GetProperty("token").GetString()!;
Console.WriteLine("  ToPH: " + TophToken[..50] + "...");

Console.WriteLine("\n3. Try activation - bare JSON, no JWS, no Accept");
var C3 = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };
C3.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + TophToken);
C3.DefaultRequestHeaders.Add("User-Agent", "mobile_cashier_android");
var Body = JsonSerializer.Serialize(new
{
    method = new { kind = "Token", value = TophToken },
    rnsId = System.Guid.NewGuid().ToString(),
    deviceInfo = new { id = "test", country = "PH", language = "en", manufacturer = "test", model = "test" },
    certificates = Array.Empty<string>(),
});
var R3 = C3.PostAsync("https://mob-gcash.t2ph.psr-it.com/api/mt/activations", new StringContent(Body, Encoding.UTF8, "application/json")).Result;
var B3 = R3.Content.ReadAsStringAsync().Result;
Console.WriteLine("  No JWS, No Accept: " + (int)R3.StatusCode + " " + B3);

Console.WriteLine("\n4. Try with Accept: application/json");
var C4 = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };
C4.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + TophToken);
C4.DefaultRequestHeaders.Add("User-Agent", "mobile_cashier_android");
C4.DefaultRequestHeaders.Add("Accept", "application/json");
var R4 = C4.PostAsync("https://mob-gcash.t2ph.psr-it.com/api/mt/activations", new StringContent(Body, Encoding.UTF8, "application/json")).Result;
var B4 = R4.Content.ReadAsStringAsync().Result;
Console.WriteLine("  Accept JSON: " + (int)R4.StatusCode + " " + B4);

Console.WriteLine("\n5. Try with Accept: */*");
var C5 = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };
C5.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + TophToken);
C5.DefaultRequestHeaders.Add("User-Agent", "mobile_cashier_android");
C5.DefaultRequestHeaders.Add("Accept", "*/*");
var R5 = C5.PostAsync("https://mob-gcash.t2ph.psr-it.com/api/mt/activations", new StringContent(Body, Encoding.UTF8, "application/json")).Result;
var B5 = R5.Content.ReadAsStringAsync().Result;
Console.WriteLine("  Accept */*: " + (int)R5.StatusCode + " " + B5);

Console.WriteLine("\n6. Try Content-Type: application/jwt");
var C6 = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };
C6.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + TophToken);
C6.DefaultRequestHeaders.Add("User-Agent", "mobile_cashier_android");
C6.DefaultRequestHeaders.Add("Accept", "application/jwt");
var R6 = C6.PostAsync("https://mob-gcash.t2ph.psr-it.com/api/mt/activations", new StringContent(Body, Encoding.UTF8, "application/jwt")).Result;
var B6 = R6.Content.ReadAsStringAsync().Result;
Console.WriteLine("  CT jwt: " + (int)R6.StatusCode + " " + B6);
