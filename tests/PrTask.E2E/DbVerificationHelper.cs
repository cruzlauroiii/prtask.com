using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public static class DbVerificationHelper
{
    public static async Task<bool> EntityExistsAsync(HttpClient Http, string ApiBase, string Id)
    {
        var Url = FormatStrings.ApiResourcePath(ApiBase, Id);
        var Resp = await Http.GetAsync(Url);
        return Resp.StatusCode is HttpStatusCode.OK;
    }

    public static async Task AssertEntityExistsAsync(HttpClient Http, string ApiBase, string Id, string EntityName)
    {
        var Exists = await EntityExistsAsync(Http, ApiBase, Id);
        Assert.IsTrue(Exists, string.Format(
            DbVerificationConstants.EntityExistsAssert, EntityName, Id, ApiBase));
    }

    public static async Task AssertEntityDeletedAsync(HttpClient Http, string ApiBase, string Id, string EntityName)
    {
        var Exists = await EntityExistsAsync(Http, ApiBase, Id);
        Assert.IsFalse(Exists, string.Format(
            DbVerificationConstants.EntityDeletedAssert, EntityName, Id, ApiBase));
    }

    public static async Task<JsonElement> GetEntityAsync(HttpClient Http, string ApiBase, string Id)
    {
        var Url = FormatStrings.ApiResourcePath(ApiBase, Id);
        var Resp = await Http.GetAsync(Url);
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode);
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        return Doc.RootElement.Clone();
    }

    public static async Task AssertFieldEqualsAsync(
        HttpClient Http, string ApiBase, string Id, string FieldName, string ExpectedValue)
    {
        var Entity = await GetEntityAsync(Http, ApiBase, Id);
        var ActualValue = Entity.GetProperty(FieldName).GetString();
        Assert.AreEqual(ExpectedValue, ActualValue,
            string.Format(DbVerificationConstants.FieldMatchAssert, ApiBase, FieldName, ExpectedValue));
    }

    public static async Task<int> GetEntityCountAsync(HttpClient Http, string ApiBase)
    {
        var Resp = await Http.GetAsync(ApiBase);
        if (Resp.StatusCode is not HttpStatusCode.OK) { return 0; }
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        return Doc.RootElement.ValueKind is JsonValueKind.Array ? Doc.RootElement.GetArrayLength() : 0;
    }

    public static async Task AssertEntityCountAsync(HttpClient Http, string ApiBase, int Expected)
    {
        var Count = await GetEntityCountAsync(Http, ApiBase);
        Assert.AreEqual(Expected, Count,
            string.Format(DbVerificationConstants.CountMatchAssert, ApiBase, Expected));
    }

    public static async Task<DbSnapshot> TakeSnapshotAsync(HttpClient Http, params string[] ApiEndpoints)
    {
        var Data = new Dictionary<string, JsonElement>();
        foreach (var Endpoint in ApiEndpoints)
        {
            try
            {
                var Resp = await Http.GetAsync(Endpoint);
                if (Resp.IsSuccessStatusCode)
                {
                    using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
                    Data[Endpoint] = Doc.RootElement.Clone();
                }
            }
            catch (HttpRequestException)
            {
                _ = Endpoint;
            }
        }
        return new DbSnapshot(DateTime.UtcNow, Data);
    }

    public static SnapshotDiff CompareSnapshots(DbSnapshot Before, DbSnapshot After)
    {
        var Differences = new Dictionary<string, SnapshotTableDiff>();
        foreach (var Endpoint in Before.Data.Keys.Union(After.Data.Keys))
        {
            var HasBefore = Before.Data.TryGetValue(Endpoint, out var BeforeData);
            var HasAfter = After.Data.TryGetValue(Endpoint, out var AfterData);

            if (!HasBefore || !HasAfter)
            {
                Differences[Endpoint] = new SnapshotTableDiff(
                    HasBefore ? GetCount(BeforeData) : 0,
                    HasAfter ? GetCount(AfterData) : 0,
                    !HasBefore || !HasAfter);
                continue;
            }

            var BeforeCount = GetCount(BeforeData);
            var AfterCount = GetCount(AfterData);

            if (BeforeCount != AfterCount)
            {
                Differences[Endpoint] = new SnapshotTableDiff(BeforeCount, AfterCount, false);
            }
        }
        return new SnapshotDiff(Differences);
    }

    public static void AssertSnapshotsMatch(DbSnapshot Expected, DbSnapshot Actual, params string[] Endpoints)
    {
        foreach (var Endpoint in Endpoints)
        {
            if (!Expected.Data.TryGetValue(Endpoint, out var ExpData)) { continue; }
            if (!Actual.Data.TryGetValue(Endpoint, out var ActData))
            {
                Assert.Fail(string.Format(DbVerificationConstants.CompareResultFormat, Endpoint, "missing"));
                continue;
            }

            var ExpCount = GetCount(ExpData);
            var ActCount = GetCount(ActData);
            Assert.AreEqual(ExpCount, ActCount,
                string.Format(DbVerificationConstants.CompareResultFormat, Endpoint, Math.Abs(ExpCount - ActCount)));
        }
    }

    public static async Task<bool> VerifyCrudCycleAsync(HttpClient Http, string ApiBase, object CreatePayload)
    {
        var CreateResp = await Http.PostAsJsonAsync(ApiBase, CreatePayload);
        if (!CreateResp.IsSuccessStatusCode) { return false; }

        using var Doc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        if (!Doc.RootElement.TryGetProperty("id", out var IdProp)) { return false; }
        var Id = IdProp.GetString()!;

        var ReadResp = await Http.GetAsync(FormatStrings.ApiResourcePath(ApiBase, Id));
        if (ReadResp.StatusCode is not HttpStatusCode.OK) { return false; }

        var DeleteResp = await Http.DeleteAsync(FormatStrings.ApiResourcePath(ApiBase, Id));
        if (DeleteResp.StatusCode is not HttpStatusCode.NoContent) { return false; }

        var VerifyResp = await Http.GetAsync(FormatStrings.ApiResourcePath(ApiBase, Id));
        return VerifyResp.StatusCode is HttpStatusCode.NotFound;
    }

    private static int GetCount(JsonElement Element) =>
        Element.ValueKind is JsonValueKind.Array ? Element.GetArrayLength() : 1;
}
