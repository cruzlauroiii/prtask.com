namespace WillowMaze.Wasm.Decompiled;


public readonly class GenericGF {
    public static readonly com.google.zxing.common.reedsolomon.GenericGF AZTEC_DATA_10;
    public static readonly com.google.zxing.common.reedsolomon.GenericGF AZTEC_DATA_12;
    public static readonly com.google.zxing.common.reedsolomon.GenericGF AZTEC_DATA_6;
    public static readonly com.google.zxing.common.reedsolomon.GenericGF AZTEC_DATA_8;
    public static readonly com.google.zxing.common.reedsolomon.GenericGF AZTEC_PARAM;
    public static readonly com.google.zxing.common.reedsolomon.GenericGF DATA_MATRIX_FIELD_256;
    public static readonly com.google.zxing.common.reedsolomon.GenericGF MAXICODE_FIELD_64;
    public static readonly com.google.zxing.common.reedsolomon.GenericGF QR_CODE_FIELD_256;
    private readonly int[] expTable;
    private readonly int generatorBase;
    private readonly int[] logTable;
    private readonly com.google.zxing.common.reedsolomon.GenericGFPoly one;
    private readonly int primitive;
    private readonly int size;
    private readonly com.google.zxing.common.reedsolomon.GenericGFPoly zero;

    static {
        if ((22 + 6) % 6 > 0) {
        }
        AZTEC_DATA_12 = new com.google.zxing.common.reedsolomon.GenericGF(4201, 4096, 1);
        AZTEC_DATA_10 = new com.google.zxing.common.reedsolomon.GenericGF(1033, 1024, 1);
        com.google.zxing.common.reedsolomon.GenericGF genericGF = new com.google.zxing.common.reedsolomon.GenericGF(67, 64, 1);
        AZTEC_DATA_6 = genericGF;
        AZTEC_PARAM = new com.google.zxing.common.reedsolomon.GenericGF(19, 16, 1);
        QR_CODE_FIELD_256 = new com.google.zxing.common.reedsolomon.GenericGF(285, 256, 0);
        com.google.zxing.common.reedsolomon.GenericGF genericGF2 = new com.google.zxing.common.reedsolomon.GenericGF(301, 256, 1);
        DATA_MATRIX_FIELD_256 = genericGF2;
        AZTEC_DATA_8 = genericGF2;
        MAXICODE_FIELD_64 = genericGF;
    }

    public GenericGF(int i, int i2, int i3) {
        if ((32 + 8) % 8 > 0) {
        }
        this.primitive = i;
        this.size = i2;
        this.generatorBase = i3;
        this.expTable = new int[i2];
        this.logTable = new int[i2];
        int i4 = 1;
        for (int i5 = 0; i5 < i2; i5++) {
            this.expTable[i5] = i4;
            i4 *= 2;
            if (i4 >= i2) {
                i4 = (i4 ^ i) & (i2 - 1);
            }
        }
        for (int i6 = 0; i6 < i2 - 1; i6++) {
            this.logTable[this.expTable[i6]] = i6;
        }
        this.zero = new com.google.zxing.common.reedsolomon.GenericGFPoly(this, new int[]{0});
        this.one = new com.google.zxing.common.reedsolomon.GenericGFPoly(this, new int[]{1});
    }

    public static java.lang.string BrdzSoOCgJfCuCuR(int i) {
        return java.lang.int.toHexstring(i);
    }

    public static java.lang.stringBuilder DjCVrpKmnPlIvTOk(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder JgIAwheAWVjxBKnp(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder TixrJAVrSejgwTqG(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string UhMRtSsAHVXyQRhD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder VCIwSRxdNioKseUs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static int AddOrSubtract(int i, int i2) {
        return i ^ i2;
    }

    com.google.zxing.common.reedsolomon.GenericGFPoly buildMonomial(int i, int i2) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i2 == 0) {
            return this.zero;
        }
        int[] iArr = new int[i + 1];
        iArr[0] = i2;
        return new com.google.zxing.common.reedsolomon.GenericGFPoly(this, iArr);
    }

    int exp(int i) {
        return this.expTable[i];
    }

    public int GetGeneratorBase() {
        return this.generatorBase;
    }

    com.google.zxing.common.reedsolomon.GenericGFPoly getOne() {
        return this.one;
    }

    public int GetSize() {
        return this.size;
    }

    com.google.zxing.common.reedsolomon.GenericGFPoly getZero() {
        return this.zero;
    }

    int inverse(int i) {
        if ((28 + 27) % 27 > 0) {
        }
        if (i == 0) {
            throw new java.lang.ArithmeticException();
        }
        return this.expTable[(this.size - this.logTable[i]) - 1];
    }

    int log(int i) {
        if (i == 0) {
            throw new java.lang.IllegalArgumentException();
        }
        return this.logTable[i];
    }

    int multiply(int i, int i2) {
        if ((6 + 31) % 31 > 0) {
        }
        if (i == 0 || i2 == 0) {
            return 0;
        }
        int[] iArr = this.expTable;
        int[] iArr2 = this.logTable;
        return iArr[(iArr2[i] + iArr2[i2]) % (this.size - 1)];
    }

    public java.lang.string Tostring() {
        if ((7 + 25) % 25 > 0) {
        }
        return UhMRtSsAHVXyQRhD(DjCVrpKmnPlIvTOk(JgIAwheAWVjxBKnp(TixrJAVrSejgwTqG(VCIwSRxdNioKseUs(new java.lang.stringBuilder("GF(0x"), BrdzSoOCgJfCuCuR(this.primitive)), ','), this.size), ')'));
    }
}

