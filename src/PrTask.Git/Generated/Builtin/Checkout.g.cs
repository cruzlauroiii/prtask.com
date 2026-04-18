namespace PrTask.Git.Generated;

internal static partial class Checkout
{
    internal static void BranchInfoRelease(nint Info)
    {
    }

    internal static int ReadTreeSome(nint Tree, nint Pathspec)
        => default;

    internal static int SkipSameName(nint Ce, int Pos)
        => default;

    internal static int CheckStages(uint Stages, nint Ce, int Pos)
        => default;

    internal static void DescribeDetachedHead(string Msg, nint Commit)
    {
    }

    internal static void SetupBranchPath(nint Branch)
    {
    }

    internal static void ReportTracking(nint NewBranchInfo)
    {
    }

    internal static int AddPendingUninterestingRef(nint Ref, nint CbData)
        => default;

    internal static void DescribeOneOrphan(nint Sb, nint Commit)
    {
    }

    internal const int ORPHAN_CUTOFF = 4;
    internal static void SuggestReattach(nint Commit, nint Revs)
    {
    }

    internal static void OrphanedCommitWarning(nint OldCommit, nint NewCommit)
    {
    }

    internal enum CheckoutCommand
    {
        CHECKOUT_CHECKOUT = 1,
        CHECKOUT_SWITCH = 2,
        CHECKOUT_RESTORE = 3,
    }
    internal static int SwitchUnbornToNewBranch(nint Opts)
        => default;

    internal static void DieExpectingABranch(nint BranchInfo)
    {
    }

    internal static void DieIfSomeOperationInProgress()
    {
    }

    internal static int ParseOptConflict(nint O, string Arg, int Unset)
        => default;

}
