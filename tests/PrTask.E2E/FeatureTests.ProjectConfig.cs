namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Domain csproj must target net ten with no package dependencies for clean architecture isolation")]
    public void DomainCsprojMustTargetNetTenWithNoPackageDependenciesForCleanArchitectureIsolation()
    {
        var Csproj = ReadSourceFile("PrTask.Domain", "PrTask.Domain.csproj");
        Assert.IsTrue(Csproj.Contains("net10.0", StringComparison.Ordinal), "Domain must target net10.0");
        Assert.IsTrue(Csproj.Contains("Microsoft.NET.Sdk", StringComparison.Ordinal), "Domain must use standard .NET SDK");
        Assert.IsFalse(Csproj.Contains("PackageReference", StringComparison.Ordinal), "Domain must have zero package dependencies");
        Assert.IsFalse(Csproj.Contains("ProjectReference", StringComparison.Ordinal), "Domain must have zero project references");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Application csproj must reference domain project and seven microsoft extensions packages")]
    public void ApplicationCsprojMustReferenceDomainProjectAndSevenMicrosoftExtensionsPackages()
    {
        var Csproj = ReadSourceFile("PrTask.Application", "PrTask.Application.csproj");
        Assert.IsTrue(Csproj.Contains("PrTask.Domain.csproj", StringComparison.Ordinal), "Application must reference Domain project");
        Assert.IsTrue(Csproj.Contains("Microsoft.Extensions.Configuration.Abstractions", StringComparison.Ordinal), "Application must use Configuration.Abstractions");
        Assert.IsTrue(Csproj.Contains("Microsoft.Extensions.Http", StringComparison.Ordinal), "Application must use Http for named HttpClient factories");
        Assert.IsTrue(Csproj.Contains("Microsoft.Extensions.DependencyInjection.Abstractions", StringComparison.Ordinal), "Application must use DI abstractions");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Application csproj must use options logging and hosting abstractions from microsoft extensions")]
    public void ApplicationCsprojMustUseOptionsLoggingAndHostingAbstractionsFromMicrosoftExtensions()
    {
        var Csproj = ReadSourceFile("PrTask.Application", "PrTask.Application.csproj");
        Assert.IsTrue(Csproj.Contains("Microsoft.Extensions.Options\"", StringComparison.Ordinal), "Application must use Options package");
        Assert.IsTrue(Csproj.Contains("Microsoft.Extensions.Logging.Abstractions", StringComparison.Ordinal), "Application must use Logging.Abstractions");
        Assert.IsTrue(Csproj.Contains("Microsoft.Extensions.Hosting.Abstractions", StringComparison.Ordinal), "Application must use Hosting.Abstractions");
        Assert.IsTrue(Csproj.Contains("Microsoft.Extensions.Options.ConfigurationExtensions", StringComparison.Ordinal), "Application must use Options.ConfigurationExtensions");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Shared ui csproj must use razor sdk with sass compiler and components web packages")]
    public void SharedUiCsprojMustUseRazorSdkWithSassCompilerAndComponentsWebPackages()
    {
        var Csproj = ReadSourceFile("PrTask.SharedUI", "PrTask.SharedUI.csproj");
        Assert.IsTrue(Csproj.Contains("Microsoft.NET.Sdk.Razor", StringComparison.Ordinal), "SharedUI must use Razor SDK for Razor Class Library");
        Assert.IsTrue(Csproj.Contains("AspNetCore.SassCompiler", StringComparison.Ordinal), "SharedUI must use SassCompiler for SCSS compilation");
        Assert.IsTrue(Csproj.Contains("Microsoft.AspNetCore.Components.Web", StringComparison.Ordinal), "SharedUI must reference Components.Web");
        Assert.IsTrue(Csproj.Contains("PrTask.Application.csproj", StringComparison.Ordinal), "SharedUI must reference Application project");
        Assert.IsTrue(Csproj.Contains("PrTask.Domain.csproj", StringComparison.Ordinal), "SharedUI must reference Domain project");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client csproj must use blazor web assembly sdk with trim and aot analyzers disabled")]
    public void ClientCsprojMustUseBlazorWebAssemblySdkWithTrimAndAotAnalyzersDisabled()
    {
        var Csproj = ReadSourceFile("PrTask.Client", "PrTask.Client.csproj");
        Assert.IsTrue(Csproj.Contains("Microsoft.NET.Sdk.BlazorWebAssembly", StringComparison.Ordinal), "Client must use BlazorWebAssembly SDK");
        Assert.IsTrue(Csproj.Contains("EnableTrimAnalyzer>false", StringComparison.Ordinal), "Client must disable trim analyzer for WASM compatibility");
        Assert.IsTrue(Csproj.Contains("EnableAotAnalyzer>false", StringComparison.Ordinal), "Client must disable AOT analyzer");
        Assert.IsTrue(Csproj.Contains("EnableSingleFileAnalyzer>false", StringComparison.Ordinal), "Client must disable single file analyzer");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client csproj must reference domain shared ui and blazor web assembly dev server packages")]
    public void ClientCsprojMustReferenceDomainSharedUiAndBlazorWebAssemblyDevServerPackages()
    {
        var Csproj = ReadSourceFile("PrTask.Client", "PrTask.Client.csproj");
        Assert.IsTrue(Csproj.Contains("PrTask.Domain.csproj", StringComparison.Ordinal), "Client must reference Domain project");
        Assert.IsTrue(Csproj.Contains("PrTask.SharedUI.csproj", StringComparison.Ordinal), "Client must reference SharedUI project");
        Assert.IsTrue(Csproj.Contains("Microsoft.AspNetCore.Components.WebAssembly\"", StringComparison.Ordinal), "Client must reference WebAssembly runtime package");
        Assert.IsTrue(Csproj.Contains("WebAssembly.DevServer", StringComparison.Ordinal), "Client must reference DevServer for development");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("E2e csproj must reference server domain and infrastructure projects with mstest and mvc testing")]
    public void E2eCsprojMustReferenceServerDomainAndInfrastructureProjectsWithMstestAndMvcTesting()
    {
        var Csproj = ReadRootFile("tests", "PrTask.E2E", "PrTask.E2E.csproj");
        Assert.IsTrue(Csproj.Contains("PrTask.Server.csproj", StringComparison.Ordinal), "E2E must reference Server project for integration tests");
        Assert.IsTrue(Csproj.Contains("PrTask.Domain.csproj", StringComparison.Ordinal), "E2E must reference Domain project");
        Assert.IsTrue(Csproj.Contains("PrTask.Infrastructure.csproj", StringComparison.Ordinal), "E2E must reference Infrastructure project");
        Assert.IsTrue(Csproj.Contains("MSTest", StringComparison.Ordinal), "E2E must use MSTest framework");
        Assert.IsTrue(Csproj.Contains("Mvc.Testing", StringComparison.Ordinal), "E2E must use Mvc.Testing for WebApplicationFactory");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must enforce treat warnings as errors and all net analyzers enabled")]
    public void DirectoryBuildPropsMustEnforceTreatWarningsAsErrorsAndAllNetAnalyzersEnabled()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("TreatWarningsAsErrors>true", StringComparison.Ordinal), "Build props must treat warnings as errors");
        Assert.IsTrue(Props.Contains("EnableNETAnalyzers>true", StringComparison.Ordinal), "Build props must enable .NET analyzers");
        Assert.IsTrue(Props.Contains("EnforceCodeStyleInBuild>true", StringComparison.Ordinal), "Build props must enforce code style in build");
        Assert.IsTrue(Props.Contains("AnalysisLevel>latest-all", StringComparison.Ordinal), "Build props must use latest-all analysis level");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must include stylecop roslynator meziantou and sonar analyzer packages")]
    public void DirectoryBuildPropsMustIncludeStylecopRoslynatorMeziantouAndSonarAnalyzerPackages()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("StyleCop.Analyzers", StringComparison.Ordinal), "Build props must include StyleCop.Analyzers");
        Assert.IsTrue(Props.Contains("Roslynator.Analyzers", StringComparison.Ordinal), "Build props must include Roslynator.Analyzers");
        Assert.IsTrue(Props.Contains("Meziantou.Analyzer", StringComparison.Ordinal), "Build props must include Meziantou.Analyzer");
        Assert.IsTrue(Props.Contains("SonarAnalyzer.CSharp", StringComparison.Ordinal), "Build props must include SonarAnalyzer.CSharp");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must enable nullable implicit usings and documentation file generation")]
    public void DirectoryBuildPropsMustEnableNullableImplicitUsingsAndDocumentationFileGeneration()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("Nullable>enable", StringComparison.Ordinal), "Build props must enable nullable reference types");
        Assert.IsTrue(Props.Contains("ImplicitUsings>enable", StringComparison.Ordinal), "Build props must enable implicit usings");
        Assert.IsTrue(Props.Contains("GenerateDocumentationFile>true", StringComparison.Ordinal), "Build props must generate documentation file");
        Assert.IsTrue(Props.Contains("AnalysisMode>AllEnabledByDefault", StringComparison.Ordinal), "Build props must enable all analyzers by default");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Variables tf must define all four oauth provider client id and secret variable pairs")]
    public void VariablesTfMustDefineAllFourOauthProviderClientIdAndSecretVariablePairs()
    {
        var Tf = ReadInfraFile("variables.tf");
        Assert.IsTrue(Tf.Contains("github_client_id", StringComparison.Ordinal), "variables.tf must define github_client_id");
        Assert.IsTrue(Tf.Contains("github_client_secret", StringComparison.Ordinal), "variables.tf must define github_client_secret");
        Assert.IsTrue(Tf.Contains("google_client_id", StringComparison.Ordinal), "variables.tf must define google_client_id");
        Assert.IsTrue(Tf.Contains("google_client_secret", StringComparison.Ordinal), "variables.tf must define google_client_secret");
        Assert.IsTrue(Tf.Contains("azure_client_id", StringComparison.Ordinal), "variables.tf must define azure_client_id");
        Assert.IsTrue(Tf.Contains("azure_client_secret", StringComparison.Ordinal), "variables.tf must define azure_client_secret");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Variables tf must define okta domain session secret and maya payment key variable pairs")]
    public void VariablesTfMustDefineOktaDomainSessionSecretAndMayaPaymentKeyVariablePairs()
    {
        var Tf = ReadInfraFile("variables.tf");
        Assert.IsTrue(Tf.Contains("okta_client_id", StringComparison.Ordinal), "variables.tf must define okta_client_id");
        Assert.IsTrue(Tf.Contains("okta_client_secret", StringComparison.Ordinal), "variables.tf must define okta_client_secret");
        Assert.IsTrue(Tf.Contains("okta_domain", StringComparison.Ordinal), "variables.tf must define okta_domain for tenant URL");
        Assert.IsTrue(Tf.Contains("session_secret", StringComparison.Ordinal), "variables.tf must define session_secret for cookie signing");
        Assert.IsTrue(Tf.Contains("maya_public_key", StringComparison.Ordinal), "variables.tf must define maya_public_key");
        Assert.IsTrue(Tf.Contains("maya_secret_key", StringComparison.Ordinal), "variables.tf must define maya_secret_key");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Variables tf must mark all secret variables as sensitive to prevent terraform plan output leak")]
    public void VariablesTfMustMarkAllSecretVariablesAsSensitiveToPreventTerraformPlanOutputLeak()
    {
        var Tf = ReadInfraFile("variables.tf");
        var Lines = Tf.Split('\n');
        var SensitiveCount = Lines.Count(L => L.Contains("sensitive = true", StringComparison.Ordinal));
        Assert.IsTrue(SensitiveCount >= 6, $"variables.tf must mark at least 6 variables as sensitive, found {SensitiveCount}");
        Assert.IsTrue(Tf.Contains("cloudflare_api_key", StringComparison.Ordinal), "variables.tf must define cloudflare_api_key");
        Assert.IsTrue(Tf.Contains("cloudflare_zone_id", StringComparison.Ordinal), "variables.tf must define cloudflare_zone_id");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss variables must define primary dark secondary accent color values and border radius token")]
    public void ScssVariablesMustDefinePrimaryDarkSecondaryAccentColorValuesAndBorderRadiusToken()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Scss.Contains("$color-primary-dark", StringComparison.Ordinal), "SCSS must define $color-primary-dark variable");
        Assert.IsTrue(Scss.Contains("$color-secondary", StringComparison.Ordinal), "SCSS must define $color-secondary variable");
        Assert.IsTrue(Scss.Contains("$color-accent", StringComparison.Ordinal), "SCSS must define $color-accent variable");
        Assert.IsTrue(Scss.Contains("$radius", StringComparison.Ordinal), "SCSS must define $radius for consistent border radius");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss variables must define css custom properties for background surface text and border colors")]
    public void ScssVariablesMustDefineCssCustomPropertiesForBackgroundSurfaceTextAndBorderColors()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Scss.Contains("--color-bg", StringComparison.Ordinal), "SCSS must define --color-bg custom property");
        Assert.IsTrue(Scss.Contains("--color-surface", StringComparison.Ordinal), "SCSS must define --color-surface custom property");
        Assert.IsTrue(Scss.Contains("--color-text", StringComparison.Ordinal), "SCSS must define --color-text custom property");
        Assert.IsTrue(Scss.Contains("--color-text-muted", StringComparison.Ordinal), "SCSS must define --color-text-muted custom property");
        Assert.IsTrue(Scss.Contains("--color-border", StringComparison.Ordinal), "SCSS must define --color-border custom property");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss variables must use segoe ui system font stack and cascadia code monospace font families")]
    public void ScssVariablesMustUseSegoeUiSystemFontStackAndCascadiaCodeMonospaceFontFamilies()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Scss.Contains("Segoe UI", StringComparison.Ordinal), "SCSS must use Segoe UI as primary font");
        Assert.IsTrue(Scss.Contains("system-ui", StringComparison.Ordinal), "SCSS must include system-ui fallback font");
        Assert.IsTrue(Scss.Contains("Cascadia Code", StringComparison.Ordinal), "SCSS must use Cascadia Code for monospace");
        Assert.IsTrue(Scss.Contains("$font-main", StringComparison.Ordinal), "SCSS must define $font-main variable");
        Assert.IsTrue(Scss.Contains("$font-mono", StringComparison.Ordinal), "SCSS must define $font-mono variable");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User service interface must define get by id get by github id and create or update methods")]
    public void UserServiceInterfaceMustDefineGetByIdGetByGithubIdAndCreateOrUpdateMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IUserService.cs");
        Assert.IsTrue(Code.Contains("GetByIdAsync", StringComparison.Ordinal), "IUserService must have GetByIdAsync for profile loading");
        Assert.IsTrue(Code.Contains("GetByGitHubIdAsync", StringComparison.Ordinal), "IUserService must have GetByGitHubIdAsync for GitHub lookup");
        Assert.IsTrue(Code.Contains("long GitHubId", StringComparison.Ordinal), "CreateOrUpdateFromGitHubAsync must accept long GitHubId");
        Assert.IsTrue(Code.Contains("string Provider", StringComparison.Ordinal), "CreateOrUpdateFromOidcAsync must accept provider parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Achievement service interface must accept prs merged earned cents streak days and rank parameters")]
    public void AchievementServiceInterfaceMustAcceptPrsMergedEarnedCentsStreakDaysAndRankParameters()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IAchievementService.cs");
        Assert.IsTrue(Code.Contains("int TotalPrsMerged", StringComparison.Ordinal), "IAchievementService must accept TotalPrsMerged for badge evaluation");
        Assert.IsTrue(Code.Contains("long TotalEarnedCents", StringComparison.Ordinal), "IAchievementService must accept TotalEarnedCents for earning badges");
        Assert.IsTrue(Code.Contains("int StreakDays", StringComparison.Ordinal), "IAchievementService must accept StreakDays for streak badges");
        Assert.IsTrue(Code.Contains("int LeaderboardRank", StringComparison.Ordinal), "IAchievementService must accept LeaderboardRank for rank badges");
        Assert.IsTrue(Code.Contains("IReadOnlyList<AchievementEntity>", StringComparison.Ordinal), "GetByUserAsync must return IReadOnlyList of AchievementEntity");
    }
}
