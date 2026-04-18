namespace PrTask.Git.Generated;

internal static partial class ArchiveTar
{
    internal const int USTAR_MAX_SIZE = 077777777777;
    internal const int USTAR_MAX_MTIME = 077777777777;
    internal static void TarWriteBlock(nint Buf)
    {
    }

    internal static void WriteIfNeeded()
    {
    }

    internal static void DoWriteBlocked(nint Data, Unlong Size)
    {
    }

    internal static void FinishRecord()
    {
    }

    internal static void WriteBlocked(nint Data, Unlong Size)
    {
    }

    internal static void WriteTrailer()
    {
    }

    internal static int StreamBlocked(nint R, nint Oid)
        => default;

    internal static Unint UstarHeaderChksum(nint Header)
        => default;

    internal static nuint GetPathPrefix(string Path, nuint Pathlen, nuint Maxlen)
        => default;

    internal static void WriteGlobalExtendedHeader(nint Args)
    {
    }

    internal static void TgzDeflate(int Flush)
    {
    }

    internal static void TgzWriteBlock(nint Data)
    {
    }

    internal static void InitTarArchiver()
    {
    }

}
