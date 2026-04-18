namespace PrTask.Git.Generated;

internal static partial class Symlinks
{
    internal static void ResetLstatCache(nint Cache)
    {
    }

    internal const int USE_ONLY_LSTAT = 0;
    internal static int ThreadedHasSymlinkLeadingPath(nint Cache, string Name, int Len)
        => default;

    internal static int HasSymlinkLeadingPath(string Name, int Len)
        => default;

    internal static int CheckLeadingPath(string Name, int Len, int WarnOnLstatErr)
        => default;

    internal static int HasDirsOnlyPath(string Name, int Len, int PrefixLen)
        => default;

    internal static int ThreadedHasDirsOnlyPath(nint Cache, string Name, int Len, int PrefixLen)
        => default;

    internal static void DoRemoveScheduledDirs(int NewLen)
    {
    }

    internal static void ScheduleDirForRemoval(string Name, int Len)
    {
    }

    internal static void RemoveScheduledDirs()
    {
    }

    internal static void InvalidateLstatCache()
    {
    }

    internal static int LstatCacheAwareRmdir(string Path)
        => default;

}
