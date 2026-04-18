namespace PrTask.Git.Generated;

internal static partial class Bisect
{
    internal static int CountDistance(nint Entry)
        => default;

    internal static void ClearDistance(nint List)
    {
    }

    internal const int DEBUG_BISECT = 0;
    internal static int Weight(nint Elem)
        => default;

    internal static void WeightSet(nint Elem, int Weight)
    {
    }

    internal static int CountInterestingParents(nint Commit, uint BisectFlags)
        => default;

    internal static int ApproxHalfway(nint P, int Nr)
        => default;

    internal static int CompareCommitDist(nint A, nint B)
        => default;

    internal static int RegisterRef(nint Ref, nint UNUSED)
        => default;

    internal static int ReadBisectRefs()
        => default;

    internal static void ReadBisectPaths(nint Array)
    {
    }

    internal const int PRN_MODULO = 32768;
    internal static uint GetPrn(uint Count)
        => default;

    internal static int Sqrti(int Val)
        => default;

    internal static void BisectCommon(nint Revs)
    {
    }

    internal static int IsExpectedRev(nint Oid)
        => default;

    internal static BisectError HandleBadMergeBase()
        => default;

    internal static void HandleSkippedMergeBase(nint Mb)
    {
    }

    internal static BisectError CheckMergeBases(nuint RevNr, nint Rev, int NoCheckout)
        => default;

    internal static void ShowCommit(nint Commit)
    {
    }

    internal static void ReadBisectTerms(string ReadBad, string ReadGood)
    {
    }

    internal static BisectError BisectNextAll(nint R, string Prefix)
        => default;

    internal static int Exp2i(int N)
        => default;

    internal static int EstimateBisectSteps(int All)
        => default;

    internal static int MarkForRemoval(nint Ref, nint CbData)
        => default;

    internal static int BisectCleanState()
        => default;

}
