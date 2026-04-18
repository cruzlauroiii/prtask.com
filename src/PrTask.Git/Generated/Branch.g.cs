namespace PrTask.Git.Generated;

internal static partial class Branch
{
    internal static int FindTrackedBranch(nint Remote, nint Priv)
        => default;

    internal static int ShouldSetupRebase(string Origin)
        => default;

    internal static int InheritTracking(nint Tracking, string OrigRef)
        => default;

    internal static int ReadBranchDesc(nint Buf, string BranchName)
        => default;

    internal static int ValidateBranchname(string Name, nint Ref)
        => default;

    internal static void PrepareCheckedOutBranches()
    {
    }

    internal static int ValidateNewBranchname(string Name, nint Ref, int Force)
        => default;

    internal static int CheckTrackingBranch(nint Remote, nint CbData)
        => default;

    internal static int ValidateRemoteTrackingBranch(string Ref)
        => default;

    internal static void RemoveMergeBranchState(nint R)
    {
    }

    internal static void RemoveBranchState(nint R, int Verbose)
    {
    }

    internal static void DieIfCheckedOut(string Branch, int IgnoreCurrentWorktree)
    {
    }

}
