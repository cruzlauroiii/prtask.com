namespace PrTask.Git.Generated;

internal static partial class Wrapper
{
    internal static int MemoryLimitCheck(nuint Size, int Gentle)
        => default;

    internal static int Xstrncmpz(string S, string T, nuint Len)
        => default;

    internal static void Xsetenv(string Name, string Value, int Overwrite)
    {
    }

    internal static int Xopen(string Path, int Oflag, params object[] VarArgs)
        => default;

    internal static int HandleNonblock(int Fd, short PollEvents, int Err)
        => default;

    internal static nint Xread(int Fd, nint Buf, nuint Len)
        => default;

    internal static nint Xwrite(int Fd, nint Buf, nuint Len)
        => default;

    internal static nint Xpread(int Fd, nint Buf, nuint Len, long Offset)
        => default;

    internal static nint ReadInFull(int Fd, nint Buf, nuint Count)
        => default;

    internal static nint WriteInFull(int Fd, nint Buf, nuint Count)
        => default;

    internal static nint PreadInFull(int Fd, nint Buf, nuint Count, long Offset)
        => default;

    internal static int Xdup(int Fd)
        => default;

    internal static void WarnOnInaccessible(string Path)
    {
    }

    internal static int WarnOnFopenErrors(string Path)
        => default;

    internal static int Xmkstemp(string FilenameTemplate)
        => default;

    internal const int TMP_MAX = 16384;
    internal static int GitMkdstempsMode(string Pattern, int SuffixLen, int Mode, bool Dir)
        => default;

    internal static int GitMkstempsMode(string Pattern, int SuffixLen, int Mode)
        => default;

    internal static int GitMkstempMode(string Pattern, int Mode)
        => default;

    internal static int XmkstempMode(string FilenameTemplate, int Mode)
        => default;

    internal static int FsyncLoop(int Fd)
        => default;

    internal static int GitFsync(int Fd, FsyncAction Action)
        => default;

    internal static int WarnIfUnremovable(string Op, string File, int Rc)
        => default;

    internal static int UnlinkOrMsg(string File, nint Err)
        => default;

    internal static int UnlinkOrWarn(string File)
        => default;

    internal static int RmdirOrWarn(string File)
        => default;

    internal static int AccessErrorIsOk(int Err, uint Flag)
        => default;

    internal static int AccessOrWarn(string Path, int Mode, uint Flag)
        => default;

    internal static int AccessOrDie(string Path, int Mode, uint Flag)
        => default;

    internal static int Xsnprintf(string Dst, nuint Max, string Fmt, params object[] VarArgs)
        => default;

    internal static void WriteFileBuf(string Path, string Buf, nuint Len)
    {
    }

    internal static void WriteFile(string Path, string Fmt, params object[] VarArgs)
    {
    }

    internal static void SleepMillisec(int Millisec)
    {
    }

    internal static int Xgethostname(string Buf, nuint Len)
        => default;

    internal static int IsMissingFile(string Filename)
        => default;

    internal static int IsEmptyOrMissingFile(string Filename)
        => default;

    internal static int OpenNofollow(string Path, int Flags)
        => default;

    internal static int CsprngBytes(nint Buf, nuint Len, MAYBEUNUSED unsigned Flags)
        => default;

    internal static uint GitRand(uint Flags)
        => default;

    internal static void MmapLimitCheck(nuint Length)
    {
    }

}
