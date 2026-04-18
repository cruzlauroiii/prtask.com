namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main page xaml must define content page with maui and xaml xml namespace declarations")]
    public void MainPageXamlMustDefineContentPageWithMauiAndXamlXmlNamespaceDeclarations()
    {
        var Xaml = ReadSourceFile("PrTask.Maui", "MainPage.xaml");
        Assert.IsTrue(Xaml.Contains("<?xml version=\"1.0\" encoding=\"utf-8\" ?>", StringComparison.Ordinal), "MainPage.xaml must have XML declaration");
        Assert.IsTrue(Xaml.Contains("xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"", StringComparison.Ordinal), "MainPage must use MAUI namespace");
        Assert.IsTrue(Xaml.Contains("xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"", StringComparison.Ordinal), "MainPage must use XAML namespace");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main page xaml must reference prtask maui local namespace with clr namespace declaration")]
    public void MainPageXamlMustReferencePrtaskMauiLocalNamespaceWithClrNamespaceDeclaration()
    {
        var Xaml = ReadSourceFile("PrTask.Maui", "MainPage.xaml");
        Assert.IsTrue(Xaml.Contains("xmlns:local=\"clr-namespace:PrTask.Maui\"", StringComparison.Ordinal), "MainPage must define local namespace pointing to PrTask.Maui");
        Assert.IsTrue(Xaml.Contains("x:Class=\"PrTask.Maui.MainPage\"", StringComparison.Ordinal), "MainPage must set x:Class to PrTask.Maui.MainPage");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main page xaml must name blazor web view and bind url loading to on url loading handler")]
    public void MainPageXamlMustNameBlazorWebViewAndBindUrlLoadingToOnUrlLoadingHandler()
    {
        var Xaml = ReadSourceFile("PrTask.Maui", "MainPage.xaml");
        Assert.IsTrue(Xaml.Contains("x:Name=\"BlazorWebView\"", StringComparison.Ordinal), "BlazorWebView must have x:Name attribute");
        Assert.IsTrue(Xaml.Contains("UrlLoading=\"OnUrlLoading\"", StringComparison.Ordinal), "BlazorWebView must handle UrlLoading event");
        Assert.IsTrue(Xaml.Contains("HostPage=\"wwwroot/index.html\"", StringComparison.Ordinal), "BlazorWebView must use wwwroot/index.html as host");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main page xaml root component must use hash app selector with local routes component type")]
    public void MainPageXamlRootComponentMustUseHashAppSelectorWithLocalRoutesComponentType()
    {
        var Xaml = ReadSourceFile("PrTask.Maui", "MainPage.xaml");
        Assert.IsTrue(Xaml.Contains("Selector=\"#app\"", StringComparison.Ordinal), "RootComponent must target #app CSS selector");
        Assert.IsTrue(Xaml.Contains("ComponentType=\"{x:Type local:Routes}\"", StringComparison.Ordinal), "RootComponent must use Routes from local namespace");
        Assert.IsTrue(Xaml.Contains("<BlazorWebView.RootComponents>", StringComparison.Ordinal), "MainPage must define RootComponents collection");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main page xaml must be content page wrapping single blazor web view without additional controls")]
    public void MainPageXamlMustBeContentPageWrappingSingleBlazorWebViewWithoutAdditionalControls()
    {
        var Xaml = ReadSourceFile("PrTask.Maui", "MainPage.xaml");
        Assert.IsTrue(Xaml.Contains("<ContentPage", StringComparison.Ordinal), "MainPage must use ContentPage as root element");
        Assert.IsTrue(Xaml.Contains("</ContentPage>", StringComparison.Ordinal), "MainPage must close ContentPage element");
        var Lines = Xaml.Split('\n');
        Assert.IsTrue(Lines.Length <= 15, $"MainPage.xaml must be concise (found {Lines.Length} lines)");
    }
}
