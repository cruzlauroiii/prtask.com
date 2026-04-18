namespace PrTask.Git.Generated;

internal static partial class Reset
{
    internal enum ResetType
    {
        static const char *reset_type_names[] = {,
        N_("mixed"), N_("soft"), N_("hard"), N_("merge"), N_("keep"), NULL,
    }
    internal static int IsMerge()
        => default;

    internal static int ResetIndex(string Ref, nint Oid, int ResetType, int Quiet)
        => default;

    internal static void PrintNewHeadLine(nint Commit)
    {
    }

    internal static void DieIfUnmergedCache(int ResetType)
    {
    }

    internal static int ResetRefs(string Rev, nint Oid)
        => default;

}
