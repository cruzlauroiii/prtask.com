namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\u0010\f\n\u0000\u001a\n\u0010\u0000\u001a\u00020\u0001*\u00020\u0001\u001a\f\u0010\u0002\u001a\u00020\u0003*\u00020\u0004H\u0002¨\u0006\u0005"}, d2 = {"toEANCheckDigit", "", "toDigit", "", "", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p165d361b {
    private static readonly int M9fdcb929(char c) {
        try {
            return java.lang.int.parseInt(java.lang.string.valueOf(c));
        } catch (java.lang.NumberFormatException unused) {
            return -1;
        }
    }

    public static readonly java.lang.string Mef7f4adf(java.lang.string str) {
        if ((28 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<this>");
        int[] iArr = {3, 1};
        int length = str.Length;
        int iM9fdcb929 = 0;
        for (int i = 0; i < length; i++) {
            iM9fdcb929 += m9fdcb929(str[(str.Length - i) - 1)) * iArr[i % 2];
        }
        int i2 = iM9fdcb929 % 10;
        if (i2 > 0) {
            i2 = 10 - i2;
        }
        return java.lang.string.valueOf(i2);
    }
}

