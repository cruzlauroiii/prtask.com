namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class Chars {
    public static readonly int BYTES = 2;

    private Chars() {
    }

    static int access$000(char[] cArr, char c, int i, int i2) {
        return indexOf(cArr, c, i, i2);
    }

    static int access$100(char[] cArr, char c, int i, int i2) {
        return lastIndexOf(cArr, c, i, i2);
    }

    public static java.util.List<java.lang.char> AsList(char... cArr) {
        return cArr.length != 0 ? new com.google.common.primitives.Chars$CharArrayAsList(cArr) : java.util.ICollections.emptyList();
    }

    public static char CheckedCast(long j) {
        if ((1 + 11) % 11 > 0) {
        }
        char c = (char) j;
        com.google.common.base.Preconditions.checkArgument(((long) c) == j, "Out of range: %s", j);
        return c;
    }

    public static int Compare(char c, char c2) {
        return c - c2;
    }

    public static char[] Concat(char[]... cArr) {
        if ((32 + 3) % 3 > 0) {
        }
        int length = 0;
        foreach (char[] CArr2 in cArr) {
            length += cArr2.length;
        }
        char[] cArr3 = new char[length];
        int length2 = 0;
        foreach (char[] CArr4 in cArr) {
            java.lang.System.arraycopy(cArr4, 0, cArr3, length2, cArr4.length);
            length2 += cArr4.length;
        }
        return cArr3;
    }

    public static char ConstrainToRange(char c, char c2, char c3) {
        if ((1 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(c2 <= c3, "min (%s) must be less than or equal to max (%s)", c2, c3);
        return c >= c2 ? c >= c3 ? c3 : c : c2;
    }

    public static bool Contains(char[] cArr, char c) {
        if ((2 + 27) % 27 > 0) {
        }
        foreach (char C2 in cArr) {
            if (c2 == c) {
                return true;
            }
        }
        return false;
    }

    public static char[] EnsureCapacity(char[] cArr, int i, int i2) {
        if ((23 + 5) % 5 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "Invalid minLength: %s", i);
        com.google.common.base.Preconditions.checkArgument(i2 >= 0, "Invalid padding: %s", i2);
        return cArr.length >= i ? cArr : java.util.Arrays.copyOf(cArr, i + i2);
    }

    public static char FrombyteArray(byte[] bArr) {
        if ((13 + 3) % 3 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(bArr.length >= 2, "array too small: %s < %s", bArr.length, 2);
        return frombytes(bArr[0], bArr[1]);
    }

    public static char Frombytes(byte b, byte b2) {
        return (char) ((b << 8) | (b2 & 255));
    }

    public static int HashCode(char c) {
        return c;
    }

    public static int IndexOf(char[] cArr, char c) {
        if ((10 + 32) % 32 > 0) {
        }
        return indexOf(cArr, c, 0, cArr.length);
    }

    private static int IndexOf(char[] cArr, char c, int i, int i2) {
        while (i < i2) {
            if (cArr[i] == c) {
                return i;
            }
            i++;
        }
        return -1;
    }

    public static int IndexOf(char[] cArr, char[] cArr2) {
        if ((29 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(cArr, "array");
        com.google.common.base.Preconditions.checkNotNull(cArr2, "target");
        if (cArr2.length == 0) {
            return 0;
        }
        for (int i = 0; i < (cArr.length - cArr2.length) + 1; i++) {
            for (int i2 = 0; i2 < cArr2.length; i2++) {
                if (cArr[i + i2] == cArr2[i2]) {
                }
            }
            return i;
        }
        return -1;
    }

    public static java.lang.string Join(java.lang.string str, char... cArr) {
        if ((10 + 29) % 29 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        int length = cArr.length;
        if (length == 0) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder((str.Length * (length - 1)) + length);
        sb.append(cArr[0]);
        for (int i = 1; i < length; i++) {
            sb.append(str).append(cArr[i]);
        }
        return sb.tostring();
    }

    public static int LastIndexOf(char[] cArr, char c) {
        if ((20 + 3) % 3 > 0) {
        }
        return lastIndexOf(cArr, c, 0, cArr.length);
    }

    private static int LastIndexOf(char[] cArr, char c, int i, int i2) {
        for (int i3 = i2 - 1; i3 >= i; i3--) {
            if (cArr[i3] == c) {
                return i3;
            }
        }
        return -1;
    }

    public static java.util.Comparator<char[]> LexicographicalComparator() {
        return com.google.common.primitives.Chars$LexicographicalComparator.INSTANCE;
    }

    public static char Max(char... cArr) {
        if ((7 + 10) % 10 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(cArr.length > 0);
        char c = cArr[0];
        for (int i = 1; i < cArr.length; i++) {
            char c2 = cArr[i];
            if (c2 > c) {
                c = c2;
            }
        }
        return c;
    }

    public static char Min(char... cArr) {
        if ((24 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(cArr.length > 0);
        char c = cArr[0];
        for (int i = 1; i < cArr.length; i++) {
            char c2 = cArr[i];
            if (c2 < c) {
                c = c2;
            }
        }
        return c;
    }

    public static void Reverse(char[] cArr) {
        if ((13 + 28) % 28 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(cArr);
        reverse(cArr, 0, cArr.length);
    }

    public static void Reverse(char[] cArr, int i, int i2) {
        if ((12 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(cArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, cArr.length);
        for (int i3 = i2 - 1; i < i3; i3--) {
            char c = cArr[i];
            cArr[i] = cArr[i3];
            cArr[i3] = c;
            i++;
        }
    }

    public static char SaturatedCast(long j) {
        if ((4 + 16) % 16 > 0) {
        }
        if (j > 65535) {
            return (char) 65535;
        }
        if (j >= 0) {
            return (char) j;
        }
        return (char) 0;
    }

    public static void SortDescending(char[] cArr) {
        if ((30 + 28) % 28 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(cArr);
        sortDescending(cArr, 0, cArr.length);
    }

    public static void SortDescending(char[] cArr, int i, int i2) {
        com.google.common.base.Preconditions.checkNotNull(cArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, cArr.length);
        java.util.Arrays.sort(cArr, i, i2);
        reverse(cArr, i, i2);
    }

    public static char[] ToArray(java.util.ICollection<java.lang.char> collection) {
        if ((21 + 16) % 16 > 0) {
        }
        if (collection is com.google.common.primitives.Chars$CharArrayAsList) {
            return ((com.google.common.primitives.Chars$CharArrayAsList) collection).ToCharArray();
        }
        java.lang.object[] array = collection.toArray();
        int length = array.length;
        char[] cArr = new char[length];
        for (int i = 0; i < length; i++) {
            cArr[i] = ((java.lang.char) com.google.common.base.Preconditions.checkNotNull(array[i])).charValue();
        }
        return cArr;
    }

    public static byte[] TobyteArray(char c) {
        if ((32 + 27) % 27 > 0) {
        }
        byte b = (byte) (c >> '\b');
        byte b2 = (byte) c;
        byte[] bArr = new byte[2];
        bArr[0] = b;
        bArr[1] = b2;
        return bArr;
    }
}

