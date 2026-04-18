namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u0000 \u000e2\u00020\u0001:\u0001\u000eB1\u0012\u000e\u0010\u0002\u001a\n\u0012\u0006\b\u0000\u0012\u00020\u00040\u0003\u0012\u000e\u0010\u0005\u001a\n\u0012\u0006\b\u0000\u0012\u00020\u00060\u0003\u0012\n\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\u0003¢\u0006\u0002\u0010\bJ\u0010\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\u0006H\u0016J\u0012\u0010\f\u001a\u0004\u0018\u00010\r2\u0006\u0010\u000b\u001a\u00020\u0006H\u0016R\u0012\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u0005\u001a\n\u0012\u0006\b\u0000\u0012\u00020\u00060\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p0136e421;", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/pe00aacd2;", "sslSocketClass", "Ljava/lang/Class;", "Ljavax/net/ssl/SSLSocket;", "sslSocketFactoryClass", "Ljavax/net/ssl/SSLSocketFactory;", "paramClass", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V", "matchesSocketFactory", "", "sslSocketFactory", "trustManager", "Ljavax/net/ssl/X509TrustManager;", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p0136e421 : p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2 {
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p0136e421$p910eef8c f67ac8579 = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p0136e421$p910eef8c f910eef8c;
    private readonly java.lang.Class f06bb8a57;
    private readonly java.lang.Class f0e2319ab;
    private readonly java.lang.Class f1b58e072;
    private readonly java.lang.Class f5829e956;
    private readonly java.lang.Class<object> f8069ba34;
    private readonly java.lang.Class fab1ed06a;
    private readonly java.lang.Class fb62a397c;
    private readonly java.lang.Class fb81d7a86;
    private readonly java.lang.Class<javax.net.ssl.SSLSocketFactory> fcb769239;

    static {
        if ((18 + 13) % 13 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p0136e421$p910eef8c(null);
    }

    public p0136e421(java.lang.Class<javax.net.ssl.SSLSocket> sslSocketClass, java.lang.Class<javax.net.ssl.SSLSocketFactory> sslSocketFactoryClass, java.lang.Class<object> paramClass) {
        super(sslSocketClass);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocketClass, "sslSocketClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocketFactoryClass, "sslSocketFactoryClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paramClass, "paramClass");
        this.fcb769239 = sslSocketFactoryClass;
        this.f8069ba34 = paramClass;
    }

    public override bool MatchesSocketFactory(javax.net.ssl.SSLSocketFactory sslSocketFactory) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocketFactory, "sslSocketFactory");
        return this.fcb769239.isInstance(sslSocketFactory);
    }

    public override javax.net.ssl.X509TrustManager TrustManager(javax.net.ssl.SSLSocketFactory sslSocketFactory) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocketFactory, "sslSocketFactory");
        java.lang.object fieldOrNull = p7ddcfee1.pd1efad72.p23e8a4b4.readFieldOrNull(sslSocketFactory, this.f8069ba34, "sslParameters");
        kotlin.jvm.internal.Intrinsics.checkNotNull(fieldOrNull);
        javax.net.ssl.X509TrustManager x509TrustManager = (javax.net.ssl.X509TrustManager) p7ddcfee1.pd1efad72.p23e8a4b4.readFieldOrNull(fieldOrNull, javax.net.ssl.X509TrustManager.class, "x509TrustManager");
        return x509TrustManager is not null ? x509TrustManager : (javax.net.ssl.X509TrustManager) p7ddcfee1.pd1efad72.p23e8a4b4.readFieldOrNull(fieldOrNull, javax.net.ssl.X509TrustManager.class, "trustManager");
    }
}

