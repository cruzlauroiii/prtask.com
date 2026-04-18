using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PlainTextDb CRUD — write, read, delete, verify 404")]
    public async Task PlainTextDbCrudAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler)
            { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        await DevLoginHelperAsync(Http, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
        var ItemPath = $"{RouteConstants.ApiPlainTextDb}/{E2ECrudConstants.PlainTextCollection}/{E2ECrudConstants.PlainTextItemId}";
        var WriteResp = await Http.PutAsync(ItemPath,
            new StringContent(E2ECrudConstants.PlainTextItemJson, Encoding.UTF8, AppConstants.ContentTypeJson));
        Assert.AreEqual(HttpStatusCode.OK, WriteResp.StatusCode, "PlainText PUT 200");
        var ReadResp = await Http.GetAsync(ItemPath);
        Assert.AreEqual(HttpStatusCode.OK, ReadResp.StatusCode, "PlainText GET 200");
        var Content = await ReadResp.Content.ReadAsStringAsync();
        Assert.IsTrue(Content.Contains(E2ECrudConstants.PlainTextItemTitle), "Read content matches");
        var DelResp = await Http.DeleteAsync(ItemPath);
        Assert.AreEqual(HttpStatusCode.NoContent, DelResp.StatusCode, "PlainText DELETE 204");
        var Get404 = await Http.GetAsync(ItemPath);
        Assert.AreEqual(HttpStatusCode.NotFound, Get404.StatusCode, "Deleted item 404");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Achievement query — GET by user returns 200")]
    public async Task AchievementQueryAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler)
            { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        await DevLoginHelperAsync(Http, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
        var Resp = await Http.GetAsync($"{RouteConstants.ApiAchievements}/{E2ECrudConstants.User1SubjectId}");
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode, "Achievements GET 200");
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        Assert.IsTrue(Doc.RootElement.ValueKind == JsonValueKind.Array, "Returns array");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Leaderboard query — GET top returns 200 with array")]
    public async Task LeaderboardQueryAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler)
            { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        var EarningsResp = await Http.GetAsync(RouteConstants.ApiLeaderboard);
        if (EarningsResp.StatusCode == HttpStatusCode.NotFound)
        {
            Assert.Inconclusive("Leaderboard endpoint not available on this environment");
            return;
        }
        Assert.AreEqual(HttpStatusCode.OK, EarningsResp.StatusCode, "Leaderboard earnings GET 200");
        using var EarningsDoc = JsonDocument.Parse(await EarningsResp.Content.ReadAsStringAsync());
        Assert.IsTrue(EarningsDoc.RootElement.ValueKind == JsonValueKind.Array, "Earnings returns array");
        var SpendingResp = await Http.GetAsync(
            RouteConstants.ApiLeaderboard + RouteConstants.SubLeaderboardSpending);
        if (SpendingResp.StatusCode == HttpStatusCode.NotFound)
        {
            Assert.Inconclusive("Spending leaderboard endpoint not available");
            return;
        }
        Assert.AreEqual(HttpStatusCode.OK, SpendingResp.StatusCode, "Leaderboard spending GET 200");
        using var SpendingDoc = JsonDocument.Parse(await SpendingResp.Content.ReadAsStringAsync());
        Assert.IsTrue(SpendingDoc.RootElement.ValueKind == JsonValueKind.Array, "Spending returns array");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("User profile query — GET by ID returns user data after dev-login")]
    public async Task UserProfileQueryAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler)
            { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        var LoginResp = await Http.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = E2ECrudConstants.User1SubjectId, Username = E2ECrudConstants.User1Name });
        if (LoginResp.StatusCode == HttpStatusCode.NotFound) { Assert.Inconclusive("DevLogin endpoint not available (404)"); return; }
        Assert.AreEqual(HttpStatusCode.OK, LoginResp.StatusCode, "DevLogin OK");
        using var LoginDoc = JsonDocument.Parse(await LoginResp.Content.ReadAsStringAsync());
        var UserId = LoginDoc.RootElement.GetProperty("id").GetString()!;
        var Resp = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiUsers, UserId));
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode, "User GET 200");
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var DisplayName = Doc.RootElement.GetProperty("displayName").GetString();
        Assert.AreEqual(E2ECrudConstants.User1Name, DisplayName, "User DisplayName matches");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("User KYC submission — POST updates KYC fields")]
    public async Task UserKycSubmissionAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler)
            { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        var LoginResp2 = await Http.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = E2ECrudConstants.User1SubjectId, Username = E2ECrudConstants.User1Name });
        if (LoginResp2.StatusCode == HttpStatusCode.NotFound) { Assert.Inconclusive("DevLogin endpoint not available (404)"); return; }
        using var LoginDoc = JsonDocument.Parse(await LoginResp2.Content.ReadAsStringAsync());
        var UserId = LoginDoc.RootElement.GetProperty("id").GetString()!;
        var KycPath = FormatStrings.ApiResourcePath(RouteConstants.ApiUsers, UserId) + "/kyc";
        var KycResp = await Http.PostAsJsonAsync(KycPath, new
        {
            DocumentType = E2ECrudConstants.KycDocType,
            DocumentId = E2ECrudConstants.KycDocId
        });
        Assert.IsTrue(KycResp.IsSuccessStatusCode, "KYC POST success");
        var VerifyResp = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiUsers, UserId));
        using var Doc = JsonDocument.Parse(await VerifyResp.Content.ReadAsStringAsync());
        Assert.IsTrue(Doc.RootElement.TryGetProperty("kycStatus", out var KycStatus), "Has kycStatus");
        Assert.AreEqual((int)PrTask.Domain.Models.KycStatus.Pending, KycStatus.GetInt32(), "KYC status is Pending");
    }
}
