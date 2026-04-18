namespace PrTask.Git.Generated;

internal static partial class Blame
{
    internal static void SetBlameSuspects(nint Commit, nint Origin)
    {
    }

    internal static void BlameOriginDecref(nint O)
    {
    }

    internal static void FreeFingerprint(nint F)
    {
    }

    internal static int FingerprintSimilarity(nint A, nint B)
        => default;

    internal static void FingerprintSubtract(nint A, nint B)
    {
    }

    internal const int CERTAIN_NOTHING_MATCHES = -2;
    internal const int CERTAINTY_NOT_CALCULATED = -1;
    internal static void FillOriginFingerprints(nint O)
    {
    }

    internal static void DropOriginFingerprints(nint O)
    {
    }

    internal static void DropOriginBlob(nint O)
    {
    }

    internal static void BlameSortFinal(nint Sb)
    {
    }

    internal static void SanityCheckRefcnt(nint Sb)
    {
    }

    internal static void BlameCoalesce(nint Sb)
    {
    }

    internal static void DecrefSplit(nint Split)
    {
    }

    internal const int FINGERPRINT_FILE_THRESHOLD = 10;
    internal static uint BlameEntryScore(nint Sb, nint E)
        => default;

    internal static int NumScapegoats(nint Revs, nint Commit, int Reverse)
        => default;

    internal static void DistributeBlame(nint Sb, nint Blamed)
    {
    }

    internal const int MAXSG = 16;
    internal static void PassBlame(nint Sb, nint Origin, int Opt)
    {
    }

    internal static void AssignBlame(nint Sb, int Opt)
    {
    }

    internal static int PrepareLines(nint Sb)
        => default;

    internal static void InitScoreboard(nint Sb)
    {
    }

    internal static void SetupBlameBloomData(nint Sb)
    {
    }

    internal static void CleanupScoreboard(nint Sb)
    {
    }

}
