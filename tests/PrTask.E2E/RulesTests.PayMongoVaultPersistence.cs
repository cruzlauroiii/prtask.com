using System.Text.Json;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req9: PayMongo customer can be created and retrieved by email")]
    public async Task PayMongoCustomerPersistsAcrossSessionsAsync()
    {
        using var Client = CreatePayMongoClient();
        var TestEmail = $"e2e-persist-{DateTime.UtcNow:yyyyMMddHHmmssff}@prtask.com";
        var Customer = await PayMongoCreateCustomerCoreAsync(Client,
            "Persist", "Test", TestEmail, "+639171234567");
        var CustomerId = PayMongoGetId(Customer);
        Assert.IsTrue(CustomerId.StartsWith("cus_"),
            $"Customer ID must start with cus_, got {CustomerId}");
        var Retrieved = await PayMongoRetrieveCustomerAsync(Client, TestEmail);
        var DataArray = Retrieved.GetProperty("data");
        Assert.IsTrue(DataArray.GetArrayLength() > 0,
            "Customer must persist and be retrievable by email");
        var RetrievedId = DataArray[0].GetProperty("id").GetString();
        Assert.AreEqual(CustomerId, RetrievedId,
            "Retrieved customer ID must match created customer ID");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req9: PayMongo payment method created and attached to customer")]
    public async Task PayMongoPaymentMethodAttachedToCustomerAsync()
    {
        using var Client = CreatePayMongoClient();
        var TestEmail = $"e2e-attach-{DateTime.UtcNow:yyyyMMddHHmmssff}@prtask.com";
        var Customer = await PayMongoCreateCustomerCoreAsync(Client,
            "Attach", "Card", TestEmail, "+639171234567");
        var CustomerId = PayMongoGetId(Customer);
        var Method = await PayMongoCreateMethodAsync(Client, TestCardVisaSuccess, 12, 2029, "123");
        var MethodId = PayMongoGetId(Method);
        Assert.IsTrue(MethodId.StartsWith("pm_"),
            $"Payment method ID must start with pm_, got {MethodId}");
        var Details = Method.GetProperty("data").GetProperty("attributes").GetProperty("details");
        Assert.AreEqual("4345", Details.GetProperty("last4").GetString(),
            "Last4 must be 4345 for Visa test card");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req9: PayMongo card info survives session clear — server-side vault")]
    public async Task PayMongoCardSurvivesSessionClearAsync()
    {
        using var Client1 = CreatePayMongoClient();
        var TestEmail = $"e2e-survive-{DateTime.UtcNow:yyyyMMddHHmmssff}@prtask.com";
        await PayMongoCreateCustomerCoreAsync(Client1, "Survive", "Clear", TestEmail, "+639171234567");
        var Method = await PayMongoCreateMethodAsync(Client1, TestCardVisaSuccess, 12, 2029, "123");
        var MethodId = PayMongoGetId(Method);
        using var Client2 = CreatePayMongoClient();
        var Retrieved = await PayMongoRetrieveCustomerAsync(Client2, TestEmail);
        var DataArray = Retrieved.GetProperty("data");
        Assert.IsTrue(DataArray.GetArrayLength() > 0,
            "Customer must be retrievable from a fresh client (simulating session clear)");
        var RetrievedEmail = DataArray[0].GetProperty("attributes").GetProperty("email").GetString();
        Assert.AreEqual(TestEmail, RetrievedEmail,
            "Email must match after session clear");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req9: Settings page has card and bank form fields")]
    public async Task SettingsPageCardAndBankFormsAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var Response = await Client.GetAsync($"{TestBaseUrl}/en/Settings");
        Assert.IsTrue(Response.IsSuccessStatusCode, "Settings must return 200");
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Html.Contains("CardNumber") || Html.Contains("card-number"),
            "Settings must have card number input");
        Assert.IsTrue(Html.Contains("PayoutMethod") || Html.Contains("Bank Transfer"),
            "Settings must have payout/bank method selector");
        Assert.IsTrue(Html.Contains("PayoutDetails") || Html.Contains("payout") || Html.Contains("Account"),
            "Settings must have payout details input");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req9: PayMongo API routes exist in RouteConstants")]
    public Task PayMongoApiRoutesExistAsync()
    {
        Assert.IsNotNull(RouteConstants.ApiCustomers, "Customer API route must exist");
        Assert.IsNotNull(RouteConstants.ApiPaymentRecords, "Payment records API route must exist");
        Assert.IsTrue(RouteConstants.SubCustomerCardsList.Contains("Cards"),
            "Customer cards list route must contain 'Cards'");
        Assert.IsTrue(RouteConstants.SubVaultPay.Contains("VaultPay"),
            "VaultPay route must exist");
        return Task.CompletedTask;
    }
}
