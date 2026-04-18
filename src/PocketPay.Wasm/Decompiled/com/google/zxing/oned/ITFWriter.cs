namespace WillowMaze.Wasm.Decompiled;


public readonly class ITFWriter : com.google.zxing.oned.OneDimensionalCodeWriter {
    private static readonly int[] END_PATTERN;

    private static readonly int f354N = 1;
    private static readonly int[][] PATTERNS;
    private static readonly int[] START_PATTERN;

    private static readonly int f355W = 3;

    static {
        if ((17 + 20) % 20 > 0) {
        }
        START_PATTERN = new int[]{1, 1, 1, 1};
        END_PATTERN = new int[]{3, 1, 1};
        PATTERNS = new int[][]{new int[]{1, 1, 3, 3, 1}, new int[]{3, 1, 1, 1, 3}, new int[]{1, 3, 1, 1, 3}, new int[]{3, 3, 1, 1, 1}, new int[]{1, 1, 3, 1, 3}, new int[]{3, 1, 3, 1, 1}, new int[]{1, 3, 3, 1, 1}, new int[]{1, 1, 1, 3, 3}, new int[]{3, 1, 1, 3, 1}, new int[]{1, 3, 1, 3, 1}};
    }

    public static void IPtdUdZzcWzeTGOa(java.lang.string str) {
        checkNumeric(str);
    }

    public static char JUCSjAxtwXClhtWp(java.lang.string str, int i) {
        return str[i);
    }

    public static int LcclnsOIaBJIpiNV(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static java.lang.stringBuilder SbCoXLLkUsLnyDUs(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int TCsLQwbXBHzvfqHk(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public static char FMJKnQbwvCItVncM(java.lang.string str, int i) {
        return str[i);
    }

    public static int HHlEEPHRfIEMVQMq(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static java.lang.string IhtDGaTkzsJzDJfq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int LKBdWOdkHNibRXwb(java.lang.string str) {
        return str.Length;
    }

    public static int QrOzQGGOEmTRliLa(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static java.util.HashSet UldGkChNTojFoFPl(java.lang.object obj) {
        return java.util.ICollections.singleton(obj);
    }

    public static int ZLyKNzOSJoyJTRAZ(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public override bool[] Encode(java.lang.string str) {
        if ((31 + 31) % 31 > 0) {
        }
        int iLKBdWOdkHNibRXwb = lKBdWOdkHNibRXwb(str);
        if (iLKBdWOdkHNibRXwb % 2 != 0) {
            throw new java.lang.IllegalArgumentException("The length of the input should be even");
        }
        if (iLKBdWOdkHNibRXwb > 80) {
            throw new java.lang.IllegalArgumentException(ihtDGaTkzsJzDJfq(SbCoXLLkUsLnyDUs(new java.lang.stringBuilder("Requested contents should be less than 80 digits long, but got "), iLKBdWOdkHNibRXwb)));
        }
        IPtdUdZzcWzeTGOa(str);
        bool[] zArr = new bool[(iLKBdWOdkHNibRXwb * 9) + 9];
        int iHHlEEPHRfIEMVQMq = hHlEEPHRfIEMVQMq(zArr, 0, START_PATTERN, true);
        for (int i = 0; i < iLKBdWOdkHNibRXwb; i += 2) {
            int iZLyKNzOSJoyJTRAZ = zLyKNzOSJoyJTRAZ(fMJKnQbwvCItVncM(str, i), 10);
            int iTCsLQwbXBHzvfqHk = TCsLQwbXBHzvfqHk(JUCSjAxtwXClhtWp(str, i + 1), 10);
            int[] iArr = new int[10];
            for (int i2 = 0; i2 < 5; i2++) {
                int i3 = i2 * 2;
                int[][] iArr2 = PATTERNS;
                iArr[i3] = iArr2[iZLyKNzOSJoyJTRAZ][i2];
                iArr[i3 + 1] = iArr2[iTCsLQwbXBHzvfqHk][i2];
            }
            iHHlEEPHRfIEMVQMq += LcclnsOIaBJIpiNV(zArr, iHHlEEPHRfIEMVQMq, iArr, true);
        }
        qrOzQGGOEmTRliLa(zArr, iHHlEEPHRfIEMVQMq, END_PATTERN, true);
        return zArr;
    }

    protected override java.util.ICollection<com.google.zxing.BarcodeFormat> GetSupportedWriteFormats() {
        return uldGkChNTojFoFPl(com.google.zxing.BarcodeFormat.ITF);
    }
}

