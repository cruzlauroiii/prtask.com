using System.Net;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient CreateTestHttpClient(string BaseUrl)
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        return new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
    }

    private static async Task<HttpClient> CreateAuthenticatedTestClientAsync(string BaseUrl, string SubjectId, string Name)
    {
        var Client = CreateTestHttpClient(BaseUrl);
        await DevLoginHelperAsync(Client, SubjectId, Name);
        return Client;
    }
}
