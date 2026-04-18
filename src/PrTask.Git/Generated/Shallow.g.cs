namespace PrTask.Git.Generated;

internal static partial class Shallow
{
    internal static void SetAlternateShallowFile(nint R, string Path, int Override)
    {
    }

    internal static int RegisterShallow(nint R, nint Oid)
        => default;

    internal static int UnregisterShallow(nint Oid)
        => default;

    internal static int IsRepositoryShallow(nint R)
        => default;

    internal static void ResetRepositoryShallow(nint R)
    {
    }

    internal static int CommitShallowFile(nint R, nint Lk)
        => default;

    internal static void RollbackShallowFile(nint R, nint Lk)
    {
    }

    internal static void FreeDepthInSlab(nint Ptr)
    {
    }

    internal static int GetShallowsDepth(nint Heads, nint Shallows)
        => default;

    internal static void ShowCommit(nint Commit, nint Data)
    {
    }

    internal static void CheckShallowFileForUpdate(nint R)
    {
    }

    internal const int SEEN_ONLY = 1;
    internal const int VERBOSE = 2;
    internal const int QUICK = 4;
    internal static int WriteOneShallow(nint Graft, nint CbData)
        => default;

    internal static int AdvertiseShallowGraftsCb(nint Graft, nint Cb)
        => default;

    internal static void AdvertiseShallowGrafts(int Fd)
    {
    }

    internal static void PruneShallow(uint Options)
    {
    }

    internal static void PrepareShallowInfo(nint Info, nint Sa)
    {
    }

    internal static void ClearShallowInfo(nint Info)
    {
    }

    internal static void RemoveNonexistentTheirsShallow(nint Info)
    {
    }

    internal static int MarkUninteresting(nint Ref, nint UNUSED)
        => default;

    internal static int AddRef(nint Ref, nint CbData)
        => default;

    internal static void UpdateRefstatus(nint RefStatus, nuint Nr, nint Bitmap)
    {
    }

    internal static int DelayedReachabilityTest(nint Si, int C)
        => default;

}
