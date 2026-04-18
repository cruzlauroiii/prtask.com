namespace PrTask.Git.Generated;

internal static partial class Worktree
{
    internal static void FreeWorktree(nint Worktree)
    {
    }

    internal static void FreeWorktrees(nint Worktrees)
    {
    }

    internal static void AddHeadInfo(nint Wt)
    {
    }

    internal static int IsCurrentWorktree(nint Wt)
        => default;

    internal static int IsMainWorktreeBare(nint Repo)
        => default;

    internal static int IsMainWorktree(nint Wt)
        => default;

    internal static void StrbufAddfGently(nint Buf, string Fmt, params object[] VarArgs)
    {
    }

    internal static int SubmoduleUsesWorktrees(string Path)
        => default;

    internal static int OtherHeadRefs(RefsForEachCb Fn, nint CbData)
        => default;

    internal static void RepairWorktrees(WorktreeRepairFn Fn, nint CbData, int UseRelativePaths)
    {
    }

    internal static void RepairWorktreeAfterGitdirMove(nint Wt, string OldPath)
    {
    }

    internal static void RepairWorktreesAfterGitdirMove(string OldPath)
    {
    }

    internal static int IsMainWorktreePath(string Path)
        => default;

    internal static nint InferBacklink(string Gitfile, nint Inferred)
        => default;

    internal static int ShouldPruneWorktree(string Id, nint Reason, string Wtpath, TimestampT Expire)
        => default;

    internal static int InitWorktreeConfig(nint R)
        => default;

}
