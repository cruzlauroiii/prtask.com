namespace PrTask.Git.Generated;

internal static partial class Remote
{
    internal enum MapDirection
    {
        enum {,
        ENABLE_ADVICE_PULL       = (1 << 0),
        ENABLE_ADVICE_PUSH       = (1 << 1),
        ENABLE_ADVICE_DIVERGENCE = (1 << 2),
    }
    internal static int ValidRemote(nint Remote)
        => default;

    internal static void AddUrl(nint Remote, string Url)
    {
    }

    internal static void AddPushurl(nint Remote, string Pushurl)
    {
    }

    internal static void RemoteClear(nint Remote)
    {
    }

    internal static void AddMerge(nint Branch, string Name)
    {
    }

    internal static void MergeClear(nint Branch)
    {
    }

    internal static void BranchRelease(nint Branch)
    {
    }

    internal static void RewritesRelease(nint R)
    {
    }

    internal static void AddInsteadOf(nint Rewrite, string InsteadOf)
    {
    }

    internal static void ReadRemotesFile(nint Repo, nint Remote)
    {
    }

    internal static void ReadBranchesFile(nint Repo, nint Remote)
    {
    }

    internal static void AliasAllUrls(nint RemoteState)
    {
    }

    internal static void ReadConfig(nint Repo, int Early)
    {
    }

    internal static int ValidRemoteNick(string Name)
        => default;

    internal static void ValidateRemoteUrl(nint Remote)
    {
    }

    internal static int RemoteIsConfigured(nint Remote, int InRepo)
        => default;

    internal static int ForEachRemote(EachRemoteFn Fn, nint Priv)
        => default;

    internal static void HandleDuplicate(nint Ref1, nint Ref2)
    {
    }

    internal static int RemoteHasUrl(nint Remote, string Url)
        => default;

    internal static void RefPushReportFree(nint Report)
    {
    }

    internal static int RemoteFindTracking(nint Remote, nint Refspec)
        => default;

    internal static void FreeOneRef(nint Ref)
    {
    }

    internal static void FreeRefs(nint Ref)
    {
    }

    internal static void TailLinkRef(nint Ref, nint Tail)
    {
    }

    internal static void AddToTips(nint Tips, nint Oid)
    {
    }

    internal static void AddMissingTags(nint Src, nint Dst, nint DstTail)
    {
    }

    internal static void PrepareRefIndex(nint RefIndex, nint Ref)
    {
    }

    internal static int CheckPushRefs(nint Src, nint Rs)
        => default;

    internal static void SetMerge(nint Repo, nint Ret)
    {
    }

    internal static int BranchHasMergeConfig(nint Branch)
        => default;

    internal static int IgnoreSymrefUpdate(string Refname, nint Scratch)
        => default;

    internal static int ResolveRemoteSymref(nint Ref, nint List)
        => default;

    internal static int OneLocalRef(nint Ref, nint CbData)
        => default;

    internal static int GetStaleHeadsCb(nint Ref, nint CbData)
        => default;

    internal static void ClearCasOption(nint Cas)
    {
    }

    internal static int ParsePushCasOption(nint Cas, string Arg, int Unset)
        => default;

    internal static int ParseoptPushCasOption(nint Opt, string Arg, int Unset)
        => default;

    internal static int IsEmptyCas(nint Cas)
        => default;

    internal const int MERGE_BASES_BATCH_SIZE = 8;
    internal static int IsReachableInReflog(string Local, nint Remote)
        => default;

    internal static void CheckIfIncludesUpstream(nint Remote)
    {
    }

    internal static void RemoteStateClear(nint RemoteState)
    {
    }

    internal static int ChopLastDir(string Remoteurl, int IsRelative)
        => default;

    internal static int ValidRemoteName(string Name)
        => default;

}
