namespace PrTask.Git.Generated;

internal static partial class Revision
{
    internal static void MarkBlobUninteresting(nint Blob)
    {
    }

    internal static void MarkTreeUninteresting(nint R, nint Tree)
    {
    }

    internal static void PathsAndOidsClear(nint Map)
    {
    }

    internal static void MarkParentsUninteresting(nint Revs, nint Commit)
    {
    }

    internal static void AddHeadToPending(nint Revs)
    {
    }

    internal static int RelevantCommit(nint Commit)
        => default;

    internal const int REV_TREE_SAME = 0;
    internal const int REV_TREE_NEW = 1	/* Only new files */;
    internal const int REV_TREE_OLD = 2	/* Only files removed */;
    internal const int REV_TREE_DIFFERENT = 3	/* Mixed changes */;
    internal static void Trace2BloomFilterStatisticsAtexit()
    {
    }

    internal static int ForbidBloomFilters(nint Spec)
        => default;

    internal static void PrepareToUseBloomFilter(nint Revs)
    {
    }

    internal static int CompactTreesame(nint Revs, nint Commit, uint NthParent)
        => default;

    internal static uint UpdateTreesame(nint Revs, nint Commit)
        => default;

    internal static int LimitingCanIncreaseTreesame(nint Revs)
        => default;

    internal static void TryToSimplifyCommit(nint Revs, nint Commit)
    {
    }

    internal static void CherryPickList(nint List, nint Revs)
    {
    }

    internal const int SLOP = 5;
    internal static void LimitToAncestry(nint Bottoms, nint List)
    {
    }

    internal static void LimitLeftRight(nint List, nint Revs)
    {
    }

    internal static int LimitList(nint Revs)
        => default;

    internal static int RefExcluded(nint Exclusions, string Path)
        => default;

    internal static void InitRefExclusions(nint Exclusions)
    {
    }

    internal static void ClearRefExclusions(nint Exclusions)
    {
    }

    internal static void AddRefExclusion(nint Exclusions, string Exclude)
    {
    }

    internal static void ExcludeHiddenRefs(nint Exclusions, string Section)
    {
    }

    internal static int HandleOneRef(nint Ref, nint CbData)
        => default;

    internal static void HandleOneReflogCommit(nint Oid, nint CbData)
    {
    }

    internal static int HandleOneReflog(string RefnameInWt, nint CbData)
        => default;

    internal static void AddOtherReflogsToPending(nint Cb)
    {
    }

    internal static void AddReflogsToPending(nint Revs, uint Flags)
    {
    }

    internal static void AddResolveUndoToPending(nint Istate, nint Revs)
    {
    }

    internal static void AddIndexObjectsToPending(nint Revs, Unint Flags)
    {
    }

    internal static void PrepareShowMerge(nint Revs)
    {
    }

    internal static int HandleRevisionArg1(string Arg, nint Revs, int Flags, uint RevargOpt)
        => default;

    internal static int HandleRevisionArg(string Arg, nint Revs, int Flags, uint RevargOpt)
        => default;

    internal static void AddGrep(nint Revs, string Ptn, GrepPatToken What)
    {
    }

    internal static void AddHeaderGrep(nint Revs, GrepHeaderField Field, string Pattern)
    {
    }

    internal static void AddMessageGrep(nint Revs, string Pattern)
    {
    }

    internal static int ParseCount(string Arg)
        => default;

    internal static TimestampT ParseAge(string Arg)
        => default;

    internal static void RevisionOptsFinish(nint Revs)
    {
    }

    internal static int ForEachBadBisectRef(nint Refs, RefsForEachCb Fn, nint CbData)
        => default;

    internal static int ForEachGoodBisectRef(nint Refs, RefsForEachCb Fn, nint CbData)
        => default;

    internal static Void NORETURN DiagnoseMissingDefault(string Def)
        => default;

    internal static int SetupRevisions(int Argc, string Argv, nint Revs, nint Opt)
        => default;

    internal static void ReleaseRevisionsCmdline(nint Cmdline)
    {
    }

    internal static void ReleaseRevisionsMailmap(nint Mailmap)
    {
    }

    internal static void ReleaseRevisionsBloomKeyvecs(nint Revs)
    {
    }

    internal static void FreeVoidCommitList(nint List)
    {
    }

    internal static void ReleaseRevisions(nint Revs)
    {
    }

    internal static void AddChild(nint Revs, nint Parent, nint Child)
    {
    }

    internal static int RemoveDuplicateParents(nint Revs, nint Commit)
        => default;

    internal static int MarkRedundantParents(nint Commit)
        => default;

    internal static int MarkTreesameRootParents(nint Commit)
        => default;

    internal static int LeaveOneTreesameToParent(nint Revs, nint Commit)
        => default;

    internal static int RemoveMarkedParents(nint Revs, nint Commit)
        => default;

    internal static void SimplifyMerges(nint Revs)
    {
    }

    internal static void SetChildren(nint Revs)
    {
    }

    internal static void ResetRevisionWalk()
    {
    }

    internal static void Trace2TopoWalkStatisticsAtexit()
    {
    }

    internal static void TestFlagAndInsert(nint Q, nint C, int Flag)
    {
    }

    internal static void ExploreWalkStep(nint Revs)
    {
    }

    internal static void IndegreeWalkStep(nint Revs)
    {
    }

    internal static void ReleaseRevisionsTopoWalkInfo(nint Info)
    {
    }

    internal static void ResetTopoWalk(nint Revs)
    {
    }

    internal static void InitTopoWalk(nint Revs)
    {
    }

    internal static void ExpandTopoWalk(nint Revs, nint Commit)
    {
    }

    internal static int PrepareRevisionWalk(nint Revs)
        => default;

    internal static void MergeQueueIntoList(nint Q, nint List)
    {
    }

    internal static RewriteResult RewriteOne(nint Revs, nint Pp)
        => default;

    internal static int CommitMatch(nint Commit, nint Opt)
        => default;

    internal static int WantAncestry(nint Revs)
        => default;

    internal static CommitAction GetCommitAction(nint Revs, nint Commit)
        => default;

    internal static void SaveParents(nint Revs, nint Commit)
    {
    }

    internal static void FreeSavedParent(nint Parents)
    {
    }

    internal static void FreeSavedParents(nint Revs)
    {
    }

    internal static CommitAction SimplifyCommit(nint Revs, nint Commit)
        => default;

    internal static void TrackLinear(nint Revs, nint Commit)
    {
    }

    internal static int EntryUnshown(nint Entry, nint UNUSED)
        => default;

    internal static void GcBoundary(nint Array)
    {
    }

    internal static void CreateBoundaryCommitList(nint Revs)
    {
    }

    internal static void PutRevisionMark(nint Revs, nint Commit)
    {
    }

}
