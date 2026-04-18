namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\u0018\u0000 \u00102\u00020\u0001:\u0001\u0010B\u0005¢\u0006\u0002\u0010\u0002J(\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\nH\u0016J\u0012\u0010\f\u001a\u0004\u0018\u00010\b2\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\b\u0010\r\u001a\u00020\u000eH\u0016J\u0010\u0010\u000f\u001a\u00020\u000e2\u0006\u0010\u0005\u001a\u00020\u0006H\u0016¨\u0006\u0011"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p39f7bd7b;", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p7e5d37b6;", "()V", "configureTlsExtensions", "", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "hostname", "", "protocols", "", "Lp7ddcfee1/p888a77f5;", "getSelectedProtocol", "isSupported", "", "matchesSocket", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p39f7bd7b : p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 {
    private static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e f4a38d766 = null;
    private static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e f641a4e34 = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p39f7bd7b$p910eef8c f7bbbf65d = null;
    private static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e f7becabbe = null;
    private static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e f82859aca = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p39f7bd7b$p910eef8c f910eef8c;
    private static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e f9549dd60;

    static {
        if ((12 + 2) % 2 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p39f7bd7b$p910eef8c(null);
        f9549dd60 = new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p39f7bd7b$p910eef8c$p9549dd60$1();
    }

    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e access$getFactory$cp() {
        return f9549dd60;
    }

    public override void ConfigureTlsExtensions(javax.net.ssl.SSLSocket sslSocket, java.lang.string hostname, java.util.List<? : p7ddcfee1.p888a77f5> protocols) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocols, "protocols");
        if (matchesSocket(sslSocket)) {
            org.bouncycastle.jsse.BCSSLSocket bCSSLSocket = (org.bouncycastle.jsse.BCSSLSocket) sslSocket;
            org.bouncycastle.jsse.BCSSLParameters parameters = bCSSLSocket.getParameters();
            java.lang.object[] array = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c.alpnProtocolNames(protocols).toArray(new java.lang.string[0]);
            if (array is null) {
                throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>");
            }
            parameters.setApplicationProtocols((java.lang.string[]) array);
            bCSSLSocket.setParameters(parameters);
        }
    }

    public override java.lang.string GetSelectedProtocol(javax.net.ssl.SSLSocket sslSocket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        java.lang.string applicationProtocol = ((org.bouncycastle.jsse.BCSSLSocket) sslSocket).getApplicationProtocol();
        if (applicationProtocol is not null ? kotlin.jvm.internal.Intrinsics.areEqual(applicationProtocol, "") : true) {
            return null;
        }
        return applicationProtocol;
    }

    public override bool IsSupported() {
        return p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea.f910eef8c.isSupported();
    }

    public override bool MatchesSocket(javax.net.ssl.SSLSocket sslSocket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        return sslSocket is org.bouncycastle.jsse.BCSSLSocket;
    }

    public override bool MatchesSocketFactory(javax.net.ssl.SSLSocketFactory sSLSocketFactory) {
        return p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6$pb0da8397.matchesSocketFactory(this, sSLSocketFactory);
    }

    public override javax.net.ssl.X509TrustManager TrustManager(javax.net.ssl.SSLSocketFactory sSLSocketFactory) {
        return p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6$pb0da8397.trustManager(this, sSLSocketFactory);
    }
}

