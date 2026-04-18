using System.Net.Http;
using System.Text;
var Jwt = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDY2MDAyMywicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.RfaniJFxmY0hhcoU-pGOz2OkfdAemAVFLLSbCTUptuAWDpnhABoBa0aDfFgTU5KVbJBk2Jck23nYtZoiQD_D-w";
var Client = new HttpClient();
Client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Jwt);
Client.DefaultRequestHeaders.Add("x-merchant-api-key", "75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5");
Client.DefaultRequestHeaders.Add("AndroidId", "e14ceab085867eab");
var Body = "{\"userId\":\"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94\",\"deviceUuid\":\"a29e8f74-e57b-46cf-80a9-a5dff92f49a2\",\"mid\":\"177397344332991\",\"tid\":\"SFT07056\"}";
var Paths = new[] { "/api/v2/device/auth", "/api/v2/device/register", "/api/v2/device/activate", "/api/v2/device/init", "/api/v2/device/login", "/api/v2/device/connect", "/api/v2/device/authDevice" };
foreach (var P in Paths) {
    var R = Client.PostAsync("https://mobilecashier.ru" + P, new StringContent(Body, Encoding.UTF8, "application/json")).Result;
    var C = R.Content.ReadAsStringAsync().Result;
    if (C.Length > 200) C = C.Substring(0, 200);
    Console.WriteLine(P + ": " + (int)R.StatusCode + " " + C);
}
