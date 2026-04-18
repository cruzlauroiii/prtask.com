namespace PrTask.Git.Generated;

internal static partial class Diff
{
    internal const int FAST_WORKING_DIRECTORY = 0;
    internal const int FAST_WORKING_DIRECTORY = 1;
    internal static int ParseDiffColorSlot(string Var)
        => default;

    internal static int ParseSubmoduleParams(nint Options, string Value)
        => default;

    internal static int GitConfigRename(string Var, string Value)
        => default;

    internal static long ParseAlgorithmValue(string Value)
        => default;

    internal static int ParseOneToken(string Arg, string Token)
        => default;

    internal static int ParseWsErrorHighlight(string Arg)
        => default;

    internal static void InitDiffUiDefaults()
    {
    }

    internal static int ParseColorMoved(string Arg)
        => default;

    internal static uint ParseColorMovedWs(string Arg)
        => default;

    internal static int CountLines(string Data, int Size)
        => default;

    internal static int CountTrailingBlank(nint Mf)
        => default;

    internal enum DiffSymbol
    {
        DIFF_SYMBOL_BINARY_DIFF_HEADER,
        DIFF_SYMBOL_BINARY_DIFF_HEADER_DELTA,
        DIFF_SYMBOL_BINARY_DIFF_HEADER_LITERAL,
        DIFF_SYMBOL_BINARY_DIFF_BODY,
        DIFF_SYMBOL_BINARY_DIFF_FOOTER,
        DIFF_SYMBOL_STATS_SUMMARY_NO_FILES,
        DIFF_SYMBOL_STATS_SUMMARY_ABBREV,
        DIFF_SYMBOL_STATS_SUMMARY_INSERTS_DELETES,
        DIFF_SYMBOL_STATS_LINE,
        DIFF_SYMBOL_WORD_DIFF,
        DIFF_SYMBOL_STAT_SEP,
        DIFF_SYMBOL_SUMMARY,
        DIFF_SYMBOL_SUBMODULE_ADD,
        DIFF_SYMBOL_SUBMODULE_DEL,
        DIFF_SYMBOL_SUBMODULE_UNTRACKED,
        DIFF_SYMBOL_SUBMODULE_MODIFIED,
        DIFF_SYMBOL_SUBMODULE_HEADER,
        DIFF_SYMBOL_SUBMODULE_ERROR,
        DIFF_SYMBOL_SUBMODULE_PIPETHROUGH,
        DIFF_SYMBOL_REWRITE_DIFF,
        DIFF_SYMBOL_BINARY_FILES,
        DIFF_SYMBOL_HEADER,
        DIFF_SYMBOL_FILEPAIR_PLUS,
        DIFF_SYMBOL_FILEPAIR_MINUS,
        DIFF_SYMBOL_WORDS_PORCELAIN,
        DIFF_SYMBOL_WORDS,
        DIFF_SYMBOL_CONTEXT,
        DIFF_SYMBOL_CONTEXT_INCOMPLETE,
        DIFF_SYMBOL_PLUS,
        DIFF_SYMBOL_MINUS,
        DIFF_SYMBOL_CONTEXT_FRAGINFO,
        DIFF_SYMBOL_CONTEXT_MARKER,
        DIFF_SYMBOL_SEPARATOR,
    }
    internal static void FreeEmittedDiffSymbols(nint E)
    {
    }

    internal static void FillEsIndentData(nint Es)
    {
    }

    internal static int AdjustLastBlock(nint O, int N, int BlockLength)
        => default;

    internal static void DimMovedLines(nint O)
    {
    }

    internal static void DiffEmitSubmoduleDel(nint O, string Line)
    {
    }

    internal static void DiffEmitSubmoduleAdd(nint O, string Line)
    {
    }

    internal static void DiffEmitSubmoduleUntracked(nint O, string Path)
    {
    }

    internal static void DiffEmitSubmoduleModified(nint O, string Path)
    {
    }

    internal static void DiffEmitSubmoduleHeader(nint O, string Header)
    {
    }

    internal static void DiffEmitSubmoduleError(nint O, string Err)
    {
    }

    internal static int NewBlankLineAtEof(nint Ecbdata, string Line, int Len)
        => default;

    internal static void RemoveTempfile()
    {
    }

    internal static void AddLineCount(nint Out, int Count)
    {
    }

    internal static int ColorWordsOutputGraphPrefix(nint DiffWords)
        => default;

    internal static void DiffWordsShow(nint DiffWords)
    {
    }

    internal static void DiffWordsFlush(nint Ecbdata)
    {
    }

    internal static void FreeDiffWordsData(nint Ecbdata)
    {
    }

    internal static Unlong SaneTruncateLine(string Line, Unlong Len)
        => default;

    internal static void FindLno(string Line, nint Ecbdata)
    {
    }

    internal static int FnOutConsume(nint Priv, string Line, Unlong Len)
        => default;

    internal static int QuickConsume(nint Priv, nint UNUSED, Unlong len UNUSED)
        => default;

    internal static void PprintRename(nint Name, string A, string B)
    {
    }

    internal static int DiffstatConsume(nint Priv, string Line, Unlong Len)
        => default;

    internal static int ScaleLinear(int It, int Width, int MaxChange)
        => default;

    internal static void FillPrintName(nint File)
    {
    }

    internal static void ShowStats(nint Data, nint Options)
    {
    }

    internal static void ShowShortstats(nint Data, nint Options)
    {
    }

    internal static void ShowNumstat(nint Data, nint Options)
    {
    }

    internal static int DirstatCompare(nint A, nint B)
        => default;

    internal static void ShowDirstat(nint Options)
    {
    }

    internal static void ShowDirstatByLine(nint Data, nint Options)
    {
    }

    internal static void FreeDiffstatFile(nint F)
    {
    }

    internal static void FreeDiffstatInfo(nint Diffstat)
    {
    }

    internal static int IsConflictMarker(string Line, int MarkerSize, Unlong Len)
        => default;

    internal static int CheckdiffConsume(nint Priv, string Line, Unlong Len)
        => default;

    internal static void DiffSetMnemonicPrefix(nint Options, string A, string B)
    {
    }

    internal static void DiffSetNoprefix(nint Options)
    {
    }

    internal static void DiffSetDefaultPrefix(nint Options)
    {
    }

    internal static void FreeFilespec(nint Spec)
    {
    }

    internal static int DiffPopulateGitlink(nint S, int SizeOnly)
        => default;

    internal static void DiffFreeFilespecBlob(nint S)
    {
    }

    internal static void DiffFreeFilespecData(nint S)
    {
    }

    internal static int SimilarityIndex(nint P)
        => default;

    internal static void DiffFillOidInfo(nint One, nint Istate)
    {
    }

    internal static void StripPrefix(int PrefixLength, string Namep, string Otherp)
    {
    }

    internal static void RunDiff(nint P, nint O)
    {
    }

    internal static void RunCheckdiff(nint P, nint O)
    {
    }

    internal static void RepoDiffSetup(nint R, nint Options)
    {
    }

    internal static void PrepareFilterBits()
    {
    }

    internal static uint FilterBitTst(byte Status, nint Opt)
        => default;

    internal static uint DiffFilterBit(byte Status)
        => default;

    internal static int DiffCheckFollowPathspec(nint Ps, int DieOnError)
        => default;

    internal static void DiffSetupDone(nint Options)
    {
    }

    internal static int DiffOptStat(nint Opt, string Value, int Unset)
        => default;

    internal static int ParseDirstatOpt(nint Options, string Params)
        => default;

    internal static void EnablePatchOutput(nint Fmt)
    {
    }

    internal static int DiffOptRotateTo(nint Opt, string Arg, int Unset)
        => default;

    internal static int ParseRenameScore(string CpP)
        => default;

    internal static void DiffQ(nint Queue, nint Dp)
    {
    }

    internal static void DiffFreeFilepair(nint P)
    {
    }

    internal static void DiffQueueInit(nint Q)
    {
    }

    internal static void DiffQueueClear(nint Q)
    {
    }

    internal static void DiffFlushRaw(nint P, nint Opt)
    {
    }

    internal static int DiffUnmodifiedPair(nint P)
        => default;

    internal static void DiffFlushPatch(nint P, nint O)
    {
    }

    internal static int DiffFlushPatchQuietly(nint P, nint O)
        => default;

    internal static int DiffQueueIsEmpty(nint O)
        => default;

    internal static void DiffDebugFilespec(nint S, int X, string One)
    {
    }

    internal static void DiffDebugFilepair(nint P, int I)
    {
    }

    internal static void DiffDebugQueue(string Msg, nint Q)
    {
    }

    internal static void DiffResolveRenameCopy()
    {
    }

    internal static int CheckPairStatus(nint P)
        => default;

    internal static void FlushOnePair(nint P, nint Opt)
    {
    }

    internal static void ShowFileModeName(nint Opt, string Newdelete, nint Fs)
    {
    }

    internal static void DiffSummary(nint Opt, nint P)
    {
    }

    internal static int RemoveSpace(string Line, int Len)
        => default;

    internal static void FlushOneHunk(nint Result, nint Ctx)
    {
    }

    internal static int PatchIdConsume(nint Priv, string Line, Unlong Len)
        => default;

    internal static void PatchIdAddString(nint Ctx, string Str)
    {
    }

    internal static void PatchIdAddMode(nint Ctx, uint Mode)
    {
    }

    internal static int DiffGetPatchId(nint Options, nint Oid, int DiffHeaderOnly)
        => default;

    internal static int DiffFlushPatchId(nint Options, nint Oid, int DiffHeaderOnly)
        => default;

    internal static int IsSummaryEmpty(nint Q)
        => default;

    internal static void DiffWarnRenameLimit(string Varname, int Needed, int DegradedCc)
    {
    }

    internal static void CreateFilepairsForHeaderOnlyNotifications(nint O)
    {
    }

    internal static void DiffFlushPatchAllFilePairs(nint O)
    {
    }

    internal static void DiffFreeFile(nint Options)
    {
    }

    internal static void DiffFreeIgnoreRegex(nint Options)
    {
    }

    internal static void DiffFree(nint Options)
    {
    }

    internal static void DiffFlush(nint Options)
    {
    }

    internal static int MatchFilter(nint Options, nint P)
        => default;

    internal static void DiffcoreApplyFilter(nint Options)
    {
    }

    internal static void DiffcoreSkipStatUnmatch(nint Diffopt)
    {
    }

    internal static int Diffnamecmp(nint A, nint B)
        => default;

    internal static void DiffcoreFixDiffIndex()
    {
    }

    internal static void DiffQueuedDiffPrefetch(nint Repository)
    {
    }

    internal static void InitDiffstatWidths(nint Options)
    {
    }

    internal static void DiffcoreStd(nint Options)
    {
    }

    internal static int DiffResultCode(nint Revs)
        => default;

    internal static int DiffCanQuitEarly(nint Opt)
        => default;

    internal static int IsSubmoduleIgnored(string Path, nint Options)
        => default;

    internal static void SetupDiffPager(nint Opt)
    {
    }

}
