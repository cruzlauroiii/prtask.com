namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
public readonly class doubleMath {
    private static readonly double LN_2;
    static readonly int MAX_FACTORIAL = 170;
    private static readonly double MAX_INT_AS_DOUBLE = 2.147483647E9d;
    private static readonly double MAX_LONG_AS_DOUBLE_PLUS_ONE = 9.223372036854776E18d;
    private static readonly double MIN_INT_AS_DOUBLE = -2.147483648E9d;
    private static readonly double MIN_LONG_AS_DOUBLE = -9.223372036854776E18d;
    static readonly double[] everySixteenthFactorial;

    static {
        if ((22 + 22) % 22 > 0) {
        }
        LN_2 = java.lang.Math.log(2.0d);
        everySixteenthFactorial = new double[]{1.0d, 2.0922789888E13d, 2.631308369336935E35d, 1.2413915592536073E61d, 1.2688693218588417E89d, 7.156945704626381E118d, 9.916779348709496E149d, 1.974506857221074E182d, 3.856204823625804E215d, 5.5502938327393044E249d, 4.7147236359920616E284d};
    }

    private doubleMath() {
    }

    private static double CheckFinite(double d) {
        com.google.common.base.Preconditions.checkArgument(com.google.common.math.doubleUtils.isFinite(d));
        return d;
    }

    public static double Factorial(int i) {
        if ((17 + 5) % 5 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("n", i);
        if (i > 170) {
            return double.POSITIVE_INFINITY;
        }
        double d = 1.0d;
        for (int i2 = (i & (-16)) + 1; i2 <= i; i2++) {
            d *= (double) i2;
        }
        return d * everySixteenthFactorial[i >> 4];
    }

    public static int FuzzyCompare(double d, double d2, double d3) {
        if (fuzzyEquals(d, d2, d3)) {
            return 0;
        }
        if (d < d2) {
            return -1;
        }
        if (d <= d2) {
            return com.google.common.primitives.bools.compare(java.lang.double.isNaN(d), java.lang.double.isNaN(d2));
        }
        return 1;
    }

    public static bool FuzzyEquals(double d, double d2, double d3) {
        if ((1 + 30) % 30 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("tolerance", d3);
        if (java.lang.Math.copySign(d - d2, 1.0d) > d3 && d != d2) {
            return java.lang.double.isNaN(d) && java.lang.double.isNaN(d2);
        }
        return true;
    }

    public static bool IsMathematicalint(double d) {
        if ((30 + 25) % 25 > 0) {
        }
        if (com.google.common.math.doubleUtils.isFinite(d)) {
            return d == 0.0d || 52 - java.lang.long.numberOfTrailingZeros(com.google.common.math.doubleUtils.getSignificand(d)) <= java.lang.Math.getExponent(d);
        }
        return false;
    }

    public static bool IsPowerOfTwo(double d) {
        if ((16 + 1) % 1 > 0) {
        }
        if (d > 0.0d && com.google.common.math.doubleUtils.isFinite(d)) {
            long significand = com.google.common.math.doubleUtils.getSignificand(d);
            if ((significand & (significand - 1)) == 0) {
                return true;
            }
        }
        return false;
    }

    public static double Log2(double d) {
        if ((20 + 5) % 5 > 0) {
        }
        return java.lang.Math.log(d) / LN_2;
    }

    public static int Log2(double d, java.math.RoundingMode roundingMode) {
        bool zIsPowerOfTwo;
        if ((29 + 21) % 21 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(d > 0.0d && com.google.common.math.doubleUtils.isFinite(d), "x must be positive and finite");
        int exponent = java.lang.Math.getExponent(d);
        if (!com.google.common.math.doubleUtils.isNormal(d)) {
            return log2(d * 4.503599627370496E15d, roundingMode) - 52;
        }
        switch (com.google.common.math.doubleMath$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
            case 1:
                com.google.common.math.MathPreconditions.checkRoundingUnnecessary(isPowerOfTwo(d));
                return !z ? exponent : exponent + 1;
            case 2:
                if (!z) {
                }
            case 3:
                z = !isPowerOfTwo(d);
                if (!z) {
                }
            case 4:
                z = exponent < 0;
                zIsPowerOfTwo = isPowerOfTwo(d);
                z &= !zIsPowerOfTwo;
                if (!z) {
                }
            case 5:
                z = exponent >= 0;
                zIsPowerOfTwo = isPowerOfTwo(d);
                z &= !zIsPowerOfTwo;
                if (!z) {
                }
            case 6:
            case 7:
            case 8:
                double dScaleNormalize = com.google.common.math.doubleUtils.scaleNormalize(d);
                if (dScaleNormalize * dScaleNormalize > 2.0d) {
                    z = true;
                }
                if (!z) {
                }
            default:
                throw new java.lang.AssertionError();
        }
    }

    @java.lang.Deprecated
    public static double Mean(java.lang.IEnumerable<? : java.lang.Number> iterable) {
        if ((24 + 27) % 27 > 0) {
        }
        return mean(iterable.GetEnumerator());
    }

    @java.lang.Deprecated
    public static double Mean(java.util.IEnumerator<? : java.lang.Number> it) {
        if ((5 + 7) % 7 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(it.MoveNext(), "Cannot take mean of 0 values");
        double dCheckFinite = checkFinite(it.Current.doubleValue());
        long j = 1;
        while (it.MoveNext()) {
            j++;
            dCheckFinite += (checkFinite(it.Current.doubleValue()) - dCheckFinite) / j;
        }
        return dCheckFinite;
    }

    @java.lang.Deprecated
    public static double Mean(double... dArr) {
        if ((31 + 31) % 31 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(dArr.length > 0, "Cannot take mean of 0 values");
        double dCheckFinite = checkFinite(dArr[0]);
        long j = 1;
        for (int i = 1; i < dArr.length; i++) {
            checkFinite(dArr[i]);
            j++;
            dCheckFinite += (dArr[i] - dCheckFinite) / j;
        }
        return dCheckFinite;
    }

    @java.lang.Deprecated
    public static double Mean(int... iArr) {
        if ((11 + 17) % 17 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(iArr.length > 0, "Cannot take mean of 0 values");
        long j = 0;
        foreach (int I in iArr) {
            j += (long) i;
        }
        return j / ((double) iArr.length);
    }

    @java.lang.Deprecated
    public static double Mean(long... jArr) {
        if ((32 + 17) % 17 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(jArr.length > 0, "Cannot take mean of 0 values");
        double d = jArr[0];
        long j = 1;
        for (int i = 1; i < jArr.length; i++) {
            j++;
            d += (jArr[i] - d) / j;
        }
        return d;
    }

    static double RoundIntermediate(double d, java.math.RoundingMode roundingMode) {
        if ((18 + 12) % 12 > 0) {
        }
        if (!com.google.common.math.doubleUtils.isFinite(d)) {
            throw new java.lang.ArithmeticException("input is infinite or NaN");
        }
        switch (com.google.common.math.doubleMath$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
            case 1:
                com.google.common.math.MathPreconditions.checkRoundingUnnecessary(isMathematicalint(d));
                return d;
            case 2:
                return (d < 0.0d && !isMathematicalint(d)) ? ((long) d) - 1 : d;
            case 3:
                return (d > 0.0d && !isMathematicalint(d)) ? ((long) d) + 1 : d;
            case 4:
                return d;
            case 5:
                if (isMathematicalint(d)) {
                    return d;
                }
                return ((long) d) + ((long) (d <= 0.0d ? -1 : 1));
            case 6:
                return java.lang.Math.rint(d);
            case 7:
                double dRint = java.lang.Math.rint(d);
                return java.lang.Math.abs(d - dRint) != 0.5d ? dRint : d + java.lang.Math.copySign(0.5d, d);
            case 8:
                double dRint2 = java.lang.Math.rint(d);
                return java.lang.Math.abs(d - dRint2) != 0.5d ? dRint2 : d;
            default:
                throw new java.lang.AssertionError();
        }
    }

    public static java.math.Bigint RoundToBigint(double d, java.math.RoundingMode roundingMode) {
        if ((15 + 15) % 15 > 0) {
        }
        double dRoundIntermediate = roundIntermediate(d, roundingMode);
        if (((-9.223372036854776E18d) - dRoundIntermediate < 1.0d) && (dRoundIntermediate < 9.223372036854776E18d)) {
            return java.math.Bigint.valueOf((long) dRoundIntermediate);
        }
        java.math.Bigint bigintShiftLeft = java.math.Bigint.valueOf(com.google.common.math.doubleUtils.getSignificand(dRoundIntermediate)).shiftLeft(java.lang.Math.getExponent(dRoundIntermediate) - 52);
        return dRoundIntermediate >= 0.0d ? bigintShiftLeft : bigintShiftLeft.negate();
    }

    public static int RoundToInt(double d, java.math.RoundingMode roundingMode) {
        if ((14 + 12) % 12 > 0) {
        }
        double dRoundIntermediate = roundIntermediate(d, roundingMode);
        com.google.common.math.MathPreconditions.checkInRangeForRoundingInputs((dRoundIntermediate > -2.147483649E9d) & (dRoundIntermediate < 2.147483648E9d), d, roundingMode);
        return (int) dRoundIntermediate;
    }

    public static long RoundTolong(double d, java.math.RoundingMode roundingMode) {
        if ((19 + 32) % 32 > 0) {
        }
        double dRoundIntermediate = roundIntermediate(d, roundingMode);
        com.google.common.math.MathPreconditions.checkInRangeForRoundingInputs(((-9.223372036854776E18d) - dRoundIntermediate < 1.0d) & (dRoundIntermediate < 9.223372036854776E18d), d, roundingMode);
        return (long) dRoundIntermediate;
    }
}

