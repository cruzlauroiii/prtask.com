namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Deployment preview page must exist with route parameter for pr based deployment viewing")]
    public void DeploymentPreviewPageMustExistWithRouteParameterForPrBasedDeploymentViewing()
    {
        Assert.IsTrue(
            SourceFileExists("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor"),
            "DeploymentPreviewPage.razor must exist for clients and developers to view deployed changes");
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(
            Razor.Contains("DeploymentId", StringComparison.Ordinal),
            "Deployment preview page must accept a DeploymentId route parameter to identify the PR deployment");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Deployment preview page must have build status section showing deployment progress")]
    public void DeploymentPreviewPageMustHaveBuildStatusSectionShowingDeploymentProgress()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(
            Razor.Contains("Build Status", StringComparison.Ordinal),
            "Deployment preview page must show the build status of the deployment");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Deployment preview page must have live preview url link to view deployed changes")]
    public void DeploymentPreviewPageMustHaveLivePreviewUrlLinkToViewDeployedChanges()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(
            Razor.Contains("Preview", StringComparison.Ordinal),
            "Deployment preview page must have a Preview URL section");
        Assert.IsTrue(
            Razor.Contains("Live Preview", StringComparison.Ordinal) || Razor.Contains("Open", StringComparison.Ordinal),
            "Deployment preview page must have a link to open the live preview of deployed changes");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Deployment preview page must have deploy log section for build output")]
    public void DeploymentPreviewPageMustHaveDeployLogSectionForBuildOutput()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(
            Razor.Contains("Deploy Log", StringComparison.Ordinal) || Razor.Contains("Deployment log", StringComparison.Ordinal),
            "Deployment preview page must have a Deploy Log section showing build output");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define deployment preview route with parameter placeholder")]
    public void RouteConstantsMustDefineDeploymentPreviewRouteWithParameterPlaceholder()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(
            Code.Contains("DeploymentPreview", StringComparison.Ordinal),
            "RouteConstants must define a DeploymentPreview route");
        Assert.IsTrue(
            Code.Contains("deployments", StringComparison.OrdinalIgnoreCase),
            "DeploymentPreview route must use /deployments/ path segment");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Deployment preview page route must accept deployment identifier parameter")]
    public void DeploymentPreviewPageRouteMustAcceptDeploymentIdentifierParameter()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(
            Razor.Contains("@page", StringComparison.Ordinal),
            "Deployment preview page must have a @page directive");
        Assert.IsTrue(
            Razor.Contains("{DeploymentId}", StringComparison.Ordinal),
            "Deployment preview page route must include {DeploymentId} parameter");
        Assert.IsTrue(
            Razor.Contains("[Parameter]", StringComparison.Ordinal),
            "DeploymentId must be marked as a [Parameter] property for Blazor routing");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Deployment preview page must generate unique preview url per pull request like vercel and netlify")]
    public void DeploymentPreviewPageMustGenerateUniquePreviewUrlPerPullRequestLikeVercelAndNetlify()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(
            Razor.Contains("deploy-preview", StringComparison.OrdinalIgnoreCase)
            || Razor.Contains("pages.dev", StringComparison.OrdinalIgnoreCase),
            "Deployment preview must generate a unique URL per PR (deploy-preview-{id}--project.pages.dev pattern)");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Deployment preview page must show deployment details with branch and environment info")]
    public void DeploymentPreviewPageMustShowDeploymentDetailsWithBranchAndEnvironmentInfo()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(
            Razor.Contains("Branch", StringComparison.Ordinal) || Razor.Contains("branch", StringComparison.Ordinal),
            "Deployment preview must show the branch name associated with the PR");
        Assert.IsTrue(
            Razor.Contains("Environment", StringComparison.Ordinal) || Razor.Contains("Preview", StringComparison.Ordinal),
            "Deployment preview must indicate the environment type (Preview vs Production)");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Deployment preview page must reference cloudflare pages as hosting platform")]
    public void DeploymentPreviewPageMustReferenceCloudflarePageAsHostingPlatform()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(
            Razor.Contains("Cloudflare", StringComparison.Ordinal),
            "Deployment preview must reference Cloudflare Pages as the hosting platform");
    }
}
