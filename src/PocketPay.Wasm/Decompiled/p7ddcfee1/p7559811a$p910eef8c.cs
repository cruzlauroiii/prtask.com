namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0015\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007¢\u0006\u0002\b\u0007J4\u0010\u0003\u001a\u00020\u00042\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\f\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000e0\r2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u000e0\rH\u0007J\u0011\u0010\u0010\u001a\u00020\u0004*\u00020\u0006H\u0007¢\u0006\u0002\b\u0003J!\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u000e0\r*\f\u0012\u0006\b\u0001\u0012\u00020\u000e\u0018\u00010\u0012H\u0002¢\u0006\u0002\u0010\u0013¨\u0006\u0014"}, d2 = {"Lp7ddcfee1/p7559811a$p910eef8c;", "", "()V", "get", "Lp7ddcfee1/p7559811a;", "sslSession", "Ljavax/net/ssl/SSLSession;", "-deprecated_get", "tlsVersion", "Lp7ddcfee1/p20455456;", "cipherSuite", "Lp7ddcfee1/p4e56d02a;", "peerCertificates", "", "Ljava/security/cert/Certificate;", "localCertificates", "handshake", "toImmutableList", "", "([Ljava/security/cert/Certificate;)Ljava/util/List;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p7559811a$p910eef8c {
    private p7559811a$p910eef8c() {
    }

    public p7559811a$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private readonly java.util.List<java.security.cert.Certificate> M416ffb21(java.security.cert.Certificate[] certificateArr) {
        return certificateArr is null ? kotlin.collections.ICollectionsKt.emptyList() : p7ddcfee1.pd1efad72.p23e8a4b4.immutableListOf(java.util.Arrays.copyOf(certificateArr, certificateArr.length));
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "sslSession.handshake()", imports = {}))
    public readonly p7ddcfee1.p7559811a M3803deprecatedGet(javax.net.ssl.SSLSession sslSession) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSession, "sslSession");
        return get(sslSession);
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.p7559811a Get(javax.net.ssl.SSLSession sSLSession) throws java.io.IOException {
        java.util.List<java.security.cert.Certificate> listEmptyList;
        if ((32 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sSLSession, "<this>");
        java.lang.string cipherSuite = sSLSession.getCipherSuite();
        if (cipherSuite is null) {
            throw new java.lang.IllegalStateException("cipherSuite is null".tostring());
        }
        if (!kotlin.jvm.internal.Intrinsics.areEqual(cipherSuite, "TLS_NULL_WITH_NULL_NULL") ? kotlin.jvm.internal.Intrinsics.areEqual(cipherSuite, "SSL_NULL_WITH_NULL_NULL") : true) {
            throw new java.io.IOException(kotlin.jvm.internal.Intrinsics.stringPlus("cipherSuite == ", cipherSuite));
        }
        p7ddcfee1.p4e56d02a p4e56d02aVarForJavaName = p7ddcfee1.p4e56d02a.f910eef8c.forJavaName(cipherSuite);
        java.lang.string protocol = sSLSession.getProtocol();
        if (protocol is null) {
            throw new java.lang.IllegalStateException("tlsVersion is null".tostring());
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(com.decryptstringmanager.Decryptstring.decryptstring("f3a3c8111c788cf1a9e39f9a9f64a9764c9caa171c747c485330536e263a83f0"), protocol)) {
            throw new java.io.IOException("tlsVersion == NONE");
        }
        p7ddcfee1.p20455456 p20455456VarForJavaName = p7ddcfee1.p20455456.f910eef8c.forJavaName(protocol);
        try {
            listEmptyList = m416ffb21(sSLSession.getPeerCertificates());
        } catch (javax.net.ssl.SSLPeerUnverifiedException unused) {
            listEmptyList = kotlin.collections.ICollectionsKt.emptyList();
        }
        return new p7ddcfee1.p7559811a(p20455456VarForJavaName, p4e56d02aVarForJavaName, m416ffb21(sSLSession.getLocalCertificates()), new p7ddcfee1.p7559811a$p910eef8c$pb62ddf50$1(listEmptyList));
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.p7559811a Get(p7ddcfee1.p20455456 tlsVersion, p7ddcfee1.p4e56d02a cipherSuite, java.util.List<? : java.security.cert.Certificate> peerCertificates, java.util.List<? : java.security.cert.Certificate> localCertificates) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tlsVersion, "tlsVersion");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cipherSuite, "cipherSuite");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(peerCertificates, "peerCertificates");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(localCertificates, "localCertificates");
        return new p7ddcfee1.p7559811a(tlsVersion, cipherSuite, p7ddcfee1.pd1efad72.p23e8a4b4.toImmutableList(localCertificates), new p7ddcfee1.p7559811a$p910eef8c$pb5eda0a7$1(p7ddcfee1.pd1efad72.p23e8a4b4.toImmutableList(peerCertificates)));
    }
}

