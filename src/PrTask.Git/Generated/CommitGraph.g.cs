namespace PrTask.Git.Generated;

internal static partial class CommitGraph
{
    internal static void GitTestWriteCommitGraphOrDie(nint Source)
    {
    }

    internal const int GRAPH_SIGNATURE = 0x43475048 /* "CGPH" */;
    internal const int GRAPH_CHUNKID_OIDFANOUT = 0x4f494446 /* "OIDF" */;
    internal const int GRAPH_CHUNKID_OIDLOOKUP = 0x4f49444c /* "OIDL" */;
    internal const int GRAPH_CHUNKID_DATA = 0x43444154 /* "CDAT" */;
    internal const int GRAPH_CHUNKID_GENERATION_DATA = 0x47444132 /* "GDA2" */;
    internal const int GRAPH_CHUNKID_GENERATION_DATA_OVERFLOW = 0x47444f32 /* "GDO2" */;
    internal const int GRAPH_CHUNKID_EXTRAEDGES = 0x45444745 /* "EDGE" */;
    internal const int GRAPH_CHUNKID_BLOOMINDEXES = 0x42494458 /* "BIDX" */;
    internal const int GRAPH_CHUNKID_BLOOMDATA = 0x42444154 /* "BDAT" */;
    internal const int GRAPH_CHUNKID_BASE = 0x42415345 /* "BASE" */;
    internal const int GRAPH_VERSION_1 = 0x1;
    internal const int GRAPH_EXTRA_EDGES_NEEDED = 0x80000000;
    internal const int GRAPH_EDGE_LAST_MASK = 0x7fffffff;
    internal const int GRAPH_PARENT_NONE = 0x70000000;
    internal const int GRAPH_LAST_EDGE = 0x80000000;
    internal const int GRAPH_HEADER_SIZE = 8;
    internal static nuint GraphDataWidth(nint Algop)
        => default;

    internal static nuint GraphMinSize(nint Algop)
        => default;

    internal static void SetCommitPos(nint R, nint Oid)
    {
    }

    internal static int CommitPosCmp(nint Va, nint Vb)
        => default;

    internal static int GetConfiguredGenerationVersion(nint R)
        => default;

    internal static uint CommitGraphPosition(nint C)
        => default;

    internal static TimestampT CommitGraphGeneration(nint C)
        => default;

    internal static TimestampT CommitGraphGenerationFromGraph(nint C)
        => default;

    internal static int CommitGenCmp(nint Va, nint Vb)
        => default;

    internal static int CommitGraphCompatible(nint R)
        => default;

    internal static int OpenCommitGraph(string GraphFile, nint Fd, nint St)
        => default;

    internal static int ValidateMixedGenerationChain(nint G)
        => default;

    internal static void ValidateMixedBloomSettings(nint G)
    {
    }

    internal static int GenerationNumbersEnabled(nint R)
        => default;

    internal static int CorrectedCommitDatesEnabled(nint R)
        => default;

    internal static void CloseCommitGraph(nint O)
    {
    }

    internal static int BsearchGraph(nint G, nint Oid, nint Pos)
        => default;

    internal static void FillCommitGraphInfo(nint Item, nint G, uint Pos)
    {
    }

    internal static void SetCommitTree(nint C, nint T)
    {
    }

    internal static int SearchCommitPosInGraph(nint Id, nint G, nint Pos)
        => default;

    internal static int FindCommitPosInGraph(nint Item, nint G, nint Pos)
        => default;

    internal static int ParseCommitInGraph(nint R, nint Item)
        => default;

    internal static void LoadCommitGraphInfo(nint R, nint Item)
    {
    }

    internal static void Trace2BloomFilterSettings(nint Ctx)
    {
    }

    internal static void AddMissingParents(nint Ctx, nint Commit)
    {
    }

    internal static void CloseReachable(nint Ctx)
    {
    }

    internal static TimestampT GetTopoLevel(nint C, nint Data)
        => default;

    internal static void SetTopoLevel(nint C, TimestampT T, nint Data)
    {
    }

    internal static void ComputeTopologicalLevels(nint Ctx)
    {
    }

    internal static void ComputeGenerationNumbers(nint Ctx)
    {
    }

    internal static void Trace2BloomFilterWriteStatistics(nint Ctx)
    {
    }

    internal static void ComputeBloomFilters(nint Ctx)
    {
    }

    internal static int AddRefToSet(nint Ref, nint CbData)
        => default;

    internal static void FillOidsFromAllPacks(nint Ctx)
    {
    }

    internal static void CopyOidsToCommits(nint Ctx)
    {
    }

    internal static int WriteCommitGraphFile(nint Ctx)
        => default;

    internal static int CommitCompare(nint A, nint B)
        => default;

    internal static void SortAndScanMergedCommits(nint Ctx)
    {
    }

    internal static void MarkCommitGraphs(nint Ctx)
    {
    }

    internal static void ExpireCommitGraphs(nint Ctx)
    {
    }

    internal const int VERIFY_COMMIT_GRAPH_ERROR_HASH = 2;
    internal static void GraphReport(string Fmt, params object[] VarArgs)
    {
    }

    internal static int CommitGraphChecksumValid(nint G)
        => default;

    internal static int VerifyCommitGraph(nint G, int Flags)
        => default;

    internal static void FreeCommitGraph(nint G)
    {
    }

    internal static void DisableCommitGraph(nint R)
    {
    }

}
