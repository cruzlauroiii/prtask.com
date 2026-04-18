namespace PrTask.Git.Generated;

internal static partial class WriteOrDie
{
    internal static void MaybeFlushOrDie(nint F, string Desc)
    {
    }

    internal static void FprintfOrDie(nint F, string Fmt, params object[] VarArgs)
    {
    }

    internal static int MaybeFsync(int Fd)
        => default;

    internal static void FsyncOrDie(int Fd, string Msg)
    {
    }

    internal static int FsyncComponent(FsyncComponent Component, int Fd)
        => default;

    internal static void FsyncComponentOrDie(FsyncComponent Component, int Fd, string Msg)
    {
    }

    internal static void WriteOrDie(int Fd, nint Buf, nuint Count)
    {
    }

    internal static void FwriteOrDie(nint F, nint Buf, nuint Count)
    {
    }

    internal static void FflushOrDie(nint F)
    {
    }

}
