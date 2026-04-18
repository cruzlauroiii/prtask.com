namespace PrTask.Git.Generated;

internal static partial class Repo
{
    internal enum OutputFormat
    {
        FORMAT_TABLE,
        FORMAT_NEWLINE_TERMINATED,
        FORMAT_NUL_TERMINATED,
    }
    internal static int GetLayoutBare(nint UNUSED, nint Buf)
        => default;

    internal static int GetLayoutShallow(nint Repo, nint Buf)
        => default;

    internal static int GetObjectFormat(nint Repo, nint Buf)
        => default;

    internal static int GetReferencesFormat(nint Repo, nint Buf)
        => default;

    internal static int RepoInfoFieldCmp(nint Va, nint Vb)
        => default;

    internal static int PrintKeys(OutputFormat Format)
        => default;

    internal static void StatsTableAddf(nint Table, string Format, params object[] VarArgs)
    {
    }

    internal static nuint GetTotalReferenceCount(nint Stats)
        => default;

    internal static nuint GetTotalObjectValues(nint Values)
        => default;

    internal const int INDEX_WIDTH = 4;
    internal static void StatsTablePrintStructure(nint Table)
    {
    }

    internal static void StatsTableClear(nint Table)
    {
    }

    internal static int CountReferences(nint Ref, nint CbData)
        => default;

    internal static nuint CountTreeEntries(nint Obj)
        => default;

}
