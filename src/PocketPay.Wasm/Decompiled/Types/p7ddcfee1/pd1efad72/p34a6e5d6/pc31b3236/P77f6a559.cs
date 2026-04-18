namespace WillowMaze.Wasm.Decompiled;

public class P77f6a559 : P7e5d37b6
{
    private readonly p77f6a559$p1c6e980e F049b4410;
    private readonly p77f6a559$p1c6e980e F33044d14;
    private p7e5d37b6 F7f662005;
    private p7e5d37b6 F841e7393;
    private p7e5d37b6 Fbb8c829a;
    private p7e5d37b6 Fdff0996a;

    private p7e5d37b6 GetDelegate(SSLSocket P0)
    {
        // call: p77f6a559$p1c6e980e.matchesSocket
        // call: p77f6a559$p1c6e980e.create
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559.f7f662005
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559.f049b4410
        return default!;
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "protocols"
        // str: "sslSocket"
        // call: Intrinsics.checkNotNullParameter
        // call: p77f6a559.getDelegate
        // call: p7e5d37b6.configureTlsExtensions
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: "sslSocket"
        // call: p7e5d37b6.getSelectedProtocol
        // call: p77f6a559.getDelegate
        // call: Intrinsics.checkNotNullParameter
        return string.Empty;
    }

    public bool IsSupported()
    {
        return false;
    }

    public bool MatchesSocket(SSLSocket P0)
    {
        // str: "sslSocket"
        // call: p77f6a559$p1c6e980e.matchesSocket
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559.f049b4410
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
