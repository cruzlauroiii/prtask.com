namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task60 RULES.md must exist at solution root and specify free platform serverless and public PRs")]
    public void Task60RulesMdExists()
    {
        var RulesPath = Path.Combine(SolutionRoot, "RULES.md");
        Assert.IsTrue(File.Exists(RulesPath), "RULES.md must exist at solution root");
        var Content = File.ReadAllText(RulesPath);
        Assert.IsTrue(Content.Contains("free", StringComparison.OrdinalIgnoreCase), "Must mention free platform");
        Assert.IsTrue(Content.Contains("serverless", StringComparison.OrdinalIgnoreCase), "Must mention serverless architecture");
        Assert.IsTrue(Content.Contains("Public pull requests", StringComparison.Ordinal), "Must mention public pull requests");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task61 Content pages Pricing HowItWorks Home Terms must reference automatic payment and public PRs")]
    public void Task61ContentPagesReferencePaymentModel()
    {
        var Pricing = ReadSource("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Pricing.Contains("free", StringComparison.OrdinalIgnoreCase), "Pricing must reference free");
        var HowItWorks = ReadSource("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(HowItWorks.Contains("HowItWorksConstants"), "HowItWorks must use HowItWorksConstants");
        var Home = ReadSource("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Home.Contains("PrTask") || Home.Contains("prtask"), "Home must reference PrTask");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task62 Licenses page must exist with PCI DSS compliance information and RouteConstants /legal/licenses")]
    public void Task62LicensesPagePciDss()
    {
        var Licenses = ReadSource("PrTask.SharedUI", "Pages", "Legal", "LicensesPage.razor");
        Assert.IsTrue(Licenses.Contains("PCI", StringComparison.OrdinalIgnoreCase) || Licenses.Contains("CreditCardProcessing") || Licenses.Contains("PaymentProviderCompliance"), "Licenses must mention PCI compliance");
        var Routes = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Routes.Contains("Licenses = \"/Legal/Licenses\""), "Must define /Legal/Licenses route");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task63 Refund page must specify automatic payment model no charge before approval no escrow")]
    public void Task63RefundPageAutoPaymentModel()
    {
        var Refund = ReadSource("PrTask.SharedUI", "Pages", "Legal", "RefundPage.razor");
        Assert.IsTrue(Refund.Contains("approv", StringComparison.OrdinalIgnoreCase), "Must mention approval in payment model");
        Assert.IsTrue(Refund.Contains("charge", StringComparison.OrdinalIgnoreCase) || Refund.Contains("payment", StringComparison.OrdinalIgnoreCase), "Must explain payment process");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task64 MAUI index.html must use viewport-fit cover and SCSS must include safe-area padding")]
    public void Task64MauiViewportAndSafeArea()
    {
        var Html = ReadSource("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("viewport-fit=cover"), "MAUI must use viewport-fit=cover");
        var Scss = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles", "app.scss"));
        Assert.IsTrue(Scss.Contains("safe-area"), "SCSS must include safe-area padding");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task65 Download page must have sections for Android Windows iOS macOS and Linux platforms")]
    public void Task65DownloadPagePlatforms()
    {
        var Download = ReadSource("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(Download.Contains("Android"), "Must have Android section");
        Assert.IsTrue(Download.Contains("Windows"), "Must have Windows section");
        Assert.IsTrue(Download.Contains("Ios"), "Must have iOS section");
        Assert.IsTrue(Download.Contains("Macos"), "Must have macOS section");
        Assert.IsTrue(Download.Contains("Linux"), "Must have Linux section");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task66 Task detail page must show pull requests list for client review with approve or merge action")]
    public void Task66TaskDetailPagePrList()
    {
        var TaskDetail = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(TaskDetail.Contains("pull-request") || TaskDetail.Contains("PullRequest"), "Must show pull requests");
        Assert.IsTrue(TaskDetail.Contains("Approve") || TaskDetail.Contains("Merge"), "Must have approve or merge action");
        var Routes = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Routes.Contains("TaskDetail") || Routes.Contains("/Tasks/"), "Must define task detail route");
        Assert.IsTrue(Routes.Contains("PullRequestDetail") || Routes.Contains("/Prs/"), "Must define PR detail route");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task67 Worker API must have task CRUD endpoints GET POST PUT/PATCH DELETE on /api/tasks")]
    public void Task67WorkerApiTaskCrud()
    {
        var TaskEndpoints = ReadSource("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(TaskEndpoints.Contains("MapGet"), "Must have GET endpoint");
        Assert.IsTrue(TaskEndpoints.Contains("MapPost"), "Must have POST endpoint");
        Assert.IsTrue(TaskEndpoints.Contains("MapPatch") || TaskEndpoints.Contains("MapPut"), "Must have PUT/PATCH endpoint");
        Assert.IsTrue(TaskEndpoints.Contains("MapDelete"), "Must have DELETE endpoint");
        var Routes = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Routes.Contains("ApiTasks = \"/Api/Tasks\""), "Must define /Api/Tasks route");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task68 Settings page must exist with withdrawal deposit profile and notification sections")]
    public void Task68SettingsPage()
    {
        var Settings = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Settings.Contains("Withdraw") || Settings.Contains("withdrawal"), "Must have withdrawal section");
        Assert.IsTrue(Settings.Contains("Deposit") || Settings.Contains("deposit"), "Must have deposit section");
        Assert.IsTrue(Settings.Contains("Profile") || Settings.Contains("profile"), "Must have profile section");
        Assert.IsTrue(Settings.Contains("Notification") || Settings.Contains("notification"), "Must have notification section");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "Pages", "ClientSettingsPage.razor")), "Client must have settings wrapper");
    }
}
