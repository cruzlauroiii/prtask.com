namespace PrTask.Git.Generated;

internal static partial class Stack
{
    internal static int StackFsync(nint Opts, int Fd)
        => default;

    internal static nint ReftableWriteData(int Fd, nint Data, nuint Size)
        => default;

    internal static nint FdWriterWrite(nint Arg, nint Data, nuint Sz)
        => default;

    internal static int FdWriterFlush(nint Arg)
        => default;

    internal static int FdReadLines(int Fd, string Namesp)
        => default;

    internal static int ReadLines(string Filename, string Namesp)
        => default;

    internal static int HasName(string Names, string Name)
        => default;

    internal static void ReftableStackDestroy(nint St)
    {
    }

    internal static int TvCmp(nint A, nint B)
        => default;

    internal static int StackUptodate(nint St)
        => default;

    internal static int ReftableStackReload(nint St)
        => default;

    internal static void ReftableAdditionClose(nint Add)
    {
    }

    internal static int FormatName(nint Dest, ulong Min, ulong Max)
        => default;

    internal static void ReftableAdditionDestroy(nint Add)
    {
    }

    internal static int ReftableAdditionCommit(nint Add)
        => default;

    internal static ulong ReftableStackNextUpdateIndex(nint St)
        => default;

    internal enum StackCompactRangeFlags
    {
        STACK_COMPACT_RANGE_BEST_EFFORT = (1 << 0),
    }
    internal static int SegmentSize(nint S)
        => default;

    internal static int ReftableStackAutoCompact(nint St)
        => default;

    internal static int IsTableName(string S)
        => default;

    internal static int ReftableStackCleanLocked(nint St)
        => default;

    internal static int ReftableStackClean(nint St)
        => default;

    internal static ReftableHash ReftableStackHashId(nint St)
        => default;

}
