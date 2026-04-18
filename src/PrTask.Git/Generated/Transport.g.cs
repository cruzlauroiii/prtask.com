namespace PrTask.Git.Generated;

internal static partial class Transport
{
    internal enum ColorTransport
    {
        TRANSPORT_COLOR_RESET = 0,
        TRANSPORT_COLOR_REJECTED = 1,
    }
    internal static int TransportColorConfig()
        => default;

    internal static void GetRefsFromBundleInner(nint Transport)
    {
    }

    internal static int CloseBundle(nint Transport)
        => default;

    internal static int ConnectSetup(nint Transport, int ForPush)
        => default;

    internal static void DieIfServerOptions(nint Transport)
    {
    }

    internal static int GetBundleUri(nint Transport)
        => default;

    internal static int PushHadErrors(nint Ref)
        => default;

    internal static int TransportRefsPushed(nint Ref)
        => default;

    internal static void TransportUpdateTrackingRef(nint Remote, nint Ref, int Verbose)
    {
    }

    internal static int MeasureAbbrev(nint Oid, int Sofar)
        => default;

    internal static int TransportSummaryWidth(nint Refs)
        => default;

    internal static int GitTransportPush(nint Transport, nint RemoteRefs, int Flags)
        => default;

    internal static int DisconnectGit(nint Transport)
        => default;

    internal static int IsFile(string Url)
        => default;

    internal static int ExternalSpecificationLen(string Url)
        => default;

    internal enum ProtocolAllowConfig
    {
        PROTOCOL_ALLOW_NEVER = 0,
        PROTOCOL_ALLOW_USER_ONLY,
        PROTOCOL_ALLOW_ALWAYS,
    }
    internal static ProtocolAllowConfig GetProtocolConfig(string Type)
        => default;

    internal static int IsTransportAllowed(string Type, int FromUser)
        => default;

    internal static void TransportCheckAllowed(string Type)
    {
    }

    internal static void DieWithUnpushedSubmodules(nint NeedsPushing)
    {
    }

    internal static int PrePushHookFeedStdin(int HookStdinFd, nint UNUSED, nint PpTaskCb)
        => default;

    internal static void PrePushHookDataFree(nint Data)
    {
    }

    internal static void TransportLsRefsOptionsRelease(nint Opts)
    {
    }

    internal static int TransportFetchRefs(nint Transport, nint Refs)
        => default;

    internal static int TransportGetRemoteBundleUri(nint Transport)
        => default;

    internal static void TransportUnlockPack(nint Transport, Unint Flags)
    {
    }

    internal static int TransportDisconnect(nint Transport)
        => default;

}
