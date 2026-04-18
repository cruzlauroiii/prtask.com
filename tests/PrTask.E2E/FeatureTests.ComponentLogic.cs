namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must use js interop to call prtask get theme on first render for initial icon")]
    public void NavMenuMustUseJsInteropToCallPrtaskGetThemeOnFirstRenderForInitialIcon()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("prtaskGetTheme", StringComparison.Ordinal), "NavMenu must call prtaskGetTheme JS function");
        Assert.IsTrue(Code.Contains("OnAfterRenderAsync(bool firstRender)", StringComparison.Ordinal), "NavMenu must override OnAfterRenderAsync");
        Assert.IsTrue(Code.Contains("if (firstRender)", StringComparison.Ordinal), "NavMenu must only init on first render");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu theme toggle must switch icon between sun and moon characters based on theme")]
    public void NavMenuThemeToggleMustSwitchIconBetweenSunAndMoonCharactersBasedOnTheme()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("prtaskToggleTheme", StringComparison.Ordinal), "NavMenu must call prtaskToggleTheme on toggle");
        Assert.IsTrue(Code.Contains("ToggleThemeAsync", StringComparison.Ordinal), "NavMenu must have ToggleThemeAsync method");
        Assert.IsTrue(Code.Contains("ThemeIcon", StringComparison.Ordinal), "NavMenu must track ThemeIcon property");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu sign out must call prtask sign out js function and clear auth state")]
    public void NavMenuSignOutMustCallPrtaskSignOutJsFunctionAndClearAuthState()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("prtaskSignOut", StringComparison.Ordinal), "NavMenu must call prtaskSignOut JS function");
        Assert.IsTrue(Code.Contains("IsAuthenticated = false", StringComparison.Ordinal), "SignOut must set IsAuthenticated to false");
        Assert.IsTrue(Code.Contains("CurrentUser = string.Empty", StringComparison.Ordinal), "SignOut must clear CurrentUser");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must call prtask check auth on first render to detect logged in user state")]
    public void NavMenuMustCallPrtaskCheckAuthOnFirstRenderToDetectLoggedInUserState()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("prtaskCheckAuth", StringComparison.Ordinal), "NavMenu must call prtaskCheckAuth for auth state");
        Assert.IsTrue(Code.Contains("IsAuthenticated = true", StringComparison.Ordinal), "Must set IsAuthenticated when user found");
        Assert.IsTrue(Code.Contains("CurrentUser = User", StringComparison.Ordinal), "Must set CurrentUser from JS result");
        Assert.IsTrue(Code.Contains("StateHasChanged()", StringComparison.Ordinal), "Must call StateHasChanged after auth check");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu mobile toggle must use inline onclick to toggle nav open class on nav links")]
    public void NavMenuMobileToggleMustUseInlineOnclickToToggleNavOpenClassOnNavLinks()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("classList.toggle('nav-open')", StringComparison.Ordinal), "Hamburger must toggle nav-open class");
        Assert.IsTrue(Code.Contains("classList.remove('nav-open')", StringComparison.Ordinal), "Links must remove nav-open on click");
        Assert.IsTrue(Code.Contains("&#9776;", StringComparison.Ordinal), "Hamburger must use trigram character entity");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer section must have two footer columns for platform and legal links with headings")]
    public void FooterSectionMustHaveTwoFooterColumnsForPlatformAndLegalLinksWithHeadings()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Code.Contains("footer-column", StringComparison.Ordinal), "Footer must use footer-column class");
        Assert.IsTrue(Code.Contains("<h4>Platform</h4>", StringComparison.Ordinal), "Footer must have Platform column heading");
        Assert.IsTrue(Code.Contains("<h4>Legal</h4>", StringComparison.Ordinal), "Footer must have Legal column heading");
        Assert.IsTrue(Code.Contains("footer-bottom", StringComparison.Ordinal), "Footer must have footer-bottom section");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer section legal column must link to acceptable use and cookie policy pages")]
    public void FooterSectionLegalColumnMustLinkToAcceptableUseAndCookiePolicyPages()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Code.Contains("/legal/acceptable-use", StringComparison.Ordinal), "Footer must link to acceptable use policy");
        Assert.IsTrue(Code.Contains("/legal/cookie-policy", StringComparison.Ordinal), "Footer must link to cookie policy");
        Assert.IsTrue(Code.Contains("/legal/licenses", StringComparison.Ordinal), "Footer must link to licenses page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must bind form fields with at bind directive for two way data binding")]
    public void CreateTaskPageMustBindFormFieldsWithAtBindDirectiveForTwoWayDataBinding()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Code.Contains("@bind=\"Title\"", StringComparison.Ordinal), "CreateTask must bind Title field");
        Assert.IsTrue(Code.Contains("@bind=\"Description\"", StringComparison.Ordinal), "CreateTask must bind Description field");
        Assert.IsTrue(Code.Contains("@bind=\"RepoUrl\"", StringComparison.Ordinal), "CreateTask must bind RepoUrl field");
        Assert.IsTrue(Code.Contains("@bind=\"SelectedComplexity\"", StringComparison.Ordinal), "CreateTask must bind Complexity selector");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must enumerate task complexity values from domain model for selector")]
    public void CreateTaskPageMustEnumerateTaskComplexityValuesFromDomainModelForSelector()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Code.Contains("Enum.GetValues<TaskComplexity>()", StringComparison.Ordinal), "CreateTask must enumerate TaskComplexity values");
        Assert.IsTrue(Code.Contains("SelectedComplexity", StringComparison.Ordinal), "CreateTask must have SelectedComplexity property");
        Assert.IsTrue(Code.Contains("TaskComplexity.Medium", StringComparison.Ordinal), "Default complexity must be Medium");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must convert bounty dollars to cents and split tags by comma for entity")]
    public void CreateTaskPageMustConvertBountyDollarsToCentsAndSplitTagsByCommaForEntity()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Code.Contains("BountyAmountPesos * 100L", StringComparison.Ordinal), "CreateTask must convert dollars to cents");
        Assert.IsTrue(Code.Contains("TagsInput.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)", StringComparison.Ordinal), "CreateTask must split tags by comma with trim");
        Assert.IsTrue(Code.Contains("Guid.NewGuid().ToString()", StringComparison.Ordinal), "CreateTask must generate GUID for task ID");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must use max length attributes from app constants for title and description")]
    public void CreateTaskPageMustUseMaxLengthAttributesFromAppConstantsForTitleAndDescription()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Code.Contains("AppConstants.MaxTaskTitleLength", StringComparison.Ordinal), "CreateTask must enforce MaxTaskTitleLength");
        Assert.IsTrue(Code.Contains("AppConstants.MaxTaskDescriptionLength", StringComparison.Ordinal), "CreateTask must enforce MaxTaskDescriptionLength");
        Assert.IsTrue(Code.Contains("AppConstants.MinBountyAmountCents", StringComparison.Ordinal), "CreateTask must enforce MinBountyAmountCents");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Repository page must have public and private visibility options with descriptive labels")]
    public void RepositoryPageMustHavePublicAndPrivateVisibilityOptionsWithDescriptiveLabels()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(Code.Contains("Public - Anyone can view the source code", StringComparison.Ordinal), "Repository must describe public visibility");
        Assert.IsTrue(Code.Contains("Private - Only assigned developers can view the code", StringComparison.Ordinal), "Repository must describe private visibility");
        Assert.IsTrue(Code.Contains("No repositories added yet", StringComparison.Ordinal), "Repository must show empty state message");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App scss must use variables partial import and define touch action manipulation on html body")]
    public void AppScssMustUseVariablesPartialImportAndDefineTouchActionManipulationOnHtmlBody()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "app.scss");
        Assert.IsTrue(Scss.Contains("@use \"variables\" as *", StringComparison.Ordinal), "App SCSS must import variables with as * namespace");
        Assert.IsTrue(Scss.Contains("touch-action: manipulation", StringComparison.Ordinal), "Must set touch-action manipulation on html body");
        Assert.IsTrue(Scss.Contains("word-break: break-word", StringComparison.Ordinal), "Body must have word-break: break-word for text wrapping");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App scss must define app container with flex column layout and min height hundred dvh")]
    public void AppScssMustDefineAppContainerWithFlexColumnLayoutAndMinHeightHundredDvh()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "app.scss");
        Assert.IsTrue(Scss.Contains("min-height: 100dvh", StringComparison.Ordinal), "App container must use 100dvh for full viewport");
        Assert.IsTrue(Scss.Contains("flex-direction: column", StringComparison.Ordinal), "App container must use column flex direction");
        Assert.IsTrue(Scss.Contains("max-width: 1200px", StringComparison.Ordinal), "Page content must have 1200px max width");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App scss must define btn primary and btn secondary with proper color and border styles")]
    public void AppScssMustDefineBtnPrimaryAndBtnSecondaryWithProperColorAndBorderStyles()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "app.scss");
        Assert.IsTrue(Scss.Contains(".btn-primary", StringComparison.Ordinal), "App SCSS must define btn-primary class");
        Assert.IsTrue(Scss.Contains(".btn-secondary", StringComparison.Ordinal), "App SCSS must define btn-secondary class");
        Assert.IsTrue(Scss.Contains("font-weight: 600", StringComparison.Ordinal), "Buttons must have font-weight 600");
        Assert.IsTrue(Scss.Contains("inline-flex", StringComparison.Ordinal), "Buttons must use inline-flex display");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App scss nav menu must use safe area inset top padding for android status bar support")]
    public void AppScssNavMenuMustUseSafeAreaInsetTopPaddingForAndroidStatusBarSupport()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "app.scss");
        Assert.IsTrue(Scss.Contains("env(safe-area-inset-top", StringComparison.Ordinal), "Nav menu must use safe-area-inset-top");
        Assert.IsTrue(Scss.Contains("justify-content: space-between", StringComparison.Ordinal), "Nav menu must justify between brand and links");
        Assert.IsTrue(Scss.Contains("nav-brand", StringComparison.Ordinal), "Nav must define nav-brand class");
        Assert.IsTrue(Scss.Contains("theme-toggle", StringComparison.Ordinal), "Nav must define theme-toggle class");
    }
}
