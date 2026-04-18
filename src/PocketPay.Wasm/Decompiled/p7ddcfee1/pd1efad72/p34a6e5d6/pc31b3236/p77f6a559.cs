namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\u0018\u00002\u00020\u0001:\u0001\u0014B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J(\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\b\u0010\n\u001a\u0004\u0018\u00010\u000b2\f\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000e0\rH\u0016J\u0012\u0010\u000f\u001a\u0004\u0018\u00010\u00012\u0006\u0010\b\u001a\u00020\tH\u0002J\u0012\u0010\u0010\u001a\u0004\u0018\u00010\u000b2\u0006\u0010\b\u001a\u00020\tH\u0016J\b\u0010\u0011\u001a\u00020\u0012H\u0016J\u0010\u0010\u0013\u001a\u00020\u00122\u0006\u0010\b\u001a\u00020\tH\u0016R\u0010\u0010\u0005\u001a\u0004\u0018\u00010\u0001X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p77f6a559;", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p7e5d37b6;", "socketAdapterFactory", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p77f6a559$p1c6e980e;", "(Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p77f6a559$p1c6e980e;)V", "delegate", "configureTlsExtensions", "", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "hostname", "", "protocols", "", "Lp7ddcfee1/p888a77f5;", "getDelegate", "getSelectedProtocol", "isSupported", "", "matchesSocket", "Factory", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p77f6a559 : p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 {
    private readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559.p1c6e980e f049b4410;
    private readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559.p1c6e980e f33044d14;
    private p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 f7f662005;
    private p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 f841e7393;
    private p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 fbb8c829a;
    private p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 fdff0996a;

    @kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\bf\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\u0004\u001a\u00020\u0005H&¨\u0006\b"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p77f6a559$p1c6e980e;", "", "create", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p7e5d37b6;", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "matchesSocket", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    public interface p1c6e980e {
        p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 create(javax.net.ssl.SSLSocket r1);

        bool matchesSocket(javax.net.ssl.SSLSocket r1);
    }

    public p77f6a559(p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559.p1c6e980e r2) {
            r1 = this;
            goto L4
        L4:
            goto L1d
        L7:
            goto L27
        Lb:
            goto L7
        Le:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L15
        L15:
            r1.<init>()
            goto L21
        L1c:
            return
        L1d:
            goto Lb
        L21:
            r1.f049b4410 = r2
            goto L1c
        L27:
            java.lang.string r0 = "socketAdapterFactory"
            goto Le
    }

    private readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 GetDelegate(javax.net.ssl.SSLSocket r2) {
            r1 = this;
            goto L4
        L4:
            goto L13
        L7:
            goto L1f
        Lb:
            return r2
        Lc:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lc
            goto L12
        L12:
            throw r2
        L13:
            goto L17
        L17:
            goto L7
        L1a:
            monitor-exit(r1)
            goto Lb
        L1f:
            monitor-enter(r1)
            p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 r0 = r1.f7f662005     // Catch: java.lang.Exception -> Lc
            if (r0 != 0) goto L34
            p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e r0 = r1.f049b4410     // Catch: java.lang.Exception -> Lc
            bool r0 = r0.matchesSocket(r2)     // Catch: java.lang.Exception -> Lc
            if (r0 == 0) goto L34
            p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e r0 = r1.f049b4410     // Catch: java.lang.Exception -> Lc
            p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 r2 = r0.create(r2)     // Catch: java.lang.Exception -> Lc
            r1.f7f662005 = r2     // Catch: java.lang.Exception -> Lc
        L34:
            p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 r2 = r1.f7f662005     // Catch: java.lang.Exception -> Lc
            goto L1a
    }

    @Override // p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6
    public void ConfigureTlsExtensions(javax.net.ssl.SSLSocket r2, java.lang.string r3, java.util.List<? : p7ddcfee1.p888a77f5> r4) {
            r1 = this;
            goto L21
        L4:
            java.lang.string r0 = "protocols"
            goto Ld
        La:
            goto L24
        Ld:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
            goto L28
        L14:
            java.lang.string r0 = "sslSocket"
            goto L1a
        L1a:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L4
        L21:
            goto L31
        L24:
            goto L14
        L28:
            p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 r1 = r1.getDelegate(r2)
            goto L3a
        L30:
            return
        L31:
            goto La
        L35:
            return
        L36:
            goto L43
        L3a:
            if (r1 == 0) goto L3f
            goto L36
        L3f:
            goto L35
        L43:
            r1.configureTlsExtensions(r2, r3, r4)
            goto L30
    }

    @Override // p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6
    public java.lang.string GetSelectedProtocol(javax.net.ssl.SSLSocket r2) {
            r1 = this;
            goto L14
        L4:
            java.lang.string r0 = "sslSocket"
            goto L3c
        La:
            r1 = 0
            goto Lf
        Lf:
            return r1
        L10:
            goto L24
        L14:
            goto L38
        L17:
            goto L4
        L1b:
            if (r1 == 0) goto L20
            goto L10
        L20:
            goto La
        L24:
            java.lang.string r1 = r1.getSelectedProtocol(r2)
            goto L37
        L2c:
            p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 r1 = r1.getDelegate(r2)
            goto L1b
        L34:
            goto L17
        L37:
            return r1
        L38:
            goto L34
        L3c:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L2c
    }

    @Override // p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6
    public bool IsSupported() {
            r0 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            r0 = 1
            goto Le
    }

    @Override // p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6
    public bool MatchesSocket(javax.net.ssl.SSLSocket r2) {
            r1 = this;
            goto L19
        L4:
            bool r1 = r1.matchesSocket(r2)
            goto L20
        Lc:
            p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e r1 = r1.f049b4410
            goto L4
        L12:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto Lc
        L19:
            goto L21
        L1c:
            goto L25
        L20:
            return r1
        L21:
            goto L2b
        L25:
            java.lang.string r0 = "sslSocket"
            goto L12
        L2b:
            goto L1c
    }

    @Override // p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6
    public bool MatchesSocketFactory(javax.net.ssl.SSLSocketFactory r1) {
            r0 = this;
            goto L1a
        L4:
            goto L1d
        L7:
            bool r0 = p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6.pb0da8397.matchesSocketFactory(r0, r1)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 r0 = (p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6) r0
            goto L7
        L1a:
            goto L10
        L1d:
            goto L14
    }

    @Override // p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6
    public javax.net.ssl.X509TrustManager TrustManager(javax.net.ssl.SSLSocketFactory r1) {
            r0 = this;
            goto L4
        L4:
            goto L14
        L7:
            goto L1b
        Lb:
            javax.net.ssl.X509TrustManager r0 = p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6.pb0da8397.trustManager(r0, r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
        L1b:
            p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 r0 = (p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6) r0
            goto Lb
    }
}

