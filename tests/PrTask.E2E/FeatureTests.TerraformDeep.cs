namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform workers must bind sessions and cache kv namespaces by name to worker script")]
    public void TerraformWorkersMustBindSessionsAndCacheKvNamespacesByNameToWorkerScript()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("name         = \"SESSIONS\"", StringComparison.Ordinal), "Workers must bind KV namespace named SESSIONS");
        Assert.IsTrue(Tf.Contains("name         = \"CACHE\"", StringComparison.Ordinal), "Workers must bind KV namespace named CACHE");
        Assert.IsTrue(Tf.Contains("prtask_sessions", StringComparison.Ordinal), "Sessions binding must reference prtask_sessions namespace");
        Assert.IsTrue(Tf.Contains("prtask_cache", StringComparison.Ordinal), "Cache binding must reference prtask_cache namespace");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform workers must bind diffs and avatars r2 buckets by name to worker script")]
    public void TerraformWorkersMustBindDiffsAndAvatarsR2BucketsByNameToWorkerScript()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("name        = \"DIFFS\"", StringComparison.Ordinal), "Workers must bind R2 bucket named DIFFS");
        Assert.IsTrue(Tf.Contains("name        = \"AVATARS\"", StringComparison.Ordinal), "Workers must bind R2 bucket named AVATARS");
        Assert.IsTrue(Tf.Contains("prtask_diffs", StringComparison.Ordinal), "Diffs binding must reference prtask_diffs bucket");
        Assert.IsTrue(Tf.Contains("prtask_avatars", StringComparison.Ordinal), "Avatars binding must reference prtask_avatars bucket");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform workers must set module true and bind durable object class plain text binding")]
    public void TerraformWorkersMustSetModuleTrueAndBindDurableObjectClassPlainTextBinding()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("module     = true", StringComparison.Ordinal), "Workers script must use ES module format");
        Assert.IsTrue(Tf.Contains("DURABLE_OBJECT_CLASS", StringComparison.Ordinal), "Workers must bind DURABLE_OBJECT_CLASS name");
        Assert.IsTrue(Tf.Contains("TaskDurableObject", StringComparison.Ordinal), "Durable Object class must be TaskDurableObject");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform workers must bind okta domain and azure client secret via secret text binding")]
    public void TerraformWorkersMustBindOktaDomainAndAzureClientSecretViaSecretTextBinding()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("OKTA_DOMAIN", StringComparison.Ordinal), "Workers must bind OKTA_DOMAIN for tenant URL");
        Assert.IsTrue(Tf.Contains("OKTA_CLIENT_SECRET", StringComparison.Ordinal), "Workers must bind Okta client secret");
        Assert.IsTrue(Tf.Contains("AZURE_CLIENT_SECRET", StringComparison.Ordinal), "Workers must bind Azure client secret");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform workers must name worker script prtask api and load content from worker js file")]
    public void TerraformWorkersMustNameWorkerScriptPrtaskApiAndLoadContentFromWorkerJsFile()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("name       = \"prtask-api\"", StringComparison.Ordinal), "Worker script must be named prtask-api");
        Assert.IsTrue(Tf.Contains("file(\"${path.module}/worker.js\")", StringComparison.Ordinal), "Worker content must load from worker.js file");
        Assert.IsTrue(Tf.Contains("cloudflare_workers_script", StringComparison.Ordinal), "Must use cloudflare_workers_script resource type");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform d1 must create prtask db database and output the database id value")]
    public void TerraformD1MustCreatePrtaskDbDatabaseAndOutputTheDatabaseIdValue()
    {
        var Tf = ReadInfraFile("d1.tf");
        Assert.IsTrue(Tf.Contains("name       = \"prtask-db\"", StringComparison.Ordinal), "D1 database must be named prtask-db");
        Assert.IsTrue(Tf.Contains("output \"d1_database_id\"", StringComparison.Ordinal), "Must output the D1 database ID");
        Assert.IsTrue(Tf.Contains("cloudflare_d1_database.prtask.id", StringComparison.Ordinal), "Output must reference database resource ID");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform kv must create sessions and cache namespaces with titles and output their ids")]
    public void TerraformKvMustCreateSessionsAndCacheNamespacesWithTitlesAndOutputTheirIds()
    {
        var Tf = ReadInfraFile("kv.tf");
        Assert.IsTrue(Tf.Contains("title      = \"prtask-sessions\"", StringComparison.Ordinal), "Sessions KV must have prtask-sessions title");
        Assert.IsTrue(Tf.Contains("title      = \"prtask-cache\"", StringComparison.Ordinal), "Cache KV must have prtask-cache title");
        Assert.IsTrue(Tf.Contains("output \"kv_sessions_id\"", StringComparison.Ordinal), "Must output sessions KV namespace ID");
        Assert.IsTrue(Tf.Contains("output \"kv_cache_id\"", StringComparison.Ordinal), "Must output cache KV namespace ID");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform r2 must create diffs and avatars buckets and output their bucket names")]
    public void TerraformR2MustCreateDiffsAndAvatarsBucketsAndOutputTheirBucketNames()
    {
        var Tf = ReadInfraFile("r2.tf");
        Assert.IsTrue(Tf.Contains("name       = \"prtask-diffs\"", StringComparison.Ordinal), "Diffs R2 bucket must be named prtask-diffs");
        Assert.IsTrue(Tf.Contains("name       = \"prtask-avatars\"", StringComparison.Ordinal), "Avatars R2 bucket must be named prtask-avatars");
        Assert.IsTrue(Tf.Contains("output \"r2_diffs_bucket\"", StringComparison.Ordinal), "Must output diffs bucket name");
        Assert.IsTrue(Tf.Contains("output \"r2_avatars_bucket\"", StringComparison.Ordinal), "Must output avatars bucket name");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform pages must use cloudflare account id and set production branch to main")]
    public void TerraformPagesMustUseCloudflareAccountIdAndSetProductionBranchToMain()
    {
        var Tf = ReadInfraFile("pages.tf");
        Assert.IsTrue(Tf.Contains("account_id", StringComparison.Ordinal), "Pages must reference Cloudflare account ID");
        Assert.IsTrue(Tf.Contains("production_branch = \"main\"", StringComparison.Ordinal), "Pages must deploy from main branch");
        Assert.IsTrue(Tf.Contains("name              = \"prtask\"", StringComparison.Ordinal), "Pages project must be named prtask");
        Assert.IsTrue(Tf.Contains("cloudflare_pages_project", StringComparison.Ordinal), "Must use cloudflare_pages_project resource type");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform dns must have data source for zone lookup and root cname record with at symbol")]
    public void TerraformDnsMustHaveDataSourceForZoneLookupAndRootCnameRecordWithAtSymbol()
    {
        var Tf = ReadInfraFile("dns.tf");
        Assert.IsTrue(Tf.Contains("data \"cloudflare_zone\"", StringComparison.Ordinal), "Must have cloudflare_zone data source for zone lookup");
        Assert.IsTrue(Tf.Contains("name    = \"@\"", StringComparison.Ordinal), "Root record must use @ symbol for zone apex");
        Assert.IsTrue(Tf.Contains("cloudflare_pages_project.prtask.subdomain", StringComparison.Ordinal), "CNAME content must point to Pages project subdomain");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform workers route must reference zone id and prtask api script name for routing")]
    public void TerraformWorkersRouteMustReferenceZoneIdAndPrtaskApiScriptNameForRouting()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("zone_id     = var.cloudflare_zone_id", StringComparison.Ordinal), "Workers route must reference zone ID variable");
        Assert.IsTrue(Tf.Contains("script_name = cloudflare_workers_script.prtask_api.name", StringComparison.Ordinal), "Route must reference the prtask_api script");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Cloudflare headers must set pragma no cache and expires zero for clear cache html path")]
    public void CloudflareHeadersMustSetPragmaNoCacheAndExpiresZeroForClearCacheHtmlPath()
    {
        var Headers = ReadSourceFile("PrTask.Client", "wwwroot", "_headers");
        Assert.IsTrue(Headers.Contains("/clear-cache.html", StringComparison.Ordinal), "Headers must target clear-cache.html path");
        Assert.IsTrue(Headers.Contains("Pragma: no-cache", StringComparison.Ordinal), "Clear cache must set Pragma: no-cache header");
        Assert.IsTrue(Headers.Contains("Expires: 0", StringComparison.Ordinal), "Clear cache must set Expires: 0 header");
        Assert.IsTrue(Headers.Contains("must-revalidate", StringComparison.Ordinal), "Headers must include must-revalidate directive");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define pull requests and pull request detail routes with id placeholder")]
    public void RouteConstantsMustDefinePullRequestsAndPullRequestDetailRoutesWithIdPlaceholder()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("PullRequests = \"/prs\"", StringComparison.Ordinal), "RouteConstants must define PullRequests list route");
        Assert.IsTrue(Code.Contains("PullRequestDetail = \"/prs/{0}\"", StringComparison.Ordinal), "RouteConstants must define PullRequestDetail with ID placeholder");
        Assert.IsTrue(Code.Contains("TaskDetail = \"/tasks/{0}\"", StringComparison.Ordinal), "RouteConstants must define TaskDetail with ID placeholder");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define how it works pricing about and download static page routes")]
    public void RouteConstantsMustDefineHowItWorksPricingAboutAndDownloadStaticPageRoutes()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("HowItWorks = \"/how-it-works\"", StringComparison.Ordinal), "RouteConstants must define HowItWorks route");
        Assert.IsTrue(Code.Contains("Pricing = \"/pricing\"", StringComparison.Ordinal), "RouteConstants must define Pricing route");
        Assert.IsTrue(Code.Contains("About = \"/about\"", StringComparison.Ordinal), "RouteConstants must define About route");
        Assert.IsTrue(Code.Contains("Download = \"/download\"", StringComparison.Ordinal), "RouteConstants must define Download route");
        Assert.IsTrue(Code.Contains("Settings = \"/settings\"", StringComparison.Ordinal), "RouteConstants must define Settings route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define cloudflare account id and api base url for infrastructure access")]
    public void AppConstantsMustDefineCloudflareAccountIdAndApiBaseUrlForInfrastructureAccess()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("CloudflareAccountId", StringComparison.Ordinal), "AppConstants must define CloudflareAccountId");
        Assert.IsTrue(Code.Contains("api.cloudflare.com/client/v4", StringComparison.Ordinal), "AppConstants must define Cloudflare API base URL");
        Assert.IsTrue(Code.Contains("static class AppConstants", StringComparison.Ordinal), "AppConstants must be a static class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Google constants must define response type code for authorization code grant flow")]
    public void GoogleConstantsMustDefineResponseTypeCodeForAuthorizationCodeGrantFlow()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "GoogleConstants.cs");
        Assert.IsTrue(Code.Contains("ResponseType = \"code\"", StringComparison.Ordinal), "GoogleConstants must use authorization code response type");
        Assert.IsTrue(Code.Contains("static class GoogleConstants", StringComparison.Ordinal), "GoogleConstants must be a static class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Azure constants must define response type code and common tenant for multi tenant auth")]
    public void AzureConstantsMustDefineResponseTypeCodeAndCommonTenantForMultiTenantAuth()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AzureConstants.cs");
        Assert.IsTrue(Code.Contains("ResponseType = \"code\"", StringComparison.Ordinal), "AzureConstants must use authorization code response type");
        Assert.IsTrue(Code.Contains("CommonTenant = \"common\"", StringComparison.Ordinal), "AzureConstants must define common tenant for multi-org auth");
        Assert.IsTrue(Code.Contains("static class AzureConstants", StringComparison.Ordinal), "AzureConstants must be a static class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Okta constants must define response type code and s256 challenge method for pkce flow")]
    public void OktaConstantsMustDefineResponseTypeCodeAndS256ChallengeMethodForPkceFlow()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "OktaConstants.cs");
        Assert.IsTrue(Code.Contains("ResponseType = \"code\"", StringComparison.Ordinal), "OktaConstants must use authorization code response type");
        Assert.IsTrue(Code.Contains("CodeChallengeMethod = \"S256\"", StringComparison.Ordinal), "OktaConstants must use S256 PKCE challenge method");
        Assert.IsTrue(Code.Contains("static class OktaConstants", StringComparison.Ordinal), "OktaConstants must be a static class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maya constants must define payment token endpoint url for tokenized payment card processing")]
    public void MayaConstantsMustDefinePaymentTokenEndpointUrlForTokenizedPaymentCardProcessing()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(Code.Contains("PaymentTokenEndpoint = \"/payments/v1/payment-tokens\"", StringComparison.Ordinal), "MayaConstants must define payment token endpoint");
        Assert.IsTrue(Code.Contains("static class MayaConstants", StringComparison.Ordinal), "MayaConstants must be a static class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define api auth callback route for github oauth callback handling")]
    public void RouteConstantsMustDefineApiAuthCallbackRouteForGitHubOauthCallbackHandling()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("ApiAuthCallback = \"/api/auth/callback\"", StringComparison.Ordinal), "RouteConstants must define GitHub auth callback route");
        Assert.IsTrue(Code.Contains("static class RouteConstants", StringComparison.Ordinal), "RouteConstants must be a static class");
    }
}
