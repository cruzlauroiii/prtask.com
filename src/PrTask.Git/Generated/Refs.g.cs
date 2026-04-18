namespace PrTask.Git.Generated;

internal static partial class Refs
{
    internal static RefStorageFormat RefStorageFormatByName(string Name)
        => default;

    internal static void UpdateRefNamespace(RefNamespace Namespace, string Ref)
    {
    }

    internal static int CheckRefnameFormat(string Refname, int Flags)
        => default;

    internal static void SanitizeRefnameComponent(string Refname, nint Out)
    {
    }

    internal static int RefnameIsSafe(string Refname)
        => default;

    internal static int RefsReadRef(nint Refs, string Refname, nint Oid)
        => default;

    internal static int RefsRefExists(nint Refs, string Refname)
        => default;

    internal static int ForEachFilterRefs(nint Ref, nint Data)
        => default;

    internal static int WarnIfDanglingSymref(nint Ref, nint CbData)
        => default;

    internal static int RefsForEachTagRef(nint Refs, RefsForEachCb Cb, nint CbData)
        => default;

    internal static int RefsForEachBranchRef(nint Refs, RefsForEachCb Cb, nint CbData)
        => default;

    internal static int RefsForEachRemoteRef(nint Refs, RefsForEachCb Cb, nint CbData)
        => default;

    internal static int RefsHeadRefNamespaced(nint Refs, RefsForEachCb Fn, nint CbData)
        => default;

    internal static int RefnameMatch(string AbbrevName, string FullName)
        => default;

    internal static void ExpandRefPrefix(nint Prefixes, string Prefix)
    {
    }

    internal static void CopyBranchname(nint Sb, string Name, uint Allowed)
    {
    }

    internal static int CheckBranchRef(nint Sb, string Name)
        => default;

    internal static int CheckTagRef(nint Sb, string Name)
        => default;

    internal static int IsPerWorktreeRef(string Refname)
        => default;

    internal static int IsPseudoRef(string Refname)
        => default;

    internal static int IsRootRefSyntax(string Refname)
        => default;

    internal static int IsRootRef(string Refname)
        => default;

    internal static int IsCurrentWorktreeRef(string Ref)
        => default;

    internal static long GetFilesRefLockTimeoutMs()
        => default;

    internal static void CopyReflogMsg(nint Sb, string Msg)
    {
    }

    internal static int IsBranch(string Refname)
        => default;

    internal static void RefTransactionFree(nint Transaction)
    {
    }

    internal static int RefsHeadRef(nint Refs, RefsForEachCb Fn, nint CbData)
        => default;

    internal static int RefsForEachRef(nint Refs, RefsForEachCb Cb, nint CbData)
        => default;

    internal static int RefsForEachReplaceRef(nint Refs, RefsForEachCb Cb, nint CbData)
        => default;

    internal static int QsortStrcmp(nint Va, nint Vb)
        => default;

    internal static int RefStoreCreateOnDisk(nint Refs, int Flags, nint Err)
        => default;

    internal static int RefStoreRemoveOnDisk(nint Refs, nint Err)
        => default;

    internal static void RefStoreRelease(nint RefStore)
    {
    }

    internal static int RefsOptimize(nint Refs, nint Opts)
        => default;

    internal static int TransactionHookFeedStdin(int HookStdinFd, nint PpCb, nint PpTaskCb)
        => default;

    internal static void TransactionFeedCbDataFree(nint Data)
    {
    }

    internal static int DoForEachReflogHelper(nint Ref, nint CbData)
        => default;

    internal static int RefsForEachReflog(nint Refs, EachReflogFn Fn, nint CbData)
        => default;

    internal static int RefsReflogExists(nint Refs, string Refname)
        => default;

    internal static int RefsDeleteReflog(nint Refs, string Refname)
        => default;

    internal static int RefUpdateHasNullNewValue(nint Update)
        => default;

    internal static int MigrateOneRef(nint Ref, nint CbData)
        => default;

    internal static int MigrateOneReflog(string Refname, nint CbData)
        => default;

    internal static int MoveFiles(string FromPath, string ToPath, nint Errbuf)
        => default;

    internal static int HasWorktrees()
        => default;

    internal static int RefUpdateExpectsExistingOldRef(nint Update)
        => default;

}
