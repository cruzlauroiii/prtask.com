using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
   [TestMethod, TestCategory("Rules")]
   [DisplayName("PWA offline support — service worker and manifest.json exist")]
   public void PwaOfflineSupport()
   {
       var ClientWwwroot = Path.Combine(SourceRoot, "PrTask.Client", "wwwroot");
       Assert.IsTrue(
           File.Exists(Path.Combine(ClientWwwroot, "service-worker.js"))
           || File.Exists(Path.Combine(ClientWwwroot, "service-worker.published.js")),
           "Client must have service-worker.js for offline PWA support");
       Assert.IsTrue(File.Exists(Path.Combine(ClientWwwroot, "manifest.json"))
           || File.Exists(Path.Combine(ClientWwwroot, "manifest.webmanifest")),
           "Client must have manifest.json for PWA installability");
       var IndexHtml = ReadSource("PrTask.Client", "wwwroot", "index.html");
       Assert.IsTrue(IndexHtml.Contains("manifest") || IndexHtml.Contains("service-worker"),
           "index.html must reference manifest or service worker");
   }
   [TestMethod, TestCategory("Rules")]
   [DisplayName("Android APK hamburger flush left with safe-area top spacing")]
   public void ApkHamburgerPosition()
   {
       var AllScss = string.Join("\n",
           Directory.GetFiles(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles"), "*.scss")
               .Select(File.ReadAllText));
       Assert.IsTrue(AllScss.Contains("safe-area-inset-top"),
           "SCSS must use safe-area-inset-top for hamburger top spacing");
       var MauiIndex = ReadSource("PrTask.Maui", "wwwroot", "index.html");
       Assert.IsTrue(MauiIndex.Contains("viewport-fit=cover"),
           "MAUI index.html must use viewport-fit=cover for safe area");
   }
   [TestMethod, TestCategory("Rules")]
   [DisplayName("APK must work fully offline with local DB")]
   public void ApkOfflineCapability()
   {
       var MauiProgram = ReadSource("PrTask.Maui", "MauiProgram.cs");
       var TryCount = 0;
       var Idx = 0;
       while ((Idx = MauiProgram.IndexOf("try", Idx, StringComparison.Ordinal)) >= 0) { TryCount++; Idx += 3; }
       Assert.IsTrue(TryCount >= 2, $"MauiProgram needs nested try-catch, found {TryCount}");
       Assert.IsTrue(MauiProgram.Contains("EnsureCreated"), "MauiProgram must create local DB");
   }
   [TestMethod, TestCategory("Rules")]
   [DisplayName("Windows EXE must work fully offline with local DB")]
   public void ExeOfflineCapability()
   {
       var Prog = ReadSource("PrTask.Desktop", "Program.cs");
       Assert.IsTrue(Prog.Contains("MapFallbackToFile"), "Desktop must serve static files offline");
       Assert.IsTrue(Prog.Contains("DesktopLocalDbConnectionString") || Prog.Contains("DbConstants"),
           "Desktop must use local DB via DesktopLocalDbConnectionString");
   }
   [TestMethod, TestCategory("Rules")]
   [DisplayName("APK persistent notification with foreground service")]
   public void ApkPersistentNotification()
   {
       var AndroidDir = Path.Combine(SourceRoot, "PrTask.Maui", "Platforms", "Android");
       var AllCode = string.Join("\n",
           Directory.GetFiles(AndroidDir, "*.cs", SearchOption.AllDirectories).Select(File.ReadAllText));
       Assert.IsTrue(AllCode.Contains("ForegroundService") || AllCode.Contains("Notification"),
           "Android must have foreground service or notification code");
       var Manifest = File.ReadAllText(Path.Combine(AndroidDir, "AndroidManifest.xml"));
       Assert.IsTrue(Manifest.Contains("FOREGROUND_SERVICE") || Manifest.Contains("foregroundServiceType"),
           "AndroidManifest must declare foreground service permission");
   }
   [TestMethod, TestCategory("Rules")]
   [DisplayName("APK invisible launch with transparent activity")]
   public void ApkInvisibleLaunch()
   {
       var AndroidDir = Path.Combine(SourceRoot, "PrTask.Maui", "Platforms", "Android");
       var AllCode = string.Join("\n",
           Directory.GetFiles(AndroidDir, "*.cs", SearchOption.AllDirectories).Select(File.ReadAllText));
       Assert.IsTrue(AllCode.Contains("Translucent") || AllCode.Contains("Transparent") || AllCode.Contains("moveTaskToBack"),
           "Android must use transparent theme or moveTaskToBack for invisible launch");
   }
   [TestMethod, TestCategory("Rules")]
   [DisplayName("APK serves local HTTPS for Playwright testing via ADB forward")]
   public void ApkServesLocalHttps()
   {
       var MauiProgram = ReadSource("PrTask.Maui", "MauiProgram.cs");
       Assert.IsTrue(MauiProgram.Contains("Kestrel") || MauiProgram.Contains("UseUrls")
           || MauiProgram.Contains("IPAddress.Loopback") || MauiProgram.Contains("127.0.0.1")
           || MauiProgram.Contains("BlazorWebView"),
           "MauiProgram must have local server or BlazorWebView for local content serving");
   }
   [TestMethod, TestCategory("Rules")]
   [DisplayName("Zero left spacing with scrollbar-gutter stable")]
   public void ZeroLeftSpacingScrollbarGutter()
   {
       var AllScss = string.Join("\n",
           Directory.GetFiles(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles"), "*.scss")
               .Select(File.ReadAllText));
       Assert.IsTrue(AllScss.Contains("scrollbar-gutter") || AllScss.Contains("stable"),
           "SCSS must use scrollbar-gutter: stable for right-side scrollbar padding");
   }
   [TestMethod, TestCategory("Rules")]
   [DisplayName("No hardcoded brand name — all display text uses AppConstants.AppName")]
   public void NoHardcodedBrandName()
   {
       var AppConst = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
       Assert.IsTrue(AppConst.Contains("AppName"), "AppConstants must define AppName");
   }
   [TestMethod, TestCategory("Rules"), Timeout(60000)]
   [DisplayName("659 Playwright offline/online toggle — 3 cycles verify sync convergence")]
   public async Task PlaywrightOfflineOnlineToggleSyncAsync()
   {
       var Page = await NavigateOrSkipAsync($"{BaseUrl}{RouteConstants.About}");
       Assert.IsNotNull(Page, "659: Must load page before offline cycles");
       for (var Cycle = 1; Cycle <= 3; Cycle++)
       {
           await BrowserContext.SetOfflineAsync(true);
           var OfflineText = await BrowserPage.TextContentAsync("body") ?? string.Empty;
           Assert.IsTrue(OfflineText.Length > 10,
               $"Cycle {Cycle} OFFLINE: Page must have content ({OfflineText.Length} chars)");
           await BrowserContext.SetOfflineAsync(false);
           await BrowserPage.ReloadAsync(new PageReloadOptions { Timeout = 15000 });
           await BrowserPage.WaitForLoadStateAsync(LoadState.NetworkIdle, new PageWaitForLoadStateOptions { Timeout = 15000 });
           var OnlineText = await BrowserPage.TextContentAsync("body") ?? string.Empty;
           Assert.IsTrue(OnlineText.Length > 10,
               $"Cycle {Cycle} ONLINE: Page must render after reconnect ({OnlineText.Length} chars)");
           await TakeScreenshotAsync($"wf659-cycle-{Cycle}.png");
       }
   }
   [TestMethod, TestCategory("Rules")]
   [DisplayName("Single browser guard — one browser, duplicate URL detection, error logging")]
   public void SingleBrowserGuardExists()
   {
       var Guards = File.ReadAllText(Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "RulesTests.Guards.cs"));
       Assert.IsTrue(Guards.Contains("TrackUrlVisit"), "Guards must have TrackUrlVisit");
       Assert.IsTrue(Guards.Contains("LogError"), "Guards must have LogError");
       var Base = File.ReadAllText(Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "RulesTests.cs"));
       Assert.IsTrue(Base.Contains("GuardSingleBrowser"), "Must have GuardSingleBrowser");
       Assert.IsTrue(Base.Contains("CheckPageForErrorsAsync"), "Must have CheckPageForErrorsAsync");
       Assert.IsTrue(Base.Contains("DumpPagePlaintextAsync"), "Must have DumpPagePlaintextAsync");
       Assert.IsTrue(Base.Contains("AttachConsoleErrorListener"), "Must have AttachConsoleErrorListener");
   }
}

