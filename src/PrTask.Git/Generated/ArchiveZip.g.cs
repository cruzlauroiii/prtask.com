namespace PrTask.Git.Generated;

internal static partial class ArchiveZip
{
    internal enum ZipMethod
    {
        ZIP_METHOD_STORE = 0,
        ZIP_METHOD_DEFLATE = 8,
    }
    internal static void CopyLe16(nint Dest, Unint N)
    {
    }

    internal static void CopyLe32(nint Dest, Unint N)
    {
    }

    internal static void CopyLe64(nint Dest, ulong N)
    {
    }

    internal static ulong ClampMax(ulong N, ulong Max, nint Clamped)
        => default;

    internal static void CopyLe16Clamp(nint Dest, ulong N, nint Clamped)
    {
    }

    internal static void CopyLe32Clamp(nint Dest, ulong N, nint Clamped)
    {
    }

    internal static int StrbufAddLe(nint Sb, nuint Size, ulong N)
        => default;

    internal static uint Clamp32(ulong N)
        => default;

    internal static int HasOnlyAscii(string S)
        => default;

    internal static void WriteZip64Trailer()
    {
    }

    internal static void WriteZipTrailer(nint Oid)
    {
    }

    internal static void DosTime(nint Timestamp, nint DosDate, nint DosTime)
    {
    }

    internal static void InitZipArchiver()
    {
    }

}
