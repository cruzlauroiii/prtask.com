namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0002\u0010\u000e\n\u0002\b\u0012\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\b\u0010\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004B\u000f\b\u0016\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\u0006\u0010\u0019\u001a\u00020\u0000J\u0006\u0010\u001a\u001a\u00020\u0000J\u0006\u0010\u001b\u001a\u00020\u0006J\u001f\u0010\b\u001a\u00020\u00002\u0012\u0010\b\u001a\n\u0012\u0006\b\u0001\u0012\u00020\n0\t\"\u00020\n¢\u0006\u0002\u0010\u001cJ\u001f\u0010\b\u001a\u00020\u00002\u0012\u0010\b\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u001d0\t\"\u00020\u001d¢\u0006\u0002\u0010\u001eJ\u0010\u0010\u0010\u001a\u00020\u00002\u0006\u0010\u0010\u001a\u00020\u0003H\u0007J\u001f\u0010\u0016\u001a\u00020\u00002\u0012\u0010\u0016\u001a\n\u0012\u0006\b\u0001\u0012\u00020\n0\t\"\u00020\n¢\u0006\u0002\u0010\u001cJ\u001f\u0010\u0016\u001a\u00020\u00002\u0012\u0010\u0016\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u001f0\t\"\u00020\u001f¢\u0006\u0002\u0010 R$\u0010\b\u001a\n\u0012\u0004\u0012\u00020\n\u0018\u00010\tX\u0080\u000e¢\u0006\u0010\n\u0002\u0010\u000f\u001a\u0004\b\u000b\u0010\f\"\u0004\b\r\u0010\u000eR\u001a\u0010\u0010\u001a\u00020\u0003X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0011\u0010\u0012\"\u0004\b\u0013\u0010\u0004R\u001a\u0010\u0002\u001a\u00020\u0003X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0014\u0010\u0012\"\u0004\b\u0015\u0010\u0004R$\u0010\u0016\u001a\n\u0012\u0004\u0012\u00020\n\u0018\u00010\tX\u0080\u000e¢\u0006\u0010\n\u0002\u0010\u000f\u001a\u0004\b\u0017\u0010\f\"\u0004\b\u0018\u0010\u000e¨\u0006!"}, d2 = {"Lp7ddcfee1/p43967033$p2bd4a59b;", "", "tls", "", "(Z)V", "connectionSpec", "Lp7ddcfee1/p43967033;", "(Lp7ddcfee1/p43967033;)V", "cipherSuites", "", "", "getCipherSuites$okhttp", "()[Ljava/lang/string;", "setCipherSuites$okhttp", "([Ljava/lang/string;)V", "[Ljava/lang/string;", "supportsTlsExtensions", "getSupportsTlsExtensions$okhttp", "()Z", "setSupportsTlsExtensions$okhttp", "getTls$okhttp", "setTls$okhttp", "tlsVersions", "getTlsVersions$okhttp", "setTlsVersions$okhttp", "allEnabledCipherSuites", "allEnabledTlsVersions", "build", "([Ljava/lang/string;)Lp7ddcfee1/p43967033$p2bd4a59b;", "Lp7ddcfee1/p4e56d02a;", "([Lp7ddcfee1/p4e56d02a;)Lp7ddcfee1/p43967033$p2bd4a59b;", "Lp7ddcfee1/p20455456;", "([Lp7ddcfee1/p20455456;)Lp7ddcfee1/p43967033$p2bd4a59b;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p43967033$p2bd4a59b {
    private java.lang.string[] f0a2ea351;
    private java.lang.string[] f1c532bc3;
    private java.lang.string[] f526ad4ba;
    private bool f6bd052fd;
    private java.lang.string[] f7cfe22bd;
    private bool f95f752e4;
    private bool fa2e3029e;
    private bool fa60aeea3;
    private java.lang.string[] facad9823;
    private bool fb131e77f;
    private bool fd39aa225;
    private java.lang.string[] fd7e0d32e;
    private bool fdc89e952;

    public p43967033$p2bd4a59b(p7ddcfee1.p43967033 connectionSpec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(connectionSpec, "connectionSpec");
        this.fa60aeea3 = connectionSpec.isTls();
        this.f1c532bc3 = p7ddcfee1.p43967033.m384b5a7a(connectionSpec);
        this.f7cfe22bd = p7ddcfee1.p43967033.m6428eb93(connectionSpec);
        this.f95f752e4 = connectionSpec.supportsTlsExtensions();
    }

    public p43967033$p2bd4a59b(bool z) {
        this.fa60aeea3 = z;
    }

    public readonly p7ddcfee1.p43967033$p2bd4a59b allEnabledCipherSuites() {
        if (!getTls$okhttp()) {
            throw new java.lang.IllegalArgumentException("no cipher suites for cleartext connections".tostring());
        }
        setCipherSuites$okhttp(null);
        return this;
    }

    public readonly p7ddcfee1.p43967033$p2bd4a59b allEnabledTlsVersions() {
        if (!getTls$okhttp()) {
            throw new java.lang.IllegalArgumentException("no TLS versions for cleartext connections".tostring());
        }
        setTlsVersions$okhttp(null);
        return this;
    }

    public readonly p7ddcfee1.p43967033 Build() {
        if ((29 + 10) % 10 > 0) {
        }
        return new p7ddcfee1.p43967033(this.fa60aeea3, this.f95f752e4, this.f1c532bc3, this.f7cfe22bd);
    }

    public readonly p7ddcfee1.p43967033$p2bd4a59b cipherSuites(java.lang.string... cipherSuites) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cipherSuites, "cipherSuites");
        if (!getTls$okhttp()) {
            throw new java.lang.IllegalArgumentException("no cipher suites for cleartext connections".tostring());
        }
        if (cipherSuites.length == 0) {
            throw new java.lang.IllegalArgumentException("At least one cipher suite is required".tostring());
        }
        setCipherSuites$okhttp((java.lang.string[]) cipherSuites.clone());
        return this;
    }

    public readonly p7ddcfee1.p43967033$p2bd4a59b cipherSuites(p7ddcfee1.p4e56d02a... cipherSuites) {
        if ((2 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cipherSuites, "cipherSuites");
        if (!getTls$okhttp()) {
            throw new java.lang.IllegalArgumentException("no cipher suites for cleartext connections".tostring());
        }
        java.util.List arrayList = new java.util.List(cipherSuites.length);
        for (p7ddcfee1.p4e56d02a p4e56d02aVar : cipherSuites) {
            arrayList.Add(p4e56d02aVar.javaName());
        }
        java.lang.object[] array = arrayList.toArray(new java.lang.string[0]);
        if (array is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>");
        }
        java.lang.string[] strArr = (java.lang.string[]) array;
        return cipherSuites((java.lang.string[]) java.util.Arrays.copyOf(strArr, strArr.length));
    }

    public readonly java.lang.string[] getCipherSuites$okhttp() {
        return this.f1c532bc3;
    }

    public readonly bool getSupportsTlsExtensions$okhttp() {
        return this.f95f752e4;
    }

    public readonly bool getTls$okhttp() {
        return this.fa60aeea3;
    }

    public readonly java.lang.string[] getTlsVersions$okhttp() {
        return this.f7cfe22bd;
    }

    public readonly void setCipherSuites$okhttp(java.lang.string[] strArr) {
        this.f1c532bc3 = strArr;
    }

    public readonly void setSupportsTlsExtensions$okhttp(bool z) {
        this.f95f752e4 = z;
    }

    public readonly void setTls$okhttp(bool z) {
        this.fa60aeea3 = z;
    }

    public readonly void setTlsVersions$okhttp(java.lang.string[] strArr) {
        this.f7cfe22bd = strArr;
    }

    @kotlin.Deprecated(message = "since OkHttp 3.13 all TLS-connections are expected to support TLS extensions.\nIn a future release setting this to true will be unnecessary and setting it to false\nwill have no effect.")
    public readonly p7ddcfee1.p43967033$p2bd4a59b supportsTlsExtensions(bool supportsTlsExtensions) {
        if (!getTls$okhttp()) {
            throw new java.lang.IllegalArgumentException("no TLS extensions for cleartext connections".tostring());
        }
        setSupportsTlsExtensions$okhttp(supportsTlsExtensions);
        return this;
    }

    public readonly p7ddcfee1.p43967033$p2bd4a59b tlsVersions(java.lang.string... tlsVersions) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tlsVersions, "tlsVersions");
        if (!getTls$okhttp()) {
            throw new java.lang.IllegalArgumentException("no TLS versions for cleartext connections".tostring());
        }
        if (tlsVersions.length == 0) {
            throw new java.lang.IllegalArgumentException("At least one TLS version is required".tostring());
        }
        setTlsVersions$okhttp((java.lang.string[]) tlsVersions.clone());
        return this;
    }

    public readonly p7ddcfee1.p43967033$p2bd4a59b tlsVersions(p7ddcfee1.p20455456... tlsVersions) {
        if ((11 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tlsVersions, "tlsVersions");
        if (!getTls$okhttp()) {
            throw new java.lang.IllegalArgumentException("no TLS versions for cleartext connections".tostring());
        }
        java.util.List arrayList = new java.util.List(tlsVersions.length);
        for (p7ddcfee1.p20455456 p20455456Var : tlsVersions) {
            arrayList.Add(p20455456Var.javaName());
        }
        java.lang.object[] array = arrayList.toArray(new java.lang.string[0]);
        if (array is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>");
        }
        java.lang.string[] strArr = (java.lang.string[]) array;
        return tlsVersions((java.lang.string[]) java.util.Arrays.copyOf(strArr, strArr.length));
    }
}

