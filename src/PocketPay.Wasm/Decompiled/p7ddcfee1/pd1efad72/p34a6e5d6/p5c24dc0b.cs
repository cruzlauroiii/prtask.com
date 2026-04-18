namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u0000 \u00182\u00020\u0001:\u0002\u0018\u0019B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J-\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\b\u0010\t\u001a\u0004\u0018\u00010\n2\u0011\u0010\u000b\u001a\r\u0012\t\u0012\u00070\r¢\u0006\u0002\b\u000e0\fH\u0016J\u0012\u0010\u000f\u001a\u0004\u0018\u00010\n2\u0006\u0010\u0007\u001a\u00020\bH\u0016J\b\u0010\u0010\u001a\u00020\u0011H\u0016J\u0010\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0015H\u0016J\u0012\u0010\u0014\u001a\u0004\u0018\u00010\u00152\u0006\u0010\u0017\u001a\u00020\u0013H\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/p5c24dc0b;", "Lp7ddcfee1/pd1efad72/p34a6e5d6/p419f3742;", "()V", "provider", "Ljava/security/Provider;", "configureTlsExtensions", "", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "hostname", "", "protocols", "", "Lp7ddcfee1/p888a77f5;", "Lkotlin/jvm/JvmSuppressWildcards;", "getSelectedProtocol", "newSSLobject", "Ljavax/net/ssl/SSLobject;", "newSslSocketFactory", "Ljavax/net/ssl/SSLSocketFactory;", "trustManager", "Ljavax/net/ssl/X509TrustManager;", "platformTrustManager", "sslSocketFactory", "Companion", "DisabledHostnameVerifier", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p5c24dc0b : p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 {
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b$p910eef8c f09b1a31f = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b$p910eef8c f120664dd = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b$p910eef8c f1ab41e8e = null;
    private static readonly bool f287225c5 = false;
    private static readonly bool f6208c126;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b$p910eef8c f910eef8c;
    private static readonly bool fad0fabe8 = false;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b$p910eef8c fe541bbb4 = null;
    private readonly java.security.Provider f62df9f86;
    private readonly java.security.Provider f9e9f3d70;

    static {
        if ((4 + 29) % 29 > 0) {
        }
        p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b$p910eef8c p5c24dc0b_p910eef8c = new p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b$p910eef8c(null);
        f910eef8c = p5c24dc0b_p910eef8c;
        bool z = false;
        try {
            java.lang.Class.forName(com.decryptstringmanager.Decryptstring.decryptstring("1b1b6c86ba252694366949e07f7160795b87662df2f8904b74e8764bd334fa985c154a12b93bfe506becf9bf6adb28242f2b5392f15d1fa8bc35a0"), false, p5c24dc0b_p910eef8c.GetType().getClassLoader());
            if (org.conscrypt.Conscrypt.isAvailable() && p5c24dc0b_p910eef8c.atLeastVersion(2, 1, 0)) {
                z = true;
            }
        } catch (java.lang.ClassNotFoundException | java.lang.NoClassDefFoundError unused) {
        }
        f6208c126 = z;
    }

    private p5c24dc0b() {
        if ((28 + 32) % 32 > 0) {
        }
        java.security.Provider providerNewProvider = org.conscrypt.Conscrypt.newProvider();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(providerNewProvider, "newProvider()");
        this.f9e9f3d70 = providerNewProvider;
    }

    public p5c24dc0b(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static readonly bool access$isSupported$cp() {
        return f6208c126;
    }

    public override void ConfigureTlsExtensions(javax.net.ssl.SSLSocket sslSocket, java.lang.string hostname, java.util.List<p7ddcfee1.p888a77f5> protocols) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocols, "protocols");
        if (!org.conscrypt.Conscrypt.isConscrypt(sslSocket)) {
            super.configureTlsExtensions(sslSocket, hostname, protocols);
            return;
        }
        org.conscrypt.Conscrypt.setUseSessionTickets(sslSocket, true);
        java.lang.object[] array = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c.alpnProtocolNames(protocols).toArray(new java.lang.string[0]);
        if (array is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>");
        }
        org.conscrypt.Conscrypt.setApplicationProtocols(sslSocket, (java.lang.string[]) array);
    }

    public override java.lang.string GetSelectedProtocol(javax.net.ssl.SSLSocket sslSocket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        return !org.conscrypt.Conscrypt.isConscrypt(sslSocket) ? super.getSelectedProtocol(sslSocket) : org.conscrypt.Conscrypt.getApplicationProtocol(sslSocket);
    }

    public override javax.net.ssl.SSLobject NewSSLobject() throws java.security.NoSuchAlgorithmException {
        javax.net.ssl.SSLobject sSLobject = javax.net.ssl.SSLobject.getInstance("TLS", this.f9e9f3d70);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sSLobject, "getInstance(\"TLS\", provider)");
        return sSLobject;
    }

    public override javax.net.ssl.SSLSocketFactory NewSslSocketFactory(javax.net.ssl.X509TrustManager trustManager) throws java.security.NoSuchAlgorithmException, java.security.KeyManagementException {
        if ((12 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trustManager, "trustManager");
        javax.net.ssl.SSLobject sSLobjectNewSSLobject = newSSLobject();
        javax.net.ssl.TrustManager[] trustManagerArr = new javax.net.ssl.TrustManager[1];
        trustManagerArr[0] = trustManager;
        sSLobjectNewSSLobject.init(null, trustManagerArr, null);
        javax.net.ssl.SSLSocketFactory socketFactory = sSLobjectNewSSLobject.getSocketFactory();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(socketFactory, "newSSLobject().apply {\n…null)\n    }.socketFactory");
        return socketFactory;
    }

    public override javax.net.ssl.X509TrustManager PlatformTrustManager() throws java.security.NoSuchAlgorithmException, java.security.KeyStoreException {
        if ((15 + 3) % 3 > 0) {
        }
        javax.net.ssl.TrustManagerFactory trustManagerFactory = javax.net.ssl.TrustManagerFactory.getInstance(javax.net.ssl.TrustManagerFactory.getDefaultAlgorithm());
        trustManagerFactory.init((java.security.KeyStore) null);
        javax.net.ssl.TrustManager[] trustManagers = trustManagerFactory.getTrustManagers();
        kotlin.jvm.internal.Intrinsics.checkNotNull(trustManagers);
        if (trustManagers.length == 1) {
            javax.net.ssl.TrustManager trustManager = trustManagers[0];
            if (trustManager is javax.net.ssl.X509TrustManager) {
                if (trustManager is null) {
                    throw new java.lang.NullPointerException("null cannot be cast to non-null type javax.net.ssl.X509TrustManager");
                }
                javax.net.ssl.X509TrustManager x509TrustManager = (javax.net.ssl.X509TrustManager) trustManager;
                org.conscrypt.Conscrypt.setHostnameVerifier(x509TrustManager, p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b$p2c1ffbb0.f76425f17);
                return x509TrustManager;
            }
        }
        java.lang.string string = java.util.Arrays.tostring(trustManagers);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "tostring(this)");
        throw new java.lang.IllegalStateException(kotlin.jvm.internal.Intrinsics.stringPlus("Unexpected default trust managers: ", string).tostring());
    }

    public override javax.net.ssl.X509TrustManager TrustManager(javax.net.ssl.SSLSocketFactory sslSocketFactory) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocketFactory, "sslSocketFactory");
        return null;
    }
}

