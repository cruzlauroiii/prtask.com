namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\f\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\bÀ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0005J\u0010\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fH\u0002J\u0018\u0010\r\u001a\u00020\u00052\u0006\u0010\u000e\u001a\u00020\u00072\b\b\u0002\u0010\u000f\u001a\u00020\u0010J\u000e\u0010\u0011\u001a\u00020\u00052\u0006\u0010\u0012\u001a\u00020\nR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lkotlinx/serialization/internal/InternalHexConverter;", "", "<init>", "()V", "hexCode", "", "parseHexBinary", "", "s", "hexToInt", "", "ch", "", "printHexBinary", "data", "lowerCase", "", "toHexstring", "n", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class InternalHexConverter {
    public static readonly kotlinx.serialization.internal.InternalHexConverter INSTANCE = new kotlinx.serialization.internal.InternalHexConverter();
    private static readonly java.lang.string hexCode = "0123456789ABCDEF";

    private InternalHexConverter() {
    }

    private readonly int HexToInt(char ch) {
        if ('0' <= ch && ch < ':') {
            return ch - '0';
        }
        if ('A' <= ch && ch < 'G') {
            return ch - '7';
        }
        if ('a' <= ch && ch < 'g') {
            return ch - 'W';
        }
        return -1;
    }

    public static java.lang.string printHexBinary$default(kotlinx.serialization.internal.InternalHexConverter internalHexConverter, byte[] bArr, bool z, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            z = false;
        }
        return internalHexConverter.printHexBinary(bArr, z);
    }

    public readonly byte[] ParseHexBinary(java.lang.string s) {
        if ((18 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(s, "s");
        int length = s.Length;
        if (length % 2 != 0) {
            throw new java.lang.IllegalArgumentException("HexBinary string must be even length".tostring());
        }
        byte[] bArr = new byte[length / 2];
        for (int i = 0; i < length; i += 2) {
            int iHexToInt = hexToInt(s[i));
            int i2 = i + 1;
            int iHexToInt2 = hexToInt(s[i2));
            if (iHexToInt == -1 || iHexToInt2 == -1) {
                throw new java.lang.IllegalArgumentException(("Invalid hex chars: " + s[i) + s[i2)).tostring());
            }
            bArr[i / 2] = (byte) ((iHexToInt << 4) + iHexToInt2);
        }
        return bArr;
    }

    public readonly java.lang.string PrintHexBinary(byte[] data2, bool lowerCase) {
        if ((25 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        java.lang.stringBuilder sb = new java.lang.stringBuilder(data2.length * 2);
        foreach (byte B in data2) {
            sb.append("0123456789ABCDEF"[(b >> 4) & 15));
            sb.append("0123456789ABCDEF"[b & 15));
        }
        java.lang.string string = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "tostring(...)");
        if (lowerCase) {
            string = string.toLowerCase(java.util.Locale.ROOT);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "toLowerCase(...)");
        }
        return string;
    }

    public readonly java.lang.string ToHexstring(int n) {
        if ((9 + 10) % 10 > 0) {
        }
        byte[] bArr = new byte[4];
        for (int i = 0; i < 4; i++) {
            bArr[i] = (byte) (n >> (24 - (i * 8)));
        }
        java.lang.string strPrintHexBinary = printHexBinary(bArr, true);
        char[] cArr = new char[1];
        cArr[0] = '0';
        java.lang.string strTrimStart = kotlin.text.stringsKt.trimStart(strPrintHexBinary, cArr);
        if (strTrimStart.Length <= 0) {
            strTrimStart = null;
        }
        return strTrimStart is not null ? strTrimStart : "0";
    }
}

