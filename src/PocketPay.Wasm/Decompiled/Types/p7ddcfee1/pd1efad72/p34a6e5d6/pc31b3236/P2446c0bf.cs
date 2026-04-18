namespace WillowMaze.Wasm.Decompiled;

public class P2446c0bf : P7e5d37b6
{
    public static p2446c0bf$p910eef8c F910eef8c;
    public static p2446c0bf$p910eef8c Fb9316fb8;

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "sslSocket"
        // str: "Android internal error"
        // str: "protocols"
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // call: Intrinsics.checkNotNullParameter
        // call: SSLSockets.setUseSessionTickets
        // call: SSLSocket.getSSLParameters
        // call: p419f3742$p910eef8c.alpnProtocolNames
        // call: ICollection<object>.toArray
        // call: SSLParameters.setApplicationProtocols
        // call: SSLSocket.setSSLParameters
        // call: NullPointerException.<init>
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // type: IOException
        // type: NullPointerException
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: "sslSocket"
        // str: ""
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.areEqual
        // call: SSLSocket.getApplicationProtocol
        return string.Empty;
    }

    public bool IsSupported()
    {
        // call: p2446c0bf$p910eef8c.isSupported
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p2446c0bf.f910eef8c
        return false;
    }

    public bool MatchesSocket(SSLSocket P0)
    {
        // str: "sslSocket"
        // call: SSLSockets.isSupportedSocket
        // call: Intrinsics.checkNotNullParameter
        return false;
    }

    public bool MatchesSocketFactory(SSLSocketFactory P0)
    {
        // call: p7e5d37b6$pb0da8397.matchesSocketFactory
        return false;
    }

    public X509TrustManager TrustManager(SSLSocketFactory P0)
    {
        // call: p7e5d37b6$pb0da8397.trustManager
        return default!;
    }

}
