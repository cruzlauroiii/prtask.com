namespace PrTask.Git.Generated;

internal static partial class Rerere
{
    internal const int RESOLVED = 0;
    internal const int PUNTED = 1;
    internal const int THREE_STAGED = 2;
    internal const int RR_HAS_POSTIMAGE = 1;
    internal const int RR_HAS_PREIMAGE = 2;
    internal static void FreeRerereDirs()
    {
    }

    internal static void FreeRerereId(nint Item)
    {
    }

    internal static void FitVariant(nint RrDir, int Variant)
    {
    }

    internal static void AssignVariant(nint Id)
    {
    }

    internal static int IsRrFile(string Name, string Filename, nint Variant)
        => default;

    internal static void ScanRerereDir(nint RrDir)
    {
    }

    internal static int HasRerereResolution(nint Id)
        => default;

    internal static void ReadRr(nint R, nint Rr)
    {
    }

    internal static int WriteRr(nint Rr, int OutFd)
        => default;

    internal static void FerrWrite(nint P, nuint Count, nint Fp, nint Err)
    {
    }

    internal static void FerrPuts(string S, nint Fp, nint Err)
    {
    }

    internal static void RerereIoPutstr(string Str, nint Io)
    {
    }

    internal static void RerereIoPutmem(string Mem, nuint Sz, nint Io)
    {
    }

    internal static int RerereFileGetline(nint Sb, nint Io)
        => default;

    internal static int IsCmarker(string Buf, int MarkerChar, int MarkerSize)
        => default;

    internal static void RerereStrbufPutconflict(nint Buf, int Ch, nuint Size)
    {
    }

    internal static int HandlePath(nint Hash, nint Io, int MarkerSize)
        => default;

    internal static int CheckOneConflict(nint Istate, int I, nint Type)
        => default;

    internal static int FindConflict(nint R, nint Conflict)
        => default;

    internal static int RerereRemaining(nint R, nint MergeRr)
        => default;

    internal static int Merge(nint Istate, nint Id, string Path)
        => default;

    internal static void UpdatePaths(nint R, nint Update)
    {
    }

    internal static void RemoveVariant(nint Id)
    {
    }

    internal static void GitRerereConfig()
    {
    }

    internal static int IsRerereEnabled()
        => default;

    internal static int SetupRerere(nint R, nint MergeRr, int Flags)
        => default;

    internal static int RepoRerere(nint R, int Flags)
        => default;

    internal static int RerereMemGetline(nint Sb, nint Io)
        => default;

    internal static int RerereForget(nint R, nint Pathspec)
        => default;

    internal static TimestampT RerereCreatedAt(nint Id)
        => default;

    internal static TimestampT RerereLastUsedAt(nint Id)
        => default;

    internal static void UnlinkRrItem(nint Id)
    {
    }

    internal static int IsRrCacheDirname(string Path)
        => default;

    internal static void RerereGc(nint R, nint Rr)
    {
    }

    internal static void RerereClear(nint R, nint MergeRr)
    {
    }

}
