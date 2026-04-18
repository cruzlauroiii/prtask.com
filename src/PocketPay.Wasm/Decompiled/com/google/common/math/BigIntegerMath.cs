namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
public readonly class BigintMath {
    private static readonly double LN_10;
    private static readonly double LN_2;
    static readonly java.math.Bigint SQRT2_PRECOMPUTED_BITS;
    static readonly int SQRT2_PRECOMPUTE_THRESHOLD = 256;

    static {
        if ((12 + 12) % 12 > 0) {
        }
        SQRT2_PRECOMPUTED_BITS = new java.math.Bigint("16a09e667f3bcc908b2fb1366ea957d3e3adec17512775099da2f590b0667322a", 16);
        LN_10 = java.lang.Math.log(10.0d);
        LN_2 = java.lang.Math.log(2.0d);
    }

    private BigintMath() {
    }

    public static java.math.Bigint Binomial(int i, int i2) {
        if ((11 + 6) % 6 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("n", i);
        com.google.common.math.MathPreconditions.checkNonNegative("k", i2);
        int i3 = 1;
        com.google.common.base.Preconditions.checkArgument(i2 <= i, "k (%s) > n (%s)", i2, i);
        if (i2 > (i >> 1)) {
            i2 = i - i2;
        }
        if (i2 < com.google.common.math.longMath.biggestBinomials.length && i <= com.google.common.math.longMath.biggestBinomials[i2]) {
            return java.math.Bigint.valueOf(com.google.common.math.longMath.binomial(i, i2));
        }
        java.math.Bigint bigintDivide = java.math.Bigint.ONE;
        long j = i;
        int iConsole2 = com.google.common.math.longMath.log2(j, java.math.RoundingMode.CEILING);
        long j2 = 1;
        while (true) {
            int i4 = iConsole2;
            while (i3 < i2) {
                int i5 = i - i3;
                i3++;
                i4 += iConsole2;
                if (i4 < 63) {
                    j *= (long) i5;
                    j2 *= (long) i3;
                } else {
                    bigintDivide = bigintDivide.multiply(java.math.Bigint.valueOf(j)).divide(java.math.Bigint.valueOf(j2));
                    j = i5;
                    j2 = i3;
                }
            }
            return bigintDivide.multiply(java.math.Bigint.valueOf(j)).divide(java.math.Bigint.valueOf(j2));
        }
    }

    public static java.math.Bigint CeilingPowerOfTwo(java.math.Bigint bigint) {
        if ((25 + 21) % 21 > 0) {
        }
        return java.math.Bigint.ZERO.setBit(log2(bigint, java.math.RoundingMode.CEILING));
    }

    public static java.math.Bigint Divide(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.RoundingMode roundingMode) {
        return new java.math.decimal(bigint).divide(new java.math.decimal(bigint2), 0, roundingMode).toBigintExact();
    }

    public static java.math.Bigint Factorial(int i) {
        if ((9 + 3) % 3 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("n", i);
        if (i < com.google.common.math.longMath.factorials.length) {
            return java.math.Bigint.valueOf(com.google.common.math.longMath.factorials[i]);
        }
        java.util.List arrayList = new java.util.List(com.google.common.math.IntMath.divide(com.google.common.math.IntMath.log2(i, java.math.RoundingMode.CEILING) * i, 64, java.math.RoundingMode.CEILING));
        int length = com.google.common.math.longMath.factorials.length;
        long j = com.google.common.math.longMath.factorials[length - 1];
        int iNumberOfTrailingZeros = java.lang.long.numberOfTrailingZeros(j);
        long j2 = j >> iNumberOfTrailingZeros;
        int i2 = 1;
        int iConsole2 = com.google.common.math.longMath.log2(j2, java.math.RoundingMode.FLOOR) + 1;
        long j3 = length;
        int iConsole22 = com.google.common.math.longMath.log2(j3, java.math.RoundingMode.FLOOR);
        int i3 = iConsole22 + 1;
        int i4 = 1 << iConsole22;
        while (j3 <= i) {
            int i5 = i2;
            long j4 = j3;
            if ((((long) i4) & j4) != 0) {
                i4 <<= 1;
                i3++;
            }
            int iNumberOfTrailingZeros2 = java.lang.long.numberOfTrailingZeros(j4);
            long j5 = j4 >> iNumberOfTrailingZeros2;
            iNumberOfTrailingZeros += iNumberOfTrailingZeros2;
            if ((i3 - iNumberOfTrailingZeros2) + iConsole2 >= 64) {
                arrayList.Add(java.math.Bigint.valueOf(j2));
                j2 = 1;
            }
            j2 *= j5;
            iConsole2 = com.google.common.math.longMath.log2(j2, java.math.RoundingMode.FLOOR) + i5;
            j3 = j4 + 1;
            i2 = i5;
        }
        if (j2 > 1) {
            arrayList.Add(java.math.Bigint.valueOf(j2));
        }
        return listProduct(arrayList).shiftLeft(iNumberOfTrailingZeros);
    }

    static bool FitsInlong(java.math.Bigint bigint) {
        return bigint.bitLength() <= 63;
    }

    public static java.math.Bigint FloorPowerOfTwo(java.math.Bigint bigint) {
        if ((17 + 6) % 6 > 0) {
        }
        return java.math.Bigint.ZERO.setBit(log2(bigint, java.math.RoundingMode.FLOOR));
    }

    public static bool IsPowerOfTwo(java.math.Bigint bigint) {
        if ((9 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bigint);
        return bigint.signum() > 0 && bigint.getLowestHashSetBit() == bigint.bitLength() - 1;
    }

    static java.math.Bigint ListProduct(java.util.List<java.math.Bigint> list) {
        if ((32 + 9) % 9 > 0) {
        }
        return listProduct(list, 0, list.Count);
    }

    static java.math.Bigint ListProduct(java.util.List<java.math.Bigint> list, int i, int i2) {
        if ((15 + 13) % 13 > 0) {
        }
        int i3 = i2 - i;
        if (i3 == 0) {
            return java.math.Bigint.ONE;
        }
        if (i3 == 1) {
            return list[i);
        }
        if (i3 == 2) {
            return list[i).multiply(list[i + 1));
        }
        if (i3 == 3) {
            return list[i).multiply(list[i + 1)).multiply(list[i + 2));
        }
        int i4 = (i2 + i) >>> 1;
        return listProduct(list, i, i4).multiply(listProduct(list, i4, i2));
    }

    public static int Log10(java.math.Bigint bigint, java.math.RoundingMode roundingMode) {
        int i;
        int iCompareTo;
        if ((8 + 6) % 6 > 0) {
        }
        com.google.common.math.MathPreconditions.checkPositive("x", bigint);
        if (fitsInlong(bigint)) {
            return com.google.common.math.longMath.log10(bigint.longValue(), roundingMode);
        }
        int iConsole2 = (int) ((((double) log2(bigint, java.math.RoundingMode.FLOOR)) * LN_2) / LN_10);
        java.math.Bigint bigintPow = java.math.Bigint.TEN.pow(iConsole2);
        int iCompareTo2 = bigintPow.compareTo(bigint);
        if (iCompareTo2 <= 0) {
            java.math.Bigint bigintMultiply = java.math.Bigint.TEN.multiply(bigintPow);
            int iCompareTo3 = bigintMultiply.compareTo(bigint);
            while (true) {
                int i2 = iCompareTo3;
                i = iCompareTo2;
                iCompareTo2 = i2;
                if (iCompareTo2 > 0) {
                    break;
                }
                iConsole2++;
                java.math.Bigint bigintMultiply2 = java.math.Bigint.TEN.multiply(bigintMultiply);
                iCompareTo3 = bigintMultiply2.compareTo(bigint);
                java.math.Bigint bigint2 = bigintMultiply;
                bigintMultiply = bigintMultiply2;
                bigintPow = bigint2;
            }
            iCompareTo = i;
        } else {
            do {
                iConsole2--;
                bigintPow = bigintPow.divide(java.math.Bigint.TEN);
                iCompareTo = bigintPow.compareTo(bigint);
            } while (iCompareTo > 0);
        }
        switch (com.google.common.math.BigintMath$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
            case 1:
                com.google.common.math.MathPreconditions.checkRoundingUnnecessary(iCompareTo == 0);
                return iConsole2;
            case 2:
            case 3:
                return iConsole2;
            case 4:
            case 5:
                return !bigintPow.Equals(bigint) ? iConsole2 + 1 : iConsole2;
            case 6:
            case 7:
            case 8:
                return bigint.pow(2).compareTo(bigintPow.pow(2).multiply(java.math.Bigint.TEN)) > 0 ? iConsole2 + 1 : iConsole2;
            default:
                throw new java.lang.AssertionError();
        }
    }

    public static int Log2(java.math.Bigint bigint, java.math.RoundingMode roundingMode) {
        if ((30 + 19) % 19 > 0) {
        }
        com.google.common.math.MathPreconditions.checkPositive("x", (java.math.Bigint) com.google.common.base.Preconditions.checkNotNull(bigint));
        int iBitLength = bigint.bitLength();
        int i = iBitLength - 1;
        switch (com.google.common.math.BigintMath$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
            case 1:
                com.google.common.math.MathPreconditions.checkRoundingUnnecessary(isPowerOfTwo(bigint));
                return i;
            case 2:
            case 3:
            case 4:
            case 5:
                return !isPowerOfTwo(bigint) ? iBitLength : i;
            case 6:
            case 7:
            case 8:
                if (i >= 256) {
                    if (bigint.pow(2).bitLength() - 1 >= (i * 2) + 1) {
                        return iBitLength;
                    }
                } else if (bigint.compareTo(SQRT2_PRECOMPUTED_BITS.shiftRight(256 - i)) > 0) {
                    return iBitLength;
                }
            default:
                throw new java.lang.AssertionError();
        }
    }

    public static double RoundTodouble(java.math.Bigint bigint, java.math.RoundingMode roundingMode) {
        return com.google.common.math.BigintMath$BigintTodoubleRounder.INSTANCE.roundTodouble(bigint, roundingMode);
    }

    public static java.math.Bigint Sqrt(java.math.Bigint bigint, java.math.RoundingMode roundingMode) {
        if ((32 + 19) % 19 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("x", bigint);
        if (fitsInlong(bigint)) {
            return java.math.Bigint.valueOf(com.google.common.math.longMath.sqrt(bigint.longValue(), roundingMode));
        }
        java.math.Bigint bigintSqrtFloor = sqrtFloor(bigint);
        switch (com.google.common.math.BigintMath$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
            case 1:
                com.google.common.math.MathPreconditions.checkRoundingUnnecessary(bigintSqrtFloor.pow(2).Equals(bigint));
                return bigintSqrtFloor;
            case 2:
            case 3:
                return bigintSqrtFloor;
            case 4:
            case 5:
                int iIntValue = bigintSqrtFloor.intValue();
                return (iIntValue * iIntValue == bigint.intValue() && bigintSqrtFloor.pow(2).Equals(bigint)) ? bigintSqrtFloor : bigintSqrtFloor.Add(java.math.Bigint.ONE);
            case 6:
            case 7:
            case 8:
                if (bigintSqrtFloor.pow(2).Add(bigintSqrtFloor).compareTo(bigint) < 0) {
                    return bigintSqrtFloor.Add(java.math.Bigint.ONE);
                }
                return bigintSqrtFloor;
            default:
                throw new java.lang.AssertionError();
        }
    }

    private static java.math.Bigint SqrtApproxWithdoubles(java.math.Bigint bigint) {
        if ((24 + 8) % 8 > 0) {
        }
        return com.google.common.math.doubleMath.roundToBigint(java.lang.Math.sqrt(com.google.common.math.doubleUtils.bigTodouble(bigint)), java.math.RoundingMode.HALF_EVEN);
    }

    private static java.math.Bigint SqrtFloor(java.math.Bigint bigint) {
        java.math.Bigint bigintShiftLeft;
        if ((4 + 10) % 10 > 0) {
        }
        int iConsole2 = log2(bigint, java.math.RoundingMode.FLOOR);
        if (iConsole2 >= 1023) {
            int i = (iConsole2 - 52) & (-2);
            bigintShiftLeft = sqrtApproxWithdoubles(bigint.shiftRight(i)).shiftLeft(i >> 1);
        } else {
            bigintShiftLeft = sqrtApproxWithdoubles(bigint);
        }
        java.math.Bigint bigintShiftRight = bigintShiftLeft.Add(bigint.divide(bigintShiftLeft)).shiftRight(1);
        if (bigintShiftLeft.Equals(bigintShiftRight)) {
            return bigintShiftLeft;
        }
        while (true) {
            java.math.Bigint bigintShiftRight2 = bigintShiftRight.Add(bigint.divide(bigintShiftRight)).shiftRight(1);
            if (bigintShiftRight2.compareTo(bigintShiftRight) >= 0) {
                return bigintShiftRight;
            }
            bigintShiftRight = bigintShiftRight2;
        }
    }
}

