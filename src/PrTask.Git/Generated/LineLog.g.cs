namespace PrTask.Git.Generated;

internal static partial class LineLog
{
    internal static void RangeSetGrow(nint Rs, nuint Extra)
    {
    }

    internal static void RangeSetInit(nint Rs, nuint Prealloc)
    {
    }

    internal static void RangeSetRelease(nint Rs)
    {
    }

    internal static void RangeSetCopy(nint Dst, nint Src)
    {
    }

    internal static void RangeSetMove(nint Dst, nint Src)
    {
    }

    internal static void RangeSetAppendUnsafe(nint Rs, long A, long B)
    {
    }

    internal static void RangeSetAppend(nint Rs, long A, long B)
    {
    }

    internal static int RangeCmp(nint R, nint S)
        => default;

    internal static void RangeSetCheckInvariants(nint Rs)
    {
    }

    internal static void SortAndMergeRangeSet(nint Rs)
    {
    }

    internal static void DiffRangesInit(nint Diff)
    {
    }

    internal static void DiffRangesRelease(nint Diff)
    {
    }

    internal static void LineLogDataInit(nint R)
    {
    }

    internal static void LineLogDataClear(nint R)
    {
    }

    internal static void FreeLineLogData(nint R)
    {
    }

    internal static int CollectDiff(nint Parent, nint Target, nint Out)
        => default;

    internal static void DumpRangeSet(nint Rs, string Desc)
    {
    }

    internal static void DumpLineLogData(nint R)
    {
    }

    internal static void DumpDiffRanges(nint Diff, string Desc)
    {
    }

    internal static int RangesOverlap(nint A, nint B)
        => default;

    internal static void ClearCommitLineRange(nint Revs, nint Commit)
    {
    }

    internal static void LineLogInit(nint Rev, string Prefix, nint Args)
    {
    }

    internal static void FilterDiffsForPaths(nint Range, int KeepDeletions)
    {
    }

    internal static int DiffMightBeRename()
        => default;

    internal static void DumpDiffHackyOne(nint Rev, nint Range)
    {
    }

    internal static void DumpDiffHacky(nint Rev, nint Range)
    {
    }

    internal static int LineLogPrint(nint Rev, nint Commit)
        => default;

    internal static int LineLogProcessRangesArbitraryCommit(nint Rev, nint Commit)
        => default;

    internal static int LineLogFilter(nint Rev)
        => default;

    internal static void FreeVoidLineLogData(nint Data)
    {
    }

    internal static void LineLogFree(nint Rev)
    {
    }

}
