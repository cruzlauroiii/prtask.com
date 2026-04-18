namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App razor must declare doctype html with lang en attribute and utf eight charset meta tag")]
    public void AppRazorMustDeclareDoctypeHtmlWithLangEnAttributeAndUtfEightCharsetMetaTag()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "App.razor");
        Assert.IsTrue(Code.Contains("<!DOCTYPE html>", StringComparison.Ordinal), "App.razor must declare DOCTYPE html");
        Assert.IsTrue(Code.Contains("lang=\"en\"", StringComparison.Ordinal), "App.razor must set lang to en");
        Assert.IsTrue(Code.Contains("charset=\"utf-8\"", StringComparison.Ordinal), "App.razor must set charset to utf-8");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App razor must set viewport meta width device width and initial scale one for responsive layout")]
    public void AppRazorMustSetViewportMetaWidthDeviceWidthAndInitialScaleOneForResponsiveLayout()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "App.razor");
        Assert.IsTrue(Code.Contains("width=device-width, initial-scale=1.0", StringComparison.Ordinal), "App.razor must set viewport width and scale");
        Assert.IsTrue(Code.Contains("<title>PrTask - Earn Money with Pull Requests</title>", StringComparison.Ordinal), "App.razor must have proper page title");
        Assert.IsTrue(Code.Contains("base href=\"/\"", StringComparison.Ordinal), "App.razor must set base href to root");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App razor must link shared ui css and include head outlet and blazor web js script tag")]
    public void AppRazorMustLinkSharedUiCssAndIncludeHeadOutletAndBlazorWebJsScriptTag()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "App.razor");
        Assert.IsTrue(Code.Contains("_content/PrTask.SharedUI/css/app.css", StringComparison.Ordinal), "App.razor must link SharedUI CSS file");
        Assert.IsTrue(Code.Contains("<HeadOutlet />", StringComparison.Ordinal), "App.razor must include HeadOutlet component");
        Assert.IsTrue(Code.Contains("<Routes />", StringComparison.Ordinal), "App.razor must include Routes component");
        Assert.IsTrue(Code.Contains("_framework/blazor.web.js", StringComparison.Ordinal), "App.razor must include blazor.web.js script");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Routes razor must use router with app assembly and main layout as default layout type")]
    public void RoutesRazorMustUseRouterWithAppAssemblyAndMainLayoutAsDefaultLayoutType()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "Routes.razor");
        Assert.IsTrue(Code.Contains("typeof(Routes).Assembly", StringComparison.Ordinal), "Routes must use typeof(Routes).Assembly for AppAssembly");
        Assert.IsTrue(Code.Contains("DefaultLayout=\"typeof(MainLayout)\"", StringComparison.Ordinal), "Routes must set MainLayout as default layout");
        Assert.IsTrue(Code.Contains("FocusOnNavigate", StringComparison.Ordinal), "Routes must include FocusOnNavigate for accessibility");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Routes razor must define not found template with page not found heading in main layout view")]
    public void RoutesRazorMustDefineNotFoundTemplateWithPageNotFoundHeadingInMainLayoutView()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "Routes.razor");
        Assert.IsTrue(Code.Contains("<NotFound>", StringComparison.Ordinal), "Routes must define NotFound template");
        Assert.IsTrue(Code.Contains("Page Not Found", StringComparison.Ordinal), "Routes must show Page Not Found heading");
        Assert.IsTrue(Code.Contains("LayoutView Layout=\"typeof(MainLayout)\"", StringComparison.Ordinal), "NotFound must use MainLayout");
        Assert.IsTrue(Code.Contains("Selector=\"h1\"", StringComparison.Ordinal), "FocusOnNavigate must target h1 selector");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main layout must inherit layout component base and render nav menu with page content main tag")]
    public void MainLayoutMustInheritLayoutComponentBaseAndRenderNavMenuWithPageContentMainTag()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "MainLayout.razor");
        Assert.IsTrue(Code.Contains("@inherits LayoutComponentBase", StringComparison.Ordinal), "MainLayout must inherit LayoutComponentBase");
        Assert.IsTrue(Code.Contains("<NavMenu />", StringComparison.Ordinal), "MainLayout must render NavMenu component");
        Assert.IsTrue(Code.Contains("class=\"page-content\"", StringComparison.Ordinal), "MainLayout must use page-content class on main");
        Assert.IsTrue(Code.Contains("@Body", StringComparison.Ordinal), "MainLayout must render Body content");
    }
}
