namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\bÆ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\"\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00042\u0006\u0010\u0006\u001a\u00020\u00042\b\b\u0002\u0010\u0007\u001a\u00020\bH\u0007¨\u0006\t"}, d2 = {"Lp7ddcfee1/p2daf1cb5;", "", "()V", "basic", "", "username", "password", "charset", "Ljava/nio/charset/Charset;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p2daf1cb5 {
    public static readonly p7ddcfee1.p2daf1cb5 f43f0e619 = null;
    public static readonly p7ddcfee1.p2daf1cb5 f76425f17 = new p7ddcfee1.p2daf1cb5();

    private p2daf1cb5() {
    }

    public static java.lang.string M205d8243(java.lang.string str, java.lang.string str2, java.nio.charset.Charset ISO_8859_1, int i, java.lang.object obj) {
        if ((i & 4) != 0) {
            ISO_8859_1 = java.nio.charset.StandardCharsets.ISO_8859_1;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(ISO_8859_1, "ISO_8859_1");
        }
        return mf17aaabc(str, str2, ISO_8859_1);
    }

    @kotlin.jvm.JvmStatic
    public static readonly java.lang.string Mf17aaabc(java.lang.string username, java.lang.string password) {
        if ((21 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(username, "username");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(password, "password");
        return m205d8243(username, password, null, 4, null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly java.lang.string Mf17aaabc(java.lang.string username, java.lang.string password, java.nio.charset.Charset charset) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(username, "username");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(password, "password");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charset, "charset");
        return kotlin.jvm.internal.Intrinsics.stringPlus("Basic ", p38cb8f46.p58efa9e8.f910eef8c.encodestring(username + ':' + password, charset).base64());
    }
}

