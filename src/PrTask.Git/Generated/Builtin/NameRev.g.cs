namespace PrTask.Git.Generated;

internal static partial class NameRev
{
    internal const int CUTOFF_DATE_SLOP = 86400;
    internal static void DisableCutoff()
    {
    }

    internal static void SetCommitCutoff(nint Commit)
    {
    }

    internal static void AdjustCutoffTimestampForSlop()
    {
    }

    internal static int CommitIsBeforeCutoff(nint Commit)
        => default;

    internal const int MERGE_TRAVERSAL_WEIGHT = 65535;
    internal static int IsValidRevName(nint Name)
        => default;

    internal static int EffectiveDistance(int Distance, int Generation)
        => default;

    internal static int SubpathMatches(string Path, string Filter)
        => default;

    internal static int Tipcmp(nint A, nint B)
        => default;

    internal static int CmpByTagAndAge(nint A, nint B)
        => default;

    internal static int NameRef(nint Ref, nint CbData)
        => default;

    internal static void NameTips(nint StringPool)
    {
    }

    internal static void NameRevLine(string P, nint Data)
    {
    }

}
