namespace PrTask.Git.Generated;

internal static partial class Submodule
{
    internal static int IsGitmodulesUnmerged(nint Istate)
        => default;

    internal static int IsWritingGitmodulesOk()
        => default;

    internal static int IsStagingGitmodulesOk(nint Istate)
        => default;

    internal static int UpdatePathInGitmodules(string Oldpath, string Newpath)
        => default;

    internal static int RemovePathFromGitmodules(string Path)
        => default;

    internal static void StageUpdatedGitmodules(nint Istate)
    {
    }

    internal static int IsSubmoduleActive(nint Repo, string Path)
        => default;

    internal static int IsSubmodulePopulatedGently(string Path, nint ReturnErrorCode)
        => default;

    internal static SubmoduleUpdateType ParseSubmoduleUpdateType(string Value)
        => default;

    internal static void SubmoduleUpdateStrategyRelease(nint Strategy)
    {
    }

    internal static void PrintSubmoduleDiffSummary(nint R, nint Rev, nint O)
    {
    }

    internal static void PrepareSubmoduleRepoEnv(nint Out)
    {
    }

    internal static void PrepareSubmoduleRepoEnvInGitdir(nint Out)
    {
    }

    internal static int ShouldUpdateSubmodules()
        => default;

    internal static void ChangedSubmoduleDataClear(nint CsData)
    {
    }

    internal static void FreeSubmodulesData(nint Submodules)
    {
    }

    internal static int HasRemote(nint UNUSED, nint UNUSED)
        => default;

    internal static int AppendOidToArgv(nint Oid, nint Data)
        => default;

    internal static int CheckHasCommit(nint Oid, nint Data)
        => default;

    internal static int AppendOidToArray(nint Ref, nint Data)
        => default;

    internal static void CheckForNewSubmoduleCommits(nint Oid)
    {
    }

    internal static int RepoHasAbsorbedSubmodules(nint R)
        => default;

    internal static void FetchTaskFree(nint P)
    {
    }

    internal static int CommitMissingInSub(nint Oid, nint Data)
        => default;

    internal static uint IsSubmoduleModified(string Path, int IgnoreUntracked)
        => default;

    internal static int SubmoduleUsesGitfile(string Path)
        => default;

    internal static int BadToRemoveSubmodule(string Path, uint Flags)
        => default;

    internal static void SubmoduleUnsetCoreWorktree(nint Sub)
    {
    }

    internal static int SubmoduleHasDirtyIndex(nint Sub)
        => default;

    internal static void SubmoduleResetIndex(string Path, string SuperPrefix)
    {
    }

    internal static bool SubmoduleConflictsWithExisting(string Gitdir, string SubmoduleName)
        => default;

    internal static int ValidateSubmoduleEncodedGitDir(string GitDir, string SubmoduleName)
        => default;

    internal static int ValidateSubmoduleLegacyGitDir(string GitDir, string SubmoduleName)
        => default;

    internal static int ValidateSubmoduleGitDir(string GitDir, string SubmoduleName)
        => default;

    internal static int ValidateSubmodulePath(string Path)
        => default;

    internal static int GetSuperprojectWorkingTree(nint Buf)
        => default;

}
