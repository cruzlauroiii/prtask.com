namespace PrTask.Git.Generated;

internal static partial class Am
{
    internal static int Linelen(string Msg)
        => default;

    internal static int StrIsspace(string Str)
        => default;

    internal enum PatchFormat
    {
        PATCH_FORMAT_UNKNOWN = 0,
        PATCH_FORMAT_MBOX,
        PATCH_FORMAT_STGIT,
        PATCH_FORMAT_STGIT_SERIES,
        PATCH_FORMAT_HG,
        PATCH_FORMAT_MBOXRD,
    }
    internal enum KeepType
    {
        KEEP_FALSE = 0,
        KEEP_TRUE,
        KEEP_NON_PATCH,
    }
    internal enum ScissorsType
    {
        SCISSORS_UNSET = -1,
        SCISSORS_FALSE = 0,
        SCISSORS_TRUE,
    }
    internal enum SignoffType
    {
        SIGNOFF_FALSE = 0,
        SIGNOFF_TRUE = 1,
        SIGNOFF_EXPLICIT,
    }
    internal enum ResumeType
    {
        RESUME_FALSE = 0,
        RESUME_APPLY,
        RESUME_RESOLVED,
        RESUME_SKIP,
        RESUME_ABORT,
        RESUME_QUIT,
        RESUME_SHOW_PATCH_RAW,
        RESUME_SHOW_PATCH_DIFF,
        RESUME_ALLOW_EMPTY,
    }
    internal enum EmptyAction
    {
        STOP_ON_EMPTY_COMMIT = 0,
        DROP_EMPTY_COMMIT,
        KEEP_EMPTY_COMMIT,
    }
    internal static void AmStateInit(nint State)
    {
    }

    internal static void AmStateRelease(nint State)
    {
    }

    internal static void Say(nint State, nint Fp, string Fmt, params object[] VarArgs)
    {
    }

    internal static int AmInProgress(nint State)
        => default;

    internal static int ReadAmAuthorScript(nint State)
        => default;

    internal static void WriteAuthorScript(nint State)
    {
    }

    internal static int ReadCommitMsg(nint State)
        => default;

    internal static void WriteCommitMsg(nint State)
    {
    }

    internal static void AmLoad(nint State)
    {
    }

    internal static void AmDestroy(nint State)
    {
    }

    internal static int RunApplypatchMsgHook(nint State)
        => default;

    internal static int RunPostRewriteHook(nint State)
        => default;

    internal static int CopyNotesForRebase(nint State)
        => default;

    internal static int IsMail(nint Fp)
        => default;

    internal static int DetectPatchFormat(string Paths)
        => default;

    internal static int StgitPatchToMail(nint Out, nint In, Int keepCr UNUSED)
        => default;

    internal static int HgPatchToMail(nint Out, nint In, Int keepCr UNUSED)
        => default;

    internal static void AmNext(nint State)
    {
    }

    internal static Void NORETURN DieUserResolve(nint State)
        => default;

    internal static void AmAppendSignoff(nint State)
    {
    }

    internal static int ParseMail(nint State, string Mail)
        => default;

    internal static int GetMailCommitOid(nint CommitId, string Mail)
        => default;

    internal static void GetCommitInfo(nint State, nint Commit)
    {
    }

    internal static void WriteCommitPatch(nint State, nint Commit)
    {
    }

    internal static void WriteIndexPatch(nint State)
    {
    }

    internal static int ParseMailRebase(nint State, string Mail)
        => default;

    internal static int RunApply(nint State, string IndexFile)
        => default;

    internal static int BuildFakeAncestor(nint State, string IndexFile)
        => default;

    internal static int FallBackThreeway(nint State, string IndexPath)
        => default;

    internal static void DoCommit(nint State)
    {
    }

    internal static void ValidateResumeState(nint State)
    {
    }

    internal static int DoInteractive(nint State)
        => default;

    internal static void AmRun(nint State, int Resume)
    {
    }

    internal static void AmResolve(nint State, int AllowEmpty)
    {
    }

    internal static int FastForwardTo(nint Head, nint Remote, int Reset)
        => default;

    internal static int MergeTree(nint Tree)
        => default;

    internal static int CleanIndex(nint Head, nint Remote)
        => default;

    internal static void AmRerereClear()
    {
    }

    internal static void AmSkip(nint State)
    {
    }

    internal static int SafeToAbort(nint State)
        => default;

    internal static void AmAbort(nint State)
    {
    }

    internal static int ShowPatch(nint State, ResumeType ResumeMode)
        => default;

    internal static int ParseOptPatchformat(nint Opt, string Arg, int Unset)
        => default;

    internal static int ParseOptShowCurrentPatch(nint Opt, string Arg, int Unset)
        => default;

}
