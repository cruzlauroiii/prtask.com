namespace PrTask.Git.Generated;

internal static partial class CacheTree
{
    internal const int DEBUG_CACHE_TREE = 0;
    internal static void CacheTreeFree(nint ItP)
    {
    }

    internal static int CacheTreeSubtreePos(nint It, string Path, int Pathlen)
        => default;

    internal static int DoInvalidatePath(nint It, string Path)
        => default;

    internal static void CacheTreeInvalidatePath(nint Istate, string Path)
    {
    }

    internal static int VerifyCache(nint Istate, int Flags)
        => default;

    internal static void DiscardUnusedSubtrees(nint It)
    {
    }

    internal static int CacheTreeFullyValid(nint It)
        => default;

    internal static int MustCheckExistence(nint Ce)
        => default;

    internal static int CacheTreeUpdate(nint Istate, int Flags)
        => default;

    internal static void CacheTreeWrite(nint Sb, nint Root)
    {
    }

    internal static int ParseInt(string Ptr, nint LenP, nint Out)
        => default;

    internal static Tree WriteInCoreIndexAsTree(nint Repo)
        => default;

    internal static int WriteIndexAsTree(nint Oid, nint IndexState, string IndexPath, int Flags, string Prefix)
        => default;

    internal static int CacheTreeVerify(nint R, nint Istate)
        => default;

}
