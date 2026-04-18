namespace PrTask.Git.Generated;

internal static partial class Merge
{
    internal const int MERGE_SHOW_DIFFSTAT = 1;
    internal const int MERGE_SHOW_COMPACTSUMMARY = 2;
    internal enum FfType
    {
        FF_NO,
        FF_ALLOW,
        FF_ONLY,
    }
    internal static void AppendStrategy(nint S)
    {
    }

    internal static int SaveState(nint Stash)
        => default;

    internal static void ReadEmpty(nint Oid)
    {
    }

    internal static void ResetHard(nint Oid)
    {
    }

    internal static void FinishUpToDate()
    {
    }

    internal static void SquashMessage(nint Commit, nint Remoteheads)
    {
    }

    internal static void MergeName(string Remote, nint Msg)
    {
    }

    internal static void ParseBranchMergeOptions(string Bmo)
    {
    }

    internal static void WriteTreeTrivial(nint Oid)
    {
    }

    internal static int CountUnmergedEntries()
        => default;

    internal static void AddStrategies(string String, uint Attr)
    {
    }

    internal static void ReadMergeMsg(nint Msg)
    {
    }

    internal static void AbortCommit(nint Remoteheads, string ErrMsg)
    {
    }

    internal static void PrepareToCommit(nint Remoteheads)
    {
    }

    internal static int MergeTrivial(nint Head, nint Remoteheads)
        => default;

    internal static int SuggestConflicts()
        => default;

    internal static int EvaluateResult()
        => default;

    internal static int SetupWithUpstream(string Argv)
        => default;

    internal static void WriteMergeHeads(nint Remoteheads)
    {
    }

    internal static void WriteMergeState(nint Remoteheads)
    {
    }

    internal static int DefaultEditOption()
        => default;

    internal static void PrepareMergeMessage(nint MergeNames, nint MergeMsg)
    {
    }

    internal static void HandleFetchHead(nint Remotes, nint MergeNames)
    {
    }

    internal static int MergingAThrowawayTag(nint Commit)
        => default;

}
