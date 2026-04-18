namespace PrTask.Git.Generated;

internal static partial class HttpBackend
{
    internal static void FormatWrite(int Fd, string Fmt, params object[] VarArgs)
    {
    }

    internal static void HttpStatus(nint Hdr, uint Code, string Msg)
    {
    }

    internal static void HdrStr(nint Hdr, string Name, string Value)
    {
    }

    internal static void HdrInt(nint Hdr, string Name, ulong Value)
    {
    }

    internal static void HdrDate(nint Hdr, string Name, TimestampT When)
    {
    }

    internal static void HdrNocache(nint Hdr)
    {
    }

    internal static void HdrCacheForever(nint Hdr)
    {
    }

    internal static void EndHeaders(nint Hdr)
    {
    }

    internal static NORETURN void NotFound(nint Hdr, string Err, params object[] VarArgs)
        => default;

    internal static NORETURN void Forbidden(nint Hdr, string Err, params object[] VarArgs)
        => default;

    internal static void SelectGetanyfile(nint Hdr)
    {
    }

    internal static void GetTextFile(nint Hdr, string Name)
    {
    }

    internal static void GetLooseObject(nint Hdr, string Name)
    {
    }

    internal static void GetPackFile(nint Hdr, string Name)
    {
    }

    internal static void GetIdxFile(nint Hdr, string Name)
    {
    }

    internal static void HttpConfig()
    {
    }

    internal static void WriteToChild(int Out, nint Buf, nint Len, string ProgName)
    {
    }

    internal static nint ReadRequestEof(int Fd, nint Out)
        => default;

    internal static nint ReadRequestFixedLen(int Fd, nint ReqLen, nint Out)
        => default;

    internal static nint GetContentLength()
        => default;

    internal static nint ReadRequest(int Fd, nint Out, nint ReqLen)
        => default;

    internal static void InflateRequest(string ProgName, int Out, int BufferInput, nint ReqLen)
    {
    }

    internal static void CopyRequest(string ProgName, int Out, nint ReqLen)
    {
    }

    internal static void PipeFixedLength(string ProgName, int Out, nuint ReqLen)
    {
    }

    internal static void RunService(string Argv, int BufferInput)
    {
    }

    internal static int ShowTextRef(nint Ref, nint CbData)
        => default;

    internal static void GetInfoRefs(nint Hdr, nint UNUSED)
    {
    }

    internal static int ShowHeadRef(nint Ref, nint CbData)
        => default;

    internal static void GetHead(nint Hdr, nint UNUSED)
    {
    }

    internal static void GetInfoPacks(nint Hdr, nint UNUSED)
    {
    }

    internal static void CheckContentType(nint Hdr, string AcceptedType)
    {
    }

    internal static void ServiceRpc(nint Hdr, string ServiceName)
    {
    }

    internal static NORETURN void DieWebcgi(string Err, VaList Params)
        => default;

    internal static int DieWebcgiRecursing()
        => default;

    internal static byte Getdir()
        => default;

    internal static int BadRequest(nint Hdr, nint C)
        => default;

    internal static int CmdMain(Int argc UNUSED, nint UNUSED)
        => default;

}
