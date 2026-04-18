namespace PrTask.Git.Generated;

internal static partial class ServerInfo
{
    internal static void UicMarkStale(nint Uic)
    {
    }

    internal static int UicIsStale(nint Uic)
        => default;

    internal static int UicPrintf(nint Uic, string Fmt, params object[] VarArgs)
        => default;

    internal static int AddInfoRef(nint Ref, nint CbData)
        => default;

    internal static int GenerateInfoRefs(nint Uic)
        => default;

    internal static int UpdateInfoRefs(nint R, int Force)
        => default;

    internal static int ParsePackDef(string Packname, int OldCnt)
        => default;

    internal static int ReadPackInfoFile(string Infofile)
        => default;

    internal static int CompareInfo(nint A, nint B)
        => default;

    internal static void InitPackInfo(nint R, string Infofile, int Force)
    {
    }

    internal static void FreePackInfo()
    {
    }

    internal static int WritePackInfoFile(nint Uic)
        => default;

    internal static int UpdateInfoPacks(nint R, int Force)
        => default;

    internal static int UpdateServerInfo(nint R, int Force)
        => default;

}
