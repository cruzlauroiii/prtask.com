namespace PrTask.Git.Generated;

internal static partial class FilesBackend
{
    internal static void ClearLooseRefCache(nint Refs)
    {
    }

    internal static void FilesRefStoreRelease(nint RefStore)
    {
    }

    internal static void AddPerWorktreeEntriesToDir(nint Dir, string Dirname)
    {
    }

    internal static int FillRootRef(string Refname, nint CbData)
        => default;

    internal static void UnlockRef(nint Lock)
    {
    }

    internal static int FilesRefIteratorAdvance(nint RefIterator)
        => default;

    internal static void FilesRefIteratorRelease(nint RefIterator)
    {
    }

    internal static int RaceproofCreateFile(string Path, CreateFileFn Fn, nint Cb)
        => default;

    internal static int RemoveEmptyDirectories(nint Path)
        => default;

    internal static int CreateReflock(string Path, nint Cb)
        => default;

    internal static void PruneRef(nint Refs, nint R)
    {
    }

    internal static void PruneRefs(nint Refs, nint RefsToPrune)
    {
    }

    internal const string TMP_RENAMED_LOG = "refs/.tmp-renamed-log";
    internal static int RenameTmpLogCallback(string Path, nint CbData)
        => default;

    internal static int RenameTmpLog(nint Refs, string Newrefname)
        => default;

    internal static int CloseRefGently(nint Lock)
        => default;

    internal static int CommitRef(nint Lock)
        => default;

    internal static int OpenOrCreateLogfile(string Path, nint Cb)
        => default;

    internal static int CreateRefSymlink(nint Lock, string Target)
        => default;

    internal static int FilesReflogIteratorAdvance(nint RefIterator)
        => default;

    internal static void FilesReflogIteratorRelease(nint RefIterator)
    {
    }

    internal static int RefPresent(nint Ref, nint CbData)
        => default;

    internal static int FilesFsckRootRef(string Refname, nint CbData)
        => default;

}
