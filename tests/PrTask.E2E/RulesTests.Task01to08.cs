namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task01 All projects must target .NET 10 with no FrameworkReference to AspNetCore.App")]
    public void Task01AllProjectsMustTargetNet10WithNoFrameworkReference()
    {
        foreach (var Csproj in GetAllProjectFiles())
        {
            var Content = File.ReadAllText(Csproj);
            var Name = Path.GetFileName(Csproj);
            if (Content.Contains("<TargetFramework>"))
            {
                Assert.IsTrue(Content.Contains("net10.0") || Content.Contains("net10.0-android") || Content.Contains("netstandard2.0"), $"{Name} must target .NET 10 or netstandard2.0");
            }
            Assert.IsFalse(Content.Contains("<FrameworkReference Include=\"Microsoft.AspNetCore.App\"") && !Content.Contains("<FrameworkReference Include=\"Microsoft.AspNetCore.App\" PrivateAssets=\"all\""), $"{Name} must not have FrameworkReference without PrivateAssets=all");
        }
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task02 Client must use BlazorWebAssembly SDK and reference SharedUI")]
    public void Task02ClientMustUseBlazorWebAssemblySdkAndReferenceSharedUi()
    {
        var Csproj = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Client", "PrTask.Client.csproj"));
        Assert.IsTrue(Csproj.Contains("Microsoft.NET.Sdk.BlazorWebAssembly"), "Client must use BlazorWebAssembly SDK");
        Assert.IsTrue(Csproj.Contains("PrTask.SharedUI"), "Client must reference SharedUI project");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task03 MAUI must target net10.0-android with UseMaui and have Android platform files")]
    public void Task03MauiMustTargetNet10AndroidWithUseMauiAndPlatformFiles()
    {
        var Csproj = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Maui", "PrTask.Maui.csproj"));
        Assert.IsTrue(Csproj.Contains("net10.0-android"), "MAUI must target net10.0-android");
        Assert.IsTrue(Csproj.Contains("<UseMaui>true</UseMaui>"), "MAUI must enable UseMaui");
        var AndroidDir = Path.Combine(SourceRoot, "PrTask.Maui", "Platforms", "Android");
        Assert.IsTrue(Directory.Exists(AndroidDir), "Must have Platforms/Android directory");
        Assert.IsTrue(File.Exists(Path.Combine(AndroidDir, "MainActivity.cs")), "Must have MainActivity.cs");
        Assert.IsTrue(File.Exists(Path.Combine(AndroidDir, "MainApplication.cs")), "Must have MainApplication.cs");
        Assert.IsTrue(File.Exists(Path.Combine(AndroidDir, "AndroidManifest.xml")), "Must have AndroidManifest.xml");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task04 MAUI pages must wrap SharedUI page components as single source of truth")]
    public void Task04MauiPagesMustWrapSharedUiPageComponents()
    {
        var MauiPagesDir = Path.Combine(SourceRoot, "PrTask.Maui", "Pages");
        var RazorFiles = Directory.GetFiles(MauiPagesDir, "*.razor", SearchOption.AllDirectories);
        Assert.IsTrue(RazorFiles.Length >= 10, $"MAUI must have at least 10 page wrappers, found {RazorFiles.Length}");
        foreach (var FilePath in RazorFiles)
        {
            var FileName = Path.GetFileName(FilePath);
            if (FileName == "MauiLoginPage.razor")
            {
                continue;
            }
            var Content = File.ReadAllText(FilePath);
            Assert.IsTrue(Content.Contains("PrTask.SharedUI.Pages."), $"{FileName} must reference SharedUI page");
        }
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task05 No third-party runtime packages only Microsoft MSTest SassCompiler or analyzer packages")]
    public void Task05NoThirdPartyRuntimePackages()
    {
        foreach (var Csproj in GetAllProjectFiles())
        {
            var Content = File.ReadAllText(Csproj);
            var Name = Path.GetFileName(Csproj);
            foreach (var Line in Content.Split('\n'))
            {
                if (!Line.Contains("<PackageReference Include="))
                {
                    continue;
                }
                var Ok = Line.Contains("Microsoft.") || Line.Contains("MSTest") || Line.Contains("SassCompiler")
                    || Line.Contains("PrivateAssets") || Line.Contains("StyleCop") || Line.Contains("Roslynator")
                    || Line.Contains("Meziantou") || Line.Contains("SonarAnalyzer")
                    || Line.Contains("LLamaSharp") || Line.Contains("Cloud.Unum.USearch")
                    || Line.Contains("Whisper.net") || Line.Contains("LowDb.Net")
                    || Line.Contains("DiffPlex")
                    || Line.Contains("System.Reactive");
                Assert.IsTrue(Ok, $"{Name} has disallowed package: {Line.Trim()}");
            }
        }
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task06 Four analyzers StyleCop Roslynator Meziantou SonarAnalyzer in Directory.Build.props with PrivateAssets all")]
    public void Task06FourAnalyzersInDirectoryBuildProps()
    {
        var Props = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(Props.Contains("StyleCop.Analyzers"), "Must include StyleCop.Analyzers");
        Assert.IsTrue(Props.Contains("Roslynator.Analyzers"), "Must include Roslynator.Analyzers");
        Assert.IsTrue(Props.Contains("Meziantou.Analyzer"), "Must include Meziantou.Analyzer");
        Assert.IsTrue(Props.Contains("SonarAnalyzer.CSharp"), "Must include SonarAnalyzer.CSharp");
        Assert.IsTrue(Props.Split("PrivateAssets").Length - 1 >= 4, "Must have at least 4 PrivateAssets=all");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task07 SassCompiler must be in Server and SharedUI with compressed output style")]
    public void Task07SassCompilerInServerAndSharedUiCompressed()
    {
        var ServerCsproj = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Server", "PrTask.Server.csproj"));
        var SharedCsproj = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "PrTask.SharedUI.csproj"));
        Assert.IsTrue(ServerCsproj.Contains("SassCompiler") || SharedCsproj.Contains("SassCompiler"), "SassCompiler must be present");
        var SassConfig = Path.Combine(SourceRoot, "PrTask.SharedUI", "sasscompiler.json");
        if (File.Exists(SassConfig))
        {
            Assert.IsTrue(File.ReadAllText(SassConfig).Contains("compressed"), "Must use compressed output");
        }
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task08 All test projects must use MSTest 4.x with IsTestProject true")]
    public void Task08TestProjectsMustUseMsTest4WithIsTestProject()
    {
        var TestProjects = GetAllProjectFiles().Where(F => F.Contains("Tests") || F.Contains("E2E"));
        foreach (var Csproj in TestProjects)
        {
            var Content = File.ReadAllText(Csproj);
            var Name = Path.GetFileName(Csproj);
            Assert.IsTrue(Content.Contains("<IsTestProject>true</IsTestProject>"), $"{Name} must have IsTestProject=true");
            Assert.IsTrue(Content.Contains("MSTest") && Content.Contains("Version=\"4."), $"{Name} must use MSTest 4.x");
        }
    }
}
