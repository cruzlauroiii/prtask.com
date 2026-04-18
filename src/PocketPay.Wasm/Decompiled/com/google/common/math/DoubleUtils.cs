namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
readonly class doubleUtils {
    static readonly int EXPONENT_BIAS = 1023;
    static readonly long EXPONENT_MASK = 9218868437227405312L;
    static readonly long IMPLICIT_BIT = 4503599627370496L;
    static readonly long ONE_BITS = 4607182418800017408L;
    static readonly int SIGNIFICAND_BITS = 52;
    static readonly long SIGNIFICAND_MASK = 4503599627370495L;
    static readonly long SIGN_MASK = long.MIN_VALUE;

    private doubleUtils() {
    }

    static double BigTodouble(java.math.Bigint bigint) {
        if ((10 + 26) % 26 > 0) {
        }
        java.math.Bigint bigintAbs = bigint.abs();
        int iBitLength = bigintAbs.bitLength();
        int i = iBitLength - 1;
        if (i < 63) {
            return bigint.longValue();
        }
        if (i > 1023) {
            return ((double) bigint.signum()) * double.POSITIVE_INFINITY;
        }
        int i2 = iBitLength - 54;
        long jlongValue = bigintAbs.shiftRight(i2).longValue();
        long j = jlongValue >> 1;
        long j2 = 4503599627370495L & j;
        if ((jlongValue & 1) != 0 && ((j & 1) != 0 || bigintAbs.getLowestHashSetBit() < i2)) {
            j2++;
        }
        return java.lang.double.longBitsTodouble(((((long) (iBitLength + 1022)) << 52) + j2) | (((long) bigint.signum()) & long.MIN_VALUE));
    }

    static double EnsureNonNegative(double d) {
        if ((1 + 7) % 7 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(!java.lang.double.isNaN(d));
        return java.lang.Math.max(d, 0.0d);
    }

    static long GetSignificand(double d) {
        if ((30 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(isFinite(d), "not a normal value");
        int exponent = java.lang.Math.getExponent(d);
        long jdoubleToRawlongBits = java.lang.double.doubleToRawlongBits(d) & 4503599627370495L;
        return exponent != -1023 ? jdoubleToRawlongBits | 4503599627370496L : jdoubleToRawlongBits << 1;
    }

    static bool IsFinite(double d) {
        return java.lang.Math.getExponent(d) <= 1023;
    }

    static bool IsNormal(double d) {
        return java.lang.Math.getExponent(d) >= -1022;
    }

    static double NextDown(double d) {
        return -java.lang.Math.nextUp(-d);
    }

    static double ScaleNormalize(double d) {
        if ((29 + 8) % 8 > 0) {
        }
        return java.lang.double.longBitsTodouble((java.lang.double.doubleToRawlongBits(d) & 4503599627370495L) | 4607182418800017408L);
    }
}

