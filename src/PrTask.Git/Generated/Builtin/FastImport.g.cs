namespace PrTask.Git.Generated;

internal static partial class FastImport
{
    internal const int PACK_ID_BITS = 16;
    internal const int DEPTH_BITS = 13;
    internal static void ForEachMark(nint M, ulong Base, EachMarkFnT Callback, nint P)
    {
    }

    internal static void DumpMarksFn(ulong Mark, nint Object, nint Cbp)
    {
    }

    internal static void WriteBranchReport(nint Rpt, nint B)
    {
    }

    internal static void WriteCrashReport(string Err)
    {
    }

    internal static NORETURN void DieNicely(string Err, VaList Params)
        => default;

    internal static void SetCheckpointSignal()
    {
    }

    internal static void CheckpointSignal(Int signo UNUSED)
    {
    }

    internal static void SetCheckpointSignal()
    {
    }

    internal static void AllocObjects(Unint Cnt)
    {
    }

    internal static void InvalidatePackId(Unint Id)
    {
    }

    internal static Unint HcStr(string S, nuint Len)
        => default;

    internal static void InsertMark(nint Top, ulong Idnum, nint Oe)
    {
    }

    internal static Unint HcEntries(Unint Cnt)
        => default;

    internal static void ReleaseTreeContent(nint T)
    {
    }

    internal static void ReleaseTreeContentRecursive(nint T)
    {
    }

    internal static void ReleaseTreeEntry(nint E)
    {
    }

    internal static void StartPackfile()
    {
    }

    internal static void UnkeepAllPacks()
    {
    }

    internal static int LoosenSmallPack(nint P)
        => default;

    internal static void EndPackfile()
    {
    }

    internal static void CyclePackfile()
    {
    }

    internal static void TruncatePack(nint Checkpoint)
    {
    }

    internal static void StreamBlob(ulong Len, nint Oidout, ulong Mark)
    {
    }

    internal static void LoadTree(nint Root)
    {
    }

    internal static int Tecmp0(nint A, nint B)
        => default;

    internal static int Tecmp1(nint A, nint B)
        => default;

    internal static void Mktree(nint T, int V, nint B)
    {
    }

    internal static void StoreTree(nint Root)
    {
    }

    internal static int UpdateBranch(nint B)
        => default;

    internal static void DumpBranches()
    {
    }

    internal static void DumpTags()
    {
    }

    internal static void DumpMarks()
    {
    }

    internal static void InsertObjectEntry(nint S, nint Oid, ulong Mark)
    {
    }

    internal static void InsertOidEntry(nint S, nint Oid, ulong Mark)
    {
    }

    internal static void ReadMarkFile(nint S, nint F, MarkSetInserterT Inserter)
    {
    }

    internal static void ReadMarks()
    {
    }

    internal static int ReadNextCommand()
        => default;

    internal static void SkipOptionalLf()
    {
    }

    internal static void ParseMark()
    {
    }

    internal static void ParseOriginalIdentifier()
    {
    }

    internal static int ParseData(nint Sb, ulong Limit, nint LenRes)
        => default;

    internal static int ValidateRawDate(string Src, nint Result, int Strict)
        => default;

    internal static void ParseNewBlob()
    {
    }

    internal static void UnloadOneBranch()
    {
    }

    internal static void LoadBranch(nint B)
    {
    }

    internal static Unchar ConvertNumNotesToFanout(ulong NumNotes)
        => default;

    internal static int ParseMappedOidHex(string Hex, nint Oid, string End)
        => default;

    internal static ulong ParseMarkRef(string P, string Endptr)
        => default;

    internal static ulong ParseMarkRefEol(string P)
        => default;

    internal static ulong ParseMarkRefSpace(string P)
        => default;

    internal static void ParsePathEol(nint Sb, string P, string Field)
    {
    }

    internal static void FileChangeM(string P, nint B)
    {
    }

    internal static void FileChangeD(string P, nint B)
    {
    }

    internal static void FileChangeCr(string P, nint B, int Rename)
    {
    }

    internal static void NoteChangeN(string P, nint B, nint OldFanout)
    {
    }

    internal static void FileChangeDeleteall(nint B)
    {
    }

    internal static void ParseFromCommit(nint B, string Buf, Unlong Size)
    {
    }

    internal static void ParseFromExisting(nint B)
    {
    }

    internal static int ParseObjectish(nint B, string Objectish)
        => default;

    internal static int ParseFrom(nint B)
        => default;

    internal static int ParseObjectishWithPrefix(nint B, string Prefix)
        => default;

    internal static void ParseOneSignature(nint Sig, string V)
    {
    }

    internal static void DiscardOneSignature()
    {
    }

    internal static void ParseNewCommit(string Arg)
    {
    }

    internal static void HandleTagSignature(nint Msg, string Name)
    {
    }

    internal static void ParseNewTag(string Arg)
    {
    }

    internal static void ParseResetBranch(string Arg)
    {
    }

    internal static void CatBlobWrite(string Buf, Unlong Size)
    {
    }

    internal static void CatBlob(nint Oe, nint Oid)
    {
    }

    internal static void ParseGetMark(string P)
    {
    }

    internal static void ParseCatBlob(string P)
    {
    }

    internal static void InsertMappedMark(ulong Mark, nint Object, nint Cbp)
    {
    }

    internal static void BuildMarkMapOne(nint From, nint To)
    {
    }

    internal static void BuildMarkMap(nint From, nint To)
    {
    }

    internal static void PrintLs(int Mode, nint Hash, string Path)
    {
    }

    internal static void ParseLs(string P, nint B)
    {
    }

    internal static void Checkpoint()
    {
    }

    internal static void ParseCheckpoint()
    {
    }

    internal static void ParseProgress()
    {
    }

    internal static void ParseAlias()
    {
    }

    internal static byte MakeFastImportPath(string Path)
        => default;

    internal static void OptionDateFormat(string Fmt)
    {
    }

    internal static Unlong UlongArg(string Option, string Arg)
        => default;

    internal static void OptionDepth(string Depth)
    {
    }

    internal static void OptionActiveBranches(string Branches)
    {
    }

    internal static void OptionExportMarks(string Marks)
    {
    }

    internal static void OptionCatBlobFd(string Fd)
    {
    }

    internal static void OptionExportPackEdges(string Edges)
    {
    }

    internal static void OptionRewriteSubmodules(string Arg, nint List)
    {
    }

    internal static int ParseOneOption(string Option)
        => default;

    internal static void CheckUnsafeFeature(string Feature, int FromStream)
    {
    }

    internal static int ParseOneFeature(string Feature, int FromStream)
        => default;

    internal static void ParseFeature(string Feature)
    {
    }

    internal static void ParseOption(string Option)
    {
    }

    internal static void GitPackConfig()
    {
    }

    internal static void ParseArgv()
    {
    }

}
