namespace PrTask.Git.Generated;

internal static partial class Commit
{
    internal static TimestampT ParseCommitDate(string Buf, string Tail)
        => default;

    internal static int CommitGraftPos(nint R, nint Oid)
        => default;

    internal static void UnparseCommit(nint R, nint Oid)
    {
    }

    internal static int ReadGraftFile(nint R, string GraftFile)
        => default;

    internal static void PrepareCommitGraft(nint R)
    {
    }

    internal static int ForEachCommitGraft(EachCommitGraftFn Fn, nint CbData)
        => default;

    internal static void FreeCommitBufferSlab(nint Bs)
    {
    }

    internal static void SetCommitBuffer(nint R, nint Commit, nint Buffer, Unlong Size)
    {
    }

    internal static void FreeCommitBuffer(nint Pool, nint Commit)
    {
    }

    internal static void SetCommitTree(nint C, nint T)
    {
    }

    internal static void ReleaseCommitMemory(nint Pool, nint C)
    {
    }

    internal static int ParseCommitBuffer(nint R, nint Item, nint Buffer, Unlong Size, int CheckGraph)
        => default;

    internal static void ParseCommitOrDie(nint Item)
    {
    }

    internal static int FindCommitSubject(string CommitBuffer, string Subject)
        => default;

    internal static nuint CommitSubjectLength(string Body)
        => default;

    internal static int CommitListContains(nint Item, nint List)
        => default;

    internal static uint CommitListCount(nint L)
        => default;

    internal static void CommitListFree(nint List)
    {
    }

    internal static CommitList CommitListInsertByDate(nint Item, nint List)
        => default;

    internal static void CommitListSortByDate(nint List)
    {
    }

    internal static void ClearCommitMarksMany(nuint Nr, nint Commit, Unint Mark)
    {
    }

    internal static void ClearCommitMarks(nint Commit, Unint Mark)
    {
    }

    internal static void SortInTopologicalOrder(nint List, RevSortOrder SortOrder)
    {
    }

    internal static void AddOneCommit(nint Oid, nint Revs)
    {
    }

    internal static int AddHeaderSignature(nint Buf, nint Sig, nint Algo)
        => default;

    internal static int SignCommitToStrbuf(nint Sig, nint Buf, string Keyid)
        => default;

    internal static int RemoveSignature(nint Buf)
        => default;

    internal static void HandleSignedTag(nint Parent, nint Tail)
    {
    }

    internal static int CheckCommitSignature(nint Commit, nint Sigc)
        => default;

    internal static int ForEachMergetag(EachMergetagFn Fn, nint Commit, nint Data)
        => default;

    internal static int StandardHeaderField(string Field, nuint Len)
        => default;

    internal static int ExcludedHeaderField(string Field, nuint Len, string Exclude)
        => default;

    internal static void FreeCommitExtraHeaders(nint Extra)
    {
    }

    internal static int FindInvalidUtf8(string Buf, int Len)
        => default;

    internal static int VerifyUtf8(nint Buf)
        => default;

    internal static nuint IgnoredLogMessageBytes(string Buf, nuint Len)
        => default;

    internal static void CommitStackInit(nint Stack)
    {
    }

    internal static void CommitStackGrow(nint Stack, nuint Extra)
    {
    }

    internal static void CommitStackPush(nint Stack, nint Commit)
    {
    }

    internal static void CommitStackClear(nint Stack)
    {
    }

}
