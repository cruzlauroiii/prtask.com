using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MAUI APK must support all four SSO providers with WebAuthenticator")]
    public void Task80MauiSsoProviders()
    {
        var MauiLogin = ReadSource("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(MauiLogin.Contains("WebAuthenticator"), "MAUI login must use WebAuthenticator for SSO");
        Assert.IsTrue(MauiLogin.Contains(AppConstants.MauiPackageName), "MAUI login must use app callback scheme");
        Assert.IsTrue(MauiLogin.Contains(nameof(RouteConstants.ApiAuthGoogle)), "MAUI login must have Google SSO");
        Assert.IsTrue(MauiLogin.Contains(nameof(RouteConstants.ApiAuthGitHub)), "MAUI login must have GitHub SSO");
        Assert.IsTrue(MauiLogin.Contains(nameof(RouteConstants.ApiAuthAzure)), "MAUI login must have Azure SSO");
        Assert.IsTrue(MauiLogin.Contains(nameof(RouteConstants.ApiAuthOkta)), "MAUI login must have Okta SSO");
        var AuthCallback = ReadSource("PrTask.Maui", "Platforms", "Android", "AuthCallbackActivity.cs");
        Assert.IsTrue(AuthCallback.Contains("WebAuthenticatorCallbackActivity"), "AuthCallbackActivity must extend WebAuthenticatorCallbackActivity");
        Assert.IsTrue(AuthCallback.Contains(AppConstants.MauiPackageName), "AuthCallbackActivity must use app scheme");
        var MainPageCs = ReadSource("PrTask.Maui", "MainPage.xaml.cs");
        Assert.IsTrue(MainPageCs.Contains("OnUrlLoading"), "MainPage must handle UrlLoading for OAuth redirects");
        Assert.IsTrue(MainPageCs.Contains("GoogleConstants"), "OnUrlLoading must allow Google OAuth URLs");
        Assert.IsTrue(MainPageCs.Contains("GitHubConstants"), "OnUrlLoading must allow GitHub OAuth URLs");
        Assert.IsTrue(MainPageCs.Contains("AzureConstants"), "OnUrlLoading must allow Azure OAuth URLs");
        Assert.IsTrue(MainPageCs.Contains("OktaConstants"), "OnUrlLoading must allow Okta OAuth URLs");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Code pattern checks must be Roslyn analyzers not E2E tests")]
    public void Task81AnalyzersOverE2eForPatterns()
    {
        var AnalyzerFiles = Directory.EnumerateFiles(
            Path.Combine(SourceRoot, "PrTask.Analyzers"), "*.cs", SearchOption.AllDirectories)
            .Where(F => !F.Contains("obj") && !F.Contains("bin")).ToList();
        Assert.IsTrue(AnalyzerFiles.Count >= 5, $"Must have at least 5 analyzer files, found {AnalyzerFiles.Count}");
        var AnalyzerContent = string.Join("\n", AnalyzerFiles.Select(File.ReadAllText));
        Assert.IsTrue(AnalyzerContent.Contains("DiagnosticAnalyzer"), "Must have DiagnosticAnalyzer implementations");
        Assert.IsTrue(AnalyzerContent.Contains("PascalCase") || AnalyzerContent.Contains("PT001"),
            "Must have PascalCase naming analyzer");
        Assert.IsTrue(AnalyzerContent.Contains("MaxFileLines") || AnalyzerContent.Contains("PT003"),
            "Must have max file lines analyzer");
        var BuildProps = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(BuildProps.Contains("PrTask.Analyzers"), "Directory.Build.props must reference PrTask.Analyzers");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("E2E test DisplayName must be descriptive without task number prefixes")]
    public void Task82DisplayNameFormat()
    {
        var TestFiles = Directory.EnumerateFiles(
            Path.Combine(SolutionRoot, "tests", "PrTask.E2E"), "RulesTests.Task*.cs", SearchOption.TopDirectoryOnly);
        var Violations = new List<string>();
        foreach (var TestFile in TestFiles)
        {
            var Content = File.ReadAllText(TestFile);
            var Fn = Path.GetFileName(TestFile);
            var Matches = DisplayNameTaskPrefixPattern().Matches(Content);
            foreach (System.Text.RegularExpressions.Match Match in Matches)
            {
                Violations.Add($"{Fn}: DisplayName starts with '{Match.Groups[1].Value.Trim()}'");
            }
        }
        Assert.AreEqual(0, Violations.Count,
            $"DisplayNames must not have task number prefix:\n{string.Join("\n", Violations.Take(10))}");
    }
}
