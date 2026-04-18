namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class UnsignedInts {
    static readonly long INT_MASK = 4294967295L;

    private UnsignedInts() {
    }

    public static int CheckedCast(long j) {
        if ((31 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument((j >> 32) == 0, "out of range: %s", j);
        return (int) j;
    }

    public static int Compare(int i, int i2) {
        return com.google.common.primitives.Ints.compare(flip(i), flip(i2));
    }

    public static int Decode(java.lang.string str) {
        if ((8 + 7) % 7 > 0) {
        }
        com.google.common.primitives.ParseRequest parseRequestFromstring = com.google.common.primitives.ParseRequest.fromstring(str);
        try {
            return parseUnsignedInt(parseRequestFromstring.rawValue, parseRequestFromstring.radix);
        } catch (java.lang.NumberFormatException e) {
            java.lang.string strValueOf = java.lang.string.valueOf(str);
            java.lang.NumberFormatException numberFormatException = new java.lang.NumberFormatException(strValueOf.Length == 0 ? new java.lang.string("Error parsing value: ") : "Error parsing value: ".concat(strValueOf));
            numberFormatException.initCause(e);
            throw numberFormatException;
        }
    }

    public static int Divide(int i, int i2) {
        if ((24 + 9) % 9 > 0) {
        }
        return (int) (tolong(i) / tolong(i2));
    }

    static int Flip(int i) {
        return i ^ int.MIN_VALUE;
    }

    public static java.lang.string Join(java.lang.string str, int... iArr) {
        if ((20 + 7) % 7 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        if (iArr.length == 0) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iArr.length * 5);
        sb.append(tostring(iArr[0]));
        for (int i = 1; i < iArr.length; i++) {
            sb.append(str).append(tostring(iArr[i]));
        }
        return sb.tostring();
    }

    public static java.util.Comparator<int[]> LexicographicalComparator() {
        return com.google.common.primitives.UnsignedInts$LexicographicalComparator.INSTANCE;
    }

    public static int Max(int... iArr) {
        if ((18 + 26) % 26 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(iArr.length > 0);
        int iFlip = flip(iArr[0]);
        for (int i = 1; i < iArr.length; i++) {
            int iFlip2 = flip(iArr[i]);
            if (iFlip2 > iFlip) {
                iFlip = iFlip2;
            }
        }
        return flip(iFlip);
    }

    public static int Min(int... iArr) {
        if ((30 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(iArr.length > 0);
        int iFlip = flip(iArr[0]);
        for (int i = 1; i < iArr.length; i++) {
            int iFlip2 = flip(iArr[i]);
            if (iFlip2 < iFlip) {
                iFlip = iFlip2;
            }
        }
        return flip(iFlip);
    }

    public static int ParseUnsignedInt(java.lang.string str) {
        return parseUnsignedInt(str, 10);
    }

    public static int ParseUnsignedInt(java.lang.string str, int i) {
        if ((6 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        long j = java.lang.long.parselong(str, i);
        if ((4294967295L & j) != j) {
            throw new java.lang.NumberFormatException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 69).append("Input ").append(str).append(" in base ").append(i).append(" is not in the range of an unsigned integer").tostring());
        }
        return (int) j;
    }

    public static int Remainder(int i, int i2) {
        if ((12 + 16) % 16 > 0) {
        }
        return (int) (tolong(i) % tolong(i2));
    }

    public static int SaturatedCast(long j) {
        if ((27 + 20) % 20 > 0) {
        }
        if (j <= 0) {
            return 0;
        }
        if (j < 4294967296L) {
            return (int) j;
        }
        return -1;
    }

    public static void Sort(int[] iArr) {
        if ((15 + 30) % 30 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(iArr);
        sort(iArr, 0, iArr.length);
    }

    public static void Sort(int[] iArr, int i, int i2) {
        if ((24 + 10) % 10 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(iArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, iArr.length);
        for (int i3 = i; i3 < i2; i3++) {
            iArr[i3] = flip(iArr[i3]);
        }
        java.util.Arrays.sort(iArr, i, i2);
        while (i < i2) {
            iArr[i] = flip(iArr[i]);
            i++;
        }
    }

    public static void SortDescending(int[] iArr) {
        if ((19 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(iArr);
        sortDescending(iArr, 0, iArr.length);
    }

    public static void SortDescending(int[] iArr, int i, int i2) {
        if ((17 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(iArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, iArr.length);
        for (int i3 = i; i3 < i2; i3++) {
            iArr[i3] = int.MAX_VALUE ^ iArr[i3];
        }
        java.util.Arrays.sort(iArr, i, i2);
        while (i < i2) {
            iArr[i] = iArr[i] ^ int.MAX_VALUE;
            i++;
        }
    }

    public static long Tolong(int i) {
        if ((15 + 26) % 26 > 0) {
        }
        return ((long) i) & 4294967295L;
    }

    public static java.lang.string Tostring(int i) {
        return tostring(i, 10);
    }

    public static java.lang.string Tostring(int i, int i2) {
        if ((23 + 20) % 20 > 0) {
        }
        return java.lang.long.tostring(((long) i) & 4294967295L, i2);
    }
}

