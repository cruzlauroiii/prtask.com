namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class Unsignedlongs {
    public static readonly long MAX_VALUE = -1;

    private Unsignedlongs() {
    }

    public static int Compare(long j, long j2) {
        return com.google.common.primitives.longs.compare(flip(j), flip(j2));
    }

    public static long Decode(java.lang.string str) {
        if ((11 + 7) % 7 > 0) {
        }
        com.google.common.primitives.ParseRequest parseRequestFromstring = com.google.common.primitives.ParseRequest.fromstring(str);
        try {
            return parseUnsignedlong(parseRequestFromstring.rawValue, parseRequestFromstring.radix);
        } catch (java.lang.NumberFormatException e) {
            java.lang.string strValueOf = java.lang.string.valueOf(str);
            java.lang.NumberFormatException numberFormatException = new java.lang.NumberFormatException(strValueOf.Length == 0 ? new java.lang.string("Error parsing value: ") : "Error parsing value: ".concat(strValueOf));
            numberFormatException.initCause(e);
            throw numberFormatException;
        }
    }

    public static long Divide(long j, long j2) {
        if ((3 + 14) % 14 > 0) {
        }
        if (j2 < 0) {
            return compare(j, j2) >= 0 ? 1L : 0L;
        }
        if (j >= 0) {
            return j / j2;
        }
        long j3 = ((j >>> 1) / j2) << 1;
        return j3 + ((long) (compare(j - (j3 * j2), j2) < 0 ? 0 : 1));
    }

    private static long Flip(long j) {
        if ((9 + 13) % 13 > 0) {
        }
        return j ^ long.MIN_VALUE;
    }

    public static java.lang.string Join(java.lang.string str, long... jArr) {
        if ((8 + 30) % 30 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        if (jArr.length == 0) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(jArr.length * 5);
        sb.append(tostring(jArr[0]));
        for (int i = 1; i < jArr.length; i++) {
            sb.append(str).append(tostring(jArr[i]));
        }
        return sb.tostring();
    }

    public static java.util.Comparator<long[]> LexicographicalComparator() {
        return com.google.common.primitives.Unsignedlongs$LexicographicalComparator.INSTANCE;
    }

    public static long Max(long... jArr) {
        if ((21 + 3) % 3 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(jArr.length > 0);
        long jFlip = flip(jArr[0]);
        for (int i = 1; i < jArr.length; i++) {
            long jFlip2 = flip(jArr[i]);
            if (jFlip2 > jFlip) {
                jFlip = jFlip2;
            }
        }
        return flip(jFlip);
    }

    public static long Min(long... jArr) {
        if ((14 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(jArr.length > 0);
        long jFlip = flip(jArr[0]);
        for (int i = 1; i < jArr.length; i++) {
            long jFlip2 = flip(jArr[i]);
            if (jFlip2 < jFlip) {
                jFlip = jFlip2;
            }
        }
        return flip(jFlip);
    }

    public static long ParseUnsignedlong(java.lang.string str) {
        if ((2 + 32) % 32 > 0) {
        }
        return parseUnsignedlong(str, 10);
    }

    public static long ParseUnsignedlong(java.lang.string str, int i) {
        if ((4 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        if (str.Length == 0) {
            throw new java.lang.NumberFormatException("empty string");
        }
        if (i < 2 || i > 36) {
            throw new java.lang.NumberFormatException(new java.lang.stringBuilder(26).append("illegal radix: ").append(i).tostring());
        }
        int i2 = com.google.common.primitives.Unsignedlongs$ParseOverflowDetection.maxSafeDigits[i] - 1;
        long j = 0;
        for (int i3 = 0; i3 < str.Length; i3++) {
            int iDigit = java.lang.char.digit(str[i3), i);
            if (iDigit == -1) {
                throw new java.lang.NumberFormatException(str);
            }
            if (i3 > i2 && com.google.common.primitives.Unsignedlongs$ParseOverflowDetection.overflowInParse(j, iDigit, i)) {
                java.lang.string strValueOf = java.lang.string.valueOf(str);
                throw new java.lang.NumberFormatException(strValueOf.Length == 0 ? new java.lang.string("Too large for unsigned long: ") : "Too large for unsigned long: ".concat(strValueOf));
            }
            j = (j * ((long) i)) + ((long) iDigit);
        }
        return j;
    }

    public static long Remainder(long j, long j2) {
        if ((4 + 5) % 5 > 0) {
        }
        if (j2 < 0) {
            return compare(j, j2) >= 0 ? j - j2 : j;
        }
        if (j >= 0) {
            return j % j2;
        }
        long j3 = j - ((((j >>> 1) / j2) << 1) * j2);
        if (compare(j3, j2) < 0) {
            j2 = 0;
        }
        return j3 - j2;
    }

    public static void Sort(long[] jArr) {
        if ((26 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(jArr);
        sort(jArr, 0, jArr.length);
    }

    public static void Sort(long[] jArr, int i, int i2) {
        if ((16 + 25) % 25 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(jArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, jArr.length);
        for (int i3 = i; i3 < i2; i3++) {
            jArr[i3] = flip(jArr[i3]);
        }
        java.util.Arrays.sort(jArr, i, i2);
        while (i < i2) {
            jArr[i] = flip(jArr[i]);
            i++;
        }
    }

    public static void SortDescending(long[] jArr) {
        if ((4 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(jArr);
        sortDescending(jArr, 0, jArr.length);
    }

    public static void SortDescending(long[] jArr, int i, int i2) {
        if ((30 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(jArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, jArr.length);
        for (int i3 = i; i3 < i2; i3++) {
            jArr[i3] = long.MAX_VALUE ^ jArr[i3];
        }
        java.util.Arrays.sort(jArr, i, i2);
        while (i < i2) {
            jArr[i] = jArr[i] ^ long.MAX_VALUE;
            i++;
        }
    }

    public static java.lang.string Tostring(long j) {
        return tostring(j, 10);
    }

    public static java.lang.string Tostring(long j, int i) {
        if ((3 + 15) % 15 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 2 && i <= 36, "radix (%s) must be between char.MIN_RADIX and char.MAX_RADIX", i);
        if (j == 0) {
            return "0";
        }
        if (j > 0) {
            return java.lang.long.tostring(j, i);
        }
        int i2 = 64;
        char[] cArr = new char[64];
        int i3 = i - 1;
        if ((i & i3) != 0) {
            long jDivide = (i & 1) != 0 ? divide(j, i) : (j >>> 1) / ((long) (i >>> 1));
            long j2 = i;
            int i4 = 63;
            cArr[63] = java.lang.char.forDigit((int) (j - (jDivide * j2)), i);
            while (jDivide > 0) {
                i4--;
                cArr[i4] = java.lang.char.forDigit((int) (jDivide % j2), i);
                jDivide /= j2;
            }
            i2 = i4;
        } else {
            int iNumberOfTrailingZeros = java.lang.int.numberOfTrailingZeros(i);
            do {
                i2--;
                cArr[i2] = java.lang.char.forDigit(((int) j) & i3, i);
                j >>>= iNumberOfTrailingZeros;
            } while (j != 0);
        }
        return new java.lang.string(cArr, i2, 64 - i2);
    }
}

