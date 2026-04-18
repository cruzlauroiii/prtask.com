namespace PrTask.E2E;
public partial class ArchitectureTests
{
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Sass compiler configuration must exist in Server project with required properties")]
    public void TScss01SassCompilerConfigurationMustExistInServerProjectWithRequiredProperties()
    {
        var SassConfigPath = Path.Combine(SourceRoot, ServerProject, "sasscompiler.json");
        Assert.IsTrue(File.Exists(SassConfigPath), "sasscompiler.json not found in Server project");
        var Content = File.ReadAllText(SassConfigPath);
        Assert.IsTrue(Content.Contains("compressed"), "sasscompiler.json missing compressed style");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Sass compiler configuration must exist in SharedUI project for component styles")]
    public void TScss02SassCompilerConfigurationMustExistInSharedUiProjectForComponentStyles()
    {
        var SassConfigPath = Path.Combine(SourceRoot, SharedUiProject, "sasscompiler.json");
        Assert.IsTrue(File.Exists(SassConfigPath), "sasscompiler.json not found in SharedUI project");
        var Content = File.ReadAllText(SassConfigPath);
        Assert.IsTrue(Content.Contains("compressed"), "sasscompiler.json missing compressed style");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SassCompiler NuGet package must be referenced in Server SharedUI and Maui project files")]
    public void TScss03SassCompilerNuGetPackageMustBeReferencedInServerSharedUiAndMauiProjectFiles()
    {
        var ServerProj = File.ReadAllText(Path.Combine(SourceRoot, ServerProject, $"{ServerProject}.csproj"));
        var SharedUiProj = File.ReadAllText(Path.Combine(SourceRoot, SharedUiProject, $"{SharedUiProject}.csproj"));
        var MauiProj = File.ReadAllText(Path.Combine(SourceRoot, MauiProject, $"{MauiProject}.csproj"));
        Assert.IsTrue(ServerProj.Contains("AspNetCore.SassCompiler"), "Server missing SassCompiler reference");
        Assert.IsTrue(SharedUiProj.Contains("AspNetCore.SassCompiler"), "SharedUI missing SassCompiler reference");
        Assert.IsTrue(MauiProj.Contains("AspNetCore.SassCompiler"), "Maui missing SassCompiler reference");
    }
}
