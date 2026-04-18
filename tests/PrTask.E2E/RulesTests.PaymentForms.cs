using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Settings: has credit card and bank account form fields")]
    public async Task SettingsHasPaymentFormsAsync()
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
            Html.Contains("PaymentMethod") || Html.Contains("Credit") || Html.Contains("card", StringComparison.OrdinalIgnoreCase),
            "Settings must have credit card payment field");
        Assert.IsTrue(
            Html.Contains("PayoutMethod") || Html.Contains("Bank") || Html.Contains("withdrawal", StringComparison.OrdinalIgnoreCase),
            "Settings must have bank/withdrawal field");
    }
}
