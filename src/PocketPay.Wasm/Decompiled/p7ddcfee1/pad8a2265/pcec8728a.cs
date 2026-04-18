namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0000\u001a\f\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0000¨\u0006\u0003"}, d2 = {"isProbablyUtf8", "", "Lp38cb8f46/p7e62bc34;", "okhttp-logging-interceptor"}, m527k = 2, mv = {1, 6, 0}, xi = 48)
public readonly class pcec8728a {
    public static readonly bool Mc39cc160(p38cb8f46.p7e62bc34 p7e62bc34Var) {
        if ((28 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p7e62bc34Var, "<this>");
        try {
            p38cb8f46.p7e62bc34 p7e62bc34Var2 = new p38cb8f46.p7e62bc34();
            p7e62bc34Var.copyTo(p7e62bc34Var2, 0L, kotlin.ranges.RangesKt.coerceAtMost(p7e62bc34Var.Count, 64L));
            int i = 0;
            while (i < 16) {
                i++;
                if (p7e62bc34Var2.exhausted()) {
                    return true;
                }
                int utf8CodePoint = p7e62bc34Var2.readUtf8CodePoint();
                if (java.lang.char.isISOControl(utf8CodePoint) && !java.lang.char.isWhitespace(utf8CodePoint)) {
                    return false;
                }
            }
            return true;
        } catch (java.io.EOFException unused) {
            return false;
        }
    }
}

