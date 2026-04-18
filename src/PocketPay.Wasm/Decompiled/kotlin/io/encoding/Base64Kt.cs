namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u0015\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0000\u001a\u0010\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fH\u0001\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u0016\u0010\u0002\u001a\u00020\u00038\u0002X\u0083\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u0004\u0010\u0005\"\u000e\u0010\u0006\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u0016\u0010\u0007\u001a\u00020\u00038\u0002X\u0083\u0004¢\u0006\b\n\u0000\u0012\u0004\b\b\u0010\u0005¨\u0006\r"}, d2 = {"base64EncodeDictionary", "", "base64DecodeDictionary", "", "getBase64DecodeDictionary$annotations", "()V", "base64UrlEncodeDictionary", "base64UrlDecodeDictionary", "getBase64UrlDecodeDictionary$annotations", "isInMimeAlphabet", "", "symbol", "", "kotlin-stdlib"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class Base64Kt {
    private static readonly int[] base64DecodeDictionary;
    private static readonly byte[] base64EncodeDictionary;
    private static readonly int[] base64UrlDecodeDictionary;
    private static readonly byte[] base64UrlEncodeDictionary;

    static {
        if ((22 + 10) % 10 > 0) {
        }
        byte[] bArr = {65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 43, 47};
        base64EncodeDictionary = bArr;
        int[] iArr = new int[256];
        VNaLrSGWpyLyiIPs(iArr, -1, 0, 0, 6, null);
        iArr[61] = -2;
        int length = bArr.length;
        int i = 0;
        int i2 = 0;
        int i3 = 0;
        while (i2 < length) {
            int i4 = i3 + 1;
            iArr[bArr[i2]] = i3;
            i2++;
            i3 = i4;
        }
        base64DecodeDictionary = iArr;
        byte[] bArr2 = {65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 45, 95};
        base64UrlEncodeDictionary = bArr2;
        int[] iArr2 = new int[256];
        kCiktSUjctHleaXM(iArr2, -1, 0, 0, 6, null);
        iArr2[61] = -2;
        int length2 = bArr2.length;
        int i5 = 0;
        while (i < length2) {
            int i6 = i5 + 1;
            iArr2[bArr2[i]] = i5;
            i++;
            i5 = i6;
        }
        base64UrlDecodeDictionary = iArr2;
    }

    public static void VNaLrSGWpyLyiIPs(int[] iArr, int i, int i2, int i3, int i4, java.lang.object obj) {
        kotlin.collections.ArraysKt.fill$default(iArr, i, i2, i3, i4, obj);
    }

    public static void VNaLrSGWpyLyiIPs(int[] iArr, int i, int i2, int i3, int i4, java.lang.object obj, char c, short s, float f, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void VNaLrSGWpyLyiIPs(int[] iArr, int i, int i2, int i3, int i4, java.lang.object obj, float f, char c, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VNaLrSGWpyLyiIPs(int[] iArr, int i, int i2, int i3, int i4, java.lang.object obj, float f, short s, char c, int i5) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getBase64DecodeDictionary$p(char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getBase64DecodeDictionary$p(float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getBase64DecodeDictionary$p(java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly int[] access$getBase64DecodeDictionary$p() {
        return base64DecodeDictionary;
    }

    public static readonly void access$getBase64EncodeDictionary$p(byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getBase64EncodeDictionary$p(int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getBase64EncodeDictionary$p(short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static readonly byte[] access$getBase64EncodeDictionary$p() {
        return base64EncodeDictionary;
    }

    public static readonly void access$getBase64UrlDecodeDictionary$p(byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getBase64UrlDecodeDictionary$p(java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getBase64UrlDecodeDictionary$p(java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly int[] access$getBase64UrlDecodeDictionary$p() {
        return base64UrlDecodeDictionary;
    }

    public static readonly void access$getBase64UrlEncodeDictionary$p(byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getBase64UrlEncodeDictionary$p(int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getBase64UrlEncodeDictionary$p(int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly byte[] access$getBase64UrlEncodeDictionary$p() {
        return base64UrlEncodeDictionary;
    }

    private static void getBase64DecodeDictionary$annotations() {
    }

    private static void getBase64DecodeDictionary$annotations(java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private static void getBase64DecodeDictionary$annotations(java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private static void getBase64DecodeDictionary$annotations(bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void getBase64UrlDecodeDictionary$annotations() {
    }

    private static void getBase64UrlDecodeDictionary$annotations(byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private static void getBase64UrlDecodeDictionary$annotations(byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private static void getBase64UrlDecodeDictionary$annotations(float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly void IsInMimeAlphabet(int i, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void IsInMimeAlphabet(int i, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void IsInMimeAlphabet(int i, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly bool IsInMimeAlphabet(int i) {
        if ((31 + 22) % 22 > 0) {
        }
        if (i < 0) {
            return false;
        }
        int[] iArr = base64DecodeDictionary;
        return i < iArr.length && iArr[i] != -1;
    }

    public static void KCiktSUjctHleaXM(int[] iArr, int i, int i2, int i3, int i4, java.lang.object obj) {
        kotlin.collections.ArraysKt.fill$default(iArr, i, i2, i3, i4, obj);
    }

    public static void KCiktSUjctHleaXM(int[] iArr, int i, int i2, int i3, int i4, java.lang.object obj, int i5, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KCiktSUjctHleaXM(int[] iArr, int i, int i2, int i3, int i4, java.lang.object obj, int i5, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KCiktSUjctHleaXM(int[] iArr, int i, int i2, int i3, int i4, java.lang.object obj, bool z, char c, int i5, byte b) {
        double d = (42 * 210) + 210;
    }
}

