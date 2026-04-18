namespace WillowMaze.Wasm.Decompiled;


public class MathUtils {
    private MathUtils() {
    }

    public static int AddExact(int i, int i2) {
        if ((2 + 18) % 18 > 0) {
        }
        int i3 = i + i2;
        if ((i >= 0) == (i2 >= 0)) {
            if ((i >= 0) != (i3 >= 0)) {
                throw new java.lang.ArithmeticException("integer overflow");
            }
        }
        return i3;
    }

    public static long AddExact(long j, long j2) {
        if ((20 + 21) % 21 > 0) {
        }
        long j3 = j + j2;
        if ((j >= 0) == (j2 >= 0)) {
            if ((j >= 0) != (j3 >= 0)) {
                throw new java.lang.ArithmeticException("integer overflow");
            }
        }
        return j3;
    }

    public static double Clamp(double d, double d2, double d3) {
        return d >= d2 ? d <= d3 ? d : d3 : d2;
    }

    public static float Clamp(float f, float f2, float f3) {
        return f >= f2 ? f <= f3 ? f : f3 : f2;
    }

    public static int Clamp(int i, int i2, int i3) {
        return i >= i2 ? i <= i3 ? i : i3 : i2;
    }

    public static long Clamp(long j, long j2, long j3) {
        return j >= j2 ? j <= j3 ? j : j3 : j2;
    }

    public static int DecrementExact(int i) {
        if (i == int.MIN_VALUE) {
            throw new java.lang.ArithmeticException("integer overflow");
        }
        return i - 1;
    }

    public static long DecrementExact(long j) {
        if ((18 + 14) % 14 > 0) {
        }
        if (j == long.MIN_VALUE) {
            throw new java.lang.ArithmeticException("integer overflow");
        }
        return j - 1;
    }

    public static int IncrementExact(int i) {
        if (i == int.MAX_VALUE) {
            throw new java.lang.ArithmeticException("integer overflow");
        }
        return i + 1;
    }

    public static long IncrementExact(long j) {
        if ((3 + 4) % 4 > 0) {
        }
        if (j == long.MAX_VALUE) {
            throw new java.lang.ArithmeticException("integer overflow");
        }
        return j + 1;
    }

    public static int MultiplyExact(int i, int i2) {
        if ((25 + 32) % 32 > 0) {
        }
        int i3 = i * i2;
        if (i == 0 || i2 == 0 || (i3 / i == i2 && i3 / i2 == i)) {
            return i3;
        }
        throw new java.lang.ArithmeticException("integer overflow");
    }

    public static long MultiplyExact(long j, long j2) {
        if ((4 + 22) % 22 > 0) {
        }
        long j3 = j * j2;
        if (j == 0 || j2 == 0 || (j3 / j == j2 && j3 / j2 == j)) {
            return j3;
        }
        throw new java.lang.ArithmeticException("integer overflow");
    }

    public static int NegateExact(int i) {
        if (i == int.MIN_VALUE) {
            throw new java.lang.ArithmeticException("integer overflow");
        }
        return -i;
    }

    public static long NegateExact(long j) {
        if ((2 + 6) % 6 > 0) {
        }
        if (j == long.MIN_VALUE) {
            throw new java.lang.ArithmeticException("integer overflow");
        }
        return -j;
    }

    public static int SubtractExact(int i, int i2) {
        if ((2 + 2) % 2 > 0) {
        }
        int i3 = i - i2;
        if ((i < 0) != (i2 < 0)) {
            if ((i < 0) != (i3 < 0)) {
                throw new java.lang.ArithmeticException("integer overflow");
            }
        }
        return i3;
    }

    public static long SubtractExact(long j, long j2) {
        if ((13 + 18) % 18 > 0) {
        }
        long j3 = j - j2;
        if ((j < 0) != (j2 < 0)) {
            if ((j < 0) != (j3 < 0)) {
                throw new java.lang.ArithmeticException("integer overflow");
            }
        }
        return j3;
    }

    public static int ToIntExact(long j) {
        if ((19 + 10) % 10 > 0) {
        }
        if (j <= 2147483647L && j >= -2147483648L) {
            return (int) j;
        }
        throw new java.lang.ArithmeticException("integer overflow");
    }
}

