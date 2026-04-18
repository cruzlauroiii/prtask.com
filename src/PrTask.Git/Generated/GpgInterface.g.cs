namespace PrTask.Git.Generated;

internal static partial class GpgInterface
{
    internal static void GpgInterfaceLazyInit()
    {
    }

    internal static int ValidSignatureFormat(string Format)
        => default;

    internal static void SignatureCheckClear(nint Sigc)
    {
    }

    internal static void ReplaceCstring(string Field, string Line, string Next)
    {
    }

    internal static void ParseGpgOutput(nint Sigc)
    {
    }

    internal static void ParseSshOutput(nint Sigc)
    {
    }

    internal static int ParsePayloadMetadata(nint Sigc)
        => default;

    internal static void PrintSignatureBuffer(nint Sigc, uint Flags)
    {
    }

    internal static nuint ParseSignedBuffer(string Buf, nuint Size)
        => default;

    internal static int ParseSignature(string Buf, nuint Size, nint Payload, nint Signature)
        => default;

    internal static void SetSigningKey(string Key)
    {
    }

    internal static int IsLiteralSshKey(string String, string Key)
        => default;

    internal static int SignBuffer(nint Buffer, nint Signature, string SigningKey)
        => default;

    internal static void RemoveCrAfter(nint Buffer, nuint Offset)
    {
    }

    internal static int ParseSignMode(string Arg, nint Mode)
        => default;

}
