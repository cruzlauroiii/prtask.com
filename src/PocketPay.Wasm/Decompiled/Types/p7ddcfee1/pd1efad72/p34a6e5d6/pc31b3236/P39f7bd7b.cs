namespace WillowMaze.Wasm.Decompiled;

public class P39f7bd7b : P7e5d37b6
{
    private static p77f6a559$p1c6e980e F4a38d766;
    private static p77f6a559$p1c6e980e F641a4e34;
    public static p39f7bd7b$p910eef8c F7bbbf65d;
    private static p77f6a559$p1c6e980e F7becabbe;
    private static p77f6a559$p1c6e980e F82859aca;
    public static p39f7bd7b$p910eef8c F910eef8c;
    private static p77f6a559$p1c6e980e F9549dd60;

    public static p77f6a559$p1c6e980e Access$getFactory$cp()
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p39f7bd7b.f9549dd60
        return default!;
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "protocols"
        // str: "sslSocket"
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // call: Intrinsics.checkNotNullParameter
        // call: BCSSLSocket.getParameters
        // call: p419f3742$p910eef8c.alpnProtocolNames
        // call: BCSSLSocket.setParameters
        // call: ICollection<object>.toArray
        // call: NullPointerException.<init>
        // call: BCSSLParameters.setApplicationProtocols
        // call: p39f7bd7b.matchesSocket
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // type: NullPointerException
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: "sslSocket"
        // str: ""
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.areEqual
        // call: BCSSLSocket.getApplicationProtocol
        return string.Empty;
    }

    public bool IsSupported()
    {
        // call: pb82ad7ea$p910eef8c.isSupported
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea.f910eef8c
        return false;
    }

    public bool MatchesSocket(SSLSocket P0)
    {
        // str: "sslSocket"
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
