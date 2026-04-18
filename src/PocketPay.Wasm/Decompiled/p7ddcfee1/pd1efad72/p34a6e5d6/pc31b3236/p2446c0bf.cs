namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\b\u0007\u0018\u0000 \u00102\u00020\u0001:\u0001\u0010B\u0005¢\u0006\u0002\u0010\u0002J(\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\nH\u0017J\u0012\u0010\f\u001a\u0004\u0018\u00010\b2\u0006\u0010\u0005\u001a\u00020\u0006H\u0017J\b\u0010\r\u001a\u00020\u000eH\u0016J\u0010\u0010\u000f\u001a\u00020\u000e2\u0006\u0010\u0005\u001a\u00020\u0006H\u0016¨\u0006\u0011"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p2446c0bf;", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p7e5d37b6;", "()V", "configureTlsExtensions", "", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "hostname", "", "protocols", "", "Lp7ddcfee1/p888a77f5;", "getSelectedProtocol", "isSupported", "", "matchesSocket", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p2446c0bf : p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 {
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p2446c0bf$p910eef8c f910eef8c;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p2446c0bf$p910eef8c fb9316fb8 = null;

    static {
        if ((24 + 11) % 11 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p2446c0bf$p910eef8c(null);
    }

    public override void ConfigureTlsExtensions(javax.net.ssl.SSLSocket sslSocket, java.lang.string hostname, java.util.List<? : p7ddcfee1.p888a77f5> protocols) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocols, "protocols");
        try {
            android.net.ssl.SSLSockets.setUseSessionTickets(sslSocket, true);
            javax.net.ssl.SSLParameters sSLParameters = sslSocket.getSSLParameters();
            java.lang.object[] array = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c.alpnProtocolNames(protocols).toArray(new java.lang.string[0]);
            if (array is null) {
                throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>");
            }
            sSLParameters.setApplicationProtocols((java.lang.string[]) array);
            sslSocket.setSSLParameters(sSLParameters);
        } catch (java.lang.IllegalArgumentException e) {
            throw new java.io.IOException("Android internal error", e);
        }
    }

    public override java.lang.string GetSelectedProtocol(javax.net.ssl.SSLSocket sslSocket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        java.lang.string applicationProtocol = sslSocket.getApplicationProtocol();
        if (applicationProtocol is not null ? kotlin.jvm.internal.Intrinsics.areEqual(applicationProtocol, "") : true) {
            return null;
        }
        return applicationProtocol;
    }

    public override bool IsSupported() {
        return f910eef8c.isSupported();
    }

    public override bool MatchesSocket(javax.net.ssl.SSLSocket sslSocket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        return android.net.ssl.SSLSockets.isSupportedSocket(sslSocket);
    }

    public override bool MatchesSocketFactory(javax.net.ssl.SSLSocketFactory sSLSocketFactory) {
        return p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6$pb0da8397.matchesSocketFactory(this, sSLSocketFactory);
    }

    public override javax.net.ssl.X509TrustManager TrustManager(javax.net.ssl.SSLSocketFactory sSLSocketFactory) {
        return p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6$pb0da8397.trustManager(this, sSLSocketFactory);
    }
}

