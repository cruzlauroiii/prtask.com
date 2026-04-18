namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must enable trim aot and single file analyzers for all projects")]
    public void DirectoryBuildPropsMustEnableTrimAotAndSingleFileAnalyzersForAllProjects()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("EnableTrimAnalyzer>true", StringComparison.Ordinal), "Build props must enable trim analyzer");
        Assert.IsTrue(Props.Contains("EnableAotAnalyzer>true", StringComparison.Ordinal), "Build props must enable AOT analyzer");
        Assert.IsTrue(Props.Contains("EnableSingleFileAnalyzer>true", StringComparison.Ordinal), "Build props must enable single file analyzer");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must conditionally set android sdk directory when work android sdk path exists")]
    public void DirectoryBuildPropsMustConditionallySetAndroidSdkDirectoryWhenWorkAndroidSdkPathExists()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("AndroidSdkDirectory", StringComparison.Ordinal), "Build props must define AndroidSdkDirectory property");
        Assert.IsTrue(Props.Contains("Condition=\"Exists('C:\\work\\android-sdk')\"", StringComparison.Ordinal), "AndroidSdkDirectory must have Exists condition");
        Assert.IsTrue(Props.Contains(">C:\\work\\android-sdk<", StringComparison.Ordinal), "AndroidSdkDirectory must point to C:\\work\\android-sdk");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must conditionally set java sdk directory when work jdk path exists")]
    public void DirectoryBuildPropsMustConditionallySetJavaSdkDirectoryWhenWorkJdkPathExists()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("JavaSdkDirectory", StringComparison.Ordinal), "Build props must define JavaSdkDirectory property");
        Assert.IsTrue(Props.Contains("Condition=\"Exists('C:\\work\\jdk')\"", StringComparison.Ordinal), "JavaSdkDirectory must have Exists condition");
        Assert.IsTrue(Props.Contains(">C:\\work\\jdk<", StringComparison.Ordinal), "JavaSdkDirectory must point to C:\\work\\jdk");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must specify stylecop analyzers version one point two point zero beta five five six")]
    public void DirectoryBuildPropsMustSpecifyStylecopAnalyzersVersionOnePointTwoPointZeroBetaFiveFiveSix()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("\"StyleCop.Analyzers\" Version=\"1.2.0-beta.556\"", StringComparison.Ordinal), "StyleCop.Analyzers must be version 1.2.0-beta.556");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must specify roslynator analyzers version four point thirteen point one")]
    public void DirectoryBuildPropsMustSpecifyRoslynatorAnalyzersVersionFourPointThirteenPointOne()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("\"Roslynator.Analyzers\" Version=\"4.13.1\"", StringComparison.Ordinal), "Roslynator.Analyzers must be version 4.13.1");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must specify meziantou analyzer version two point zero point one nine four")]
    public void DirectoryBuildPropsMustSpecifyMeziantouAnalyzerVersionTwoPointZeroPointOneNineFour()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("\"Meziantou.Analyzer\" Version=\"2.0.194\"", StringComparison.Ordinal), "Meziantou.Analyzer must be version 2.0.194");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must specify sonar analyzer csharp version ten point six point zero")]
    public void DirectoryBuildPropsMustSpecifySonarAnalyzerCsharpVersionTenPointSixPointZero()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("\"SonarAnalyzer.CSharp\" Version=\"10.6.0.109712\"", StringComparison.Ordinal), "SonarAnalyzer.CSharp must be version 10.6.0.109712");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must set private assets all on every analyzer package reference entry")]
    public void DirectoryBuildPropsMustSetPrivateAssetsAllOnEveryAnalyzerPackageReferenceEntry()
    {
        var Props = ReadRootFile("Directory.Build.props");
        var Lines = Props.Split('\n');
        var PackageLines = Lines.Where(L => L.Contains("PackageReference", StringComparison.Ordinal)).ToArray();
        Assert.AreEqual(4, PackageLines.Length, "Build props must have exactly 4 analyzer package references");
        foreach (var Line in PackageLines)
        {
            Assert.IsTrue(Line.Contains("PrivateAssets=\"all\"", StringComparison.Ordinal), $"Package reference must have PrivateAssets=all: {Line.Trim()}");
        }
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must use project root element without sdk attribute for central config")]
    public void DirectoryBuildPropsMustUseProjectRootElementWithoutSdkAttributeForCentralConfig()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("<Project>", StringComparison.Ordinal), "Build props must start with bare <Project> element");
        Assert.IsFalse(Props.Contains("Sdk=", StringComparison.Ordinal), "Build props must not specify an SDK (it's inherited by each project)");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must have exactly two property groups for settings and sdk paths")]
    public void DirectoryBuildPropsMustHaveExactlyTwoPropertyGroupsForSettingsAndSdkPaths()
    {
        var Props = ReadRootFile("Directory.Build.props");
        var Lines = Props.Split('\n');
        var PropertyGroupCount = Lines.Count(L => L.Contains("<PropertyGroup>", StringComparison.Ordinal) || L.Contains("<PropertyGroup ", StringComparison.Ordinal));
        Assert.AreEqual(2, PropertyGroupCount, "Build props must have exactly 2 PropertyGroup elements");
        var ItemGroupCount = Lines.Count(L => L.Contains("<ItemGroup>", StringComparison.Ordinal));
        Assert.AreEqual(1, ItemGroupCount, "Build props must have exactly 1 ItemGroup for analyzers");
    }
}
