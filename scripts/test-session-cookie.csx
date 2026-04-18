using System.Net;
using System.Net.Http;
using System.Text;

var Jwt = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDY2MDAyMywicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.RfaniJFxmY0hhcoU-pGOz2OkfdAemAVFLLSbCTUptuAWDpnhABoBa0aDfFgTU5KVbJBk2Jck23nYtZoiQD_D-w";

var Handler = new HttpClientHandler { CookieContainer = new CookieContainer(), UseCookies = true };
var Client = new HttpClient(Handler);
Client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Jwt);
Client.DefaultRequestHeaders.Add("AndroidId", "e14ceab085867eab");

Console.WriteLine("=== Step 1: status/toph ===");
var AuthBody = "{\"user_id\":\"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94\",\"device_uuid\":\"a29e8f74-e57b-46cf-80a9-a5dff92f49a2\",\"mid\":\"177397344332991\",\"tid\":\"SFT07056\"}";
var R1 = Client.PostAsync("https://mobilecashier.ru/api/v2/device/status/toph", new StringContent(AuthBody, Encoding.UTF8, "application/json")).Result;
Console.WriteLine("Status: " + (int)R1.StatusCode);
Console.WriteLine("Body: '" + R1.Content.ReadAsStringAsync().Result + "'");
foreach (var H in R1.Headers)
    Console.WriteLine("  " + H.Key + ": " + string.Join(", ", H.Value));

var Cookies = Handler.CookieContainer.GetCookies(new Uri("https://mobilecashier.ru"));
Console.WriteLine("Cookies: " + Cookies.Count);
foreach (Cookie C in Cookies)
    Console.WriteLine("  " + C.Name + "=" + C.Value);

Console.WriteLine("\n=== Step 2: order/toph (same session) ===");
var OrderBody = "{\"user_id\":\"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94\",\"phone\":\"639568564236\",\"fio\":\"\",\"inn\":\"\",\"region_id\":0}";
var R2 = Client.PostAsync("https://mobilecashier.ru/api/v3/market/order/toph", new StringContent(OrderBody, Encoding.UTF8, "application/json")).Result;
Console.WriteLine("Status: " + (int)R2.StatusCode);
var Body2 = R2.Content.ReadAsStringAsync().Result;
if (Body2.Length > 500) Body2 = Body2.Substring(0, 500);
Console.WriteLine("Body: '" + Body2 + "'");
foreach (var H in R2.Headers)
    Console.WriteLine("  " + H.Key + ": " + string.Join(", ", H.Value));
