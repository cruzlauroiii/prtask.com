namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task41 Login page must have SSO buttons with href links without forceLoad or NavigateTo auto-redirect")]
    public void Task41LoginPageSsoButtonsWithHrefNoAutoRedirect()
    {
        var ClientLogin = ReadSource("PrTask.Client", "Pages", "ClientLoginPage.razor");
        var SharedLogin = ReadSource("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsFalse(ClientLogin.Contains("forceLoad"), "Client login must not use forceLoad");
        Assert.IsFalse(SharedLogin.Contains("forceLoad"), "SharedUI login must not use forceLoad");
        Assert.IsFalse(ClientLogin.Contains("NavigateTo"), "Client login must not auto-redirect");
        Assert.IsFalse(SharedLogin.Contains("NavigateTo"), "SharedUI login must not auto-redirect");
        Assert.IsTrue(SharedLogin.Contains("github", StringComparison.OrdinalIgnoreCase), "Must have GitHub sign-in");
        Assert.IsTrue(SharedLogin.Contains("google", StringComparison.OrdinalIgnoreCase), "Must have Google sign-in");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task42 All Razor pages must have @page directive and constants model service files must exist")]
    public void Task42RazorPageDirectivesAndFilesExist()
    {
        var RazorPages = GetSourceFiles(".razor").Where(F => F.Contains("Pages") && !F.Contains("_Imports"));
        foreach (var Page in RazorPages)
        {
            var Content = File.ReadAllText(Page);
            var Fn = Path.GetFileName(Page);
            if (!Fn.Contains("Layout") && !Fn.Contains("Component"))
            {
                Assert.IsTrue(Content.Contains("@page"), $"{Fn} must have @page directive");
            }
        }
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Domain", "Constants", "AppConstants.cs")), "AppConstants must exist");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Domain", "Constants", "RouteConstants.cs")), "RouteConstants must exist");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task43 Plain SCSS only no CSS frameworks and SassCompiler must produce compressed output")]
    public void Task43PlainScssNoFrameworksCompressedOutput()
    {
        foreach (var Csproj in GetAllProjectFiles())
        {
            var Content = File.ReadAllText(Csproj);
            var Name = Path.GetFileName(Csproj);
            Assert.IsFalse(Content.Contains("bootstrap", StringComparison.OrdinalIgnoreCase) && Content.Contains("PackageReference"), $"{Name} must not use Bootstrap");
            Assert.IsFalse(Content.Contains("tailwind", StringComparison.OrdinalIgnoreCase) && Content.Contains("PackageReference"), $"{Name} must not use Tailwind");
        }
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task44 Night mode SCSS must define prefers-color-scheme dark media query with data-theme support")]
    public void Task44NightModeScssDarkTheme()
    {
        var StylesDir = Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles");
        var AllScss = string.Join("\n", Directory.GetFiles(StylesDir, "*.scss").Select(File.ReadAllText));
        Assert.IsTrue(AllScss.Contains("prefers-color-scheme"), "Must have prefers-color-scheme media query");
        Assert.IsTrue(AllScss.Contains("data-theme"), "Must support data-theme attribute");
        Assert.IsTrue(AllScss.Contains(":not([data-theme=\"light\"])"), "Must have CSS-only fallback with :not([data-theme=\"light\"])");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task45 SCSS layouts must use flexbox with display flex and flex-direction without CSS grid")]
    public void Task45FlexboxLayoutsNoGrid()
    {
        var Scss = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles", "app.scss"));
        Assert.IsTrue(Scss.Contains("display: flex") || Scss.Contains("display:flex"), "Must use display flex");
        Assert.IsTrue(Scss.Contains("flex-direction"), "Must use flex-direction");
        Assert.IsTrue(Scss.Contains("flex-wrap"), "Must use flex-wrap");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task46 App root div must be flex column with min-height 100dvh max-width 100vw word-break no overflow")]
    public void Task46AppRootDivFlexColumnNoOverflow()
    {
        var Scss = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles", "app.scss"));
        Assert.IsTrue(Scss.Contains("min-height: 100dvh") || Scss.Contains("min-height:100dvh"), "Must use 100dvh");
        Assert.IsTrue(Scss.Contains("max-width: 100vw") || Scss.Contains("max-width:100vw"), "Must use 100vw");
        Assert.IsTrue(Scss.Contains("word-break"), "Must use word-break");
        Assert.IsFalse(Scss.Contains("100vh") && !Scss.Contains("100dvh"), "Must not use 100vh without dvh");
        Assert.IsFalse(Scss.Contains("overflow-x:") || Scss.Contains("overflow-x :"), "Must not use overflow-x");
        Assert.IsFalse(Scss.Contains("overflow-y:") || Scss.Contains("overflow-y :"), "Must not use overflow-y");
        Assert.IsFalse(Scss.Contains("overflow: hidden") || Scss.Contains("overflow:hidden"), "Must not use overflow:hidden");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task47 Client index.html must have inline theme script with localStorage prtaskToggleTheme prtaskGetTheme")]
    public void Task47ClientIndexHtmlThemeScript()
    {
        var Html = ReadSource("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("prtaskToggleTheme"), "Must define prtaskToggleTheme");
        Assert.IsTrue(Html.Contains("prtaskGetTheme"), "Must define prtaskGetTheme");
        Assert.IsTrue(Html.Contains("data-theme"), "Must use data-theme attribute");
        Assert.IsTrue(Html.Contains("prtask-theme"), "Must use prtask-theme localStorage key");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task48 Serverless architecture one HTML one WASM deployed to Cloudflare Pages via OpenTofu")]
    public void Task48ServerlessCloudflarePages()
    {
        Assert.IsTrue(File.Exists(Path.Combine(SolutionRoot, "infra", "main.tf")), "Must have main.tf");
        Assert.IsTrue(File.Exists(Path.Combine(SolutionRoot, "infra", "pages.tf")), "Must have pages.tf");
        var MainTf = ReadInfra("main.tf");
        Assert.IsTrue(MainTf.Contains("cloudflare"), "Must use Cloudflare provider");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task49 Infrastructure must have main.tf pages.tf dns.tf variables.tf and outputs.tf OpenTofu files")]
    public void Task49OpenTofuFiles()
    {
        Assert.IsTrue(File.Exists(Path.Combine(SolutionRoot, "infra", "main.tf")), "Must have main.tf");
        Assert.IsTrue(File.Exists(Path.Combine(SolutionRoot, "infra", "pages.tf")), "Must have pages.tf");
        Assert.IsTrue(File.Exists(Path.Combine(SolutionRoot, "infra", "dns.tf")), "Must have dns.tf");
        Assert.IsTrue(File.Exists(Path.Combine(SolutionRoot, "infra", "variables.tf")), "Must have variables.tf");
        Assert.IsTrue(File.Exists(Path.Combine(SolutionRoot, "infra", "outputs.tf")), "Must have outputs.tf");
        var Pages = ReadInfra("pages.tf");
        Assert.IsTrue(Pages.Contains("cloudflare_pages_project"), "pages.tf must use cloudflare_pages_project");
        var Dns = ReadInfra("dns.tf");
        Assert.IsTrue(Dns.Contains("cloudflare_record"), "dns.tf must use cloudflare_record");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task50 Cloudflare D1 database in d1.tf KV namespaces for sessions and cache in kv.tf R2 bucket in r2.tf")]
    public void Task50CloudflareDatabases()
    {
        var D1 = ReadInfra("d1.tf");
        Assert.IsTrue(D1.Contains("cloudflare_d1_database"), "Must have D1 database");
        Assert.IsTrue(D1.Contains("\"prtask-db\""), "Must name database prtask-db");
        var Kv = ReadInfra("kv.tf");
        Assert.IsTrue(Kv.Contains("\"prtask-sessions\""), "Must have prtask-sessions KV namespace");
        Assert.IsTrue(Kv.Contains("\"prtask-cache\""), "Must have prtask-cache KV namespace");
        var R2 = ReadInfra("r2.tf");
        Assert.IsTrue(R2.Contains("cloudflare_r2_bucket"), "Must have R2 bucket");
        Assert.IsTrue(R2.Contains("\"prtask-diffs\""), "Must have prtask-diffs bucket");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task51 Workers.tf must configure D1 KV and R2 bindings with /api/* route pattern")]
    public void Task51WorkersTfBindingsAndRoute()
    {
        var Tf = ReadInfra("workers.tf");
        Assert.IsTrue(Tf.Contains("d1_database_binding"), "Must have D1 binding");
        Assert.IsTrue(Tf.Contains("kv_namespace_binding"), "Must have KV binding");
        Assert.IsTrue(Tf.Contains("r2_bucket_binding"), "Must have R2 binding");
        Assert.IsTrue(Tf.Contains("prtask.com/api/*"), "Route must match /api/* pattern");
        Assert.IsTrue(Tf.Contains("secret_text_binding"), "Must have secret bindings for OAuth");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task52 Gitignore must exclude terraform.tfvars and .wrangler directory")]
    public void Task52GitignoreExcludesSecrets()
    {
        var Gitignore = File.ReadAllText(Path.Combine(SolutionRoot, ".gitignore"));
        Assert.IsTrue(Gitignore.Contains("terraform.tfvars"), "Must exclude terraform.tfvars");
        Assert.IsTrue(Gitignore.Contains(".wrangler"), "Must exclude .wrangler directory");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task53 Editorconfig must configure PascalCase naming rules for fields constants types members locals parameters")]
    public void Task53EditorConfigPascalCaseRules()
    {
        var Ec = File.ReadAllText(Path.Combine(SolutionRoot, ".editorconfig"));
        Assert.IsTrue(Ec.Contains("dotnet_naming_rule"), "Must have naming rules");
        Assert.IsTrue(Ec.Contains("pascal_case"), "Must define pascal_case style");
        Assert.IsTrue(Ec.Contains("private_fields"), "Must have private fields rule");
        Assert.IsTrue(Ec.Contains("constants_pascal"), "Must have constants rule");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task54 Directory.Build.props must set GenerateDocumentationFile and AnalysisMode AllEnabledByDefault")]
    public void Task54DirectoryBuildPropsAnalysis()
    {
        var Props = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(Props.Contains("<GenerateDocumentationFile>true</GenerateDocumentationFile>"), "Must enable doc generation");
        Assert.IsTrue(Props.Contains("AllEnabledByDefault"), "Must set AnalysisMode to AllEnabledByDefault");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task55 Solution file must reference all projects and Client wwwroot must have _redirects file")]
    public void Task55SolutionFileAndRedirects()
    {
        var Sln = File.ReadAllText(Path.Combine(SolutionRoot, "PrTask.sln"));
        Assert.IsTrue(Sln.Contains("PrTask.Client"), "Solution must reference Client");
        Assert.IsTrue(Sln.Contains("PrTask.Server"), "Solution must reference Server");
        Assert.IsTrue(Sln.Contains("PrTask.SharedUI"), "Solution must reference SharedUI");
        Assert.IsTrue(Sln.Contains("PrTask.Domain"), "Solution must reference Domain");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "_redirects")), "Client must have _redirects file");
    }
}
