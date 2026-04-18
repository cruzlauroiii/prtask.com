namespace PrTask.Git.Generated;

internal static partial class Remote
{
    internal static int FetchRemote(string Name)
        => default;

    internal const int MIRROR_NONE = 0;
    internal const int MIRROR_FETCH = 1;
    internal const int MIRROR_PUSH = 2;
    internal static int ParseMirrorOpt(nint Opt, string Arg, int Not)
        => default;

    internal static int CheckRemoteCollision(nint Remote, nint Data)
        => default;

    internal static void ReadBranches()
    {
    }

    internal static int GetRefStates(nint RemoteRefs, nint States)
        => default;

    internal static int GetPushRefStatesNoquery(nint States)
        => default;

    internal static int GetHeadNames(nint RemoteRefs, nint States)
        => default;

    internal static int AddKnownRemote(nint Remote, nint CbData)
        => default;

    internal static int AddBranchForRemoval(nint Ref, nint CbData)
        => default;

    internal static int RenameOneRef(nint Ref, nint CbData)
        => default;

    internal static int MigrateFile(nint Remote)
        => default;

    internal static void HandlePushDefault(string OldName, string NewName)
    {
    }

    internal static void ClearPushInfo(nint Util, nint UNUSED)
    {
    }

    internal static void FreeRemoteRefStates(nint States)
    {
    }

    internal static int AppendRefToTrackedList(nint Ref, nint CbData)
        => default;

    internal static int AddRemoteToShowInfo(nint Item, nint CbData)
        => default;

    internal static int ShowRemoteInfoItem(nint Item, nint CbData)
        => default;

    internal static int AddLocalToShowInfo(nint BranchItem, nint CbData)
        => default;

    internal static int ShowLocalInfoItem(nint Item, nint CbData)
        => default;

    internal static int AddPushToShowInfo(nint PushItem, nint CbData)
        => default;

    internal static int CmpStringWithPush(nint Va, nint Vb)
        => default;

    internal static int ShowPushInfoItem(nint Item, nint CbData)
        => default;

    internal static int GetOneEntry(nint Remote, nint Priv)
        => default;

    internal static int ShowAll()
        => default;

    internal static int PruneRemote(string Remote, int DryRun)
        => default;

    internal static int RemoveAllFetchRefspecs(string Key)
        => default;

}
