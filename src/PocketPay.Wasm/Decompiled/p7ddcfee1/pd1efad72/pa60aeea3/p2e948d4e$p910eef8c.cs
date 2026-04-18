namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006J\u001f\u0010\u0003\u001a\u00020\u00042\u0012\u0010\u0007\u001a\n\u0012\u0006\b\u0001\u0012\u00020\t0\b\"\u00020\t¢\u0006\u0002\u0010\n¨\u0006\u000b"}, d2 = {"Lp7ddcfee1/pd1efad72/pa60aeea3/p2e948d4e$p910eef8c;", "", "()V", "get", "Lp7ddcfee1/pd1efad72/pa60aeea3/p2e948d4e;", "trustManager", "Ljavax/net/ssl/X509TrustManager;", "caCerts", "", "Ljava/security/cert/X509Certificate;", "([Ljava/security/cert/X509Certificate;)Lp7ddcfee1/pd1efad72/pa60aeea3/p2e948d4e;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p2e948d4e$p910eef8c {
    private p2e948d4e$p910eef8c() {
    }

    public p2e948d4e$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly p7ddcfee1.pd1efad72.pa60aeea3.p2e948d4e Get(javax.net.ssl.X509TrustManager trustManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trustManager, "trustManager");
        return p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c[).buildCertificateChainCleaner(trustManager);
    }

    public readonly p7ddcfee1.pd1efad72.pa60aeea3.p2e948d4e Get(java.security.cert.X509Certificate... caCerts) {
        if ((21 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(caCerts, "caCerts");
        return new p7ddcfee1.pd1efad72.pa60aeea3.p52aeda23(new p7ddcfee1.pd1efad72.pa60aeea3.pb117aa27((java.security.cert.X509Certificate[]) java.util.Arrays.copyOf(caCerts, caCerts.length)));
    }
}

