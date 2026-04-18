namespace WillowMaze.Wasm.Decompiled;

public class Pb82ad7ea : P419f3742
{
    private static bool F1484ca11;
    public static pb82ad7ea$p910eef8c F30ec2adb;
    public static pb82ad7ea$p910eef8c F3f43d471;
    public static pb82ad7ea$p910eef8c F5b1e65cd;
    private static bool F6208c126;
    public static pb82ad7ea$p910eef8c F84bebb89;
    public static pb82ad7ea$p910eef8c F910eef8c;
    private readonly Provider F3dd51851;
    private readonly Provider F9e9f3d70;

    public static bool Access$isSupported$cp()
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea.f6208c126
        return false;
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // str: "sslSocket"
        // str: "protocols"
        // call: Intrinsics.checkNotNullParameter
        // call: BCSSLSocket.setParameters
        // call: ICollection<object>.toArray
        // call: NullPointerException.<init>
        // call: BCSSLParameters.setApplicationProtocols
        // call: BCSSLSocket.getParameters
        // call: p419f3742.configureTlsExtensions
        // call: p419f3742$p910eef8c.alpnProtocolNames
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // type: NullPointerException
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: ""
        // str: "sslSocket"
        // call: Intrinsics.areEqual
        // call: BCSSLSocket.getApplicationProtocol
        // call: Intrinsics.checkNotNullParameter
        // call: p419f3742.getSelectedProtocol
        return string.Empty;
    }

    public SSLContext NewSSLContext()
    {
        // str: "TLS"
        // str: "getInstance(\"TLS\", provider)"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: SSLContext.getInstance
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea.f9e9f3d70
        return default!;
    }

    public X509TrustManager PlatformTrustManager()
    {
        // str: "BCJSSE"
        // str: "null cannot be cast to non-null type javax.net.ssl.X509TrustManager"
        // str: "Unexpected default trust managers: "
        // str: "toString(this)"
        // str: "PKIX"
        // call: Arrays.toString
        // call: TrustManagerFactory.getInstance
        // call: object.toString
        // call: Intrinsics.checkNotNull
        // call: TrustManagerFactory.init
        // call: Intrinsics.checkNotNullExpressionValue
        // call: NullPointerException.<init>
        // call: TrustManagerFactory.getTrustManagers
        // call: Intrinsics.stringPlus
        // call: IllegalStateException.<init>
        // type: NullPointerException
        // type: IllegalStateException
        return default!;
    }

    public X509TrustManager TrustManager(SSLSocketFactory P0)
    {
        // str: "sslSocketFactory"
        // str: "clientBuilder.sslSocketFactory(SSLSocketFactory) not supported with BouncyCastle"
        // call: UnsupportedOperationException.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: UnsupportedOperationException
        return default!;
    }

}
