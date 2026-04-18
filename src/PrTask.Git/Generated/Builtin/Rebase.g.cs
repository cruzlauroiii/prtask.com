namespace PrTask.Git.Generated;

internal static partial class Rebase
{
    internal enum RebaseType
    {
        REBASE_UNSPECIFIED = -1,
        REBASE_APPLY,
        REBASE_MERGE,
    }
    internal enum EmptyType
    {
        EMPTY_UNSPECIFIED = -1,
        EMPTY_DROP,
        EMPTY_KEEP,
        EMPTY_STOP,
    }
    internal enum Action
    {
        ACTION_NONE = 0,
        ACTION_CONTINUE,
        ACTION_SKIP,
        ACTION_ABORT,
        ACTION_QUIT,
        ACTION_EDIT_TODO,
        ACTION_SHOW_CURRENT_PATCH,
    }
    internal static void RebaseOptionsRelease(nint Opts)
    {
    }

    internal static ReplayOpts GetReplayOpts(nint Opts)
        => default;

    internal static int EditTodoFile(uint Flags, nint Opts)
        => default;

    internal static int DoInteractiveRebase(nint Opts, uint Flags)
        => default;

    internal static int RunSequencerRebase(nint Opts)
        => default;

    internal static int IsMerge(nint Opts)
        => default;

    internal static void ImplyMerge(nint Opts, string Option)
    {
    }

    internal static int ReadBasicState(nint Opts)
        => default;

    internal static int RebaseWriteBasicState(nint Opts)
        => default;

    internal static int CleanupAutostash(nint Opts)
        => default;

    internal static int FinishRebase(nint Opts)
        => default;

    internal static int MoveToOriginalBranch(nint Opts)
        => default;

    internal static int RunAm(nint Opts)
        => default;

    internal static int RunSpecificRebase(nint Opts)
        => default;

    internal static void ParseRebaseMergesValue(nint Options, string Value)
    {
    }

    internal static int CheckoutUpToDate(nint Options)
        => default;

    internal static int IsLinearHistory(nint From, nint To)
        => default;

    internal static int ParseOptAm(nint Opt, string Arg, int Unset)
        => default;

    internal static int ParseOptMerge(nint Opt, string Arg, int Unset)
        => default;

    internal static EmptyType ParseEmptyValue(string Value)
        => default;

    internal static int ParseOptEmpty(nint Opt, string Arg, int Unset)
        => default;

    internal static int ParseOptRebaseMerges(nint Opt, string Arg, int Unset)
        => default;

    internal static Void NORETURN ErrorOnMissingDefaultUpstream()
        => default;

    internal static int CheckExecCmd(string Cmd)
        => default;

}
