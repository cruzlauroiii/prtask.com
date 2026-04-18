namespace PrTask.Git.Generated;

internal static partial class SendPack
{
    internal static int ReceiveUnpackStatus(nint Reader)
        => default;

    internal static int SidebandDemux(Int in UNUSED, int Out, nint Data)
        => default;

    internal static int AdvertiseShallowGraftsCb(nint Graft, nint Cb)
        => default;

    internal static void AdvertiseShallowGraftsBuf(nint R, nint Sb)
    {
    }

    internal const int CHECK_REF_NO_PUSH = -1;
    internal const int CHECK_REF_STATUS_REJECTED = -2;
    internal const int CHECK_REF_UPTODATE = -3;
    internal static int CheckToSendUpdate(nint Ref, nint Args)
        => default;

    internal const int NONCE_LEN_LIMIT = 256;
    internal static void RejectInvalidNonce(string Nonce, int Len)
    {
    }

}
