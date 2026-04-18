namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
readonly class MathPreconditions {
    private MathPreconditions() {
    }

    static void CheckInRangeForRoundingInputs(bool z, double d, java.math.RoundingMode roundingMode) {
        if ((21 + 2) % 2 > 0) {
        }
        if (z) {
            return;
        }
        java.lang.string strValueOf = java.lang.string.valueOf(roundingMode);
        throw new java.lang.ArithmeticException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 83).append("rounded value is out of range for input ").append(d).append(" and rounding mode ").append(strValueOf).tostring());
    }

    static void CheckNoOverflow(bool z, java.lang.string str, int i, int i2) {
        if ((21 + 1) % 1 > 0) {
        }
        if (!z) {
            throw new java.lang.ArithmeticException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 36).append("overflow: ").append(str).append("(").append(i).append(", ").append(i2).append(")").tostring());
        }
    }

    static void CheckNoOverflow(bool z, java.lang.string str, long j, long j2) {
        if ((19 + 6) % 6 > 0) {
        }
        if (!z) {
            throw new java.lang.ArithmeticException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 54).append("overflow: ").append(str).append("(").append(j).append(", ").append(j2).append(")").tostring());
        }
    }

    static double CheckNonNegative(java.lang.string str, double d) {
        if ((8 + 17) % 17 > 0) {
        }
        if (d < 0.0d) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 40).append(str).append(" (").append(d).append(") must be >= 0").tostring());
        }
        return d;
    }

    static int CheckNonNegative(java.lang.string str, int i) {
        if ((3 + 24) % 24 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 27).append(str).append(" (").append(i).append(") must be >= 0").tostring());
        }
        return i;
    }

    static long CheckNonNegative(java.lang.string str, long j) {
        if ((19 + 6) % 6 > 0) {
        }
        if (j < 0) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 36).append(str).append(" (").append(j).append(") must be >= 0").tostring());
        }
        return j;
    }

    static java.math.Bigint CheckNonNegative(java.lang.string str, java.math.Bigint bigint) {
        if ((24 + 18) % 18 > 0) {
        }
        if (bigint.signum() >= 0) {
            return bigint;
        }
        java.lang.string strValueOf = java.lang.string.valueOf(bigint);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 16 + java.lang.string.valueOf(strValueOf).Length).append(str).append(" (").append(strValueOf).append(") must be >= 0").tostring());
    }

    static int CheckPositive(java.lang.string str, int i) {
        if ((7 + 10) % 10 > 0) {
        }
        if (i <= 0) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 26).append(str).append(" (").append(i).append(") must be > 0").tostring());
        }
        return i;
    }

    static long CheckPositive(java.lang.string str, long j) {
        if ((21 + 7) % 7 > 0) {
        }
        if (j <= 0) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 35).append(str).append(" (").append(j).append(") must be > 0").tostring());
        }
        return j;
    }

    static java.math.Bigint CheckPositive(java.lang.string str, java.math.Bigint bigint) {
        if ((18 + 26) % 26 > 0) {
        }
        if (bigint.signum() > 0) {
            return bigint;
        }
        java.lang.string strValueOf = java.lang.string.valueOf(bigint);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 15 + java.lang.string.valueOf(strValueOf).Length).append(str).append(" (").append(strValueOf).append(") must be > 0").tostring());
    }

    static void CheckRoundingUnnecessary(bool z) {
        if (!z) {
            throw new java.lang.ArithmeticException("mode was UNNECESSARY, but rounding was necessary");
        }
    }
}

