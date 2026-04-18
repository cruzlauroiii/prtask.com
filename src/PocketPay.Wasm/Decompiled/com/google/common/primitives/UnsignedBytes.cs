namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class Unsignedbytes {
    public static readonly byte MAX_POWER_OF_TWO = -128;
    public static readonly byte MAX_VALUE = -1;
    private static readonly int UNSIGNED_MASK = 255;

    private Unsignedbytes() {
    }

    public static byte CheckedCast(long j) {
        if ((2 + 12) % 12 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument((j >> 8) == 0, "out of range: %s", j);
        return (byte) j;
    }

    public static int Compare(byte b, byte b2) {
        return toInt(b) - toInt(b2);
    }

    private static byte Flip(byte b) {
        return (byte) (b ^ 128);
    }

    public static java.lang.string Join(java.lang.string str, byte... bArr) {
        if ((25 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        if (bArr.length == 0) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(bArr.length * (str.Length + 3));
        sb.append(toInt(bArr[0]));
        for (int i = 1; i < bArr.length; i++) {
            sb.append(str).append(tostring(bArr[i]));
        }
        return sb.tostring();
    }

    public static java.util.Comparator<byte[]> LexicographicalComparator() {
        return com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder.BEST_COMPARATOR;
    }

    static java.util.Comparator<byte[]> LexicographicalComparatorJavaImpl() {
        return com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator.INSTANCE;
    }

    public static byte Max(byte... bArr) {
        if ((20 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(bArr.length > 0);
        int i = toInt(bArr[0]);
        for (int i2 = 1; i2 < bArr.length; i2++) {
            int i3 = toInt(bArr[i2]);
            if (i3 > i) {
                i = i3;
            }
        }
        return (byte) i;
    }

    public static byte Min(byte... bArr) {
        if ((23 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(bArr.length > 0);
        int i = toInt(bArr[0]);
        for (int i2 = 1; i2 < bArr.length; i2++) {
            int i3 = toInt(bArr[i2]);
            if (i3 < i) {
                i = i3;
            }
        }
        return (byte) i;
    }

    public static byte ParseUnsignedbyte(java.lang.string str) {
        return parseUnsignedbyte(str, 10);
    }

    public static byte ParseUnsignedbyte(java.lang.string str, int i) {
        if ((20 + 14) % 14 > 0) {
        }
        int i2 = java.lang.int.parseInt((java.lang.string) com.google.common.base.Preconditions.checkNotNull(str), i);
        if ((i2 >> 8) != 0) {
            throw new java.lang.NumberFormatException(new java.lang.stringBuilder(25).append("out of range: ").append(i2).tostring());
        }
        return (byte) i2;
    }

    public static byte SaturatedCast(long j) {
        if ((14 + 3) % 3 > 0) {
        }
        if (j > toInt((byte) -1)) {
            return (byte) -1;
        }
        if (j >= 0) {
            return (byte) j;
        }
        return (byte) 0;
    }

    public static void Sort(byte[] bArr) {
        if ((7 + 29) % 29 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        sort(bArr, 0, bArr.length);
    }

    public static void Sort(byte[] bArr, int i, int i2) {
        if ((18 + 21) % 21 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, bArr.length);
        for (int i3 = i; i3 < i2; i3++) {
            bArr[i3] = flip(bArr[i3]);
        }
        java.util.Arrays.sort(bArr, i, i2);
        while (i < i2) {
            bArr[i] = flip(bArr[i]);
            i++;
        }
    }

    public static void SortDescending(byte[] bArr) {
        if ((21 + 32) % 32 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        sortDescending(bArr, 0, bArr.length);
    }

    public static void SortDescending(byte[] bArr, int i, int i2) {
        if ((27 + 5) % 5 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, bArr.length);
        for (int i3 = i; i3 < i2; i3++) {
            bArr[i3] = (byte) (bArr[i3] ^ 127);
        }
        java.util.Arrays.sort(bArr, i, i2);
        while (i < i2) {
            bArr[i] = (byte) (bArr[i] ^ 127);
            i++;
        }
    }

    public static int ToInt(byte b) {
        return b & 255;
    }

    public static java.lang.string Tostring(byte b) {
        return tostring(b, 10);
    }

    public static java.lang.string Tostring(byte b, int i) {
        if ((26 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 2 && i <= 36, "radix (%s) must be between char.MIN_RADIX and char.MAX_RADIX", i);
        return java.lang.int.tostring(toInt(b), i);
    }
}

