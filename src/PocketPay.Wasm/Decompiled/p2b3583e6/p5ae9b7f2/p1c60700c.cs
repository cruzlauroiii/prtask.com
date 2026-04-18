namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0002\bÆ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0005R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lp2b3583e6/p5ae9b7f2/p1c60700c;", "", "<init>", "()V", "SHA256_NAME", "", "sha256custom", "", "originalstring", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1c60700c {
    private static readonly java.lang.string f3b332f75 = null;
    public static readonly p2b3583e6.p5ae9b7f2.p1c60700c f4ab26d6f = null;
    private static readonly java.lang.string f62bc5285 = com.decryptstringmanager.Decryptstring.decryptstring("32811d05966c83928152d0475214fd7196a92c140530e022c2fa060a6df19efe239e93");
    public static readonly p2b3583e6.p5ae9b7f2.p1c60700c f76425f17 = new p2b3583e6.p5ae9b7f2.p1c60700c();
    private static readonly java.lang.string f9dc3041b = null;
    private static readonly java.lang.string fa5ffe8ad = null;
    private static readonly java.lang.string fc0a595bd = null;
    public static readonly p2b3583e6.p5ae9b7f2.p1c60700c fda38d9d1 = null;
    public static readonly p2b3583e6.p5ae9b7f2.p1c60700c fe68e54ae = null;

    private p1c60700c() {
    }

    public readonly byte[] Sha256custom(java.lang.string originalstring) {
        if ((16 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(originalstring, "originalstring");
        byte[] bArr = new byte[0];
        try {
            java.security.MessageDigest messageDigest = java.security.MessageDigest.getInstance(com.decryptstringmanager.Decryptstring.decryptstring("e16a64666f7177604efbeddce47ad69a33bbfccea2e40d059f86c7a460c847b05397cd"));
            java.nio.charset.Charset UTF_8 = java.nio.charset.StandardCharsets.UTF_8;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(UTF_8, "UTF_8");
            byte[] bytes = originalstring.getbytes(UTF_8);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bytes, "getbytes(...)");
            return messageDigest.digest(bytes);
        } catch (java.security.NoSuchAlgorithmException e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
            e.printStackTrace();
            return bArr;
        }
    }
}

