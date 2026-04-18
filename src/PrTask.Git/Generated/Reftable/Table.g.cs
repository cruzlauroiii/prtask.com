namespace PrTask.Git.Generated;

internal static partial class Table
{
    internal static ReftableHash ReftableTableHashId(nint T)
        => default;

    internal static int TableIterInit(nint Ti, nint T)
        => default;

    internal static void TableIterBlockDone(nint Ti)
    {
    }

    internal static void TableIterClose(nint Ti)
    {
    }

    internal static int TableIterNextBlock(nint Ti)
        => default;

    internal static int TableIterNext(nint Ti, nint Rec)
        => default;

    internal static int TableIterSeekTo(nint Ti, ulong Off, byte Typ)
        => default;

    internal static int TableIterSeekStart(nint Ti, byte Typ, int Index)
        => default;

    internal static int TableIterSeekVoid(nint Ti, nint Want)
        => default;

    internal static int TableIterNextVoid(nint Ti, nint Rec)
        => default;

    internal static void TableIterCloseVoid(nint Ti)
    {
    }

    internal static void ReftableTableIncref(nint T)
    {
    }

    internal static void ReftableTableDecref(nint T)
    {
    }

    internal static ulong ReftableTableMaxUpdateIndex(nint T)
        => default;

    internal static ulong ReftableTableMinUpdateIndex(nint T)
        => default;

    internal static void ReftableTableIteratorRelease(nint It)
    {
    }

}
