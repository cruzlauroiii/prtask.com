using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public class HttpKycVerificationService(HttpClient Http) : IKycVerificationService
{
    public async Task<(string SessionId, string VerificationUrl)> CreateSessionAsync(string UserId, string? CallbackUrl)
    {
        var Query = string.IsNullOrEmpty(CallbackUrl) ? string.Empty : string.Format(DiditConstants.QueryPathFormat, DiditConstants.QuerySeparator, string.Format(DiditConstants.QueryVendorDataFormat, CallbackUrl));
        var Resp = await Http.PostAsync(RouteConstants.ApiKycCreate + Query, null);
        if (!Resp.IsSuccessStatusCode) { return (string.Empty, string.Empty); }
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var Sid = Doc.RootElement.TryGetProperty(DiditConstants.JsonSessionId, out var S) ? S.GetString() ?? string.Empty : string.Empty;
        var Url = Doc.RootElement.TryGetProperty(DiditConstants.JsonVerificationUrl, out var U) ? U.GetString() ?? string.Empty : string.Empty;
        return (Sid, Url);
    }
    public async Task<(string Status, string FullName)> GetSessionStatusAsync(string SessionId)
    {
        var Resp = await Http.GetAsync(string.Format(RouteConstants.ApiKycStatusFormat, SessionId));
        if (!Resp.IsSuccessStatusCode) { return (string.Empty, string.Empty); }
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var Status = Doc.RootElement.TryGetProperty(DiditConstants.JsonStatus, out var St) ? St.GetString() ?? string.Empty : string.Empty;
        var Name = Doc.RootElement.TryGetProperty(DiditConstants.JsonFullName, out var N) ? N.GetString() ?? string.Empty : string.Empty;
        return (Status, Name);
    }
    public async Task UpdateSessionStatusAsync(string SessionId, string NewStatus, string? Comment) =>
        await Http.PatchAsJsonAsync(string.Format(RouteConstants.ApiKycUpdateFormat, SessionId), new { NewStatus, Comment });
    public async Task<string> ListSessionsAsync(string? VendorData, string? Status)
    {
        var Resp = await Http.GetAsync(RouteConstants.ApiKycListSessions);
        return await Resp.Content.ReadAsStringAsync();
    }
    public async Task DeleteSessionAsync(string SessionId) =>
        await Http.DeleteAsync(string.Format(RouteConstants.ApiKycDeleteFormat, SessionId));
}
