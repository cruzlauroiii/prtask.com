namespace PrTask.Git.Generated;

internal static partial class Worktree
{
    internal static int DeleteGitDir(string Id)
        => default;

    internal static void DeleteWorktreesDirIfEmpty()
    {
    }

    internal static void PruneWorktree(string Id, string Reason)
    {
    }

    internal static int PruneCmp(nint A, nint B)
        => default;

    internal static void PruneDups(nint L)
    {
    }

    internal static void PruneWorktrees()
    {
    }

    internal static void RemoveJunk()
    {
    }

    internal static void RemoveJunkOnSignal(int Signo)
    {
    }

    internal static void CopySparseCheckout(string WorktreeGitDir)
    {
    }

    internal static void CopyFilteredWorktreeConfig(string WorktreeGitDir)
    {
    }

    internal static void SetupAlternateRefDir(nint Wt, string WtGitPath)
    {
    }

    internal static int FirstValidRef(nint UNUSED, nint UNUSED)
        => default;

    internal static int CanUseLocalRefs(nint Opts)
        => default;

    internal static int CanUseRemoteRefs(nint Opts)
        => default;

    internal static int DwimOrphan(nint Opts, int OptTrack, int Remote)
        => default;

    internal static void ShowWorktreePorcelain(nint Wt, int LineTerminator)
    {
    }

    internal static int Pathcmp(nint A, nint B)
        => default;

    internal static void Pathsort(nint Wt)
    {
    }

    internal static void ValidateNoSubmodules(nint Wt)
    {
    }

    internal static int DeleteGitWorkTree(nint Wt)
        => default;

    internal static void ReportRepair(int Iserr, string Path, string Msg, nint CbData)
    {
    }

}
