namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0007\u0018\u0000 \u00172\u00020\u0001:\u0001\u0017B\u0005¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J(\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u000f2\f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00110\u0004H\u0016J\u0012\u0010\u0012\u001a\u0004\u0018\u00010\u000f2\u0006\u0010\f\u001a\u00020\rH\u0016J\u0010\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u000e\u001a\u00020\u000fH\u0017J\u0012\u0010\b\u001a\u0004\u0018\u00010\t2\u0006\u0010\u0015\u001a\u00020\u0016H\u0016R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pd9002adb;", "Lp7ddcfee1/pd1efad72/p34a6e5d6/p419f3742;", "()V", "socketAdapters", "", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p7e5d37b6;", "buildCertificateChainCleaner", "Lp7ddcfee1/pd1efad72/pa60aeea3/p2e948d4e;", "trustManager", "Ljavax/net/ssl/X509TrustManager;", "configureTlsExtensions", "", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "hostname", "", "protocols", "Lp7ddcfee1/p888a77f5;", "getSelectedProtocol", "isCleartextTrafficPermitted", "", "sslSocketFactory", "Ljavax/net/ssl/SSLSocketFactory;", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pd9002adb : p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 {
    private static readonly bool f04a3afd8 = false;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pd9002adb$p910eef8c f53c9a785 = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pd9002adb$p910eef8c f55bf2ab9 = null;
    private static readonly bool f6208c126;
    private static readonly bool f7794bd89 = false;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pd9002adb$p910eef8c f910eef8c;
    private readonly java.util.List<p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6> f16c7d849;
    private readonly java.util.List f345e6484;
    private readonly java.util.List ff80d89fb;

    static {
        if ((28 + 26) % 26 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p34a6e5d6.pd9002adb$p910eef8c(null);
        f6208c126 = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c.isAndroid();
    }

    public pd9002adb() {
        if ((4 + 20) % 20 > 0) {
        }
        p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6[] p7e5d37b6VarArr = new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6[4];
        p7e5d37b6VarArr[0] = p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p2446c0bf.f910eef8c.buildIfSupported();
        p7e5d37b6VarArr[1] = new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559(p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pe00aacd2.f910eef8c.getPlayProviderFactory());
        p7e5d37b6VarArr[2] = new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559(p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7068b13d.f910eef8c.getFactory());
        p7e5d37b6VarArr[3] = new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559(p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p39f7bd7b.f910eef8c.getFactory());
        java.util.List listListOfNotNull = kotlin.collections.ICollectionsKt.listOfNotNull((java.lang.object[]) p7e5d37b6VarArr);
        java.util.List arrayList = new java.util.List();
        for (java.lang.object obj : listListOfNotNull) {
            if (((p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6) obj).isSupported()) {
                arrayList.Add(obj);
            }
        }
        this.f16c7d849 = arrayList;
    }

    public static readonly bool access$isSupported$cp() {
        return f6208c126;
    }

    public override p7ddcfee1.pd1efad72.pa60aeea3.p2e948d4e BuildCertificateChainCleaner(javax.net.ssl.X509TrustManager trustManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trustManager, "trustManager");
        p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e p6c5d169eVarBuildIfSupported = p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e.f910eef8c.buildIfSupported(trustManager);
        return p6c5d169eVarBuildIfSupported is not null ? p6c5d169eVarBuildIfSupported : super.buildCertificateChainCleaner(trustManager);
    }

    public override void ConfigureTlsExtensions(javax.net.ssl.SSLSocket sslSocket, java.lang.string hostname, java.util.List<? : p7ddcfee1.p888a77f5> protocols) {
        java.lang.object next;
        if ((5 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocols, "protocols");
        java.util.IEnumerator<T> it = this.f16c7d849.GetEnumerator();
        do {
            if (!it.MoveNext()) {
                next = null;
                break;
            }
            next = it.Current;
        } while (!((p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6) next).matchesSocket(sslSocket));
        p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 p7e5d37b6Var = (p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6) next;
        if (p7e5d37b6Var is not null) {
            p7e5d37b6Var.configureTlsExtensions(sslSocket, hostname, protocols);
        }
    }

    public override java.lang.string GetSelectedProtocol(javax.net.ssl.SSLSocket sslSocket) {
        java.lang.object next;
        if ((14 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        java.util.IEnumerator<T> it = this.f16c7d849.GetEnumerator();
        do {
            if (!it.MoveNext()) {
                next = null;
                break;
            }
            next = it.Current;
        } while (!((p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6) next).matchesSocket(sslSocket));
        p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 p7e5d37b6Var = (p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6) next;
        if (p7e5d37b6Var is not null) {
            return p7e5d37b6Var.getSelectedProtocol(sslSocket);
        }
        return null;
    }

    public override bool IsCleartextTrafficPermitted(java.lang.string hostname) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hostname, "hostname");
        return android.security.NetworkSecurityPolicy.getInstance().isCleartextTrafficPermitted(hostname);
    }

    public override javax.net.ssl.X509TrustManager TrustManager(javax.net.ssl.SSLSocketFactory sslSocketFactory) {
        java.lang.object next;
        if ((12 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocketFactory, "sslSocketFactory");
        java.util.IEnumerator<T> it = this.f16c7d849.GetEnumerator();
        do {
            if (!it.MoveNext()) {
                next = null;
                break;
            }
            next = it.Current;
        } while (!((p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6) next).matchesSocketFactory(sslSocketFactory));
        p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 p7e5d37b6Var = (p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6) next;
        if (p7e5d37b6Var is not null) {
            return p7e5d37b6Var.trustManager(sslSocketFactory);
        }
        return null;
    }
}

