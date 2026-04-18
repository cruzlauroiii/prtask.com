namespace PrTask.Git.Generated;

internal static partial class GitZlib
{
    internal static UInt ZlibBufCap(Unlong Len)
        => default;

    internal static void ZlibPreCall(nint S)
    {
    }

    internal static void ZlibPostCall(nint S, int Status)
    {
    }

    internal static void GitInflateInit(nint Strm)
    {
    }

    internal static void GitInflateInitGzipOnly(nint Strm)
    {
    }

    internal static void GitInflateEnd(nint Strm)
    {
    }

    internal static int GitInflate(nint Strm, int Flush)
        => default;

    internal static Unlong GitDeflateBound(nint Strm, Unlong Size)
        => default;

    internal static void GitDeflateInit(nint Strm, int Level)
    {
    }

    internal static void DoGitDeflateInit(nint Strm, int Level, int WindowBits)
    {
    }

    internal static void GitDeflateInitGzip(nint Strm, int Level)
    {
    }

    internal static void GitDeflateInitRaw(nint Strm, int Level)
    {
    }

    internal static int GitDeflateAbort(nint Strm)
        => default;

    internal static void GitDeflateEnd(nint Strm)
    {
    }

    internal static int GitDeflateEndGently(nint Strm)
        => default;

    internal static int GitDeflate(nint Strm, int Flush)
        => default;

}
