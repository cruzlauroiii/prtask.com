using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Prerender;

var PrerenderRoutes = new (string Route, Type PageType)[]
{
    (PrerenderConstants.RouteHome, typeof(PrTask.SharedUI.Pages.Home)),
    (PrerenderConstants.RouteDashboard, typeof(PrTask.SharedUI.Pages.DashboardPage)),
    (PrerenderConstants.RouteTasks, typeof(PrTask.SharedUI.Pages.TaskList)),
    (PrerenderConstants.RouteLogin, typeof(PrTask.SharedUI.Pages.LoginPage)),
    (PrerenderConstants.RouteSettings, typeof(PrTask.SharedUI.Pages.SettingsPage)),
    (PrerenderConstants.RouteLeaderboard, typeof(PrTask.SharedUI.Pages.LeaderboardPage)),
    (PrerenderConstants.RouteHowItWorks, typeof(PrTask.SharedUI.Pages.HowItWorks)),
    (PrerenderConstants.RoutePricing, typeof(PrTask.SharedUI.Pages.PricingPage)),
    (PrerenderConstants.RouteAbout, typeof(PrTask.SharedUI.Pages.AboutPage)),
    (PrerenderConstants.RouteDownload, typeof(PrTask.SharedUI.Pages.DownloadPage)),
    (PrerenderConstants.RouteSprints, typeof(PrTask.SharedUI.Pages.SprintsPage)),
    (PrerenderConstants.RouteBoards, typeof(PrTask.SharedUI.Pages.BoardsPage)),
    (PrerenderConstants.RouteLegalTerms, typeof(PrTask.SharedUI.Pages.Legal.TermsPage)),
    (PrerenderConstants.RouteLegalPrivacy, typeof(PrTask.SharedUI.Pages.Legal.PrivacyPage)),
    (PrerenderConstants.RouteLegalRefund, typeof(PrTask.SharedUI.Pages.Legal.RefundPage)),
    (PrerenderConstants.RouteLegalAcceptableUse, typeof(PrTask.SharedUI.Pages.Legal.AcceptableUsePage)),
    (PrerenderConstants.RouteLegalCookiePolicy, typeof(PrTask.SharedUI.Pages.Legal.CookiePolicyPage)),
    (PrerenderConstants.RouteLegalLicenses, typeof(PrTask.SharedUI.Pages.Legal.LicensesPage)),
    (PrerenderConstants.RouteLegalAccessibility, typeof(PrTask.SharedUI.Pages.Legal.AccessibilityPage)),
    (PrerenderConstants.RouteLegalDmca, typeof(PrTask.SharedUI.Pages.Legal.DmcaPage)),
    (PrerenderConstants.RouteClientCreateTask, typeof(PrTask.SharedUI.Pages.Client.CreateTaskPage)),
    (PrerenderConstants.RouteClientPayments, typeof(PrTask.SharedUI.Pages.Client.PaymentsPage)),
    (PrerenderConstants.RouteClientRepository, typeof(PrTask.SharedUI.Pages.Client.RepositoryPage)),
};

var OutputDir = args.Length > 0 ? args[0] : Path.Combine(Directory.GetCurrentDirectory(), PrerenderConstants.OutputDirName);
var TotalPages = PrerenderRoutes.Length * I18NConstants.AllLanguages.Length;
Console.WriteLine(string.Format(CultureInfo.InvariantCulture, PrerenderConstants.LogStartFormat, TotalPages, OutputDir));

foreach (var (LanguageCode, LanguageLabel) in I18NConstants.AllLanguages)
{
    var Culture = new CultureInfo(LanguageCode);
    CultureInfo.DefaultThreadCurrentCulture = Culture;
    CultureInfo.DefaultThreadCurrentUICulture = Culture;

    foreach (var (Route, PageType) in PrerenderRoutes)
    {
        try
        {
            var Services = new ServiceCollection();
            Services.AddLogging(B => B.AddConsole().SetMinimumLevel(LogLevel.Warning));
            Services.AddSingleton<ILocalStoreService, NoOpLocalStoreService>();
            Services.AddSingleton<PrTask.SharedUI.Services.IConnectionStateService, PrTask.SharedUI.Services.ConnectionStateService>();
            Services.AddSingleton<IConnectionStateService, NoOpConnectionStateService>();
            Services.AddSingleton<IWssService, NoOpWssService>();
            Services.AddSingleton<IWssConnectionService, NoOpWssConnectionService>();
            Services.AddSingleton<IWebSocketReconnectionService, NoOpWebSocketReconnectionService>();
            Services.AddSingleton<IVisibilitySyncService, NoOpVisibilitySyncService>();
            Services.AddSingleton<IGitSyncService, NoOpGitSyncService>();
            Services.AddSingleton<IJSRuntime, NoOpJsRuntime>();
            Services.AddScoped<PrTask.SharedUI.Services.WssStateService>();
            Services.AddSingleton<NavigationManager>(new StaticNavigationManager(PrerenderConstants.BaseUrl + Route));
            NoOpApplicationServices.Register(Services);
            Services.AddLocalization(Options => Options.ResourcesPath = I18NConstants.ResourcesPath);

            await using var Provider = Services.BuildServiceProvider();
            using var Scope = Provider.CreateScope();

            await using var Renderer = new HtmlRenderer(Scope.ServiceProvider, Provider.GetRequiredService<ILoggerFactory>());

            var Html = await Renderer.Dispatcher.InvokeAsync(async () =>
            {
                var Output = await Renderer.RenderComponentAsync(PageType);
                return Output.ToHtmlString();
            });

            var FullHtml = HtmlTemplate.Wrap(Route, Html, LanguageCode);

            var RelPath = Route == PrerenderConstants.RouteHome
                ? Path.Combine(LanguageCode, PrerenderConstants.IndexFileName)
                : Path.Combine(LanguageCode, Route.TrimStart('/') + PrerenderConstants.HtmlExtension);

            var FilePath = Path.Combine(OutputDir, RelPath);
            var Dir = Path.GetDirectoryName(FilePath)!;
            Directory.CreateDirectory(Dir);
            await File.WriteAllTextAsync(FilePath, FullHtml);
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, PrerenderConstants.LogOkFormat, PrerenderConstants.StatusOk, string.Format(CultureInfo.InvariantCulture, PrerenderConstants.LogLangRouteFormat, LanguageCode, Route), RelPath, FullHtml.Length));
        }
        catch (Exception Ex)
        {
            Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture, PrerenderConstants.LogErrFormat, PrerenderConstants.StatusErr, string.Format(CultureInfo.InvariantCulture, PrerenderConstants.LogLangRouteFormat, LanguageCode, Route), Ex.Message));
        }
    }
}

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

var RootIndexPath = Path.Combine(OutputDir, PrerenderConstants.IndexFileName);
var RootRedirectHtml = string.Format(CultureInfo.InvariantCulture, PrerenderConstants.RootRedirectTemplate, PrerenderConstants.RootRedirectTarget);
await File.WriteAllTextAsync(RootIndexPath, RootRedirectHtml);

Console.WriteLine(PrerenderConstants.LogComplete);
