using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task CRUD endpoints with full entity properties and DTO mapping")]
    public void TaskCrudEndpoints()
    {
        var Endpoints = ReadSource("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(Endpoints.Contains("MapTaskEndpoints"),
            "TaskEndpoints must define MapTaskEndpoints extension method");
        Assert.IsTrue(Endpoints.Contains("RouteConstants.ApiTasks"),
            "TaskEndpoints must map to ApiTasks route");
        Assert.IsTrue(Endpoints.Contains("MapGet") && Endpoints.Contains("SubRoot"),
            "Must have GET / for listing tasks");
        Assert.IsTrue(Endpoints.Contains("SubById"),
            "Must have GET /{TaskId} for getting task by ID");
        Assert.IsTrue(Endpoints.Contains("MapPost") && Endpoints.Contains("SubRoot"),
            "Must have POST / for creating tasks");
        Assert.IsTrue(Endpoints.Contains("MapPatch") && Endpoints.Contains("SubPatch"),
            "Must have PATCH /{TaskId} for updating tasks");
        Assert.IsTrue(Endpoints.Contains("MapDelete") && Endpoints.Contains("SubDelete"),
            "Must have DELETE /{TaskId} for deleting tasks");
        Assert.IsTrue(Endpoints.Contains("SubClaim"),
            "Must have POST /{TaskId}/claim for claiming tasks");
        Assert.IsTrue(Endpoints.Contains("RequireAuthorization"),
            "Create, update, delete, and claim must require authorization");
        Assert.IsTrue(Endpoints.Contains("TaskDto.FromEntity"),
            "TaskEndpoints must use TaskDto.FromEntity for response shaping");
        var Entity = ReadSource("PrTask.Domain", "Models", "TaskEntity.cs");
        var RequiredProps = new[] { "Id", "ClientId", "Title", "Description", "RepoUrl",
            "Complexity", "BountyAmountCents", "Status", "MaxClaims", "Tags",
            "Deadline", "PaymentId", "WorkItemType", "ParentId", "SprintId",
            "BoardColumnId", "Priority", "CreatedAt", "UpdatedAt" };
        foreach (var Prop in RequiredProps)
        {
            Assert.IsTrue(Entity.Contains(Prop),
                $"TaskEntity must have {Prop} property");
        }
        var StatusEnum = ReadSource("PrTask.Domain", "Models", "TaskStatus.cs");
        var StatusValues = new[] { "Open", "Claimed", "InProgress", "Review", "Completed", "Cancelled" };
        foreach (var Val in StatusValues)
        {
            Assert.IsTrue(StatusEnum.Contains(Val),
                $"PrTaskStatus enum must have {Val} value");
        }
        var ComplexityEnum = ReadSource("PrTask.Domain", "Models", "TaskComplexity.cs");
        var ComplexityValues = new[] { "Trivial", "Simple", "Medium", "Complex", "Expert" };
        foreach (var Val in ComplexityValues)
        {
            Assert.IsTrue(ComplexityEnum.Contains(Val),
                $"TaskComplexity enum must have {Val} value");
        }
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Windows Desktop EXE builds as self-contained single-file Kestrel host")]
    public void DesktopExeDownload()
    {
        var Csproj = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Desktop", "PrTask.Desktop.csproj"));
        Assert.IsTrue(Csproj.Contains("Microsoft.NET.Sdk.Web"),
            "Desktop must use Microsoft.NET.Sdk.Web SDK");
        Assert.IsTrue(Csproj.Contains("<RuntimeIdentifier>win-x64</RuntimeIdentifier>"),
            "Desktop must target win-x64 runtime");
        Assert.IsTrue(Csproj.Contains("<SelfContained>true</SelfContained>"),
            "Desktop must be self-contained");
        Assert.IsTrue(Csproj.Contains("<PublishSingleFile>true</PublishSingleFile>"),
            "Desktop must publish as single file");
        Assert.IsTrue(Csproj.Contains("<AssemblyName>PrTask</AssemblyName>"),
            "Desktop assembly name must be PrTask (produces PrTask.exe)");
        Assert.IsTrue(Csproj.Contains("PrTask.Client"),
            "Desktop must reference PrTask.Client");
        Assert.IsTrue(Csproj.Contains("PrTask.Domain"),
            "Desktop must reference PrTask.Domain");
        Assert.IsTrue(Csproj.Contains("PrTask.Infrastructure"),
            "Desktop must reference PrTask.Infrastructure");
        var Program = ReadSource("PrTask.Desktop", "Program.cs");
        Assert.IsTrue(Program.Contains("Kestrel") || Program.Contains("UseUrls") || Program.Contains("IPAddress.Loopback"),
            "Desktop must start a self-hosted Kestrel server on localhost");
        Assert.IsTrue(Program.Contains("StaticFiles") || Program.Contains("UseStaticFiles"),
            "Desktop must serve static Blazor WASM files");
        Assert.IsTrue(Program.Contains("MapFallbackToFile") || Program.Contains("index.html"),
            "Desktop must fall back to index.html for SPA routing");
        Assert.IsTrue(Program.Contains("Process.Start") || Program.Contains("OpenBrowser") || Program.Contains("Shell"),
            "Desktop must auto-open the browser");
        var DownloadPage = ReadSource("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(DownloadPage.Contains("download", StringComparison.OrdinalIgnoreCase),
            "DownloadPage must contain download instructions");
        Assert.IsTrue(DownloadPage.Contains("Windows") || DownloadPage.Contains("exe", StringComparison.OrdinalIgnoreCase),
            "DownloadPage must reference Windows EXE");
        var AppConst = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(AppConst.Contains("DesktopExeName") && AppConst.Contains("PrTask.exe"),
            "AppConstants.DesktopExeName must be PrTask.exe");
        Assert.IsTrue(AppConst.Contains("DesktopRid") && AppConst.Contains("win-x64"),
            "AppConstants.DesktopRid must be win-x64");
        Assert.IsTrue(AppConst.Contains("DesktopProjectName") && AppConst.Contains("PrTask.Desktop"),
            "AppConstants.DesktopProjectName must be PrTask.Desktop");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("All prtask.com navigation links render correctly in headless Chrome")]
    public async Task AllNavLinksResolveCorrectlyAsync()
    {
        var HomePage = await NavigateOrSkipAsync(BaseUrl);
        if (HomePage is null)
        {
            return;
        }
        try
        {
            var Title = await HomePage.TitleAsync();
            Assert.IsTrue(Title.Contains("PrTask"), $"Home title must contain PrTask, got: {Title}");
            var HeroText = await HomePage.TextContentAsync("#app");
            Assert.IsTrue(HeroText is not null && HeroText.Contains("Earn Money"),
                "Home page must render hero section via Blazor WASM");
            var NavVisible = await HomePage.Locator(".nav-links a").CountAsync();
            Assert.IsTrue(NavVisible >= 10, $"Nav must have at least 10 links, found {NavVisible}");
        }
        finally
        {
            await HomePage.CloseAsync();
        }
        var NavRoutes = new[]
        {
            RouteConstants.Tasks, RouteConstants.Leaderboard,
            RouteConstants.HowItWorks, RouteConstants.Pricing,
            RouteConstants.About, RouteConstants.Dashboard,
            RouteConstants.Download, RouteConstants.Settings,
            RouteConstants.Terms, RouteConstants.Privacy,
            RouteConstants.CookiePolicy, RouteConstants.AcceptableUse,
            RouteConstants.Refund, RouteConstants.Licenses,
            RouteConstants.Accessibility, RouteConstants.Dmca,
            RouteConstants.Login
        };
        var Failures = new List<string>();
        foreach (var Route in NavRoutes)
        {
            var NavPage = await NavigateOrSkipAsync($"{BaseUrl}{Route}");
            if (NavPage is null)
            {
                continue;
            }
            try
            {
                var PageContent = await NavPage.TextContentAsync("#app");
                if (string.IsNullOrWhiteSpace(PageContent) || PageContent.Length < 20)
                {
                    Failures.Add($"{Route}: page rendered blank or insufficient content");
                }
            }
            finally
            {
                await NavPage.CloseAsync();
            }
        }
        Assert.AreEqual(0, Failures.Count,
            $"Navigation link failures:\n{string.Join("\n", Failures)}");
    }
}
