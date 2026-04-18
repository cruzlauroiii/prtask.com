namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform main must require cloudflare provider version four point twenty one with source path")]
    public void TerraformMainMustRequireCloudflareProviderVersionFourPointTwentyOneWithSourcePath()
    {
        var Tf = ReadInfraFile("main.tf");
        Assert.IsTrue(Tf.Contains("cloudflare/cloudflare", StringComparison.Ordinal), "Main.tf must specify cloudflare provider source");
        Assert.IsTrue(Tf.Contains("~> 4.21", StringComparison.Ordinal), "Main.tf must require cloudflare version ~> 4.21");
        Assert.IsTrue(Tf.Contains("var.cloudflare_api_key", StringComparison.Ordinal), "Main.tf must use api_key variable");
        Assert.IsTrue(Tf.Contains("var.cloudflare_email", StringComparison.Ordinal), "Main.tf must use email variable");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform d1 database must create prtask db resource with account id and output database id")]
    public void TerraformD1DatabaseMustCreatePrtaskDbResourceWithAccountIdAndOutputDatabaseId()
    {
        var Tf = ReadInfraFile("d1.tf");
        Assert.IsTrue(Tf.Contains("cloudflare_d1_database", StringComparison.Ordinal), "D1.tf must use cloudflare_d1_database resource type");
        Assert.IsTrue(Tf.Contains("\"prtask-db\"", StringComparison.Ordinal), "D1.tf must name database prtask-db");
        Assert.IsTrue(Tf.Contains("var.cloudflare_account_id", StringComparison.Ordinal), "D1.tf must use account_id variable");
        Assert.IsTrue(Tf.Contains("d1_database_id", StringComparison.Ordinal), "D1.tf must output d1_database_id");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform dns must create root cname and www cname records pointing to pages project subdomain")]
    public void TerraformDnsMustCreateRootCnameAndWwwCnameRecordsPointingToPagesProjectSubdomain()
    {
        var Tf = ReadInfraFile("dns.tf");
        Assert.IsTrue(Tf.Contains("cloudflare_record", StringComparison.Ordinal), "DNS.tf must use cloudflare_record resource type");
        Assert.IsTrue(Tf.Contains("name    = \"@\"", StringComparison.Ordinal), "DNS.tf must create root @ record");
        Assert.IsTrue(Tf.Contains("name    = \"www\"", StringComparison.Ordinal), "DNS.tf must create www record");
        Assert.IsTrue(Tf.Contains("type    = \"CNAME\"", StringComparison.Ordinal), "DNS.tf must use CNAME record type");
        Assert.IsTrue(Tf.Contains("proxied = true", StringComparison.Ordinal), "DNS.tf must enable Cloudflare proxying");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform dns records must point to cloudflare pages project prtask subdomain content")]
    public void TerraformDnsRecordsMustPointToCloudfarePagesProjectPrtaskSubdomainContent()
    {
        var Tf = ReadInfraFile("dns.tf");
        Assert.IsTrue(Tf.Contains("cloudflare_pages_project.prtask.subdomain", StringComparison.Ordinal), "DNS.tf must point to pages project subdomain");
        Assert.IsTrue(Tf.Contains("cloudflare_zone", StringComparison.Ordinal), "DNS.tf must reference cloudflare_zone data source");
        Assert.IsTrue(Tf.Contains("var.cloudflare_zone_id", StringComparison.Ordinal), "DNS.tf must use zone_id variable");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform kv must create prtask sessions and prtask cache namespaces with output ids")]
    public void TerraformKvMustCreatePrtaskSessionsAndPrtaskCacheNamespacesWithOutputIds()
    {
        var Tf = ReadInfraFile("kv.tf");
        Assert.IsTrue(Tf.Contains("cloudflare_workers_kv_namespace", StringComparison.Ordinal), "KV.tf must use workers_kv_namespace resource type");
        Assert.IsTrue(Tf.Contains("\"prtask-sessions\"", StringComparison.Ordinal), "KV.tf must create prtask-sessions namespace");
        Assert.IsTrue(Tf.Contains("\"prtask-cache\"", StringComparison.Ordinal), "KV.tf must create prtask-cache namespace");
        Assert.IsTrue(Tf.Contains("kv_sessions_id", StringComparison.Ordinal), "KV.tf must output kv_sessions_id");
        Assert.IsTrue(Tf.Contains("kv_cache_id", StringComparison.Ordinal), "KV.tf must output kv_cache_id");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform pages must create project with main production branch and both root and www domains")]
    public void TerraformPagesMustCreateProjectWithMainProductionBranchAndBothRootAndWwwDomains()
    {
        var Tf = ReadInfraFile("pages.tf");
        Assert.IsTrue(Tf.Contains("cloudflare_pages_project", StringComparison.Ordinal), "Pages.tf must use cloudflare_pages_project resource type");
        Assert.IsTrue(Tf.Contains("production_branch = \"main\"", StringComparison.Ordinal), "Pages.tf must set production branch to main");
        Assert.IsTrue(Tf.Contains("\"prtask.com\"", StringComparison.Ordinal), "Pages.tf must create root domain prtask.com");
        Assert.IsTrue(Tf.Contains("\"www.prtask.com\"", StringComparison.Ordinal), "Pages.tf must create www domain www.prtask.com");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform r2 must create prtask diffs and prtask avatars buckets with output bucket names")]
    public void TerraformR2MustCreatePrtaskDiffsAndPrtaskAvatarsBucketsWithOutputBucketNames()
    {
        var Tf = ReadInfraFile("r2.tf");
        Assert.IsTrue(Tf.Contains("cloudflare_r2_bucket", StringComparison.Ordinal), "R2.tf must use cloudflare_r2_bucket resource type");
        Assert.IsTrue(Tf.Contains("\"prtask-diffs\"", StringComparison.Ordinal), "R2.tf must create prtask-diffs bucket");
        Assert.IsTrue(Tf.Contains("\"prtask-avatars\"", StringComparison.Ordinal), "R2.tf must create prtask-avatars bucket");
        Assert.IsTrue(Tf.Contains("r2_diffs_bucket", StringComparison.Ordinal), "R2.tf must output r2_diffs_bucket");
        Assert.IsTrue(Tf.Contains("r2_avatars_bucket", StringComparison.Ordinal), "R2.tf must output r2_avatars_bucket");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform outputs must expose pages url with https prefix and pages project name values")]
    public void TerraformOutputsMustExposePagesTrlWithHttpsPrefixAndPagesProjectNameValues()
    {
        var Tf = ReadInfraFile("outputs.tf");
        Assert.IsTrue(Tf.Contains("pages_url", StringComparison.Ordinal), "Outputs.tf must define pages_url output");
        Assert.IsTrue(Tf.Contains("https://", StringComparison.Ordinal), "Outputs.tf pages_url must include https protocol");
        Assert.IsTrue(Tf.Contains("pages_project_name", StringComparison.Ordinal), "Outputs.tf must define pages_project_name output");
        Assert.IsTrue(Tf.Contains("cloudflare_pages_project.prtask.name", StringComparison.Ordinal), "Outputs.tf must reference pages project name");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform worker script must bind d1 database kv sessions kv cache and two r2 buckets")]
    public void TerraformWorkerScriptMustBindD1DatabaseKvSessionsKvCacheAndTwoR2Buckets()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("d1_database_binding", StringComparison.Ordinal), "Workers.tf must have d1_database_binding");
        Assert.IsTrue(Tf.Contains("name        = \"DB\"", StringComparison.Ordinal), "Workers.tf must bind D1 as DB");
        Assert.IsTrue(Tf.Contains("name         = \"SESSIONS\"", StringComparison.Ordinal), "Workers.tf must bind KV as SESSIONS");
        Assert.IsTrue(Tf.Contains("name         = \"CACHE\"", StringComparison.Ordinal), "Workers.tf must bind KV as CACHE");
        Assert.IsTrue(Tf.Contains("name        = \"DIFFS\"", StringComparison.Ordinal), "Workers.tf must bind R2 as DIFFS");
        Assert.IsTrue(Tf.Contains("name        = \"AVATARS\"", StringComparison.Ordinal), "Workers.tf must bind R2 as AVATARS");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform worker script must use secret text binding for all four oauth client secrets")]
    public void TerraformWorkerScriptMustUseSecretTextBindingForAllFourOauthClientSecrets()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("secret_text_binding", StringComparison.Ordinal), "Workers.tf must use secret_text_binding for secrets");
        Assert.IsTrue(Tf.Contains("name = \"GOOGLE_CLIENT_SECRET\"", StringComparison.Ordinal), "Workers.tf must bind GOOGLE_CLIENT_SECRET as secret");
        Assert.IsTrue(Tf.Contains("name = \"GITHUB_CLIENT_SECRET\"", StringComparison.Ordinal), "Workers.tf must bind GITHUB_CLIENT_SECRET as secret");
        Assert.IsTrue(Tf.Contains("name = \"AZURE_CLIENT_SECRET\"", StringComparison.Ordinal), "Workers.tf must bind AZURE_CLIENT_SECRET as secret");
        Assert.IsTrue(Tf.Contains("name = \"OKTA_CLIENT_SECRET\"", StringComparison.Ordinal), "Workers.tf must bind OKTA_CLIENT_SECRET as secret");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform worker script must use plain text binding for oauth client ids and okta domain")]
    public void TerraformWorkerScriptMustUsePlainTextBindingForOauthClientIdsAndOktaDomain()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("name = \"GOOGLE_CLIENT_ID\"", StringComparison.Ordinal), "Workers.tf must bind GOOGLE_CLIENT_ID as plain text");
        Assert.IsTrue(Tf.Contains("name = \"GITHUB_CLIENT_ID\"", StringComparison.Ordinal), "Workers.tf must bind GITHUB_CLIENT_ID as plain text");
        Assert.IsTrue(Tf.Contains("name = \"AZURE_CLIENT_ID\"", StringComparison.Ordinal), "Workers.tf must bind AZURE_CLIENT_ID as plain text");
        Assert.IsTrue(Tf.Contains("name = \"OKTA_CLIENT_ID\"", StringComparison.Ordinal), "Workers.tf must bind OKTA_CLIENT_ID as plain text");
        Assert.IsTrue(Tf.Contains("name = \"OKTA_DOMAIN\"", StringComparison.Ordinal), "Workers.tf must bind OKTA_DOMAIN as plain text");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform worker route must match prtask com api wildcard pattern on zone id with module enabled")]
    public void TerraformWorkerRouteMustMatchPrtaskComApiWildcardPatternOnZoneIdWithModuleEnabled()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("cloudflare_workers_route", StringComparison.Ordinal), "Workers.tf must use cloudflare_workers_route resource");
        Assert.IsTrue(Tf.Contains("prtask.com/api/*", StringComparison.Ordinal), "Workers.tf route must match prtask.com/api/* pattern");
        Assert.IsTrue(Tf.Contains("module     = true", StringComparison.Ordinal), "Workers.tf must enable module format for worker");
        Assert.IsTrue(Tf.Contains("file(\"${path.module}/worker.js\")", StringComparison.Ordinal), "Workers.tf must load worker.js from module path");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform worker must bind durable object class as task durable object plain text value")]
    public void TerraformWorkerMustBindDurableObjectClassAsTaskDurableObjectPlainTextValue()
    {
        var Tf = ReadInfraFile("workers.tf");
        Assert.IsTrue(Tf.Contains("name = \"DURABLE_OBJECT_CLASS\"", StringComparison.Ordinal), "Workers.tf must bind DURABLE_OBJECT_CLASS");
        Assert.IsTrue(Tf.Contains("text = \"TaskDurableObject\"", StringComparison.Ordinal), "Workers.tf must set durable object to TaskDurableObject");
        Assert.IsTrue(Tf.Contains("name       = \"prtask-api\"", StringComparison.Ordinal), "Workers.tf must name worker script prtask-api");
    }
}
