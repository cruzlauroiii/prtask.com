namespace PrTask.Git.Generated;

internal static partial class Packfile
{
    internal static void PackfileListClear(nint List)
    {
    }

    internal static void PackfileListRemove(nint List, nint Pack)
    {
    }

    internal static void PackfileListPrepend(nint List, nint Pack)
    {
    }

    internal static void PackfileListAppend(nint List, nint Pack)
    {
    }

    internal static void PackReport(nint Repo)
    {
    }

    internal static int CheckPackedGitIdx(string Path, nint P)
        => default;

    internal static int OpenPackIndex(nint P)
        => default;

    internal static uint GetPackFanout(nint P, uint Value)
        => default;

    internal static int UnuseOneWindow(nint Odb)
        => default;

    internal static void ClosePackWindows(nint P)
    {
    }

    internal static int ClosePackFd(nint P)
        => default;

    internal static void ClosePackIndex(nint P)
    {
    }

    internal static void ClosePackRevindex(nint P)
    {
    }

    internal static void ClosePackMtimes(nint P)
    {
    }

    internal static void ClosePack(nint P)
    {
    }

    internal static void UnlinkPackPath(string PackName, int ForceDelete)
    {
    }

    internal static void FindLruPack(nint P, nint LruP, nint MruW, nint AcceptWindowsInuse)
    {
    }

    internal static int CloseOnePack(nint R)
        => default;

    internal static Unint GetMaxFdLimit()
        => default;

    internal static int OpenPackedGit1(nint P)
        => default;

    internal static int OpenPackedGit(nint P)
        => default;

    internal static void UnusePack(nint WCursor)
    {
    }

    internal static void ReportPackGarbage(nint List)
    {
    }

    internal static void PreparePackedGitOne(nint Source)
    {
    }

    internal static void PackfileStorePrepare(nint Store)
    {
    }

    internal static void PackfileStoreReprepare(nint Store)
    {
    }

    internal static Unlong RepoApproximateObjectCount(nint R)
        => default;

    internal static void MarkBadPackedObject(nint P, nint Oid)
    {
    }

    internal const int POI_STACK_PREALLOC = 64;
    internal static Unint PackEntryHash(nint P, long BaseOffset)
        => default;

    internal static int InDeltaBaseCache(nint P, long BaseOffset)
        => default;

    internal static void DetachDeltaBaseCacheEntry(nint Ent)
    {
    }

    internal static void ReleaseDeltaBaseCache(nint Ent)
    {
    }

    internal static void ClearDeltaBaseCache()
    {
    }

    internal static void WritePackAccessLog(nint P, long ObjOffset)
    {
    }

    internal const int UNPACK_ENTRY_STACK_PREALLOC = 64;
    internal static int BsearchPack(nint Oid, nint P, nint Result)
        => default;

    internal static void CheckPackIndexPtr(nint P, nint Vptr)
    {
    }

    internal static long NthPackedObjectOffset(nint P, uint N)
        => default;

    internal static int IsPackValid(nint P)
        => default;

    internal static int HasObjectPack(nint R, nint Oid)
        => default;

    internal static int IsPromisorObject(nint R, nint Oid)
        => default;

    internal static int ParsePackHeaderOption(string In, nint Out, nint Len)
        => default;

    internal static void PackfileStoreFree(nint Store)
    {
    }

    internal static void PackfileStoreClose(nint Store)
    {
    }

    internal static int CloseIstreamPackNonDelta(nint St)
        => default;

}
