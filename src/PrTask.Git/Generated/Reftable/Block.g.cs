namespace PrTask.Git.Generated;

internal static partial class Block
{
    internal static nuint HeaderSize(int Version)
        => default;

    internal static nuint FooterSize(int Version)
        => default;

    internal static byte BlockWriterType(nint Bw)
        => default;

    internal static int BlockWriterAdd(nint W, nint Rec)
        => default;

    internal static int BlockWriterFinish(nint W)
        => default;

    internal static void ReftableBlockRelease(nint Block)
    {
    }

    internal static byte ReftableBlockType(nint B)
        => default;

    internal static int ReftableBlockFirstKey(nint Block, nint Key)
        => default;

    internal static uint BlockRestartOffset(nint B, nuint Idx)
        => default;

    internal static void BlockIterInit(nint It, nint Block)
    {
    }

    internal static void BlockIterSeekStart(nint It)
    {
    }

    internal static int RestartNeedleLess(nuint Idx, nint Args)
        => default;

    internal static int BlockIterNext(nint It, nint Rec)
        => default;

    internal static void BlockIterReset(nint It)
    {
    }

    internal static void BlockIterClose(nint It)
    {
    }

    internal static int BlockIterSeekKey(nint It, nint Want)
        => default;

    internal static int BlockIterSeekVoid(nint It, nint Want)
        => default;

    internal static int BlockIterNextVoid(nint It, nint Rec)
        => default;

    internal static void BlockIterCloseVoid(nint It)
    {
    }

    internal static void BlockWriterRelease(nint Bw)
    {
    }

}
