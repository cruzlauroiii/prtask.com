namespace PrTask.Domain.Constants;
public static class GitSyncConstants
{
    public const string CorsProxyBase = "https://prtask.com/Git";
    public const string RepoOwner = "cruzlauroiii";
    public const string PublicRepo = "prtask.com";
    public const string DefaultLocalDir = "/data";
    public const string DefaultRemoteName = "origin";
    public const string DefaultRemoteRef = "origin/Public";
    public const string CloneFailedFormat = "Git clone failed with code {0}";
    public const string FetchFailedFormat = "Git fetch failed with code {0}";
    public const string ResetFailedFormat = "Git reset failed with code {0}";
    public const string CheckoutFailedFormat = "Git checkout failed with code {0}";
    public const string ResetHardFailedFormat = "Git reset --hard failed with code {0}";
    public const string CommitFailedFormat = "Git commit failed with code {0}";
    public const string PushFailedFormat = "Git push failed with code {0}";
    public const string CloneUrlFormat = "{0}/{1}/{2}.git";
}
