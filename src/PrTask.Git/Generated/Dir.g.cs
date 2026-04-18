namespace PrTask.Git.Generated;

internal static partial class Dir
{
    internal enum PathTreatment
    {
        path_none = 0,
        path_recurse,
        path_excluded,
        path_untracked,
    }
    internal static int ForEachFileInDir(nint Path, FileIterator Fn, nint Data)
        => default;

    internal static int CountSlashes(string S)
        => default;

    internal static int GitFspathcmp(string A, string B)
        => default;

    internal static int Fspatheq(string A, string B)
        => default;

    internal static int GitFspathncmp(string A, string B, nuint Count)
        => default;

    internal static int PathsCollide(string A, string B)
        => default;

    internal static Unint Fspathhash(string Str)
        => default;

    internal static nuint CommonPrefixLen(nint Pathspec)
        => default;

    internal static int SimpleLength(string Match)
        => default;

    internal static int NoWildcard(string String)
        => default;

    internal static void ClearPatternEntryHashmap(nint Map)
    {
    }

    internal static void AddPatternToHashsets(nint Pl, nint Given)
    {
    }

    internal static void ClearPatternList(nint Pl)
    {
    }

    internal static void TrimTrailingSpaces(string Buf)
    {
    }

    internal static void DoInvalidateGitignore(nint Dir)
    {
    }

    internal static void AddPatternsFromFile(nint Dir, string Fname)
    {
    }

    internal static int InitSparseCheckoutPatterns(nint Istate)
        => default;

    internal enum ExistStatus
    {
        index_nonexistent = 0,
        index_directory,
        index_gitdir,
    }
    internal static void AddUntracked(nint Dir, string Name)
    {
    }

    internal static int ReadCachedDir(nint Cdir)
        => default;

    internal static void CloseCachedDir(nint Cdir)
    {
    }

    internal static int CmpDirEntry(nint P1, nint P2)
        => default;

    internal static int CheckDirEntryContains(nint Out, nint In)
        => default;

    internal static int IdentInUntracked(nint Uc)
        => default;

    internal static void SetUntrackedIdent(nint Uc)
    {
    }

    internal static uint NewUntrackedCacheFlags(nint Istate)
        => default;

    internal static void NewUntrackedCache(nint Istate, int Flags)
    {
    }

    internal static void AddUntrackedCache(nint Istate)
    {
    }

    internal static void RemoveUntrackedCache(nint Istate)
    {
    }

    internal static int FileExists(string F)
        => default;

    internal static int RepoFileExists(nint Repo, string Path)
        => default;

    internal static int CmpIcase(byte A, byte B)
        => default;

    internal static int DirInsideOf(string Subdir, string Dir)
        => default;

    internal static int IsInsideDir(string Dir)
        => default;

    internal static int IsEmptyDir(string Path)
        => default;

    internal static void StripDirTrailingSlashes(string Dir)
    {
    }

    internal static int RemoveDirRecurse(nint Path, int Flag, nint KeptUp)
        => default;

    internal static int RemoveDirRecursively(nint Path, int Flag)
        => default;

    internal static void SetupStandardExcludes(nint Dir)
    {
    }

    internal static int GetSparseCheckoutPatterns(nint Pl)
        => default;

    internal static int RemovePath(string Name)
        => default;

    internal static void DirClear(nint Dir)
    {
    }

    internal static void StatDataToDisk(nint To, nint From)
    {
    }

    internal static void WriteUntrackedExtension(nint Out, nint Untracked)
    {
    }

    internal static void FreeUntracked(nint Ucd)
    {
    }

    internal static void FreeUntrackedCache(nint Uc)
    {
    }

    internal static void StatDataFromDisk(nint To, nint Data)
    {
    }

    internal static void SetCheckOnly(nuint Pos, nint Cb)
    {
    }

    internal static void ReadStat(nuint Pos, nint Cb)
    {
    }

    internal static void ReadOid(nuint Pos, nint Cb)
    {
    }

    internal static void RelocateGitdir(string Path, string OldGitDir, string NewGitDir)
    {
    }

    internal static int PathMatchFlags(string Str, PathMatchFlags Flags)
        => default;

}
