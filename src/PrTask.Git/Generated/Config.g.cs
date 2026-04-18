namespace PrTask.Git.Generated;

internal static partial class Config
{
    internal static int ConfigFileFgetc(nint Conf)
        => default;

    internal static int ConfigFileUngetc(int C, nint Conf)
        => default;

    internal static long ConfigFileFtell(nint Conf)
        => default;

    internal static int ConfigBufFgetc(nint Conf)
        => default;

    internal static int ConfigBufUngetc(int C, nint Conf)
        => default;

    internal static long ConfigBufFtell(nint Conf)
        => default;

    internal const int MAX_INCLUDE_DEPTH = 10;
    internal static void AddTrailingStarstarForDir(nint Pat)
    {
    }

    internal static void PopulateRemoteUrls(nint Inc)
    {
    }

    internal static void GitConfigPushSplitParameter(string Key, string Value)
    {
    }

    internal static void GitConfigPushParameter(string Text)
    {
    }

    internal static void GitConfigPushEnv(string Spec)
    {
    }

    internal static int Iskeychar(int C)
        => default;

    internal static int GitConfigParseKey(string Key, string StoreKey, nint Baselen)
        => default;

    internal static void KviFromParam(nint Out)
    {
    }

    internal static int GitConfigFromParameters(ConfigFnT Fn, nint Data)
        => default;

    internal static int GetNextChar(nint Cs)
        => default;

    internal static int GetBaseVar(nint Cs, nint Name)
        => default;

    internal static int GitConfigBool(string Name, string Value)
        => default;

    internal static int GitConfigString(string Dest, string Var, string Value)
        => default;

    internal static int GitConfigPathname(string Dest, string Var, string Value)
        => default;

    internal static int GitConfigExpiryDate(nint Timestamp, string Var, string Value)
        => default;

    internal static int GitConfigColor(string Dest, string Var, string Value)
        => default;

    internal static int GitConfigFromFile(ConfigFnT Fn, string Filename, nint Data)
        => default;

    internal static void GitGlobalConfigPaths(string UserOut, string XdgOut)
    {
    }

    internal static int GitConfigSystem()
        => default;

    internal static void ConfigsetIter(nint Set, ConfigFnT Fn, nint Data)
    {
    }

    internal static void ReadEarlyConfig(nint Repo, ConfigFnT Cb, nint Data)
    {
    }

    internal static void ReadVeryEarlyConfig(ConfigFnT Cb, nint Data)
    {
    }

    internal static void GitConfigsetInit(nint Set)
    {
    }

    internal static void GitConfigsetClear(nint Set)
    {
    }

    internal static int GitConfigsetAddFile(nint Set, string Filename)
        => default;

    internal static int CheckMultiString(nint Item, nint Util)
        => default;

    internal static int GitConfigsetGet(nint Set, string Key)
        => default;

    internal static int GitConfigsetGetString(nint Set, string Key, string Dest)
        => default;

    internal static int GitConfigsetGetInt(nint Set, string Key, nint Dest)
        => default;

    internal static int GitConfigsetGetUlong(nint Set, string Key, nint Dest)
        => default;

    internal static int GitConfigsetGetBool(nint Set, string Key, nint Dest)
        => default;

    internal static int GitConfigsetGetMaybeBool(nint Set, string Key, nint Dest)
        => default;

    internal static int GitConfigsetGetPathname(nint Set, string Key, string Dest)
        => default;

    internal static void CommentCharConfigRelease(nint Config)
    {
    }

    internal const int KEY_SEEN_ONCE = 1;
    internal const int KEY_SEEN_TWICE = 2;
    internal static bool CanUnsetCommentCharConfig(nint Config)
        => default;

    internal static void RepoConfigRelease(nint Config)
    {
    }

    internal static void CheckDeprecatedConfig(nint Config)
    {
    }

    internal static void RepoReadConfig(nint Repo)
    {
    }

    internal static void GitConfigCheckInit(nint Repo)
    {
    }

    internal static void RepoConfigClear(nint Repo)
    {
    }

    internal static void RepoConfig(nint Repo, ConfigFnT Fn, nint Data)
    {
    }

    internal static int RepoConfigGet(nint Repo, string Key)
        => default;

    internal static void ReadProtectedConfig()
    {
    }

    internal static void GitProtectedConfig(ConfigFnT Fn, nint Data)
    {
    }

    internal static int RepoConfigGetExpiry(nint R, string Key, string Output)
        => default;

    internal static int RepoConfigGetSplitIndex(nint R)
        => default;

    internal static int RepoConfigGetMaxPercentSplitChange(nint R)
        => default;

    internal static int RepoConfigGetIndexThreads(nint R, nint Dest)
        => default;

    internal static void GitDieConfigLinenr(string Key, string Filename, int Linenr)
    {
    }

    internal static void GitDieConfig(nint R, string Key, string Err, params object[] VarArgs)
    {
    }

    internal static void ConfigStoreDataClear(nint Store)
    {
    }

    internal static int WriteError(string Filename)
        => default;

    internal static int RepoConfigSetGently(nint R, string Key, string Value)
        => default;

    internal static void RepoConfigSet(nint R, string Key, string Value)
    {
    }

    internal static void ValidateCommentString(string Comment)
    {
    }

    internal static nuint SectionNameMatch(string Buf, string Name)
        => default;

    internal static int SectionNameIsOk(string Name)
        => default;

    internal static int RepoConfigRenameSection(nint R, string OldName, string NewName)
        => default;

    internal static int RepoConfigCopySection(nint R, string OldName, string NewName)
        => default;

    internal static int ConfigErrorNonbool(string Var)
        => default;

    internal static int LookupConfig(string Mapping, int NrMapping, string Var)
        => default;

}
