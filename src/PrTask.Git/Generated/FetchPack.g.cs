namespace PrTask.Git.Generated;

internal static partial class FetchPack
{
    internal const int MAX_IN_VAIN = 256;
    internal const int ALLOW_TIP_SHA1 = 01;
    internal const int ALLOW_REACHABLE_SHA1 = 02;
    internal static void DieInCommitGraphOnly(nint Oid)
    {
    }

    internal static int RevListInsertRefOid(nint Ref, nint CbData)
        => default;

    internal enum AckType
    {
        NAK = 0,
        ACK,
        ACK_continue,
        ACK_common,
        ACK_ready,
    }
    internal const int INITIAL_FLUSH = 16;
    internal const int PIPESAFE_FLUSH = 32;
    internal const int LARGE_FLUSH = 16384;
    internal static int NextFlush(int StatelessRpc, int Count)
        => default;

    internal static int MarkComplete(nint Oid)
        => default;

    internal static int MarkCompleteOid(nint Ref, nint UNUSED)
        => default;

    internal static void AddRefsToOidset(nint Oids, nint Refs)
    {
    }

    internal static int IsUnmatchedRef(nint Ref)
        => default;

    internal static int SidebandDemux(Int in UNUSED, int Out, nint Data)
        => default;

    internal static void ParseGitmodulesOids(int Fd, nint GitmodulesOids)
    {
    }

    internal static void AddIndexPackKeepOption(nint Args)
    {
    }

    internal static int RefCompareName(nint A, nint B)
        => default;

    internal static int CmpRefByName(nint A, nint B)
        => default;

    internal static void AddWants(nint Wants, nint ReqBuf)
    {
    }

    internal static void AddCommon(nint ReqBuf, nint Common)
    {
    }

    internal static int CmpNameRef(nint Name, nint Ref)
        => default;

    internal enum FetchState
    {
        FETCH_CHECK_LOCAL = 0,
        FETCH_SEND_REQUEST,
        FETCH_PROCESS_ACKS,
        FETCH_GET_PACK,
        FETCH_DONE,
    }
    internal static void FetchPackConfig()
    {
    }

    internal static void FetchPackSetup()
    {
    }

    internal static int RemoveDuplicatesInRefs(nint Ref, int Nr)
        => default;

    internal static int FetchPackFsckObjects()
        => default;

    internal static int AddToObjectArray(nint Oid, nint Data)
        => default;

    internal static void ClearCommonFlag(nint S)
    {
    }

    internal static int ReportUnmatchedRefs(nint Sought, int NrSought)
        => default;

}
