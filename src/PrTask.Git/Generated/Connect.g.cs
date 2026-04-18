namespace PrTask.Git.Generated;

internal static partial class Connect
{
    internal static int CheckRef(string Name, Unint Flags)
        => default;

    internal static int CheckRefType(nint Ref, int Flags)
        => default;

    internal static NORETURN void DieInitialContact(int Unexpected)
        => default;

    internal static int ServerSupportsV2(string C)
        => default;

    internal static void EnsureServerSupportsV2(string C)
    {
    }

    internal static int ServerFeatureV2(string C, string V)
        => default;

    internal static void ProcessCapabilitiesV2(nint Reader)
    {
    }

    internal static ProtocolVersion DiscoverVersion(nint Reader)
        => default;

    internal static void ParseOneSymrefInfo(nint Symref, string Val, int Len)
    {
    }

    internal static void AnnotateRefsWithSymrefInfo(nint Ref)
    {
    }

    internal static void ProcessCapabilities(nint Reader, nint Linelen)
    {
    }

    internal static int ProcessDummyRef(nint Reader)
        => default;

    internal static void CheckNoCapabilities(string Line, nuint Len)
    {
    }

    internal enum GetRemoteHeadsState
    {
        EXPECTING_FIRST_REF = 0,
        EXPECTING_REF,
        EXPECTING_SHALLOW,
        EXPECTING_DONE,
    }
    internal static void SendCapabilities(int FdOut, nint Reader)
    {
    }

    internal static int ServerSupportsHash(string Desired, nint FeatureSupported)
        => default;

    internal static int ParseFeatureRequest(string FeatureList, string Feature)
        => default;

    internal static int ServerSupports(string Feature)
        => default;

    internal enum Protocol
    {
        PROTO_LOCAL = 1,
        PROTO_FILE,
        PROTO_SSH,
        PROTO_GIT,
    }
    internal static int UrlIsLocalNotSsh(string Url)
        => default;

    internal static Protocol GetProtocol(string Name)
        => default;

    internal static void GetHostAndPort(string Host, string Port)
    {
    }

    internal static void EnableKeepalive(int Sockfd)
    {
    }

    internal static int GitTcpConnectSock(string Host, int Flags)
        => default;

    internal static int GitTcpConnectSock(string Host, int Flags)
        => default;

    internal static int GitConnectionIsSocket(nint Conn)
        => default;

    internal static int GitUseProxy(string Host)
        => default;

    internal enum SshVariant
    {
        VARIANT_AUTO,
        VARIANT_SIMPLE,
        VARIANT_SSH,
        VARIANT_PLINK,
        VARIANT_PUTTY,
        VARIANT_TORTOISEPLINK,
    }
    internal static void OverrideSshVariant(nint SshVariant)
    {
    }

    internal static int FinishConnect(nint Conn)
        => default;

}
