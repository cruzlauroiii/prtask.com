namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App scss must have styles for pr detail page diff viewer and file tree")]
    public void AppScssMustHaveStylesForPrDetailPageDiffViewerAndFileTree()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "app.scss");
        Assert.IsTrue(Scss.Contains(".diff-viewer", StringComparison.Ordinal), "SCSS must have .diff-viewer styles");
        Assert.IsTrue(Scss.Contains(".diff-file-tree", StringComparison.Ordinal), "SCSS must have .diff-file-tree styles");
        Assert.IsTrue(Scss.Contains(".diff-line", StringComparison.Ordinal), "SCSS must have .diff-line styles");
        Assert.IsTrue(Scss.Contains(".line-add", StringComparison.Ordinal), "SCSS must have .line-add styles for added lines");
        Assert.IsTrue(Scss.Contains(".line-del", StringComparison.Ordinal), "SCSS must have .line-del styles for deleted lines");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App scss must have styles for pr card list and task owner action buttons")]
    public void AppScssMustHaveStylesForPrCardListAndTaskOwnerActionButtons()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "app.scss");
        Assert.IsTrue(Scss.Contains(".pr-card", StringComparison.Ordinal), "SCSS must have .pr-card styles for PR list items");
        Assert.IsTrue(Scss.Contains(".pr-actions", StringComparison.Ordinal), "SCSS must have .pr-actions styles");
        Assert.IsTrue(Scss.Contains(".task-owner-actions", StringComparison.Ordinal), "SCSS must have .task-owner-actions styles");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App scss must have styles for deployment preview status and info sections")]
    public void AppScssMustHaveStylesForDeploymentPreviewStatusAndInfoSections()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "app.scss");
        Assert.IsTrue(Scss.Contains(".deployment-status", StringComparison.Ordinal), "SCSS must have .deployment-status styles");
        Assert.IsTrue(Scss.Contains(".deployment-info", StringComparison.Ordinal), "SCSS must have .deployment-info styles");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App scss must have responsive mobile styles for diff layout and pr actions")]
    public void AppScssMustHaveResponsiveMobileStylesForDiffLayoutAndPrActions()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "app.scss");
        Assert.IsTrue(
            Scss.Contains(".diff-layout", StringComparison.Ordinal),
            "SCSS must have .diff-layout styles with responsive column layout on mobile");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App scss must have line number styles for diff code reference and navigation")]
    public void AppScssMustHaveLineNumberStylesForDiffCodeReferenceAndNavigation()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "app.scss");
        Assert.IsTrue(Scss.Contains(".line-number", StringComparison.Ordinal), "SCSS must have .line-number styles");
        Assert.IsTrue(Scss.Contains("$font-mono", StringComparison.Ordinal), "SCSS must use monospace font for code display");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App scss must have connected status and nav user styles for auth state display")]
    public void AppScssMustHaveConnectedStatusAndNavUserStylesForAuthStateDisplay()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "app.scss");
        Assert.IsTrue(Scss.Contains(".connected-status", StringComparison.Ordinal), "SCSS must have .connected-status styles for settings page");
        Assert.IsTrue(Scss.Contains(".nav-user", StringComparison.Ordinal), "SCSS must have .nav-user styles for authenticated username display");
    }
}
