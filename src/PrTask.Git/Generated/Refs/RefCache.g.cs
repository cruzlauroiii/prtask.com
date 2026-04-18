namespace PrTask.Git.Generated;

internal static partial class RefCache
{
    internal static void AddEntryToDir(nint Dir, nint Entry)
    {
    }

    internal static void FreeRefEntry(nint Entry)
    {
    }

    internal static void FreeRefCache(nint Cache)
    {
    }

    internal static void ClearRefDir(nint Dir)
    {
    }

    internal static int RefEntryCmp(nint A, nint B)
        => default;

    internal static int RefEntryCmpSslice(nint Key, nint Ent)
        => default;

    internal static int SearchRefDir(nint Dir, string Refname, nuint Len)
        => default;

    internal static int IsDupRef(nint Ref1, nint Ref2)
        => default;

    internal static void SortRefDir(nint Dir)
    {
    }

    internal enum PrefixState
    {
        PREFIX_CONTAINS_DIR,
        PREFIX_WITHIN_DIR,
        PREFIX_EXCLUDES_DIR,
    }
    internal static void PrimeRefDir(nint Dir, string Prefix)
    {
    }

    internal static int CacheRefIteratorAdvance(nint RefIterator)
        => default;

    internal static void CacheRefIteratorRelease(nint RefIterator)
    {
    }

}
