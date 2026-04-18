namespace PrTask.Git.Generated;

internal static partial class PackedBackend
{
    internal enum MmapStrategy
    {
        MMAP_NONE,
        MMAP_TEMPORARY,
        MMAP_OK,
    }
    internal static void AcquireSnapshot(nint Snapshot)
    {
    }

    internal static void ClearSnapshotBuffer(nint Snapshot)
    {
    }

    internal static int ReleaseSnapshot(nint Snapshot)
        => default;

    internal static nuint SnapshotHexsz(nint Snapshot)
        => default;

    internal static void ClearSnapshot(nint Refs)
    {
    }

    internal static void PackedRefStoreRelease(nint RefStore)
    {
    }

    internal static int CmpPackedRefname(string R1, string R2)
        => default;

    internal static void SortSnapshot(nint Snapshot)
    {
    }

    internal static void VerifyBufferSafe(nint Snapshot)
    {
    }

    internal static int RefnameContainsNul(nint Refname)
        => default;

    internal static int AllocateSnapshotBuffer(nint Snapshot, int Fd, nint St)
        => default;

    internal static int LoadContents(nint Snapshot)
        => default;

    internal static void ValidateSnapshot(nint Refs)
    {
    }

    internal const int REF_KNOWS_PEELED = 0x40;
    internal static int NextRecord(nint Iter)
        => default;

    internal static int PackedRefIteratorAdvance(nint RefIterator)
        => default;

    internal static void PackedRefIteratorRelease(nint RefIterator)
    {
    }

    internal static int JumpListEntryCmp(nint Va, nint Vb)
        => default;

    internal static int HasGlobSpecial(string Str)
        => default;

    internal static int PackedRefsLock(nint RefStore, int Flags, nint Err)
        => default;

    internal static void PackedRefsUnlock(nint RefStore)
    {
    }

    internal static int PackedRefsIsLocked(nint RefStore)
        => default;

}
