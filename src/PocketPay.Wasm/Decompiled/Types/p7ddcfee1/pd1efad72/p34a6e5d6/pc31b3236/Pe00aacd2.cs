namespace WillowMaze.Wasm.Decompiled;

public class Pe00aacd2 : P7e5d37b6
{
    public static pe00aacd2$p910eef8c F2de5ff9b;
    public static pe00aacd2$p910eef8c F42d14877;
    public static pe00aacd2$p910eef8c F67233067;
    public static pe00aacd2$p910eef8c F910eef8c;
    private static p77f6a559$p1c6e980e Fb95a4146;
    private static p77f6a559$p1c6e980e Fbe22213f;
    private readonly Method F0d4ba24c;
    private readonly Method F199abca2;
    private readonly Method F3093f90c;
    private readonly Method F3a74fd3d;
    private readonly Method F42f8ed0d;
    private readonly Type F4b6bf3b4;
    private readonly Method F5675ba37;
    private readonly Method F5c271ae6;
    private readonly Method F6d57045c;
    private readonly Method F8419426f;
    private readonly Type F9a53bc41;
    private readonly Method Fab575846;
    private readonly Method Faedbb6f3;
    private readonly Method Fb430dcd1;
    private readonly Method Fb9577539;
    private readonly Method Fc514916c;
    private readonly Method Fc8861577;
    private readonly Type Fdfde81a6;

    public static p77f6a559$p1c6e980e Access$getPlayProviderFactory$cp()
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2.fb95a4146
        return default!;
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "sslSocket"
        // str: "protocols"
        // call: pe00aacd2.matchesSocket
        // call: bool.valueOf
        // call: Method.invoke
        // call: p419f3742$p910eef8c.concatLengthPrefixed
        // call: AssertionError.<init>
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2.fab575846
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2.f3a74fd3d
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2.fb9577539
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // type: AssertionError
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: "ssl == null"
        // str: "sslSocket"
        // call: NullPointerException.getMessage
        // call: AssertionError.<init>
        // call: pe00aacd2.matchesSocket
        // call: Intrinsics.areEqual
        // call: Method.invoke
        // call: string.<init>
        // call: InvocationTargetException.getCause
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2.f199abca2
        // field: kotlin.text.Charsets.UTF_8
        // type: AssertionError
        // type: string
        return string.Empty;
    }

    public bool IsSupported()
    {
        // call: pb95e9adf$p910eef8c.isSupported
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf.f910eef8c
        return false;
    }

    public bool MatchesSocket(SSLSocket P0)
    {
        // str: "sslSocket"
        // call: Type.isInstance
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2.f9a53bc41
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
