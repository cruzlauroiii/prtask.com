namespace PrTask.Git.Generated;

internal static partial class Sha1
{
    internal const int SHA1DC_INIT_SAFE_HASH_DEFAULT = 1;
    internal static void Sha1Compression(nint Ihv, nint M)
    {
    }

    internal static void Sha1CompressionW(nint Ihv, nint W)
    {
    }

    internal static void Sha1CompressionStates(nint Ihv, nint M, nint W, nint States)
    {
    }

    internal static void Sha1RecompressionStep(uint Step, nint Ihvin, nint Ihvout, nint Me2, nint State)
    {
    }

    internal static void Sha1Process(nint Ctx, nint Block)
    {
    }

    internal static void SHA1DCInit(nint Ctx)
    {
    }

    internal static void SHA1DCSetSafeHash(nint Ctx, int Safehash)
    {
    }

    internal static void SHA1DCSetUseUBC(nint Ctx, int UbcCheck)
    {
    }

    internal static void SHA1DCSetUseDetectColl(nint Ctx, int DetectColl)
    {
    }

    internal static void SHA1DCSetDetectReducedRoundCollision(nint Ctx, int ReducedRoundColl)
    {
    }

    internal static void SHA1DCSetCallback(nint Ctx, CollisionBlockCallback Callback)
    {
    }

    internal static void SHA1DCUpdate(nint Ctx, string Buf, nuint Len)
    {
    }

    internal static int SHA1DCFinal(nint Output, nint Ctx)
        => default;

}
