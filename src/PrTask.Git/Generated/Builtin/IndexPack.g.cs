namespace PrTask.Git.Generated;

internal static partial class IndexPack
{
    internal static void LockMutex(nint Mutex)
    {
    }

    internal static void UnlockMutex(nint Mutex)
    {
    }

    internal static void InitThread()
    {
    }

    internal static void CleanupThread()
    {
    }

    internal static uint CheckObject(nint Obj)
        => default;

    internal static uint CheckObjects()
        => default;

    internal static void Flush()
    {
    }

    internal static void Use(int Bytes)
    {
    }

    internal static void ParsePackHeader()
    {
    }

    internal static NORETURN void BadObject(long Offset, string Format, params object[] VarArgs)
        => default;

    internal static void SetThreadData(nint Data)
    {
    }

    internal static void FreeBaseData(nint C)
    {
    }

    internal static void PruneBaseData(nint Retain)
    {
    }

    internal static int IsDeltaType(ObjectType Type)
        => default;

    internal static int FindOfsDelta(long Offset)
        => default;

    internal static int FindRefDelta(nint Oid)
        => default;

    internal static int CheckCollison(nint Entry)
        => default;

    internal static void RecordOutgoingLink(nint Oid)
    {
    }

    internal static void MaybeRecordNameEntry(nint Entry)
    {
    }

    internal static void DoRecordOutgoingLinks(nint Obj)
    {
    }

    internal static int CompareOfsDeltaEntry(nint A, nint B)
        => default;

    internal static int CompareRefDeltaEntry(nint A, nint B)
        => default;

    internal static void ParsePackObjects(nint Hash)
    {
    }

    internal static void ResolveDeltas(nint Opts)
    {
    }

    internal static void ConcludePack(int FixThinPack, string CurrPack, nint PackHash)
    {
    }

    internal static int WriteCompressed(nint F, nint In, Unint Size)
        => default;

    internal static int DeltaPosCompare(nint A, nint B)
        => default;

    internal static void FixUnresolvedDeltas(nint F)
    {
    }

    internal static int CmpUint32(nint A, nint B)
        => default;

    internal static void ReadIdxOption(nint Opts, string PackName)
    {
    }

    internal static void ShowPackInfo(int StatOnly)
    {
    }

    internal static void RepackLocalLinks()
    {
    }

}
