namespace PrTask.Git.Generated;

internal static partial class ImapSend
{
    internal const int USE_CURL_DEFAULT = 1;
    internal const int USE_CURL_DEFAULT = 0;
    internal const int DRV_OK = 0;
    internal const int DRV_MSG_BAD = -1;
    internal const int DRV_BOX_BAD = -2;
    internal const int DRV_STORE_BAD = -3;
    internal enum CAPABILITY
    {
        NOLOGIN = 0,
        UIDPLUS,
        LITERALPLUS,
        NAMESPACE,
        STARTTLS,
        AUTH_PLAIN,
        AUTH_CRAM_MD5,
        AUTH_OAUTHBEARER,
        AUTH_XOAUTH2,
    }
    internal const int RESP_OK = 0;
    internal const int RESP_NO = 1;
    internal const int RESP_BAD = 2;
    internal static void SslSocketPerror(string Func)
    {
    }

    internal static void SocketPerror(string Func, nint Sock, int Ret)
    {
    }

    internal static int HostMatches(string Host, string Pattern)
        => default;

    internal static int VerifyHostname(nint Cert, string Hostname)
        => default;

    internal static int SocketRead(nint Sock, string Buf, int Len)
        => default;

    internal static int SocketWrite(nint Sock, string Buf, int Len)
        => default;

    internal static void SocketShutdown(nint Sock)
    {
    }

    internal static int BufferGets(nint B, string S)
        => default;

    internal static void ImapInfo(string Msg, params object[] VarArgs)
    {
    }

    internal static void ImapWarn(string Msg, params object[] VarArgs)
    {
    }

    internal static int SkipImapListL(string Sp, int Level)
        => default;

    internal static void SkipList(string Sp)
    {
    }

    internal static void ParseCapability(nint Imap, string Cmd)
    {
    }

    internal static int GetCmdResult(nint Ctx, nint Tcmd)
        => default;

    internal static void ImapCloseServer(nint Ictx)
    {
    }

    internal static void ImapCloseStore(nint Ctx)
    {
    }

    internal static byte Hexchar(Unint B)
        => default;

    internal static int AuthPlain(nint Ctx, nint UNUSED)
        => default;

    internal static int AuthCramMd5(nint Ctx, string Prompt)
        => default;

    internal static int AuthOauthbearer(nint Ctx, nint UNUSED)
        => default;

    internal static int AuthXoauth2(nint Ctx, nint UNUSED)
        => default;

    internal static void ServerFillCredential(nint Srvc, nint Cred)
    {
    }

    internal static void LfToCrlf(nint Msg)
    {
    }

    internal static int ImapStoreMsg(nint Ctx, nint Msg)
        => default;

    internal static void WrapInHtml(nint Msg)
    {
    }

    internal static int CountMessages(nint AllMsgs)
        => default;

    internal static int SplitMsg(nint AllMsgs, nint Msg, nint Ofs)
        => default;

    internal static int ListImapFolders(nint Server)
        => default;

    internal static int CurlListImapFolders(nint Server)
        => default;

    internal static int CmdMain(int Argc, string Argv)
        => default;

}
