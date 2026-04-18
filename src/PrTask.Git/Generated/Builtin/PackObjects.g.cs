namespace PrTask.Git.Generated;

internal static partial class PackObjects
{
    internal enum MissingAction
    {
        MA_ERROR = 0,
        MA_ALLOW_ANY,
        MA_ALLOW_PROMISOR,
    }
    internal enum StdinPacksMode
    {
        STDIN_PACKS_MODE_NONE,
        STDIN_PACKS_MODE_STANDARD,
        STDIN_PACKS_MODE_FOLLOW,
    }
    internal static void ValidateNameHashVersion()
    {
    }

    internal static uint PackNameHashFn(string Name)
        => default;

    internal static void IndexCommitForBitmap(nint Commit)
    {
    }

    internal static Unlong DoCompress(nint Pptr, Unlong Size)
        => default;

    internal enum WriteOneStatus
    {
        WRITE_ONE_SKIP = -1,
        WRITE_ONE_BREAK = 0,
        WRITE_ONE_WRITTEN = 1,
        WRITE_ONE_RECURSIVE = 2,
    }
    internal static int MarkTagged(nint Ref, nint UNUSED)
        => default;

    internal static void ComputeLayerOrder(nint Wo, nint WoEnd)
    {
    }

    internal static void RecordReusedObject(long Where, long Offset)
    {
    }

    internal static long FindReusedOffset(long Where)
        => default;

    internal static void WriteExcludedByConfigs()
    {
    }

    internal static void WritePackFile()
    {
    }

    internal static int NoTryDelta(string Path)
        => default;

    internal static int PbaseTreeCacheIx(nint Oid)
        => default;

    internal static int PbaseTreeCacheIxIncr(int Ix)
        => default;

    internal static void PbaseTreePut(nint Cache)
    {
    }

    internal static nuint NameCmpLen(string Name)
        => default;

    internal static int DonePbasePathPos(uint Hash)
        => default;

    internal static int CheckPbasePath(uint Hash)
        => default;

    internal static void AddPreferredBaseObject(string Name)
    {
    }

    internal static void AddPreferredBase(nint Oid)
    {
    }

    internal static void CleanupPreferredBase()
    {
    }

    internal static void PrefetchToPack(uint ObjectIndexStart)
    {
    }

    internal static void CheckObject(nint Entry, uint ObjectIndex)
    {
    }

    internal static int PackOffsetSort(nint A, nint B)
        => default;

    internal static void DropReusedDelta(nint Entry)
    {
    }

    internal static void BreakDeltaChains(nint Entry)
    {
    }

    internal static void GetObjectDetails()
    {
    }

    internal static int TypeSizeSort(nint A, nint B)
        => default;

    internal static Unint CheckDeltaLimit(nint Me, Unint N)
        => default;

    internal static Unlong FreeUnpacked(nint N)
        => default;

    internal static void InitThreadedSearch()
    {
    }

    internal static void CleanupThreadedSearch()
    {
    }

    internal static int ObjIsPacked(nint Oid)
        => default;

    internal static void AddTagChain(nint Oid)
    {
    }

    internal static int AddRefTag(nint Ref, nint UNUSED)
        => default;

    internal static int ShouldAttemptDeltas(nint Entry)
        => default;

    internal static void PreparePack(int Window, int Depth)
    {
    }

    internal static void ShowCommitPackHint(nint Commit, nint Data)
    {
    }

    internal static int PackMtimeCmp(nint A, nint B)
        => default;

    internal static void ReadPacksListFromStdin(nint Revs)
    {
    }

    internal static void ReadStdinPacks(StdinPacksMode Mode, int RevListUnpacked)
    {
    }

    internal static void ShowCruftObject(nint Obj, string Name, nint UNUSED)
    {
    }

    internal static void ShowCruftCommit(nint Commit, nint Data)
    {
    }

    internal static int CruftIncludeCheckObj(nint Obj, nint UNUSED)
        => default;

    internal static int CruftIncludeCheck(nint Commit, nint Data)
        => default;

    internal static void MarkPackKeptInCore(nint Packs, uint Keep)
    {
    }

    internal static void EnumerateCruftObjects()
    {
    }

    internal static void EnumerateAndTraverseCruftObjects(nint FreshPacks)
    {
    }

    internal static void ReadCruftObjects()
    {
    }

    internal static void ReadObjectListFromStdin()
    {
    }

    internal static void ShowCommit(nint Commit, nint UNUSED)
    {
    }

    internal static void ShowObjectMaAllowAny(nint Obj, string Name, nint Data)
    {
    }

    internal static void ShowObjectMaAllowPromisor(nint Obj, string Name, nint Data)
    {
    }

    internal static void ShowEdge(nint Commit)
    {
    }

    internal static void AddObjectsInUnpackedPacks()
    {
    }

    internal static void AddUnreachableLooseObjects(nint Revs)
    {
    }

    internal static int HasSha1PackKeptOrNonlocal(nint Oid)
        => default;

    internal static void LoosenUnusedPackedObjects()
    {
    }

    internal static int PackOptionsAllowReuse()
        => default;

    internal static int GetObjectListFromBitmap(nint Revs)
        => default;

    internal static void RecordRecentCommit(nint Commit, nint UNUSED)
    {
    }

    internal static int MarkBitmapPreferredTip(nint Ref, nint UNUSED)
        => default;

    internal static void GetObjectListPathWalk(nint Revs)
    {
    }

    internal static void GetObjectList(nint Revs, nint Argv)
    {
    }

    internal static void AddExtraKeptPacks(nint Names)
    {
    }

    internal static int IsNotInPromisorPackObj(nint Obj, nint UNUSED)
        => default;

    internal static int IsNotInPromisorPack(nint Commit, nint Data)
        => default;

}
