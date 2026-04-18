using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Security.Cryptography;

var TophToken = "eyJhbGciOiJSUzI1NiIsImtpZCI6IjQzNEUzMTY3RDQzRDc2NDMyMTE1MEI4MURCNTE1QjYwRUY2MDY1MUMiLCJ0eXAiOiJKV1QifQ.eyJtZXJjaGFudElkIjoiMTc3Mzk3MzQ0MzMyOTkxIiwidGVybWluYWxJZCI6IlNGVDA3MDU2IiwiZXh0ZXJuYWxEYXRhIjoiUFNSIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWN0aXZhdGlvbiIsIm5iZiI6MTc3NDY3NzA2MiwiZXhwIjoyMDkwMjk2MjYyLCJpYXQiOjE3NzQ2NzcwNjIsImlzcyI6InRvcGgiLCJhdWQiOiJ0b3BoIn0.IT7p_xtuvCfhB8K0YB9ucRj4JFNnWSSqBegZ2wA5gGggFoG6BGgldBPE2Ya7ID";

var Rsa = RSA.Create(2048);
var CertReq = new System.Security.Cryptography.X509Certificates.CertificateRequest("CN=PocketPay", Rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
var Cert = CertReq.CreateSelfSigned(DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddYears(5));
var CertB64 = Convert.ToBase64String(Cert.RawData);

var DeviceInfo = new
{
    id = "e14ceab085867eab", country = "PH", language = "en", manufacturer = "samsung",
    model = "SM-S928B", title = "Samsung Galaxy S25 Ultra", osVersionSdk = 36, osVersion = "16",
    osName = "Android", securityPatch = "2026-03-01", appVersion = "1.0.30", appVersionCode = 110304,
    buildVersion = "1.0.30", brand = "samsung", product = "e3q", board = "s5e9945",
    hardware = "exynos2400", supportedAbis = new[] { "arm64-v8a" },
    screenWidth = 1440, screenHeight = 3120, appPackageName = "com.gcash.business.pocketpay",
    sdkVersion = "1.2.1", sdkVersionCode = 121, sdkBuildVersion = "1.2.1",
    memory = 12288000000L, appClassName = "com.gcash.business.pocketpay.App",
    appProcessName = "com.gcash.business.pocketpay",
    developerMode = false, appInstaller = "com.android.vending",
    nfcRequired = true, nfcEnabled = true, cameraRequired = false, cameraEnabled = true
};

var ActivationReq = JsonSerializer.Serialize(new
{
    method = new { kind = "Token", value = TophToken },
    rnsId = Guid.NewGuid().ToString(),
    deviceInfo = DeviceInfo,
    certificates = new[] { CertB64 },
});

string B64Url(byte[] D) => Convert.ToBase64String(D).TrimEnd('=').Replace('+', '-').Replace('/', '_');

var Nonce = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
var BodyHash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(ActivationReq))).ToLowerInvariant();
var JwsHeader = JsonSerializer.Serialize(new { alg = "RS256", x5c = new[] { CertB64 } });
var JwsPayload = JsonSerializer.Serialize(new { nonce = Nonce, method = "POST", body = BodyHash, request = "/api/mt/activations" });
var H64 = B64Url(Encoding.UTF8.GetBytes(JwsHeader));
var P64 = B64Url(Encoding.UTF8.GetBytes(JwsPayload));
var Sig = Rsa.SignData(Encoding.UTF8.GetBytes(H64 + "." + P64), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
var Jws = H64 + "." + P64 + "." + B64Url(Sig);

Console.WriteLine("Trying with Authorization: Bearer TophToken");

var Client = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };
Client.DefaultRequestHeaders.Add("User-Agent", "mobile_cashier_android");
Client.DefaultRequestHeaders.Add("Accept", "application/jwt");
Client.DefaultRequestHeaders.Add("X-Request-Signature", Jws);
Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + TophToken);

try
{
    var R = Client.PostAsync("https://mob-gcash.t2ph.psr-it.com/api/mt/activations", new StringContent(ActivationReq, Encoding.UTF8, "application/json")).Result;
    var Body = R.Content.ReadAsStringAsync().Result;
    Console.WriteLine($"Status: {(int)R.StatusCode}");
    Console.WriteLine($"Body: {(Body.Length > 1000 ? Body[..1000] : Body)}");
    foreach (var H in R.Headers)
        Console.WriteLine($"  {H.Key}: {string.Join(", ", H.Value)}");
    foreach (var H in R.Content.Headers)
        Console.WriteLine($"  Content-{H.Key}: {string.Join(", ", H.Value)}");
}
catch (Exception Ex) { Console.WriteLine($"Error: {(Ex.InnerException?.Message ?? Ex.Message)}"); }
