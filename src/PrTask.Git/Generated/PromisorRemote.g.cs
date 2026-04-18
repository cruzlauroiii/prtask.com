namespace PrTask.Git.Generated;

internal static partial class PromisorRemote
{
    internal static void PromisorRemoteInit(nint R)
    {
    }

    internal static void PromisorRemoteClear(nint Config)
    {
    }

    internal static void RepoPromisorRemoteReinit(nint R)
    {
    }

    internal static int RepoHasPromisorRemote(nint R)
        => default;

    internal static int RepoHasAcceptedPromisorRemote(nint R)
        => default;

    internal static int AllowUnsanitized(byte Ch)
        => default;

    internal static int IsKnownField(string Field)
        => default;

    internal static int IsValidField(nint Item, nint CbData)
        => default;

    internal static void PromisorInfoFree(nint P)
    {
    }

    internal static void PromisorInfoListClear(nint List)
    {
    }

    internal enum AcceptPromisor
    {
        ACCEPT_NONE = 0,
        ACCEPT_KNOWN_URL,
        ACCEPT_KNOWN_NAME,
        ACCEPT_ALL,
    }
    internal static int SkipFieldNamePrefix(string Elem, string FieldName, string Value)
        => default;

    internal static bool ValidFilter(string Filter, string RemoteName)
        => default;

    internal static bool ValidToken(string Token, string RemoteName)
        => default;

    internal static void StoreInfoFree(nint S)
    {
    }

    internal static void PromisorRemoteReply(string Info, string AcceptedOut)
    {
    }

    internal static void MarkPromisorRemotesAsAccepted(nint R, string Remotes)
    {
    }

}
