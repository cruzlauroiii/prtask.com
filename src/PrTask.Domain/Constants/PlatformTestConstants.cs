namespace PrTask.Domain.Constants;

public static class PlatformTestConstants
{
    public const string PlatformWeb = "web";
    public const string PlatformDesktop = "desktop";
    public const string PlatformAndroid = "android";
    public const string WebBaseUrlEnv = "PRTASK_WEB_URL";
    public const string DesktopBaseUrlEnv = "PRTASK_DESKTOP_URL";
    public const string AndroidBaseUrlEnv = "PRTASK_ANDROID_URL";
    public const string DefaultWebUrl = "https://prtask.com";
    public const string DefaultDesktopUrl = "https://127.0.0.1:5001";
    public const string DefaultAndroidUrl = "http://10.0.2.2:5001";
    public const string DesktopExePath = "PrTask.Desktop.exe";
    public const string AndroidPackageName = "com.prtask.app";
    public const string AndroidActivityName = "com.prtask.app.MainActivity";
    public const string AdbDeviceSerial = "192.168.100.175:44207";
    public const string PlatformScreenshotFormat = "e2e-{0}-{1}-{2}.png";
    public const string PlatformDbVerifyFormat = "db-verify-{0}-{1}.json";
    public const string ChromiumChannel = "chromium";
    public const int PlatformNavigationTimeoutMs = 30000;
    public const int PlatformActionTimeoutMs = 15000;
    public const int DesktopStartupWaitMs = 10000;
    public const int AndroidBootWaitMs = 20000;
    public const string DbConnectionStringFormat = "Data Source={0};Mode=ReadOnly";
    public const string DbWalMode = "WAL";
    public const string WssDbQueryPath = "/api/db/query";
    public const string CrossPlatformTestCategory = "CrossPlatform";
    public const string PlatformTestCategory = "Platform";
    public const string CrudVerifyAssertFormat = "{0}: {1} must match across {2} and {3}";
    public const string PlatformStartedAssert = "Platform {0} must be reachable";
    public const string DbStateMatchAssert = "DB state must match after {0} on {1}";
    public const string ScreenshotExistsAssert = "{0} screenshot must exist for {1}";
    public const int MinPlatformScreenshotBytes = 10240;
    public const int MinReachablePlatforms = 2;
    public const string CrossPlatformMinPlatformsAssert =
        "Cross-platform test requires at least 2 reachable platforms";
    public const string PlatformUnreachableSkipFormat =
        "Skipping platform {0}: unreachable or login failed";
}
