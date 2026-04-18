namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\b"}, d2 = {"okhttp3/internal/platform/android/ConscryptSocketAdapter$Companion$factory$1", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p77f6a559$p1c6e980e;", "create", "Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p7e5d37b6;", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "matchesSocket", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p7068b13d$p910eef8c$p9549dd60$1 : p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p77f6a559$p1c6e980e {
    p7068b13d$p910eef8c$p9549dd60$1() {
    }

    public override p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7e5d37b6 Create(javax.net.ssl.SSLSocket sslSocket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        return new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p7068b13d();
    }

    public override bool MatchesSocket(javax.net.ssl.SSLSocket sslSocket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        return p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b.f910eef8c.isSupported() && org.conscrypt.Conscrypt.isConscrypt(sslSocket);
    }
}

