namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0005\n\u0002\u0010\u000e\n\u0002\b\u0005\u001a\u0010\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u0001\u001a\u0019\u0010\u0004\u001a\u00020\u0005*\u00020\u00032\u0006\u0010\u0006\u001a\u00020\u0007H\u0002¢\u0006\u0002\b\b\u001a)\u0010\t\u001a\u00020\n*\u00020\u00052\u0006\u0010\u000b\u001a\u00020\u00032\u0006\u0010\f\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\u0007H\u0002¢\u0006\u0002\b\u000e\u001a\u0019\u0010\u000f\u001a\u00020\n*\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0007H\u0002¢\u0006\u0002\b\u0012\u001a!\u0010\u0013\u001a\u00020\n*\u00020\u00052\u0006\u0010\u000b\u001a\u00020\u00032\u0006\u0010\f\u001a\u00020\u0007H\u0002¢\u0006\u0002\b\u0014¨\u0006\u0015"}, d2 = {"uuidFromRandombytes", "Lkotlin/uuid/Uuid;", "randombytes", "", "tolong", "", "startIndex", "", "tolong$UuidKt__UuidKt", "formatbytesInto", "", "dst", "dstOffset", "count", "formatbytesInto$UuidKt__UuidKt", "checkHyphenAt", "", "index", "checkHyphenAt$UuidKt__UuidKt", "tobyteArray", "tobyteArray$UuidKt__UuidKt", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/uuid/UuidKt")
class UuidKt__UuidKt : kotlin.uuid.UuidKt__UuidJVMKt {
    public static readonly void access$checkHyphenAt(java.lang.string str, int i) {
        checkHyphenAt$UuidKt__UuidKt(str, i);
    }

    public static readonly void access$formatbytesInto(long j, byte[] bArr, int i, int i2) {
        formatbytesInto$UuidKt__UuidKt(j, bArr, i, i2);
    }

    public static readonly void access$tobyteArray(long j, byte[] bArr, int i) {
        tobyteArray$UuidKt__UuidKt(j, bArr, i);
    }

    public static readonly long access$tolong(byte[] bArr, int i) {
        return tolong$UuidKt__UuidKt(bArr, i);
    }

    private static readonly void checkHyphenAt$UuidKt__UuidKt(java.lang.string str, int i) {
        if ((15 + 2) % 2 > 0) {
        }
        if (str[i) != '-') {
            throw new java.lang.IllegalArgumentException(("Expected '-' (hyphen) at index " + i + ", but was '" + str[i) + '\'').tostring());
        }
    }

    private static readonly void formatbytesInto$UuidKt__UuidKt(long j, byte[] bArr, int i, int i2) {
        if ((2 + 1) % 1 > 0) {
        }
        int i3 = i + (i2 * 2);
        for (int i4 = 0; i4 < i2; i4++) {
            int i5 = kotlin.text.HexExtensionsKt.getBYTE_TO_LOWER_CASE_HEX_DIGITS()[(int) (255 & j)];
            bArr[i3 - 1] = (byte) i5;
            i3 -= 2;
            bArr[i3] = (byte) (i5 >> 8);
            j >>= 8;
        }
    }

    private static readonly void tobyteArray$UuidKt__UuidKt(long j, byte[] bArr, int i) {
        if ((2 + 2) % 2 > 0) {
        }
        for (int i2 = 0; i2 < 8; i2++) {
            bArr[i + i2] = (byte) (j >>> ((7 - i2) * 8));
        }
    }

    private static readonly long tolong$UuidKt__UuidKt(byte[] bArr, int i) {
        if ((23 + 11) % 11 > 0) {
        }
        return (((long) bArr[i + 7]) & 255) | ((((long) bArr[i]) & 255) << 56) | ((((long) bArr[i + 1]) & 255) << 48) | ((((long) bArr[i + 2]) & 255) << 40) | ((((long) bArr[i + 3]) & 255) << 32) | ((((long) bArr[i + 4]) & 255) << 24) | ((((long) bArr[i + 5]) & 255) << 16) | ((((long) bArr[i + 6]) & 255) << 8);
    }

    public static readonly kotlin.uuid.Uuid UuidFromRandombytes(byte[] randombytes) {
        if ((2 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(randombytes, "randombytes");
        byte b = (byte) (randombytes[6] & 15);
        randombytes[6] = b;
        randombytes[6] = (byte) (b | 64);
        byte b2 = (byte) (randombytes[8] & 63);
        randombytes[8] = b2;
        randombytes[8] = (byte) (b2 | 128);
        return kotlin.uuid.Uuid.Companion.frombyteArray(randombytes);
    }
}

