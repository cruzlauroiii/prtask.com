using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LoginConstants has all SSO and page text constants")]
    public void LoginConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "LoginConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.SeoTitle)), "Has SeoTitle");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.SeoDescription)), "Has SeoDescription");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.PageDescription)), "Has PageDescription");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.SignInWithGoogle)), "Has SignInWithGoogle");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.SignInWithGitHub)), "Has SignInWithGitHub");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.SignInWithMicrosoft)), "Has SignInWithMicrosoft");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.SignInWithOkta)), "Has SignInWithOkta");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.DevelopersHeading)), "Has DevelopersHeading");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.DevelopersDescription)), "Has DevelopersDescription");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.ClientsHeading)), "Has ClientsHeading");
        Assert.IsTrue(Source.Contains(nameof(LoginConstants.ClientsDescription)), "Has ClientsDescription");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LoginPage uses LoginConstants for all UI text")]
    public void LoginPageUsesLoginConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Source.Contains("LoginConstants.SeoTitle"), "Uses SeoTitle");
        Assert.IsTrue(Source.Contains("LoginConstants.SeoDescription"), "Uses SeoDescription");
        Assert.IsTrue(Source.Contains("LoginConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("LoginConstants.PageDescription"), "Uses PageDescription");
        Assert.IsTrue(Source.Contains("LoginConstants.SignInWithGoogle"), "Uses SignInWithGoogle");
        Assert.IsTrue(Source.Contains("LoginConstants.SignInWithGitHub"), "Uses SignInWithGitHub");
        Assert.IsTrue(Source.Contains("LoginConstants.SignInWithMicrosoft"), "Uses SignInWithMicrosoft");
        Assert.IsTrue(Source.Contains("LoginConstants.SignInWithOkta"), "Uses SignInWithOkta");
        Assert.IsFalse(Source.Contains("\"Sign in with"), "No hardcoded SSO button text");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HowItWorksConstants has all step workflow and status constants")]
    public void HowItWorksConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "HowItWorksConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(HowItWorksConstants.SeoTitle)), "Has SeoTitle");
        Assert.IsTrue(Source.Contains(nameof(HowItWorksConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(HowItWorksConstants.Step1Heading)), "Has Step1Heading");
        Assert.IsTrue(Source.Contains(nameof(HowItWorksConstants.Step5Description)), "Has Step5Description");
        Assert.IsTrue(Source.Contains(nameof(HowItWorksConstants.ForClientsHeading)), "Has ForClientsHeading");
        Assert.IsTrue(Source.Contains(nameof(HowItWorksConstants.ForClientsStep1)), "Has ForClientsStep1");
        Assert.IsTrue(Source.Contains(nameof(HowItWorksConstants.WorkflowGuideHeading)), "Has WorkflowGuideHeading");
        Assert.IsTrue(Source.Contains(nameof(HowItWorksConstants.StatusLoginRequired)), "Has StatusLoginRequired");
        Assert.IsTrue(Source.Contains(nameof(HowItWorksConstants.Workflow1Heading)), "Has Workflow1Heading");
        Assert.IsTrue(Source.Contains(nameof(HowItWorksConstants.Workflow14LinkText)), "Has Workflow14LinkText");
        Assert.IsTrue(Source.Contains(nameof(HowItWorksConstants.Workflow12PaymentsLinkText)), "Has Workflow12PaymentsLinkText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HowItWorks page uses HowItWorksConstants for all UI text")]
    public void HowItWorksPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Source.Contains("HowItWorksConstants.SeoTitle"), "Uses SeoTitle");
        Assert.IsTrue(Source.Contains("HowItWorksConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("HowItWorksConstants.Step1Heading"), "Uses Step1Heading");
        Assert.IsTrue(Source.Contains("HowItWorksConstants.Step2Description"), "Uses Step2Description");
        Assert.IsTrue(Source.Contains("HowItWorksConstants.ForClientsHeading"), "Uses ForClientsHeading");
        Assert.IsTrue(Source.Contains("HowItWorksConstants.ForClientsStep1"), "Uses ForClientsStep1");
        Assert.IsTrue(Source.Contains("HowItWorksConstants.WorkflowGuideHeading"), "Uses WorkflowGuideHeading");
        Assert.IsTrue(Source.Contains("HowItWorksConstants.Workflow1Heading"), "Uses Workflow1Heading");
        Assert.IsTrue(Source.Contains("HowItWorksConstants.Workflow14LinkText"), "Uses Workflow14LinkText");
        Assert.IsFalse(Source.Contains("\"How It Works\""), "No hardcoded page heading");
        Assert.IsFalse(Source.Contains("\"For Clients\""), "No hardcoded For Clients heading");
        Assert.IsFalse(Source.Contains("\"Workflow Guide\""), "No hardcoded Workflow Guide heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DeploymentPreviewConstants has all display text constants")]
    public void DeploymentPreviewConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DeploymentPreviewConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(DeploymentPreviewConstants.SeoTitle)), "Has SeoTitle");
        Assert.IsTrue(Source.Contains(nameof(DeploymentPreviewConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(DeploymentPreviewConstants.BuildStatusHeading)), "Has BuildStatusHeading");
        Assert.IsTrue(Source.Contains(nameof(DeploymentPreviewConstants.PreviewUrlHeading)), "Has PreviewUrlHeading");
        Assert.IsTrue(Source.Contains(nameof(DeploymentPreviewConstants.OpenLivePreviewText)), "Has OpenLivePreviewText");
        Assert.IsTrue(Source.Contains(nameof(DeploymentPreviewConstants.DetailsHeading)), "Has DetailsHeading");
        Assert.IsTrue(Source.Contains(nameof(DeploymentPreviewConstants.BranchLabel)), "Has BranchLabel");
        Assert.IsTrue(Source.Contains(nameof(DeploymentPreviewConstants.EnvironmentLabel)), "Has EnvironmentLabel");
        Assert.IsTrue(Source.Contains(nameof(DeploymentPreviewConstants.PlatformLabel)), "Has PlatformLabel");
        Assert.IsTrue(Source.Contains(nameof(DeploymentPreviewConstants.FilesChangedLabel)), "Has FilesChangedLabel");
        Assert.IsTrue(Source.Contains(nameof(DeploymentPreviewConstants.DeployLogHeading)), "Has DeployLogHeading");
    }
}
