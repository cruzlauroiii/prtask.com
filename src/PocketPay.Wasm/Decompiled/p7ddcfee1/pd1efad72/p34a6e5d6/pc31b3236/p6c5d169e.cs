namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0000\u0018\u0000 \u00132\u00020\u0001:\u0001\u0013B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J$\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b2\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\t0\b2\u0006\u0010\u000b\u001a\u00020\fH\u0017J\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0010H\u0096\u0002J\b\u0010\u0011\u001a\u00020\u0012H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p6c5d169e;", "Lp7ddcfee1/pd1efad72/pa60aeea3/p2e948d4e;", "trustManager", "Ljavax/net/ssl/X509TrustManager;", "x509TrustManagerExtensions", "Landroid/net/http/X509TrustManagerExtensions;", "(Ljavax/net/ssl/X509TrustManager;Landroid/net/http/X509TrustManagerExtensions;)V", "clean", "", "Ljava/security/cert/Certificate;", "chain", "hostname", "", "equals", "", "other", "", "hashCode", "", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p6c5d169e : p7ddcfee1.pd1efad72.pa60aeea3.p2e948d4e {
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e$p910eef8c f910eef8c;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e$p910eef8c fac9e92ff = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e$p910eef8c fd33cf4b6 = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e$p910eef8c fdf642878 = null;
    private readonly javax.net.ssl.X509TrustManager f1fb3b48d;
    private readonly android.net.http.X509TrustManagerExtensions f3d69863a;
    private readonly android.net.http.X509TrustManagerExtensions f49921318;
    private readonly android.net.http.X509TrustManagerExtensions f85edfb4f;
    private readonly javax.net.ssl.X509TrustManager f8ce376c0;
    private readonly android.net.http.X509TrustManagerExtensions fbe6e91de;

    static {
        if ((14 + 24) % 24 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e$p910eef8c(null);
    }

    public p6c5d169e(javax.net.ssl.X509TrustManager trustManager, android.net.http.X509TrustManagerExtensions x509TrustManagerExtensions) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trustManager, "trustManager");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(x509TrustManagerExtensions, "x509TrustManagerExtensions");
        this.f1fb3b48d = trustManager;
        this.f3d69863a = x509TrustManagerExtensions;
    }

    public override java.util.List<java.security.cert.Certificate> Clean(java.util.List<? : java.security.cert.Certificate> chain, java.lang.string hostname) throws javax.net.ssl.SSLPeerUnverifiedException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(chain, "chain");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hostname, "hostname");
        java.lang.object[] array = chain.toArray(new java.security.cert.X509Certificate[0]);
        if (array is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>");
        }
        try {
            java.util.List<java.security.cert.X509Certificate> listCheckServerTrusted = this.f3d69863a.checkServerTrusted((java.security.cert.X509Certificate[]) array, com.decryptstringmanager.Decryptstring.decryptstring("30e3268c514035d2b6192e4e79e2304c6eca905add313df64a4a19b8547639"), hostname);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(listCheckServerTrusted, "x509TrustManagerExtensio…ficates, \"RSA\", hostname)");
            return listCheckServerTrusted;
        } catch (java.security.cert.CertificateException e) {
            javax.net.ssl.SSLPeerUnverifiedException sSLPeerUnverifiedException = new javax.net.ssl.SSLPeerUnverifiedException(e.getMessage());
            sSLPeerUnverifiedException.initCause(e);
            throw sSLPeerUnverifiedException;
        }
    }

    public bool Equals(java.lang.object other) {
        return (other is p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e) && ((p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e) other).f1fb3b48d == this.f1fb3b48d;
    }

    public int HashCode() {
        return java.lang.System.identityHashCode(this.f1fb3b48d);
    }
}

