namespace PrTask.Git.Generated;

internal static partial class Apply
{
    internal static void GitApplyConfig()
    {
    }

    internal static int ParseWhitespaceOption(nint State, string Option)
        => default;

    internal static void ClearApplyState(nint State)
    {
    }

    internal static void MuteRoutine(nint UNUSED, VaList params UNUSED)
    {
    }

    internal static int CheckApplyState(nint State, int ForceApply)
        => default;

    internal static void SetDefaultWhitespaceMode(nint State)
    {
    }

    internal const int BINARY_DELTA_DEFLATED = 1;
    internal const int BINARY_LITERAL_DEFLATED = 2;
    internal static void FreeFragmentList(nint List)
    {
    }

    internal static void ReleasePatch(nint Patch)
    {
    }

    internal static void FreePatch(nint Patch)
    {
    }

    internal static void FreePatchList(nint List)
    {
    }

    internal const int LINE_COMMON = 1;
    internal const int LINE_PATCHED = 2;
    internal static void ImageInit(nint Image)
    {
    }

    internal static void ImageClear(nint Image)
    {
    }

    internal static uint HashLine(string Cp, nuint Len)
        => default;

    internal static void ImageAddLine(nint Img, string Bol, nuint Len, uint Flag)
    {
    }

    internal static void ImageRemoveFirstLine(nint Img)
    {
    }

    internal static void ImageRemoveLastLine(nint Img)
    {
    }

    internal static void SayPatchName(nint Output, string Fmt, nint Patch)
    {
    }

    internal static int ReadPatchFile(nint Sb, int Fd)
        => default;

    internal static Unlong Linelen(string Buffer, Unlong Size)
        => default;

    internal static int IsDevNull(string Str)
        => default;

    internal const int TERM_SPACE = 1;
    internal const int TERM_TAB = 2;
    internal static int NameTerminate(int C, int Terminate)
        => default;

    internal static nuint SaneTzLen(string Line, nuint Len)
        => default;

    internal static nuint TzWithColonLen(string Line, nuint Len)
        => default;

    internal static nuint DateLen(string Line, nuint Len)
        => default;

    internal static nuint ShortTimeLen(string Line, nuint Len)
        => default;

    internal static nuint FractionalTimeLen(string Line, nuint Len)
        => default;

    internal static nuint TrailingSpacesLen(string Line, nuint Len)
        => default;

    internal static nuint DiffTimestampLen(string Line, nuint Len)
        => default;

    internal static int GuessPValue(nint State, string Nameline)
        => default;

    internal static int HasEpochTimestamp(string Nameline)
        => default;

    internal const int DIFF_OLD_NAME = 0;
    internal const int DIFF_NEW_NAME = 1;
    internal static int ParseModeLine(string Line, int Linenr, nint Mode)
        => default;

    internal static int CheckHeaderLine(int Linenr, nint Patch)
        => default;

    internal static int ParseNum(string Line, nint P)
        => default;

    internal static void RecountDiff(string Line, int Size, nint Fragment)
    {
    }

    internal static int ParseFragmentHeader(string Line, int Len, nint Fragment)
        => default;

    internal static void CheckOldForCrlf(nint Patch, string Line, int Len)
    {
    }

    internal static int MetadataChanges(nint Patch)
        => default;

    internal static void PrefixOne(nint State, string Name)
    {
    }

    internal static void PrefixPatch(nint State, nint P)
    {
    }

    internal static int UsePatch(nint State, nint P)
        => default;

    internal static int ParseChunk(nint State, string Buffer, Unlong Size, nint Patch)
        => default;

    internal static void ReversePatches(nint P)
    {
    }

    internal static void ShowStats(nint State, nint Patch)
    {
    }

    internal static int ApplyFragments(nint State, nint Img, nint Patch)
        => default;

    internal static int ReadBlobObject(nint Buf, nint Oid, uint Mode)
        => default;

    internal static int ReadFileOrGitlink(nint Ce, nint Buf)
        => default;

    internal static int ToBeDeleted(nint Patch)
        => default;

    internal static int WasDeleted(nint Patch)
        => default;

    internal static void AddToFnTable(nint State, nint Patch)
    {
    }

    internal static void PrepareFnTable(nint State, nint Patch)
    {
    }

    internal const int SUBMODULE_PATCH_WITHOUT_INDEX = 1;
    internal static int ResolveTo(nint Image, nint ResultId)
        => default;

    internal const int EXISTS_IN_INDEX = 1;
    internal const int EXISTS_IN_WORKTREE = 2;
    internal const int EXISTS_IN_INDEX_AS_ITA = 3;
    internal static void PrepareSymlinkChanges(nint State, nint Patch)
    {
    }

    internal static int PathIsBeyondSymlink1(nint State, nint Name)
        => default;

    internal static int PathIsBeyondSymlink(nint State, string Name)
        => default;

    internal static int CheckUnsafePath(nint Patch)
        => default;

    internal static int CheckPatch(nint State, nint Patch)
        => default;

    internal static int CheckPatchList(nint State, nint Patch)
        => default;

    internal static int ReadApplyCache(nint State)
        => default;

    internal static int PreimageOidInGitlinkPatch(nint P, nint Oid)
        => default;

    internal static int BuildFakeAncestor(nint State, nint List)
        => default;

    internal static void StatPatchList(nint State, nint Patch)
    {
    }

    internal static void ShowFileModeName(string Newdelete, Unint Mode, string Name)
    {
    }

    internal static void ShowModeChange(nint P, int ShowName)
    {
    }

    internal static void ShowRenameCopy(nint P)
    {
    }

    internal static void SummaryPatchList(nint Patch)
    {
    }

    internal static void PatchStats(nint State, nint Patch)
    {
    }

    internal static int RemoveFile(nint State, nint Patch, int RmdirEmpty)
        => default;

    internal static int CreateFile(nint State, nint Patch)
        => default;

    internal static int WriteOutOneReject(nint State, nint Patch)
        => default;

    internal static int WriteOutResults(nint State, nint List)
        => default;

}
