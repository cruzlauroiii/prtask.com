using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Config: JavaScriptEnabled is false by default")]
    public Task JavaScriptDisabledByDefaultAsync()
    {
#pragma warning disable MSTEST0032
        Assert.IsFalse(AppConstants.JavaScriptEnabled,
            "JavaScriptEnabled must be false by default");
#pragma warning restore MSTEST0032
        return Task.CompletedTask;
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Config: ServiceWorkerEnabled is false by default")]
    public Task ServiceWorkerDisabledByDefaultAsync()
    {
#pragma warning disable MSTEST0032
        Assert.IsFalse(AppConstants.ServiceWorkerEnabled,
            "ServiceWorkerEnabled must be false by default");
#pragma warning restore MSTEST0032
        return Task.CompletedTask;
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Static HTML: no script tags when JS disabled")]
    public async Task NoScriptTagsWhenJsDisabledAsync()
    {
#pragma warning disable CS0162
        if (AppConstants.JavaScriptEnabled)
        {
            return;
        }
#pragma warning restore CS0162

#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var Response = await Client.GetAsync($"{TestBaseUrl}/en/About");
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsFalse(Html.Contains("<script "),
            "When JavaScriptEnabled=false, static HTML must have no script tags");
        Assert.IsFalse(Html.Contains("blazor.webassembly"),
            "When JavaScriptEnabled=false, no Blazor WASM references");
    }
}
