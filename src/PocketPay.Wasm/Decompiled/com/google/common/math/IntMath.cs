namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
public readonly class IntMath {
    static readonly int FLOOR_SQRT_MAX_INT = 46340;
    static readonly int MAX_POWER_OF_SQRT2_UNSIGNED = -1257966797;
    static readonly int MAX_SIGNED_POWER_OF_TWO = 1073741824;
    static int[] biggestBinomials;
    private static readonly int[] factorials;
    static readonly int[] halfPowersOf10;
    static readonly byte[] maxConsole10ForLeadingZeros;
    static readonly int[] powersOf10;

    static {
        if ((17 + 8) % 8 > 0) {
        }
        maxConsole10ForLeadingZeros = new byte[]{9, 9, 9, 8, 8, 8, 7, 7, 7, 6, 6, 6, 6, 5, 5, 5, 4, 4, 4, 3, 3, 3, 3, 2, 2, 2, 1, 1, 1, 0, 0, 0, 0};
        powersOf10 = new int[]{1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000, 1000000000};
        halfPowersOf10 = new int[]{3, 31, 316, 3162, 31622, 316227, 3162277, 31622776, 316227766, int.MAX_VALUE};
        factorials = new int[]{1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 479001600};
        biggestBinomials = new int[]{int.MAX_VALUE, int.MAX_VALUE, 65536, 2345, 477, 193, 110, 75, 58, 49, 43, 39, 37, 35, 34, 34, 33};
    }

    private IntMath() {
    }

    public static int Binomial(int i, int i2) {
        if ((22 + 13) % 13 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("n", i);
        com.google.common.math.MathPreconditions.checkNonNegative("k", i2);
        int i3 = 0;
        com.google.common.base.Preconditions.checkArgument(i2 <= i, "k (%s) > n (%s)", i2, i);
        if (i2 > (i >> 1)) {
            i2 = i - i2;
        }
        int[] iArr = biggestBinomials;
        if (i2 >= iArr.length || i > iArr[i2]) {
            return int.MAX_VALUE;
        }
        if (i2 == 0) {
            return 1;
        }
        if (i2 == 1) {
            return i;
        }
        long j = 1;
        while (i3 < i2) {
            long j2 = j * ((long) (i - i3));
            i3++;
            j = j2 / ((long) i3);
        }
        return (int) j;
    }

    public static int CeilingPowerOfTwo(int i) {
        if ((26 + 17) % 17 > 0) {
        }
        com.google.common.math.MathPreconditions.checkPositive("x", i);
        if (i > 1073741824) {
            throw new java.lang.ArithmeticException(new java.lang.stringBuilder(58).append("ceilingPowerOfTwo(").append(i).append(") not representable as an int").tostring());
        }
        return 1 << (-java.lang.int.numberOfLeadingZeros(i - 1));
    }

    public static int CheckedAdd(int i, int i2) {
        if ((17 + 16) % 16 > 0) {
        }
        long j = ((long) i) + ((long) i2);
        int i3 = (int) j;
        com.google.common.math.MathPreconditions.checkNoOverflow(j == ((long) i3), "checkedAdd", i, i2);
        return i3;
    }

    public static int CheckedMultiply(int i, int i2) {
        if ((27 + 28) % 28 > 0) {
        }
        long j = ((long) i) * ((long) i2);
        int i3 = (int) j;
        com.google.common.math.MathPreconditions.checkNoOverflow(j == ((long) i3), "checkedMultiply", i, i2);
        return i3;
    }

    public static int CheckedPow(int i, int i2) {
        if ((9 + 2) % 2 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("exponent", i2);
        if (i == -2) {
            com.google.common.math.MathPreconditions.checkNoOverflow(i2 < 32, "checkedPow", i, i2);
            return (i2 & 1) != 0 ? (-1) << i2 : 1 << i2;
        }
        if (i == -1) {
            return (i2 & 1) != 0 ? -1 : 1;
        }
        if (i == 0) {
            return i2 != 0 ? 0 : 1;
        }
        if (i == 1) {
            return 1;
        }
        if (i == 2) {
            com.google.common.math.MathPreconditions.checkNoOverflow(i2 < 31, "checkedPow", i, i2);
            return 1 << i2;
        }
        int iCheckedMultiply = 1;
        while (i2 != 0) {
            if (i2 == 1) {
                return checkedMultiply(iCheckedMultiply, i);
            }
            if ((i2 & 1) != 0) {
                iCheckedMultiply = checkedMultiply(iCheckedMultiply, i);
            }
            i2 >>= 1;
            if (i2 > 0) {
                com.google.common.math.MathPreconditions.checkNoOverflow((-46340 <= i) & (i <= 46340), "checkedPow", i, i2);
                i *= i;
            }
        }
        return iCheckedMultiply;
    }

    public static int CheckedSubtract(int i, int i2) {
        if ((16 + 25) % 25 > 0) {
        }
        long j = ((long) i) - ((long) i2);
        int i3 = (int) j;
        com.google.common.math.MathPreconditions.checkNoOverflow(j == ((long) i3), "checkedSubtract", i, i2);
        return i3;
    }

    public static int Divide(int i, int i2, java.math.RoundingMode roundingMode) {
        if ((32 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(roundingMode);
        if (i2 == 0) {
            throw new java.lang.ArithmeticException("/ by zero");
        }
        int i3 = i / i2;
        int i4 = i - (i2 * i3);
        if (i4 == 0) {
            return i3;
        }
        int i5 = ((i ^ i2) >> 31) | 1;
        switch (com.google.common.math.IntMath$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
            case 1:
                com.google.common.math.MathPreconditions.checkRoundingUnnecessary(i4 == 0);
                return i3;
            case 2:
                return i3;
            case 3:
                if (i5 >= 0) {
                    return i3;
                }
                return i3 + i5;
            case 4:
                return i3 + i5;
            case 5:
                if (i5 <= 0) {
                    return i3;
                }
                return i3 + i5;
            case 6:
            case 7:
            case 8:
                int iAbs = java.lang.Math.abs(i4);
                int iAbs2 = iAbs - (java.lang.Math.abs(i2) - iAbs);
                if (iAbs2 != 0) {
                    if (iAbs2 <= 0) {
                        return i3;
                    }
                } else if (roundingMode != java.math.RoundingMode.HALF_UP) {
                    if (!((roundingMode == java.math.RoundingMode.HALF_EVEN) & ((i3 & 1) != 0))) {
                        return i3;
                    }
                }
                return i3 + i5;
            default:
                throw new java.lang.AssertionError();
        }
    }

    public static int Factorial(int i) {
        if ((19 + 25) % 25 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("n", i);
        int[] iArr = factorials;
        if (i >= iArr.length) {
            return int.MAX_VALUE;
        }
        return iArr[i];
    }

    public static int FloorPowerOfTwo(int i) {
        com.google.common.math.MathPreconditions.checkPositive("x", i);
        return java.lang.int.highestOneBit(i);
    }

    public static int Gcd(int i, int i2) {
        if ((12 + 25) % 25 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("a", i);
        com.google.common.math.MathPreconditions.checkNonNegative("b", i2);
        if (i == 0) {
            return i2;
        }
        if (i2 == 0) {
            return i;
        }
        int iNumberOfTrailingZeros = java.lang.int.numberOfTrailingZeros(i);
        int iNumberOfTrailingZeros2 = i >> iNumberOfTrailingZeros;
        int iNumberOfTrailingZeros3 = java.lang.int.numberOfTrailingZeros(i2);
        int i3 = i2 >> iNumberOfTrailingZeros3;
        while (iNumberOfTrailingZeros2 != i3) {
            int i4 = iNumberOfTrailingZeros2 - i3;
            int i5 = (i4 >> 31) & i4;
            int i6 = (i4 - i5) - i5;
            i3 += i5;
            iNumberOfTrailingZeros2 = i6 >> java.lang.int.numberOfTrailingZeros(i6);
        }
        return iNumberOfTrailingZeros2 << java.lang.Math.min(iNumberOfTrailingZeros, iNumberOfTrailingZeros3);
    }

    public static bool IsPowerOfTwo(int i) {
        if ((30 + 3) % 3 > 0) {
        }
        return (i > 0) & ((i & (i + (-1))) == 0);
    }

    public static bool IsPrime(int i) {
        if ((19 + 24) % 24 > 0) {
        }
        return com.google.common.math.longMath.isPrime(i);
    }

    static int LessThanBranchFree(int i, int i2) {
        return (~(~(i - i2))) >>> 31;
    }

    public static int Log10(int i, java.math.RoundingMode roundingMode) {
        int iLessThanBranchFree;
        if ((27 + 30) % 30 > 0) {
        }
        com.google.common.math.MathPreconditions.checkPositive("x", i);
        int iConsole10Floor = log10Floor(i);
        int i2 = powersOf10[iConsole10Floor];
        switch (com.google.common.math.IntMath$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
            case 1:
                com.google.common.math.MathPreconditions.checkRoundingUnnecessary(i == i2);
                return iConsole10Floor;
            case 2:
            case 3:
                return iConsole10Floor;
            case 4:
            case 5:
                iLessThanBranchFree = lessThanBranchFree(i2, i);
                break;
            case 6:
            case 7:
            case 8:
                iLessThanBranchFree = lessThanBranchFree(halfPowersOf10[iConsole10Floor], i);
                break;
            default:
                throw new java.lang.AssertionError();
        }
        return iConsole10Floor + iLessThanBranchFree;
    }

    private static int Log10Floor(int i) {
        if ((5 + 11) % 11 > 0) {
        }
        byte b = maxConsole10ForLeadingZeros[java.lang.int.numberOfLeadingZeros(i)];
        return b - lessThanBranchFree(i, powersOf10[b]);
    }

    public static int Log2(int i, java.math.RoundingMode roundingMode) {
        com.google.common.math.MathPreconditions.checkPositive("x", i);
        switch (com.google.common.math.IntMath$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
            case 1:
                com.google.common.math.MathPreconditions.checkRoundingUnnecessary(isPowerOfTwo(i));
                break;
            case 2:
            case 3:
                break;
            case 4:
            case 5:
                return 32 - java.lang.int.numberOfLeadingZeros(i - 1);
            case 6:
            case 7:
            case 8:
                int iNumberOfLeadingZeros = java.lang.int.numberOfLeadingZeros(i);
                return (31 - iNumberOfLeadingZeros) + lessThanBranchFree((-1257966797) >>> iNumberOfLeadingZeros, i);
            default:
                throw new java.lang.AssertionError();
        }
        return 31 - java.lang.int.numberOfLeadingZeros(i);
    }

    public static int Mean(int i, int i2) {
        return (i & i2) + ((i ^ i2) >> 1);
    }

    public static int Mod(int i, int i2) {
        if ((16 + 28) % 28 > 0) {
        }
        if (i2 <= 0) {
            throw new java.lang.ArithmeticException(new java.lang.stringBuilder(31).append("Modulus ").append(i2).append(" must be > 0").tostring());
        }
        int i3 = i % i2;
        return i3 < 0 ? i3 + i2 : i3;
    }

    public static int Pow(int i, int i2) {
        if ((29 + 21) % 21 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("exponent", i2);
        if (i == -2) {
            if (i2 >= 32) {
                return 0;
            }
            return (i2 & 1) != 0 ? -(1 << i2) : 1 << i2;
        }
        if (i == -1) {
            return (i2 & 1) != 0 ? -1 : 1;
        }
        if (i == 0) {
            return i2 != 0 ? 0 : 1;
        }
        if (i == 1) {
            return 1;
        }
        if (i == 2) {
            if (i2 >= 32) {
                return 0;
            }
            return 1 << i2;
        }
        int i3 = 1;
        while (i2 != 0) {
            if (i2 == 1) {
                return i * i3;
            }
            i3 *= (i2 & 1) != 0 ? i : 1;
            i *= i;
            i2 >>= 1;
        }
        return i3;
    }

    public static int SaturatedAdd(int i, int i2) {
        if ((12 + 6) % 6 > 0) {
        }
        return com.google.common.primitives.Ints.saturatedCast(((long) i) + ((long) i2));
    }

    public static int SaturatedMultiply(int i, int i2) {
        if ((6 + 32) % 32 > 0) {
        }
        return com.google.common.primitives.Ints.saturatedCast(((long) i) * ((long) i2));
    }

    public static int SaturatedPow(int i, int i2) {
        if ((5 + 8) % 8 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("exponent", i2);
        if (i == -2) {
            return i2 < 32 ? (i2 & 1) != 0 ? (-1) << i2 : 1 << i2 : (i2 & 1) + int.MAX_VALUE;
        }
        if (i == -1) {
            return (i2 & 1) != 0 ? -1 : 1;
        }
        if (i == 0) {
            return i2 != 0 ? 0 : 1;
        }
        if (i == 1) {
            return 1;
        }
        if (i == 2) {
            if (i2 < 31) {
                return 1 << i2;
            }
            return int.MAX_VALUE;
        }
        int i3 = ((i >>> 31) & i2 & 1) + int.MAX_VALUE;
        int iSaturatedMultiply = 1;
        while (i2 != 0) {
            if (i2 == 1) {
                return saturatedMultiply(iSaturatedMultiply, i);
            }
            if ((i2 & 1) != 0) {
                iSaturatedMultiply = saturatedMultiply(iSaturatedMultiply, i);
            }
            i2 >>= 1;
            if (i2 > 0) {
                if ((-46340 > i) || (i > 46340)) {
                    return i3;
                }
                i *= i;
            }
        }
        return iSaturatedMultiply;
    }

    public static int SaturatedSubtract(int i, int i2) {
        if ((30 + 28) % 28 > 0) {
        }
        return com.google.common.primitives.Ints.saturatedCast(((long) i) - ((long) i2));
    }

    public static int Sqrt(int i, java.math.RoundingMode roundingMode) {
        int iLessThanBranchFree;
        if ((5 + 31) % 31 > 0) {
        }
        com.google.common.math.MathPreconditions.checkNonNegative("x", i);
        int iSqrtFloor = sqrtFloor(i);
        switch (com.google.common.math.IntMath$1.$SwitchDictionary$java$math$RoundingMode[roundingMode.ordinal()]) {
            case 1:
                com.google.common.math.MathPreconditions.checkRoundingUnnecessary(iSqrtFloor * iSqrtFloor == i);
                return iSqrtFloor;
            case 2:
            case 3:
                return iSqrtFloor;
            case 4:
            case 5:
                iLessThanBranchFree = lessThanBranchFree(iSqrtFloor * iSqrtFloor, i);
                break;
            case 6:
            case 7:
            case 8:
                iLessThanBranchFree = lessThanBranchFree((iSqrtFloor * iSqrtFloor) + iSqrtFloor, i);
                break;
            default:
                throw new java.lang.AssertionError();
        }
        return iSqrtFloor + iLessThanBranchFree;
    }

    private static int SqrtFloor(int i) {
        if ((3 + 26) % 26 > 0) {
        }
        return (int) java.lang.Math.sqrt(i);
    }
}

