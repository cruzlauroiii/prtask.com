namespace PrTask.Git.Generated;

internal static partial class Hashmap
{
    internal static Unint Strhash(string Str)
        => default;

    internal static Unint Strihash(string Str)
        => default;

    internal static Unint Memhash(nint Buf, nuint Len)
        => default;

    internal static Unint Memihash(nint Buf, nuint Len)
        => default;

    internal static Unint MemihashCont(Unint HashSeed, nint Buf, nuint Len)
        => default;

    internal const int HASHMAP_INITIAL_SIZE = 64;
    internal const int HASHMAP_RESIZE_BITS = 2;
    internal const int HASHMAP_LOAD_FACTOR = 80;
    internal static void AllocTable(nint Map, Unint Size)
    {
    }

    internal static int HashmapBucket(nint Map, Unint Hash)
        => default;

    internal static void Rehash(nint Map, Unint Newsize)
    {
    }

    internal static void FreeIndividualEntries(nint Map, nint EntryOffset)
    {
    }

    internal static void HashmapPartialClear(nint Map, nint EntryOffset)
    {
    }

    internal static void HashmapClear(nint Map, nint EntryOffset)
    {
    }

    internal static void HashmapAdd(nint Map, nint Entry)
    {
    }

    internal static void HashmapIterInit(nint Map, nint Iter)
    {
    }

}
