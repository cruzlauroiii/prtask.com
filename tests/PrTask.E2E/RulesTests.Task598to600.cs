using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MainLayout wraps Body in ErrorBoundary with AppConstants")]
    public void MainLayoutWrapsBodyInErrorBoundary()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "MainLayout.razor");
        Assert.IsTrue(Source.Contains("ErrorBoundary"),
            "MainLayout must use ErrorBoundary component");
        Assert.IsTrue(Source.Contains("ChildContent"),
            "MainLayout ErrorBoundary must have ChildContent section");
        Assert.IsTrue(Source.Contains("ErrorContent"),
            "MainLayout ErrorBoundary must have ErrorContent section");
        Assert.IsTrue(Source.Contains(nameof(AppConstants) + "." + nameof(AppConstants.ErrorBoundaryTitle)),
            "MainLayout must use AppConstants.ErrorBoundaryTitle");
        Assert.IsTrue(Source.Contains(nameof(AppConstants) + "." + nameof(AppConstants.ErrorBoundaryMessage)),
            "MainLayout must use AppConstants.ErrorBoundaryMessage");
        Assert.IsTrue(Source.Contains(nameof(AppConstants) + "." + nameof(AppConstants.ErrorBoundaryRetryText)),
            "MainLayout must use AppConstants.ErrorBoundaryRetryText");
        Assert.IsTrue(Source.Contains("Recover"),
            "MainLayout must call ErrorBoundary.Recover for retry");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("AppConstants defines ErrorBoundary text constants")]
    public void AppConstantsDefinesErrorBoundaryText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Source.Contains("ErrorBoundaryTitle"),
            "AppConstants must define ErrorBoundaryTitle");
        Assert.IsTrue(Source.Contains("ErrorBoundaryMessage"),
            "AppConstants must define ErrorBoundaryMessage");
        Assert.IsTrue(Source.Contains("ErrorBoundaryRetryText"),
            "AppConstants must define ErrorBoundaryRetryText");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("SCSS defines all CSS classes referenced in razor files")]
    public void ScssDefinesAllCssClassesReferencedInRazorFiles()
    {
        var ScssSource = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles", "app.scss"));
        var RequiredClasses = new[]
        {
            "status-message", "status-login-required", "status-required", "status-open",
            "step-content", "step-links", "board-header", "board-column",
            "task-filters", "task-count", "amount", "developer", "tasks-posted",
            "prs", "featured", "file-size", "footer-logo", "google-login",
            "review-comment", "error-boundary"
        };
        var Missing = new List<string>();
        foreach (var ClassName in RequiredClasses)
        {
            if (!ScssSource.Contains("." + ClassName))
            {
                Missing.Add(ClassName);
            }
        }
        Assert.AreEqual(0, Missing.Count,
            string.Format("SCSS missing class definitions: {0}", string.Join(", ", Missing)));
    }
}
