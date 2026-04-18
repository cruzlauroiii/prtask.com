namespace PrTask.E2E;
public partial class FeatureTests
{
    private static string ReadRootFile(params string[] PathSegments)
    {
        var FullPath = Path.Combine([SourceRoot, "..", .. PathSegments]);
        return File.ReadAllText(FullPath);
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform workers must bind d1 database kv namespaces and r2 buckets to cloudflare worker")]
    public void TerraformWorkersMustBindD1DatabaseKvNamespacesAndR2BucketsToCloudflareWorker()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("d1_database_binding", StringComparison.Ordinal), "Workers must have D1 database binding");
        Assert.IsTrue(Tf.Contains("kv_namespace_binding", StringComparison.Ordinal), "Workers must have KV namespace binding");
        Assert.IsTrue(Tf.Contains("r2_bucket_binding", StringComparison.Ordinal), "Workers must have R2 bucket binding");
        Assert.IsTrue(Tf.Contains("\"DB\"", StringComparison.Ordinal), "D1 binding must use DB name");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform workers must configure all four oauth client id and secret bindings")]
    public void TerraformWorkersMustConfigureAllFourOauthClientIdAndSecretBindings()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("GOOGLE_CLIENT_ID", StringComparison.Ordinal), "Workers must bind Google client ID");
        Assert.IsTrue(Tf.Contains("GOOGLE_CLIENT_SECRET", StringComparison.Ordinal), "Workers must bind Google client secret");
        Assert.IsTrue(Tf.Contains("GITHUB_CLIENT_ID", StringComparison.Ordinal), "Workers must bind GitHub client ID");
        Assert.IsTrue(Tf.Contains("GITHUB_CLIENT_SECRET", StringComparison.Ordinal), "Workers must bind GitHub client secret");
        Assert.IsTrue(Tf.Contains("AZURE_CLIENT_ID", StringComparison.Ordinal), "Workers must bind Azure client ID");
        Assert.IsTrue(Tf.Contains("OKTA_CLIENT_ID", StringComparison.Ordinal), "Workers must bind Okta client ID");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform workers must use secret text binding for all oauth client secret values")]
    public void TerraformWorkersMustUseSecretTextBindingForAllOauthClientSecretValues()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("secret_text_binding", StringComparison.Ordinal), "Workers must use secret bindings for secrets");
        Assert.IsTrue(Tf.Contains("plain_text_binding", StringComparison.Ordinal), "Workers must use plain text bindings for IDs");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform workers route must map prtask dot com api wildcard to worker script")]
    public void TerraformWorkersRouteMustMapPrtaskDotComApiWildcardToWorkerScript()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("prtask.com/api/*", StringComparison.Ordinal), "Workers route must match prtask.com/api/*");
        Assert.IsTrue(Tf.Contains("cloudflare_workers_route", StringComparison.Ordinal), "Must define cloudflare_workers_route resource");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform variables must mark all secret keys as sensitive for state encryption")]
    public void TerraformVariablesMustMarkAllSecretKeysAsSensitiveForStateEncryption()
    {
        var Tf = ReadInfraFile("variables.tf");
        Assert.IsTrue(Tf.Contains("cloudflare_api_key", StringComparison.Ordinal), "Must define cloudflare_api_key variable");
        Assert.IsTrue(Tf.Contains("maya_secret_key", StringComparison.Ordinal), "Must define maya_secret_key variable");
        Assert.IsTrue(Tf.Contains("github_client_secret", StringComparison.Ordinal), "Must define github_client_secret variable");
        Assert.IsTrue(Tf.Contains("session_secret", StringComparison.Ordinal), "Must define session_secret variable");
        var SensitiveCount = Tf.Split("sensitive = true").Length - 1;
        Assert.IsTrue(SensitiveCount >= 6, $"Must have at least 6 sensitive variables, found {SensitiveCount}");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform dns must create cname records for root and www subdomains pointing to pages")]
    public void TerraformDnsMustCreateCnameRecordsForRootAndWwwSubdomainsPointingToPages()
    {
        var Tf = ReadInfraFile("dns.tf");
        Assert.IsTrue(Tf.Contains("cloudflare_record", StringComparison.Ordinal), "Must define cloudflare_record resources");
        Assert.IsTrue(Tf.Contains("type    = \"CNAME\"", StringComparison.Ordinal), "DNS records must be CNAME type");
        Assert.IsTrue(Tf.Contains("proxied = true", StringComparison.Ordinal), "DNS records must be proxied through Cloudflare");
        Assert.IsTrue(Tf.Contains("name    = \"www\"", StringComparison.Ordinal), "Must create www CNAME record");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform must define d1 database kv namespaces r2 buckets and pages project resources")]
    public void TerraformMustDefineD1DatabaseKvNamespacesR2BucketsAndPagesProjectResources()
    {
        var D1 = ReadInfraFile("d1.tf");
        var Kv = ReadInfraFile("kv.tf");
        var R2 = ReadInfraFile("r2.tf");
        var Pages = ReadInfraFile("pages.tf");
        Assert.IsTrue(D1.Contains("cloudflare_d1_database", StringComparison.Ordinal), "Must define D1 database resource");
        Assert.IsTrue(Kv.Contains("prtask-sessions", StringComparison.Ordinal), "Must define sessions KV namespace");
        Assert.IsTrue(Kv.Contains("prtask-cache", StringComparison.Ordinal), "Must define cache KV namespace");
        Assert.IsTrue(R2.Contains("prtask-diffs", StringComparison.Ordinal), "Must define diffs R2 bucket");
        Assert.IsTrue(R2.Contains("prtask-avatars", StringComparison.Ordinal), "Must define avatars R2 bucket");
        Assert.IsTrue(Pages.Contains("production_branch = \"main\"", StringComparison.Ordinal), "Pages must deploy from main branch");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform pages must bind custom domains for prtask dot com and www subdomain")]
    public void TerraformPagesMustBindCustomDomainsForPrtaskDotComAndWwwSubdomain()
    {
        var Pages = ReadInfraFile("pages.tf");
        Assert.IsTrue(Pages.Contains("prtask.com", StringComparison.Ordinal), "Pages must bind prtask.com domain");
        Assert.IsTrue(Pages.Contains("www.prtask.com", StringComparison.Ordinal), "Pages must bind www.prtask.com domain");
        Assert.IsTrue(Pages.Contains("cloudflare_pages_domain", StringComparison.Ordinal), "Must define cloudflare_pages_domain resources");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must enable nullable implicit usings and treat warnings as errors")]
    public void DirectoryBuildPropsMustEnableNullableImplicitUsingsAndTreatWarningsAsErrors()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("<Nullable>enable</Nullable>", StringComparison.Ordinal), "Must enable nullable reference types");
        Assert.IsTrue(Props.Contains("<ImplicitUsings>enable</ImplicitUsings>", StringComparison.Ordinal), "Must enable implicit usings");
        Assert.IsTrue(Props.Contains("<TreatWarningsAsErrors>true</TreatWarningsAsErrors>", StringComparison.Ordinal), "Must treat warnings as errors");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must include stylecop roslynator meziantou and sonar analyzers")]
    public void DirectoryBuildPropsMustIncludeStylecopRoslynatorMeziantouAndSonarAnalyzers()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("StyleCop.Analyzers", StringComparison.Ordinal), "Must include StyleCop analyzer");
        Assert.IsTrue(Props.Contains("Roslynator.Analyzers", StringComparison.Ordinal), "Must include Roslynator analyzer");
        Assert.IsTrue(Props.Contains("Meziantou.Analyzer", StringComparison.Ordinal), "Must include Meziantou analyzer");
        Assert.IsTrue(Props.Contains("SonarAnalyzer.CSharp", StringComparison.Ordinal), "Must include SonarAnalyzer");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Directory build props must enable all net analyzers with latest analysis level")]
    public void DirectoryBuildPropsMustEnableAllNetAnalyzersWithLatestAnalysisLevel()
    {
        var Props = ReadRootFile("Directory.Build.props");
        Assert.IsTrue(Props.Contains("<EnableNETAnalyzers>true</EnableNETAnalyzers>", StringComparison.Ordinal), "Must enable .NET analyzers");
        Assert.IsTrue(Props.Contains("<AnalysisLevel>latest-all</AnalysisLevel>", StringComparison.Ordinal), "Must use latest-all analysis level");
        Assert.IsTrue(Props.Contains("<EnforceCodeStyleInBuild>true</EnforceCodeStyleInBuild>", StringComparison.Ordinal), "Must enforce code style in build");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Infrastructure csproj must expose internals to both unit and e2e test assemblies")]
    public void InfrastructureCsprojMustExposeInternalsToUnitAndE2ETestAssemblies()
    {
        var Csproj = ReadSourceFile("PrTask.Infrastructure", "PrTask.Infrastructure.csproj");
        Assert.IsTrue(Csproj.Contains("InternalsVisibleTo Include=\"PrTask.Unit\"", StringComparison.Ordinal), "Infrastructure must expose internals to Unit tests");
        Assert.IsTrue(Csproj.Contains("InternalsVisibleTo Include=\"PrTask.E2E\"", StringComparison.Ordinal), "Infrastructure must expose internals to E2E tests");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui csproj must target android thirty six with com prtask app application id")]
    public void MauiCsprojMustTargetAndroidThirtySixWithComPrtaskAppApplicationId()
    {
        var Csproj = ReadSourceFile("PrTask.Maui", "PrTask.Maui.csproj");
        Assert.IsTrue(Csproj.Contains("net10.0-android36.0", StringComparison.Ordinal), "Maui must target Android 36.0");
        Assert.IsTrue(Csproj.Contains("com.prtask.app", StringComparison.Ordinal), "Maui must use com.prtask.app application ID");
        Assert.IsTrue(Csproj.Contains("<UseMaui>true</UseMaui>", StringComparison.Ordinal), "Maui must enable UseMaui");
        Assert.IsTrue(Csproj.Contains("<RunAOTCompilation>false</RunAOTCompilation>", StringComparison.Ordinal), "Maui must disable AOT compilation");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server csproj must use web sdk with user secrets and internals visible to e2e tests")]
    public void ServerCsprojMustUseWebSdkWithUserSecretsAndInternalsVisibleToE2ETests()
    {
        var Csproj = ReadSourceFile("PrTask.Server", "PrTask.Server.csproj");
        Assert.IsTrue(Csproj.Contains("Microsoft.NET.Sdk.Web", StringComparison.Ordinal), "Server must use Web SDK");
        Assert.IsTrue(Csproj.Contains("UserSecretsId", StringComparison.Ordinal), "Server must have UserSecretsId for local dev");
        Assert.IsTrue(Csproj.Contains("InternalsVisibleTo Include=\"PrTask.E2E\"", StringComparison.Ordinal), "Server must expose internals to E2E tests");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Android manifest must require internet permission and disable cleartext traffic")]
    public void AndroidManifestMustRequireInternetPermissionAndDisableCleartextTraffic()
    {
        var Xml = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "AndroidManifest.xml");
        Assert.IsTrue(Xml.Contains("android.permission.INTERNET", StringComparison.Ordinal), "Manifest must require INTERNET permission");
        Assert.IsTrue(Xml.Contains("ACCESS_NETWORK_STATE", StringComparison.Ordinal), "Manifest must require ACCESS_NETWORK_STATE");
        Assert.IsTrue(Xml.Contains("usesCleartextTraffic=\"false\"", StringComparison.Ordinal), "Manifest must disable cleartext traffic for security");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui main page xaml must use blazor web view with index html host and routes component")]
    public void MauiMainPageXamlMustUseBlazorWebViewWithIndexHtmlHostAndRoutesComponent()
    {
        var Xaml = ReadSourceFile("PrTask.Maui", "MainPage.xaml");
        Assert.IsTrue(Xaml.Contains("BlazorWebView", StringComparison.Ordinal), "MainPage must use BlazorWebView control");
        Assert.IsTrue(Xaml.Contains("wwwroot/index.html", StringComparison.Ordinal), "MainPage must host wwwroot/index.html");
        Assert.IsTrue(Xaml.Contains("RootComponent", StringComparison.Ordinal), "MainPage must define RootComponent");
        Assert.IsTrue(Xaml.Contains("#app", StringComparison.Ordinal), "MainPage must mount at #app selector");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Interop javascript must provide copy to clipboard scroll to top and timezone offset functions")]
    public void InteropJavascriptMustProvideCopyToClipboardScrollToTopAndTimezoneOffsetFunctions()
    {
        var Js = ReadRootFile("scripts", "interop.js");
        Assert.IsTrue(Js.Contains("copyToClipboard", StringComparison.Ordinal), "Interop must have copyToClipboard function");
        Assert.IsTrue(Js.Contains("scrollToTop", StringComparison.Ordinal), "Interop must have scrollToTop function");
        Assert.IsTrue(Js.Contains("getTimezoneOffset", StringComparison.Ordinal), "Interop must have getTimezoneOffset function");
        Assert.IsTrue(Js.Contains("navigator.clipboard", StringComparison.Ordinal), "copyToClipboard must use navigator.clipboard API");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("CI workflow must build and test with dotnet ten on ubuntu and lint javascript and scss")]
    public void CiWorkflowMustBuildAndTestWithDotnetTenOnUbuntuAndLintJavascriptAndScss()
    {
        var Yml = ReadRootFile(".github", "workflows", "ci.yml");
        Assert.IsTrue(Yml.Contains("dotnet-version: 10.0.x", StringComparison.Ordinal), "CI must use .NET 10");
        Assert.IsTrue(Yml.Contains("ubuntu-latest", StringComparison.Ordinal), "CI must run on ubuntu-latest");
        Assert.IsTrue(Yml.Contains("dotnet test", StringComparison.Ordinal), "CI must run dotnet test");
        Assert.IsTrue(Yml.Contains("eslint", StringComparison.Ordinal), "CI must lint JavaScript with ESLint");
        Assert.IsTrue(Yml.Contains("stylelint", StringComparison.Ordinal), "CI must lint SCSS with Stylelint");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Deploy workflow must publish client to cloudflare pages from main branch only")]
    public void DeployWorkflowMustPublishClientToCloudflarePageFromMainBranchOnly()
    {
        var Yml = ReadRootFile(".github", "workflows", "deploy.yml");
        Assert.IsTrue(Yml.Contains("branches: [main]", StringComparison.Ordinal), "Deploy must trigger on main branch push");
        Assert.IsTrue(Yml.Contains("dotnet publish", StringComparison.Ordinal), "Deploy must dotnet publish the client");
        Assert.IsTrue(Yml.Contains("cloudflare/pages-action", StringComparison.Ordinal), "Deploy must use Cloudflare Pages action");
        Assert.IsTrue(Yml.Contains("CLOUDFLARE_API_TOKEN", StringComparison.Ordinal), "Deploy must use Cloudflare API token secret");
        Assert.IsTrue(Yml.Contains("projectName: prtask", StringComparison.Ordinal), "Deploy must target prtask project");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client clear cache html must download fresh wasm assemblies and redirect with cache bust")]
    public void ClientClearCacheHtmlMustDownloadFreshWasmAssembliesAndRedirectWithCacheBust()
    {
        var Html = ReadSourceFile("PrTask.Client", "wwwroot", "clear-cache.html");
        Assert.IsTrue(Html.Contains("serviceWorker", StringComparison.Ordinal), "Clear cache must unregister service workers");
        Assert.IsTrue(Html.Contains(".wasm", StringComparison.Ordinal), "Clear cache must re-download WASM assemblies");
        Assert.IsTrue(Html.Contains("cache: \"no-store\"", StringComparison.Ordinal), "Clear cache must bypass cache with no-store");
        Assert.IsTrue(Html.Contains("prtask-theme", StringComparison.Ordinal), "Clear cache must preserve theme preference across cache clear");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Cloudflare headers file must set no cache no store for index html and framework assets")]
    public void CloudflareHeadersFileMustSetNoCacheNoStoreForIndexHtmlAndFrameworkAssets()
    {
        var Headers = ReadSourceFile("PrTask.Client", "wwwroot", "_headers");
        Assert.IsTrue(Headers.Contains("no-cache, no-store, must-revalidate", StringComparison.Ordinal), "Headers must set aggressive no-cache");
        Assert.IsTrue(Headers.Contains("/_framework/*", StringComparison.Ordinal), "Headers must apply to framework assets");
        Assert.IsTrue(Headers.Contains("/index.html", StringComparison.Ordinal), "Headers must apply to index.html");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Cloudflare redirects file must have spa fallback routing all paths to index html")]
    public void CloudflareRedirectsFileMustHaveSpaFallbackRoutingAllPathsToIndexHtml()
    {
        var Redirects = ReadSourceFile("PrTask.Client", "wwwroot", "_redirects");
        Assert.IsTrue(Redirects.Contains("/*", StringComparison.Ordinal), "Redirects must match all paths");
        Assert.IsTrue(Redirects.Contains("/index.html", StringComparison.Ordinal), "Redirects must route to index.html");
        Assert.IsTrue(Redirects.Contains("200", StringComparison.Ordinal), "Redirects must return 200 for SPA fallback");
    }
}
