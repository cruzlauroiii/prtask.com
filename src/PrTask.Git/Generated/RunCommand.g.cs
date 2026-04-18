namespace PrTask.Git.Generated;

internal static partial class RunCommand
{
    internal static void ChildProcessInit(nint Child)
    {
    }

    internal static void ChildProcessClear(nint Child)
    {
    }

    internal static void CleanupChildren(int Sig, int InSignal)
    {
    }

    internal static void CleanupChildrenOnSignal(int Sig)
    {
    }

    internal static void CleanupChildrenOnExit()
    {
    }

    internal static void MarkChildForCleanup(int Pid, nint Process)
    {
    }

    internal static void ClearChildForCleanup(int Pid)
    {
    }

    internal static void ClosePair(nint Fd)
    {
    }

    internal static int IsExecutable(string Name)
        => default;

    internal static int ExistsInPATH(string Command)
        => default;

    internal static int SaneExecvp(string File, string Argv)
        => default;

    internal enum ChildErrcode
    {
        CHILD_ERR_CHDIR,
        CHILD_ERR_DUP2,
        CHILD_ERR_CLOSE,
        CHILD_ERR_SIGPROCMASK,
        CHILD_ERR_SILENT,
        CHILD_ERR_ERRNO,
    }
    internal static void ChildDie(ChildErrcode Err)
    {
    }

    internal static void ChildDup2(int Fd, int To)
    {
    }

    internal static void ChildClose(int Fd)
    {
    }

    internal static void ChildClosePair(nint Fd)
    {
    }

    internal static void ChildErrorFn(nint UNUSED, VaList params UNUSED)
    {
    }

    internal static void ChildWarnFn(nint UNUSED, VaList params UNUSED)
    {
    }

    internal static Void NORETURN ChildDieFn(nint UNUSED, VaList params UNUSED)
        => default;

    internal static void ChildErrSpew(nint Cmd, nint Cerr)
    {
    }

    internal static int PrepareCmd(nint Out, nint Cmd)
        => default;

    internal static void AtforkPrepare(nint As)
    {
    }

    internal static void AtforkParent(nint As)
    {
    }

    internal static void SetCloexec(int Fd)
    {
    }

    internal static int WaitOrWhine(int Pid, string Argv0, int InSignal)
        => default;

    internal static void TraceAddEnv(nint Dst, string Deltaenv)
    {
    }

    internal static void TraceRunCommand(nint Cp)
    {
    }

    internal static int StartCommand(nint Cmd)
        => default;

    internal static int FinishCommand(nint Cmd)
        => default;

    internal static int FinishCommandInSignal(nint Cmd)
        => default;

    internal static int RunCommand(nint Cmd)
        => default;

    internal static NORETURN void DieAsync(string Err, VaList Params)
        => default;

    internal static int AsyncDieIsRecursing()
        => default;

    internal static int InAsync()
        => default;

    internal static Void NORETURN AsyncExit(int Code)
        => default;

    internal static void GitAtexitDispatch()
    {
    }

    internal static void GitAtexitClear()
    {
    }

    internal static int InAsync()
        => default;

    internal static Void NORETURN AsyncExit(int Code)
        => default;

    internal static void CheckPipe(int Err)
    {
    }

    internal static int StartAsync(nint Async)
        => default;

    internal static int FinishAsync(nint Async)
        => default;

    internal static int AsyncWithFork()
        => default;

    internal static int PumpIoRound(nint Slots, int Nr, nint Pfd)
        => default;

    internal static int PumpIo(nint Slots, int Nr)
        => default;

    internal enum ChildState
    {
        GIT_CP_FREE,
        GIT_CP_WORKING,
        GIT_CP_WAIT_CLEANUP,
    }
    internal static int ChildIsWorking(nint PpChild)
        => default;

    internal static int ChildIsReadyForCleanup(nint PpChild)
        => default;

    internal static int ChildIsReceivingInput(nint PpChild)
        => default;

    internal static int ChildIsSendingOutput(nint PpChild)
        => default;

    internal static void HandleChildrenOnSignal(int Signo)
    {
    }

    internal static void PpOutput(nint Pp)
    {
    }

    internal static void RunProcessesParallel(nint Opts)
    {
    }

    internal static int RunAutoMaintenance(nint R, int Quiet)
        => default;

    internal static void SanitizeRepoEnv(nint Env)
    {
    }

    internal static void PrepareOtherRepoEnv(nint Env, string NewGitDir)
    {
    }

}
