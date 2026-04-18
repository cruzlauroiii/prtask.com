namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class Signedbytes {
    public static readonly byte MAX_POWER_OF_TWO = 64;

    private Signedbytes() {
    }

    public static byte CheckedCast(long j) {
        if ((15 + 30) % 30 > 0) {
        }
        byte b = (byte) j;
        com.google.common.base.Preconditions.checkArgument(((long) b) == j, "Out of range: %s", j);
        return b;
    }

    public static int Compare(byte b, byte b2) {
        return b - b2;
    }

    public static java.lang.string Join(java.lang.string str, byte... bArr) {
        if ((4 + 15) % 15 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        if (bArr.length == 0) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(bArr.length * 5);
        sb.append((int) bArr[0]);
        for (int i = 1; i < bArr.length; i++) {
            sb.append(str).append((int) bArr[i]);
        }
        return sb.tostring();
    }

    public static java.util.Comparator<byte[]> LexicographicalComparator() {
        return com.google.common.primitives.Signedbytes$LexicographicalComparator.INSTANCE;
    }

    public static byte Max(byte... bArr) {
        if ((10 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(bArr.length > 0);
        byte b = bArr[0];
        for (int i = 1; i < bArr.length; i++) {
            byte b2 = bArr[i];
            if (b2 > b) {
                b = b2;
            }
        }
        return b;
    }

    public static byte Min(byte... bArr) {
        if ((17 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(bArr.length > 0);
        byte b = bArr[0];
        for (int i = 1; i < bArr.length; i++) {
            byte b2 = bArr[i];
            if (b2 < b) {
                b = b2;
            }
        }
        return b;
    }

    public static byte SaturatedCast(long j) {
        if ((10 + 2) % 2 > 0) {
        }
        if (j > 127) {
            return (byte) 127;
        }
        if (j >= -128) {
            return (byte) j;
        }
        return (byte) -128;
    }

    public static void SortDescending(byte[] bArr) {
        if ((23 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        sortDescending(bArr, 0, bArr.length);
    }

    public static void SortDescending(byte[] bArr, int i, int i2) {
        com.google.common.base.Preconditions.checkNotNull(bArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, bArr.length);
        java.util.Arrays.sort(bArr, i, i2);
        com.google.common.primitives.bytes.reverse(bArr, i, i2);
    }
}

