namespace PrTask.Domain.Constants;
public static class HtmlConstants
{
    public const string Charset = "charset";
    public const string Utf8 = "utf-8";
    public const string Viewport = "viewport";
    public const string ViewportValue = "width=device-width, initial-scale=1.0";
    public const string ThemeColor = "theme-color";
    public const string ThemeColorValue = "#1a1a2e";
    public const string Description = "description";
    public const string OgTitle = "og:title";
    public const string OgDescription = "og:description";
    public const string OgType = "og:type";
    public const string OgUrl = "og:url";
    public const string OgSiteName = "og:site_name";
    public const string TwitterCard = "twitter:card";
    public const string TwitterTitle = "twitter:title";
    public const string TwitterDescription = "twitter:description";
    public const string Canonical = "canonical";
    public const string AppleTouchIcon = "apple-touch-icon";
    public const string IconPath = "icon-192.png";
    public const string FaviconPath = "favicon.ico";
    public const string FaviconRel = "icon";
    public const string CssPath = "_content/PrTask.SharedUI/css/app.css";
    public const string OpfsStorePath = "Js/opfs-store.min.js";
    public const string GitSyncPath = "Js/git-sync.min.js";
    public const string CircuitManagerPath = "_content/PrTask.SharedUI/js/circuit-manager.min.js";
    public const string IndexedDbSyncPath = "Js/indexeddb-sync.min.js";
    public const string SwUpdatePath = "Js/sw-update.min.js";
    public const string BlazorWasmPath = "_framework/blazor.webassembly.js";
    public const string MetaCharsetTag = "    <meta charset=\"utf-8\" />\n";
    public const string MetaViewportTag = "    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n";
    public const string MetaThemeColorTag = "    <meta name=\"theme-color\" content=\"#1a1a2e\" />\n";
    public const string MetaNameOpen = "    <meta name=\"";
    public const string MetaPropertyOpen = "    <meta property=\"";
    public const string ContentEquals = "\" content=\"";
    public const string TagClose = "\" />\n";
    public const string TitleOpen = "    <title>";
    public const string TitleClose = "</title>\n";
    public const string LinkRelOpen = "    <link rel=\"";
    public const string HrefEquals = "\" href=\"";
    public const string ParentPrefix = "../";
    public const string LinkStylesheetOpen = "    <link rel=\"stylesheet\" href=\"";
    public const string ScriptSrcOpen = "    <script defer src=\"";
    public const string ScriptClose = "\"></script>\n";
    public const string BlazorScriptOpen = "    <script defer src=\"";
    public const string BlazorScriptClose = "\" autostart=\"false\"></script>\n";
    public const string BlazorDeferredStart = "    <script>function prtaskStartBlazor(){document.removeEventListener('click',prtaskStartBlazor);document.removeEventListener('scroll',prtaskStartBlazor);document.removeEventListener('touchstart',prtaskStartBlazor);Blazor.start()}document.addEventListener('click',prtaskStartBlazor,{once:true});document.addEventListener('scroll',prtaskStartBlazor,{once:true});document.addEventListener('touchstart',prtaskStartBlazor,{once:true})</script>\n";
    public const string HeadClose = "</head>\n";
    public const string BodyOpen = "<body>\n";
    public const string BodyClose = "\n";
    public const string AppDivOpen = "    <div id=\"app\"><main>\n";
    public const string AppDivClose = "    </main></div>\n";
    public const string NavBrandOpen = "class=\"nav-brand\">";
    public const string NavBrandClose = "</a>";
    public const string InlineScriptResource = "InlineScript.html";
    public const string ServiceWorkerScriptResource = "ServiceWorkerScript.html";
    public const string PrtaskCorePath = "Js/prtask-core.js";
    public const string PageTasks = "Tasks";
    public const string PageLeaderboard = "Leaderboard";
    public const string PageHowItWorks = "HowItWorks";
    public const string PagePricing = "Pricing";
    public const string PageAbout = "About";
    public const string PageDownload = "Download";
    public const string PageDashboard = "Dashboard";
    public const string PageClientCreateTask = "Client/CreateTask";
    public const string PageClientPayments = "Client/Payments";
    public const string PageClientRepository = "Client/Repository";
    public const string PageSprints = "Sprints";
    public const string PageBoards = "Boards";
    public const string PageSettings = "Settings";
    public const string PageLogin = "Login";
    public const string PageNotFound = "NotFound";
    public const string PagePrs = "Prs";
    public const string PageProfile = "Profile";
    public const string PageDeployments = "Deployments";
    public const string PageLegalTerms = "Legal/Terms";
    public const string PageLegalPrivacy = "Legal/Privacy";
    public const string PageLegalCookiePolicy = "Legal/CookiePolicy";
    public const string PageLegalAcceptableUse = "Legal/AcceptableUse";
    public const string PageLegalRefund = "Legal/Refund";
    public const string PageLegalLicenses = "Legal/Licenses";
    public const string PageLegalAccessibility = "Legal/Accessibility";
    public const string PageLegalDmca = "Legal/Dmca";
    public const string HomeHref = "href=\"./\"";
    public const string HrefOpen = "href=\"";
    public const string HrefClose = "\"";
    public const string ActiveAttr = " aria-current=\"page\"";
    public const string PreloadCssFormat = "    <link rel=\"preload\" href=\"{0}_content/PrTask.SharedUI/css/app.css\" as=\"style\" />\n";
    public const string PreloadCoreJsFormat = "    <link rel=\"preload\" href=\"{0}Js/prtask-core.js\" as=\"script\" />\n";
    public const string PreloadBlazorJsFormat = "    <link rel=\"preload\" href=\"{0}_framework/blazor.webassembly.js\" as=\"script\" />\n";
    public const string StaticNavHtml = "<nav class=\"nav-bar\">"
        + "<input type=\"checkbox\" id=\"burger-check\" class=\"burger-check\" aria-hidden=\"true\" />"
        + "<label for=\"burger-check\" class=\"burger-toggle\" aria-label=\"Menu\">&#9776;</label>"
        + "<a href=\"./\" class=\"nav-brand\">PrTask</a>"
        + "<div class=\"nav-cats\">"
        + "<div class=\"nav-cat\"><input type=\"checkbox\" id=\"cat-platform\" class=\"cat-check\" aria-hidden=\"true\" />"
        + "<label for=\"cat-platform\" class=\"cat-label\">Platform &#9662;</label>"
        + "<div class=\"cat-links\"><a href=\"Tasks\">Tasks</a><a href=\"Dashboard\">Dashboard</a>"
        + "<a href=\"Leaderboard\">Leaderboard</a><a href=\"Sprints\">Sprints</a><a href=\"Boards\">Boards</a></div>"
        + "<label for=\"cat-platform\" class=\"cat-overlay\"></label></div>"
        + "<div class=\"nav-cat\"><input type=\"checkbox\" id=\"cat-client\" class=\"cat-check\" aria-hidden=\"true\" />"
        + "<label for=\"cat-client\" class=\"cat-label\">Client &#9662;</label>"
        + "<div class=\"cat-links\"><a href=\"Client/CreateTask\">Create Task</a><a href=\"Client/Payments\">Payments</a>"
        + "<a href=\"Client/Repository\">Repository</a></div>"
        + "<label for=\"cat-client\" class=\"cat-overlay\"></label></div>"
        + "<div class=\"nav-cat\"><input type=\"checkbox\" id=\"cat-account\" class=\"cat-check\" aria-hidden=\"true\" />"
        + "<label for=\"cat-account\" class=\"cat-label\">Account &#9662;</label>"
        + "<div class=\"cat-links\"><a href=\"Login\">Login</a><a href=\"Settings\">Settings</a>"
        + "<a href=\"Download\">Download</a></div>"
        + "<label for=\"cat-account\" class=\"cat-overlay\"></label></div>"
        + "<div class=\"nav-cat\"><input type=\"checkbox\" id=\"cat-info\" class=\"cat-check\" aria-hidden=\"true\" />"
        + "<label for=\"cat-info\" class=\"cat-label\">Info &#9662;</label>"
        + "<div class=\"cat-links\"><a href=\"About\">About</a><a href=\"HowItWorks\">How It Works</a>"
        + "<a href=\"Pricing\">Pricing</a></div>"
        + "<label for=\"cat-info\" class=\"cat-overlay\"></label></div>"
        + "<div class=\"nav-cat\"><input type=\"checkbox\" id=\"cat-legal\" class=\"cat-check\" aria-hidden=\"true\" />"
        + "<label for=\"cat-legal\" class=\"cat-label\">Legal &#9662;</label>"
        + "<div class=\"cat-links\"><a href=\"Legal/Terms\">Terms</a><a href=\"Legal/Privacy\">Privacy</a>"
        + "<a href=\"Legal/Refund\">Refund</a><a href=\"Legal/AcceptableUse\">Acceptable Use</a>"
        + "<a href=\"Legal/CookiePolicy\">Cookie Policy</a><a href=\"Legal/Licenses\">Licenses</a>"
        + "<a href=\"Legal/Accessibility\">Accessibility</a><a href=\"Legal/Dmca\">DMCA</a></div>"
        + "<label for=\"cat-legal\" class=\"cat-overlay\"></label></div>"
        + "</div>"
        + "<div class=\"nav-cat\"><input type=\"checkbox\" id=\"cat-lang\" class=\"cat-check\" aria-hidden=\"true\" />"
        + "<label for=\"cat-lang\" class=\"cat-label lang-summary\">Language &#9662;</label>"
        + "<div class=\"cat-links lang-dropdown\">"
        + "<a href=\"?lang=en\" class=\"lang-option\">English</a>"
        + "<a href=\"?lang=zh\" class=\"lang-option\">\u4e2d\u6587</a>"
        + "<a href=\"?lang=es\" class=\"lang-option\">Espa\u00f1ol</a>"
        + "<a href=\"?lang=ja\" class=\"lang-option\">\u65e5\u672c\u8a9e</a>"
        + "<a href=\"?lang=de\" class=\"lang-option\">Deutsch</a>"
        + "<a href=\"?lang=fr\" class=\"lang-option\">Fran\u00e7ais</a>"
        + "<a href=\"?lang=pt\" class=\"lang-option\">Portugu\u00eas</a>"
        + "<a href=\"?lang=hi\" class=\"lang-option\">\u0939\u093f\u0928\u094d\u0926\u0940</a>"
        + "<a href=\"?lang=ko\" class=\"lang-option\">\ud55c\uad6d\uc5b4</a>"
        + "<a href=\"?lang=it\" class=\"lang-option\">Italiano</a>"
        + "<a href=\"?lang=ru\" class=\"lang-option\">\u0420\u0443\u0441\u0441\u043a\u0438\u0439</a>"
        + "<a href=\"?lang=id\" class=\"lang-option\">Bahasa</a>"
        + "<a href=\"?lang=nl\" class=\"lang-option\">Nederlands</a>"
        + "<a href=\"?lang=tr\" class=\"lang-option\">T\u00fcrk\u00e7e</a>"
        + "<a href=\"?lang=fil\" class=\"lang-option\">Filipino</a>"
        + "<a href=\"?lang=ar\" class=\"lang-option\">\u0627\u0644\u0639\u0631\u0628\u064a\u0629</a>"
        + "</div><label for=\"cat-lang\" class=\"cat-overlay\"></label></div>"
        + "<div class=\"nav-cat\"><input type=\"checkbox\" id=\"cat-theme\" class=\"cat-check\" aria-hidden=\"true\" />"
        + "<label for=\"cat-theme\" class=\"cat-label\">Theme &#9662;</label>"
        + "<div class=\"cat-links\">"
        + "<label class=\"theme-option\"><input type=\"radio\" name=\"theme\" id=\"theme-light\" class=\"theme-radio theme-light\"> Light</label>"
        + "<label class=\"theme-option\"><input type=\"radio\" name=\"theme\" id=\"theme-dark\" class=\"theme-radio theme-dark\"> Dark</label>"
        + "<label class=\"theme-option\"><input type=\"radio\" name=\"theme\" id=\"theme-system\" class=\"theme-radio theme-system\" checked> System</label>"
        + "</div><label for=\"cat-theme\" class=\"cat-overlay\"></label></div>"
        + "<div class=\"burger-menu\">"
        + "<div class=\"burger-cat\"><input type=\"checkbox\" id=\"bm-platform\" class=\"bm-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"bm-platform\" class=\"bm-label\">Platform</label>"
        + "<div class=\"bm-links\"><a href=\"Tasks\">Tasks</a><a href=\"Dashboard\">Dashboard</a>"
        + "<a href=\"Leaderboard\">Leaderboard</a><a href=\"Sprints\">Sprints</a><a href=\"Boards\">Boards</a></div></div>"
        + "<div class=\"burger-cat\"><input type=\"checkbox\" id=\"bm-client\" class=\"bm-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"bm-client\" class=\"bm-label\">Client</label>"
        + "<div class=\"bm-links\"><a href=\"Client/CreateTask\">Create Task</a><a href=\"Client/Payments\">Payments</a>"
        + "<a href=\"Client/Repository\">Repository</a></div></div>"
        + "<div class=\"burger-cat\"><input type=\"checkbox\" id=\"bm-account\" class=\"bm-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"bm-account\" class=\"bm-label\">Account</label>"
        + "<div class=\"bm-links\"><a href=\"Login\">Login</a><a href=\"Settings\">Settings</a>"
        + "<a href=\"Download\">Download</a></div></div>"
        + "<div class=\"burger-cat\"><input type=\"checkbox\" id=\"bm-info\" class=\"bm-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"bm-info\" class=\"bm-label\">Info</label>"
        + "<div class=\"bm-links\"><a href=\"About\">About</a><a href=\"HowItWorks\">How It Works</a>"
        + "<a href=\"Pricing\">Pricing</a></div></div>"
        + "<div class=\"burger-cat\"><input type=\"checkbox\" id=\"bm-legal\" class=\"bm-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"bm-legal\" class=\"bm-label\">Legal</label>"
        + "<div class=\"bm-links\"><a href=\"Legal/Terms\">Terms</a><a href=\"Legal/Privacy\">Privacy</a>"
        + "<a href=\"Legal/Refund\">Refund</a><a href=\"Legal/AcceptableUse\">Acceptable Use</a>"
        + "<a href=\"Legal/CookiePolicy\">Cookie Policy</a><a href=\"Legal/Licenses\">Licenses</a>"
        + "<a href=\"Legal/Accessibility\">Accessibility</a><a href=\"Legal/Dmca\">DMCA</a></div></div>"
        + "<div class=\"bm-lang\"><input type=\"checkbox\" id=\"bm-lang-check\" class=\"bm-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"bm-lang-check\" class=\"bm-label\">Language</label>"
        + "<div class=\"bm-links\">"
        + "<a href=\"?lang=en\" class=\"lang-option\">English</a>"
        + "<a href=\"?lang=zh\" class=\"lang-option\">\u4e2d\u6587</a>"
        + "<a href=\"?lang=es\" class=\"lang-option\">Espa\u00f1ol</a>"
        + "<a href=\"?lang=ja\" class=\"lang-option\">\u65e5\u672c\u8a9e</a>"
        + "<a href=\"?lang=de\" class=\"lang-option\">Deutsch</a>"
        + "<a href=\"?lang=fr\" class=\"lang-option\">Fran\u00e7ais</a>"
        + "<a href=\"?lang=pt\" class=\"lang-option\">Portugu\u00eas</a>"
        + "<a href=\"?lang=hi\" class=\"lang-option\">\u0939\u093f\u0928\u094d\u0926\u0940</a>"
        + "<a href=\"?lang=ko\" class=\"lang-option\">\ud55c\uad6d\uc5b4</a>"
        + "<a href=\"?lang=it\" class=\"lang-option\">Italiano</a>"
        + "<a href=\"?lang=ru\" class=\"lang-option\">\u0420\u0443\u0441\u0441\u043a\u0438\u0439</a>"
        + "<a href=\"?lang=id\" class=\"lang-option\">Bahasa</a>"
        + "<a href=\"?lang=nl\" class=\"lang-option\">Nederlands</a>"
        + "<a href=\"?lang=tr\" class=\"lang-option\">T\u00fcrk\u00e7e</a>"
        + "<a href=\"?lang=fil\" class=\"lang-option\">Filipino</a>"
        + "<a href=\"?lang=ar\" class=\"lang-option\">\u0627\u0644\u0639\u0631\u0628\u064a\u0629</a>"
        + "</div></div>"
        + "<div class=\"burger-cat\"><input type=\"checkbox\" id=\"bm-theme\" class=\"bm-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"bm-theme\" class=\"bm-label\">Theme</label>"
        + "<div class=\"bm-links\">"
        + "<label class=\"theme-option theme-active-light\" for=\"theme-light\">Light</label>"
        + "<label class=\"theme-option theme-active-dark\" for=\"theme-dark\">Dark</label>"
        + "<label class=\"theme-option theme-active-system\" for=\"theme-system\">System</label>"
        + "</div></div>"
        + "</div>"
        + "<label for=\"burger-check\" class=\"burger-overlay\"></label>"
        + "</nav>\n";
    public const string StaticFooterHtml = "<footer class=\"site-footer\">"
        + "<div class=\"footer-content\">"
        + "<div class=\"footer-links\">"
        + "<div class=\"footer-column\">"
        + "<input type=\"checkbox\" id=\"fcat-platform\" class=\"fcat-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"fcat-platform\" class=\"fcat-label\">Platform</label>"
        + "<div class=\"fcat-links\"><a href=\"Tasks\">Tasks</a><a href=\"Dashboard\">Dashboard</a>"
        + "<a href=\"Leaderboard\">Leaderboard</a><a href=\"Sprints\">Sprints</a><a href=\"Boards\">Boards</a></div></div>"
        + "<div class=\"footer-column\">"
        + "<input type=\"checkbox\" id=\"fcat-client\" class=\"fcat-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"fcat-client\" class=\"fcat-label\">Client</label>"
        + "<div class=\"fcat-links\"><a href=\"Client/CreateTask\">Create Task</a><a href=\"Client/Payments\">Payments</a>"
        + "<a href=\"Client/Repository\">Repository</a></div></div>"
        + "<div class=\"footer-column\">"
        + "<input type=\"checkbox\" id=\"fcat-account\" class=\"fcat-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"fcat-account\" class=\"fcat-label\">Account</label>"
        + "<div class=\"fcat-links\"><a href=\"Login\">Login</a><a href=\"Settings\">Settings</a>"
        + "<a href=\"Download\">Download</a></div></div>"
        + "<div class=\"footer-column\">"
        + "<input type=\"checkbox\" id=\"fcat-info\" class=\"fcat-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"fcat-info\" class=\"fcat-label\">Info</label>"
        + "<div class=\"fcat-links\"><a href=\"About\">About</a><a href=\"HowItWorks\">How It Works</a>"
        + "<a href=\"Pricing\">Pricing</a></div></div>"
        + "<div class=\"footer-column\">"
        + "<input type=\"checkbox\" id=\"fcat-legal\" class=\"fcat-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"fcat-legal\" class=\"fcat-label\">Legal</label>"
        + "<div class=\"fcat-links\"><a href=\"Legal/Terms\">Terms</a><a href=\"Legal/Privacy\">Privacy</a>"
        + "<a href=\"Legal/Refund\">Refund</a><a href=\"Legal/AcceptableUse\">Acceptable Use</a>"
        + "<a href=\"Legal/CookiePolicy\">Cookie Policy</a><a href=\"Legal/Licenses\">Licenses</a>"
        + "<a href=\"Legal/Accessibility\">Accessibility</a><a href=\"Legal/Dmca\">DMCA</a></div></div>"
        + "<div class=\"footer-column\">"
        + "<input type=\"checkbox\" id=\"fcat-lang\" class=\"fcat-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"fcat-lang\" class=\"fcat-label\">Language</label>"
        + "<div class=\"fcat-links\">"
        + "<a href=\"?lang=en\" class=\"lang-option\">English</a>"
        + "<a href=\"?lang=zh\" class=\"lang-option\">\u4e2d\u6587</a>"
        + "<a href=\"?lang=es\" class=\"lang-option\">Espa\u00f1ol</a>"
        + "<a href=\"?lang=ja\" class=\"lang-option\">\u65e5\u672c\u8a9e</a>"
        + "<a href=\"?lang=de\" class=\"lang-option\">Deutsch</a>"
        + "<a href=\"?lang=fr\" class=\"lang-option\">Fran\u00e7ais</a>"
        + "<a href=\"?lang=pt\" class=\"lang-option\">Portugu\u00eas</a>"
        + "<a href=\"?lang=hi\" class=\"lang-option\">\u0939\u093f\u0928\u094d\u0926\u0940</a>"
        + "<a href=\"?lang=ko\" class=\"lang-option\">\ud55c\uad6d\uc5b4</a>"
        + "<a href=\"?lang=it\" class=\"lang-option\">Italiano</a>"
        + "<a href=\"?lang=ru\" class=\"lang-option\">\u0420\u0443\u0441\u0441\u043a\u0438\u0439</a>"
        + "<a href=\"?lang=id\" class=\"lang-option\">Bahasa</a>"
        + "<a href=\"?lang=nl\" class=\"lang-option\">Nederlands</a>"
        + "<a href=\"?lang=tr\" class=\"lang-option\">T\u00fcrk\u00e7e</a>"
        + "<a href=\"?lang=fil\" class=\"lang-option\">Filipino</a>"
        + "<a href=\"?lang=ar\" class=\"lang-option\">\u0627\u0644\u0639\u0631\u0628\u064a\u0629</a>"
        + "</div></div>"
        + "<div class=\"footer-column\">"
        + "<input type=\"checkbox\" id=\"fcat-theme\" class=\"fcat-check\" checked aria-hidden=\"true\" />"
        + "<label for=\"fcat-theme\" class=\"fcat-label\">Theme</label>"
        + "<div class=\"fcat-links\">"
        + "<label class=\"theme-option theme-active-light\" for=\"theme-light\">Light</label>"
        + "<label class=\"theme-option theme-active-dark\" for=\"theme-dark\">Dark</label>"
        + "<label class=\"theme-option theme-active-system\" for=\"theme-system\">System</label>"
        + "</div></div>"
        + "</div></div>"
        + "<div class=\"footer-bottom\">"
        + "<p>&copy; 2026 PrTask. All rights reserved.</p>"
        + "</div></footer>\n";
    public const string DoctypeHtmlLangOpen = "<!DOCTYPE html>\n<html lang=\"";
    public const string HtmlLangCloseHeadOpen = "\">\n<head>\n";
    public const string Slash = "/";
    public const string DotSlash = "./";
    public const string SrcOpen = "src=\"";
    public const string HashPrefix = "#";
    public const string HreflangOpen = "    <link rel=\"alternate\" hreflang=\"";
    public const string HreflangHref = "\" href=\"";
    public const string HreflangClose = "\" />\n";
    public const string HreflangXDefault = "x-default";
    public const string LangSummaryOpen = "<label for=\"cat-lang\" class=\"cat-label lang-summary\">";
    public const string LangSummaryClose = "</label>";
    public const string LangQueryPrefix = "?lang=";
    public const string EnLocaleSlash = "/en/";
    public const string HtmlExtension = ".html";
    public static readonly (string Route, string Page)[] RouteToPageMap =
    [
        ("/login", "/" + PageLogin + HtmlExtension),
        ("/settings", "/" + PageSettings + HtmlExtension),
        ("/tasks", "/" + PageTasks + HtmlExtension),
        ("/dashboard", "/" + PageDashboard + HtmlExtension),
        ("/leaderboard", "/" + PageLeaderboard + HtmlExtension),
        ("/sprints", "/" + PageSprints + HtmlExtension),
        ("/boards", "/" + PageBoards + HtmlExtension),
        ("/how-it-works", "/" + PageHowItWorks + HtmlExtension),
        ("/pricing", "/" + PagePricing + HtmlExtension),
        ("/about", "/" + PageAbout + HtmlExtension),
        ("/download", "/" + PageDownload + HtmlExtension),
        ("/client/create-task", "/" + PageClientCreateTask + HtmlExtension),
        ("/client/payments", "/" + PageClientPayments + HtmlExtension),
        ("/client/repository", "/" + PageClientRepository + HtmlExtension),
        ("/legal/terms", "/" + PageLegalTerms + HtmlExtension),
        ("/legal/privacy", "/" + PageLegalPrivacy + HtmlExtension),
        ("/legal/refund", "/" + PageLegalRefund + HtmlExtension),
        ("/legal/acceptable-use", "/" + PageLegalAcceptableUse + HtmlExtension),
        ("/legal/cookie-policy", "/" + PageLegalCookiePolicy + HtmlExtension),
        ("/legal/licenses", "/" + PageLegalLicenses + HtmlExtension),
        ("/legal/accessibility", "/" + PageLegalAccessibility + HtmlExtension),
        ("/legal/dmca", "/" + PageLegalDmca + HtmlExtension),
    ];
}
