namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MAUI APK status bar spacing, unified hamburger menu, and working navigation")]
    public void Task79MauiStatusBarAndNavigation()
    {
        var MainPageCs = ReadSource("PrTask.Maui", "MainPage.xaml.cs");
        Assert.IsTrue(MainPageCs.Contains(AppConstants.AndroidStatusBarResource) || MainPageCs.Contains("Padding"),
            "MainPage must apply status bar padding to prevent notification bar overlap");
        Assert.IsTrue(MainPageCs.Contains("OnAppearing") || MainPageCs.Contains("OnSafeAreaChanged"),
            "MainPage must handle status bar spacing in lifecycle method");
        var MauiProgram = ReadSource("PrTask.Maui", "MauiProgram.cs");
        Assert.IsFalse(MauiProgram.Contains("SetDecorFitsSystemWindows"),
            "Must not use SetDecorFitsSystemWindows — use ContentPage padding instead");
        var NavMenu = ReadSource("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(NavMenu.Contains("NavigationManager") || NavMenu.Contains("Nav.NavigateTo"),
            "NavMenu must use NavigationManager for WASM and MAUI compatibility");
        Assert.IsTrue(NavMenu.Contains("@onclick:preventDefault"),
            "NavMenu links must use @onclick:preventDefault with NavigationManager.NavigateTo");
        Assert.IsFalse(NavMenu.Contains("onclick=\"var l=document"),
            "NavMenu must not use raw HTML onclick handlers");
        var MauiLayout = ReadSource("PrTask.Maui", "Components", "MauiLayout.razor");
        Assert.IsFalse(MauiLayout.Contains("maui-auth-bar"),
            "MauiLayout must not have a separate auth bar — auth goes in NavMenu hamburger");
        Assert.IsFalse(MauiLayout.Contains("nav-logout"),
            "MauiLayout must not render logout outside NavMenu");
        var MauiIndex = ReadSource("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(MauiIndex.Contains("prtaskCloseMenu"),
            "MAUI index.html must define prtaskCloseMenu function");
        Assert.IsTrue(MauiIndex.Contains("prtaskToggleMenu"),
            "MAUI index.html must define prtaskToggleMenu function");
        Assert.IsTrue(MauiIndex.Contains("viewport-fit=cover"),
            "MAUI index.html must use viewport-fit=cover");
        var MauiPages = Directory.EnumerateFiles(
            Path.Combine(SourceRoot, "PrTask.Maui", "Pages"), "*.razor", SearchOption.AllDirectories).ToList();
        var NavRoutes = new[] { "/tasks", "/leaderboard", "/how-it-works", "/pricing", "/about", "/dashboard", "/download", "/settings", "/login" };
        foreach (var Route in NavRoutes)
        {
            Assert.IsTrue(MauiPages.Any(P =>
            {
                var Content = File.ReadAllText(P);
                return Content.Contains($"@page \"{Route}\"");
            }), $"MAUI must have a page for route {Route}");
        }
    }
}
