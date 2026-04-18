using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    public static async Task<IPlaywrightSteps> GetPlaywrightStepsAsync(string Platform)
    {
        var Ctx = await GetPlatformContextAsync(Platform);
        return new PlaywrightSteps(Ctx);
    }

    public static async Task ExecuteOnAllPlatformsAsync(Func<IPlaywrightSteps, string, Task> TestAction)
    {
        var Reachable = await GetReachablePlatformsAsync();
        Assert.IsTrue(Reachable.Length >= PlatformTestConstants.MinReachablePlatforms,
            PlatformTestConstants.CrossPlatformMinPlatformsAssert);

        var Errors = new List<string>();
        foreach (var PlatformName in Reachable)
        {
            try
            {
                var Steps = await GetPlaywrightStepsAsync(PlatformName);
                await TestAction(Steps, PlatformName);
            }
#pragma warning disable CA1031
            catch (Exception Ex)
#pragma warning restore CA1031
            {
                Errors.Add($"[{PlatformName}] {Ex.Message}");
                LogError($"ExecuteOnAllPlatforms: {PlatformName} failed — {Ex.Message}");
            }
        }

        if (Errors.Count > 0)
        {
            Assert.Fail($"ExecuteOnAllPlatforms: {Errors.Count} platform(s) failed:\n{string.Join("\n", Errors)}");
        }
    }

    public static async Task<string[]> GetReachablePlatformsAsync()
    {
        var Reachable = new List<string>();

        if (!string.IsNullOrEmpty(BaseUrl))
        {
            var WebReachable = await ProbePlatformAsync(
                PlatformTestConstants.PlatformWeb, BaseUrl);
            if (WebReachable)
            {
                Reachable.Add(PlatformTestConstants.PlatformWeb);
            }
        }

        var DesktopUrl = Environment.GetEnvironmentVariable(PlatformTestConstants.DesktopBaseUrlEnv);
        if (!string.IsNullOrEmpty(DesktopUrl))
        {
            var DesktopReachable = await ProbePlatformAsync(
                PlatformTestConstants.PlatformDesktop, DesktopUrl);
            if (DesktopReachable)
            {
                Reachable.Add(PlatformTestConstants.PlatformDesktop);
            }
        }

        var AndroidUrl = Environment.GetEnvironmentVariable(PlatformTestConstants.AndroidBaseUrlEnv);
        if (!string.IsNullOrEmpty(AndroidUrl))
        {
            var AndroidReachable = await ProbePlatformAsync(
                PlatformTestConstants.PlatformAndroid, AndroidUrl);
            if (AndroidReachable)
            {
                Reachable.Add(PlatformTestConstants.PlatformAndroid);
            }
        }

        return [.. Reachable];
    }

    private static async Task<bool> ProbePlatformAsync(string Platform, string Url)
    {
        try
        {
            using var Http = CreatePlatformHttpClient(Url);
            Http.Timeout = TimeSpan.FromSeconds(10);
            var Response = await Http.GetAsync("/");
            LogWarning($"ProbePlatform: {Platform} at {Url} returned {(int)Response.StatusCode}");
            return true;
        }
#pragma warning disable CA1031
        catch (Exception Ex)
#pragma warning restore CA1031
        {
            LogWarning(string.Format(PlatformTestConstants.PlatformUnreachableSkipFormat, Platform)
                + $" — {Ex.Message}");
            return false;
        }
    }
}
