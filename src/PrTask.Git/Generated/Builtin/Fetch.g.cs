namespace PrTask.Git.Generated;

internal static partial class Fetch
{
    internal enum DisplayFormat
    {
        DISPLAY_FORMAT_FULL,
        DISPLAY_FORMAT_COMPACT,
        DISPLAY_FORMAT_PORCELAIN,
    }
    internal const int PRUNE_BY_DEFAULT = 0 /* do we prune by default? */;
    internal const int PRUNE_TAGS_BY_DEFAULT = 0 /* do we prune tags by default? */;
    internal static int ParseRefmapArg(nint Opt, string Arg, int Unset)
        => default;

    internal static void UnlockPack(Unint Flags)
    {
    }

    internal static void UnlockPackAtexit()
    {
    }

    internal static void UnlockPackOnSignal(int Signo)
    {
    }

    internal static void CreateFetchOidset(nint Head, nint Out)
    {
    }

    internal static int AddOneRefname(nint Ref, nint Cbdata)
        => default;

    internal static void RefnameHashInit(nint Map)
    {
    }

    internal static int RefnameHashExists(nint Map, string Refname)
        => default;

    internal static void ClearItem(nint Item)
    {
    }

    internal static void FilterPrefetchRefspec(nint Rs)
    {
    }

    internal static int RefcolWidth(nint RefMap, int CompactFormat)
        => default;

    internal static void DisplayStateRelease(nint DisplayState)
    {
    }

    internal static void RefUpdateDisplayInfoSetFailed(nint Info)
    {
    }

    internal static void RefUpdateDisplayInfoFree(nint Info)
    {
    }

    internal static int OpenFetchHead(nint FetchHead)
        => default;

    internal static void CommitFetchHead(nint FetchHead)
    {
    }

    internal static void CloseFetchHead(nint FetchHead)
    {
    }

    internal static int CheckExistAndConnected(nint RefMap)
        => default;

    internal static void CheckNotCurrentBranch(nint RefMap)
    {
    }

    internal static int TruncateFetchHead()
        => default;

    internal static void SetOption(nint Transport, string Name, string Value)
    {
    }

    internal static int AddOid(nint Ref, nint CbData)
        => default;

    internal static void AddNegotiationTips(nint SmartOptions)
    {
    }

    internal static void SetHeadAdviceMsg(string Remote, string HeadName)
    {
    }

    internal static int SetHead(nint RemoteRefs, nint Remote)
        => default;

    internal static int GetOneRemoteForFetch(nint Remote, nint Priv)
        => default;

    internal static int AddRemoteOrGroup(string Name, nint List)
        => default;

}
