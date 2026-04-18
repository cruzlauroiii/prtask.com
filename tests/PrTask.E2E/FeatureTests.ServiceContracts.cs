namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request service interface must define submit approve reject and query methods for pr workflow")]
    public void PullRequestServiceInterfaceMustDefineSubmitApproveRejectAndQueryMethodsForPrWorkflow()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IPullRequestService.cs");
        Assert.IsTrue(Code.Contains("SubmitAsync", StringComparison.Ordinal), "IPullRequestService must have SubmitAsync for PR creation");
        Assert.IsTrue(Code.Contains("ApproveAsync", StringComparison.Ordinal), "IPullRequestService must have ApproveAsync for client approval");
        Assert.IsTrue(Code.Contains("RejectAsync", StringComparison.Ordinal), "IPullRequestService must have RejectAsync for client rejection");
        Assert.IsTrue(Code.Contains("GetByIdAsync", StringComparison.Ordinal), "IPullRequestService must have GetByIdAsync for PR lookup");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request service interface must have list by developer and list by task query methods")]
    public void PullRequestServiceInterfaceMustHaveListByDeveloperAndListByTaskQueryMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IPullRequestService.cs");
        Assert.IsTrue(Code.Contains("ListByDeveloperAsync", StringComparison.Ordinal), "IPullRequestService must list PRs by developer");
        Assert.IsTrue(Code.Contains("ListByTaskAsync", StringComparison.Ordinal), "IPullRequestService must list PRs by task");
        Assert.IsTrue(Code.Contains("ExistsAsync", StringComparison.Ordinal), "IPullRequestService must check PR existence");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task service interface must define create claim update delete and query methods for task lifecycle")]
    public void TaskServiceInterfaceMustDefineCreateClaimUpdateDeleteAndQueryMethodsForTaskLifecycle()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "ITaskService.cs");
        Assert.IsTrue(Code.Contains("CreateAsync", StringComparison.Ordinal), "ITaskService must have CreateAsync for task creation");
        Assert.IsTrue(Code.Contains("ClaimAsync", StringComparison.Ordinal), "ITaskService must have ClaimAsync for developer assignment");
        Assert.IsTrue(Code.Contains("UpdateAsync", StringComparison.Ordinal), "ITaskService must have UpdateAsync for task modification");
        Assert.IsTrue(Code.Contains("DeleteAsync", StringComparison.Ordinal), "ITaskService must have DeleteAsync for task removal");
        Assert.IsTrue(Code.Contains("ListOpenAsync", StringComparison.Ordinal), "ITaskService must have ListOpenAsync for browsing");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui index html must have theme toggle and theme persistence javascript functions defined")]
    public void MauiIndexHtmlMustHaveThemeToggleAndThemePersistenceJavascriptFunctionsDefined()
    {
        var Html = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("prtaskToggleTheme", StringComparison.Ordinal), "MAUI index.html must define prtaskToggleTheme function");
        Assert.IsTrue(Html.Contains("prtaskGetTheme", StringComparison.Ordinal), "MAUI index.html must define prtaskGetTheme function");
        Assert.IsTrue(Html.Contains("data-theme", StringComparison.Ordinal), "MAUI must use data-theme attribute for theme switching");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui index html must have viewport fit cover and maximum scale for mobile display")]
    public void MauiIndexHtmlMustHaveViewportFitCoverAndMaximumScaleForMobileDisplay()
    {
        var Html = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("viewport-fit=cover", StringComparison.Ordinal), "MAUI viewport must use viewport-fit=cover for safe area");
        Assert.IsTrue(Html.Contains("maximum-scale=1.0", StringComparison.Ordinal), "MAUI viewport must prevent zoom for app-like experience");
        Assert.IsTrue(Html.Contains("user-scalable=no", StringComparison.Ordinal), "MAUI viewport must disable user scaling");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui index html must load blazor webview js with autostart false for manual initialization")]
    public void MauiIndexHtmlMustLoadBlazorWebviewJsWithAutostartFalseForManualInitialization()
    {
        var Html = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("blazor.webview.js", StringComparison.Ordinal), "MAUI must load blazor.webview.js for hybrid hosting");
        Assert.IsTrue(Html.Contains("autostart=\"false\"", StringComparison.Ordinal), "MAUI must use autostart=false for controlled initialization");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui auth check function must use credentials include for cross origin cookie authentication")]
    public void MauiAuthCheckFunctionMustUseCredentialsIncludeForCrossOriginCookieAuthentication()
    {
        var Html = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("credentials", StringComparison.Ordinal), "MAUI prtaskCheckAuth must include credentials");
        Assert.IsTrue(Html.Contains("prtask.com/api/auth/me", StringComparison.Ordinal), "MAUI must call prtask.com auth endpoint directly");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client index html must load blazor webassembly js for wasm based component rendering")]
    public void ClientIndexHtmlMustLoadBlazorWebAssemblyJsForWasmBasedComponentRendering()
    {
        var Html = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("blazor.webassembly.js", StringComparison.Ordinal), "Client must load blazor.webassembly.js for WASM hosting");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Both index html files must reference shared ui app css stylesheet for consistent styling")]
    public void BothIndexHtmlFilesMustReferenceSharedUiAppCssStylesheetForConsistentStyling()
    {
        var MauiHtml = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        var ClientHtml = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(MauiHtml.Contains("_content/PrTask.SharedUI/css/app.css", StringComparison.Ordinal), "MAUI must reference SharedUI CSS");
        Assert.IsTrue(ClientHtml.Contains("_content/PrTask.SharedUI/css/app.css", StringComparison.Ordinal), "Client must reference SharedUI CSS");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Both index html files must define theme functions with local storage persistence for dark mode")]
    public void BothIndexHtmlFilesMustDefineThemeFunctionsWithLocalStoragePersistenceForDarkMode()
    {
        var MauiHtml = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        var ClientHtml = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(MauiHtml.Contains("prtask-theme", StringComparison.Ordinal), "MAUI must use prtask-theme localStorage key");
        Assert.IsTrue(ClientHtml.Contains("prtask-theme", StringComparison.Ordinal), "Client must use prtask-theme localStorage key");
    }
}
