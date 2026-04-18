namespace PrTask.Git.Generated;

internal static partial class Lockfile
{
    internal static void TrimLastPathComponent(nint Path)
    {
    }

    internal const int MAXDEPTH = 5;
    internal static void ResolveSymlink(nint Path)
    {
    }

    internal static void GetLockPath(nint Out, string Path)
    {
    }

    internal static void GetPidPath(nint Out, string Path)
    {
    }

    internal static int ReadLockPid(string PidPath, nint PidOut)
        => default;

    internal const int INITIAL_BACKOFF_MS = 1;
    internal const int BACKOFF_MAX_MULTIPLIER = 1000;
    internal static void UnableToLockMessage(string Path, int Err, nint Buf)
    {
    }

    internal static NORETURN void UnableToLockDie(string Path, int Err)
        => default;

    internal static int CommitLockFile(nint Lk)
        => default;

    internal static int RollbackLockFile(nint Lk)
        => default;

}
