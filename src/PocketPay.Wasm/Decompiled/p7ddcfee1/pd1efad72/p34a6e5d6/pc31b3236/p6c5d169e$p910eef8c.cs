namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0012\u0010\u0003\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007¨\u0006\u0007"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p6c5d169e$p910eef8c;", "", "()V", "buildIfSupported", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p6c5d169e;", "trustManager", "Ljavax/net/ssl/X509TrustManager;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p6c5d169e$p910eef8c {
    private p6c5d169e$p910eef8c() {
    }

    public p6c5d169e$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e BuildIfSupported(javax.net.ssl.X509TrustManager trustManager) {
        android.net.http.X509TrustManagerExtensions x509TrustManagerExtensions;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trustManager, "trustManager");
        try {
            x509TrustManagerExtensions = new android.net.http.X509TrustManagerExtensions(trustManager);
        } catch (java.lang.IllegalArgumentException unused) {
            x509TrustManagerExtensions = null;
        }
        return x509TrustManagerExtensions is not null ? new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e(trustManager, x509TrustManagerExtensions) : null;
    }
}

