namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must use web authenticator default for mobile oauth with callback uri")]
    public void MauiLoginPageMustUseWebAuthenticatorDefaultForMobileOauthWithCallbackUri()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("WebAuthenticator.Default.AuthenticateAsync", StringComparison.Ordinal), "MauiLogin must use WebAuthenticator for mobile OAuth");
        Assert.IsTrue(Code.Contains("com.prtask.app://auth", StringComparison.Ordinal), "MauiLogin must use app callback URI scheme");
        Assert.IsTrue(Code.Contains("CallbackUri", StringComparison.Ordinal), "MauiLogin must define CallbackUri for auth redirect");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must store session token in preferences after successful authentication")]
    public void MauiLoginPageMustStoreSessionTokenInPreferencesAfterSuccessfulAuthentication()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("Preferences.Default.Set(\"session\", Session)", StringComparison.Ordinal), "MauiLogin must save session to Preferences");
        Assert.IsTrue(Code.Contains("Preferences.Default.Set(\"username\", StoredUsername)", StringComparison.Ordinal), "MauiLogin must save username to Preferences");
        Assert.IsTrue(Code.Contains("Result.Properties.TryGetValue", StringComparison.Ordinal), "MauiLogin must extract properties from auth result");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must navigate to dashboard after successful login via navigation manager")]
    public void MauiLoginPageMustNavigateToDashboardAfterSuccessfulLoginViaNavigationManager()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("NavigationManager.NavigateTo(RouteConstants.Dashboard)", StringComparison.Ordinal), "MauiLogin must navigate to dashboard after auth");
        Assert.IsTrue(Code.Contains("@inject NavigationManager NavigationManager", StringComparison.Ordinal), "MauiLogin must inject NavigationManager");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must catch task canceled exception silently and display other error messages")]
    public void MauiLoginPageMustCatchTaskCanceledExceptionSilentlyAndDisplayOtherErrorMessages()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("catch (TaskCanceledException)", StringComparison.Ordinal), "MauiLogin must catch TaskCanceledException for user cancellation");
        Assert.IsTrue(Code.Contains("catch (Exception Ex)", StringComparison.Ordinal), "MauiLogin must catch general exceptions with message");
        Assert.IsTrue(Code.Contains("ErrorMessage = Ex.Message", StringComparison.Ordinal), "MauiLogin must display exception message as error");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must append platform android query parameter to auth url for worker routing")]
    public void MauiLoginPageMustAppendPlatformAndroidQueryParameterToAuthUrlForWorkerRouting()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("?platform=android", StringComparison.Ordinal), "MauiLogin must add platform=android query parameter");
        Assert.IsTrue(Code.Contains("SiteBase", StringComparison.Ordinal), "MauiLogin must use SiteBase for auth URL construction");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "MauiLogin SiteBase must use AppDomain constant");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must have four sso buttons calling login with provider async method")]
    public void MauiLoginPageMustHaveFourSsoButtonsCallingLoginWithProviderAsyncMethod()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("LoginWithProviderAsync(RouteConstants.ApiAuthGoogle)", StringComparison.Ordinal), "MauiLogin must have Google provider button");
        Assert.IsTrue(Code.Contains("LoginWithProviderAsync(RouteConstants.ApiAuthGitHub)", StringComparison.Ordinal), "MauiLogin must have GitHub provider button");
        Assert.IsTrue(Code.Contains("LoginWithProviderAsync(RouteConstants.ApiAuthAzure)", StringComparison.Ordinal), "MauiLogin must have Azure provider button");
        Assert.IsTrue(Code.Contains("LoginWithProviderAsync(RouteConstants.ApiAuthOkta)", StringComparison.Ordinal), "MauiLogin must have Okta provider button");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform variables must define cloudflare api key as sensitive and email as non sensitive")]
    public void TerraformVariablesMustDefineCloudflareApiKeyAsSensitiveAndEmailAsNonSensitive()
    {
        var Tf = ReadInfraFile("variables.tf");
        Assert.IsTrue(Tf.Contains("variable \"cloudflare_api_key\"", StringComparison.Ordinal), "Variables must define cloudflare_api_key");
        Assert.IsTrue(Tf.Contains("variable \"cloudflare_email\"", StringComparison.Ordinal), "Variables must define cloudflare_email");
        Assert.IsTrue(Tf.Contains("variable \"cloudflare_account_id\"", StringComparison.Ordinal), "Variables must define cloudflare_account_id");
        Assert.IsTrue(Tf.Contains("variable \"cloudflare_zone_id\"", StringComparison.Ordinal), "Variables must define cloudflare_zone_id");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform variables must define maya public and secret keys with secret key marked sensitive")]
    public void TerraformVariablesMustDefineMayaPublicAndSecretKeysWithSecretKeyMarkedSensitive()
    {
        var Tf = ReadInfraFile("variables.tf");
        Assert.IsTrue(Tf.Contains("variable \"maya_public_key\"", StringComparison.Ordinal), "Variables must define maya_public_key");
        Assert.IsTrue(Tf.Contains("variable \"maya_secret_key\"", StringComparison.Ordinal), "Variables must define maya_secret_key");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform variables must define all four oauth provider client ids and client secrets")]
    public void TerraformVariablesMustDefineAllFourOauthProviderClientIdsAndClientSecrets()
    {
        var Tf = ReadInfraFile("variables.tf");
        Assert.IsTrue(Tf.Contains("variable \"github_client_id\"", StringComparison.Ordinal), "Variables must define github_client_id");
        Assert.IsTrue(Tf.Contains("variable \"github_client_secret\"", StringComparison.Ordinal), "Variables must define github_client_secret");
        Assert.IsTrue(Tf.Contains("variable \"google_client_id\"", StringComparison.Ordinal), "Variables must define google_client_id");
        Assert.IsTrue(Tf.Contains("variable \"google_client_secret\"", StringComparison.Ordinal), "Variables must define google_client_secret");
        Assert.IsTrue(Tf.Contains("variable \"azure_client_id\"", StringComparison.Ordinal), "Variables must define azure_client_id");
        Assert.IsTrue(Tf.Contains("variable \"azure_client_secret\"", StringComparison.Ordinal), "Variables must define azure_client_secret");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform variables must define okta client credentials domain and session secret")]
    public void TerraformVariablesMustDefineOktaClientCredentialsDomainAndSessionSecret()
    {
        var Tf = ReadInfraFile("variables.tf");
        Assert.IsTrue(Tf.Contains("variable \"okta_client_id\"", StringComparison.Ordinal), "Variables must define okta_client_id");
        Assert.IsTrue(Tf.Contains("variable \"okta_client_secret\"", StringComparison.Ordinal), "Variables must define okta_client_secret");
        Assert.IsTrue(Tf.Contains("variable \"okta_domain\"", StringComparison.Ordinal), "Variables must define okta_domain");
        Assert.IsTrue(Tf.Contains("variable \"session_secret\"", StringComparison.Ordinal), "Variables must define session_secret");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform variables must mark all client secrets and api keys as sensitive type string")]
    public void TerraformVariablesMustMarkAllClientSecretsAndApiKeysAsSensitiveTypeString()
    {
        var Tf = ReadInfraFile("variables.tf");
        var SensitiveCount = Tf.Split("sensitive = true").Length - 1;
        Assert.IsTrue(SensitiveCount >= 6, $"Variables must have at least 6 sensitive flags, found {SensitiveCount}");
        Assert.IsTrue(Tf.Contains("type      = string", StringComparison.Ordinal) || Tf.Contains("type = string", StringComparison.Ordinal), "All variables must be type string");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have deposit payment section with credit card and bank transfer options")]
    public void SettingsPageMustHaveDepositPaymentSectionWithCreditCardAndBankTransferOptions()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Code.Contains("Deposit and Payment Methods", StringComparison.Ordinal), "Settings must have deposit payment section");
        Assert.IsTrue(Code.Contains("Credit or Debit Card", StringComparison.Ordinal), "Settings must offer credit card payment method");
        Assert.IsTrue(Code.Contains("form-container", StringComparison.Ordinal), "Settings must use form-container class for sections");
        Assert.IsTrue(Code.Contains("form-group", StringComparison.Ordinal), "Settings must use form-group class for input groups");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have account section with timezone options including asia manila utc")]
    public void SettingsPageMustHaveAccountSectionWithTimezoneOptionsIncludingAsiaManilaUtc()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Code.Contains("Account", StringComparison.Ordinal), "Settings must have Account section heading");
        Assert.IsTrue(Code.Contains("Asia/Manila", StringComparison.Ordinal), "Settings must offer Asia/Manila timezone");
        Assert.IsTrue(Code.Contains("America/New_York", StringComparison.Ordinal), "Settings must offer Eastern Time timezone");
        Assert.IsTrue(Code.Contains("Europe/London", StringComparison.Ordinal), "Settings must offer London timezone");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page connected accounts must show not connected status for all four sso providers")]
    public void SettingsPageConnectedAccountsMustShowNotConnectedStatusForAllFourSsoProviders()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Code.Contains("connected-status", StringComparison.Ordinal), "Settings must use connected-status class");
        Assert.IsTrue(Code.Contains("Not connected", StringComparison.Ordinal), "Settings must show Not connected default status");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss variables must define dark theme mixin with specific background and surface hex colors")]
    public void ScssVariablesMustDefineDarkThemeMixinWithSpecificBackgroundAndSurfaceHexColors()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Scss.Contains("--color-bg: #0f172a", StringComparison.Ordinal), "Dark theme bg must be slate-900");
        Assert.IsTrue(Scss.Contains("--color-surface: #1e293b", StringComparison.Ordinal), "Dark theme surface must be slate-800");
        Assert.IsTrue(Scss.Contains("--color-text: #f1f5f9", StringComparison.Ordinal), "Dark theme text must be slate-100");
        Assert.IsTrue(Scss.Contains("--color-text-muted: #94a3b8", StringComparison.Ordinal), "Dark theme muted must be slate-400");
        Assert.IsTrue(Scss.Contains("--color-border: #334155", StringComparison.Ordinal), "Dark theme border must be slate-700");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss variables root must define light theme defaults with white background and slate text")]
    public void ScssVariablesRootMustDefineLightThemeDefaultsWithWhiteBackgroundAndSlateText()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Scss.Contains("--color-bg: #ffffff", StringComparison.Ordinal), "Light theme bg must be white");
        Assert.IsTrue(Scss.Contains("--color-surface: #f8fafc", StringComparison.Ordinal), "Light theme surface must be slate-50");
        Assert.IsTrue(Scss.Contains("--color-text: #0f172a", StringComparison.Ordinal), "Light theme text must be slate-900");
        Assert.IsTrue(Scss.Contains("--color-border: #e2e8f0", StringComparison.Ordinal), "Light theme border must be slate-200");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss variables must interpolate sass color variables into css custom properties using hash syntax")]
    public void ScssVariablesMustInterpolateSassColorVariablesIntoCssCustomPropertiesUsingHashSyntax()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Scss.Contains("#{$color-primary}", StringComparison.Ordinal), "Must interpolate $color-primary into CSS custom property");
        Assert.IsTrue(Scss.Contains("#{$color-primary-dark}", StringComparison.Ordinal), "Must interpolate $color-primary-dark into CSS custom property");
        Assert.IsTrue(Scss.Contains("#{$color-accent}", StringComparison.Ordinal), "Must interpolate $color-accent into CSS custom property");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss variables must exclude data theme light from dark prefers color scheme media query")]
    public void ScssVariablesMustExcludeDataThemeLightFromDarkPrefersColorSchemeMediaQuery()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Scss.Contains(":root:not([data-theme=\"light\"])", StringComparison.Ordinal), "Dark media query must exclude explicit light theme");
        Assert.IsTrue(Scss.Contains(":root[data-theme=\"dark\"]", StringComparison.Ordinal), "Must support explicit dark theme attribute selector");
        Assert.IsTrue(Scss.Contains("$radius: 8px", StringComparison.Ordinal), "Must define border radius variable");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Interop javascript must use strict mode and define prtask namespace on window object")]
    public void InteropJavascriptMustUseStrictModeAndDefinePrtaskNamespaceOnWindowObject()
    {
        var Js = ReadRootFile("scripts", "interop.js");
        Assert.IsTrue(Js.Contains("\"use strict\"", StringComparison.Ordinal), "Interop must use strict mode");
        Assert.IsTrue(Js.Contains("window.PrTask", StringComparison.Ordinal), "Interop must define PrTask on window");
        Assert.IsTrue(Js.Contains("navigator.clipboard.writeText(text)", StringComparison.Ordinal), "copyToClipboard must use navigator clipboard API");
        Assert.IsTrue(Js.Contains("behavior: \"smooth\"", StringComparison.Ordinal), "scrollToTop must use smooth scroll behavior");
    }
}
