namespace PrTask.Git.Generated;

internal static partial class UploadPack
{
    internal enum AllowUor
    {
        ALLOW_TIP_SHA1 = 0x01,
        ALLOW_REACHABLE_SHA1 = 0x02,
        ALLOW_ANY_SHA1 = 0x07,
    }
    internal static void UploadPackDataInit(nint Data)
    {
    }

    internal static void UploadPackDataClear(nint Data)
    {
    }

    internal static void ResetTimeout(Unint Timeout)
    {
    }

    internal static int WriteOneShallow(nint Graft, nint CbData)
        => default;

    internal static int DoGotOid(nint Data, nint Oid)
        => default;

    internal static int OkToGiveUp(nint Data)
        => default;

    internal static int AllowHiddenRefs(AllowUor AllowUor)
        => default;

    internal static int IsOurRef(nint O, AllowUor AllowUor)
        => default;

    internal static int HasUnreachable(nint Src, AllowUor AllowUor)
        => default;

    internal static void CheckNonTip(nint Data)
    {
    }

    internal static void SendUnshallow(nint Data)
    {
    }

    internal static void Deepen(nint Data, int Depth)
    {
    }

    internal static int SendShallowList(nint Data)
        => default;

    internal static int ProcessShallow(string Line, nint Shallows)
        => default;

    internal static int ProcessDeepen(string Line, nint Depth)
        => default;

    internal static int ProcessDeepenSince(string Line, nint DeepenSince, nint DeepenRevList)
        => default;

    internal static int ProcessDeepenNot(string Line, nint DeepenNot, nint DeepenRevList)
        => default;

    internal static void DieIfUsingBannedFilter(nint Data)
    {
    }

    internal static int CheckRef(nint Ref, nint CbData)
        => default;

    internal static void FormatSymrefInfo(nint Buf, nint Symref)
    {
    }

    internal static void FormatSessionId(nint Buf, nint D)
    {
    }

    internal static int SendRef(nint Ref, nint CbData)
        => default;

    internal static int FindSymref(nint Ref, nint CbData)
        => default;

    internal static int ParseHave(string Line, nint Data)
        => default;

    internal static void Trace2FetchInfo(nint Data)
    {
    }

    internal static int SendAcks(nint Data, nint Acks)
        => default;

    internal static int ProcessHavesAndSendAcks(nint Data)
        => default;

    internal static void SendWantedRefInfo(nint Data)
    {
    }

    internal static void SendShallowInfo(nint Data)
    {
    }

    internal enum UploadState
    {
        UPLOAD_PROCESS_ARGS = 0,
        UPLOAD_SEND_ACKS,
        UPLOAD_SEND_PACK,
        UPLOAD_DONE,
    }
    internal static int UploadPackV2(nint R, nint Request)
        => default;

}
