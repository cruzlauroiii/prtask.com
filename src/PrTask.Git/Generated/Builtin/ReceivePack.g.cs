namespace PrTask.Git.Generated;

internal static partial class ReceivePack
{
    internal enum DenyAction
    {
        DENY_UNCONFIGURED,
        DENY_IGNORE,
        DENY_WARN,
        DENY_REFUSE,
        DENY_UPDATE_INSTEAD,
    }
    internal static DenyAction ParseDenyAction(string Var, string Value)
        => default;

    internal static void ShowRef(string Path, nint Oid)
    {
    }

    internal static int ShowRefCb(nint Ref, nint Data)
        => default;

    internal static void WriteHeadInfo()
    {
    }

    internal const int RUN_PROC_RECEIVE_SCHEDULED = 1;
    internal const int RUN_PROC_RECEIVE_RETURNED = 2;
    internal static void ProcReceiveRefAppend(string Prefix)
    {
    }

    internal static int ProcReceiveRefMatches(nint Cmd)
        => default;

    internal static void ReportMessage(string Prefix, string Err, VaList Params)
    {
    }

    internal static void RpWarning(string Err, params object[] VarArgs)
    {
    }

    internal static void RpError(string Err, params object[] VarArgs)
    {
    }

    internal static int CopyToSideband(int In, Int out UNUSED, nint UNUSED)
        => default;

    internal static void PrepareSidebandAsync(nint SidebandAsync, nint SavedStderr, nint Started)
    {
    }

    internal static void FinishSidebandAsync(nint SidebandAsync, int SavedStderr, int Started)
    {
    }

    internal static int ConstantMemequal(string A, string B, nuint N)
        => default;

    internal static int CheckCertPushOptions(nint PushOptions)
        => default;

    internal static void PreparePushCertSha1(nint Opt)
    {
    }

    internal static int FeedReceiveHookCb(int HookStdinFd, nint UNUSED, nint PpTaskCb)
        => default;

    internal static void ReceiveHookFeedStateFree(nint Data)
    {
    }

    internal static int RunUpdateHook(nint Cmd)
        => default;

    internal static void RefuseUnconfiguredDeny()
    {
    }

    internal static void RefuseUnconfiguredDenyDeleteCurrent()
    {
    }

    internal static int UpdateShallowRef(nint Cmd, nint Si)
        => default;

    internal static int HeadHasHistory()
        => default;

    internal static void RunUpdatePostHook(nint Commands)
    {
    }

    internal static void CheckAliasedUpdate(nint Cmd, nint List)
    {
    }

    internal static void CheckAliasedUpdates(nint Commands)
    {
    }

    internal static void RejectUpdatesToHidden(nint Commands)
    {
    }

    internal static int ShouldProcessCmd(nint Cmd)
        => default;

    internal enum ProcessingPhase
    {
        PHASE_DELETIONS,
        PHASE_OTHERS,
    }
    internal static void FreeCommands(nint Commands)
    {
    }

    internal static void PushHeaderArg(nint Args, nint Hdr)
    {
    }

    internal static void PrepareShallowUpdate(nint Si)
    {
    }

    internal static void Report(nint Commands, string UnpackStatus)
    {
    }

    internal static void ReportV2(nint Commands, string UnpackStatus)
    {
    }

    internal static int DeleteOnly(nint Commands)
        => default;

}
