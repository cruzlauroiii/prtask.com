namespace PrTask.E2E;
public partial class ArchitectureTests
{
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Editor config file must exist at solution root to enforce code style")]
    public void TLinter01EditorConfigFileMustExistAtSolutionRootToEnforceCodeStyle()
    {
        var EditorConfigPath = Path.Combine(SolutionRoot, ".editorconfig");
        Assert.IsTrue(File.Exists(EditorConfigPath), ".editorconfig not found at solution root");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Editor config must define analyzer diagnostic severity to enforce all rules")]
    public void TLinter02EditorConfigMustDefineAnalyzerDiagnosticSeverityToEnforceAllRules()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, ".editorconfig"));
        Assert.IsTrue(Content.Contains("dotnet_analyzer_diagnostic.severity"), ".editorconfig missing analyzer diagnostic severity");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Directory build props must treat warnings as errors for strict enforcement")]
    public void TLinter03DirectoryBuildPropsMustTreatWarningsAsErrorsForStrictEnforcement()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(Content.Contains("<TreatWarningsAsErrors>true</TreatWarningsAsErrors>"), "TreatWarningsAsErrors not enabled");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Directory build props must enable dot net analyzers for code quality")]
    public void TLinter04DirectoryBuildPropsMustEnableDotNetAnalyzersForCodeQuality()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(Content.Contains("<EnableNETAnalyzers>true</EnableNETAnalyzers>"), "EnableNETAnalyzers not enabled");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Directory build props must enforce code style in build pipeline")]
    public void TLinter05DirectoryBuildPropsMustEnforceCodeStyleInBuildPipeline()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(Content.Contains("<EnforceCodeStyleInBuild>true</EnforceCodeStyleInBuild>"), "EnforceCodeStyleInBuild not enabled");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Analysis level must be set to latest all for maximum rule coverage")]
    public void TLinter06AnalysisLevelMustBeSetToLatestAllForMaximumRuleCoverage()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(Content.Contains("<AnalysisLevel>latest-all</AnalysisLevel>"), "AnalysisLevel not set to latest-all");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No project files should disable any analyzers to maintain quality enforcement")]
    public void TLinter07NoProjectFilesShouldDisableAnyAnalyzersToMaintainQualityEnforcement()
    {
        var Violations = new List<string>();
        foreach (var ProjectFile in GetAllProjectFiles())
        {
            var Content = File.ReadAllText(ProjectFile);
            if (Content.Contains("<EnableNETAnalyzers>false</EnableNETAnalyzers>"))
            {
                Violations.Add(Path.GetFileName(ProjectFile));
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Projects disabling analyzers: {string.Join(", ", Violations)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Editor config must define naming rules for private fields interfaces async and constants")]
    public void TLinter08EditorConfigMustDefineNamingRulesForPrivateFieldsInterfacesAsyncAndConstants()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, ".editorconfig"));
        var RequiredRules = new[] { "private_fields", "interfaces", "async_methods", "constants", "types" };
        var Missing = RequiredRules.Where(Rule => !Content.Contains(Rule)).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing naming rules: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Editor config must enforce file scoped namespace declarations for consistency")]
    public void TLinter09EditorConfigMustEnforceFileScopedNamespaceDeclarationsForConsistency()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, ".editorconfig"));
        Assert.IsTrue(Content.Contains("csharp_style_namespace_declarations = file_scoped"), "File-scoped namespaces not configured");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Eslint configuration must exist at solution root for JavaScript quality enforcement")]
    public void TLinter10EslintConfigurationMustExistAtSolutionRootForJavaScriptQualityEnforcement()
    {
        var EslintPath = Path.Combine(SolutionRoot, "eslint.config.mjs");
        Assert.IsTrue(File.Exists(EslintPath), "eslint.config.mjs not found at solution root");
    }
}
