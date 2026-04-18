namespace PrTask.Git.Generated;

internal static partial class Stash
{
    internal const int INCLUDE_ALL_FILES = 2;
    internal static void FreeStashInfo(nint Info)
    {
    }

    internal static int CheckStashTopology(nint R, nint Stash)
        => default;

    internal static void AssertStashLike(nint Info, string Revision)
    {
    }

    internal static int ParseStashRevision(nint Revision, string Commit, int Quiet)
        => default;

    internal static int GetStashInfo(nint Info, int Argc, string Argv)
        => default;

    internal static int DoClearStash()
        => default;

    internal static int ResetTree(nint ITree, int Update, int Reset)
        => default;

    internal static int DiffTreeBinary(nint Out, nint WCommit)
        => default;

    internal static int ApplyCached(nint Out)
        => default;

    internal static int ResetHead()
        => default;

    internal static int IsPathADirectory(string Path)
        => default;

    internal static int RestoreUntracked(nint UTree)
        => default;

    internal static void UnstageChangesUnlessNew(nint OrigTree)
    {
    }

    internal static int ReflogIsEmpty(string Refname)
        => default;

    internal static int DoDropStash(nint Info, int Quiet)
        => default;

    internal static void DiffIncludeUntracked(nint Info, nint DiffOpt)
    {
    }

    internal static int CheckChangesTrackedFiles(nint Ps)
        => default;

    internal static int StashWorkingTree(nint Info, nint Ps)
        => default;

    internal static int DoImportStash(nint R, string Rev)
        => default;

    internal enum ExportAction
    {
        ACTION_NONE,
        ACTION_PRINT,
        ACTION_TO_REF,
    }
}
