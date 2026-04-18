using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class ArchitectureTests
{
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI must contain Terms Privacy Refund AcceptableUse and CookiePolicy legal pages")]
    public void TClaudeMd59SharedUiMustContainTermsPrivacyRefundAcceptableUseAndCookiePolicyLegalPages()
    {
        var LegalDir = Path.Combine(SourceRoot, SharedUiProject, "Pages", "Legal");
        var RequiredPages = new[] { "TermsPage.razor", "PrivacyPage.razor", "RefundPage.razor", "AcceptableUsePage.razor", "CookiePolicyPage.razor" };
        var Missing = RequiredPages.Where(Page => !File.Exists(Path.Combine(LegalDir, Page))).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing legal pages: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI must contain NavMenu FooterSection MainLayout and App shared component files")]
    public void TClaudeMd60SharedUiMustContainNavMenuFooterSectionMainLayoutAndAppSharedComponentFiles()
    {
        var ComponentsDir = Path.Combine(SourceRoot, SharedUiProject, "Components");
        var Required = new[] { "NavMenu.razor", "FooterSection.razor", "MainLayout.razor", "App.razor", "Routes.razor" };
        var Missing = Required.Where(File => !System.IO.File.Exists(Path.Combine(ComponentsDir, File))).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing components: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI must contain client CreateTaskPage for job posting with bounty workflow")]
    public void TClaudeMd61SharedUiMustContainClientCreateTaskPageForJobPostingWithBountyWorkflow()
    {
        var ClientDir = Path.Combine(SourceRoot, SharedUiProject, "Pages", "Client");
        Assert.IsTrue(File.Exists(Path.Combine(ClientDir, "CreateTaskPage.razor")), "Missing Client/CreateTaskPage.razor");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI must contain ProfilePage and TaskDetailPage for user and task detail views")]
    public void TClaudeMd62SharedUiMustContainProfilePageAndTaskDetailPageForUserAndTaskDetailViews()
    {
        var PagesDir = Path.Combine(SourceRoot, SharedUiProject, "Pages");
        Assert.IsTrue(File.Exists(Path.Combine(PagesDir, "ProfilePage.razor")), "Missing ProfilePage.razor");
        Assert.IsTrue(File.Exists(Path.Combine(PagesDir, "TaskDetailPage.razor")), "Missing TaskDetailPage.razor");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI Imports razor must reference AspNetCore Components namespaces for Blazor support")]
    public void TClaudeMd63SharedUiImportsRazorMustReferenceAspNetCoreComponentsNamespacesForBlazorSupport()
    {
        var ImportsPath = Path.Combine(SourceRoot, SharedUiProject, "_Imports.razor");
        Assert.IsTrue(File.Exists(ImportsPath), "_Imports.razor not found in SharedUI");
        var Content = File.ReadAllText(ImportsPath);
        Assert.IsTrue(Content.Contains("Microsoft.AspNetCore.Components"), "_Imports.razor missing Components namespace");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Solution file must reference all required project files for complete build graph")]
    public void TClaudeMd64SolutionFileMustReferenceAllRequiredProjectFilesForCompleteBuildGraph()
    {
        var SlnFiles = Directory.GetFiles(SolutionRoot, "*.sln");
        Assert.IsTrue(SlnFiles.Length > 0, "No .sln file found in solution root");
        var SlnContent = File.ReadAllText(SlnFiles[0]);
        var RequiredProjects = new[] { DomainProject, ApplicationProject, InfrastructureProject, ServerProject, SharedUiProject, ClientProject, MauiProject, E2EProject };
        var Missing = RequiredProjects.Where(P => !SlnContent.Contains(P)).ToList();
        Assert.AreEqual(0, Missing.Count, $"Solution missing projects: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Editor config must suppress StyleCop SA1312 SA1313 SA1306 for PascalCase local naming convention")]
    public void TClaudeMd65EditorConfigMustSuppressStyleCopSa1312Sa1313Sa1306ForPascalCaseLocalNamingConvention()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, ".editorconfig"));
        Assert.IsTrue(Content.Contains("SA1312"), ".editorconfig missing SA1312 suppression for PascalCase locals");
        Assert.IsTrue(Content.Contains("SA1313"), ".editorconfig missing SA1313 suppression for PascalCase params");
        Assert.IsTrue(Content.Contains("SA1306"), ".editorconfig missing SA1306 suppression for PascalCase fields");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Directory build props must generate documentation file for XML doc analysis support")]
    public void TClaudeMd66DirectoryBuildPropsMustGenerateDocumentationFileForXmlDocAnalysisSupport()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(Content.Contains("<GenerateDocumentationFile>true</GenerateDocumentationFile>"), "Missing GenerateDocumentationFile");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Directory build props must set analysis mode to AllEnabledByDefault for maximum coverage")]
    public void TClaudeMd67DirectoryBuildPropsMustSetAnalysisModeToAllEnabledByDefaultForMaximumCoverage()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(Content.Contains("<AnalysisMode>AllEnabledByDefault</AnalysisMode>"), "Missing AnalysisMode AllEnabledByDefault");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All Razor page files must contain page directive with route for navigation routing")]
    public void TClaudeMd68AllRazorPageFilesMustContainPageDirectiveWithRouteForNavigationRouting()
    {
        var PagesDir = Path.Combine(SourceRoot, SharedUiProject, "Pages");
        var RazorPages = Directory.EnumerateFiles(PagesDir, "*.razor", SearchOption.AllDirectories).ToList();
        var Missing = new List<string>();
        foreach (var Page in RazorPages)
        {
            var Content = File.ReadAllText(Page);
            if (!Content.Contains("@page"))
            {
                Missing.Add(Path.GetFileName(Page));
            }
        }
        Assert.AreEqual(0, Missing.Count, $"Pages without @page directive: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Domain constants directory must contain all required constant files for application configuration")]
    public void TClaudeMd69DomainConstantsDirectoryMustContainAllRequiredConstantFilesForApplicationConfiguration()
    {
        var ConstantsDir = Path.Combine(SourceRoot, DomainProject, "Constants");
        var Required = new[] { "AppConstants.cs", "RouteConstants.cs", "MayaConstants.cs", "GitHubConstants.cs", "BadgeConstants.cs", "GoogleConstants.cs", "AzureConstants.cs", "OktaConstants.cs" };
        var Missing = Required.Where(File => !System.IO.File.Exists(Path.Combine(ConstantsDir, File))).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing constant files: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Domain models directory must contain all required entity and enum files for data modeling")]
    public void TClaudeMd70DomainModelsDirectoryMustContainAllRequiredEntityAndEnumFilesForDataModeling()
    {
        var ModelsDir = Path.Combine(SourceRoot, DomainProject, "Models");
        var Required = new[] { "UserEntity.cs", "TaskEntity.cs", "PullRequestEntity.cs", "PaymentEntity.cs", "LeaderboardEntry.cs", "AchievementEntity.cs" };
        var Missing = Required.Where(File => !System.IO.File.Exists(Path.Combine(ModelsDir, File))).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing model files: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Infrastructure services directory must contain all eight required service implementation files")]
    public void TClaudeMd71InfrastructureServicesDirectoryMustContainAllEightRequiredServiceImplementationFiles()
    {
        var ServicesDir = Path.Combine(SourceRoot, InfrastructureProject, "Services");
        var Required = new[] { "TaskService.cs", "PullRequestService.cs", "UserService.cs", "PaymentService.cs", "LeaderboardService.cs", "AchievementService.cs", "ComplexityScoringService.cs", "DiffSanitizationService.cs" };
        var Missing = Required.Where(File => !System.IO.File.Exists(Path.Combine(ServicesDir, File))).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing service files: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI SCSS styles directory must contain app scss and variables scss for theming")]
    public void TClaudeMd72SharedUiScssStylesDirectoryMustContainAppScssAndVariablesScssForTheming()
    {
        var StylesDir = Path.Combine(SourceRoot, SharedUiProject, "Styles");
        Assert.IsTrue(File.Exists(Path.Combine(StylesDir, "app.scss")), "Missing Styles/app.scss");
        Assert.IsTrue(File.Exists(Path.Combine(StylesDir, "_variables.scss")), "Missing Styles/_variables.scss");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Infrastructure directory must contain OpenTofu terraform files for cloud deployment configuration")]
    public void TClaudeMd73InfrastructureDirectoryMustContainOpenTofuTerraformFilesForCloudDeploymentConfiguration()
    {
        var InfraDir = Path.Combine(SolutionRoot, "infra");
        Assert.IsTrue(Directory.Exists(InfraDir), "infra/ directory must exist for OpenTofu configuration");
        var TfFiles = Directory.GetFiles(InfraDir, "*.tf");
        Assert.IsTrue(TfFiles.Length > 0, "No .tf files found in infra/ directory");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OpenTofu main config must require Cloudflare provider for free tier hosting deployment")]
    public void TClaudeMd74OpenTofuMainConfigMustRequireCloudflareProviderForFreeTierHostingDeployment()
    {
        var MainTf = Path.Combine(SolutionRoot, "infra", "main.tf");
        Assert.IsTrue(File.Exists(MainTf), "infra/main.tf must exist");
        var Content = File.ReadAllText(MainTf);
        Assert.IsTrue(Content.Contains("cloudflare"), "main.tf must reference Cloudflare provider");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OpenTofu pages config must define Cloudflare Pages project for static Blazor WASM hosting")]
    public void TClaudeMd75OpenTofuPagesConfigMustDefineCloudflarePageProjectForStaticBlazorWasmHosting()
    {
        var PagesTf = Path.Combine(SolutionRoot, "infra", "pages.tf");
        Assert.IsTrue(File.Exists(PagesTf), "infra/pages.tf must exist");
        var Content = File.ReadAllText(PagesTf);
        Assert.IsTrue(Content.Contains("cloudflare_pages_project"), "pages.tf must define cloudflare_pages_project");
        Assert.IsTrue(Content.Contains("cloudflare_pages_domain"), "pages.tf must define cloudflare_pages_domain");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OpenTofu DNS config must define Cloudflare zone and DNS records for domain routing")]
    public void TClaudeMd76OpenTofuDnsConfigMustDefineCloudflareZoneAndDnsRecordsForDomainRouting()
    {
        var DnsTf = Path.Combine(SolutionRoot, "infra", "dns.tf");
        Assert.IsTrue(File.Exists(DnsTf), "infra/dns.tf must exist");
        var Content = File.ReadAllText(DnsTf);
        Assert.IsTrue(Content.Contains("cloudflare_zone"), "dns.tf must define cloudflare_zone");
        Assert.IsTrue(Content.Contains("cloudflare_record"), "dns.tf must define cloudflare_record");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OpenTofu variables must define sensitive secrets for API tokens and client credentials")]
    public void TClaudeMd77OpenTofuVariablesMustDefineSensitiveSecretsForApiTokensAndClientCredentials()
    {
        var VarsTf = Path.Combine(SolutionRoot, "infra", "variables.tf");
        Assert.IsTrue(File.Exists(VarsTf), "infra/variables.tf must exist");
        var Content = File.ReadAllText(VarsTf);
        Assert.IsTrue(Content.Contains("sensitive"), "variables.tf must mark secrets as sensitive");
        Assert.IsTrue(Content.Contains("cloudflare_api_key"), "variables.tf must define cloudflare_api_key");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OpenTofu outputs must expose pages URL and project name for deployment verification")]
    public void TClaudeMd78OpenTofuOutputsMustExposePageUrlAndProjectNameForDeploymentVerification()
    {
        var OutputsTf = Path.Combine(SolutionRoot, "infra", "outputs.tf");
        Assert.IsTrue(File.Exists(OutputsTf), "infra/outputs.tf must exist");
        var Content = File.ReadAllText(OutputsTf);
        Assert.IsTrue(Content.Contains("output"), "outputs.tf must define outputs");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OpenTofu example vars file must exist for onboarding with all required variable placeholders")]
    public void TClaudeMd79OpenTofuExampleVarsFileMustExistForOnboardingWithAllRequiredVariablePlaceholders()
    {
        var ExampleVars = Path.Combine(SolutionRoot, "infra", "terraform.tfvars.example");
        Assert.IsTrue(File.Exists(ExampleVars), "infra/terraform.tfvars.example must exist for developer onboarding");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Auth endpoints must map callback routes for all four SSO providers including OIDC callbacks")]
    public void TClaudeMd82AuthEndpointsMustMapCallbackRoutesForAllFourSsoProvidersIncludingOidcCallbacks()
    {
        var AuthFile = Path.Combine(SourceRoot, ServerProject, "Endpoints", "AuthEndpoints.cs");
        var Content = File.ReadAllText(AuthFile);
        Assert.IsTrue(Content.Contains("ApiAuthCallback"), "AuthEndpoints must map GitHub callback route");
        Assert.IsTrue(Content.Contains("ApiAuthCallbackGoogle"), "AuthEndpoints must map Google callback route");
        Assert.IsTrue(Content.Contains("ApiAuthCallbackAzure"), "AuthEndpoints must map Azure callback route");
        Assert.IsTrue(Content.Contains("ApiAuthCallbackOkta"), "AuthEndpoints must map Okta callback route");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Server Program must configure cookie authentication with secure settings for session management")]
    public void TClaudeMd84ServerProgramMustConfigureCookieAuthenticationWithSecureSettingsForSessionManagement()
    {
        var ProgramFile = Path.Combine(SourceRoot, ServerProject, "Program.cs");
        var Content = File.ReadAllText(ProgramFile);
        Assert.IsTrue(Content.Contains("CookieAuthenticationDefaults"), "Program.cs must configure cookie auth");
        Assert.IsTrue(Content.Contains("HttpOnly"), "Program.cs must set HttpOnly on cookies");
        Assert.IsTrue(Content.Contains("SecurePolicy"), "Program.cs must set secure cookie policy");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Cloudflare Pages project must be configured for direct upload deployment via OpenTofu")]
    public void TClaudeMd86CloudflarePagesProjectMustBeConfiguredForDirectUploadDeploymentViaOpenTofu()
    {
        var PagesTf = Path.Combine(SolutionRoot, "infra", "pages.tf");
        var Content = File.ReadAllText(PagesTf);
        Assert.IsTrue(Content.Contains("cloudflare_pages_project"), "pages.tf must define cloudflare_pages_project");
        Assert.IsTrue(Content.Contains("prtask.com"), "pages.tf must configure prtask.com domain");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Client project must have single index HTML file as entry point for serverless deployment")]
    public void TClaudeMd87ClientProjectMustHaveSingleIndexHtmlFileAsEntryPointForServerlessDeployment()
    {
        var IndexHtml = Path.Combine(SourceRoot, ClientProject, "wwwroot", "index.html");
        Assert.IsTrue(File.Exists(IndexHtml), "Client wwwroot/index.html must exist");
        var Content = File.ReadAllText(IndexHtml);
        Assert.IsTrue(Content.Contains("blazor.webassembly.js"), "index.html must reference blazor.webassembly.js for WASM loading");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Client project must use Blazor WebAssembly SDK producing WASM output for serverless hosting")]
    public void TClaudeMd88ClientProjectMustUseBlazorWebAssemblySdkProducingWasmOutputForServerlessHosting()
    {
        var ClientProj = Path.Combine(SourceRoot, ClientProject, $"{ClientProject}.csproj");
        var Content = File.ReadAllText(ClientProj);
        Assert.IsTrue(Content.Contains("Microsoft.NET.Sdk.BlazorWebAssembly"), "Client must use BlazorWebAssembly SDK for WASM output");
        Assert.IsTrue(Content.Contains("Microsoft.AspNetCore.Components.WebAssembly"), "Client must reference WebAssembly runtime package");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Client project must have Cloudflare Pages redirects file for single page application routing")]
    public void TClaudeMd89ClientProjectMustHaveCloudflarePageRedirectsFileForSinglePageApplicationRouting()
    {
        var RedirectsFile = Path.Combine(SourceRoot, ClientProject, "wwwroot", "_redirects");
        Assert.IsTrue(File.Exists(RedirectsFile), "_redirects file must exist for SPA routing");
        var Content = File.ReadAllText(RedirectsFile);
        Assert.IsTrue(Content.Contains("/index.html"), "_redirects must route all paths to index.html");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OpenTofu must define Cloudflare D1 SQL database resource for serverless relational persistence")]
    public void TClaudeMd90OpenTofuMustDefineCloudflareD1SqlDatabaseResourceForServerlessRelationalPersistence()
    {
        var D1Tf = Path.Combine(SolutionRoot, "infra", "d1.tf");
        Assert.IsTrue(File.Exists(D1Tf), "infra/d1.tf must exist for D1 database config");
        var Content = File.ReadAllText(D1Tf);
        Assert.IsTrue(Content.Contains("cloudflare_d1_database"), "d1.tf must define cloudflare_d1_database resource");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OpenTofu must define Cloudflare KV namespace resources for serverless key value storage")]
    public void TClaudeMd91OpenTofuMustDefineCloudflareKvNamespaceResourcesForServerlessKeyValueStorage()
    {
        var KvTf = Path.Combine(SolutionRoot, "infra", "kv.tf");
        Assert.IsTrue(File.Exists(KvTf), "infra/kv.tf must exist for KV namespace config");
        var Content = File.ReadAllText(KvTf);
        Assert.IsTrue(Content.Contains("cloudflare_workers_kv_namespace"), "kv.tf must define cloudflare_workers_kv_namespace resource");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OpenTofu must define Cloudflare R2 bucket resources for serverless object storage persistence")]
    public void TClaudeMd92OpenTofuMustDefineCloudflareR2BucketResourcesForServerlessObjectStoragePersistence()
    {
        var R2Tf = Path.Combine(SolutionRoot, "infra", "r2.tf");
        Assert.IsTrue(File.Exists(R2Tf), "infra/r2.tf must exist for R2 bucket config");
        var Content = File.ReadAllText(R2Tf);
        Assert.IsTrue(Content.Contains("cloudflare_r2_bucket"), "r2.tf must define cloudflare_r2_bucket resource");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OpenTofu must define Cloudflare Workers script with D1 KV and R2 bindings for API backend")]
    public void TClaudeMd93OpenTofuMustDefineCloudflareWorkersScriptWithD1KvAndR2BindingsForApiBackend()
    {
        var WorkersTf = Path.Combine(SolutionRoot, "infra", "workers.tf");
        Assert.IsTrue(File.Exists(WorkersTf), "infra/workers.tf must exist for Workers config");
        var Content = File.ReadAllText(WorkersTf);
        Assert.IsTrue(Content.Contains("cloudflare_workers_script"), "workers.tf must define cloudflare_workers_script resource");
        Assert.IsTrue(Content.Contains("d1_database_binding"), "workers.tf must bind D1 database to worker");
        Assert.IsTrue(Content.Contains("kv_namespace_binding"), "workers.tf must bind KV namespace to worker");
        Assert.IsTrue(Content.Contains("r2_bucket_binding"), "workers.tf must bind R2 bucket to worker");
    }
}
