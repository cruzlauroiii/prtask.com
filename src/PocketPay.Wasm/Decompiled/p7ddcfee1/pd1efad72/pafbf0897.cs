namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0016\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u0004\u001a\u001e\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0005\u001a\u00020\u00042\u0006\u0010\u0006\u001a\u00020\u0004\u001a\u001e\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e\u001a\u0018\u0010\u000f\u001a\u0004\u0018\u00010\u00102\u0006\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u0014\u001a\u0016\u0010\u0015\u001a\u00020\u00042\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u000e\u001a \u0010\u0019\u001a\u0004\u0018\u00010\u00172\u0006\u0010\u001a\u001a\u00020\u001b2\u0006\u0010\u001c\u001a\u00020\u001d2\u0006\u0010\u001e\u001a\u00020\u0004¨\u0006\u001f"}, d2 = {"addHeaderLenient", "Lp7ddcfee1/p883d7615$p2bd4a59b;", "builder", "line", "", "name", "value", "applyConnectionSpec", "", "connectionSpec", "Lp7ddcfee1/p43967033;", "sslSocket", "Ljavax/net/ssl/SSLSocket;", "isFallback", "", "cacheGet", "Lp7ddcfee1/pd64ed3e9;", "cache", "Lp7ddcfee1/pab0cf104;", "request", "Lp7ddcfee1/p15c2d85f;", "cookieTostring", "cookie", "Lp7ddcfee1/p706f1088;", "forObsoleteRfc2965", "parseCookie", "currentTimeMillis", "", "url", "Lp7ddcfee1/pdfadebdd;", "setCookie", "okhttp"}, m527k = 2, mv = {1, 6, 0}, xi = 48)
public readonly class pafbf0897 {
    public static readonly p7ddcfee1.p883d7615$p2bd4a59b addHeaderLenient(p7ddcfee1.p883d7615$p2bd4a59b builder, java.lang.string line) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(line, "line");
        return builder.addLenient$okhttp(line);
    }

    public static readonly p7ddcfee1.p883d7615$p2bd4a59b addHeaderLenient(p7ddcfee1.p883d7615$p2bd4a59b builder, java.lang.string name, java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        return builder.addLenient$okhttp(name, value);
    }

    public static readonly void ApplyConnectionSpec(p7ddcfee1.p43967033 connectionSpec, javax.net.ssl.SSLSocket sslSocket, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(connectionSpec, "connectionSpec");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sslSocket, "sslSocket");
        connectionSpec.apply$okhttp(sslSocket, z);
    }

    public static readonly p7ddcfee1.pd64ed3e9 CacheGet(p7ddcfee1.pab0cf104 cache, p7ddcfee1.p15c2d85f request) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cache, "cache");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return cache.get$okhttp(request);
    }

    public static readonly java.lang.string CookieTostring(p7ddcfee1.p706f1088 cookie, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cookie, "cookie");
        return cookie.tostring$okhttp(z);
    }

    public static readonly p7ddcfee1.p706f1088 ParseCookie(long j, p7ddcfee1.pdfadebdd url, java.lang.string setCookie) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(setCookie, "setCookie");
        return p7ddcfee1.p706f1088.f910eef8c.parse$okhttp(j, url, setCookie);
    }
}

