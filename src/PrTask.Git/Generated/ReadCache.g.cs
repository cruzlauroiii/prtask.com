namespace PrTask.Git.Generated;

internal static partial class ReadCache
{
    internal const int CACHE_EXT_TREE = 0x54524545	/* "TREE" */;
    internal const int CACHE_EXT_RESOLVE_UNDO = 0x52455543 /* "REUC" */;
    internal const int CACHE_EXT_LINK = 0x6c696e6b	  /* "link" */;
    internal const int CACHE_EXT_UNTRACKED = 0x554E5452	  /* "UNTR" */;
    internal const int CACHE_EXT_FSMONITOR = 0x46534D4E	  /* "FSMN" */;
    internal const int CACHE_EXT_ENDOFINDEXENTRIES = 0x454F4945	/* "EOIE" */;
    internal const int CACHE_EXT_INDEXENTRYOFFSETTABLE = 0x49454F54 /* "IEOT" */;
    internal const int CACHE_EXT_SPARSE_DIRECTORIES = 0x73646972 /* "sdir" */;
    internal const int CACHE_ENTRY_PATH_LENGTH = 80;
    internal enum IndexSearchMode
    {
        NO_EXPAND_SPARSE = 0,
        EXPAND_SPARSE = 1,
    }
    internal static void SetIndexEntry(nint Istate, int Nr, nint Ce)
    {
    }

    internal static void ReplaceIndexEntry(nint Istate, int Nr, nint Ce)
    {
    }

    internal static void RenameIndexEntryAt(nint Istate, int Nr, string NewName)
    {
    }

    internal static void FillStatCacheInfo(nint Istate, nint Ce, nint St)
    {
    }

    internal static Unint StModeFromCe(nint Ce)
        => default;

    internal static int FakeLstat(nint Ce, nint St)
        => default;

    internal static int CeCompareLink(nint Ce, nuint ExpectedSize)
        => default;

    internal static int CeCompareGitlink(nint Ce)
        => default;

    internal static int CeMatchStatBasic(nint Ce, nint St)
        => default;

    internal static int CmpCacheNameCompare(nint A, nint B)
        => default;

    internal static int IndexNamePos(nint Istate, string Name, int Namelen)
        => default;

    internal static int IndexNamePosSparse(nint Istate, string Name, int Namelen)
        => default;

    internal static int IndexEntryExists(nint Istate, string Name, int Namelen)
        => default;

    internal static int RemoveIndexEntryAt(nint Istate, int Pos)
        => default;

    internal static void RemoveMarkedCacheEntries(nint Istate, int Invalidate)
    {
    }

    internal static int RemoveFileFromIndex(nint Istate, string Path)
        => default;

    internal static int CompareName(nint Ce, string Path, int Namelen)
        => default;

    internal static int DifferentName(nint Ce, nint Alias)
        => default;

    internal static void SetObjectNameForIntentToAddEntry(nint Ce)
    {
    }

    internal static int AddToIndex(nint Istate, string Path, nint St, int Flags)
        => default;

    internal static int AddFileToIndex(nint Istate, string Path, int Flags)
        => default;

    internal enum VerifyPathResult
    {
        PATH_OK,
        PATH_INVALID,
        PATH_DIR_WITH_SEP,
    }
    internal static int VerifyPath(string Path, uint Mode)
        => default;

    internal static int CeSameName(nint A, nint B)
        => default;

    internal static int VerifyDotfile(string Rest, uint Mode)
        => default;

    internal static int StrcmpOffset(string S1, string S2, nint FirstChange)
        => default;

    internal static int AddIndexEntryWithCheck(nint Istate, nint Ce, int Option)
        => default;

    internal static int AddIndexEntry(nint Istate, nint Ce, int Option)
        => default;

    internal const int INDEX_FORMAT_DEFAULT = 3;
    internal static Unint GetIndexFormatDefault(nint R)
        => default;

    internal static int VerifyHdr(nint Hdr, Unlong Size)
        => default;

    internal static void CheckCeOrder(nint Istate)
    {
    }

    internal static void TweakUntrackedCache(nint Istate)
    {
    }

    internal static void TweakSplitIndex(nint Istate)
    {
    }

    internal static void PostReadIndexFrom(nint Istate)
    {
    }

    internal static nuint EstimateCacheSizeFromCompressed(Unint Entries)
        => default;

    internal static nuint EstimateCacheSize(nuint OndiskSize, Unint Entries)
        => default;

    internal static void SetNewIndexSparsity(nint Istate)
    {
    }

    internal static int DoReadIndex(nint Istate, string Path, int MustExist)
        => default;

    internal static void FreshenSharedIndex(string SharedIndex, int Warn)
    {
    }

    internal static int IsIndexUnborn(nint Istate)
        => default;

    internal static void IndexStateInit(nint Istate, nint R)
    {
    }

    internal static void ReleaseIndex(nint Istate)
    {
    }

    internal static void DiscardIndex(nint Istate)
    {
    }

    internal static void ValidateCacheEntries(nint Istate)
    {
    }

    internal static int UnmergedIndex(nint Istate)
        => default;

    internal static int VerifyIndexFrom(nint Istate, string Path)
        => default;

    internal static int RepoVerifyIndex(nint Repo)
        => default;

    internal static int HasRacyTimestamp(nint Istate)
        => default;

    internal static int RecordEoie()
        => default;

    internal static int RecordIeot()
        => default;

    internal enum WriteExtensions
    {
        WRITE_NO_EXTENSION =              0,
        WRITE_SPLIT_INDEX_EXTENSION =     1<<0,
        WRITE_CACHE_TREE_EXTENSION =      1<<1,
        WRITE_RESOLVE_UNDO_EXTENSION =    1<<2,
        WRITE_UNTRACKED_CACHE_EXTENSION = 1<<3,
        WRITE_FSMONITOR_EXTENSION =       1<<4,
    }
    internal static void SetAlternateIndexOutput(string Name)
    {
    }

    internal static int CommitLockedIndex(nint Lk)
        => default;

    internal static Unlong GetSharedIndexExpireDate()
        => default;

    internal static int ShouldDeleteSharedIndex(string SharedIndexPath)
        => default;

    internal static int CleanSharedIndexFiles(string CurrentHex)
        => default;

    internal static int TooManyNotSharedEntries(nint Istate)
        => default;

    internal static int RepoReadIndexUnmerged(nint Repo)
        => default;

    internal static void MoveIndexExtensions(nint Dst, nint Src)
    {
    }

    internal static void DiscardCacheEntry(nint Ce)
    {
    }

    internal static int ShouldValidateCacheEntries()
        => default;

    internal static nuint ReadEoieExtension(string Mmap, nuint MmapSize)
        => default;

    internal static void WriteEoieExtension(nint Sb, nint EoieContext, nuint Offset)
    {
    }

    internal static void WriteIeotExtension(nint Sb, nint Ieot)
    {
    }

}
