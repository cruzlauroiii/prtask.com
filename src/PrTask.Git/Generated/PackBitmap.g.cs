namespace PrTask.Git.Generated;

internal static partial class PackBitmap
{
    internal static uint BitmapNumObjectsTotal(nint Index)
        => default;

    internal static uint BitmapNumObjects(nint Index)
        => default;

    internal static uint BitmapNameHash(nint Index, uint Pos)
        => default;

    internal static int LoadBitmapHeader(nint Index)
        => default;

    internal static uint ReadBe32(nint Buffer, nint Pos)
        => default;

    internal static byte ReadU8(nint Buffer, nint Pos)
        => default;

    internal const int MAX_XOR_OFFSET = 160;
    internal static int LoadBitmapEntriesV1(nint Index)
        => default;

    internal static int OpenPackBitmap1(nint BitmapGit, nint Packfile)
        => default;

    internal static int LoadReverseIndex(nint R, nint BitmapGit)
        => default;

    internal static void LoadAllTypeBitmaps(nint BitmapGit)
    {
    }

    internal static int BitmapIndexContainsPack(nint Bitmap, nint Pack)
        => default;

    internal static int TripletCmp(nint CommitPos, nint TableEntry)
        => default;

    internal static void ShowObject(nint Object, string Name, nint Data)
    {
    }

    internal static int ShouldInclude(nint Commit, nint Data)
        => default;

    internal static int ShouldIncludeObj(nint Obj, nint Data)
        => default;

    internal static void ShowBoundaryCommit(nint Commit, nint Data)
    {
    }

    internal static void UnsatisfyAllPseudoMerges(nint BitmapGit)
    {
    }

    internal static int CanFilterBitmap(nint Filter)
        => default;

    internal static int BitmappedPackCmp(nint Va, nint Vb)
        => default;

    internal static void TestShowCommit(nint Commit, nint Data)
    {
    }

    internal static uint BitmapTotalEntryCount(nint BitmapGit)
        => default;

    internal static void BitmapTestDataRelease(nint Tdata)
    {
    }

    internal static void TestBitmapWalk(nint Revs)
    {
    }

    internal static int TestBitmapCommits(nint R)
        => default;

    internal static int TestBitmapCommitsWithOffset(nint R)
        => default;

    internal static int TestBitmapHashes(nint R)
        => default;

    internal static int TestBitmapPseudoMerges(nint R)
        => default;

    internal static int TestBitmapPseudoMergeCommits(nint R, uint N)
        => default;

    internal static int TestBitmapPseudoMergeObjects(nint R, uint N)
        => default;

    internal static void FreeBitmapIndex(nint B)
    {
    }

    internal static long GetDiskUsageForExtended(nint BitmapGit)
        => default;

    internal static int BitmapIsMidx(nint BitmapGit)
        => default;

    internal static int BitmapIsPreferredRefname(nint R, string Refname)
        => default;

    internal static int VerifyBitmapFiles(nint R)
        => default;

}
