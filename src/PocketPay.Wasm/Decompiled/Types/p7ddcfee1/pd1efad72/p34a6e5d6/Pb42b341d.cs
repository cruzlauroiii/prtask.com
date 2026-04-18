namespace WillowMaze.Wasm.Decompiled;

public class Pb42b341d : P419f3742
{
    public static pb42b341d$p910eef8c F54070b53;
    public static pb42b341d$p910eef8c F910eef8c;
    public static pb42b341d$p910eef8c Fc2b12a1b;
    private readonly Method F0b936d14;
    private readonly Method F1ce17be1;
    private readonly Method F41766231;
    private readonly Method F7d0b4fc5;
    private readonly Type F88e5699e;
    private readonly Type Fbbca7939;
    private readonly Method Fbe5cde35;
    private readonly Type Fd3a776b1;
    private readonly Method Fd40da09d;
    private readonly Type Fd830b1ec;
    private readonly Type Fdb0495a3;
    private readonly Method Fdb37f91f;
    private readonly Method Fe13a482d;
    private readonly Type Fed49ee89;
    private readonly Type Ff8c018d7;

    public void AfterHandshake(SSLSocket P0)
    {
        // str: "sslSocket"
        // str: "failed to remove ALPN"
        // call: Intrinsics.checkNotNullParameter
        // call: Method.invoke
        // call: AssertionError.<init>
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d.f41766231
        // type: AssertionError
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "failed to set ALPN"
        // str: "protocols"
        // str: "sslSocket"
        // call: Intrinsics.checkNotNullParameter
        // call: p419f3742$p910eef8c.alpnProtocolNames
        // call: Type.getClassLoader
        // call: pb42b341d$pe289f7c3.<init>
        // call: Proxy.newProxyInstance
        // call: Method.invoke
        // call: AssertionError.<init>
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d.fed49ee89
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d.fd3a776b1
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d.fd40da09d
        // type: p419f3742
        // type: pb42b341d$pe289f7c3
        // type: AssertionError
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: "sslSocket"
        // str: "ALPN callback dropped: HTTP/2 is disabled. Is alpn-boot on the boot class path?"
        // str: "null cannot be cast to non-null type okhttp3.internal.platform.Jdk8WithJettyBootPlatform.AlpnProv..."
        // str: "failed to get ALPN selected protocol"
        // call: AssertionError.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: Method.invoke
        // call: Proxy.getInvocationHandler
        // call: pb42b341d$pe289f7c3.getUnsupported
        // call: pb42b341d$pe289f7c3.getSelected
        // call: p419f3742.log$default
        // call: NullPointerException.<init>
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d.fdb37f91f
        // type: AssertionError
        // type: NullPointerException
        return string.Empty;
    }

}
