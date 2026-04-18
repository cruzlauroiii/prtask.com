namespace WillowMaze.Wasm.Decompiled;

public class Pb95e9adf : P419f3742
{
    private static bool F273a3855;
    public static pb95e9adf$p910eef8c F4e8cf6a1;
    private static bool F6208c126;
    private static bool F7104c119;
    public static pb95e9adf$p910eef8c F910eef8c;
    private readonly List<object> F16c7d849;
    private readonly p8b368d79 F20d035db;
    private readonly List<object> F96a0c6e4;
    private readonly p8b368d79 F990063fa;
    private readonly p8b368d79 Fb1b02a8c;
    private readonly List<object> Fe4e1144f;
    private readonly p8b368d79 Feaedc124;

    public static bool Access$isSupported$cp()
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf.f6208c126
        return false;
    }

    public p2e948d4e BuildCertificateChainCleaner(X509TrustManager P0)
    {
        // str: "trustManager"
        // call: p6c5d169e$p910eef8c.buildIfSupported
        // call: Intrinsics.checkNotNullParameter
        // call: p419f3742.buildCertificateChainCleaner
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e.f910eef8c
        return default!;
    }

    public p9989c878 BuildTrustRootIndex(X509TrustManager P0)
    {
        // str: "findTrustAnchorByIssuerAndSignature"
        // str: "method"
        // str: "trustManager"
        // call: Intrinsics.checkNotNullParameter
        // call: object.getClass
        // call: Type.getDeclaredMethod
        // call: Method.setAccessible
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pb95e9adf$p7ec86cb2.<init>
        // call: p419f3742.buildTrustRootIndex
        // type: X509Certificate
        // type: pb95e9adf$p7ec86cb2
        return default!;
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "protocols"
        // str: "sslSocket"
        // call: p7e5d37b6.matchesSocket
        // call: IEnumerator<object>.hasNext
        // call: Intrinsics.checkNotNullParameter
        // call: IEnumerator<object>.next
        // call: IEnumerable<object>.iterator
        // call: p7e5d37b6.configureTlsExtensions
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf.f16c7d849
    }

    public void ConnectSocket(Socket P0, InetSocketAddress P1, int P2)
    {
        // str: "socket"
        // str: "address"
        // call: Intrinsics.checkNotNullParameter
        // call: Socket.connect
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: "sslSocket"
        // call: IEnumerator<object>.hasNext
        // call: p7e5d37b6.getSelectedProtocol
        // call: Intrinsics.checkNotNullParameter
        // call: p7e5d37b6.matchesSocket
        // call: IEnumerator<object>.next
        // call: IEnumerable<object>.iterator
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf.f16c7d849
        return string.Empty;
    }

    public object GetStackTraceForCloseable(string P0)
    {
        // str: "closer"
        // call: Intrinsics.checkNotNullParameter
        // call: p8b368d79.createAndOpen
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf.f20d035db
        return default!;
    }

    public bool IsCleartextTrafficPermitted(string P0)
    {
        // str: "hostname"
        // call: NetworkSecurityPolicy.getInstance
        // call: NetworkSecurityPolicy.isCleartextTrafficPermitted
        // call: Intrinsics.checkNotNullParameter
        return false;
    }

    public void LogCloseableLeak(string P0, object P1)
    {
        // str: "message"
        // call: p419f3742.log$default
        // call: Intrinsics.checkNotNullParameter
        // call: p8b368d79.warnIfOpen
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf.f20d035db
    }

    public X509TrustManager TrustManager(SSLSocketFactory P0)
    {
        // str: "sslSocketFactory"
        // call: IEnumerable<object>.iterator
        // call: p7e5d37b6.trustManager
        // call: IEnumerator<object>.hasNext
        // call: Intrinsics.checkNotNullParameter
        // call: IEnumerator<object>.next
        // call: p7e5d37b6.matchesSocketFactory
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf.f16c7d849
        return default!;
    }

}
