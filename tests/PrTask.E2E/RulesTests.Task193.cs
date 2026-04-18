namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RulesTests base class has CDP browser init and navigation helpers")]
    public void RulesTestsBaseClassHasCdpInfrastructure()
    {
        var Source = File.ReadAllText(Path.Combine(SourceRoot, "..", "tests", "PrTask.E2E", "RulesTests.cs"));
        Assert.IsTrue(Source.Contains("ChromeLauncher"),
            "Base class must have ChromeLauncher field");
        Assert.IsTrue(Source.Contains("CdpBrowser"),
            "Base class must have CdpBrowser field");
        Assert.IsTrue(Source.Contains("LaunchAsync"),
            "Base class must launch headless Chrome in ClassInitialize");
        Assert.IsTrue(Source.Contains("NavigateOrSkipAsync"),
            "Base class must define NavigateOrSkipAsync helper");
        var Guards = File.ReadAllText(Path.Combine(SourceRoot, "..", "tests", "PrTask.E2E", "RulesTests.Guards.cs"));
        Assert.IsTrue(Guards.Contains("GetOrSkipAsync"),
            "Guards partial class must define GetOrSkipAsync for API tests");
        Assert.IsTrue(Source.Contains("WaitForLoadAsync"),
            "NavigateOrSkipAsync must wait for page load");
        Assert.IsTrue(Source.Contains("Assert.Fail"),
            "Navigation failures must use Assert.Fail to stop immediately");
    }
}
