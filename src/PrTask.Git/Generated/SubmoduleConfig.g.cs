namespace PrTask.Git.Generated;

internal static partial class SubmoduleConfig
{
    internal enum LookupType
    {
        lookup_name,
        lookup_path,
    }
    internal static void SubmoduleCacheInit(nint Cache)
    {
    }

    internal static void FreeOneConfig(nint Entry)
    {
    }

    internal static void SubmoduleCacheClear(nint Cache)
    {
    }

    internal static void SubmoduleCacheFree(nint Cache)
    {
    }

    internal static int CheckSubmoduleName(string Name)
        => default;

    internal static int SubmoduleUrlIsRelative(string Url)
        => default;

    internal static int CountLeadingDotdots(string Url, string Out)
        => default;

    internal static int UrlToCurlUrl(string Url, string Out)
        => default;

    internal static int CheckSubmoduleUrl(string Url)
        => default;

    internal static int ParseFetchRecurseSubmodulesArg(string Opt, string Arg)
        => default;

    internal static int ParseUpdateRecurseSubmodulesArg(string Opt, string Arg)
        => default;

    internal static int ParsePushRecurseSubmodulesArg(string Opt, string Arg)
        => default;

    internal static void WarnCommandLineOption(string Var, string Value)
    {
    }

    internal static void SubmoduleCacheCheckInit(nint Repo)
    {
    }

    internal static void ConfigFromGitmodules(ConfigFnT Fn, nint Repo, nint Data)
    {
    }

    internal static void RepoReadGitmodules(nint Repo, int SkipIfRead)
    {
    }

    internal static void GitmodulesConfigOid(nint CommitOid)
    {
    }

    internal static void SubmoduleEntryListRelease(nint List)
    {
    }

    internal static void SubmoduleFree(nint R)
    {
    }

    internal static int PrintConfigFromGitmodules(nint Repo, string Key)
        => default;

    internal static int ConfigSetInGitmodulesFileGently(string Key, string Value)
        => default;

    internal static void FetchConfigFromGitmodules(nint MaxChildren, nint RecurseSubmodules)
    {
    }

    internal static void UpdateCloneConfigFromGitmodules(nint MaxJobs)
    {
    }

}
