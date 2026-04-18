namespace PrTask.Git.Generated;

internal static partial class MergeOrt
{
    internal enum MergeSide
    {
        MERGE_BASE = 0,
        MERGE_SIDE1 = 1,
        MERGE_SIDE2 = 2,
    }
    internal static void ConflictedSubmoduleItemFree(nint Util, nint UNUSED)
    {
    }

    internal enum ConflictAndInfoTypes
    {
        INFO_AUTO_MERGING = 0,
        CONFLICT_CONTENTS,
        CONFLICT_BINARY,
        CONFLICT_FILE_DIRECTORY,
        CONFLICT_DISTINCT_MODES,
        CONFLICT_MODIFY_DELETE,
        CONFLICT_RENAME_RENAME,
        CONFLICT_RENAME_COLLIDES,
        CONFLICT_RENAME_DELETE,
        CONFLICT_DIR_RENAME_SUGGESTED,
        INFO_DIR_RENAME_APPLIED,
        INFO_DIR_RENAME_SKIPPED_DUE_TO_RERENAME,
        CONFLICT_DIR_RENAME_FILE_IN_WAY,
        CONFLICT_DIR_RENAME_COLLISION,
        CONFLICT_DIR_RENAME_SPLIT,
        INFO_SUBMODULE_FAST_FORWARDING,
        CONFLICT_SUBMODULE_FAILED_TO_MERGE,
        CONFLICT_SUBMODULE_FAILED_TO_MERGE_BUT_POSSIBLE_RESOLUTION,
        CONFLICT_SUBMODULE_NOT_INITIALIZED,
        CONFLICT_SUBMODULE_HISTORY_NOT_AVAILABLE,
        CONFLICT_SUBMODULE_MAY_HAVE_REWINDS,
        CONFLICT_SUBMODULE_NULL_MERGE_BASE,
        NB_REGULAR_CONFLICT_TYPES,
        ERROR_SUBMODULE_CORRUPT,
        ERROR_THREEWAY_CONTENT_MERGE_FAILED,
        ERROR_OBJECT_WRITE_FAILED,
        ERROR_OBJECT_READ_FAILED,
        ERROR_OBJECT_NOT_A_BLOB,
        NB_TOTAL_TYPES,
    }
    internal static void FreeStrmapStrings(nint Map)
    {
    }

    internal static void AddFlattenedPath(nint Out, string S)
    {
    }

    internal static void ResolveTrivialDirectoryMerge(nint Ci, int Side)
    {
    }

    internal static void InitializeAttrIndex(nint Opt)
    {
    }

    internal static void HandleDirectoryLevelConflicts(nint Opt)
    {
    }

    internal static void FreeCollisions(nint Collisions)
    {
    }

    internal static int PossibleRenames(nint Renames)
        => default;

    internal static void ResolveDiffpairStatuses(nint Q)
    {
    }

    internal static int ComparePairs(nint A, nint B)
        => default;

    internal static int DetectAndProcessRenames(nint Opt)
        => default;

    internal static int SortDirsNextToTheirChildren(string One, string Two)
        => default;

    internal static int TreeEntryOrder(nint A, nint B)
        => default;

    internal static int RecordConflictedIndexEntries(nint Opt)
        => default;

    internal static void PrintSubmoduleConflictSuggestion(nint Csub)
    {
    }

    internal static void SetCommitTree(nint C, nint T)
    {
    }

    internal static void MergeStart(nint Opt, nint Result)
    {
    }

    internal static void MergeRecursiveConfig(nint Opt, int Ui)
    {
    }

    internal static void CopyMergeOptions(nint Dst, nint Src)
    {
    }

    internal static void ClearMergeOptions(nint UNUSED)
    {
    }

    internal static int ParseMergeOpt(nint Opt, string S)
        => default;

}
