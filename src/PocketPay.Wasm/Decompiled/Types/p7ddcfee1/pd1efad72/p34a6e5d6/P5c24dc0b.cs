namespace WillowMaze.Wasm.Decompiled;

public class P5c24dc0b : P419f3742
{
    public static p5c24dc0b$p910eef8c F09b1a31f;
    public static p5c24dc0b$p910eef8c F120664dd;
    public static p5c24dc0b$p910eef8c F1ab41e8e;
    private static bool F287225c5;
    private static bool F6208c126;
    public static p5c24dc0b$p910eef8c F910eef8c;
    private static bool Fad0fabe8;
    public static p5c24dc0b$p910eef8c Fe541bbb4;
    private readonly Provider F62df9f86;
    private readonly Provider F9e9f3d70;

    public static bool Access$isSupported$cp()
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b.f6208c126
        return false;
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "protocols"
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // str: "sslSocket"
        // call: Conscrypt.isConscrypt
        // call: NullPointerException.<init>
        // call: Conscrypt.setUseSessionTickets
        // call: ICollection<object>.toArray
        // call: p419f3742.configureTlsExtensions
        // call: Conscrypt.setApplicationProtocols
        // call: Intrinsics.checkNotNullParameter
        // call: p419f3742$p910eef8c.alpnProtocolNames
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // type: NullPointerException
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: "sslSocket"
        // call: Conscrypt.isConscrypt
        // call: Intrinsics.checkNotNullParameter
        // call: Conscrypt.getApplicationProtocol
        // call: p419f3742.getSelectedProtocol
        return string.Empty;
    }

    public SSLContext NewSSLContext()
    {
        // str: "getInstance(\"TLS\", provider)"
        // str: "TLS"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: SSLContext.getInstance
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b.f9e9f3d70
        return default!;
    }

    public SSLSocketFactory NewSslSocketFactory(X509TrustManager P0)
    {
        // str: "newSSLContext().apply {\n…null)\n    }.socketFactory"
        // str: "trustManager"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Intrinsics.checkNotNullParameter
        // call: p5c24dc0b.newSSLContext
        // call: SSLContext.init
        // call: SSLContext.getSocketFactory
        return default!;
    }

    public X509TrustManager PlatformTrustManager()
    {
        // str: "Unexpected default trust managers: "
        // str: "toString(this)"
        // str: "null cannot be cast to non-null type javax.net.ssl.X509TrustManager"
        // call: Intrinsics.stringPlus
        // call: TrustManagerFactory.init
        // call: object.toString
        // call: Conscrypt.setHostnameVerifier
        // call: Intrinsics.checkNotNull
        // call: TrustManagerFactory.getTrustManagers
        // call: IllegalStateException.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Arrays.toString
        // call: TrustManagerFactory.getInstance
        // call: NullPointerException.<init>
        // call: TrustManagerFactory.getDefaultAlgorithm
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b$p2c1ffbb0.f76425f17
        // type: IllegalStateException
        // type: NullPointerException
        return default!;
    }

    public X509TrustManager TrustManager(SSLSocketFactory P0)
    {
        // str: "sslSocketFactory"
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

}
