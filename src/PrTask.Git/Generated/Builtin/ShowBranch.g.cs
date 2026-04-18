namespace PrTask.Git.Generated;

internal static partial class ShowBranch
{
    internal const int UNINTERESTING = 01;
    internal const int REV_SHIFT = 2;
    internal const int DEFAULT_REFLOG = 4;
    internal static void NameCommit(nint Commit, string HeadName, int Nth)
    {
    }

    internal static void NameParent(nint Commit, nint Parent)
    {
    }

    internal static int NameFirstParentChain(nint C)
        => default;

    internal static int MarkSeen(nint Commit, nint SeenP)
        => default;

    internal static void ShowOneCommit(nint Commit, int NoName)
    {
    }

    internal static int VersionCmp(string A, string B)
        => default;

    internal static int CompareRefName(nint A, nint B)
        => default;

    internal static void SortRefRange(int Bottom, int Top)
    {
    }

    internal static int AppendHeadRef(nint Ref, nint UNUSED)
        => default;

    internal static int AppendRemoteRef(nint Ref, nint UNUSED)
        => default;

    internal static int AppendMatchingRef(nint Ref, nint CbData)
        => default;

    internal static void SnarfRefs(int Head, int Remotes)
    {
    }

    internal static int RevIsHead(string Head, string Name)
        => default;

    internal static int ShowMergeBase(nint Seen, int NumRev)
        => default;

    internal static void AppendOneRev(string Av)
    {
    }

    internal static int OmitInDense(nint Commit, nint Rev, int N)
        => default;

}
