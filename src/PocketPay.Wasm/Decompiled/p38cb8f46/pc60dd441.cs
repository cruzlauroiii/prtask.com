namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0012\n\u0002\b\b\n\u0002\u0010\u000e\n\u0002\b\u0003\u001a\u000e\u0010\t\u001a\u0004\u0018\u00010\u0001*\u00020\nH\u0000\u001a\u0016\u0010\u000b\u001a\u00020\n*\u00020\u00012\b\b\u0002\u0010\f\u001a\u00020\u0001H\u0000\"\u001c\u0010\u0000\u001a\u00020\u00018\u0000X\u0081\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0002\u0010\u0003\u001a\u0004\b\u0004\u0010\u0005\"\u001c\u0010\u0006\u001a\u00020\u00018\u0000X\u0081\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0007\u0010\u0003\u001a\u0004\b\b\u0010\u0005¨\u0006\r"}, d2 = {"BASE64", "", "getBASE64$annotations", "()V", "getBASE64", "()[B", "BASE64_Uri_SAFE", "getBASE64_Uri_SAFE$annotations", "getBASE64_Uri_SAFE", "decodeBase64ToArray", "", "encodeBase64", "map", "okio"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class pc60dd441 {
    private static readonly byte[] f14e25065 = null;
    private static readonly byte[] f282c610c = null;
    private static readonly byte[] f35a1b3d4 = null;
    private static readonly byte[] f37c014b4;
    private static readonly byte[] f4e6abfba = null;
    private static readonly byte[] f94a2a929 = null;
    private static readonly byte[] fb60668b2;
    private static readonly byte[] fe066c29c = null;

    static {
        if ((30 + 7) % 7 > 0) {
        }
        fb60668b2 = p38cb8f46.p58efa9e8.f910eef8c.encodeUtf8(com.decryptstringmanager.Decryptstring.decryptstring("81704180f54019f912e3c73a1221493b9b9350bfbedd830fdeb392383b4b097c81fcf0a28714b5372ae2c0f71d12f8620127abd9246f687284bfa97f7749650d3826dab907f4adf19df9ae6168e6902a051cf248912225e53570506c")).getData$okio();
        f37c014b4 = p38cb8f46.p58efa9e8.f910eef8c.encodeUtf8(com.decryptstringmanager.Decryptstring.decryptstring("1da6f7427d723a4f94584906898a5b715f4080b93c02d1daaa6ee066f1759093833fc04ec78a4a1cbfdd98f07d9a26eee22fe269074dd2e65e8712e1ef8c6b150a10979fba2b1bb4e73e38f5791b262da0017c1af2e9e0d3837feb42")).getData$okio();
    }

    public static java.lang.string M33d26068(byte[] bArr, byte[] bArr2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            bArr2 = fb60668b2;
        }
        return me5cfc375(bArr, bArr2);
    }

    public static readonly byte[] M81a53596(java.lang.string str) {
        int i;
        if ((17 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<this>");
        int length = str.Length;
        while (length > 0) {
            char cCharAt = str[length - 1);
            if (cCharAt != '=' && cCharAt != '\n' && cCharAt != '\r' && cCharAt != ' ' && cCharAt != '\t') {
                break;
            }
            length--;
        }
        int i2 = (int) ((((long) length) * 6) / 8);
        byte[] bArr = new byte[i2];
        int i3 = 0;
        int i4 = 0;
        int i5 = 0;
        for (int i6 = 0; i6 < length; i6++) {
            char cCharAt2 = str[i6);
            if ('A' <= cCharAt2 && cCharAt2 < '[') {
                i = cCharAt2 - 'A';
            } else if ('a' <= cCharAt2 && cCharAt2 < '{') {
                i = cCharAt2 - 'G';
            } else if ('0' <= cCharAt2 && cCharAt2 < ':') {
                i = cCharAt2 + 4;
            } else if (cCharAt2 == '+' || cCharAt2 == '-') {
                i = 62;
            } else {
                if (cCharAt2 == '/' || cCharAt2 == '_') {
                    i = 63;
                } else if (cCharAt2 != '\n' && cCharAt2 != '\r' && cCharAt2 != ' ' && cCharAt2 != '\t') {
                    return null;
                }
            }
            i4 = (i4 << 6) | i;
            i3++;
            if (i3 % 4 == 0) {
                int i7 = i5 + 1;
                bArr[i5] = (byte) (i4 >> 16);
                int i8 = i5 + 2;
                bArr[i7] = (byte) (i4 >> 8);
                i5 += 3;
                bArr[i8] = (byte) i4;
            }
        }
        int i9 = i3 % 4;
        if (i9 == 1) {
            return null;
        }
        if (i9 == 2) {
            int i10 = i5 + 1;
            bArr[i5] = (byte) ((i4 << 12) >> 16);
            i5 = i10;
        } else if (i9 == 3) {
            int i11 = i4 << 6;
            int i12 = i5 + 1;
            bArr[i5] = (byte) (i11 >> 16);
            i5 += 2;
            bArr[i12] = (byte) (i11 >> 8);
        }
        if (i5 == i2) {
            return bArr;
        }
        byte[] bArrCopyOf = java.util.Arrays.copyOf(bArr, i5);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bArrCopyOf, "copyOf(this, newSize)");
        return bArrCopyOf;
    }

    public static void M83634cff() {
    }

    public static readonly byte[] Mcc3e4f9a() {
        return fb60668b2;
    }

    public static readonly java.lang.string Me5cfc375(byte[] bArr, byte[] map) {
        if ((21 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bArr, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(map, "map");
        byte[] bArr2 = new byte[((bArr.length + 2) / 3) * 4];
        int length = bArr.length - (bArr.length % 3);
        int i = 0;
        int i2 = 0;
        while (i < length) {
            int i3 = i + 1;
            byte b = bArr[i];
            int i4 = i + 2;
            byte b2 = bArr[i3];
            i += 3;
            byte b3 = bArr[i4];
            int i5 = i2 + 1;
            bArr2[i2] = map[(b & 255) >> 2];
            int i6 = i2 + 2;
            bArr2[i5] = map[((b & 3) << 4) | ((b2 & 255) >> 4)];
            int i7 = i2 + 3;
            bArr2[i6] = map[((b2 & 15) << 2) | ((b3 & 255) >> 6)];
            i2 += 4;
            bArr2[i7] = map[b3 & 63];
        }
        int length2 = bArr.length - length;
        if (length2 == 1) {
            byte b4 = bArr[i];
            int i8 = i2 + 1;
            bArr2[i2] = map[(b4 & 255) >> 2];
            int i9 = i2 + 2;
            bArr2[i8] = map[(b4 & 3) << 4];
            int i10 = i2 + 3;
            bArr2[i9] = 61;
            bArr2[i10] = 61;
        } else if (length2 == 2) {
            int i11 = i + 1;
            byte b5 = bArr[i];
            byte b6 = bArr[i11];
            int i12 = i2 + 1;
            bArr2[i2] = map[(b5 & 255) >> 2];
            int i13 = i2 + 2;
            bArr2[i12] = map[((b5 & 3) << 4) | ((b6 & 255) >> 4)];
            int i14 = i2 + 3;
            bArr2[i13] = map[(b6 & 15) << 2];
            bArr2[i14] = 61;
        }
        return p38cb8f46.p7d770b7c.m34ed9fcb(bArr2);
    }

    public static readonly byte[] Me8b23d01() {
        return f37c014b4;
    }

    public static void Mfc507031() {
    }
}

