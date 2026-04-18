namespace PrTask.Git.Generated;

internal static partial class ObjectFile
{
    internal const int MAX_HEADER_LEN = 32;
    internal static int GetConvFlags(uint Flags)
        => default;

    internal static int FreshenFile(string Fn)
        => default;

    internal static int CheckAndFreshenFile(string Fn, int Freshen)
        => default;

    internal enum UnpackLooseHeaderResult
    {
        ULHR_OK,
        ULHR_BAD,
        ULHR_TOO_LONG,
    }
    internal static int ParseLooseHeader(string Hdr, nint Oi)
        => default;

    internal const int CHECK_COLLISION_DEST_VANISHED = -2;
    internal static int CheckCollision(string Source, string Dest)
        => default;

    internal static void PrepareLooseObjectTransaction(nint Base)
    {
    }

    internal static void FlushLooseObjectTransaction(nint Transaction)
    {
    }

    internal static int DirectorySize(string Filename)
        => default;

    internal static void FlushPackfileTransaction(nint Transaction)
    {
    }

    internal static int ReadPackHeader(int Fd, nint Header)
        => default;

    internal static void OdbSourceLooseClearCache(nint Loose)
    {
    }

    internal static void OdbSourceLooseReprepare(nint Source)
    {
    }

    internal static void OdbTransactionFilesCommit(nint Base)
    {
    }

    internal static void OdbSourceLooseFree(nint Loose)
    {
    }

    internal static nint ReadIstreamLoose(nint St, string Buf, nuint Sz)
        => default;

    internal static int CloseIstreamLoose(nint St)
        => default;

}
