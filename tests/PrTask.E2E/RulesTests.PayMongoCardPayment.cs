using System.Text.Json;

namespace PrTask.E2E;

public partial class RulesTests
{
    [TestMethod]
    [DisplayName("PayMongo: Visa card payment succeeds (non-3DS)")]
    public async Task PayMongoVisaCardSucceedsAsync()
    {
        using var Client = CreatePayMongoClient();
        var Intent = await PayMongoCreateIntentAsync(Client, 10000, "E2E Visa success");
        var IntentId = PayMongoGetId(Intent);
        var ClientKey = PayMongoGetClientKey(Intent);
        Assert.AreEqual("awaiting_payment_method", PayMongoGetStatus(Intent));
        Assert.IsTrue(IntentId.StartsWith("pi_"), $"ID must start with pi_, got {IntentId}");

        var Method = await PayMongoCreateMethodAsync(Client, TestCardVisaSuccess, 12, 2029, "123");
        var MethodId = PayMongoGetId(Method);
        Assert.IsTrue(MethodId.StartsWith("pm_"), $"ID must start with pm_, got {MethodId}");

        var (Attached, StatusCode) = await PayMongoAttachAsync(Client, IntentId, MethodId, ClientKey);
        Assert.AreEqual(200, StatusCode, $"Attach must return 200, got {StatusCode}");
        Assert.AreEqual("succeeded", PayMongoGetStatus(Attached), "Visa non-3DS must succeed");

        var Retrieved = await PayMongoRetrieveIntentAsync(Client, IntentId);
        Assert.AreEqual("succeeded", PayMongoGetStatus(Retrieved));
        Assert.AreEqual(10000, Retrieved.GetProperty("data").GetProperty("attributes").GetProperty("amount").GetInt32());
    }

    [TestMethod]
    [DisplayName("PayMongo: Mastercard payment succeeds (non-3DS)")]
    public async Task PayMongoMastercardSucceedsAsync()
    {
        using var Client = CreatePayMongoClient();
        var Intent = await PayMongoCreateIntentAsync(Client, 5000, "E2E MC success");
        var IntentId = PayMongoGetId(Intent);
        var ClientKey = PayMongoGetClientKey(Intent);

        var Method = await PayMongoCreateMethodAsync(Client, TestCardMastercardSuccess, 6, 2028, "456");
        var (Attached, StatusCode) = await PayMongoAttachAsync(Client, IntentId, PayMongoGetId(Method), ClientKey);
        Assert.AreEqual(200, StatusCode, $"Attach must return 200, got {StatusCode}");
        Assert.AreEqual("succeeded", PayMongoGetStatus(Attached), "Mastercard non-3DS must succeed");
    }

    [TestMethod]
    [DisplayName("PayMongo: 3DS card triggers awaiting_next_action with redirect")]
    public async Task PayMongo3DsTriggersRedirectAsync()
    {
        using var Client = CreatePayMongoClient();
        var Intent = await PayMongoCreateIntentAsync(Client, 20000, "E2E 3DS flow");
        var IntentId = PayMongoGetId(Intent);
        var ClientKey = PayMongoGetClientKey(Intent);

        var Method = await PayMongoCreateMethodAsync(Client, TestCard3DsAuthSuccess, 12, 2029, "123");
        var (Attached, StatusCode) = await PayMongoAttachAsync(Client, IntentId, PayMongoGetId(Method), ClientKey,
            "https://prtask.com/en/Settings");
        Assert.AreEqual(200, StatusCode, $"3DS attach must return 200, got {StatusCode}");
        Assert.AreEqual("awaiting_next_action", PayMongoGetStatus(Attached), "3DS card must require next action");

        var NextAction = Attached.GetProperty("data").GetProperty("attributes").GetProperty("next_action");
        Assert.IsTrue(NextAction.ValueKind != JsonValueKind.Null, "next_action must not be null");
        var RedirectUrl = NextAction.GetProperty("redirect").GetProperty("url").GetString()!;
        Assert.IsFalse(string.IsNullOrWhiteSpace(RedirectUrl), "3DS redirect URL must not be empty");
        Assert.IsTrue(RedirectUrl.StartsWith("https://"), $"Redirect must be HTTPS, got {RedirectUrl}");
    }

    [TestMethod]
    [DisplayName("PayMongo: 3DS authorize via CDP")]
    public async Task PayMongo3DsCdpAuthorizeAsync()
    {
        using var Client = CreatePayMongoClient();
        var Intent = await PayMongoCreateIntentAsync(Client, 20000, "E2E 3DS CDP");
        var IntentId = PayMongoGetId(Intent);
        var ClientKey = PayMongoGetClientKey(Intent);

        var Method = await PayMongoCreateMethodAsync(Client, TestCard3DsAuthSuccess, 12, 2029, "123");
        var (Attached, _) = await PayMongoAttachAsync(Client, IntentId, PayMongoGetId(Method), ClientKey,
            "https://prtask.com/en/Settings");
        var RedirectUrl = Attached.GetProperty("data").GetProperty("attributes")
            .GetProperty("next_action").GetProperty("redirect").GetProperty("url").GetString()!;

        await BrowserPage.NavigateAsync(RedirectUrl);

        await Task.Delay(500);

        var AuthButtonCount = await CdpHelpers.CountAsync(BrowserPage, "[data-test='authorize-btn'], button.authorize, button[type='submit']");
        if (AuthButtonCount > 0 && await CdpHelpers.IsVisibleAsync(BrowserPage, "[data-test='authorize-btn'], button.authorize, button[type='submit']"))
        {
            await CdpHelpers.ClickSelectorAsync(BrowserPage, "[data-test='authorize-btn'], button.authorize, button[type='submit']");
            await Task.Delay(500);
        }

        const int MaxRetries = 15;
        var FinalStatus = "awaiting_next_action";
        for (var I = 0; I < MaxRetries; I++)
        {
            await Task.Delay(2000);
            var Retrieved = await PayMongoRetrieveIntentAsync(Client, IntentId);
            FinalStatus = PayMongoGetStatus(Retrieved);
            if (FinalStatus is "succeeded" or "processing")
            {
                break;
            }
        }
        Assert.IsTrue(FinalStatus is "succeeded" or "processing",
            $"3DS payment must succeed or be processing after auth, got {FinalStatus}");
        await TakeScreenshotAsync("paymongo-3ds-complete.png");
    }

    [TestMethod]
    [DisplayName("PayMongo: expired card returns error")]
    public async Task PayMongoExpiredCardErrorAsync()
    {
        using var Client = CreatePayMongoClient();
        var Intent = await PayMongoCreateIntentAsync(Client, 5000, "E2E expired card");
        var IntentId = PayMongoGetId(Intent);
        var ClientKey = PayMongoGetClientKey(Intent);

        var Method = await PayMongoCreateMethodAsync(Client, TestCardExpired, 12, 2029, "123");
        var (ErrorJson, StatusCode) = await PayMongoAttachAsync(Client, IntentId, PayMongoGetId(Method), ClientKey);

        Assert.AreEqual(400, StatusCode, $"Expired card must return 400, got {StatusCode}");
        var Errors = ErrorJson.GetProperty("errors");
        Assert.IsTrue(Errors.GetArrayLength() > 0, "Error response must have errors array");
        var SubCode = Errors[0].GetProperty("sub_code").GetString();
        Assert.AreEqual("card_expired", SubCode, $"Decline sub_code must be card_expired, got {SubCode}");
    }

    [TestMethod]
    [DisplayName("PayMongo: insufficient funds returns error")]
    public async Task PayMongoInsufficientFundsErrorAsync()
    {
        using var Client = CreatePayMongoClient();
        var Intent = await PayMongoCreateIntentAsync(Client, 5000, "E2E insufficient funds");
        var IntentId = PayMongoGetId(Intent);
        var ClientKey = PayMongoGetClientKey(Intent);

        var Method = await PayMongoCreateMethodAsync(Client, TestCardInsufficientFunds, 12, 2029, "123");
        var (ErrorJson, StatusCode) = await PayMongoAttachAsync(Client, IntentId, PayMongoGetId(Method), ClientKey);

        Assert.AreEqual(400, StatusCode, $"NSF card must return 400, got {StatusCode}");
        var Errors = ErrorJson.GetProperty("errors");
        Assert.IsTrue(Errors.GetArrayLength() > 0, "Error response must have errors array");
        var SubCode = Errors[0].GetProperty("sub_code").GetString();
        Assert.AreEqual("insufficient_funds", SubCode, $"Decline sub_code must be insufficient_funds, got {SubCode}");
    }

    [TestMethod]
    [DisplayName("PayMongo: retrieve intent returns correct data")]
    public async Task PayMongoRetrieveCorrectDataAsync()
    {
        using var Client = CreatePayMongoClient();
        var Intent = await PayMongoCreateIntentAsync(Client, 7500, "E2E retrieve verify");
        var IntentId = PayMongoGetId(Intent);

        var Retrieved = await PayMongoRetrieveIntentAsync(Client, IntentId);
        var Attrs = Retrieved.GetProperty("data").GetProperty("attributes");
        Assert.AreEqual(7500, Attrs.GetProperty("amount").GetInt32());
        Assert.AreEqual("PHP", Attrs.GetProperty("currency").GetString());
        Assert.AreEqual("awaiting_payment_method", Attrs.GetProperty("status").GetString());
        Assert.IsFalse(Attrs.GetProperty("livemode").GetBoolean(), "Must be test mode");
    }
}
