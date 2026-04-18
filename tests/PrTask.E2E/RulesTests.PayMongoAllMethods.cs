using System.Net.Http.Headers;
using System.Text.Json;

namespace PrTask.E2E;

public partial class RulesTests
{
    private static readonly string[] PayMongoMethodTypes =
    [
        "card", "gcash", "grab_pay", "paymaya", "qrph"
    ];

    private static readonly string[] GcashMethodAllowed = ["gcash"];

    private static readonly string[] GcashMethodAllowed = ["gcash"];

    private static readonly string[] GcashMethodAllowed = ["gcash"];

    private static async Task<(int StatusCode, string Body)> PayMongoCreateMethodRawAsync(
        HttpClient Client, string MethodType)
    {
        var Body = JsonSerializer.Serialize(new
        {
            data = new
            {
                attributes = new
                {
                    type = MethodType,
                    billing = new
                    {
                        name = "E2E Test",
                        email = "e2e@prtask.com",
                        phone = "+639171234567"
                    }
                }
            }
        });
        var Response = await Client.PostAsync("/v1/payment_methods",
            new StringContent(Body, Encoding.UTF8, "application/json"));
        var ResponseBody = await Response.Content.ReadAsStringAsync();
        return ((int)Response.StatusCode, ResponseBody);
    }

    private static async Task<(int StatusCode, string Body)> PayMongoCreateCardMethodRawAsync(HttpClient Client)
    {
        var Body = JsonSerializer.Serialize(new
        {
            data = new
            {
                attributes = new
                {
                    type = "card",
                    details = new
                    {
                        card_number = TestCardVisaSuccess,
                        exp_month = 12,
                        exp_year = 2029,
                        cvc = "123"
                    },
                    billing = new
                    {
                        name = "E2E Card Test",
                        email = "e2e-card@prtask.com",
                        phone = "+639171234567"
                    }
                }
            }
        });
        var Response = await Client.PostAsync("/v1/payment_methods",
            new StringContent(Body, Encoding.UTF8, "application/json"));
        var ResponseBody = await Response.Content.ReadAsStringAsync();
        return ((int)Response.StatusCode, ResponseBody);
    }

    [TestMethod]
    [DisplayName("PayMongo: create card payment method")]
    public async Task PayMongoCreateCardMethodTestAsync()
    {
        using var Client = CreatePayMongoClient();
        var (StatusCode, Body) = await PayMongoCreateCardMethodRawAsync(Client);
        Assert.AreEqual(200, StatusCode, $"Card method must return 200, got {StatusCode}: {Body}");

        var Parsed = JsonElement.Parse(Body);
        var MethodType = Parsed.GetProperty("data").GetProperty("attributes").GetProperty("type").GetString();
        Assert.AreEqual("card", MethodType);
    }

    [TestMethod]
    [DisplayName("PayMongo: create GCash payment method")]
    public async Task PayMongoCreateGcashMethodAsync()
    {
        using var Client = CreatePayMongoClient();
        var (StatusCode, Body) = await PayMongoCreateMethodRawAsync(Client, "gcash");
        Assert.AreEqual(200, StatusCode, $"GCash method must return 200, got {StatusCode}: {Body}");

        var Parsed = JsonElement.Parse(Body);
        var Id = Parsed.GetProperty("data").GetProperty("id").GetString()!;
        Assert.IsTrue(Id.StartsWith("pm_"), $"GCash method ID must start with pm_, got {Id}");
    }

    [TestMethod]
    [DisplayName("PayMongo: create GrabPay payment method")]
    public async Task PayMongoCreateGrabPayMethodAsync()
    {
        using var Client = CreatePayMongoClient();
        var (StatusCode, Body) = await PayMongoCreateMethodRawAsync(Client, "grab_pay");
        Assert.AreEqual(200, StatusCode, $"GrabPay method must return 200, got {StatusCode}: {Body}");

        var Parsed = JsonElement.Parse(Body);
        var Id = Parsed.GetProperty("data").GetProperty("id").GetString()!;
        Assert.IsTrue(Id.StartsWith("pm_"), $"GrabPay method ID must start with pm_, got {Id}");
    }

    [TestMethod]
    [DisplayName("PayMongo: create Maya payment method")]
    public async Task PayMongoCreateMayaMethodAsync()
    {
        using var Client = CreatePayMongoClient();
        var (StatusCode, Body) = await PayMongoCreateMethodRawAsync(Client, "paymaya");
        Assert.AreEqual(200, StatusCode, $"Maya method must return 200, got {StatusCode}: {Body}");

        var Parsed = JsonElement.Parse(Body);
        var Id = Parsed.GetProperty("data").GetProperty("id").GetString()!;
        Assert.IsTrue(Id.StartsWith("pm_"), $"Maya method ID must start with pm_, got {Id}");
    }

    [TestMethod]
    [DisplayName("PayMongo: create QRPh payment method")]
    public async Task PayMongoCreateQrPhMethodAsync()
    {
        using var Client = CreatePayMongoClient();
        var (StatusCode, Body) = await PayMongoCreateMethodRawAsync(Client, "qrph");
        Assert.AreEqual(200, StatusCode, $"QRPh method must return 200, got {StatusCode}: {Body}");

        var Parsed = JsonElement.Parse(Body);
        var Id = Parsed.GetProperty("data").GetProperty("id").GetString()!;
        Assert.IsTrue(Id.StartsWith("pm_"), $"QRPh method ID must start with pm_, got {Id}");
    }

    [TestMethod]
    [DisplayName("PayMongo: create ShopeePay payment method")]
    public async Task PayMongoCreateShopeePayMethodAsync()
    {
        using var Client = CreatePayMongoClient();
        var (StatusCode, Body) = await PayMongoCreateMethodRawAsync(Client, "shopee_pay");

        Assert.IsTrue(StatusCode is 200 or 400,
            $"ShopeePay method must return 200 or 400 (if not enabled), got {StatusCode}");
    }

    [TestMethod]
    [DisplayName("PayMongo: full card payment intent flow (create-attach-succeed)")]
    public async Task PayMongoFullCardIntentFlowAsync()
    {
        using var Client = CreatePayMongoClient();

        var Intent = await PayMongoCreateIntentAsync(Client, 10000, "E2E full card flow");
        var IntentId = PayMongoGetId(Intent);
        var ClientKey = PayMongoGetClientKey(Intent);
        Assert.AreEqual("awaiting_payment_method", PayMongoGetStatus(Intent));

        var Method = await PayMongoCreateMethodAsync(Client, TestCardVisaSuccess, 12, 2029, "123");
        var MethodId = PayMongoGetId(Method);

        var (Attached, StatusCode) = await PayMongoAttachAsync(Client, IntentId, MethodId, ClientKey);
        Assert.AreEqual(200, StatusCode);
        Assert.AreEqual("succeeded", PayMongoGetStatus(Attached));

        var Retrieved = await PayMongoRetrieveIntentAsync(Client, IntentId);
        Assert.AreEqual("succeeded", PayMongoGetStatus(Retrieved));
    }

    [TestMethod]
    [DisplayName("PayMongo: GCash payment intent triggers redirect")]
    public async Task PayMongoGcashIntentRedirectAsync()
    {
        using var Client = CreatePayMongoClient();

        var IntentBody = JsonSerializer.Serialize(new
        {
            data = new
            {
                attributes = new
                {
                    amount = 10000,
                    currency = "PHP",
                    payment_method_allowed = GcashMethodAllowed,
                    description = "E2E GCash flow"
                }
            }
        });
        var IntentResponse = await Client.PostAsync("/v1/payment_intents",
            new StringContent(IntentBody, Encoding.UTF8, "application/json"));
        var IntentResponseBody = await IntentResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(IntentResponse.IsSuccessStatusCode,
            $"GCash intent must return 2xx, got {(int)IntentResponse.StatusCode}: {IntentResponseBody}");

        var Intent = JsonElement.Parse(IntentResponseBody);
        var IntentId = PayMongoGetId(Intent);
        var ClientKey = PayMongoGetClientKey(Intent);

        var (_, MethodBody) = await PayMongoCreateMethodRawAsync(Client, "gcash");
        var MethodParsed = JsonElement.Parse(MethodBody);
        var MethodId = MethodParsed.GetProperty("data").GetProperty("id").GetString()!;

        var Attributes = new Dictionary<string, object>
        {
            ["payment_method"] = MethodId,
            ["client_key"] = ClientKey,
            ["return_url"] = "https://prtask.com/en/Settings"
        };
        var AttachBody = JsonSerializer.Serialize(new { data = new { attributes = Attributes } });
        var AttachResponse = await Client.PostAsync($"/v1/payment_intents/{IntentId}/attach",
            new StringContent(AttachBody, Encoding.UTF8, "application/json"));
        var AttachResponseBody = await AttachResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(AttachResponse.IsSuccessStatusCode,
            $"GCash attach must return 2xx, got {(int)AttachResponse.StatusCode}: {AttachResponseBody}");

        var Attached = JsonElement.Parse(AttachResponseBody);
        var Status = PayMongoGetStatus(Attached);
        Assert.AreEqual("awaiting_next_action", Status, $"GCash must need redirect, got {Status}");

        var NextAction = Attached.GetProperty("data").GetProperty("attributes").GetProperty("next_action");
        Assert.IsTrue(NextAction.ValueKind != JsonValueKind.Null, "GCash next_action must not be null");
    }

    [TestMethod]
    [DisplayName("PrTask.com Settings: payment method selects exist")]
    public async Task PrtaskComSettingsPaymentSelectsAsync()
    {
        await BrowserPage.NavigateAsync("https://prtask.com/en/Settings");

        await Task.Delay(500);

        var PayoutSelectCount = await CdpHelpers.CountAsync(BrowserPage, "#PayoutMethod");
        Assert.IsTrue(PayoutSelectCount > 0, "PayoutMethod select must exist");

        var PaymentSelectCount = await CdpHelpers.CountAsync(BrowserPage, "#PaymentMethod");
        Assert.IsTrue(PaymentSelectCount > 0, "PaymentMethod select must exist");

        var QrSelectCount = await CdpHelpers.CountAsync(BrowserPage, "#QrPaymentSetting");
        Assert.IsTrue(QrSelectCount > 0, "QrPaymentSetting select must exist");

        await TakeScreenshotAsync("settings-payment-selects.png");
    }

    [TestMethod]
    [DisplayName("PrTask.com Settings: no crypto option in payout method")]
    public async Task PrtaskComSettingsNoCryptoAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(15) };

        var GhResponse = await Client.GetAsync("https://cruzlauroiii.github.io/prtask.com/en/Settings.html");
        Assert.IsTrue(GhResponse.IsSuccessStatusCode, $"Settings.html must return 2xx, got {(int)GhResponse.StatusCode}");
        var GhHtml = await GhResponse.Content.ReadAsStringAsync();
        Assert.IsFalse(GhHtml.Contains("value=\"crypto\"", StringComparison.OrdinalIgnoreCase),
            "Settings.html must NOT have crypto payout option");
        Assert.IsFalse(GhHtml.Contains("Cryptocurrency", StringComparison.Ordinal),
            "Settings.html must NOT contain Cryptocurrency label");

        var PrtaskResponse = await Client.GetAsync("https://prtask.com/en/Settings.html");
        Assert.IsTrue(PrtaskResponse.IsSuccessStatusCode, "prtask.com Settings.html must return 2xx");
        var PrtaskHtml = await PrtaskResponse.Content.ReadAsStringAsync();
        Assert.IsFalse(PrtaskHtml.Contains("value=\"crypto\"", StringComparison.OrdinalIgnoreCase),
            "prtask.com Settings.html must NOT have crypto payout option");
    }
}
