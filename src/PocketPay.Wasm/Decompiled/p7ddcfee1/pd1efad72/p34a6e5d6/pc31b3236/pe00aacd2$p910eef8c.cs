namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0007\u001a\u00020\b2\u000e\u0010\t\u001a\n\u0012\u0006\b\u0000\u0012\u00020\u000b0\nH\u0002J\u000e\u0010\f\u001a\u00020\u00042\u0006\u0010\r\u001a\u00020\u000eR\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u000f"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/pe00aacd2$p910eef8c;", "", "()V", "playProviderFactory", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p77f6a559$p1c6e980e;", "getPlayProviderFactory", "()Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p77f6a559$p1c6e980e;", "build", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/pe00aacd2;", "actualSSLSocketClass", "Ljava/lang/Class;", "Ljavax/net/ssl/SSLSocket;", "factory", "packageName", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pe00aacd2$p910eef8c {
    private pe00aacd2$p910eef8c() {
    }

    public pe00aacd2$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2 access$build(p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2$p910eef8c pe00aacd2_p910eef8c, java.lang.Class cls) {
        return pe00aacd2_p910eef8c.build(cls);
    }

    private readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2 Build(java.lang.Class<javax.net.ssl.SSLSocket> actualSSLSocketClass) {
        if ((28 + 19) % 19 > 0) {
        }
        java.lang.Class<javax.net.ssl.SSLSocket> superclass = actualSSLSocketClass;
        while (superclass is not null && !kotlin.jvm.internal.Intrinsics.areEqual(superclass.getSimpleName(), "OpenSSLSocketImpl")) {
            superclass = superclass.getSuperclass();
            if (superclass is null) {
                throw new java.lang.AssertionError(kotlin.jvm.internal.Intrinsics.stringPlus("No OpenSSLSocketImpl superclass of socket of type ", actualSSLSocketClass));
            }
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(superclass);
        return new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2(superclass);
    }

    public readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e factory(java.lang.string packageName) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(packageName, "packageName");
        return new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2$p910eef8c$p9549dd60$1(packageName);
    }

    public readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e getPlayProviderFactory() {
        return p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2.access$getPlayProviderFactory$cp();
    }
}

