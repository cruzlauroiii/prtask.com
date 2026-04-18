namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout must inherit layout component base and inject http client for auth check")]
    public void ClientLayoutMustInheritLayoutComponentBaseAndInjectHttpClientForAuthCheck()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Razor.Contains("LayoutComponentBase", StringComparison.Ordinal), "ClientLayout must inherit LayoutComponentBase");
        Assert.IsTrue(Razor.Contains("@inject HttpClient Http", StringComparison.Ordinal), "ClientLayout must inject HttpClient");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiAuthMe", StringComparison.Ordinal), "ClientLayout must call auth/me for login state");
        Assert.IsTrue(Razor.Contains("IsLoggedIn", StringComparison.Ordinal), "ClientLayout must track IsLoggedIn state");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout must have nav menu with route constants for all main navigation links")]
    public void ClientLayoutMustHaveNavMenuWithRouteConstantsForAllMainNavigationLinks()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Razor.Contains("RouteConstants.Tasks", StringComparison.Ordinal), "ClientLayout must link to Tasks via RouteConstants");
        Assert.IsTrue(Razor.Contains("RouteConstants.Leaderboard", StringComparison.Ordinal), "ClientLayout must link to Leaderboard");
        Assert.IsTrue(Razor.Contains("RouteConstants.Dashboard", StringComparison.Ordinal), "ClientLayout must link to Dashboard");
        Assert.IsTrue(Razor.Contains("nav-brand", StringComparison.Ordinal), "ClientLayout must have brand navigation link");
        Assert.IsTrue(Razor.Contains("page-content", StringComparison.Ordinal), "ClientLayout must wrap body in page-content class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout must use js interop for theme toggle with dark and light mode icons")]
    public void ClientLayoutMustUseJsInteropForThemeToggleWithDarkAndLightModeIcons()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Razor.Contains("prtaskGetTheme", StringComparison.Ordinal), "ClientLayout must call prtaskGetTheme for initial theme");
        Assert.IsTrue(Razor.Contains("prtaskToggleTheme", StringComparison.Ordinal), "ClientLayout must call prtaskToggleTheme on toggle");
        Assert.IsTrue(Razor.Contains("ToggleThemeAsync", StringComparison.Ordinal), "ClientLayout must define ToggleThemeAsync method");
        Assert.IsTrue(Razor.Contains("theme-toggle", StringComparison.Ordinal), "ClientLayout must have theme toggle button");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client routes must use router with client layout as default and not found fallback")]
    public void ClientRoutesMustUseRouterWithClientLayoutAsDefaultAndNotFoundFallback()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Components", "ClientRoutes.razor");
        Assert.IsTrue(Razor.Contains("Router", StringComparison.Ordinal), "ClientRoutes must use Router component");
        Assert.IsTrue(Razor.Contains("ClientLayout", StringComparison.Ordinal), "ClientRoutes must use ClientLayout as default layout");
        Assert.IsTrue(Razor.Contains("RouteView", StringComparison.Ordinal), "ClientRoutes must use RouteView for page rendering");
        Assert.IsTrue(Razor.Contains("NotFound", StringComparison.Ordinal), "ClientRoutes must handle NotFound with fallback");
        Assert.IsTrue(Razor.Contains("Page Not Found", StringComparison.Ordinal), "ClientRoutes must show page not found message");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client program must create webassembly host with client routes root component on app div")]
    public void ClientProgramMustCreateWebassemblyHostWithClientRoutesRootComponentOnAppDiv()
    {
        var Code = ReadSourceFile("PrTask.Client", "Program.cs");
        Assert.IsTrue(Code.Contains("WebAssemblyHostBuilder.CreateDefault", StringComparison.Ordinal), "Client must use WebAssemblyHostBuilder");
        Assert.IsTrue(Code.Contains("ClientRoutes", StringComparison.Ordinal), "Client must register ClientRoutes component");
        Assert.IsTrue(Code.Contains("#app", StringComparison.Ordinal), "Client must mount on #app element");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "Client HttpClient must use AppDomain for base URL");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client index html must have inline theme script with data theme and prefers color scheme")]
    public void ClientIndexHtmlMustHaveInlineThemeScriptWithDataThemeAndPrefersColorScheme()
    {
        var Html = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("prtask-theme", StringComparison.Ordinal), "Index must use prtask-theme localStorage key");
        Assert.IsTrue(Html.Contains("data-theme", StringComparison.Ordinal), "Index must set data-theme attribute on html");
        Assert.IsTrue(Html.Contains("prefers-color-scheme", StringComparison.Ordinal), "Index must detect prefers-color-scheme");
        Assert.IsTrue(Html.Contains("prtaskToggleTheme", StringComparison.Ordinal), "Index must define prtaskToggleTheme function");
        Assert.IsTrue(Html.Contains("prtaskGetTheme", StringComparison.Ordinal), "Index must define prtaskGetTheme function");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client index html must define auth functions for check auth sign out and user storage")]
    public void ClientIndexHtmlMustDefineAuthFunctionsForCheckAuthSignOutAndUserStorage()
    {
        var Html = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("prtaskCheckAuth", StringComparison.Ordinal), "Index must define prtaskCheckAuth function");
        Assert.IsTrue(Html.Contains("prtaskSignOut", StringComparison.Ordinal), "Index must define prtaskSignOut function");
        Assert.IsTrue(Html.Contains("prtaskGetUser", StringComparison.Ordinal), "Index must define prtaskGetUser function");
        Assert.IsTrue(Html.Contains("prtaskSetUser", StringComparison.Ordinal), "Index must define prtaskSetUser function");
        Assert.IsTrue(Html.Contains("/api/auth/me", StringComparison.Ordinal), "prtaskCheckAuth must call auth/me endpoint");
        Assert.IsTrue(Html.Contains("/api/auth/logout", StringComparison.Ordinal), "prtaskSignOut must call auth/logout endpoint");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client index html must reference shared ui css and blazor webassembly js with app div")]
    public void ClientIndexHtmlMustReferenceSharedUiCssAndBlazorWebassemblyJsWithAppDiv()
    {
        var Html = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("_content/PrTask.SharedUI/css/app.css", StringComparison.Ordinal), "Index must link SharedUI app.css");
        Assert.IsTrue(Html.Contains("blazor.webassembly.js", StringComparison.Ordinal), "Index must load blazor.webassembly.js");
        Assert.IsTrue(Html.Contains("id=\"app\"", StringComparison.Ordinal), "Index must have div with id app");
        Assert.IsTrue(Html.Contains("base href=\"/\"", StringComparison.Ordinal), "Index must set base href to root");
        Assert.IsTrue(Html.Contains("PrTask - Earn Money with Pull Requests", StringComparison.Ordinal), "Index must have PrTask title");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Editorconfig must set root true with utf8 charset and space indent for all files")]
    public void EditorconfigMustSetRootTrueWithUtf8CharsetAndSpaceIndentForAllFiles()
    {
        var Config = ReadRootFile(".editorconfig");
        Assert.IsTrue(Config.Contains("root = true", StringComparison.Ordinal), "Editorconfig must be root configuration");
        Assert.IsTrue(Config.Contains("charset = utf-8", StringComparison.Ordinal), "Editorconfig must use UTF-8 charset");
        Assert.IsTrue(Config.Contains("indent_style = space", StringComparison.Ordinal), "Editorconfig must use space indentation");
        Assert.IsTrue(Config.Contains("trim_trailing_whitespace = true", StringComparison.Ordinal), "Editorconfig must trim trailing whitespace");
        Assert.IsTrue(Config.Contains("insert_final_newline = true", StringComparison.Ordinal), "Editorconfig must insert final newline");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Editorconfig must enforce pascal case naming for private fields constants locals and parameters")]
    public void EditorconfigMustEnforcePascalCaseNamingForPrivateFieldsConstantsLocalsAndParameters()
    {
        var Config = ReadRootFile(".editorconfig");
        Assert.IsTrue(Config.Contains("private_fields_pascal", StringComparison.Ordinal), "Editorconfig must define private fields pascal case rule");
        Assert.IsTrue(Config.Contains("constants_pascal", StringComparison.Ordinal), "Editorconfig must define constants pascal case rule");
        Assert.IsTrue(Config.Contains("locals_pascal_case_style", StringComparison.Ordinal), "Editorconfig must define locals pascal case style");
        Assert.IsTrue(Config.Contains("parameters_pascal_case", StringComparison.Ordinal), "Editorconfig must define parameters pascal case rule");
        Assert.IsTrue(Config.Contains("capitalization = pascal_case", StringComparison.Ordinal), "Editorconfig must set pascal_case capitalization");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Editorconfig must suppress stylecop doc comments and pascal case naming conflict diagnostics")]
    public void EditorconfigMustSuppressStylecopDocCommentsAndPascalCaseNamingConflictDiagnostics()
    {
        var Config = ReadRootFile(".editorconfig");
        Assert.IsTrue(Config.Contains("SA1312.severity = none", StringComparison.Ordinal), "Must suppress SA1312 for PascalCase variables");
        Assert.IsTrue(Config.Contains("SA1313.severity = none", StringComparison.Ordinal), "Must suppress SA1313 for PascalCase parameters");
        Assert.IsTrue(Config.Contains("SA1600.severity = none", StringComparison.Ordinal), "Must suppress SA1600 for no XML docs");
        Assert.IsTrue(Config.Contains("SA1633.severity = none", StringComparison.Ordinal), "Must suppress SA1633 for no file headers");
        Assert.IsTrue(Config.Contains("SA1101.severity = none", StringComparison.Ordinal), "Must suppress SA1101 for no this qualifier");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Editorconfig must enforce file scoped namespaces var preferences and braces on all")]
    public void EditorconfigMustEnforceFileScopedNamespacesVarPreferencesAndBracesOnAll()
    {
        var Config = ReadRootFile(".editorconfig");
        Assert.IsTrue(Config.Contains("csharp_style_namespace_declarations = file_scoped:warning", StringComparison.Ordinal), "Must enforce file-scoped namespaces");
        Assert.IsTrue(Config.Contains("csharp_style_var_for_built_in_types = true:warning", StringComparison.Ordinal), "Must prefer var for built-in types");
        Assert.IsTrue(Config.Contains("csharp_new_line_before_open_brace = all", StringComparison.Ordinal), "Must put braces on new line");
        Assert.IsTrue(Config.Contains("csharp_prefer_braces = true:warning", StringComparison.Ordinal), "Must prefer braces");
        Assert.IsTrue(Config.Contains("csharp_style_prefer_primary_constructors = true:warning", StringComparison.Ordinal), "Must prefer primary constructors");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must extend configs all with eqeqeq no eval and complexity limit twenty")]
    public void EslintConfigMustExtendConfigsAllWithEqeqeqNoEvalAndComplexityLimitTwenty()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("js.configs.all", StringComparison.Ordinal), "ESLint must extend all recommended configs");
        Assert.IsTrue(Config.Contains("\"eqeqeq\": \"error\"", StringComparison.Ordinal), "ESLint must enforce strict equality");
        Assert.IsTrue(Config.Contains("\"no-eval\": \"error\"", StringComparison.Ordinal), "ESLint must forbid eval");
        Assert.IsTrue(Config.Contains("\"no-var\": \"error\"", StringComparison.Ordinal), "ESLint must forbid var declarations");
        Assert.IsTrue(Config.Contains("\"complexity\": [\"warn\", 20]", StringComparison.Ordinal), "ESLint must limit cyclomatic complexity to 20");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must extend standard scss with declaration no important and nesting depth four")]
    public void StylelintConfigMustExtendStandardScssWithDeclarationNoImportantAndNestingDepthFour()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("stylelint-config-standard-scss", StringComparison.Ordinal), "Stylelint must extend standard SCSS config");
        Assert.IsTrue(Config.Contains("\"declaration-no-important\": true", StringComparison.Ordinal), "Stylelint must forbid !important");
        Assert.IsTrue(Config.Contains("\"color-named\": \"never\"", StringComparison.Ordinal), "Stylelint must forbid named colors");
        Assert.IsTrue(Config.Contains("\"max-nesting-depth\": [4", StringComparison.Ordinal), "Stylelint must limit nesting to 4 levels");
        Assert.IsTrue(Config.Contains("\"font-weight-notation\": \"numeric\"", StringComparison.Ordinal), "Stylelint must require numeric font weights");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Package json must be private prtask with eslint and stylelint dev dependencies")]
    public void PackageJsonMustBePrivatePrtaskWithEslintAndStylelintDevDependencies()
    {
        var Json = ReadRootFile("package.json");
        Assert.IsTrue(Json.Contains("\"name\": \"prtask\"", StringComparison.Ordinal), "Package name must be prtask");
        Assert.IsTrue(Json.Contains("\"private\": true", StringComparison.Ordinal), "Package must be private");
        Assert.IsTrue(Json.Contains("\"eslint\":", StringComparison.Ordinal), "Package must have eslint dev dependency");
        Assert.IsTrue(Json.Contains("\"stylelint\":", StringComparison.Ordinal), "Package must have stylelint dev dependency");
        Assert.IsTrue(Json.Contains("\"stylelint-config-standard-scss\":", StringComparison.Ordinal), "Package must have stylelint SCSS config");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Web config must define wasm mime type spa fallback routing and http compression")]
    public void WebConfigMustDefineWasmMimeTypeSpaFallbackRoutingAndHttpCompression()
    {
        var Config = ReadRootFile("publish", "web.config");
        Assert.IsTrue(Config.Contains("application/wasm", StringComparison.Ordinal), "Web config must define WASM mime type");
        Assert.IsTrue(Config.Contains("SPA fallback routing", StringComparison.Ordinal), "Web config must have SPA fallback rule");
        Assert.IsTrue(Config.Contains("httpCompression", StringComparison.Ordinal), "Web config must enable HTTP compression");
        Assert.IsTrue(Config.Contains("application/octet-stream", StringComparison.Ordinal), "Web config must define octet-stream for DLLs");
        Assert.IsTrue(Config.Contains("application/font-woff", StringComparison.Ordinal), "Web config must define woff mime type");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Sass compiler json must use compressed style with no source map and generate scoped css")]
    public void SassCompilerJsonMustUseCompressedStyleWithNoSourceMapAndGenerateScopedCss()
    {
        var SharedUi = ReadSourceFile("PrTask.SharedUI", "sasscompiler.json");
        var Server = ReadSourceFile("PrTask.Server", "sasscompiler.json");
        Assert.IsTrue(SharedUi.Contains("--style=compressed", StringComparison.Ordinal), "SharedUI sass must use compressed style");
        Assert.IsTrue(SharedUi.Contains("--no-source-map", StringComparison.Ordinal), "SharedUI sass must disable source maps");
        Assert.IsTrue(SharedUi.Contains("\"GenerateScopedCss\": true", StringComparison.Ordinal), "SharedUI sass must enable scoped CSS");
        Assert.IsTrue(Server.Contains("\"Source\": \"Styles\"", StringComparison.Ordinal), "Server sass must compile from Styles directory");
        Assert.IsTrue(Server.Contains("\"Target\": \"wwwroot/css\"", StringComparison.Ordinal), "Server sass must output to wwwroot/css");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Appsettings json must define github maya config sections with use sandbox true")]
    public void AppsettingsJsonMustDefineGithubMayaConfigSectionsWithUseSandboxTrue()
    {
        var Config = ReadSourceFile("PrTask.Server", "appsettings.json");
        Assert.IsTrue(Config.Contains("\"GitHub\"", StringComparison.Ordinal), "Appsettings must have GitHub config section");
        Assert.IsTrue(Config.Contains("\"ClientId\"", StringComparison.Ordinal), "Appsettings must have ClientId placeholder");
        Assert.IsTrue(Config.Contains("\"ClientSecret\"", StringComparison.Ordinal), "Appsettings must have ClientSecret placeholder");
        Assert.IsTrue(Config.Contains("\"Maya\"", StringComparison.Ordinal), "Appsettings must have Maya config section");
        Assert.IsTrue(Config.Contains("\"UseSandbox\": true", StringComparison.Ordinal), "Appsettings must default Maya to sandbox mode");
        Assert.IsTrue(Config.Contains("\"WebhookSecret\"", StringComparison.Ordinal), "Appsettings must have WebhookSecret placeholder");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform main must use cloudflare provider with required version four point twenty one")]
    public void TerraformMainMustUseCloudflareProviderWithRequiredVersionFourPointTwentyOne()
    {
        var Tf = ReadInfraFile("main.tf");
        Assert.IsTrue(Tf.Contains("cloudflare/cloudflare", StringComparison.Ordinal), "Main.tf must use cloudflare provider source");
        Assert.IsTrue(Tf.Contains("~> 4.21", StringComparison.Ordinal), "Main.tf must require cloudflare version ~> 4.21");
        Assert.IsTrue(Tf.Contains("var.cloudflare_api_key", StringComparison.Ordinal), "Main.tf must reference api_key variable");
        Assert.IsTrue(Tf.Contains("var.cloudflare_email", StringComparison.Ordinal), "Main.tf must reference email variable");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform outputs must expose pages url and project name for deployment reference")]
    public void TerraformOutputsMustExposePagesUrlAndProjectNameForDeploymentReference()
    {
        var Tf = ReadInfraFile("outputs.tf");
        Assert.IsTrue(Tf.Contains("pages_url", StringComparison.Ordinal), "Outputs must define pages_url output");
        Assert.IsTrue(Tf.Contains("pages_project_name", StringComparison.Ordinal), "Outputs must define pages_project_name output");
        Assert.IsTrue(Tf.Contains("cloudflare_pages_project.prtask", StringComparison.Ordinal), "Outputs must reference prtask pages project");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform tfvars example must have all nine required variable placeholders for setup")]
    public void TerraformTfvarsExampleMustHaveAllNineRequiredVariablePlaceholdersForSetup()
    {
        var Tfvars = ReadInfraFile("terraform.tfvars.example");
        Assert.IsTrue(Tfvars.Contains("cloudflare_api_key", StringComparison.Ordinal), "Tfvars example must have cloudflare_api_key");
        Assert.IsTrue(Tfvars.Contains("cloudflare_email", StringComparison.Ordinal), "Tfvars example must have cloudflare_email");
        Assert.IsTrue(Tfvars.Contains("cloudflare_account_id", StringComparison.Ordinal), "Tfvars example must have cloudflare_account_id");
        Assert.IsTrue(Tfvars.Contains("cloudflare_zone_id", StringComparison.Ordinal), "Tfvars example must have cloudflare_zone_id");
        Assert.IsTrue(Tfvars.Contains("maya_public_key", StringComparison.Ordinal), "Tfvars example must have maya_public_key");
        Assert.IsTrue(Tfvars.Contains("maya_secret_key", StringComparison.Ordinal), "Tfvars example must have maya_secret_key");
        Assert.IsTrue(Tfvars.Contains("github_client_id", StringComparison.Ordinal), "Tfvars example must have github_client_id");
        Assert.IsTrue(Tfvars.Contains("github_client_secret", StringComparison.Ordinal), "Tfvars example must have github_client_secret");
        Assert.IsTrue(Tfvars.Contains("session_secret", StringComparison.Ordinal), "Tfvars example must have session_secret");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui program must use maui app with blazor web view and android status bar configuration")]
    public void MauiProgramMustUseMauiAppWithBlazorWebViewAndAndroidStatusBarConfiguration()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MauiProgram.cs");
        Assert.IsTrue(Code.Contains("CreateMauiApp()", StringComparison.Ordinal), "MauiProgram must define CreateMauiApp factory");
        Assert.IsTrue(Code.Contains("UseMauiApp<PrTaskApp>()", StringComparison.Ordinal), "MauiProgram must use PrTaskApp as main app");
        Assert.IsTrue(Code.Contains("AddMauiBlazorWebView()", StringComparison.Ordinal), "MauiProgram must add Blazor WebView");
        Assert.IsTrue(Code.Contains("ConfigureAndroidStatusBar", StringComparison.Ordinal), "MauiProgram must configure Android status bar");
        Assert.IsTrue(Code.Contains("SetDecorFitsSystemWindows", StringComparison.Ordinal), "MauiProgram must set system windows fitting");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth callback activity must handle com prtask app deep link scheme for android oauth")]
    public void AuthCallbackActivityMustHandleComPrtaskAppDeepLinkSchemeForAndroidOauth()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "AuthCallbackActivity.cs");
        Assert.IsTrue(Code.Contains("DataScheme = \"com.prtask.app\"", StringComparison.Ordinal), "AuthCallbackActivity must use com.prtask.app scheme");
        Assert.IsTrue(Code.Contains("DataHost = \"auth\"", StringComparison.Ordinal), "AuthCallbackActivity must use auth host");
        Assert.IsTrue(Code.Contains("WebAuthenticatorCallbackActivity", StringComparison.Ordinal), "AuthCallbackActivity must extend WebAuthenticatorCallbackActivity");
        Assert.IsTrue(Code.Contains("NoHistory = true", StringComparison.Ordinal), "AuthCallbackActivity must not keep history");
        Assert.IsTrue(Code.Contains("Exported = true", StringComparison.Ordinal), "AuthCallbackActivity must be exported for intent handling");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main application must extend maui application and create maui app from maui program")]
    public void MainApplicationMustExtendMauiApplicationAndCreateMauiAppFromMauiProgram()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "MainApplication.cs");
        Assert.IsTrue(Code.Contains("MauiApplication", StringComparison.Ordinal), "MainApplication must extend MauiApplication");
        Assert.IsTrue(Code.Contains("MauiProgram.CreateMauiApp()", StringComparison.Ordinal), "MainApplication must call MauiProgram.CreateMauiApp");
        Assert.IsTrue(Code.Contains("nint Handle", StringComparison.Ordinal), "MainApplication must accept native handle parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App xaml must define application with prtask maui namespace and app class reference")]
    public void AppXamlMustDefineApplicationWithPrtaskMauiNamespaceAndAppClassReference()
    {
        var Xaml = ReadSourceFile("PrTask.Maui", "App.xaml");
        Assert.IsTrue(Xaml.Contains("x:Class=\"PrTask.Maui.PrTaskApp\"", StringComparison.Ordinal), "App.xaml must reference PrTaskApp class");
        Assert.IsTrue(Xaml.Contains("schemas.microsoft.com/dotnet/2021/maui", StringComparison.Ordinal), "App.xaml must use MAUI XML namespace");
    }
}
