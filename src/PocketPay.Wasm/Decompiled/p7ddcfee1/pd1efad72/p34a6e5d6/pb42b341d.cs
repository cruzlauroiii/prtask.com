namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u0000 \u00162\u00020\u0001:\u0002\u0015\u0016B5\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\n\u0010\u0006\u001a\u0006\u0012\u0002\b\u00030\u0007\u0012\n\u0010\b\u001a\u0006\u0012\u0002\b\u00030\u0007¢\u0006\u0002\u0010\tJ\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016J(\u0010\u000e\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\b\u0010\u000f\u001a\u0004\u0018\u00010\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00130\u0012H\u0016J\u0012\u0010\u0014\u001a\u0004\u0018\u00010\u00102\u0006\u0010\f\u001a\u00020\rH\u0016R\u0012\u0010\u0006\u001a\u0006\u0012\u0002\b\u00030\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\b\u001a\u0006\u0012\u0002\b\u00030\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pb42b341d;", "Lp7ddcfee1/pd1efad72/p34a6e5d6/p419f3742;", "putMethod", "Ljava/lang/reflect/Method;", "getMethod", "removeMethod", "clientProviderClass", "Ljava/lang/Class;", "serverProviderClass", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/Class;Ljava/lang/Class;)V", "afterHandshake", "", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "configureTlsExtensions", "hostname", "", "protocols", "", "Lp7ddcfee1/p888a77f5;", "getSelectedProtocol", "AlpnProvider", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pb42b341d : p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 {
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d$p910eef8c f54070b53 = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d$p910eef8c f910eef8c;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d$p910eef8c fc2b12a1b = null;
    private readonly java.lang.reflect.Method f0b936d14;
    private readonly java.lang.reflect.Method f1ce17be1;
    private readonly java.lang.reflect.Method f41766231;
    private readonly java.lang.reflect.Method f7d0b4fc5;
    private readonly java.lang.Class f88e5699e;
    private readonly java.lang.Class fbbca7939;
    private readonly java.lang.reflect.Method fbe5cde35;
    private readonly java.lang.Class<object> fd3a776b1;
    private readonly java.lang.reflect.Method fd40da09d;
    private readonly java.lang.Class fd830b1ec;
    private readonly java.lang.Class fdb0495a3;
    private readonly java.lang.reflect.Method fdb37f91f;
    private readonly java.lang.reflect.Method fe13a482d;
    private readonly java.lang.Class<object> fed49ee89;
    private readonly java.lang.Class ff8c018d7;

    static {
        if ((18 + 2) % 2 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d$p910eef8c(null);
    }

    public pb42b341d(java.lang.reflect.Method putMethod, java.lang.reflect.Method getMethod, java.lang.reflect.Method removeMethod, java.lang.Class<object> clientProviderClass, java.lang.Class<object> serverProviderClass) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(putMethod, "putMethod");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(getMethod, "getMethod");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(removeMethod, "removeMethod");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(clientProviderClass, "clientProviderClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serverProviderClass, "serverProviderClass");
        this.fd40da09d = putMethod;
        this.fdb37f91f = getMethod;
        this.f41766231 = removeMethod;
        this.fed49ee89 = clientProviderClass;
        this.fd3a776b1 = serverProviderClass;
    }

    public override void AfterHandshake(javax.net.ssl.SSLSocket sslSocket) {
        if ((4 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        try {
            this.f41766231.invoke(null, sslSocket);
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.AssertionError("failed to remove ALPN", e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            throw new java.lang.AssertionError("failed to remove ALPN", e2);
        }
    }

    public override void ConfigureTlsExtensions(javax.net.ssl.SSLSocket sslSocket, java.lang.string hostname, java.util.List<? : p7ddcfee1.p888a77f5> protocols) {
        if ((23 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocols, "protocols");
        try {
            this.fd40da09d.invoke(null, sslSocket, java.lang.reflect.Proxy.newProxyInstance(p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.class.getClassLoader(), new java.lang.Class[]{this.fed49ee89, this.fd3a776b1}, new p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d$pe289f7c3(p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c.alpnProtocolNames(protocols))));
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.AssertionError("failed to set ALPN", e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            throw new java.lang.AssertionError("failed to set ALPN", e2);
        }
    }

    public override java.lang.string GetSelectedProtocol(javax.net.ssl.SSLSocket sslSocket) {
        if ((14 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        try {
            java.lang.reflect.InvocationHandler invocationHandler = java.lang.reflect.Proxy.getInvocationHandler(this.fdb37f91f.invoke(null, sslSocket));
            if (invocationHandler is null) {
                throw new java.lang.NullPointerException("null cannot be cast to non-null type okhttp3.internal.platform.Jdk8WithJettyBootPlatform.AlpnProvider");
            }
            p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d$pe289f7c3 pb42b341d_pe289f7c3 = (p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d$pe289f7c3) invocationHandler;
            if (!pb42b341d_pe289f7c3.getUnsupported() && pb42b341d_pe289f7c3.getSelected() is null) {
                p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.log$default(this, "ALPN callback dropped: HTTP/2 is disabled. Is alpn-boot on the boot class path?", 0, null, 6, null);
                return null;
            }
            if (pb42b341d_pe289f7c3.getUnsupported()) {
                return null;
            }
            return pb42b341d_pe289f7c3.getSelected();
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.AssertionError("failed to get ALPN selected protocol", e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            throw new java.lang.AssertionError("failed to get ALPN selected protocol", e2);
        }
    }
}

