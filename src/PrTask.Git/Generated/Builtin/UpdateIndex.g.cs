namespace PrTask.Git.Generated;

internal static partial class UpdateIndex
{
    internal const int MARK_FLAG = 1;
    internal const int UNMARK_FLAG = 2;
    internal enum UcMode
    {
        UC_UNSPECIFIED = -1,
        UC_DISABLE = 0,
        UC_ENABLE,
        UC_TEST,
        UC_FORCE,
    }
    internal static void Report(string Fmt, params object[] VarArgs)
    {
    }

    internal static void RemoveTestDirectory()
    {
    }

    internal static void Xmkdir(string Path)
    {
    }

    internal static int XstatMtimeDir(nint St)
        => default;

    internal static int CreateFile(string Path)
        => default;

    internal static void Xunlink(string Path)
    {
    }

    internal static void Xrmdir(string Path)
    {
    }

    internal static void AvoidRacy()
    {
    }

    internal static int TestIfUntrackedCacheIsSupported()
        => default;

    internal static int MarkCeFlags(string Path, int Flag, int Mark)
        => default;

    internal static int RemoveOnePath(string Path)
        => default;

    internal static int ProcessLstatError(string Path, int Err)
        => default;

    internal static int AddOnePath(nint Old, string Path, int Len, nint St)
        => default;

    internal static int ProcessDirectory(string Path, int Len, nint St)
        => default;

    internal static int ProcessPath(string Path, nint St, int StatErrno)
        => default;

    internal static void ChmodPath(byte Flip, string Path)
    {
    }

    internal static void UpdateOne(string Path)
    {
    }

    internal static void ReadIndexInfo(int NulTermLine)
    {
    }

    internal static int UnresolveOne(string Path)
        => default;

    internal static int Refresh(nint O, Unint Flag)
        => default;

}
