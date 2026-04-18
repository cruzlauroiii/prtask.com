namespace PrTask.Git.Generated;

internal static partial class Branch
{
    internal enum ColorBranch
    {
        BRANCH_COLOR_RESET = 0,
        BRANCH_COLOR_PLAIN = 1,
        BRANCH_COLOR_REMOTE = 2,
        BRANCH_COLOR_LOCAL = 3,
        BRANCH_COLOR_CURRENT = 4,
        BRANCH_COLOR_UPSTREAM = 5,
        BRANCH_COLOR_WORKTREE = 6,
    }
    internal static void DeleteBranchConfig(string Branchname)
    {
    }

    internal static int CalcMaxwidth(nint Refs, int RemoteBonus)
        => default;

    internal static void PrintCurrentBranchName()
    {
    }

    internal const int IS_HEAD = 1;
    internal const int IS_ORPHAN = 2;
    internal static void CopyOrRenameBranch(string Oldname, string Newname, int Copy, int Force)
    {
    }

    internal static int EditBranchDescription(string BranchName)
        => default;

}
