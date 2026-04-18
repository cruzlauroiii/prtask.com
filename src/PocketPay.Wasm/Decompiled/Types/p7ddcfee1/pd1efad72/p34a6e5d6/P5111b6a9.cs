namespace WillowMaze.Wasm.Decompiled;

public class P5111b6a9 : P419f3742
{
    private static bool F142345d7;
    public static p5111b6a9$p910eef8c F27f84dbc;
    private static bool F6208c126;
    public static p5111b6a9$p910eef8c F7271a125;
    public static p5111b6a9$p910eef8c F8f9e49fb;
    public static p5111b6a9$p910eef8c F910eef8c;
    private static bool F9b29b748;
    public static p5111b6a9$p910eef8c Fb3615860;
    private readonly Provider F3893a504;
    private readonly Provider F5ae176fc;
    private readonly Provider F9e9f3d70;
    private readonly Provider Ff65e7989;

    public static bool Access$isSupported$cp()
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p5111b6a9.f6208c126
        return false;
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "protocols"
        // str: "sslSocket"
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // call: Intrinsics.checkNotNullParameter
        // call: p419f3742.configureTlsExtensions
        // call: SSLParameters.setApplicationProtocols
        // call: NullPointerException.<init>
        // call: SSLSocket.getSSLParameters
        // call: p419f3742$p910eef8c.alpnProtocolNames
        // call: SSLSocket.setSSLParameters
        // call: ICollection<object>.toArray
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // type: NullPointerException
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: ""
        // str: "sslSocket"
        // call: Intrinsics.checkNotNullParameter
        // call: p419f3742.getSelectedProtocol
        // call: Intrinsics.areEqual
        // call: SSLSocket.getApplicationProtocol
        return string.Empty;
    }

    public SSLContext NewSSLContext()
    {
        // str: "getInstance(\"TLSv1.3\", provider)"
        // str: "TLSv1.3"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: SSLContext.getInstance
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p5111b6a9.f9e9f3d70
        return default!;
    }

    public X509TrustManager PlatformTrustManager()
    {
        // str: "toString(this)"
        // str: "Unexpected default trust managers: "
        // str: "null cannot be cast to non-null type javax.net.ssl.X509TrustManager"
        // call: TrustManagerFactory.getTrustManagers
        // call: NullPointerException.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // call: object.toString
        // call: Arrays.toString
        // call: TrustManagerFactory.init
        // call: TrustManagerFactory.getInstance
        // call: IllegalStateException.<init>
        // call: Intrinsics.checkNotNull
        // call: Intrinsics.stringPlus
        // call: TrustManagerFactory.getDefaultAlgorithm
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p5111b6a9.f9e9f3d70
        // type: NullPointerException
        // type: IllegalStateException
        return default!;
    }

    public X509TrustManager TrustManager(SSLSocketFactory P0)
    {
        // str: "sslSocketFactory"
        // str: "clientBuilder.sslSocketFactory(SSLSocketFactory) not supported with OpenJSSE"
        // call: UnsupportedOperationException.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: UnsupportedOperationException
        return default!;
    }

}
