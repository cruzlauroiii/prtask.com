namespace PrTask.Git.Generated;

internal static partial class Http
{
    internal const int PREV_BUF_SIZE = 4096;
    internal enum ProactiveAuth
    {
        PROACTIVE_AUTH_NONE = 0,
        PROACTIVE_AUTH_IF_CREDENTIALS,
        PROACTIVE_AUTH_AUTO,
        PROACTIVE_AUTH_BASIC,
    }
    internal static int AlwaysAuthProactively()
        => default;

    internal static nuint FreadBuffer(string Ptr, nuint Eltsize, nuint Nmemb, nint Buffer)
        => default;

    internal static int SeekBuffer(nint Clientp, CurlOffT Offset, int Origin)
        => default;

    internal static nuint FwriteBuffer(string Ptr, nuint Eltsize, nuint Nmemb, nint Buffer)
        => default;

    internal static int IsHdrContinuation(string Ptr, nuint Size)
        => default;

    internal static nuint FwriteWwwauth(string Ptr, nuint Eltsize, nuint Nmemb, nint UNUSED)
        => default;

    internal static void ClosedownActiveSlot(nint Slot)
    {
    }

    internal static void FinishActiveSlot(nint Slot)
    {
    }

    internal static void XmultiRemoveHandle(nint Slot)
    {
    }

    internal static void ProcessCurlMessages()
    {
    }

    internal static int CurlEmptyAuthEnabled()
        => default;

    internal static void InitCurlHttpAuth(nint Result)
    {
    }

    internal static void VarOverride(string Var, string Value)
    {
    }

    internal static void SetProxyauthNamePassword(nint Result)
    {
    }

    internal static void InitCurlProxyAuth(nint Result)
    {
    }

    internal static int HasCertPassword()
        => default;

    internal static int HasProxyCertPassword()
        => default;

    internal static int RedactSensitiveHeader(nint Header, nuint Offset)
        => default;

    internal static int MatchCurlH2Trace(string Line, string Out)
        => default;

    internal static void RedactSensitiveInfoHeader(nint Header)
    {
    }

    internal static void CurlDumpHeader(string Text, nint Ptr, nuint Size, int HideSensitiveHeader)
    {
    }

    internal static void CurlDumpData(string Text, nint Ptr, nuint Size)
    {
    }

    internal static void CurlDumpInfo(string Data, nuint Size)
    {
    }

    internal static void HttpTraceCurlNoData()
    {
    }

    internal static void SetupCurlTrace(nint Handle)
    {
    }

    internal static void ProtoListAppend(nint List, string Proto)
    {
    }

    internal static long GetCurlAllowedProtocols(int FromUser, nint List)
        => default;

    internal static int GetCurlHttpVersionOpt(string VersionString, nint Opt)
        => default;

    internal static void SetFromEnv(string Var, string Envname)
    {
    }

    internal static void SetLongFromEnv(nint Var, string Envname)
    {
    }

    internal static void HttpInit(nint Remote, string Url, int ProactiveAuth)
    {
    }

    internal static void HttpCleanup()
    {
    }

    internal static int StartActiveSlot(nint Slot)
        => default;

    internal static void FillActiveSlots()
    {
    }

    internal static void StepActiveSlots()
    {
    }

    internal static void RunActiveSlot(nint Slot)
    {
    }

    internal static void ReleaseActiveSlot(nint Slot)
    {
    }

    internal static void FinishAllActiveSlots()
    {
    }

    internal static int NeedsQuote(int Ch)
        => default;

    internal static int HandleCurlResult(nint Results)
        => default;

    internal static CURLcode CurlinfoStrbuf(nint Curl, CURLINFO Info, nint Buf)
        => default;

    internal static void WriteAcceptLanguage(nint Buf)
    {
    }

    internal static void HttpOptRequestRemainder(nint Curl, long Pos)
    {
    }

    internal const int HTTP_REQUEST_STRBUF = 0;
    internal const int HTTP_REQUEST_FILE = 1;
    internal static int HttpFetchRef(string Base, nint Ref)
        => default;

    internal static int HttpGetInfoPacks(string BaseUrl, nint Packs)
        => default;

    internal static void ReleaseHttpPackRequest(nint Preq)
    {
    }

    internal static int FinishHttpPackRequest(nint Preq)
        => default;

    internal static void ProcessHttpObjectRequest(nint Freq)
    {
    }

    internal static int FinishHttpObjectRequest(nint Freq)
        => default;

    internal static void AbortHttpObjectRequest(nint FreqP)
    {
    }

    internal static void ReleaseHttpObjectRequest(nint FreqP)
    {
    }

}
