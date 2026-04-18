using System.Net.Http;
using System.Text;

var Jwt = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDY2MDAyMywicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.RfaniJFxmY0hhcoU-pGOz2OkfdAemAVFLLSbCTUptuAWDpnhABoBa0aDfFgTU5KVbJBk2Jck23nYtZoiQD_D-w";

var Variations = new[]
{
    ("Bearer " + Jwt, "Bearer JWT"),
    (Jwt, "Raw JWT"),
    ("Token " + Jwt, "Token JWT"),
};

foreach (var (AuthValue, Label) in Variations)
{
    var Client = new HttpClient();
    Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", AuthValue);
    Client.DefaultRequestHeaders.Add("AndroidId", "e14ceab085867eab");

    var Body = "{\"user_id\":\"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94\",\"phone\":\"639568564236\",\"fio\":\"\",\"inn\":\"\",\"region_id\":0}";
    var R = Client.PostAsync("https://mobilecashier.ru/api/v3/market/order/toph", new StringContent(Body, Encoding.UTF8, "application/json")).Result;
    var Content = R.Content.ReadAsStringAsync().Result;
    if (Content.Length > 300) Content = Content.Substring(0, 300);
    Console.WriteLine(Label + ": " + (int)R.StatusCode + " " + Content);
}
