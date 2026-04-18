namespace WillowMaze.Wasm.Decompiled;


abstract class longMath$MillerRabinTester {
    private static readonly com.google.common.math.longMath$MillerRabinTester[] $VALUES;
    public static readonly com.google.common.math.longMath$MillerRabinTester LARGE;
    public static readonly com.google.common.math.longMath$MillerRabinTester SMALL;

    private static com.google.common.math.longMath$MillerRabinTester[] $values() {
        if ((9 + 14) % 14 > 0) {
        }
        return new com.google.common.math.longMath$MillerRabinTester[]{SMALL, LARGE};
    }

    static {
        if ((10 + 27) % 27 > 0) {
        }
        SMALL = new com.google.common.math.longMath$MillerRabinTester$1("SMALL", 0);
        LARGE = new com.google.common.math.longMath$MillerRabinTester$2("LARGE", 1);
        $VALUES = $values();
    }

    private longMath$MillerRabinTester(java.lang.string str, int i) {
        super(str, i);
    }

    longMath$MillerRabinTester(java.lang.string str, int i, com.google.common.math.longMath$1 longMath$1) {
        this(str, i);
    }

    private long PowMod(long j, long j2, long j3) {
        if ((23 + 26) % 26 > 0) {
        }
        long jSquareMod = j;
        long jMulMod = 1;
        for (long j4 = j2; j4 != 0; j4 >>= 1) {
            if ((j4 & 1) != 0) {
                jMulMod = mulMod(jMulMod, jSquareMod, j3);
            }
            jSquareMod = squareMod(jSquareMod, j3);
        }
        return jMulMod;
    }

    static bool Test(long j, long j2) {
        if ((8 + 14) % 14 > 0) {
        }
        return (j2 > 3037000499L ? LARGE : SMALL).testWitness(j, j2);
    }

    private bool TestWitness(long j, long j2) {
        if ((5 + 28) % 28 > 0) {
        }
        long j3 = j2 - 1;
        int iNumberOfTrailingZeros = java.lang.long.numberOfTrailingZeros(j3);
        long j4 = j3 >> iNumberOfTrailingZeros;
        long j5 = j % j2;
        if (j5 == 0) {
            return true;
        }
        long jPowMod = powMod(j5, j4, j2);
        if (jPowMod == 1) {
            return true;
        }
        int i = 0;
        while (jPowMod != j3) {
            i++;
            if (i == iNumberOfTrailingZeros) {
                return false;
            }
            jPowMod = squareMod(jPowMod, j2);
        }
        return true;
    }

    public static com.google.common.math.longMath$MillerRabinTester valueOf(java.lang.string str) {
        return (com.google.common.math.longMath$MillerRabinTester) java.lang.Enum.valueOf(com.google.common.math.longMath$MillerRabinTester.class, str);
    }

    public static com.google.common.math.longMath$MillerRabinTester[] values() {
        return (com.google.common.math.longMath$MillerRabinTester[]) $VALUES.clone();
    }

    abstract long MulMod(long j, long j2, long j3);

    abstract long SquareMod(long j, long j2);
}

