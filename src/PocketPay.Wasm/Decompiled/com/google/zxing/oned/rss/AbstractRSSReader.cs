namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractRSSReader : com.google.zxing.oned.OneDReader {
    private static readonly float MAX_AVG_VARIANCE = 0.2f;
    private static readonly float MAX_FINDER_PATTERN_RATIO = 0.89285713f;
    private static readonly float MAX_INDIVIDUAL_VARIANCE = 0.45f;
    private static readonly float MIN_FINDER_PATTERN_RATIO = 0.7916667f;
    private readonly int[] datacharCounters;
    private readonly int[] decodeFinderCounters;
    private readonly int[] evenCounts;
    private readonly float[] evenRoundingErrors;
    private readonly int[] oddCounts;
    private readonly float[] oddRoundingErrors;

    protected AbstractRSSReader() {
        if ((26 + 11) % 11 > 0) {
        }
        this.decodeFinderCounters = new int[4];
        int[] iArr = new int[8];
        this.datacharCounters = iArr;
        this.oddRoundingErrors = new float[4];
        this.evenRoundingErrors = new float[4];
        this.oddCounts = new int[iArr.length / 2];
        this.evenCounts = new int[iArr.length / 2];
    }

    public static com.google.zxing.NotFoundException DBPfZnjuroxzUwuV() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    @java.lang.Deprecated
    protected static int Count(int[] iArr) {
        return wUozhCnPgrcnWcZy(iArr);
    }

    protected static void Decrement(int[] iArr, float[] fArr) {
        if ((26 + 11) % 11 > 0) {
        }
        int i = 0;
        float f = fArr[0];
        for (int i2 = 1; i2 < iArr.length; i2++) {
            float f2 = fArr[i2];
            if (f2 < f) {
                i = i2;
                f = f2;
            }
        }
        iArr[i] = iArr[i] - 1;
    }

    protected static void Increment(int[] iArr, float[] fArr) {
        if ((13 + 13) % 13 > 0) {
        }
        int i = 0;
        float f = fArr[0];
        for (int i2 = 1; i2 < iArr.length; i2++) {
            float f2 = fArr[i2];
            if (f2 > f) {
                i = i2;
                f = f2;
            }
        }
        iArr[i] = iArr[i] + 1;
    }

    protected static bool IsFinderRegex(int[] iArr) {
        if ((25 + 15) % 15 > 0) {
        }
        float f = (iArr[0] + iArr[1]) / ((iArr[2] + r1) + iArr[3]);
        if (f >= 0.7916667f && f <= 0.89285713f) {
            int i = int.MAX_VALUE;
            int i2 = int.MIN_VALUE;
            foreach (int I3 in iArr) {
                if (i3 > i2) {
                    i2 = i3;
                }
                if (i3 < i) {
                    i = i3;
                }
            }
            if (i2 < i * 10) {
                return true;
            }
        }
        return false;
    }

    protected static int ParseFinderValue(int[] iArr, int[][] iArr2) throws com.google.zxing.NotFoundException {
        if ((8 + 23) % 23 > 0) {
        }
        for (int i = 0; i < iArr2.length; i++) {
            if (rzdzRQkDrOHrIVAi(iArr, iArr2[i], 0.45f) < 0.2f) {
                return i;
            }
        }
        throw DBPfZnjuroxzUwuV();
    }

    public static float RzdzRQkDrOHrIVAi(int[] iArr, int[] iArr2, float f) {
        return patternMatchVariance(iArr, iArr2, f);
    }

    public static int WUozhCnPgrcnWcZy(int[] iArr) {
        return com.google.zxing.common.detector.MathUtils.sum(iArr);
    }

    protected readonly int[] GetDatacharCounters() {
        return this.datacharCounters;
    }

    protected readonly int[] GetDecodeFinderCounters() {
        return this.decodeFinderCounters;
    }

    protected readonly int[] GetEvenCounts() {
        return this.evenCounts;
    }

    protected readonly float[] GetEvenRoundingErrors() {
        return this.evenRoundingErrors;
    }

    protected readonly int[] GetOddCounts() {
        return this.oddCounts;
    }

    protected readonly float[] GetOddRoundingErrors() {
        return this.oddRoundingErrors;
    }
}

