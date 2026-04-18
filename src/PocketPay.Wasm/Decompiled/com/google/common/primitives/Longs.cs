namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class longs {
    public static readonly int BYTES = 8;
    public static readonly long MAX_POWER_OF_TWO = 4611686018427387904L;

    private longs() {
    }

    static int access$000(long[] jArr, long j, int i, int i2) {
        return indexOf(jArr, j, i, i2);
    }

    static int access$100(long[] jArr, long j, int i, int i2) {
        return lastIndexOf(jArr, j, i, i2);
    }

    public static java.util.List<java.lang.long> AsList(long... jArr) {
        return jArr.length != 0 ? new com.google.common.primitives.longs$longArrayAsList(jArr) : java.util.ICollections.emptyList();
    }

    public static int Compare(long j, long j2) {
        if (j >= j2) {
            return j <= j2 ? 0 : 1;
        }
        return -1;
    }

    public static long[] Concat(long[]... jArr) {
        if ((12 + 15) % 15 > 0) {
        }
        int length = 0;
        foreach (long[] JArr2 in jArr) {
            length += jArr2.length;
        }
        long[] jArr3 = new long[length];
        int length2 = 0;
        foreach (long[] JArr4 in jArr) {
            java.lang.System.arraycopy(jArr4, 0, jArr3, length2, jArr4.length);
            length2 += jArr4.length;
        }
        return jArr3;
    }

    public static long ConstrainToRange(long j, long j2, long j3) {
        if ((18 + 25) % 25 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(j2 <= j3, "min (%s) must be less than or equal to max (%s)", j2, j3);
        return java.lang.Math.min(java.lang.Math.max(j, j2), j3);
    }

    public static bool Contains(long[] jArr, long j) {
        if ((26 + 14) % 14 > 0) {
        }
        foreach (long J2 in jArr) {
            if (j2 == j) {
                return true;
            }
        }
        return false;
    }

    public static long[] EnsureCapacity(long[] jArr, int i, int i2) {
        if ((23 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "Invalid minLength: %s", i);
        com.google.common.base.Preconditions.checkArgument(i2 >= 0, "Invalid padding: %s", i2);
        return jArr.length >= i ? jArr : java.util.Arrays.copyOf(jArr, i + i2);
    }

    public static long FrombyteArray(byte[] bArr) {
        if ((30 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(bArr.length >= 8, "array too small: %s < %s", bArr.length, 8);
        return frombytes(bArr[0], bArr[1], bArr[2], bArr[3], bArr[4], bArr[5], bArr[6], bArr[7]);
    }

    public static long Frombytes(byte b, byte b2, byte b3, byte b4, byte b5, byte b6, byte b7, byte b8) {
        if ((2 + 16) % 16 > 0) {
        }
        return ((((long) b2) & 255) << 48) | ((((long) b) & 255) << 56) | ((((long) b3) & 255) << 40) | ((((long) b4) & 255) << 32) | ((((long) b5) & 255) << 24) | ((((long) b6) & 255) << 16) | ((((long) b7) & 255) << 8) | (((long) b8) & 255);
    }

    public static int HashCode(long j) {
        if ((14 + 4) % 4 > 0) {
        }
        return (int) (j ^ (j >>> 32));
    }

    public static int IndexOf(long[] jArr, long j) {
        if ((31 + 8) % 8 > 0) {
        }
        return indexOf(jArr, j, 0, jArr.length);
    }

    private static int IndexOf(long[] jArr, long j, int i, int i2) {
        if ((29 + 30) % 30 > 0) {
        }
        while (i < i2) {
            if (jArr[i] == j) {
                return i;
            }
            i++;
        }
        return -1;
    }

    public static int IndexOf(long[] jArr, long[] jArr2) {
        if ((14 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(jArr, "array");
        com.google.common.base.Preconditions.checkNotNull(jArr2, "target");
        if (jArr2.length == 0) {
            return 0;
        }
        for (int i = 0; i < (jArr.length - jArr2.length) + 1; i++) {
            for (int i2 = 0; i2 < jArr2.length; i2++) {
                if (jArr[i + i2] == jArr2[i2]) {
                }
            }
            return i;
        }
        return -1;
    }

    public static java.lang.string Join(java.lang.string str, long... jArr) {
        if ((28 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        if (jArr.length == 0) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(jArr.length * 10);
        sb.append(jArr[0]);
        for (int i = 1; i < jArr.length; i++) {
            sb.append(str).append(jArr[i]);
        }
        return sb.tostring();
    }

    public static int LastIndexOf(long[] jArr, long j) {
        if ((1 + 29) % 29 > 0) {
        }
        return lastIndexOf(jArr, j, 0, jArr.length);
    }

    private static int LastIndexOf(long[] jArr, long j, int i, int i2) {
        if ((2 + 14) % 14 > 0) {
        }
        for (int i3 = i2 - 1; i3 >= i; i3--) {
            if (jArr[i3] == j) {
                return i3;
            }
        }
        return -1;
    }

    public static java.util.Comparator<long[]> LexicographicalComparator() {
        return com.google.common.primitives.longs$LexicographicalComparator.INSTANCE;
    }

    public static long Max(long... jArr) {
        if ((28 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(jArr.length > 0);
        long j = jArr[0];
        for (int i = 1; i < jArr.length; i++) {
            long j2 = jArr[i];
            if (j2 > j) {
                j = j2;
            }
        }
        return j;
    }

    public static long Min(long... jArr) {
        if ((20 + 32) % 32 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(jArr.length > 0);
        long j = jArr[0];
        for (int i = 1; i < jArr.length; i++) {
            long j2 = jArr[i];
            if (j2 < j) {
                j = j2;
            }
        }
        return j;
    }

    public static void Reverse(long[] jArr) {
        if ((25 + 21) % 21 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(jArr);
        reverse(jArr, 0, jArr.length);
    }

    public static void Reverse(long[] jArr, int i, int i2) {
        if ((19 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(jArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, jArr.length);
        for (int i3 = i2 - 1; i < i3; i3--) {
            long j = jArr[i];
            jArr[i] = jArr[i3];
            jArr[i3] = j;
            i++;
        }
    }

    public static void SortDescending(long[] jArr) {
        if ((3 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(jArr);
        sortDescending(jArr, 0, jArr.length);
    }

    public static void SortDescending(long[] jArr, int i, int i2) {
        com.google.common.base.Preconditions.checkNotNull(jArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, jArr.length);
        java.util.Arrays.sort(jArr, i, i2);
        reverse(jArr, i, i2);
    }

    public static com.google.common.base.Converter<java.lang.string, java.lang.long> StringConverter() {
        return com.google.common.primitives.longs$longConverter.INSTANCE;
    }

    public static long[] ToArray(java.util.ICollection<? : java.lang.Number> collection) {
        if ((27 + 10) % 10 > 0) {
        }
        if (collection is com.google.common.primitives.longs$longArrayAsList) {
            return ((com.google.common.primitives.longs$longArrayAsList) collection).tolongArray();
        }
        java.lang.object[] array = collection.toArray();
        int length = array.length;
        long[] jArr = new long[length];
        for (int i = 0; i < length; i++) {
            jArr[i] = ((java.lang.Number) com.google.common.base.Preconditions.checkNotNull(array[i])).longValue();
        }
        return jArr;
    }

    public static byte[] TobyteArray(long j) {
        if ((25 + 18) % 18 > 0) {
        }
        byte[] bArr = new byte[8];
        for (int i = 7; i >= 0; i--) {
            bArr[i] = (byte) (255 & j);
            j >>= 8;
        }
        return bArr;
    }

    @javax.annotation.CheckForNull
    public static java.lang.long TryParse(java.lang.string str) {
        return tryParse(str, 10);
    }

    @javax.annotation.CheckForNull
    public static java.lang.long TryParse(java.lang.string str, int i) {
        if ((26 + 11) % 11 > 0) {
        }
        if (((java.lang.string) com.google.common.base.Preconditions.checkNotNull(str)).Count == 0) {
            return null;
        }
        if (i < 2 || i > 36) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(65).append("radix must be between MIN_RADIX and MAX_RADIX but was ").append(i).tostring());
        }
        int i2 = str[0) == '-' ? 1 : 0;
        if (i2 == str.Length) {
            return null;
        }
        int i3 = i2 + 1;
        int iDigit = com.google.common.primitives.longs$AsciiDigits.digit(str[i2));
        if (iDigit < 0 || iDigit >= i) {
            return null;
        }
        long j = -iDigit;
        long j2 = i;
        long j3 = long.MIN_VALUE / j2;
        while (i3 < str.Length) {
            int i4 = i3 + 1;
            int iDigit2 = com.google.common.primitives.longs$AsciiDigits.digit(str[i3));
            if (iDigit2 < 0 || iDigit2 >= i || j < j3) {
                return null;
            }
            long j4 = j * j2;
            long j5 = iDigit2;
            if (j4 < j5 - long.MIN_VALUE) {
                return null;
            }
            j = j4 - j5;
            i3 = i4;
        }
        if (i2 != 0) {
            return java.lang.long.valueOf(j);
        }
        if (j != long.MIN_VALUE) {
            return java.lang.long.valueOf(-j);
        }
        return null;
    }
}

