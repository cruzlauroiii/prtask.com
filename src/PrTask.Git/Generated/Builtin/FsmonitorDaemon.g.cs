namespace PrTask.Git.Generated;

internal static partial class FsmonitorDaemon
{
    internal const string FSMONITOR__IPC_THREADS = "fsmonitor.ipcthreads";
    internal const string FSMONITOR__START_TIMEOUT = "fsmonitor.starttimeout";
    internal const string FSMONITOR__ANNOUNCE_STARTUP = "fsmonitor.announcestartup";
    internal static int DoAsClientSendStop()
        => default;

    internal static int DoAsClientStatus()
        => default;

    internal enum FsmonitorCookieItemResult
    {
        FCIR_ERROR = -1,
        FCIR_INIT,
        FCIR_SEEN,
        FCIR_ABORT,
    }
    internal static void WithLockAbortAllCookies(nint State)
    {
    }

    internal static void FsmonitorBatchFreeList(nint Batch)
    {
    }

    internal static void FsmonitorFreeTokenData(nint Token)
    {
    }

    internal static void WithLockDoForceResync(nint State)
    {
    }

    internal static void FsmonitorForceResync(nint State)
    {
    }

    internal const string FSMONITOR_DIR = "fsmonitor--daemon";
    internal const string FSMONITOR_COOKIE_DIR = "cookies";
    internal static int FsmonitorRunDaemon1(nint State)
        => default;

    internal static int FsmonitorRunDaemon()
        => default;

    internal static int TryToRunForegroundDaemon(Int detachConsole MAYBEUNUSED)
        => default;

    internal static int TryToStartBackgroundDaemon()
        => default;

    internal static int CmdFsmonitorDaemon(int Argc, string Argv, nint UNUSED, nint UNUSED)
        => default;

}
