namespace PrTask.Git.Generated;

internal static partial class Midx
{
    internal static void GetMidxFilename(nint Source, nint Out)
    {
    }

    internal static void GetMidxChainDirname(nint Source, nint Buf)
    {
    }

    internal static void GetMidxChainFilename(nint Source, nint Buf)
    {
    }

    internal static void CloseMidx(nint M)
    {
    }

    internal static uint MidxForObject(nint M, uint Pos)
        => default;

    internal static int MidxHasOid(nint M, nint Oid)
        => default;

    internal static long NthMidxedOffset(nint M, uint Pos)
        => default;

    internal static uint NthMidxedPackIntId(nint M, uint Pos)
        => default;

    internal static int MidxContainsPack(nint M, string IdxOrPackName)
        => default;

    internal static int MidxPreferredPack(nint M, nint PackIntId)
        => default;

    internal static int PrepareMultiPackIndexOne(nint Source)
        => default;

    internal static int MidxChecksumValid(nint M)
        => default;

    internal static void ClearMidxFile(nint R)
    {
    }

    internal static void MidxReport(string Fmt, params object[] VarArgs)
    {
    }

    internal static int ComparePairPosVsId(nint A, nint B)
        => default;

    internal static int VerifyMidxFile(nint Source, uint Flags)
        => default;

}
