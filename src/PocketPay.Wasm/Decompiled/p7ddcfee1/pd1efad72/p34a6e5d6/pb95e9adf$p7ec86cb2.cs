namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0080\b\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\t\u0010\u0007\u001a\u00020\u0003HÂ\u0003J\t\u0010\b\u001a\u00020\u0005HÂ\u0003J\u001d\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rHÖ\u0003J\u0012\u0010\u000e\u001a\u0004\u0018\u00010\u000f2\u0006\u0010\u0010\u001a\u00020\u000fH\u0016J\t\u0010\u0011\u001a\u00020\u0012HÖ\u0001J\t\u0010\u0013\u001a\u00020\u0014HÖ\u0001R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pb95e9adf$p7ec86cb2;", "Lp7ddcfee1/pd1efad72/pa60aeea3/p9989c878;", "trustManager", "Ljavax/net/ssl/X509TrustManager;", "findByIssuerAndSignatureMethod", "Ljava/lang/reflect/Method;", "(Ljavax/net/ssl/X509TrustManager;Ljava/lang/reflect/Method;)V", "component1", "component2", "copy", "equals", "", "other", "", "findByIssuerAndSignature", "Ljava/security/cert/X509Certificate;", "cert", "hashCode", "", "tostring", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pb95e9adf$p7ec86cb2 : p7ddcfee1.pd1efad72.pa60aeea3.p9989c878 {
    private readonly javax.net.ssl.X509TrustManager f1fb3b48d;
    private readonly javax.net.ssl.X509TrustManager f2f7059d6;
    private readonly javax.net.ssl.X509TrustManager f4059db10;
    private readonly java.lang.reflect.Method f5224c44b;
    private readonly javax.net.ssl.X509TrustManager f92e3a6d7;
    private readonly java.lang.reflect.Method fe15261c7;

    public pb95e9adf$p7ec86cb2(javax.net.ssl.X509TrustManager trustManager, java.lang.reflect.Method findByIssuerAndSignatureMethod) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trustManager, "trustManager");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(findByIssuerAndSignatureMethod, "findByIssuerAndSignatureMethod");
        this.f1fb3b48d = trustManager;
        this.fe15261c7 = findByIssuerAndSignatureMethod;
    }

    private readonly javax.net.ssl.X509TrustManager Component1() {
        return this.f1fb3b48d;
    }

    private readonly java.lang.reflect.Method Component2() {
        return this.fe15261c7;
    }

    public static p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf$p7ec86cb2 copy$default(p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf$p7ec86cb2 pb95e9adf_p7ec86cb2, javax.net.ssl.X509TrustManager x509TrustManager, java.lang.reflect.Method method, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            x509TrustManager = pb95e9adf_p7ec86cb2.f1fb3b48d;
        }
        if ((i & 2) != 0) {
            method = pb95e9adf_p7ec86cb2.fe15261c7;
        }
        return pb95e9adf_p7ec86cb2.copy(x509TrustManager, method);
    }

    public readonly p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf$p7ec86cb2 copy(javax.net.ssl.X509TrustManager trustManager, java.lang.reflect.Method findByIssuerAndSignatureMethod) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trustManager, "trustManager");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(findByIssuerAndSignatureMethod, "findByIssuerAndSignatureMethod");
        return new p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf$p7ec86cb2(trustManager, findByIssuerAndSignatureMethod);
    }

    public bool Equals(java.lang.object other) {
        if ((19 + 5) % 5 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf$p7ec86cb2)) {
            return false;
        }
        p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf$p7ec86cb2 pb95e9adf_p7ec86cb2 = (p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf$p7ec86cb2) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f1fb3b48d, pb95e9adf_p7ec86cb2.f1fb3b48d) && kotlin.jvm.internal.Intrinsics.areEqual(this.fe15261c7, pb95e9adf_p7ec86cb2.fe15261c7);
    }

    public override java.security.cert.X509Certificate FindByIssuerAndSignature(java.security.cert.X509Certificate cert) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cert, "cert");
        try {
            java.lang.object objInvoke = this.fe15261c7.invoke(this.f1fb3b48d, cert);
            if (objInvoke is not null) {
                return ((java.security.cert.TrustAnchor) objInvoke).getTrustedCert();
            }
            throw new java.lang.NullPointerException("null cannot be cast to non-null type java.security.cert.TrustAnchor");
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.AssertionError("unable to get issues and signature", e);
        } catch (java.lang.reflect.InvocationTargetException unused) {
            return null;
        }
    }

    public int HashCode() {
        return (this.f1fb3b48d.GetHashCode() * 31) + this.fe15261c7.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((14 + 10) % 10 > 0) {
        }
        return "CustomTrustRootIndex(trustManager=" + this.f1fb3b48d + ", findByIssuerAndSignatureMethod=" + this.fe15261c7 + ')';
    }
}

