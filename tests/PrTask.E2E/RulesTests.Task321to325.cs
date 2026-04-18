using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("JsInteropConstants has all JS function names")]
    public void JsInteropConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "JsInteropConstants.cs");
        Assert.IsTrue(Source.Contains("prtaskGetUserId"), "Has GetUserId");
        Assert.IsTrue(Source.Contains("prtaskCheckAuth"), "Has CheckAuth");
        Assert.IsTrue(Source.Contains("prtaskGetTheme"), "Has GetTheme");
        Assert.IsTrue(Source.Contains("prtaskToggleTheme"), "Has ToggleTheme");
        Assert.IsTrue(Source.Contains("prtaskSignOut"), "Has SignOut");
        Assert.IsTrue(Source.Contains("prtaskCloseMenu"), "Has CloseMenu");
        Assert.IsTrue(Source.Contains("prtaskToggleMenu"), "Has ToggleMenu");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Client index.html stores userId in localStorage")]
    public void ClientIndexStoresUserId()
    {
        var Source = ReadSource("PrTask.Client", "wwwroot", "index.html");
        var CoreJs = File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "Js", "prtask-core.js"))
            ? File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "Js", "prtask-core.js"))
            : string.Empty;
        var Combined = Source + CoreJs;
        Assert.IsTrue(Combined.Contains("prtaskGetUserId"), "Has prtaskGetUserId function");
        Assert.IsTrue(Combined.Contains("prtaskSetUserId"), "Has prtaskSetUserId function");
        Assert.IsTrue(Combined.Contains("prtask-userid"), "Stores userid in localStorage");
        Assert.IsTrue(Combined.Contains("U.userId") || Combined.Contains("userId"), "Stores userId from auth/me response");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MAUI index.html has prtaskGetUserId function")]
    public void MauiIndexHasGetUserId()
    {
        var Source = ReadSource("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(Source.Contains("prtaskGetUserId"), "Has prtaskGetUserId function");
        Assert.IsTrue(Source.Contains("prtaskSetUserId"), "Has prtaskSetUserId function");
        Assert.IsTrue(Source.Contains("prtask-userid"), "Stores userid in localStorage");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("App.razor has prtaskGetUserId function")]
    public void AppRazorHasGetUserId()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "App.razor");
        Assert.IsTrue(Source.Contains("prtaskGetUserId"), "Has prtaskGetUserId function");
        Assert.IsTrue(Source.Contains("prtask-userid"), "Stores userid in localStorage");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("No current-user hardcoded in Razor pages")]
    public void NoCurrentUserHardcoded()
    {
        var PagesDir = Path.Combine(SourceRoot, "PrTask.SharedUI", "Pages");
        var AllRazorFiles = Directory.GetFiles(PagesDir, "*.razor", SearchOption.AllDirectories);
        foreach (var FilePath in AllRazorFiles)
        {
            var Content = File.ReadAllText(FilePath);
            Assert.IsFalse(Content.Contains("\"current-user\""),
                $"File {Path.GetFileName(FilePath)} must not contain hardcoded current-user");
        }
    }
}
