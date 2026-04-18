namespace PrTask.Git.Generated;

internal static partial class SubmoduleHelper
{
    internal static int GetDefaultRemoteSubmodule(string ModulePath, string DefaultRemote)
        => default;

    internal static void ModuleListRelease(nint Ml)
    {
    }

    internal static void ModuleListActive(nint List)
    {
    }

    internal static void CreateDefaultGitdirConfig(string SubmoduleName)
    {
    }

    internal static void InitSubmoduleCb(nint ListItem, nint CbData)
    {
    }

    internal static int HandleSubmoduleHeadRef(nint Ref, nint CbData)
        => default;

    internal static void ModuleCbRelease(nint Mcb)
    {
    }

    internal static void ModuleCbListRelease(nint Mcbl)
    {
    }

    internal enum DiffCmd
    {
        DIFF_INDEX,
        DIFF_FILES,
    }
    internal static void SyncSubmoduleCb(nint ListItem, nint CbData)
    {
    }

    internal enum SUBMODULEALTERNATEERRORMODE
    {
        SUBMODULE_ALTERNATE_ERROR_DIE,
        SUBMODULE_ALTERNATE_ERROR_INFO,
        SUBMODULE_ALTERNATE_ERROR_IGNORE,
    }
    internal static int DirContainsOnlyDotgit(string Path)
        => default;

    internal static void SubmoduleUpdateCloneRelease(nint Suc)
    {
    }

    internal static void UpdateDataRelease(nint Ud)
    {
    }

    internal static int IsTipReachable(string Path, nint Oid)
        => default;

    internal static int RunUpdateCommand(nint Ud, int Subforce)
        => default;

    internal static int RunUpdateProcedure(nint Ud)
        => default;

    internal static int RemoteSubmoduleBranch(string Path, string Branch)
        => default;

    internal static int EnsureCoreWorktree(string Path)
        => default;

    internal static int UpdateSubmodule(nint UpdateData)
        => default;

    internal static int UpdateSubmodules(nint UpdateData)
        => default;

    internal static void AppendFetchRemotes(nint Msg, string GitDirPath)
    {
    }

    internal static int AddSubmodule(nint AddData)
        => default;

    internal static int ConfigSubmoduleInGitmodules(string Name, string Var, string Value)
        => default;

    internal static void ConfigureAddedSubmodule(nint AddData)
    {
    }

    internal static void DieOnIndexMatch(string Path, int Force)
    {
    }

    internal static void DieOnRepoWithoutCommits(string Path)
    {
    }

}
