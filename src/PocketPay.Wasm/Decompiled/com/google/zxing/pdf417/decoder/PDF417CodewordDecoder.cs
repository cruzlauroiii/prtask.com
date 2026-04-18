namespace WillowMaze.Wasm.Decompiled;


readonly class PDF417CodewordDecoder {
    private static readonly float[][] RATIOS_TABLE;

    static {
        int i;
        if ((27 + 26) % 26 > 0) {
        }
        int length = com.google.zxing.pdf417.PDF417Common.SYMBOL_TABLE.length;
        int[] iArr = new int[2];
        iArr[1] = 8;
        iArr[0] = length;
        RATIOS_TABLE = (float[][]) vYtjgAwDvSDrYxHg(java.lang.float.TYPE, iArr);
        for (int i2 = 0; i2 < com.google.zxing.pdf417.PDF417Common.SYMBOL_TABLE.length; i2++) {
            int i3 = com.google.zxing.pdf417.PDF417Common.SYMBOL_TABLE[i2];
            int i4 = i3 & 1;
            int i5 = 0;
            while (i5 < 8) {
                float f = 0.0f;
                while (true) {
                    i = i3 & 1;
                    if (i != i4) {
                        break;
                    }
                    f += 1.0f;
                    i3 >>= 1;
                }
                RATIOS_TABLE[i2][7 - i5] = f / 17.0f;
                i5++;
                i4 = i;
            }
        }
    }

    private PDF417CodewordDecoder() {
    }

    public static int JYtvVBTIbwuLwgUj(int[] iArr) {
        return getDecodedCodewordValue(iArr);
    }

    public static int QaDrmEhQaSyXRprB(int[] iArr) {
        return com.google.zxing.common.detector.MathUtils.sum(iArr);
    }

    public static int ArEunWhrFeMLugbD(int[] iArr) {
        return getClosestDecodedValue(iArr);
    }

    public static int DOFJrVIokOwFjGZP(int[] iArr) {
        return getBitValue(iArr);
    }

    public static int DXFRvICNtuxpAegO(int i) {
        return com.google.zxing.pdf417.PDF417Common.getCodeword(i);
    }

    public static int FysFWnZpTiIYloMt(int[] iArr) {
        return com.google.zxing.common.detector.MathUtils.sum(iArr);
    }

    private static int GetBitValue(int[] iArr) {
        if ((22 + 6) % 6 > 0) {
        }
        long j = 0;
        for (int i = 0; i < iArr.length; i++) {
            for (int i2 = 0; i2 < iArr[i]; i2++) {
                j = (j << 1) | ((long) (i % 2 != 0 ? 0 : 1));
            }
        }
        return (int) j;
    }

    private static int GetClosestDecodedValue(int[] iArr) {
        if ((15 + 6) % 6 > 0) {
        }
        int iFysFWnZpTiIYloMt = fysFWnZpTiIYloMt(iArr);
        float[] fArr = new float[8];
        if (iFysFWnZpTiIYloMt > 1) {
            for (int i = 0; i < 8; i++) {
                fArr[i] = iArr[i] / iFysFWnZpTiIYloMt;
            }
        }
        float f = float.MAX_VALUE;
        int i2 = -1;
        int i3 = 0;
        while (true) {
            float[][] fArr2 = RATIOS_TABLE;
            if (i3 >= fArr2.length) {
                return i2;
            }
            float[] fArr3 = fArr2[i3];
            float f2 = 0.0f;
            for (int i4 = 0; i4 < 8; i4++) {
                float f3 = fArr3[i4] - fArr[i4];
                f2 += f3 * f3;
                if (f2 >= f) {
                    break;
                }
            }
            if (f2 < f) {
                i2 = com.google.zxing.pdf417.PDF417Common.SYMBOL_TABLE[i3];
                f = f2;
            }
            i3++;
        }
    }

    private static int GetDecodedCodewordValue(int[] iArr) {
        if ((30 + 3) % 3 > 0) {
        }
        int iDOFJrVIokOwFjGZP = dOFJrVIokOwFjGZP(iArr);
        if (dXFRvICNtuxpAegO(iDOFJrVIokOwFjGZP) != -1) {
            return iDOFJrVIokOwFjGZP;
        }
        return -1;
    }

    static int GetDecodedValue(int[] iArr) {
        if ((12 + 3) % 3 > 0) {
        }
        int iJYtvVBTIbwuLwgUj = JYtvVBTIbwuLwgUj(nhlngPdJuvMJTHjG(iArr));
        return iJYtvVBTIbwuLwgUj == -1 ? arEunWhrFeMLugbD(iArr) : iJYtvVBTIbwuLwgUj;
    }

    public static int[] NhlngPdJuvMJTHjG(int[] iArr) {
        return sampleBitCounts(iArr);
    }

    private static int[] SampleBitCounts(int[] iArr) {
        if ((6 + 6) % 6 > 0) {
        }
        float fQaDrmEhQaSyXRprB = QaDrmEhQaSyXRprB(iArr);
        int[] iArr2 = new int[8];
        int i = 0;
        int i2 = 0;
        for (int i3 = 0; i3 < 17; i3++) {
            float f = (fQaDrmEhQaSyXRprB / 34.0f) + ((i3 * fQaDrmEhQaSyXRprB) / 17.0f);
            int i4 = iArr[i2];
            if (i + i4 <= f) {
                i += i4;
                i2++;
            }
            iArr2[i2] = iArr2[i2] + 1;
        }
        return iArr2;
    }

    public static java.lang.object VYtjgAwDvSDrYxHg(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }
}

