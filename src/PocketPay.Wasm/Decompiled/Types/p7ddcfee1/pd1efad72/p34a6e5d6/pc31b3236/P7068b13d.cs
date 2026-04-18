namespace WillowMaze.Wasm.Decompiled;

public class P7068b13d : P7e5d37b6
{
    public static p7068b13d$p910eef8c F065e65ae;
    public static p7068b13d$p910eef8c F0c7bab2e;
    public static p7068b13d$p910eef8c F687be414;
    public static p7068b13d$p910eef8c F910eef8c;
    private static p77f6a559$p1c6e980e F924101b5;
    private static p77f6a559$p1c6e980e F9549dd60;
    public static p7068b13d$p910eef8c F9a5cde13;
    private static p77f6a559$p1c6e980e Ffa76f504;

    public static p77f6a559$p1c6e980e Access$getFactory$cp()
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7068b13d.f9549dd60
        return default!;
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "protocols"
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // str: "sslSocket"
        // call: p7068b13d.matchesSocket
        // call: NullPointerException.<init>
        // call: ICollection<object>.toArray
        // call: Intrinsics.checkNotNullParameter
        // call: Conscrypt.setUseSessionTickets
        // call: p419f3742$p910eef8c.alpnProtocolNames
        // call: Conscrypt.setApplicationProtocols
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // type: NullPointerException
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: "sslSocket"
        // call: p7068b13d.matchesSocket
        // call: Intrinsics.checkNotNullParameter
        // call: Conscrypt.getApplicationProtocol
        return string.Empty;
    }

    public bool IsSupported()
    {
        // call: p5c24dc0b$p910eef8c.isSupported
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b.f910eef8c
        return false;
    }

    public bool MatchesSocket(SSLSocket P0)
    {
        // str: "sslSocket"
        // call: Intrinsics.checkNotNullParameter
        // call: Conscrypt.isConscrypt
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
