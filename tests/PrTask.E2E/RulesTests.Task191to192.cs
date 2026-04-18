using Microsoft.Playwright;
using Microsoft.Playwright;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Playwright headless Chrome setup for live-site E2E tests")]
    public void PlaywrightHeadlessChromeSetup()
    {
        var Csproj = File.ReadAllText(Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "PrTask.E2E.csproj"));
        Assert.IsTrue(Csproj.Contains("PrTask.Cdp"),
            "E2E test project must reference PrTask.Cdp project");
        var BaseClass = File.ReadAllText(Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "RulesTests.cs"));
        Assert.IsTrue(BaseClass.Contains("ChromeLauncher"),
            "RulesTests must declare ChromeLauncher instance");
        Assert.IsTrue(BaseClass.Contains("CdpBrowser"),
            "RulesTests must declare CdpBrowser instance");
        Assert.IsTrue(BaseClass.Contains("LaunchAsync"),
            "RulesTests must launch Chrome browser via CDP");
        Assert.IsTrue(BaseClass.Contains("Headless"),
            "Browser must configure Headless mode");
        Assert.IsTrue(BaseClass.Contains("NavigateOrSkipAsync"),
            "RulesTests must have NavigateOrSkipAsync helper");
        Assert.IsTrue(BaseClass.Contains("WaitForLoadAsync"),
            "NavigateOrSkipAsync must wait for page load");
        Assert.IsTrue(BaseClass.Contains("CdpException"),
            "NavigateOrSkipAsync must catch CdpException");
        var GuardsFile = File.ReadAllText(Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "RulesTests.Guards.cs"));
        Assert.IsTrue(GuardsFile.Contains("GetOrSkipAsync"),
            "RulesTests.Guards must have GetOrSkipAsync for API tests");
        Assert.IsTrue(BaseClass.Contains("TakeScreenshotAsync"),
            "RulesTests must have TakeScreenshotAsync helper for workflow screenshots");
        Assert.IsTrue(BaseClass.Contains("WaitForBlazorAsync"),
            "RulesTests must have WaitForBlazorAsync helper for Blazor WASM rendering");
        Assert.IsTrue(BaseClass.Contains("ScreenshotDir"),
            "RulesTests must define ScreenshotDir for screenshot output");
        Assert.IsTrue(BaseClass.Contains("DisposeAsync"),
            "ClassCleanup must dispose browser via DisposeAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Playwright headless Chrome setup for live-site E2E tests")]
    public void PlaywrightHeadlessChromeSetup()
    {
        var Csproj = File.ReadAllText(Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "PrTask.E2E.csproj"));
        Assert.IsTrue(Csproj.Contains("PrTask.Cdp"),
            "E2E test project must reference PrTask.Cdp project");
        var BaseClass = File.ReadAllText(Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "RulesTests.cs"));
        Assert.IsTrue(BaseClass.Contains("ChromeLauncher"),
            "RulesTests must declare ChromeLauncher instance");
        Assert.IsTrue(BaseClass.Contains("CdpBrowser"),
            "RulesTests must declare CdpBrowser instance");
        Assert.IsTrue(BaseClass.Contains("LaunchAsync"),
            "RulesTests must launch Chrome browser via CDP");
        Assert.IsTrue(BaseClass.Contains("Headless"),
            "Browser must configure Headless mode");
        Assert.IsTrue(BaseClass.Contains("NavigateOrSkipAsync"),
            "RulesTests must have NavigateOrSkipAsync helper");
        Assert.IsTrue(BaseClass.Contains("WaitForLoadAsync"),
            "NavigateOrSkipAsync must wait for page load");
        Assert.IsTrue(BaseClass.Contains("CdpException"),
            "NavigateOrSkipAsync must catch CdpException");
        var GuardsFile = File.ReadAllText(Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "RulesTests.Guards.cs"));
        Assert.IsTrue(GuardsFile.Contains("GetOrSkipAsync"),
            "RulesTests.Guards must have GetOrSkipAsync for API tests");
        Assert.IsTrue(BaseClass.Contains("TakeScreenshotAsync"),
            "RulesTests must have TakeScreenshotAsync helper for workflow screenshots");
        Assert.IsTrue(BaseClass.Contains("WaitForBlazorAsync"),
            "RulesTests must have WaitForBlazorAsync helper for Blazor WASM rendering");
        Assert.IsTrue(BaseClass.Contains("ScreenshotDir"),
            "RulesTests must define ScreenshotDir for screenshot output");
        Assert.IsTrue(BaseClass.Contains("DisposeAsync"),
            "ClassCleanup must dispose browser via DisposeAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Playwright headless Chrome setup for live-site E2E tests")]
    public void PlaywrightHeadlessChromeSetup()
    {
        var Csproj = File.ReadAllText(Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "PrTask.E2E.csproj"));
        Assert.IsTrue(Csproj.Contains("Microsoft.Playwright"),
            "E2E test project must reference Microsoft.Playwright package");
        var BaseClass = File.ReadAllText(Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "RulesTests.cs"));
        Assert.IsTrue(BaseClass.Contains("IPlaywright"),
            "RulesTests must declare IPlaywright instance");
        Assert.IsTrue(BaseClass.Contains("IBrowser"),
            "RulesTests must declare IBrowser instance");
        Assert.IsTrue(BaseClass.Contains("Chromium.LaunchAsync"),
            "RulesTests must launch Chromium browser");
        Assert.IsTrue(BaseClass.Contains("Headless ="),
            "Browser must configure Headless mode");
        Assert.IsTrue(BaseClass.Contains("NavigateOrSkipAsync"),
            "RulesTests must have NavigateOrSkipAsync helper");
        Assert.IsTrue(BaseClass.Contains("NetworkIdle"),
            "NavigateOrSkipAsync must wait for NetworkIdle");
        Assert.IsTrue(BaseClass.Contains("PlaywrightException"),
            "NavigateOrSkipAsync must catch PlaywrightException");
        Assert.IsTrue(BaseClass.Contains("GetOrSkipAsync"),
            "RulesTests must still have GetOrSkipAsync for API tests");
        Assert.IsTrue(BaseClass.Contains("TakeScreenshotAsync"),
            "RulesTests must have TakeScreenshotAsync helper for workflow screenshots");
        Assert.IsTrue(BaseClass.Contains("WaitForBlazorAsync"),
            "RulesTests must have WaitForBlazorAsync helper for Blazor WASM rendering");
        Assert.IsTrue(BaseClass.Contains("ScreenshotDir"),
            "RulesTests must define ScreenshotDir for screenshot output");
        Assert.IsTrue(BaseClass.Contains("DisposeAsync"),
            "ClassCleanup must dispose browser via DisposeAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Full Maya payment workflow from task creation through developer payout")]
    public void FullMayaPaymentWorkflow()
    {
        var TaskEndpoints = ReadSource("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(TaskEndpoints.Contains("MapPost") && TaskEndpoints.Contains("CreateAsync"),
            "TaskEndpoints must support POST to create tasks");
        var PrEndpoints = ReadSource("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(PrEndpoints.Contains("MapPost") && PrEndpoints.Contains("SubmitAsync"),
            "PullRequestEndpoints must support POST to submit PRs");
        Assert.IsTrue(PrEndpoints.Contains("SubApprove") && PrEndpoints.Contains("ApproveAsync"),
            "PullRequestEndpoints must have approve endpoint");
        var PayEndpoints = ReadSource("PrTask.Server", "Endpoints", "PaymentEndpoints.cs");
        Assert.IsTrue(PayEndpoints.Contains("CreateCheckoutAsync"),
            "PaymentEndpoints must create Maya checkout on payment");
        Assert.IsTrue(PayEndpoints.Contains("SubWebhook") && PayEndpoints.Contains("HandleWebhookAsync"),
            "PaymentEndpoints must handle Maya webhook callbacks");
        Assert.IsTrue(PayEndpoints.Contains("SubPaymentVoid") && PayEndpoints.Contains("VoidPaymentAsync"),
            "PaymentEndpoints must support void");
        Assert.IsTrue(PayEndpoints.Contains("SubPaymentRefund") && PayEndpoints.Contains("RefundPaymentAsync"),
            "PaymentEndpoints must support refund");
        var PaymentService = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(PaymentService.Contains("CreateCheckoutAsync"),
            "IPaymentService must have CreateCheckoutAsync");
        Assert.IsTrue(PaymentService.Contains("HandleWebhookAsync"),
            "IPaymentService must have HandleWebhookAsync");
        Assert.IsTrue(PaymentService.Contains("GetStatusAsync"),
            "IPaymentService must have GetStatusAsync");
        var PaymentEntity = ReadSource("PrTask.Domain", "Models", "PaymentEntity.cs");
        Assert.IsTrue(PaymentEntity.Contains("MayaCheckoutId"),
            "PaymentEntity must have MayaCheckoutId");
        Assert.IsTrue(PaymentEntity.Contains("MayaPaymentId"),
            "PaymentEntity must have MayaPaymentId");
        Assert.IsTrue(PaymentEntity.Contains("PayerId"),
            "PaymentEntity must have PayerId (client who pays)");
        Assert.IsTrue(PaymentEntity.Contains("PayeeId"),
            "PaymentEntity must have PayeeId (developer who gets paid)");
        Assert.IsTrue(PaymentEntity.Contains("TaskId"),
            "PaymentEntity must link to TaskId");
        Assert.IsTrue(PaymentEntity.Contains("PullRequestId"),
            "PaymentEntity must link to PullRequestId");
        Assert.IsTrue(PaymentEntity.Contains("PlatformFeeCents"),
            "PaymentEntity must track platform fee");
        Assert.IsTrue(PaymentEntity.Contains("WebhookData"),
            "PaymentEntity must store webhook data");
        var WebhookEp = ReadSource("PrTask.Server", "Endpoints", "WebhookEndpoints.cs");
        Assert.IsTrue(WebhookEp.Contains("RegisterWebhookAsync"),
            "WebhookEndpoints must support webhook registration");
        Assert.IsTrue(WebhookEp.Contains("GetWebhooksAsync"),
            "WebhookEndpoints must support listing webhooks");
        Assert.IsTrue(WebhookEp.Contains("UpdateWebhookAsync"),
            "WebhookEndpoints must support updating webhooks");
        Assert.IsTrue(WebhookEp.Contains("DeleteWebhookAsync"),
            "WebhookEndpoints must support deleting webhooks");
        var DisbEp = ReadSource("PrTask.Server", "Endpoints", "DisbursementEndpoints.cs");
        Assert.IsTrue(DisbEp.Contains("CreateSessionAsync"),
            "DisbursementEndpoints must create disbursement session");
        Assert.IsTrue(DisbEp.Contains("SubmitDisbursementAsync"),
            "DisbursementEndpoints must submit disbursement");
        Assert.IsTrue(DisbEp.Contains("ProcessDisbursementAsync"),
            "DisbursementEndpoints must process disbursement");
        Assert.IsTrue(DisbEp.Contains("GetDisbursementStatusAsync"),
            "DisbursementEndpoints must get disbursement status");
        var MayaConst = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(MayaConst.Contains("SandboxPublicKey") && MayaConst.Contains("pk-"),
            "SandboxPublicKey must start with pk- prefix");
        Assert.IsTrue(MayaConst.Contains("SandboxSecretKey") && MayaConst.Contains("sk-"),
            "SandboxSecretKey must start with sk- prefix");
        Assert.IsTrue(MayaConst.Contains("SandboxCheckoutUrl"),
            "SandboxCheckoutUrl must be defined");
        Assert.IsTrue(MayaConst.Contains("WebhookMaxRetries"),
            "WebhookMaxRetries must be defined");
        Assert.IsTrue(MayaConst.Contains("CheckoutExpiryMinutes"),
            "CheckoutExpiryMinutes must be defined");
        var TestCards = ReadSource("PrTask.Domain", "Constants", "MayaTestCards.cs");
        Assert.IsTrue(TestCards.Contains("VisaNoThreeDsNumber"),
            "MayaTestCards must have Visa no-3DS test card");
        Assert.IsTrue(TestCards.Contains("MasterCardNoThreeDsNumber"),
            "MayaTestCards must have MasterCard no-3DS test card");
        Assert.IsTrue(TestCards.Contains("AmexNumber"),
            "MayaTestCards must have Amex test card");
        Assert.IsTrue(TestCards.Contains("JcbNumber"),
            "MayaTestCards must have JCB test card");
        Assert.IsTrue(TestCards.Contains("InsufficientFundsVisaNumber"),
            "MayaTestCards must have insufficient funds test card");
        var TaskEntity = ReadSource("PrTask.Domain", "Models", "TaskEntity.cs");
        Assert.IsTrue(TaskEntity.Contains("PaymentId"),
            "TaskEntity.PaymentId links task to payment for traceability");
        var PrEntity = ReadSource("PrTask.Domain", "Models", "PullRequestEntity.cs");
        Assert.IsTrue(PrEntity.Contains("TaskId"),
            "PullRequestEntity.TaskId links PR to task");
        Assert.IsTrue(PrEntity.Contains("PaidAt"),
            "PullRequestEntity.PaidAt tracks when developer was paid");
        var StatusValues = new[] { "Submitted", "Approved", "Rejected", "Merged", "Paid" };
        var PrStatus = ReadSource("PrTask.Domain", "Models", "PullRequestStatus.cs");
        foreach (var Val in StatusValues)
        {
            Assert.IsTrue(PrStatus.Contains(Val), $"PullRequestStatus must have {Val} value");
        }
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Cross-platform test matrix for prtask.com Desktop EXE and MAUI APK")]
    public void CrossPlatformTestMatrix()
    {
        var ClientCsproj = File.ReadAllText(
            Path.Combine(SourceRoot, "PrTask.Client", "PrTask.Client.csproj"));
        Assert.IsTrue(ClientCsproj.Contains("Microsoft.NET.Sdk.BlazorWebAssembly"),
            "Client must use BlazorWebAssembly SDK for prtask.com");
        Assert.IsTrue(ClientCsproj.Contains("PrTask.SharedUI"),
            "Client must reference SharedUI for shared pages");
        var DesktopCsproj = File.ReadAllText(
            Path.Combine(SourceRoot, "PrTask.Desktop", "PrTask.Desktop.csproj"));
        Assert.IsTrue(DesktopCsproj.Contains("<RuntimeIdentifier>win-x64</RuntimeIdentifier>"),
            "Desktop must target win-x64 for Windows EXE");
        Assert.IsTrue(DesktopCsproj.Contains("<PublishSingleFile>true</PublishSingleFile>"),
            "Desktop must produce single-file EXE");
        Assert.IsTrue(DesktopCsproj.Contains("<SelfContained>true</SelfContained>"),
            "Desktop must be self-contained (no runtime dependency)");
        Assert.IsTrue(DesktopCsproj.Contains("PrTask.Client"),
            "Desktop must reference Client to serve its WASM files");
        var MauiCsproj = File.ReadAllText(
            Path.Combine(SourceRoot, "PrTask.Maui", "PrTask.Maui.csproj"));
        Assert.IsTrue(MauiCsproj.Contains("net10.0-android"),
            "MAUI must target net10.0-android for APK");
        Assert.IsTrue(MauiCsproj.Contains("<UseMaui>true</UseMaui>"),
            "MAUI must have UseMaui enabled");
        Assert.IsTrue(MauiCsproj.Contains("PrTask.SharedUI"),
            "MAUI must reference SharedUI for shared pages");
        var SharedPages = Directory.GetFiles(
            Path.Combine(SourceRoot, "PrTask.SharedUI", "Pages"),
            "*.razor", SearchOption.AllDirectories);
        Assert.IsTrue(SharedPages.Length >= 25,
            $"SharedUI must have at least 25 pages, found {SharedPages.Length}");
        var ClientWwwroot = Path.Combine(SourceRoot, "PrTask.Client", "wwwroot");
        Assert.IsTrue(Directory.Exists(ClientWwwroot),
            "Client must have wwwroot directory for WASM output");
        Assert.IsTrue(File.Exists(Path.Combine(ClientWwwroot, "index.html")),
            "Client must have index.html entry point");
        var MauiWwwroot = Path.Combine(SourceRoot, "PrTask.Maui", "wwwroot");
        Assert.IsTrue(Directory.Exists(MauiWwwroot),
            "MAUI must have wwwroot directory for BlazorWebView");
        Assert.IsTrue(File.Exists(Path.Combine(MauiWwwroot, "index.html")),
            "MAUI must have index.html entry point");
        var MauiPages = Directory.GetFiles(
            Path.Combine(SourceRoot, "PrTask.Maui", "Pages"),
            "*.razor", SearchOption.AllDirectories);
        Assert.IsTrue(MauiPages.Length >= 9,
            $"MAUI must have wrapper pages for key routes, found {MauiPages.Length}");
        foreach (var MauiPage in MauiPages)
        {
            var Content = File.ReadAllText(MauiPage);
            var FileName = Path.GetFileName(MauiPage);
            Assert.IsTrue(Content.Contains("PrTask.SharedUI") || Content.Contains("PrTask.Domain"),
                $"MAUI page {FileName} must reference SharedUI or Domain");
        }
        var AppConst = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(AppConst.Contains("ClientProjectName") && AppConst.Contains("PrTask.Client"),
            "AppConstants must define ClientProjectName");
        Assert.IsTrue(AppConst.Contains("DesktopProjectName") && AppConst.Contains("PrTask.Desktop"),
            "AppConstants must define DesktopProjectName");
        Assert.IsTrue(AppConst.Contains("MauiProjectName") && AppConst.Contains("PrTask.Maui"),
            "AppConstants must define MauiProjectName");
    }
}
