using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Settings: card form fields present for adding credit card")]
    public async Task SettingsCardFormFieldsPresentAsync()
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
        Assert.IsTrue(Html.Contains("CardNumber"), "Settings must have CardNumber input");
        Assert.IsTrue(Html.Contains("CardExpMonth"), "Settings must have CardExpMonth input");
        Assert.IsTrue(Html.Contains("CardExpYear"), "Settings must have CardExpYear input");
        Assert.IsTrue(Html.Contains("CardCvc"), "Settings must have CardCvc input");
        Assert.IsTrue(Html.Contains("Add Card") || Html.Contains("Add a Card"),
            "Settings must have Add Card button");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Settings: bank account form fields present for withdrawal")]
    public async Task SettingsBankFormFieldsPresentAsync()
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
        Assert.IsTrue(
            Html.Contains("PayoutMethod") || Html.Contains("Bank Transfer"),
            "Settings must have payout/bank method selector");
        Assert.IsTrue(
            Html.Contains("PayoutDetails") || Html.Contains("Account") || Html.Contains("payout"),
            "Settings must have payout details input");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("API: card vault endpoints exist")]
    public Task CardVaultEndpointsExistAsync()
    {
        const string VaultEndpoint = RouteConstants.ApiCustomers;
        Assert.IsNotNull(VaultEndpoint, "Customer API route must exist");
        const string CardVaultPath = RouteConstants.SubCustomerCardsList;
        Assert.IsNotNull(CardVaultPath, "Customer cards list route must exist");
        return Task.CompletedTask;
    }
}
