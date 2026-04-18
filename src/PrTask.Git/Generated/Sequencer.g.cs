namespace PrTask.Git.Generated;

internal static partial class Sequencer
{
    internal const string GIT_REFLOG_ACTION = "GIT_REFLOG_ACTION";
    internal static ReplayCtx ReplayCtxNew()
        => default;

    internal static void SequencerInitConfig(nint Opts)
    {
    }

    internal static int IsRebaseI(nint Opts)
        => default;

    internal static void ReplayCtxRelease(nint Ctx)
    {
    }

    internal static void ReplayOptsRelease(nint Opts)
    {
    }

    internal static int SequencerRemoveState(nint Opts)
        => default;

    internal static int GetMessage(nint Commit, nint Out)
        => default;

    internal static void FreeMessage(nint Commit, nint Msg)
    {
    }

    internal static int ErrorDirtyIndex(nint Repo, nint Opts)
        => default;

    internal static void UpdateAbortSafetyFile()
    {
    }

    internal static int IsIndexUnchanged(nint R)
        => default;

    internal static int WriteAuthorScript(string Message)
        => default;

    internal static int ParseKeyValueSquoted(string Buf, nint List)
        => default;

    internal static int ReadEnvScript(nint Env)
        => default;

    internal static int RunCommandSilentOnSuccess(nint Cmd)
        => default;

    internal static int RestIsEmpty(nint Sb, int Start)
        => default;

    internal static int PipeFromStrbuf(int HookStdinFd, nint PpCb, nint UNUSED)
        => default;

    internal static int ParseHead(nint R, nint Head)
        => default;

    internal static int WriteRebaseHead(nint Oid)
        => default;

    internal static int IsOriginalCommitEmpty(nint Commit)
        => default;

    internal static byte CommandToChar(TodoCommand Command)
        => default;

    internal static int IsNoop(TodoCommand Command)
        => default;

    internal static int IsFixup(TodoCommand Command)
        => default;

    internal static int IsPickOrSimilar(TodoCommand Command)
        => default;

    internal enum TodoItemFlags
    {
        TODO_EDIT_MERGE_MSG    = (1 << 0),
        TODO_REPLACE_FIXUP_MSG = (1 << 1),
        TODO_EDIT_FIXUP_MSG    = (1 << 2),
    }
    internal static int IsFixupFlag(TodoCommand Command, uint Flag)
        => default;

    internal static void AddCommentedLines(nint Buf, nint Str, nuint Len)
    {
    }

    internal static int SeenSquash(nint Ctx)
        => default;

    internal static void UpdateCommentBufs(nint Buf1, nint Buf2, int N)
    {
    }

    internal static void UpdateSquashMessageForFixup(nint Msg)
    {
    }

    internal static void FlushRewrittenPending()
    {
    }

    internal static int ShouldEdit(nint Opts)
        => default;

    internal static int PrepareRevs(nint Opts)
        => default;

    internal static void TodoListRelease(nint TodoList)
    {
    }

    internal static int IsCommand(TodoCommand Command, string Bol)
        => default;

    internal static int CheckLabelOrRefArg(TodoCommand Command, string Arg)
        => default;

    internal static int CheckMergeCommitInsn(TodoCommand Command)
        => default;

    internal static int SequencerGetLastCommand(nint UNUSED, nint Action)
        => default;

    internal static int CountCommands(nint TodoList)
        => default;

    internal static int GetItemLineOffset(nint TodoList, int Index)
        => default;

    internal static int GetItemLineLength(nint TodoList, int Index)
        => default;

    internal static nint StrbufReadFileOrWhine(nint Sb, string Path)
        => default;

    internal static int HaveFinishedTheLastPick()
        => default;

    internal static void SequencerPostCommitCleanup(nint R, int Verbose)
    {
    }

    internal static void TodoListWriteTotalNr(nint TodoList)
    {
    }

    internal static void ParseStrategyOpts(nint Opts, string RawOpts)
    {
    }

    internal static void ReadStrategyOpts(nint Opts, nint Buf)
    {
    }

    internal static int ReadTrailers(nint Opts, nint Buf)
        => default;

    internal static int ReadPopulateOpts(nint Opts)
        => default;

    internal static void WriteStrategyOpts(nint Opts)
    {
    }

    internal static int CreateSeqDir(nint R)
        => default;

    internal static int SaveHead(string Head)
        => default;

    internal static int RollbackIsSafe()
        => default;

    internal static int ResetMerge(nint Oid)
        => default;

    internal static int RollbackSinglePick(nint R)
        => default;

    internal static int SkipSinglePick()
        => default;

    internal static int SequencerRollback(nint R, nint Opts)
        => default;

    internal static int SequencerSkip(nint R, nint Opts)
        => default;

    internal static int SaveOpts(nint Opts)
        => default;

    internal static int IntendToAmend()
        => default;

    internal static int DoExec(nint R, string CommandLine, int Quiet)
        => default;

    internal static int SafeAppend(string Filename, string Fmt, params object[] VarArgs)
        => default;

    internal static int DoLabel(nint R, string Name, int Len)
        => default;

    internal static int WriteUpdateRefsState(nint RefsToOids)
        => default;

    internal static int DoUpdateRef(nint R, string Refname)
        => default;

    internal static int DoUpdateRefs(nint R, int Quiet)
        => default;

    internal static int IsFinalFixup(nint TodoList)
        => default;

    internal static TodoCommand PeekCommand(nint TodoList, int Offset)
        => default;

    internal static void CreateAutostash(nint R, string Path)
    {
    }

    internal static void CreateAutostashRef(nint R, string Refname)
    {
    }

    internal static int ApplySaveAutostashOid(string StashOid, int AttemptApply)
        => default;

    internal static int ApplySaveAutostash(string Path, int AttemptApply)
        => default;

    internal static int SaveAutostash(string Path)
        => default;

    internal static int ApplyAutostash(string Path)
        => default;

    internal static int ApplyAutostashOid(string StashOid)
        => default;

    internal static int SaveAutostashRef(nint R, string Refname)
        => default;

    internal static int ApplyAutostashRef(nint R, string Refname)
        => default;

    internal static int StoppedAtHead(nint R)
        => default;

    internal static int ContinueSinglePick(nint R, nint Opts)
        => default;

    internal static int SequencerContinue(nint R, nint Opts)
        => default;

    internal static void AppendSignoff(nint Msgbuf, nuint IgnoreFooter, uint Flag)
    {
    }

    internal static int TodoListAddUpdateRefCommands(nint TodoList)
        => default;

    internal static int SkipFixupish(string Subject, string P)
        => default;

    internal static int TodoListRearrangeSquash(nint TodoList)
        => default;

    internal static int SequencerDetermineWhence(nint R, nint Whence)
        => default;

}
