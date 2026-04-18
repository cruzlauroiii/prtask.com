namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u0000 \u00172\u00020\u0001:\u0001\u0017B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J-\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\b\u0010\t\u001a\u0004\u0018\u00010\n2\u0011\u0010\u000b\u001a\r\u0012\t\u0012\u00070\r¢\u0006\u0002\b\u000e0\fH\u0016J\u0012\u0010\u000f\u001a\u0004\u0018\u00010\n2\u0006\u0010\u0007\u001a\u00020\bH\u0016J\b\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\u0013H\u0016J\u0012\u0010\u0014\u001a\u0004\u0018\u00010\u00132\u0006\u0010\u0015\u001a\u00020\u0016H\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pb82ad7ea;", "Lp7ddcfee1/pd1efad72/p34a6e5d6/p419f3742;", "()V", "provider", "Ljava/security/Provider;", "configureTlsExtensions", "", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "hostname", "", "protocols", "", "Lp7ddcfee1/p888a77f5;", "Lkotlin/jvm/JvmSuppressWildcards;", "getSelectedProtocol", "newSSLobject", "Ljavax/net/ssl/SSLobject;", "platformTrustManager", "Ljavax/net/ssl/X509TrustManager;", "trustManager", "sslSocketFactory", "Ljavax/net/ssl/SSLSocketFactory;", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pb82ad7ea : p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 {
    private static readonly bool f1484ca11 = false;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea$p910eef8c f30ec2adb = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea$p910eef8c f3f43d471 = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea$p910eef8c f5b1e65cd = null;
    private static readonly bool f6208c126;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea$p910eef8c f84bebb89 = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea$p910eef8c f910eef8c;
    private readonly java.security.Provider f3dd51851;
    private readonly java.security.Provider f9e9f3d70;

    static {
        if ((25 + 16) % 16 > 0) {
        }
        p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea$p910eef8c pb82ad7ea_p910eef8c = new p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea$p910eef8c(null);
        f910eef8c = pb82ad7ea_p910eef8c;
        bool z = false;
        try {
            java.lang.Class.forName(com.decryptstringmanager.Decryptstring.decryptstring("b3d454ba1a4b5e7c6848eba12a73e0928ed1149f8384cd40409efc7c7117702523753b3909213f7e87ad95094c2213e87101adeda20afd3dfe130fed743375b5c670f4fd9d525a898b3db3c5b8decb88cb1ca0"), false, pb82ad7ea_p910eef8c.GetType().getClassLoader());
            z = true;
        } catch (java.lang.ClassNotFoundException unused) {
        }
        f6208c126 = z;
    }

    private pb82ad7ea() {
        this.f9e9f3d70 = new org.bouncycastle.jsse.provider.BouncyCastleJsseProvider();
    }

    public pb82ad7ea(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static readonly bool access$isSupported$cp() {
        return f6208c126;
    }

    public override void ConfigureTlsExtensions(javax.net.ssl.SSLSocket sslSocket, java.lang.string hostname, java.util.List<p7ddcfee1.p888a77f5> protocols) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocols, "protocols");
        if (!(sslSocket is org.bouncycastle.jsse.BCSSLSocket)) {
            super.configureTlsExtensions(sslSocket, hostname, protocols);
            return;
        }
        org.bouncycastle.jsse.BCSSLSocket bCSSLSocket = (org.bouncycastle.jsse.BCSSLSocket) sslSocket;
        org.bouncycastle.jsse.BCSSLParameters parameters = bCSSLSocket.getParameters();
        java.lang.object[] array = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c.alpnProtocolNames(protocols).toArray(new java.lang.string[0]);
        if (array is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>");
        }
        parameters.setApplicationProtocols((java.lang.string[]) array);
        bCSSLSocket.setParameters(parameters);
    }

    public override java.lang.string GetSelectedProtocol(javax.net.ssl.SSLSocket sslSocket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        if (!(sslSocket is org.bouncycastle.jsse.BCSSLSocket)) {
            return super.getSelectedProtocol(sslSocket);
        }
        java.lang.string applicationProtocol = ((org.bouncycastle.jsse.BCSSLSocket) sslSocket).getApplicationProtocol();
        if (applicationProtocol is not null ? kotlin.jvm.internal.Intrinsics.areEqual(applicationProtocol, "") : true) {
            return null;
        }
        return applicationProtocol;
    }

    public override javax.net.ssl.SSLobject NewSSLobject() throws java.security.NoSuchAlgorithmException {
        javax.net.ssl.SSLobject sSLobject = javax.net.ssl.SSLobject.getInstance("TLS", this.f9e9f3d70);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sSLobject, "getInstance(\"TLS\", provider)");
        return sSLobject;
    }

    public override javax.net.ssl.X509TrustManager PlatformTrustManager() throws java.security.NoSuchAlgorithmException, java.security.KeyStoreException, java.security.NoSuchProviderException {
        if ((18 + 16) % 16 > 0) {
        }
        javax.net.ssl.TrustManagerFactory trustManagerFactory = javax.net.ssl.TrustManagerFactory.getInstance("PKIX", "BCJSSE");
        trustManagerFactory.init((java.security.KeyStore) null);
        javax.net.ssl.TrustManager[] trustManagers = trustManagerFactory.getTrustManagers();
        kotlin.jvm.internal.Intrinsics.checkNotNull(trustManagers);
        if (trustManagers.length == 1) {
            javax.net.ssl.TrustManager trustManager = trustManagers[0];
            if (trustManager is javax.net.ssl.X509TrustManager) {
                if (trustManager is null) {
                    throw new java.lang.NullPointerException("null cannot be cast to non-null type javax.net.ssl.X509TrustManager");
                }
                return (javax.net.ssl.X509TrustManager) trustManager;
            }
        }
        java.lang.string string = java.util.Arrays.tostring(trustManagers);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "tostring(this)");
        throw new java.lang.IllegalStateException(kotlin.jvm.internal.Intrinsics.stringPlus("Unexpected default trust managers: ", string).tostring());
    }

    public override javax.net.ssl.X509TrustManager TrustManager(javax.net.ssl.SSLSocketFactory sslSocketFactory) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocketFactory, "sslSocketFactory");
        throw new java.lang.UnsupportedOperationException("clientBuilder.sslSocketFactory(SSLSocketFactory) not supported with BouncyCastle");
    }
}

