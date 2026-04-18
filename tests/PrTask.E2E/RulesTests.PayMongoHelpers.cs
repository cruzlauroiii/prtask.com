using System.Net.Http.Headers;
using System.Text.Json;

namespace PrTask.E2E;

public partial class RulesTests
{
    private const string PayMongoTestSecretKey = "sk_test_gzxmocVUvpoGh4ej3kMYaPMX";
    private const string PayMongoApiBase = "https://api.paymongo.com/v1";
    private const string TestCardVisaSuccess = "4343434343434345";
    private const string TestCardMastercardSuccess = "5555444444444457";
    private const string TestCard3DsAuthSuccess = "4120000000000007";
    private const string TestCardExpired = "4200000000000018";
    private const string TestCardInsufficientFunds = "5100000000000198";
    private static readonly string[] CardMethodAllowed = ["card"];

    private static HttpClient CreatePayMongoClient()
    {
        var Client = new HttpClient { BaseAddress = new Uri(PayMongoApiBase), Timeout = TimeSpan.FromSeconds(30) };
        var Credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{PayMongoTestSecretKey}:"));
        Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Credentials);
        Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        return Client;
    }

    private static async Task<JsonElement> PayMongoCreateIntentAsync(HttpClient Client, int AmountCentavos, string Description)
    {
        var Body = JsonSerializer.Serialize(new
        {
            data = new
            {
                attributes = new
                {
                    amount = AmountCentavos,
                    currency = "PHP",
                    payment_method_allowed = CardMethodAllowed,
                    description = Description,
                    statement_descriptor = "PrTask",
                    payment_method_options = new { card = new { request_three_d_secure = "any" } }
                }
            }
        });
        var Response = await Client.PostAsync("/v1/payment_intents",
            new StringContent(Body, Encoding.UTF8, "application/json"));
        var ResponseBody = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Response.IsSuccessStatusCode,
            $"CreatePaymentIntent must return 2xx, got {(int)Response.StatusCode}: {ResponseBody}");
        return JsonElement.Parse(ResponseBody);
    }

    private static async Task<JsonElement> PayMongoCreateMethodAsync(HttpClient Client, string CardNumber,
        int ExpMonth, int ExpYear, string Cvc)
    {
        var Body = JsonSerializer.Serialize(new
        {
            data = new
            {
                attributes = new
                {
                    type = "card",
                    details = new { card_number = CardNumber, exp_month = ExpMonth, exp_year = ExpYear, cvc = Cvc },
                    billing = new { name = "E2E Test User", email = "e2e@prtask.com", phone = "+639171234567" }
                }
            }
        });
        var Response = await Client.PostAsync("/v1/payment_methods",
            new StringContent(Body, Encoding.UTF8, "application/json"));
        var ResponseBody = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Response.IsSuccessStatusCode,
            $"CreatePaymentMethod must return 2xx, got {(int)Response.StatusCode}: {ResponseBody}");
        return JsonElement.Parse(ResponseBody);
    }

    private static async Task<(JsonElement Json, int StatusCode)> PayMongoAttachAsync(HttpClient Client,
        string IntentId, string MethodId, string? ClientKey = null, string? ReturnUrl = null)
    {
        var Attributes = new Dictionary<string, object> { ["payment_method"] = MethodId };
        if (ClientKey is not null)
        {
            Attributes["client_key"] = ClientKey;
        }
        if (ReturnUrl is not null)
        {
            Attributes["return_url"] = ReturnUrl;
        }
        var Body = JsonSerializer.Serialize(new { data = new { attributes = Attributes } });
        var Response = await Client.PostAsync($"/v1/payment_intents/{IntentId}/attach",
            new StringContent(Body, Encoding.UTF8, "application/json"));
        var ResponseBody = await Response.Content.ReadAsStringAsync();
        return (JsonElement.Parse(ResponseBody), (int)Response.StatusCode);
    }

    private static async Task<JsonElement> PayMongoRetrieveIntentAsync(HttpClient Client, string IntentId)
    {
        var Response = await Client.GetAsync($"/v1/payment_intents/{IntentId}");
        var ResponseBody = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Response.IsSuccessStatusCode,
            $"RetrievePaymentIntent must return 2xx, got {(int)Response.StatusCode}: {ResponseBody}");
        return JsonElement.Parse(ResponseBody);
    }

    private static string PayMongoGetId(JsonElement Root) =>
        Root.GetProperty("data").GetProperty("id").GetString()!;

    private static string PayMongoGetStatus(JsonElement Root) =>
        Root.GetProperty("data").GetProperty("attributes").GetProperty("status").GetString()!;

    private static string PayMongoGetClientKey(JsonElement Root) =>
        Root.GetProperty("data").GetProperty("attributes").GetProperty("client_key").GetString()!;
}
