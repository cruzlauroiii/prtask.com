namespace PrTask.Git.Generated;

internal static partial class Xprepare
{
    internal const int XDL_KPDIS_RUN = 4;
    internal const int XDL_MAX_EQLIMIT = 1024;
    internal const int XDL_SIMSCAN_WINDOW = 100;
    internal const int XDL_GUESS_NLINES1 = 256;
    internal const int XDL_GUESS_NLINES2 = 20;
    internal const int DISCARD = 0;
    internal const int KEEP = 1;
    internal const int INVESTIGATE = 2;
    internal static int XdlInitClassifier(nint Cf, long Size, long Flags)
        => default;

    internal static void XdlFreeClassifier(nint Cf)
    {
    }

    internal static void XdlFreeCtx(nint Xdf)
    {
    }

    internal static void XdlFreeEnv(nint Xe)
    {
    }

    internal static bool XdlCleanMmatch(nint Action, long I, long S, long E)
        => default;

    internal static int XdlCleanupRecords(nint Cf, nint Xdf1, nint Xdf2)
        => default;

    internal static int XdlTrimEnds(nint Xdf1, nint Xdf2)
        => default;

    internal static int XdlOptimizeCtxs(nint Cf, nint Xdf1, nint Xdf2)
        => default;

}
