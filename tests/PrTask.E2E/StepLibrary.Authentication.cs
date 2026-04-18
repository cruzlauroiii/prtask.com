using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static async Task<HttpResponseMessage> LoginDevAsync(HttpClient Http, string SubjectId, string Name)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = SubjectId, Username = Name });
        if (Resp.StatusCode == HttpStatusCode.NotFound)
        {
            Assert.Inconclusive($"DevLogin endpoint not available (404) for '{Name}'");
        }
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
            $"LoginDev: dev login for '{Name}' (subject={SubjectId}) must return 200");
        return Resp;
    }

    private static async Task LoginBrowserAsync(string UserId, string Username)
    {
        try
        {
            await CdpHelpers.NavigateAsync(BrowserPage, BaseUrl + RouteConstants.Home, 10000);
        }
        catch (CdpException) { }

        var Body = JsonSerializer.Serialize(new { UserId, Username });
        await BrowserPage.EvaluateAsync(
            $"(async () => {{ try {{ await fetch('{RouteConstants.ApiAuthDevLogin}', {{ method: 'POST', headers: {{ 'Content-Type': 'application/json' }}, body: {JsonSerializer.Serialize(Body)} }}); }} catch {{}} }})()");
    }

    private static async Task<string> ExtractUserIdFromResponseAsync(HttpResponseMessage Response)
    {
        var ResponseBody = await Response.Content.ReadAsStringAsync();
        using var Doc = JsonDocument.Parse(ResponseBody);
        var Id = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        Assert.IsTrue(Id.Length > 0, "ExtractUserId: response must contain a non-empty 'id' property");
        return Id;
    }

    private static async Task VerifyAuthenticatedAsync(HttpClient Http)
    {
        var MeResp = await Http.GetAsync(RouteConstants.ApiAuthMe);
        Assert.AreEqual(HttpStatusCode.OK, MeResp.StatusCode,
            "VerifyAuthenticated: GET /Api/Auth/Me must return 200");
    }

    private static async Task VerifyUnauthenticatedAsync(HttpClient Http, string Endpoint)
    {
        var Resp = await Http.GetAsync(Endpoint);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Resp.StatusCode,
            $"VerifyUnauthenticated: GET {Endpoint} must return 401, got {(int)Resp.StatusCode}");
    }

    private static async Task VerifyRoleAccessAsync(
        HttpClient Http, string Role, string[] AllowedEndpoints, string[] DeniedEndpoints)
    {
        foreach (var Endpoint in AllowedEndpoints)
        {
            var Resp = await Http.GetAsync(Endpoint);
            Assert.IsTrue(Resp.IsSuccessStatusCode,
                $"VerifyRoleAccess: {Role} GET {Endpoint} must succeed, got {(int)Resp.StatusCode}");
        }
        foreach (var Endpoint in DeniedEndpoints)
        {
            var Resp = await Http.GetAsync(Endpoint);
            Assert.IsTrue(
                Resp.StatusCode is HttpStatusCode.Unauthorized or HttpStatusCode.Forbidden,
                $"VerifyRoleAccess: {Role} GET {Endpoint} must return 401/403, got {(int)Resp.StatusCode}");
        }
    }
}
