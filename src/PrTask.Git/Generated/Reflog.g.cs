namespace PrTask.Git.Generated;

internal static partial class Reflog
{
    internal static void ReflogClearExpireConfig(nint Opts)
    {
    }

    internal static int TreeIsComplete(nint Oid)
        => default;

    internal static int CommitIsComplete(nint Commit)
        => default;

    internal static int KeepEntry(nint It, nint Oid)
        => default;

    internal static void MarkReachable(nint Cb)
    {
    }

    internal static int IsUnreachable(nint Cb, nint Commit, nint Oid)
        => default;

    internal static int PushTipToList(nint Ref, nint CbData)
        => default;

    internal static int IsHead(string Refname)
        => default;

    internal static void ReflogExpiryCleanup(nint CbData)
    {
    }

    internal static int ReflogDelete(string Rev, ExpireReflogFlags Flags, int Verbose)
        => default;

}
