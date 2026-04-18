using System.Net.Http;
using System.Text;
using System.Text.Json;

var BaseUrl = "https://mob-gcash.t2ph.psr-it.com";

Console.WriteLine("Step 1: Get JWT from pulsar");
var AuthClient = new HttpClient();
var AuthBody = "{\"device_model\":\"SM-S928B\",\"device_brand\":\"samsung\",\"package_name\":\"com.gcash.business.pocketpay\",\"time_zone_offset\":28800000,\"password\":\"75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5\",\"app_version\":\"1.0.30\",\"login\":\"639568564236\",\"fcmtoken\":\"browser\",\"android_id\":\"e14ceab085867eab\"}";
AuthClient.DefaultRequestHeaders.Add("platform", "Android");
AuthClient.DefaultRequestHeaders.Add("versionName", "1.0.30");
AuthClient.DefaultRequestHeaders.Add("versionCode", "110304");
var R1 = AuthClient.PostAsync("https://pulsar.psr-it.com/api/v3/authorize", new StringContent(AuthBody, Encoding.UTF8, "application/json")).Result;
var Token = R1.Content.ReadAsStringAsync().Result.Trim();
Console.WriteLine("  Auth: " + (int)R1.StatusCode + " Token len: " + Token.Length);

Console.WriteLine("\nStep 2: Try POST /api/mt/activations with device info");
var Client = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };
Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Token);
Client.DefaultRequestHeaders.Add("User-Agent", "mobile_cashier_android");

var DeviceInfo = new
{
    id = "e14ceab085867eab",
    country = "PH",
    language = "en",
    manufacturer = "samsung",
    model = "SM-S928B",
    title = "Samsung Galaxy S25 Ultra",
    osVersionSdk = 36,
    osVersion = "16",
    osName = "Android",
    securityPatch = "2026-03-01",
    appVersion = "1.0.30",
    appVersionCode = 110304,
    buildVersion = "1.0.30",
    brand = "samsung",
    product = "e3q",
    board = "s5e9945",
    hardware = "exynos2400",
    supportedAbis = new[] { "arm64-v8a", "armeabi-v7a", "armeabi" },
    screenWidth = 1440,
    screenHeight = 3120,
    appPackageName = "com.gcash.business.pocketpay",
    sdkVersion = "1.2.1",
    sdkVersionCode = 121,
    sdkBuildVersion = "1.2.1",
    memory = 12288000000L,
    appClassName = "com.gcash.business.pocketpay.App",
    appProcessName = "com.gcash.business.pocketpay",
    developerMode = false,
    appInstaller = "com.android.vending",
    nfcRequired = true,
    nfcEnabled = true,
    cameraRequired = false,
    cameraEnabled = true
};

var ActivationReq = new
{
    method = new { kind = "Phone", value = "639568564236" },
    rnsId = Guid.NewGuid().ToString(),
    deviceInfo = DeviceInfo,
    certificates = Array.Empty<string>(),
};

var ActivationJson = JsonSerializer.Serialize(ActivationReq);
Console.WriteLine("  Request body length: " + ActivationJson.Length);

try
{
    var R2 = Client.PostAsync($"{BaseUrl}/api/mt/activations", new StringContent(ActivationJson, Encoding.UTF8, "application/json")).Result;
    var Body2 = R2.Content.ReadAsStringAsync().Result;
    Console.WriteLine("  Status: " + (int)R2.StatusCode);
    Console.WriteLine("  Body: " + (Body2.Length > 500 ? Body2[..500] : Body2));
    foreach (var H in R2.Headers)
        Console.WriteLine("  " + H.Key + ": " + string.Join(", ", H.Value));
}
catch (Exception Ex) { Console.WriteLine("  FAILED: " + (Ex.InnerException?.Message ?? Ex.Message)); }

Console.WriteLine("\nStep 3: Try POST /api/mt/terminal/balance");
try
{
    var R3 = Client.PostAsync($"{BaseUrl}/api/mt/terminal/balance", new StringContent("{}", Encoding.UTF8, "application/json")).Result;
    var Body3 = R3.Content.ReadAsStringAsync().Result;
    Console.WriteLine("  Status: " + (int)R3.StatusCode + " Body: " + (Body3.Length > 300 ? Body3[..300] : Body3));
}
catch (Exception Ex) { Console.WriteLine("  FAILED: " + (Ex.InnerException?.Message ?? Ex.Message)); }

Console.WriteLine("\nStep 4: Try GET /api/mt/terminal/transactions/current");
try
{
    var R4 = Client.GetAsync($"{BaseUrl}/api/mt/terminal/transactions/current").Result;
    var Body4 = R4.Content.ReadAsStringAsync().Result;
    Console.WriteLine("  Status: " + (int)R4.StatusCode + " Body: " + (Body4.Length > 300 ? Body4[..300] : Body4));
}
catch (Exception Ex) { Console.WriteLine("  FAILED: " + (Ex.InnerException?.Message ?? Ex.Message)); }
