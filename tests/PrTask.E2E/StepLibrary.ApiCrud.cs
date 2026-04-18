using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static readonly JsonSerializerOptions ApiCrudJsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private static async Task<T> ApiPostAsync<T>(HttpClient Http, string Endpoint, object Payload)
    {
        var Resp = await Http.PostAsJsonAsync(Endpoint, Payload);
        Assert.IsTrue(
            Resp.StatusCode is HttpStatusCode.Created or HttpStatusCode.OK,
            $"ApiPost {Endpoint}: expected 201/200, got {(int)Resp.StatusCode}");
        var Body = await Resp.Content.ReadAsStringAsync();
        var Result = JsonSerializer.Deserialize<T>(Body, ApiCrudJsonOptions);
        Assert.IsNotNull(Result, $"ApiPost {Endpoint}: deserialization returned null");
        return Result;
    }

    private static async Task<T> ApiGetAsync<T>(HttpClient Http, string Endpoint, string Id)
    {
        var Url = FormatStrings.ApiResourcePath(Endpoint, Id);
        var Resp = await Http.GetAsync(Url);
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
            $"ApiGet {Url}: expected 200, got {(int)Resp.StatusCode}");
        var Body = await Resp.Content.ReadAsStringAsync();
        var Result = JsonSerializer.Deserialize<T>(Body, ApiCrudJsonOptions);
        Assert.IsNotNull(Result, $"ApiGet {Url}: deserialization returned null");
        return Result;
    }

    private static async Task<List<T>> ApiGetListAsync<T>(HttpClient Http, string Endpoint)
    {
        var Resp = await Http.GetAsync(Endpoint);
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
            $"ApiGetList {Endpoint}: expected 200, got {(int)Resp.StatusCode}");
        var Body = await Resp.Content.ReadAsStringAsync();
        var Result = JsonSerializer.Deserialize<List<T>>(Body, ApiCrudJsonOptions);
        Assert.IsNotNull(Result, $"ApiGetList {Endpoint}: deserialization returned null");
        return Result;
    }

    private static async Task ApiPatchAsync(HttpClient Http, string Endpoint, string Id, object Patch)
    {
        var Url = FormatStrings.ApiResourcePath(Endpoint, Id);
        var Content = JsonContent.Create(Patch);
        var Request = new HttpRequestMessage(HttpMethod.Patch, Url) { Content = Content };
        var Resp = await Http.SendAsync(Request);
        Assert.IsTrue(
            Resp.StatusCode is HttpStatusCode.OK or HttpStatusCode.NoContent,
            $"ApiPatch {Url}: expected 200/204, got {(int)Resp.StatusCode}");
    }

    private static async Task ApiDeleteAsync(HttpClient Http, string Endpoint, string Id)
    {
        var Url = FormatStrings.ApiResourcePath(Endpoint, Id);
        var Resp = await Http.DeleteAsync(Url);
        Assert.IsTrue(
            Resp.StatusCode is HttpStatusCode.OK or HttpStatusCode.NoContent,
            $"ApiDelete {Url}: expected 200/204, got {(int)Resp.StatusCode}");
    }

    private static async Task VerifyEntityExistsAsync(HttpClient Http, string Endpoint, string Id)
    {
        var Url = FormatStrings.ApiResourcePath(Endpoint, Id);
        var Resp = await Http.GetAsync(Url);
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
            $"VerifyExists {Url}: expected 200, got {(int)Resp.StatusCode}");
    }

    private static async Task VerifyEntityDeletedAsync(HttpClient Http, string Endpoint, string Id)
    {
        var Url = FormatStrings.ApiResourcePath(Endpoint, Id);
        var Resp = await Http.GetAsync(Url);
        Assert.AreEqual(HttpStatusCode.NotFound, Resp.StatusCode,
            $"VerifyDeleted {Url}: expected 404, got {(int)Resp.StatusCode}");
    }

    private static async Task VerifyFieldEqualsAsync(
        HttpClient Http, string Endpoint, string Id, string Field, string Expected)
    {
        var Url = FormatStrings.ApiResourcePath(Endpoint, Id);
        var Resp = await Http.GetAsync(Url);
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
            $"VerifyField {Url}: expected 200, got {(int)Resp.StatusCode}");
        var Body = await Resp.Content.ReadAsStringAsync();
        using var Doc = JsonDocument.Parse(Body);
        var Actual = Doc.RootElement.GetProperty(Field).GetString();
        Assert.AreEqual(Expected, Actual,
            $"VerifyField {Url}.{Field}: expected '{Expected}', got '{Actual}'");
    }

    private static async Task<string> VerifyCrudCycleAsync(
        HttpClient Http, string Endpoint, object CreatePayload)
    {
        var CreateResp = await Http.PostAsJsonAsync(Endpoint, CreatePayload);
        Assert.IsTrue(CreateResp.IsSuccessStatusCode,
            $"CrudCycle {Endpoint}: POST must succeed, got {(int)CreateResp.StatusCode}");
        var CreateBody = await CreateResp.Content.ReadAsStringAsync();
        using var Doc = JsonDocument.Parse(CreateBody);
        Assert.IsTrue(Doc.RootElement.TryGetProperty("id", out var IdProp),
            $"CrudCycle {Endpoint}: response must contain 'id'");
        var Id = IdProp.GetString()!;

        var ReadUrl = FormatStrings.ApiResourcePath(Endpoint, Id);
        var ReadResp = await Http.GetAsync(ReadUrl);
        Assert.AreEqual(HttpStatusCode.OK, ReadResp.StatusCode,
            $"CrudCycle GET {ReadUrl}: expected 200, got {(int)ReadResp.StatusCode}");

        var DeleteResp = await Http.DeleteAsync(ReadUrl);
        Assert.IsTrue(
            DeleteResp.StatusCode is HttpStatusCode.OK or HttpStatusCode.NoContent,
            $"CrudCycle DELETE {ReadUrl}: expected 200/204, got {(int)DeleteResp.StatusCode}");

        var VerifyResp = await Http.GetAsync(ReadUrl);
        Assert.AreEqual(HttpStatusCode.NotFound, VerifyResp.StatusCode,
            $"CrudCycle verify-deleted {ReadUrl}: expected 404, got {(int)VerifyResp.StatusCode}");

        return Id;
    }

    private static async Task CleanupResourcesAsync(
        HttpClient Http, Dictionary<string, string> EndpointIdPairs)
    {
        foreach (var Kvp in EndpointIdPairs)
        {
            var Endpoint = Kvp.Key;
            var Id = Kvp.Value;
            if (string.IsNullOrEmpty(Id))
            {
                continue;
            }
            var Url = FormatStrings.ApiResourcePath(Endpoint, Id);
            await Http.DeleteAsync(Url);
        }
    }
}
