namespace PrTask.Git.Generated;

internal static partial class Blame
{
    internal const int DEBUG_BLAME = 0;
    internal static void CommitInfoDestroy(nint Ci)
    {
    }

    internal static void GetCommitInfo(nint Commit, nint Ret)
    {
    }

    internal static void WriteFilenameInfo(nint Suspect)
    {
    }

    internal static int EmitOneSuspectDetail(nint Suspect, int Repeat)
        => default;

    internal static void FoundGuiltyEntry(nint Ent, nint Data)
    {
    }

    internal static void EmitPorcelainDetails(nint Suspect, int Repeat)
    {
    }

    internal static void EmitPorcelainPerLineDetails(nint Ent)
    {
    }

    internal static void ParseColorFields(string S)
    {
    }

    internal static void SetupDefaultColorByAge()
    {
    }

    internal static void DetermineLineHeat(nint Ci, string DestColor)
    {
    }

    internal static void Output(nint Sb, int Option)
    {
    }

    internal static int ReadAncestry(string GraftFile)
        => default;

    internal static int UpdateAutoAbbrev(int AutoAbbrev, nint Suspect)
        => default;

    internal static void FindAlignment(nint Sb, nint Option)
    {
    }

    internal static void SanityCheckOnFail(nint Sb, int Baa)
    {
    }

    internal static uint ParseScore(string Arg)
        => default;

    internal static int BlameCopyCallback(nint Option, string Arg, int Unset)
        => default;

    internal static int BlameMoveCallback(nint Option, string Arg, int Unset)
        => default;

    internal static int IsARev(string Name)
        => default;

    internal static int PeelToCommitOid(nint OidRet, nint Cbdata)
        => default;

}
