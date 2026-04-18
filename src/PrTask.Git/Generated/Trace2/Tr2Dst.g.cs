namespace PrTask.Git.Generated;

internal static partial class Tr2Dst
{
    internal const int MAX_AUTO_ATTEMPTS = 10;
    internal const string DISCARD_SENTINEL_NAME = "git-trace2-discard";
    internal static int Tr2DstWantWarning()
        => default;

    internal static void Tr2DstTraceDisable(nint Dst)
    {
    }

    internal static int Tr2DstTooManyFiles(nint Dst, string TgtPrefix)
        => default;

    internal static int Tr2DstTryAutoPath(nint Dst, string TgtPrefix)
        => default;

    internal static int Tr2DstTryPath(nint Dst, string TgtValue)
        => default;

    internal const string PREFIX_AF_UNIX = "af_unix:";
    internal const string PREFIX_AF_UNIX_STREAM = "af_unix:stream:";
    internal const string PREFIX_AF_UNIX_DGRAM = "af_unix:dgram:";
    internal static int Tr2DstTryUdsConnect(string Path, int SockType, nint OutFd)
        => default;

    internal static int Tr2DstGetTraceFd(nint Dst)
        => default;

    internal static int Tr2DstTraceWant(nint Dst)
        => default;

    internal static void Tr2DstWriteLine(nint Dst, nint BufLine)
    {
    }

}
