namespace PrTask.Git.Generated;

internal static partial class Fsck
{
    internal const int REACHABLE = 0x0001;
    internal const int SEEN = 0x0002;
    internal const int HAS_OBJ = 0x0004;
    internal const int USED = 0x0008;
    internal const int ERROR_OBJECT = 01;
    internal const int ERROR_REACHABLE = 02;
    internal const int ERROR_PACK = 04;
    internal const int ERROR_REFS = 010;
    internal const int ERROR_COMMIT_GRAPH = 020;
    internal const int ERROR_MULTI_PACK_INDEX = 040;
    internal const int ERROR_PACK_REV_INDEX = 0100;
    internal const int ERROR_BITMAP = 0200;
    internal static int Objerror(nint Obj, string Err)
        => default;

    internal static void MarkObjectReachable(nint Obj)
    {
    }

    internal static int TraverseOneObject(nint Obj)
        => default;

    internal static int TraverseReachable()
        => default;

    internal static void CheckReachableObject(nint Obj)
    {
    }

    internal static void CheckUnreachableObject(nint Obj)
    {
    }

    internal static void CheckObject(nint Obj)
    {
    }

    internal static void CheckConnectivity()
    {
    }

    internal static int FsckObj(nint Obj, nint Buffer, Unlong Size)
        => default;

    internal static int FsckHandleReflog(string Logname, nint CbData)
        => default;

    internal static int SnapshotRef(nint Ref, nint CbData)
        => default;

    internal static int FsckHandleRef(nint Ref, nint UNUSED)
        => default;

    internal static void SnapshotRefs(nint Snap, int Argc, string Argv)
    {
    }

    internal static void FreeSnapshotRefs(nint Snap)
    {
    }

    internal static void ProcessRefs(nint Snap)
    {
    }

    internal static int FsckSubdir(Unint Nr, nint UNUSED, nint Data)
        => default;

    internal static void FsckSource(nint Source)
    {
    }

    internal static int FsckCacheTree(nint It, string IndexPath)
        => default;

    internal static int CheckPackRevIndexes(nint R, int ShowProgress)
        => default;

    internal static void FsckRefs(nint R)
    {
    }

}
