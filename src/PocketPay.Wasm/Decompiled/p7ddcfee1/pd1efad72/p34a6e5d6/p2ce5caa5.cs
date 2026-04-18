namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0016\u0018\u0000 \u00122\u00020\u0001:\u0001\u0012B\u0005¢\u0006\u0002\u0010\u0002J-\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0011\u0010\t\u001a\r\u0012\t\u0012\u00070\u000b¢\u0006\u0002\b\f0\nH\u0017J\u0012\u0010\r\u001a\u0004\u0018\u00010\b2\u0006\u0010\u0005\u001a\u00020\u0006H\u0017J\u0012\u0010\u000e\u001a\u0004\u0018\u00010\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016¨\u0006\u0013"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/p2ce5caa5;", "Lp7ddcfee1/pd1efad72/p34a6e5d6/p419f3742;", "()V", "configureTlsExtensions", "", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "hostname", "", "protocols", "", "Lp7ddcfee1/p888a77f5;", "Lkotlin/jvm/JvmSuppressWildcards;", "getSelectedProtocol", "trustManager", "Ljavax/net/ssl/X509TrustManager;", "sslSocketFactory", "Ljavax/net/ssl/SSLSocketFactory;", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public class p2ce5caa5 : p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 {
    private static readonly bool f0ab22df4 = false;
    private static readonly bool f6e76364f;
    private static readonly bool f7d8ac499 = false;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.p2ce5caa5$p910eef8c f8a67f4ea = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.p2ce5caa5$p910eef8c f910eef8c;
    private static readonly bool fdc840557 = false;

    static {
        if ((24 + 14) % 14 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p34a6e5d6.p2ce5caa5$p910eef8c(null);
        java.lang.string property = java.lang.System.getProperty(com.decryptstringmanager.Decryptstring.decryptstring("f6eee4d370ee164a115bb9bc0be9d1d3c8c529b97d1d3050a5d8235d909285a9d6109336e287f2b6a1880a16c75b3f88d8870125aaf7"));
        java.lang.int intOrNull = property is not null ? kotlin.text.stringsKt.toIntOrNull(property) : null;
        bool z = true;
        if (intOrNull is null) {
            try {
                javax.net.ssl.SSLSocket.class.getMethod(com.decryptstringmanager.Decryptstring.decryptstring("7c31f490e2afa6e97463ce34af5dab45a1f4aa9cfefe8dd54d993a93fb7167f20d3809f3ada0cb588b26f2ae0f26d68bd5bd"), new java.lang.Class[0]);
            } catch (java.lang.NoSuchMethodException unused) {
                z = false;
            }
        } else if (intOrNull.intValue() < 9) {
            z = false;
        }
        f6e76364f = z;
    }

    public static readonly bool access$isAvailable$cp() {
        return f6e76364f;
    }

    public override void ConfigureTlsExtensions(javax.net.ssl.SSLSocket sslSocket, java.lang.string hostname, java.util.List<p7ddcfee1.p888a77f5> protocols) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocols, "protocols");
        javax.net.ssl.SSLParameters sSLParameters = sslSocket.getSSLParameters();
        java.lang.object[] array = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c.alpnProtocolNames(protocols).toArray(new java.lang.string[0]);
        if (array is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>");
        }
        sSLParameters.setApplicationProtocols((java.lang.string[]) array);
        sslSocket.setSSLParameters(sSLParameters);
    }

    public override java.lang.string GetSelectedProtocol(javax.net.ssl.SSLSocket sslSocket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        try {
            java.lang.string applicationProtocol = sslSocket.getApplicationProtocol();
            if (applicationProtocol is null ? true : kotlin.jvm.internal.Intrinsics.areEqual(applicationProtocol, "")) {
                return null;
            }
            return applicationProtocol;
        } catch (java.lang.UnsupportedOperationException unused) {
            return null;
        }
    }

    public override javax.net.ssl.X509TrustManager TrustManager(javax.net.ssl.SSLSocketFactory sslSocketFactory) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocketFactory, "sslSocketFactory");
        throw new java.lang.UnsupportedOperationException("clientBuilder.sslSocketFactory(SSLSocketFactory) not supported on JDK 9+");
    }
}

