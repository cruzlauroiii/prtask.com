namespace WillowMaze.Wasm.Decompiled;

public class P419f3742
{
    private static Logger F05209ad4;
    public static int F14aab8d7;
    public static int F32bd8a1d;
    private static p419f3742 F34a6e5d6;
    public static p419f3742$p910eef8c F35e40b88;
    private static p419f3742 F50577657;
    public static int F551b723e;
    private static Logger F5a7d693c;
    public static int F5d9c9e1a;
    private static Logger F6db435f3;
    public static p419f3742$p910eef8c F910eef8c;
    public static int F975b0156;
    private static Logger Fb37003e6;
    private static Logger Fc8f9d5f0;
    private static p419f3742 Fdd36b07a;
    public static int Fea41ed4c;
    public static int Ff4b9c6cf;

    public static p419f3742 Access$getPlatform$cp()
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f34a6e5d6
        return default!;
    }

    public static void Access$setPlatform$cp(p419f3742 P0)
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f34a6e5d6
    }

    public static p419f3742 Get()
    {
        // call: p419f3742$p910eef8c.get
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        return default!;
    }

    public static void Log$default(p419f3742 P0, string P1, int P2, Exception P3, int P4, object P5)
    {
        // str: "Super calls with default arguments not supported in this target, function: log"
        // call: p419f3742.log
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
    }

    public void AfterHandshake(SSLSocket P0)
    {
        // str: "sslSocket"
        // call: Intrinsics.checkNotNullParameter
    }

    public p2e948d4e BuildCertificateChainCleaner(X509TrustManager P0)
    {
        // str: "trustManager"
        // call: p52aeda23.<init>
        // call: p419f3742.buildTrustRootIndex
        // call: Intrinsics.checkNotNullParameter
        // type: p52aeda23
        return default!;
    }

    public p9989c878 BuildTrustRootIndex(X509TrustManager P0)
    {
        // str: "trustManager"
        // str: "trustManager.acceptedIssuers"
        // call: X509TrustManager.getAcceptedIssuers
        // call: Intrinsics.checkNotNullParameter
        // call: pb117aa27.<init>
        // call: Arrays.copyOf
        // call: Intrinsics.checkNotNullExpressionValue
        // type: pb117aa27
        return default!;
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "sslSocket"
        // str: "protocols"
        // call: Intrinsics.checkNotNullParameter
    }

    public void ConnectSocket(Socket P0, InetSocketAddress P1, int P2)
    {
        // str: "address"
        // str: "socket"
        // call: Socket.connect
        // call: Intrinsics.checkNotNullParameter
    }

    public string GetPrefix()
    {
        // str: "OkHttp"
        return string.Empty;
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: "sslSocket"
        // call: Intrinsics.checkNotNullParameter
        return string.Empty;
    }

    public object GetStackTraceForCloseable(string P0)
    {
        // str: "closer"
        // call: Intrinsics.checkNotNullParameter
        // call: Exception.<init>
        // call: Logger.isLoggable
        // field: java.util.logging.Level.FINE
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f6db435f3
        // type: Exception
        return default!;
    }

    public bool IsCleartextTrafficPermitted(string P0)
    {
        // str: "hostname"
        // call: Intrinsics.checkNotNullParameter
        return false;
    }

    public void Log(string P0, int P1, Exception P2)
    {
        // str: "message"
        // call: Logger.log
        // call: Intrinsics.checkNotNullParameter
        // field: java.util.logging.Level.INFO
        // field: java.util.logging.Level.WARNING
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f6db435f3
    }

    public void LogCloseableLeak(string P0, object P1)
    {
        // str: "message"
        // str: " To see where this was allocated, set the OkHttpClient logger level to FINE: Logger.getLogger(OkH..."
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.stringPlus
        // call: p419f3742.log
    }

    public SSLContext NewSSLContext()
    {
        // str: "getInstance(\"TLS\")"
        // str: "TLS"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: SSLContext.getInstance
        return default!;
    }

    public SSLSocketFactory NewSslSocketFactory(X509TrustManager P0)
    {
        // str: "trustManager"
        // str: "No System TLS: "
        // str: "newSSLContext().apply {\n…ll)\n      }.socketFactory"
        // call: AssertionError.<init>
        // call: Intrinsics.stringPlus
        // call: Intrinsics.checkNotNullParameter
        // call: p419f3742.newSSLContext
        // call: SSLContext.init
        // call: SSLContext.getSocketFactory
        // call: Intrinsics.checkNotNullExpressionValue
        // type: AssertionError
        return default!;
    }

    public X509TrustManager PlatformTrustManager()
    {
        // str: "Unexpected default trust managers: "
        // str: "null cannot be cast to non-null type javax.net.ssl.X509TrustManager"
        // str: "toString(this)"
        // call: Intrinsics.checkNotNull
        // call: Intrinsics.stringPlus
        // call: Arrays.toString
        // call: TrustManagerFactory.getTrustManagers
        // call: TrustManagerFactory.getInstance
        // call: IllegalStateException.<init>
        // call: NullPointerException.<init>
        // call: TrustManagerFactory.init
        // call: Intrinsics.checkNotNullExpressionValue
        // call: object.toString
        // call: TrustManagerFactory.getDefaultAlgorithm
        // type: NullPointerException
        // type: IllegalStateException
        return default!;
    }

    public string ToString()
    {
        // str: "javaClass.simpleName"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: object.getClass
        // call: Type.getSimpleName
        return string.Empty;
    }

    public X509TrustManager TrustManager(SSLSocketFactory P0)
    {
        // str: "java.lang.reflect.InaccessibleObjectException"
        // str: "sun.security.ssl.SSLContextImpl"
        // str: "sslContextClass"
        // str: "context"
        // str: "trustManager"
        // str: "sslSocketFactory"
        // call: object.getClass
        // call: Intrinsics.checkNotNullParameter
        // call: Type.getName
        // call: Type.forName
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p23e8a4b4.readFieldOrNull
        // call: Intrinsics.areEqual
        // type: X509TrustManager
        return default!;
    }

}
