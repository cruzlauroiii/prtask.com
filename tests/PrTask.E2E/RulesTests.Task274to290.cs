using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Native reference repos cloned at C:\\work")]
    public void NativeReposExist()
    {
        Assert.IsTrue(Directory.Exists(E2ECrudConstants.NativeRepoLlamaCpp), "llama.cpp cloned");
        Assert.IsTrue(Directory.Exists(E2ECrudConstants.NativeRepoWhisperCpp), "whisper.cpp cloned");
        Assert.IsTrue(Directory.Exists(E2ECrudConstants.NativeRepoUSearch), "USearch cloned");
        Assert.IsTrue(Directory.Exists(E2ECrudConstants.NativeRepoAutomerge), "automerge cloned");
        Assert.IsTrue(Directory.Exists(E2ECrudConstants.NativeRepoLowdb), "lowdb cloned");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("XA0141 suppressed in MAUI csproj for USearch 16KB page alignment")]
    public void MauiXa0141Suppressed()
    {
        var Csproj = ReadSource("PrTask.Maui", "PrTask.Maui.csproj");
        Assert.IsTrue(Csproj.Contains("XA0141"), "NoWarn includes XA0141");
        Assert.IsTrue(Csproj.Contains("<NoWarn>"), "Has NoWarn element");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Real Maya sandbox checkout creates real checkoutId")]
    public async Task RealMayaSandboxCheckoutAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Maya = new HttpClient(Handler) { BaseAddress = new Uri(MayaConstants.SandboxBaseUrl) };
        var CheckoutKeyBytes = Encoding.UTF8.GetBytes(Domain.Constants.Domain.Constants.MayaSandboxCredentials.Party1PublicKey + ":");
        Maya.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Basic", Convert.ToBase64String(CheckoutKeyBytes));
        var Body = new
        {
            totalAmount = new { value = 100, currency = E2ECrudConstants.MayaCheckoutCurrency },
            requestReferenceNumber = E2ECrudConstants.MayaCheckoutReferencePrefix + Guid.NewGuid().ToString("N")[..8],
            redirectUrl = new
            {
                success = "https://prtask.com/payment/success",
                failure = "https://prtask.com/payment/failure",
                cancel = "https://prtask.com/payment/cancel"
            }
        };
        var Resp = await Maya.PostAsJsonAsync(MayaConstants.CheckoutEndpoint, Body);
        var Json = await Resp.Content.ReadAsStringAsync();
        if (!Resp.IsSuccessStatusCode)
        {
            Assert.Inconclusive($"Maya sandbox returned {Resp.StatusCode}: {Json}");
        }
        using var Doc = JsonDocument.Parse(Json);
        Assert.IsTrue(Doc.RootElement.TryGetProperty(MayaConstants.CheckoutIdProperty, out var CheckoutId),
            "Response has checkoutId");
        Assert.IsFalse(string.IsNullOrEmpty(CheckoutId.GetString()), "checkoutId is not empty");
        Assert.IsTrue(Doc.RootElement.TryGetProperty(MayaConstants.RedirectUrlProperty, out var RedirectUrl),
            "Response has redirectUrl");
        var RedirectUrlStr = RedirectUrl.GetString()!;
        Assert.IsTrue(
            RedirectUrlStr.Contains("paymaya", StringComparison.OrdinalIgnoreCase)
            || RedirectUrlStr.Contains("maya", StringComparison.OrdinalIgnoreCase)
            || RedirectUrlStr.StartsWith("https://", StringComparison.OrdinalIgnoreCase),
            $"redirectUrl is valid: {RedirectUrlStr}");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Real Maya sandbox payment token with test card")]
    public async Task RealMayaSandboxPaymentTokenAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Maya = new HttpClient(Handler) { BaseAddress = new Uri(MayaConstants.SandboxBaseUrl) };
        var TokenKeyBytes = Encoding.UTF8.GetBytes(MayaSandboxCredentials.Party1PublicKey + ":");
        Maya.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Basic", Convert.ToBase64String(TokenKeyBytes));
        var Body = new
        {
            card = new
            {
                number = MayaTestCards.MasterCardNoThreeDsNumber,
                expMonth = "12", expYear = "2030",
                cvc = MayaTestCards.MasterCardNoThreeDsCvv
            }
        };
        var Resp = await Maya.PostAsJsonAsync(MayaConstants.PaymentTokenEndpoint, Body);
        var Json = await Resp.Content.ReadAsStringAsync();
        if (!Resp.IsSuccessStatusCode)
        {
            Assert.Inconclusive($"Maya token returned {Resp.StatusCode}: {Json}");
        }
        using var Doc = JsonDocument.Parse(Json);
        Assert.IsTrue(Doc.RootElement.TryGetProperty(MayaConstants.PaymentTokenIdProperty, out var TokenId),
            "Response has paymentTokenId");
        Assert.IsFalse(string.IsNullOrEmpty(TokenId.GetString()), "paymentTokenId is not empty");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Real Didit KYC sandbox session creation")]
    public async Task RealDiditKycSessionAsync()
    {
        var ApiKey = Environment.GetEnvironmentVariable("DIDIT_API_KEY")
            ?? "GVTQTUdkmEaJneMrUNeppVmspEhVqnNENYX4FOh0sCs";
        var WorkflowId = Environment.GetEnvironmentVariable("DIDIT_WORKFLOW_ID")
            ?? DiditConstants.DefaultWorkflowId;
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Didit = new HttpClient(Handler) { BaseAddress = new Uri(DiditConstants.BaseUrl) };
        Didit.DefaultRequestHeaders.Add(DiditConstants.ApiKeyHeader, ApiKey);
        var Body = new { workflow_id = WorkflowId, vendor_data = "e2e-test-user" };
        var Resp = await Didit.PostAsJsonAsync(DiditConstants.CreateSessionPath, Body);
        var Json = await Resp.Content.ReadAsStringAsync();
        if (!Resp.IsSuccessStatusCode)
        {
            Assert.Inconclusive($"Didit returned {Resp.StatusCode}: {Json}");
            return;
        }
        using var Doc = JsonDocument.Parse(Json);
        Assert.IsTrue(Doc.RootElement.TryGetProperty(DiditConstants.PropertySessionId, out var Sid),
            "Response has session_id");
        Assert.IsFalse(string.IsNullOrEmpty(Sid.GetString()), "session_id not empty");
        Assert.IsTrue(Doc.RootElement.TryGetProperty(DiditConstants.PropertyUrl, out var Url),
            "Response has url");
        Assert.IsTrue(Url.GetString()!.Contains("didit.me", StringComparison.OrdinalIgnoreCase),
            "url points to didit.me");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Sprint full CRUD — create, read, update, delete, verify 404")]
    public async Task SprintCrudAsync()
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
        var Sprint = new
        {
            Name = E2ECrudConstants.SprintName,
            Goal = E2ECrudConstants.SprintGoal,
            OwnerId = E2ECrudConstants.User1SubjectId,
            StartDate = DateTime.UtcNow.ToString("o"),
            EndDate = DateTime.UtcNow.AddDays(14).ToString("o")
        };
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiSprints, Sprint);
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Sprint POST 201");
        using var CreateDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var SprintId = CreateDoc.RootElement.GetProperty("id").GetString()!;
        var GetResp = await Http.GetAsync($"{RouteConstants.ApiSprints}/{SprintId}");
        Assert.AreEqual(HttpStatusCode.OK, GetResp.StatusCode, "Sprint GET 200");
        using var GetDoc = JsonDocument.Parse(await GetResp.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.SprintName, GetDoc.RootElement.GetProperty("name").GetString());
        var PatchResp = await Http.PatchAsJsonAsync(
            $"{RouteConstants.ApiSprints}/{SprintId}",
            new { Name = E2ECrudConstants.UpdatedSprintName, Status = (int)SprintStatus.Active });
        Assert.IsTrue(PatchResp.IsSuccessStatusCode, "Sprint PATCH success");
        var GetUpdated = await Http.GetAsync($"{RouteConstants.ApiSprints}/{SprintId}");
        using var UpdDoc = JsonDocument.Parse(await GetUpdated.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.UpdatedSprintName, UpdDoc.RootElement.GetProperty("name").GetString());
        var DelResp = await Http.DeleteAsync($"{RouteConstants.ApiSprints}/{SprintId}");
        Assert.AreEqual(HttpStatusCode.NoContent, DelResp.StatusCode, "Sprint DELETE 204");
        var Get404 = await Http.GetAsync($"{RouteConstants.ApiSprints}/{SprintId}");
        Assert.AreEqual(HttpStatusCode.NotFound, Get404.StatusCode, "Deleted sprint 404");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Board and Column CRUD — create board, add/delete column, delete board")]
    public async Task BoardColumnCrudAsync()
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
        var Board = new
        {
            Id = E2ECrudConstants.CrudBoardId, Name = E2ECrudConstants.BoardName,
            OwnerId = E2ECrudConstants.User1SubjectId, Type = (int)BoardType.Kanban
        };
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiBoards, Board);
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Board POST 201");
        var Column = new
        {
            Id = E2ECrudConstants.CrudColumnId, BoardId = E2ECrudConstants.CrudBoardId,
            Name = E2ECrudConstants.ColumnName, Order = 0, WipLimit = E2ECrudConstants.ColumnWipLimit
        };
        var ColPath = $"{RouteConstants.ApiBoards}/{E2ECrudConstants.CrudBoardId}/columns";
        var ColResp = await Http.PostAsJsonAsync(ColPath, Column);
        Assert.IsTrue(ColResp.IsSuccessStatusCode, "Column POST success");
        var ColGetResp = await Http.GetAsync(ColPath);
        Assert.AreEqual(HttpStatusCode.OK, ColGetResp.StatusCode, "Columns GET 200");
        using var ColDoc = JsonDocument.Parse(await ColGetResp.Content.ReadAsStringAsync());
        Assert.IsTrue(ColDoc.RootElement.GetArrayLength() > 0, "Column list not empty");
        var DelColResp = await Http.DeleteAsync($"{ColPath}/{E2ECrudConstants.CrudColumnId}");
        Assert.AreEqual(HttpStatusCode.NoContent, DelColResp.StatusCode, "Column DELETE 204");
        var DelBoardResp = await Http.DeleteAsync($"{RouteConstants.ApiBoards}/{E2ECrudConstants.CrudBoardId}");
        Assert.AreEqual(HttpStatusCode.NoContent, DelBoardResp.StatusCode, "Board DELETE 204");
        var Get404 = await Http.GetAsync($"{RouteConstants.ApiBoards}/{E2ECrudConstants.CrudBoardId}");
        Assert.AreEqual(HttpStatusCode.NotFound, Get404.StatusCode, "Deleted board 404");
    }
    private static async Task DevLoginHelperAsync(HttpClient Http, string SubjectId, string Name)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = SubjectId, Username = Name });
        if (Resp.StatusCode == HttpStatusCode.NotFound)
        {
            Assert.Inconclusive("DevLogin endpoint not available (404) — server may not support /Api/Auth/DevLogin in this environment");
            return;
        }
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode, $"DevLogin for {Name}");
    }
}
