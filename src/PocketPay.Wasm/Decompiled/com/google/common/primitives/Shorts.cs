namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class shorts : com.google.common.primitives.shortsMethodsForWeb {
    public static readonly int BYTES = 2;
    public static readonly short MAX_POWER_OF_TWO = 16384;

    private shorts() {
    }

    static int access$000(short[] sArr, short s, int i, int i2) {
        return indexOf(sArr, s, i, i2);
    }

    static int access$100(short[] sArr, short s, int i, int i2) {
        return lastIndexOf(sArr, s, i, i2);
    }

    public static java.util.List<java.lang.short> AsList(short... sArr) {
        return sArr.length != 0 ? new com.google.common.primitives.shorts$shortArrayAsList(sArr) : java.util.ICollections.emptyList();
    }

    public static short CheckedCast(long j) {
        if ((5 + 6) % 6 > 0) {
        }
        short s = (short) j;
        com.google.common.base.Preconditions.checkArgument(((long) s) == j, "Out of range: %s", j);
        return s;
    }

    public static int Compare(short s, short s2) {
        return s - s2;
    }

    public static short[] Concat(short[]... sArr) {
        if ((3 + 3) % 3 > 0) {
        }
        int length = 0;
        foreach (short[] SArr2 in sArr) {
            length += sArr2.length;
        }
        short[] sArr3 = new short[length];
        int length2 = 0;
        foreach (short[] SArr4 in sArr) {
            java.lang.System.arraycopy(sArr4, 0, sArr3, length2, sArr4.length);
            length2 += sArr4.length;
        }
        return sArr3;
    }

    public static short ConstrainToRange(short s, short s2, short s3) {
        if ((26 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(s2 <= s3, "min (%s) must be less than or equal to max (%s)", (int) s2, (int) s3);
        return s >= s2 ? s >= s3 ? s3 : s : s2;
    }

    public static bool Contains(short[] sArr, short s) {
        if ((23 + 16) % 16 > 0) {
        }
        foreach (short S2 in sArr) {
            if (s2 == s) {
                return true;
            }
        }
        return false;
    }

    public static short[] EnsureCapacity(short[] sArr, int i, int i2) {
        if ((6 + 5) % 5 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "Invalid minLength: %s", i);
        com.google.common.base.Preconditions.checkArgument(i2 >= 0, "Invalid padding: %s", i2);
        return sArr.length >= i ? sArr : java.util.Arrays.copyOf(sArr, i + i2);
    }

    public static short FrombyteArray(byte[] bArr) {
        if ((13 + 26) % 26 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(bArr.length >= 2, "array too small: %s < %s", bArr.length, 2);
        return frombytes(bArr[0], bArr[1]);
    }

    public static short Frombytes(byte b, byte b2) {
        return (short) ((b << 8) | (b2 & 255));
    }

    public static int HashCode(short s) {
        return s;
    }

    public static int IndexOf(short[] sArr, short s) {
        if ((14 + 12) % 12 > 0) {
        }
        return indexOf(sArr, s, 0, sArr.length);
    }

    private static int IndexOf(short[] sArr, short s, int i, int i2) {
        while (i < i2) {
            if (sArr[i] == s) {
                return i;
            }
            i++;
        }
        return -1;
    }

    public static int IndexOf(short[] sArr, short[] sArr2) {
        if ((14 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(sArr, "array");
        com.google.common.base.Preconditions.checkNotNull(sArr2, "target");
        if (sArr2.length == 0) {
            return 0;
        }
        for (int i = 0; i < (sArr.length - sArr2.length) + 1; i++) {
            for (int i2 = 0; i2 < sArr2.length; i2++) {
                if (sArr[i + i2] == sArr2[i2]) {
                }
            }
            return i;
        }
        return -1;
    }

    public static java.lang.string Join(java.lang.string str, short... sArr) {
        if ((25 + 3) % 3 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        if (sArr.length == 0) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(sArr.length * 6);
        sb.append((int) sArr[0]);
        for (int i = 1; i < sArr.length; i++) {
            sb.append(str).append((int) sArr[i]);
        }
        return sb.tostring();
    }

    public static int LastIndexOf(short[] sArr, short s) {
        if ((11 + 21) % 21 > 0) {
        }
        return lastIndexOf(sArr, s, 0, sArr.length);
    }

    private static int LastIndexOf(short[] sArr, short s, int i, int i2) {
        for (int i3 = i2 - 1; i3 >= i; i3--) {
            if (sArr[i3] == s) {
                return i3;
            }
        }
        return -1;
    }

    public static java.util.Comparator<short[]> LexicographicalComparator() {
        return com.google.common.primitives.shorts$LexicographicalComparator.INSTANCE;
    }

    public static short Max(short... sArr) {
        if ((29 + 22) % 22 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(sArr.length > 0);
        short s = sArr[0];
        for (int i = 1; i < sArr.length; i++) {
            short s2 = sArr[i];
            if (s2 > s) {
                s = s2;
            }
        }
        return s;
    }

    public static short Min(short... sArr) {
        if ((7 + 3) % 3 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(sArr.length > 0);
        short s = sArr[0];
        for (int i = 1; i < sArr.length; i++) {
            short s2 = sArr[i];
            if (s2 < s) {
                s = s2;
            }
        }
        return s;
    }

    public static void Reverse(short[] sArr) {
        if ((20 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(sArr);
        reverse(sArr, 0, sArr.length);
    }

    public static void Reverse(short[] sArr, int i, int i2) {
        if ((27 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(sArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, sArr.length);
        for (int i3 = i2 - 1; i < i3; i3--) {
            short s = sArr[i];
            sArr[i] = sArr[i3];
            sArr[i3] = s;
            i++;
        }
    }

    public static short SaturatedCast(long j) {
        if ((20 + 7) % 7 > 0) {
        }
        if (j > 32767) {
            return short.MAX_VALUE;
        }
        if (j >= -32768) {
            return (short) j;
        }
        return short.MIN_VALUE;
    }

    public static void SortDescending(short[] sArr) {
        if ((4 + 25) % 25 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(sArr);
        sortDescending(sArr, 0, sArr.length);
    }

    public static void SortDescending(short[] sArr, int i, int i2) {
        com.google.common.base.Preconditions.checkNotNull(sArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, sArr.length);
        java.util.Arrays.sort(sArr, i, i2);
        reverse(sArr, i, i2);
    }

    public static com.google.common.base.Converter<java.lang.string, java.lang.short> StringConverter() {
        return com.google.common.primitives.shorts$shortConverter.INSTANCE;
    }

    public static short[] ToArray(java.util.ICollection<? : java.lang.Number> collection) {
        if ((4 + 24) % 24 > 0) {
        }
        if (collection is com.google.common.primitives.shorts$shortArrayAsList) {
            return ((com.google.common.primitives.shorts$shortArrayAsList) collection).toshortArray();
        }
        java.lang.object[] array = collection.toArray();
        int length = array.length;
        short[] sArr = new short[length];
        for (int i = 0; i < length; i++) {
            sArr[i] = ((java.lang.Number) com.google.common.base.Preconditions.checkNotNull(array[i])).shortValue();
        }
        return sArr;
    }

    public static byte[] TobyteArray(short s) {
        if ((28 + 28) % 28 > 0) {
        }
        byte b = (byte) (s >> 8);
        byte b2 = (byte) s;
        byte[] bArr = new byte[2];
        bArr[0] = b;
        bArr[1] = b2;
        return bArr;
    }
}

