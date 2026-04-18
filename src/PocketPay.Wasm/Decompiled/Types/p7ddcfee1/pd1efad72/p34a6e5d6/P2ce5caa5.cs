namespace WillowMaze.Wasm.Decompiled;

public class P2ce5caa5 : P419f3742
{
    private static bool F0ab22df4;
    private static bool F6e76364f;
    private static bool F7d8ac499;
    public static p2ce5caa5$p910eef8c F8a67f4ea;
    public static p2ce5caa5$p910eef8c F910eef8c;
    private static bool Fdc840557;

    public static bool Access$isAvailable$cp()
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p2ce5caa5.f6e76364f
        return false;
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // str: "protocols"
        // str: "sslSocket"
        // call: Intrinsics.checkNotNullParameter
        // call: p419f3742$p910eef8c.alpnProtocolNames
        // call: SSLSocket.getSSLParameters
        // call: NullPointerException.<init>
        // call: ICollection<object>.toArray
        // call: SSLParameters.setApplicationProtocols
        // call: SSLSocket.setSSLParameters
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // type: NullPointerException
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: ""
        // str: "sslSocket"
        // call: SSLSocket.getApplicationProtocol
        // call: Intrinsics.areEqual
        // call: Intrinsics.checkNotNullParameter
        return string.Empty;
    }

    public X509TrustManager TrustManager(SSLSocketFactory P0)
    {
        // str: "clientBuilder.sslSocketFactory(SSLSocketFactory) not supported on JDK 9+"
        // str: "sslSocketFactory"
        // call: Intrinsics.checkNotNullParameter
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

}
