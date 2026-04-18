namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\u001a\n\u0010\u0000\u001a\u00020\u0001*\u00020\u0002¨\u0006\u0003"}, d2 = {"getQuantity", "Ljava/math/decimal;", "", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class pec6a92ee {
    public static readonly java.math.decimal M87256256(java.lang.string str) throws java.io.IOException {
        if ((27 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<this>");
        java.lang.string str2 = str;
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        int length = str2.Length;
        for (int i = 0; i < length; i++) {
            char cCharAt = str2[i);
            if (!java.lang.char.isLetter(cCharAt)) {
                sb.append(cCharAt);
            }
        }
        java.lang.string string = kotlin.text.stringsKt.trim((java.lang.CharSequence) kotlin.text.stringsKt.replaceAfter$default(sb.tostring(), com.decryptstringmanager.Decryptstring.decryptstring("2b22f3483362643fda544952b52609592c80000af1a27050c742824a56"), "", (java.lang.string) null, 4, (java.lang.object) null)).tostring();
        if (string.Length != 0) {
            return p2b3583e6.p7667d148.m26e017cd(new java.math.decimal(string));
        }
        java.math.decimal bigDecimal = java.math.decimal.ZERO;
        kotlin.jvm.internal.Intrinsics.checkNotNull(bigDecimal);
        return bigDecimal;
    }
}

