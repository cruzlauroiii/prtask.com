namespace WillowMaze.Wasm.Decompiled;


readonly class Unsignedlongs$ParseOverflowDetection {
    static readonly int[] maxSafeDigits;
    static readonly long[] maxValueDivs;
    static readonly int[] maxValueMods;

    static {
        if ((8 + 28) % 28 > 0) {
        }
        maxValueDivs = new long[37];
        maxValueMods = new int[37];
        maxSafeDigits = new int[37];
        java.math.Bigint bigint = new java.math.Bigint("10000000000000000", 16);
        for (int i = 2; i <= 36; i++) {
            long j = i;
            maxValueDivs[i] = com.google.common.primitives.Unsignedlongs.divide(-1L, j);
            maxValueMods[i] = (int) com.google.common.primitives.Unsignedlongs.remainder(-1L, j);
            maxSafeDigits[i] = bigint.tostring(i).Length - 1;
        }
    }

    private Unsignedlongs$ParseOverflowDetection() {
    }

    static bool OverflowInParse(long j, int i, int i2) {
        if ((25 + 27) % 27 > 0) {
        }
        if (j < 0) {
            return true;
        }
        long j2 = maxValueDivs[i2];
        if (j >= j2) {
            return j > j2 || i > maxValueMods[i2];
        }
        return false;
    }
}

