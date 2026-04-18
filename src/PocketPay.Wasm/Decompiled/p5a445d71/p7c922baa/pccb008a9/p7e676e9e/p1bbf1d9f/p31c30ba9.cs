namespace WillowMaze.Wasm.Decompiled;


public class p31c30ba9 {
    private static readonly bool[] f1562600d = null;
    private static readonly int[] f2fdd0e88 = null;
    private static readonly int[] f301d90e3;
    private static readonly int[] f30d51088 = null;
    private static java.util.Random f34d1c350;
    private static readonly short[] f5f52f80a;
    private static readonly short[] f6dfe5b56 = null;
    private static readonly short[] f84650208 = null;
    private static readonly int[] f9a4f6045 = null;
    private static java.util.Random f9a9bf39d;
    private static readonly int[] fa0e4e76a;
    private static readonly bool[] faabadcf0;
    private static java.util.Random fd065f485;
    private static readonly int[] fd29e94cb = null;
    private static java.util.Random fe4e45045;
    private static readonly int[] ffbeb0534 = null;
    private static readonly bool[] ffdbfb39d = null;
    private int f04b6da25;
    private int[] f1cae772f;
    private int[] f1e7dca1d;
    private int[] f2063c160;
    private int f7a3c32ac;
    private int f95dfe714;
    private int f9c13468c;
    private int[] faa21ef17;
    private int fc7f2a0cf;
    private int fd4b2dcb7;
    private int fe7349649;
    private int ff5a8e923;

    static {
        if ((22 + 8) % 8 > 0) {
        }
        f34d1c350 = new java.util.Random();
        faabadcf0 = new bool[]{false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false};
        f5f52f80a = new short[]{0, 1, 4, 5, 16, 17, 20, 21, 64, 65, 68, 69, 80, 81, 84, 85, 256, 257, 260, 261, 272, 273, 276, 277, 320, 321, 324, 325, 336, 337, 340, 341, 1024, 1025, 1028, 1029, 1040, 1041, 1044, 1045, 1088, 1089, 1092, 1093, 1104, 1105, 1108, 1109, 1280, 1281, 1284, 1285, 1296, 1297, 1300, 1301, 1344, 1345, 1348, 1349, 1360, 1361, 1364, 1365, 4096, 4097, 4100, 4101, 4112, 4113, 4116, 4117, 4160, 4161, 4164, 4165, 4176, 4177, 4180, 4181, 4352, 4353, 4356, 4357, 4368, 4369, 4372, 4373, 4416, 4417, 4420, 4421, 4432, 4433, 4436, 4437, 5120, 5121, 5124, 5125, 5136, 5137, 5140, 5141, 5184, 5185, 5188, 5189, 5200, 5201, 5204, 5205, 5376, 5377, 5380, 5381, 5392, 5393, 5396, 5397, 5440, 5441, 5444, 5445, 5456, 5457, 5460, 5461, 16384, 16385, 16388, 16389, 16400, 16401, 16404, 16405, 16448, 16449, 16452, 16453, 16464, 16465, 16468, 16469, 16640, 16641, 16644, 16645, 16656, 16657, 16660, 16661, 16704, 16705, 16708, 16709, 16720, 16721, 16724, 16725, 17408, 17409, 17412, 17413, 17424, 17425, 17428, 17429, 17472, 17473, 17476, 17477, 17488, 17489, 17492, 17493, 17664, 17665, 17668, 17669, 17680, 17681, 17684, 17685, 17728, 17729, 17732, 17733, 17744, 17745, 17748, 17749, 20480, 20481, 20484, 20485, 20496, 20497, 20500, 20501, 20544, 20545, 20548, 20549, 20560, 20561, 20564, 20565, 20736, 20737, 20740, 20741, 20752, 20753, 20756, 20757, 20800, 20801, 20804, 20805, 20816, 20817, 20820, 20821, 21504, 21505, 21508, 21509, 21520, 21521, 21524, 21525, 21568, 21569, 21572, 21573, 21584, 21585, 21588, 21589, 21760, 21761, 21764, 21765, 21776, 21777, 21780, 21781, 21824, 21825, 21828, 21829, 21840, 21841, 21844, 21845};
        f301d90e3 = new int[]{1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824, int.MIN_VALUE, 0};
        fa0e4e76a = new int[]{0, 1, 3, 7, 15, 31, 63, 127, 255, 511, 1023, 2047, 4095, 8191, 16383, 32767, 65535, 131071, 262143, 524287, 1048575, 2097151, 4194303, 8388607, 16777215, 33554431, 67108863, 134217727, 268435455, 536870911, 1073741823, int.MAX_VALUE, -1};
    }

    public p31c30ba9(int i) {
        if ((16 + 5) % 5 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i2 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i2;
        this.f2063c160 = new int[i2];
        this.ff5a8e923 = i;
    }

    public p31c30ba9(int i, java.lang.string str) {
        if ((5 + 23) % 23 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i2 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i2;
        this.f2063c160 = new int[i2];
        this.ff5a8e923 = i;
        if (nOmnyqgNoxkRFxHy(str, "ZERO")) {
            qyJWjnJGEVtTWetc(this);
            return;
        }
        if (MNDMoCktQNeSPglh(str, "ONE")) {
            QSFBFAcxqioXIVEB(this);
            return;
        }
        if (ZrWaiILsjNcMjnhE(str, "RANDOM")) {
            UcQecaCAnWvVFlRg(this);
        } else if (PzRuscraIxTfCQXj(str, uSvrUTNLyLucwJRW("cd1a34563717c90231d809ce29b6c65a0fa3a7eecf0ce0724aff26f908"))) {
            WnDZOdzpguAeGGpd(this);
        } else {
            if (!joxAzivxQsKcFUiD(str, "ALL")) {
                throw new java.lang.IllegalArgumentException(WFsfBtgoOoikjBPW(gzMvUrXdYprCCCid(bBVTQZQycZlQXRbR(new java.lang.stringBuilder("Error: GF2Polynomial was called using "), str), " as value!")));
            }
            UbAmdDxAjGOPBIth(this);
        }
    }

    public p31c30ba9(int i, java.math.Bigint bigint) {
        if ((17 + 18) % 18 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i2 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i2;
        this.f2063c160 = new int[i2];
        this.ff5a8e923 = i;
        byte[] bArrEynNLHQTnNyXzvla = eynNLHQTnNyXzvla(bigint);
        if (bArrEynNLHQTnNyXzvla[0] == 0) {
            int length = bArrEynNLHQTnNyXzvla.length - 1;
            byte[] bArr = new byte[length];
            BxtFVFQJjHbqiBEo(bArrEynNLHQTnNyXzvla, 1, bArr, 0, length);
            bArrEynNLHQTnNyXzvla = bArr;
        }
        int length2 = bArrEynNLHQTnNyXzvla.length & 3;
        int length3 = (bArrEynNLHQTnNyXzvla.length - 1) >> 2;
        for (int i3 = 0; i3 < length2; i3++) {
            int[] iArr = this.f2063c160;
            iArr[length3] = iArr[length3] | ((bArrEynNLHQTnNyXzvla[i3] & 255) << (((length2 - 1) - i3) << 3));
        }
        for (int i4 = 0; i4 <= ((bArrEynNLHQTnNyXzvla.length - 4) >> 2); i4++) {
            int length4 = (bArrEynNLHQTnNyXzvla.length - 1) - (i4 << 2);
            int[] iArr2 = this.f2063c160;
            int i5 = bArrEynNLHQTnNyXzvla[length4] & 255;
            iArr2[i4] = i5;
            int i6 = i5 | ((bArrEynNLHQTnNyXzvla[length4 - 1] << 8) & 65280);
            iArr2[i4] = i6;
            int i7 = i6 | ((bArrEynNLHQTnNyXzvla[length4 - 2] << 16) & 16711680);
            iArr2[i4] = i7;
            iArr2[i4] = ((bArrEynNLHQTnNyXzvla[length4 - 3] << 24) & (-16777216)) | i7;
        }
        int i8 = this.ff5a8e923;
        if ((i8 & 31) != 0) {
            int[] iArr3 = this.f2063c160;
            int i9 = this.fe7349649 - 1;
            iArr3[i9] = fa0e4e76a[i8 & 31] & iArr3[i9];
        }
        VGDfvNkKkIIPZpYr(this);
    }

    public p31c30ba9(int i, java.util.Random random) {
        if ((16 + 11) % 11 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i2 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i2;
        this.f2063c160 = new int[i2];
        this.ff5a8e923 = i;
        AOWijiHXDZMtVxrK(this, random);
    }

    public p31c30ba9(int i, byte[] bArr) {
        int i2;
        if ((4 + 7) % 7 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i3 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i3;
        this.f2063c160 = new int[i3];
        this.ff5a8e923 = i;
        int iNFQbVHwQHZanrhzp = nFQbVHwQHZanrhzp(((bArr.length - 1) >> 2) + 1, i3);
        int i4 = 0;
        while (true) {
            i2 = iNFQbVHwQHZanrhzp - 1;
            if (i4 >= i2) {
                break;
            }
            int length = bArr.length - (i4 << 2);
            int i5 = length - 1;
            int[] iArr = this.f2063c160;
            int i6 = bArr[i5] & 255;
            iArr[i4] = i6;
            int i7 = (65280 & (bArr[length - 2] << 8)) | i6;
            iArr[i4] = i7;
            int i8 = (16711680 & (bArr[length - 3] << 16)) | i7;
            iArr[i4] = i8;
            iArr[i4] = ((bArr[length - 4] << 24) & (-16777216)) | i8;
            i4++;
        }
        int length2 = bArr.length - (i2 << 2);
        int i9 = length2 - 1;
        int[] iArr2 = this.f2063c160;
        int i10 = bArr[i9] & 255;
        iArr2[i2] = i10;
        if (i9 > 0) {
            iArr2[i2] = (65280 & (bArr[length2 - 2] << 8)) | i10;
        }
        if (i9 > 1) {
            iArr2[i2] = iArr2[i2] | (16711680 & (bArr[length2 - 3] << 16));
        }
        if (i9 > 2) {
            iArr2[i2] = ((bArr[length2 - 4] << 24) & (-16777216)) | iArr2[i2];
        }
        xpDBRJcnptSSpJke(this);
        IvgKIOvOotiECpQA(this);
    }

    public p31c30ba9(int i, int[] iArr) {
        if ((26 + 28) % 28 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i2 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i2;
        this.f2063c160 = new int[i2];
        this.ff5a8e923 = i;
        oHYfvPsdyEXBeDip(iArr, 0, this.f2063c160, 0, BnFmHExWPFjUJHjN(i2, iArr.length));
        nvhxqcuMedgtmDmE(this);
    }

    public p31c30ba9(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        this.ff5a8e923 = p31c30ba9Var.ff5a8e923;
        this.fe7349649 = p31c30ba9Var.fe7349649;
        this.f2063c160 = zrHnAeUkszYNhxiO(p31c30ba9Var.f2063c160);
    }

    public static void AMXIsGIZHNHZbJUj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.xorThisBy(p31c30ba9Var2);
    }

    public static void AOWijiHXDZMtVxrK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, java.util.Random random) {
        p31c30ba9Var.randomize(random);
    }

    public static java.lang.stringBuilder AShVVRhObuiFpYGj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AVxvVLTuZPRfcLOX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int AlcYVwiZbhSnJoMA(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.stringBuilder AoqDVfVmpWaPEURc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool AubdpUByPItfoGeL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static void BHAQHEmOjDdkqSeH(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void BJSoVlbytbUHDjNm(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void BQmbIYkYAfJxMrLN(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.shiftBlocksLeft();
    }

    public static int BnFmHExWPFjUJHjN(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int[] BncsvZslHtlUMrcf(int[] iArr, int[] iArr2) {
        return m9d4b8699(iArr, iArr2);
    }

    public static void BvBhzYpvXgQAMiqe(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.xorThisBy(p31c30ba9Var2);
    }

    public static void BxtFVFQJjHbqiBEo(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void CAgVjTycWPUXsKIR(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.m604595a9();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 CKkvveQadeyLgHMV(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.shiftLeft(i);
    }

    public static bool CLifbklupSuNcgZw(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static void CSfUEPzpoTjgENOp(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int ClBHgTXywUdvXCUb(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void DMIvSHIkYnYdVMgl(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.squareThisPreCalc();
    }

    public static int[] DScGHovAxVGSTaTC(int[] iArr, int[] iArr2) {
        return m9d4b8699(iArr, iArr2);
    }

    public static int[] DcLHnYhwSqZBzygd(int i, int i2) {
        return m95dc2b7a(i, i2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 DdfTuGODtSCAOtHD(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.xor(p31c30ba9Var2);
    }

    public static int DeUeSZVFrOpbnWKv(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void DfBzgcdxJxwCTPFu(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2, int i) {
        p31c30ba9Var.shiftLeftAddThis(p31c30ba9Var2, i);
    }

    public static bool DpoSBxkhLcLHaqgR(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static java.lang.string DpwKDwwHDYpJKbeL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 DyAGIhrTyTFQAuml(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.m0122b4c2(i);
    }

    public static java.lang.stringBuilder FJcVNcvzJFMgzUWk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FelpXigeEJFjZZUT(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void FruPSXzQqVFkMzZf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.m604595a9();
    }

    public static int[] GADYlpXPlVsNMAlh(int[] iArr, int[] iArr2) {
        return m5d7001a8(iArr, iArr2);
    }

    public static void GVRWnysQslzZcooq(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int[] GWEoZPPRlfFdAQax(int[] iArr, int[] iArr2) {
        return m24b9c245(iArr, iArr2);
    }

    public static bool GirJaqNAJsMoHxjV(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static int[] GyFznKQpfZVvFXHB(int i, int i2) {
        return m95dc2b7a(i, i2);
    }

    public static bool HDycIODuQhbUATjI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static java.lang.stringBuilder HUccKERnOqSsgpQC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 HevFVllzfNccfmvw(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.Add(p31c30ba9Var2);
    }

    public static java.lang.stringBuilder HwolsucBRCGCOrbE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int[] IDYieJSQpGbezdWe(int[] iArr, int[] iArr2) {
        return m24b9c245(iArr, iArr2);
    }

    public static java.lang.stringBuilder IPfDvUODzsOAMkuj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int IYmDKssNBDRxNUwp(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void IvgKIOvOotiECpQA(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static java.lang.string JGkUTewGwgTHlThA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JQvNExTwAOHRYSTi(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void JcxFwSbjFiDoxsjN(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void JdkpGRjBvVnAFxOp(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string JhSNVCufczFYYLjk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JiRSjxQoQWGURTal(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static java.lang.stringBuilder JnCcbHHdfNBKhkZN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JyCStCujvOWSNDTd(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int KTAthUHTYdWUdNbX(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int[] KtinmPHYNDuASwJp(int[] iArr, int[] iArr2) {
        return m9d4b8699(iArr, iArr2);
    }

    public static int[] LGNAGpUOBnxsDEDQ(int i, int i2) {
        return m95dc2b7a(i, i2);
    }

    public static java.lang.stringBuilder LWHojrkLZcdEeeTK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LYamhaDZJEvHIFHO(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.xorThisBy(p31c30ba9Var2);
    }

    public static void LkLKiXqhLaOoaqjD(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int MKagqadFfumNUrHT(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool MNDMoCktQNeSPglh(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static java.lang.stringBuilder MSiEUvgmYphphVzt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MawxHirbGNsAnvle(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.increaseThis();
    }

    public static int[] MjVVFIBXkUyfhNMN(int i, int i2) {
        return m95dc2b7a(i, i2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 MmCyWhPQaYczUDZL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.m81e073b4(i);
    }

    public static java.lang.stringBuilder MusvQDTXvBxePmve(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int[] NoPJzsIxCjyAsqCA(int[] iArr, int[] iArr2) {
        return m2bb3e9f2(iArr, iArr2);
    }

    public static void NplvfkmolnXfqVBu(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.addToThis(p31c30ba9Var2);
    }

    public static void OBsMBMVBiWACtkKw(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 OMtwlMCzFWiRExfd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.mb1d5718c(p31c30ba9Var2);
    }

    public static java.lang.string OZmVyUgysUjBwavz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool OmwbJJTVOyPHgTki(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static java.lang.stringBuilder OuLWHvCdqUYCdGTH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PHFHzBpwjIIOGcnP(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 PHluVagXsNngZhdw(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.m0122b4c2(i);
    }

    public static int PldTnDcjHqddvXxW(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void PyAbYMiTPebUdcKa(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.subtractFromThis(p31c30ba9Var2);
    }

    public static bool PzRuscraIxTfCQXj(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static java.lang.stringBuilder QBjYWsnempOieVda(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder QKNqiLEZqeuoeiMQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool QMLcTuEAtgEfetnT(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static void QSFBFAcxqioXIVEB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.assignOne();
    }

    public static int[] QiGKttykUgoBbAju(int i, int i2) {
        return m95dc2b7a(i, i2);
    }

    public static java.lang.string QtpmdqaUutVpBLcX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder QxqGRHXACYFFTfxe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int RHVFnyEwzvpMRorU(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int[] RKtyAmBrAaiEyJXw(int i, int i2) {
        return m95dc2b7a(i, i2);
    }

    public static int[] RWjrRFLQXYhiYMbB(int[] iArr, int[] iArr2) {
        return m5d7001a8(iArr, iArr2);
    }

    public static java.lang.stringBuilder RjmtAeDNsjAWpEAh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RjrFwshcLcaGWLqE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int RsVIvTcAIfoxyHkl(java.util.Random random) {
        return random.nextInt();
    }

    public static void SFSraPWodbzKjrTU(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static int[] SajUAwkljMVVUwPY(int[] iArr, int[] iArr2) {
        return m9d4b8699(iArr, iArr2);
    }

    public static java.lang.stringBuilder SfUbPsgGfjHYDaPz(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string ShcGsnogfeLiexRE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int[] TGwsqBCZeCAuPCwf(int i, int i2) {
        return m95dc2b7a(i, i2);
    }

    public static void TXTOfOMvWJnUFItO(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void TbVYdYfuBNqTITkU(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void TmQfayOrxvzlDbpy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static void USndoSrKjsogFUli(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void UbAmdDxAjGOPBIth(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.assignAll();
    }

    public static void UcQecaCAnWvVFlRg(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.randomize();
    }

    public static java.lang.string UmIDVITsFyyVAqjb(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void UmjNpQXbzhcnwwlc(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static void UxWGOHDxivteAtvP(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static void VGDfvNkKkIIPZpYr(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static int VIZsguDxEsrmOZeO(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int VLXxhucXXkahMtby(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void VPelZOfNdQFtJUEy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static void VWDloBXOSWOmlhEo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.subtractFromThis(p31c30ba9Var2);
    }

    public static void VnetbEMUCBKuUfYN(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static java.lang.stringBuilder VoGAONZSiaeheBIC(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 VoOQwhwDqQSNmTqb(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.remainder(p31c30ba9Var2);
    }

    public static int VwSFhyNJnPcaCmTO(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m1d16fd25(i);
    }

    public static java.lang.string WFsfBtgoOoikjBPW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WJHtTcmewCQGuSPB(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void WlTPxJKQeBxmarun(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2, int i) {
        p31c30ba9Var.shiftLeftAddThis(p31c30ba9Var2, i);
    }

    public static void WnDZOdzpguAeGGpd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.assignX();
    }

    public static void WvqFgVSGyadWTItC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void XNVTZKPyQiwbKkrv(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.xorBit(i);
    }

    public static java.lang.stringBuilder XPMCDMMvxTgWcpKp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XSuSUmVuTQeNWnfW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static int XeZWGxVlOEepahFR(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 XldgRTVNDVSaJzMh(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.shiftLeft(i);
    }

    public static void YTvJjJHLyAvhIoWY(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 ZGxeFdikWXzLBiGT(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.remainder(p31c30ba9Var2);
    }

    public static java.lang.stringBuilder ZVvALDhZoghAvyFV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZWmiMvsPPaOwdBtu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool ZrWaiILsjNcMjnhE(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static void ACmtooMYtlBRPaxo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.addToThis(p31c30ba9Var2);
    }

    public static bool AhGtRCnkuKPJkbsV(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static java.lang.string AlcWNYKERlaRGsen(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void AljKHVImgSAcYEER(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.xorBit(i);
    }

    public static java.lang.stringBuilder BBVTQZQycZlQXRbR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder BuTIBlVXzuGZKSHP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CEZtCsvkmHRCsPWy(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int[] CYgGJsqKTlrHVWZC(int[] iArr, int[] iArr2) {
        return m5d7001a8(iArr, iArr2);
    }

    public static java.lang.string CsEZFGExaxnWTdSY(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void DITbnFDfYCcAiqtj(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int DoqsndCkxXLYjVoy(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void EBMtSqztcNnlDLge(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.addToThis(p31c30ba9Var2);
    }

    public static void EMZQBvZcXjAVvHcm(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder EMtzvRJJewkJQkSL(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool ETHiwDWEmrshwKhm(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static java.lang.string EbSuPvONSFbpxtbw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder EkwhpXqbCWOhrule(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool ErkgjqjsurbiDOIS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isOne();
    }

    public static bool EvfpamhWnFZYoTNZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static byte[] EynNLHQTnNyXzvla(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }

    public static bool FLnwVqFLyBuYfhNj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static int[] GCIPQEsOLQVEbzxg(int[] iArr, int[] iArr2) {
        return m24b9c245(iArr, iArr2);
    }

    public static void GGKTnwYsRFcfczXZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static java.lang.stringBuilder GLRDVdrgeqNpYsPC(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder GNJiPAwJnfVxcUnq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int GYAwmeTzWwVBJGGc(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void GtOxZzfKiguhGKpV(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder GzMvUrXdYprCCCid(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GzcHPiXapzjgDAns(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2, int i) {
        p31c30ba9Var.shiftLeftAddThis(p31c30ba9Var2, i);
    }

    public static java.lang.stringBuilder HPZQWgSujkbFCYBB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HaWSYXXgRtrCFazR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder HrVcFrgJkPlJCrhT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HvQgaRmuAGSYnvce(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.m604595a9();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 HvbUKkLYCmbmlfsx(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.mb1d5718c(p31c30ba9Var2);
    }

    public static java.lang.string IMPzLdilfnXovSQs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string IQIYkCIEmPYSlXua(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ISYKYjWzxcPcvLoM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.m1e048a41(i);
    }

    public static void IZrBQYYidafRCdxc(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.xorBit(i);
    }

    public static java.lang.string IyTqxvFkxSzeTerJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 JBUwjKLkjtmIRiEj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.mb1d5718c(p31c30ba9Var2);
    }

    public static bool JoxAzivxQsKcFUiD(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static bool JxMvDtoutkaZyVyo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static int[] KQFfSCUufNHpPlbQ(int[] iArr, int[] iArr2) {
        return m9d4b8699(iArr, iArr2);
    }

    public static int KgtavPpNEcXYHYsv(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int KizspEjXPwWkolYa(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 KjPqjDMeimZXfLyf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.mb1d5718c(p31c30ba9Var2);
    }

    public static java.lang.stringBuilder KuqMHYmFIknsoTAs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LCxETnzsIAypIgQi(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 LhOwXZuhukMGeERW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.shiftLeft(i);
    }

    public static void LoomIjpqjtlvOwBY(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.subtractFromThis(p31c30ba9Var2);
    }

    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 M0122b4c2(int i) {
        if ((12 + 1) % 1 > 0) {
        }
        int iRHVFnyEwzvpMRorU = RHVFnyEwzvpMRorU(i, this.fe7349649 - i);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(iRHVFnyEwzvpMRorU << 5);
        if (this.fe7349649 >= i) {
            GVRWnysQslzZcooq(this.f2063c160, i, p31c30ba9Var.f2063c160, 0, iRHVFnyEwzvpMRorU);
        }
        return p31c30ba9Var;
    }

    private void M1e048a41(int i) {
        if ((5 + 22) % 22 > 0) {
        }
        int i2 = this.fe7349649;
        int[] iArr = this.f2063c160;
        if (i2 > iArr.length) {
            int[] iArr2 = new int[i2];
            rXASytqteUYmyOgg(iArr, 0, iArr2, i, i2 - i);
            this.f2063c160 = iArr2;
            return;
        }
        for (int i3 = i2 - 1; i3 >= i; i3--) {
            int[] iArr3 = this.f2063c160;
            iArr3[i3] = iArr3[i3 - i];
        }
        for (int i4 = 0; i4 < i; i4++) {
            this.f2063c160[i4] = 0;
        }
    }

    private static int[] M24b9c245(int[] iArr, int[] iArr2) {
        char c;
        if ((11 + 12) % 12 > 0) {
        }
        int[] iArr3 = new int[16];
        int[] iArr4 = new int[4];
        WJHtTcmewCQGuSPB(iArr, 0, iArr4, 0, XeZWGxVlOEepahFR(4, iArr.length));
        int[] iArr5 = new int[4];
        if (iArr.length > 4) {
            YTvJjJHLyAvhIoWY(iArr, 4, iArr5, 0, qLUezBQikspgAhvM(4, iArr.length - 4));
        }
        int[] iArr6 = new int[4];
        TXTOfOMvWJnUFItO(iArr2, 0, iArr6, 0, KTAthUHTYdWUdNbX(4, iArr2.length));
        int[] iArr7 = new int[4];
        if (iArr2.length > 4) {
            xtdbUJwKvIEYaVDJ(iArr2, 4, iArr7, 0, ClBHgTXywUdvXCUb(4, iArr2.length - 4));
        }
        if (iArr5[3] != 0 || iArr5[2] != 0 || iArr7[3] != 0 || iArr7[2] != 0) {
            c = 3;
            int[] iArrGADYlpXPlVsNMAlh = GADYlpXPlVsNMAlh(iArr5, iArr7);
            int i = iArr3[15];
            int i2 = iArrGADYlpXPlVsNMAlh[7];
            iArr3[15] = i ^ i2;
            int i3 = iArr3[14];
            int i4 = iArrGADYlpXPlVsNMAlh[6];
            iArr3[14] = i3 ^ i4;
            int i5 = iArr3[13];
            int i6 = iArrGADYlpXPlVsNMAlh[5];
            iArr3[13] = i5 ^ i6;
            int i7 = iArr3[12];
            int i8 = iArrGADYlpXPlVsNMAlh[4];
            iArr3[12] = i7 ^ i8;
            int i9 = iArr3[11];
            int i10 = iArrGADYlpXPlVsNMAlh[3];
            iArr3[11] = i9 ^ (i10 ^ i2);
            int i11 = iArr3[10];
            int i12 = iArrGADYlpXPlVsNMAlh[2];
            iArr3[10] = i11 ^ (i12 ^ i4);
            int i13 = iArr3[9];
            int i14 = iArrGADYlpXPlVsNMAlh[1];
            iArr3[9] = i13 ^ (i14 ^ i6);
            int i15 = iArr3[8];
            int i16 = iArrGADYlpXPlVsNMAlh[0];
            iArr3[8] = i15 ^ (i16 ^ i8);
            iArr3[7] = iArr3[7] ^ i10;
            iArr3[6] = iArr3[6] ^ i12;
            iArr3[5] = iArr3[5] ^ i14;
            iArr3[4] = i16 ^ iArr3[4];
        } else if (iArr5[1] == 0 && iArr7[1] == 0) {
            int i17 = iArr5[0];
            if (i17 == 0 && iArr7[0] == 0) {
                c = 3;
            } else {
                c = 3;
                int[] iArrLGNAGpUOBnxsDEDQ = LGNAGpUOBnxsDEDQ(i17, iArr7[0]);
                int i18 = iArr3[9];
                int i19 = iArrLGNAGpUOBnxsDEDQ[1];
                iArr3[9] = i18 ^ i19;
                int i20 = iArr3[8];
                int i21 = iArrLGNAGpUOBnxsDEDQ[0];
                iArr3[8] = i20 ^ i21;
                iArr3[5] = iArr3[5] ^ i19;
                iArr3[4] = i21 ^ iArr3[4];
            }
        } else {
            c = 3;
            int[] iArrKQFfSCUufNHpPlbQ = kQFfSCUufNHpPlbQ(iArr5, iArr7);
            int i22 = iArr3[11];
            int i23 = iArrKQFfSCUufNHpPlbQ[3];
            iArr3[11] = i22 ^ i23;
            int i24 = iArr3[10];
            int i25 = iArrKQFfSCUufNHpPlbQ[2];
            iArr3[10] = i24 ^ i25;
            int i26 = iArr3[9];
            int i27 = iArrKQFfSCUufNHpPlbQ[1];
            iArr3[9] = i26 ^ i27;
            int i28 = iArr3[8];
            int i29 = iArrKQFfSCUufNHpPlbQ[0];
            iArr3[8] = i28 ^ i29;
            iArr3[7] = iArr3[7] ^ i23;
            iArr3[6] = iArr3[6] ^ i25;
            iArr3[5] = iArr3[5] ^ i27;
            iArr3[4] = i29 ^ iArr3[4];
        }
        iArr5[0] = iArr5[0] ^ iArr4[0];
        iArr5[1] = iArr5[1] ^ iArr4[1];
        iArr5[2] = iArr5[2] ^ iArr4[2];
        iArr5[c] = iArr5[c] ^ iArr4[c];
        iArr7[0] = iArr7[0] ^ iArr6[0];
        iArr7[1] = iArr7[1] ^ iArr6[1];
        iArr7[2] = iArr7[2] ^ iArr6[2];
        iArr7[c] = iArr7[c] ^ iArr6[c];
        int[] iArrPCsLSchbquFYPuNh = pCsLSchbquFYPuNh(iArr5, iArr7);
        iArr3[11] = iArr3[11] ^ iArrPCsLSchbquFYPuNh[7];
        iArr3[10] = iArr3[10] ^ iArrPCsLSchbquFYPuNh[6];
        iArr3[9] = iArr3[9] ^ iArrPCsLSchbquFYPuNh[5];
        iArr3[8] = iArr3[8] ^ iArrPCsLSchbquFYPuNh[4];
        iArr3[7] = iArr3[7] ^ iArrPCsLSchbquFYPuNh[c];
        iArr3[6] = iArr3[6] ^ iArrPCsLSchbquFYPuNh[2];
        iArr3[5] = iArr3[5] ^ iArrPCsLSchbquFYPuNh[1];
        iArr3[4] = iArrPCsLSchbquFYPuNh[0] ^ iArr3[4];
        int[] iArrRWjrRFLQXYhiYMbB = RWjrRFLQXYhiYMbB(iArr4, iArr6);
        int i30 = iArr3[11];
        int i31 = iArrRWjrRFLQXYhiYMbB[7];
        iArr3[11] = i30 ^ i31;
        int i32 = iArr3[10];
        int i33 = iArrRWjrRFLQXYhiYMbB[6];
        iArr3[10] = i32 ^ i33;
        int i34 = iArr3[9];
        int i35 = iArrRWjrRFLQXYhiYMbB[5];
        iArr3[9] = i34 ^ i35;
        int i36 = iArr3[8];
        int i37 = iArrRWjrRFLQXYhiYMbB[4];
        iArr3[8] = i36 ^ i37;
        int i38 = iArr3[7];
        int i39 = iArrRWjrRFLQXYhiYMbB[c];
        iArr3[7] = i38 ^ (i31 ^ i39);
        int i40 = iArr3[6];
        int i41 = iArrRWjrRFLQXYhiYMbB[2];
        iArr3[6] = i40 ^ (i33 ^ i41);
        int i42 = iArr3[5];
        int i43 = iArrRWjrRFLQXYhiYMbB[1];
        iArr3[5] = i42 ^ (i35 ^ i43);
        int i44 = iArr3[4];
        int i45 = iArrRWjrRFLQXYhiYMbB[0];
        iArr3[4] = i44 ^ (i45 ^ i37);
        iArr3[c] = iArr3[c] ^ i39;
        iArr3[2] = iArr3[2] ^ i41;
        iArr3[1] = iArr3[1] ^ i43;
        iArr3[0] = i45 ^ iArr3[0];
        return iArr3;
    }

    private static int[] M2bb3e9f2(int[] iArr, int[] iArr2) {
        if ((10 + 4) % 4 > 0) {
        }
        int[] iArr3 = new int[32];
        int[] iArr4 = new int[8];
        JyCStCujvOWSNDTd(iArr, 0, iArr4, 0, AlcYVwiZbhSnJoMA(8, iArr.length));
        int[] iArr5 = new int[8];
        if (iArr.length > 8) {
            TbVYdYfuBNqTITkU(iArr, 8, iArr5, 0, wqNxhuaGWFwcRqxU(8, iArr.length - 8));
        }
        int[] iArr6 = new int[8];
        sfhwGUzfYuZmJKVz(iArr2, 0, iArr6, 0, yIzHEXCItFQpPJQx(8, iArr2.length));
        int[] iArr7 = new int[8];
        if (iArr2.length > 8) {
            JcxFwSbjFiDoxsjN(iArr2, 8, iArr7, 0, VLXxhucXXkahMtby(8, iArr2.length - 8));
        }
        int[] iArrGWEoZPPRlfFdAQax = GWEoZPPRlfFdAQax(iArr5, iArr7);
        int i = iArr3[31];
        int i2 = iArrGWEoZPPRlfFdAQax[15];
        iArr3[31] = i ^ i2;
        int i3 = iArr3[30];
        int i4 = iArrGWEoZPPRlfFdAQax[14];
        iArr3[30] = i3 ^ i4;
        int i5 = iArr3[29];
        int i6 = iArrGWEoZPPRlfFdAQax[13];
        iArr3[29] = i5 ^ i6;
        int i7 = iArr3[28];
        int i8 = iArrGWEoZPPRlfFdAQax[12];
        iArr3[28] = i7 ^ i8;
        int i9 = iArr3[27];
        int i10 = iArrGWEoZPPRlfFdAQax[11];
        iArr3[27] = i9 ^ i10;
        int i11 = iArr3[26];
        int i12 = iArrGWEoZPPRlfFdAQax[10];
        iArr3[26] = i11 ^ i12;
        int i13 = iArr3[25];
        int i14 = iArrGWEoZPPRlfFdAQax[9];
        iArr3[25] = i13 ^ i14;
        int i15 = iArr3[24];
        int i16 = iArrGWEoZPPRlfFdAQax[8];
        iArr3[24] = i15 ^ i16;
        int i17 = iArr3[23];
        int i18 = iArrGWEoZPPRlfFdAQax[7];
        iArr3[23] = i17 ^ (i18 ^ i2);
        int i19 = iArr3[22];
        int i20 = iArrGWEoZPPRlfFdAQax[6];
        iArr3[22] = i19 ^ (i20 ^ i4);
        int i21 = iArr3[21];
        int i22 = iArrGWEoZPPRlfFdAQax[5];
        iArr3[21] = i21 ^ (i22 ^ i6);
        int i23 = iArr3[20];
        int i24 = iArrGWEoZPPRlfFdAQax[4];
        iArr3[20] = i23 ^ (i24 ^ i8);
        int i25 = iArr3[19];
        int i26 = iArrGWEoZPPRlfFdAQax[3];
        iArr3[19] = i25 ^ (i26 ^ i10);
        int i27 = iArr3[18];
        int i28 = iArrGWEoZPPRlfFdAQax[2];
        iArr3[18] = i27 ^ (i28 ^ i12);
        int i29 = iArr3[17];
        int i30 = iArrGWEoZPPRlfFdAQax[1];
        iArr3[17] = i29 ^ (i30 ^ i14);
        int i31 = iArr3[16];
        int i32 = iArrGWEoZPPRlfFdAQax[0];
        iArr3[16] = i31 ^ (i32 ^ i16);
        iArr3[15] = iArr3[15] ^ i18;
        iArr3[14] = iArr3[14] ^ i20;
        iArr3[13] = iArr3[13] ^ i22;
        iArr3[12] = iArr3[12] ^ i24;
        iArr3[11] = iArr3[11] ^ i26;
        iArr3[10] = iArr3[10] ^ i28;
        iArr3[9] = iArr3[9] ^ i30;
        iArr3[8] = iArr3[8] ^ i32;
        iArr5[0] = iArr5[0] ^ iArr4[0];
        iArr5[1] = iArr5[1] ^ iArr4[1];
        iArr5[2] = iArr5[2] ^ iArr4[2];
        iArr5[3] = iArr5[3] ^ iArr4[3];
        iArr5[4] = iArr5[4] ^ iArr4[4];
        iArr5[5] = iArr5[5] ^ iArr4[5];
        iArr5[6] = iArr5[6] ^ iArr4[6];
        iArr5[7] = iArr5[7] ^ iArr4[7];
        iArr7[0] = iArr7[0] ^ iArr6[0];
        iArr7[1] = iArr7[1] ^ iArr6[1];
        iArr7[2] = iArr7[2] ^ iArr6[2];
        iArr7[3] = iArr7[3] ^ iArr6[3];
        iArr7[4] = iArr7[4] ^ iArr6[4];
        iArr7[5] = iArr7[5] ^ iArr6[5];
        iArr7[6] = iArr7[6] ^ iArr6[6];
        iArr7[7] = iArr7[7] ^ iArr6[7];
        int[] iArrIDYieJSQpGbezdWe = IDYieJSQpGbezdWe(iArr5, iArr7);
        iArr3[23] = iArr3[23] ^ iArrIDYieJSQpGbezdWe[15];
        iArr3[22] = iArr3[22] ^ iArrIDYieJSQpGbezdWe[14];
        iArr3[21] = iArr3[21] ^ iArrIDYieJSQpGbezdWe[13];
        iArr3[20] = iArr3[20] ^ iArrIDYieJSQpGbezdWe[12];
        iArr3[19] = iArr3[19] ^ iArrIDYieJSQpGbezdWe[11];
        iArr3[18] = iArr3[18] ^ iArrIDYieJSQpGbezdWe[10];
        iArr3[17] = iArr3[17] ^ iArrIDYieJSQpGbezdWe[9];
        iArr3[16] = iArr3[16] ^ iArrIDYieJSQpGbezdWe[8];
        iArr3[15] = iArr3[15] ^ iArrIDYieJSQpGbezdWe[7];
        iArr3[14] = iArr3[14] ^ iArrIDYieJSQpGbezdWe[6];
        iArr3[13] = iArr3[13] ^ iArrIDYieJSQpGbezdWe[5];
        iArr3[12] = iArr3[12] ^ iArrIDYieJSQpGbezdWe[4];
        iArr3[11] = iArr3[11] ^ iArrIDYieJSQpGbezdWe[3];
        iArr3[10] = iArr3[10] ^ iArrIDYieJSQpGbezdWe[2];
        iArr3[9] = iArr3[9] ^ iArrIDYieJSQpGbezdWe[1];
        iArr3[8] = iArrIDYieJSQpGbezdWe[0] ^ iArr3[8];
        int[] iArrOJCyQbjWWwyGaNHM = oJCyQbjWWwyGaNHM(iArr4, iArr6);
        int i33 = iArr3[23];
        int i34 = iArrOJCyQbjWWwyGaNHM[15];
        iArr3[23] = i33 ^ i34;
        int i35 = iArr3[22];
        int i36 = iArrOJCyQbjWWwyGaNHM[14];
        iArr3[22] = i35 ^ i36;
        int i37 = iArr3[21];
        int i38 = iArrOJCyQbjWWwyGaNHM[13];
        iArr3[21] = i37 ^ i38;
        int i39 = iArr3[20];
        int i40 = iArrOJCyQbjWWwyGaNHM[12];
        iArr3[20] = i39 ^ i40;
        int i41 = iArr3[19];
        int i42 = iArrOJCyQbjWWwyGaNHM[11];
        iArr3[19] = i41 ^ i42;
        int i43 = iArr3[18];
        int i44 = iArrOJCyQbjWWwyGaNHM[10];
        iArr3[18] = i43 ^ i44;
        int i45 = iArr3[17];
        int i46 = iArrOJCyQbjWWwyGaNHM[9];
        iArr3[17] = i45 ^ i46;
        int i47 = iArr3[16];
        int i48 = iArrOJCyQbjWWwyGaNHM[8];
        iArr3[16] = i47 ^ i48;
        int i49 = iArr3[15];
        int i50 = iArrOJCyQbjWWwyGaNHM[7];
        iArr3[15] = i49 ^ (i34 ^ i50);
        int i51 = iArr3[14];
        int i52 = iArrOJCyQbjWWwyGaNHM[6];
        iArr3[14] = i51 ^ (i36 ^ i52);
        int i53 = iArr3[13];
        int i54 = iArrOJCyQbjWWwyGaNHM[5];
        iArr3[13] = i53 ^ (i38 ^ i54);
        int i55 = iArr3[12];
        int i56 = iArrOJCyQbjWWwyGaNHM[4];
        iArr3[12] = i55 ^ (i40 ^ i56);
        int i57 = iArr3[11];
        int i58 = iArrOJCyQbjWWwyGaNHM[3];
        iArr3[11] = i57 ^ (i42 ^ i58);
        int i59 = iArr3[10];
        int i60 = iArrOJCyQbjWWwyGaNHM[2];
        iArr3[10] = i59 ^ (i60 ^ i44);
        int i61 = iArr3[9];
        int i62 = iArrOJCyQbjWWwyGaNHM[1];
        iArr3[9] = i61 ^ (i62 ^ i46);
        int i63 = iArr3[8];
        int i64 = iArrOJCyQbjWWwyGaNHM[0];
        iArr3[8] = i63 ^ (i64 ^ i48);
        iArr3[7] = iArr3[7] ^ i50;
        iArr3[6] = iArr3[6] ^ i52;
        iArr3[5] = iArr3[5] ^ i54;
        iArr3[4] = iArr3[4] ^ i56;
        iArr3[3] = iArr3[3] ^ i58;
        iArr3[2] = iArr3[2] ^ i60;
        iArr3[1] = iArr3[1] ^ i62;
        iArr3[0] = i64 ^ iArr3[0];
        return iArr3;
    }

    private static int[] M5d7001a8(int[] iArr, int[] iArr2) {
        if ((30 + 8) % 8 > 0) {
        }
        int[] iArr3 = new int[8];
        int[] iArr4 = new int[2];
        JdkpGRjBvVnAFxOp(iArr, 0, iArr4, 0, zbsgUltHHkUfQZdL(2, iArr.length));
        int[] iArr5 = new int[2];
        if (iArr.length > 2) {
            LkLKiXqhLaOoaqjD(iArr, 2, iArr5, 0, doqsndCkxXLYjVoy(2, iArr.length - 2));
        }
        int[] iArr6 = new int[2];
        eMZQBvZcXjAVvHcm(iArr2, 0, iArr6, 0, kgtavPpNEcXYHYsv(2, iArr2.length));
        int[] iArr7 = new int[2];
        if (iArr2.length > 2) {
            oiGmLefTAqTRiEIS(iArr2, 2, iArr7, 0, gYAwmeTzWwVBJGGc(2, iArr2.length - 2));
        }
        if (iArr5[1] == 0 && iArr7[1] == 0) {
            int i = iArr5[0];
            if (i != 0 || iArr7[0] != 0) {
                int[] iArrDcLHnYhwSqZBzygd = DcLHnYhwSqZBzygd(i, iArr7[0]);
                int i2 = iArr3[5];
                int i3 = iArrDcLHnYhwSqZBzygd[1];
                iArr3[5] = i2 ^ i3;
                int i4 = iArr3[4];
                int i5 = iArrDcLHnYhwSqZBzygd[0];
                iArr3[4] = i4 ^ i5;
                iArr3[3] = iArr3[3] ^ i3;
                iArr3[2] = i5 ^ iArr3[2];
            }
        } else {
            int[] iArrKtinmPHYNDuASwJp = KtinmPHYNDuASwJp(iArr5, iArr7);
            int i6 = iArr3[7];
            int i7 = iArrKtinmPHYNDuASwJp[3];
            iArr3[7] = i6 ^ i7;
            int i8 = iArr3[6];
            int i9 = iArrKtinmPHYNDuASwJp[2];
            iArr3[6] = i8 ^ i9;
            int i10 = iArr3[5];
            int i11 = iArrKtinmPHYNDuASwJp[1];
            iArr3[5] = i10 ^ (i7 ^ i11);
            int i12 = iArr3[4];
            int i13 = iArrKtinmPHYNDuASwJp[0];
            iArr3[4] = i12 ^ (i13 ^ i9);
            iArr3[3] = iArr3[3] ^ i11;
            iArr3[2] = i13 ^ iArr3[2];
        }
        iArr5[0] = iArr5[0] ^ iArr4[0];
        iArr5[1] = iArr5[1] ^ iArr4[1];
        int i14 = iArr7[0] ^ iArr6[0];
        iArr7[0] = i14;
        int i15 = iArr7[1] ^ iArr6[1];
        iArr7[1] = i15;
        if (iArr5[1] == 0 && i15 == 0) {
            int[] iArrTGwsqBCZeCAuPCwf = TGwsqBCZeCAuPCwf(iArr5[0], i14);
            iArr3[3] = iArr3[3] ^ iArrTGwsqBCZeCAuPCwf[1];
            iArr3[2] = iArrTGwsqBCZeCAuPCwf[0] ^ iArr3[2];
        } else {
            int[] iArrBncsvZslHtlUMrcf = BncsvZslHtlUMrcf(iArr5, iArr7);
            iArr3[5] = iArr3[5] ^ iArrBncsvZslHtlUMrcf[3];
            iArr3[4] = iArr3[4] ^ iArrBncsvZslHtlUMrcf[2];
            iArr3[3] = iArr3[3] ^ iArrBncsvZslHtlUMrcf[1];
            iArr3[2] = iArrBncsvZslHtlUMrcf[0] ^ iArr3[2];
        }
        if (iArr4[1] == 0 && iArr6[1] == 0) {
            int[] iArrMjVVFIBXkUyfhNMN = MjVVFIBXkUyfhNMN(iArr4[0], iArr6[0]);
            int i16 = iArr3[3];
            int i17 = iArrMjVVFIBXkUyfhNMN[1];
            iArr3[3] = i16 ^ i17;
            int i18 = iArr3[2];
            int i19 = iArrMjVVFIBXkUyfhNMN[0];
            iArr3[2] = i18 ^ i19;
            iArr3[1] = iArr3[1] ^ i17;
            iArr3[0] = i19 ^ iArr3[0];
            return iArr3;
        }
        int[] iArrSajUAwkljMVVUwPY = SajUAwkljMVVUwPY(iArr4, iArr6);
        int i20 = iArr3[5];
        int i21 = iArrSajUAwkljMVVUwPY[3];
        iArr3[5] = i20 ^ i21;
        int i22 = iArr3[4];
        int i23 = iArrSajUAwkljMVVUwPY[2];
        iArr3[4] = i22 ^ i23;
        int i24 = iArr3[3];
        int i25 = iArrSajUAwkljMVVUwPY[1];
        iArr3[3] = i24 ^ (i21 ^ i25);
        int i26 = iArr3[2];
        int i27 = iArrSajUAwkljMVVUwPY[0];
        iArr3[2] = i26 ^ (i27 ^ i23);
        iArr3[1] = iArr3[1] ^ i25;
        iArr3[0] = i27 ^ iArr3[0];
        return iArr3;
    }

    private void M604595a9() {
        if ((4 + 32) % 32 > 0) {
        }
        int i = this.ff5a8e923;
        if ((i & 31) == 0) {
            return;
        }
        int[] iArr = this.f2063c160;
        int i2 = this.fe7349649 - 1;
        iArr[i2] = fa0e4e76a[i & 31] & iArr[i2];
    }

    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 M81e073b4(int i) {
        if ((1 + 11) % 11 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(i << 5);
        PHFHzBpwjIIOGcnP(this.f2063c160, 0, p31c30ba9Var.f2063c160, 0, MKagqadFfumNUrHT(i, this.fe7349649));
        return p31c30ba9Var;
    }

    private static int[] M95dc2b7a(int i, int i2) {
        if ((24 + 19) % 19 > 0) {
        }
        int[] iArr = new int[2];
        if (i != 0 && i2 != 0) {
            long j = ((long) i2) & 4294967295L;
            long j2 = 0;
            for (int i3 = 1; i3 <= 32; i3++) {
                if ((f301d90e3[i3 - 1] & i) != 0) {
                    j2 ^= j;
                }
                j <<= 1;
            }
            iArr[1] = (int) (j2 >>> 32);
            iArr[0] = (int) (j2 & 4294967295L);
        }
        return iArr;
    }

    private static int[] M9d4b8699(int[] iArr, int[] iArr2) {
        if ((5 + 22) % 22 > 0) {
        }
        int[] iArr3 = new int[4];
        int i = iArr[0];
        int i2 = iArr.length <= 1 ? 0 : iArr[1];
        int i3 = iArr2[0];
        int i4 = iArr2.length <= 1 ? 0 : iArr2[1];
        if (i2 != 0 || i4 != 0) {
            int[] iArrGyFznKQpfZVvFXHB = GyFznKQpfZVvFXHB(i2, i4);
            int i5 = iArr3[3];
            int i6 = iArrGyFznKQpfZVvFXHB[1];
            iArr3[3] = i5 ^ i6;
            int i7 = iArr3[2];
            int i8 = iArrGyFznKQpfZVvFXHB[0];
            iArr3[2] = i7 ^ (i8 ^ i6);
            iArr3[1] = i8 ^ iArr3[1];
        }
        int[] iArrRKtyAmBrAaiEyJXw = RKtyAmBrAaiEyJXw(i2 ^ i, i4 ^ i3);
        iArr3[2] = iArr3[2] ^ iArrRKtyAmBrAaiEyJXw[1];
        iArr3[1] = iArrRKtyAmBrAaiEyJXw[0] ^ iArr3[1];
        int[] iArrQiGKttykUgoBbAju = QiGKttykUgoBbAju(i, i3);
        int i9 = iArr3[2];
        int i10 = iArrQiGKttykUgoBbAju[1];
        iArr3[2] = i9 ^ i10;
        int i11 = iArr3[1];
        int i12 = iArrQiGKttykUgoBbAju[0];
        iArr3[1] = i11 ^ (i10 ^ i12);
        iArr3[0] = i12 ^ iArr3[0];
        return iArr3;
    }

    public static int[] MVClMKeXLrpghARL(int i, int i2) {
        return m95dc2b7a(i, i2);
    }

    public static void MZxYTJhUFugLvrhs(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.m604595a9();
    }

    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Mb1d5718c(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        if ((31 + 15) % 15 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923 << 1);
        int i = this.ff5a8e923;
        if (i <= 32) {
            p31c30ba9Var2.f2063c160 = mVClMKeXLrpghARL(this.f2063c160[0], p31c30ba9Var.f2063c160[0]);
            return p31c30ba9Var2;
        }
        if (i <= 64) {
            p31c30ba9Var2.f2063c160 = DScGHovAxVGSTaTC(this.f2063c160, p31c30ba9Var.f2063c160);
            return p31c30ba9Var2;
        }
        if (i <= 128) {
            p31c30ba9Var2.f2063c160 = cYgGJsqKTlrHVWZC(this.f2063c160, p31c30ba9Var.f2063c160);
            return p31c30ba9Var2;
        }
        if (i <= 256) {
            p31c30ba9Var2.f2063c160 = gCIPQEsOLQVEbzxg(this.f2063c160, p31c30ba9Var.f2063c160);
            return p31c30ba9Var2;
        }
        if (i <= 512) {
            p31c30ba9Var2.f2063c160 = NoPJzsIxCjyAsqCA(this.f2063c160, p31c30ba9Var.f2063c160);
            return p31c30ba9Var2;
        }
        int i2 = f301d90e3[VwSFhyNJnPcaCmTO(i - 1)];
        int i3 = ((i2 - 1) >> 5) + 1;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarRhkFJosCctnxvuht = rhkFJosCctnxvuht(this, i3);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarDyAGIhrTyTFQAuml = DyAGIhrTyTFQAuml(this, i3);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarMmCyWhPQaYczUDZL = MmCyWhPQaYczUDZL(p31c30ba9Var, i3);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarPHluVagXsNngZhdw = PHluVagXsNngZhdw(p31c30ba9Var, i3);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarHvbUKkLYCmbmlfsx = hvbUKkLYCmbmlfsx(p31c30ba9VarDyAGIhrTyTFQAuml, p31c30ba9VarPHluVagXsNngZhdw);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarOMtwlMCzFWiRExfd = OMtwlMCzFWiRExfd(p31c30ba9VarRhkFJosCctnxvuht, p31c30ba9VarMmCyWhPQaYczUDZL);
        NplvfkmolnXfqVBu(p31c30ba9VarRhkFJosCctnxvuht, p31c30ba9VarDyAGIhrTyTFQAuml);
        aCmtooMYtlBRPaxo(p31c30ba9VarMmCyWhPQaYczUDZL, p31c30ba9VarPHluVagXsNngZhdw);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarJBUwjKLkjtmIRiEj = jBUwjKLkjtmIRiEj(p31c30ba9VarRhkFJosCctnxvuht, p31c30ba9VarMmCyWhPQaYczUDZL);
        gzcHPiXapzjgDAns(p31c30ba9Var2, p31c30ba9VarHvbUKkLYCmbmlfsx, i2 << 1);
        WlTPxJKQeBxmarun(p31c30ba9Var2, p31c30ba9VarHvbUKkLYCmbmlfsx, i2);
        DfBzgcdxJxwCTPFu(p31c30ba9Var2, p31c30ba9VarJBUwjKLkjtmIRiEj, i2);
        rWpyBbcbgUpRJAlu(p31c30ba9Var2, p31c30ba9VarOMtwlMCzFWiRExfd, i2);
        mkwTSaggYyzdElCD(p31c30ba9Var2, p31c30ba9VarOMtwlMCzFWiRExfd);
        return p31c30ba9Var2;
    }

    public static void MkwTSaggYyzdElCD(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.addToThis(p31c30ba9Var2);
    }

    public static int NFQbVHwQHZanrhzp(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool NOmnyqgNoxkRFxHy(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static byte[] NYbMhoLKuZnhenPQ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.tobyteArray();
    }

    public static void NvhxqcuMedgtmDmE(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.m604595a9();
    }

    public static void OHYfvPsdyEXBeDip(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int[] OJCyQbjWWwyGaNHM(int[] iArr, int[] iArr2) {
        return m24b9c245(iArr, iArr2);
    }

    public static void OiGmLefTAqTRiEIS(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 OploaQHBtciYfzrW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.gcd(p31c30ba9Var2);
    }

    public static int[] PCsLSchbquFYPuNh(int[] iArr, int[] iArr2) {
        return m5d7001a8(iArr, iArr2);
    }

    public static int QLUezBQikspgAhvM(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void QyJWjnJGEVtTWetc(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.assignZero();
    }

    public static void RWpyBbcbgUpRJAlu(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2, int i) {
        p31c30ba9Var.shiftLeftAddThis(p31c30ba9Var2, i);
    }

    public static void RXASytqteUYmyOgg(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 RhkFJosCctnxvuht(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.m81e073b4(i);
    }

    public static java.lang.string RnwObmSYdyEEmyKP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string RyXugdpHrBdcMGxg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SVTaQhcybwBOmJiU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SfhwGUzfYuZmJKVz(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 SxMoptAInyYttkdn(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.xor(p31c30ba9Var2);
    }

    public static int TFOpGmWZNXGBfmPF(java.util.Random random) {
        return random.nextInt();
    }

    public static java.lang.stringBuilder TTzAwaYPWJGJBgzP(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string ThuVavAhKywkQhKI(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string USvrUTNLyLucwJRW(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string UugNJpzJnbKMXHeg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 UxzvOynTcHdmuiJX(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.shiftLeft();
    }

    public static int WqNxhuaGWFwcRqxU(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.stringBuilder WyivglgPPCtvWgfu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XCOdVbTlxGNCBxHn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string XEzdGDEvzwcLcQfu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XpDBRJcnptSSpJke(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.m604595a9();
    }

    public static void XtdbUJwKvIEYaVDJ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder XxapGTucdkzQWzPK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YGhMlJSwDTmdVzUS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.m604595a9();
    }

    public static int YIzHEXCItFQpPJQx(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void YxXIdVVGFskjGJGR(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static java.lang.stringBuilder ZEIuMseFiJGRbkoO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ZbsgUltHHkUfQZdL(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool ZdfoZRIuEOpOvZey(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static java.lang.string ZlTtTimxjNtGGCOg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ZpzIMEjrdDukNFIo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int[] ZrHnAeUkszYNhxiO(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return DdfTuGODtSCAOtHD(this, p31c30ba9Var);
    }

    public void AddToThis(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        TmQfayOrxvzlDbpy(this, p31c30ba9Var.ff5a8e923);
        BvBhzYpvXgQAMiqe(this, p31c30ba9Var);
    }

    public void AssignAll() {
        if ((21 + 20) % 20 > 0) {
        }
        for (int i = 0; i < this.fe7349649; i++) {
            this.f2063c160[i] = -1;
        }
        hvQgaRmuAGSYnvce(this);
    }

    public void AssignOne() {
        if ((9 + 7) % 7 > 0) {
        }
        for (int i = 1; i < this.fe7349649; i++) {
            this.f2063c160[i] = 0;
        }
        this.f2063c160[0] = 1;
    }

    public void AssignX() {
        if ((12 + 4) % 4 > 0) {
        }
        for (int i = 1; i < this.fe7349649; i++) {
            this.f2063c160[i] = 0;
        }
        this.f2063c160[0] = 2;
    }

    public void AssignZero() {
        if ((14 + 8) % 8 > 0) {
        }
        for (int i = 0; i < this.fe7349649; i++) {
            this.f2063c160[i] = 0;
        }
    }

    public java.lang.object Clone() {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] Divide(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        if ((2 + 15) % 15 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[2];
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        if (zdfoZRIuEOpOvZey(p31c30ba9Var4)) {
            throw new java.lang.Exception();
        }
        yxXIdVVGFskjGJGR(p31c30ba9Var3);
        JiRSjxQoQWGURTal(p31c30ba9Var4);
        int i = p31c30ba9Var3.ff5a8e923;
        int i2 = p31c30ba9Var4.ff5a8e923;
        if (i < i2) {
            p31c30ba9VarArr[0] = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(0);
            p31c30ba9VarArr[1] = p31c30ba9Var3;
            return p31c30ba9VarArr;
        }
        int i3 = i - i2;
        OBsMBMVBiWACtkKw(p31c30ba9Var2, i3 + 1);
        while (i3 >= 0) {
            PyAbYMiTPebUdcKa(p31c30ba9Var3, lhOwXZuhukMGeERW(p31c30ba9Var4, i3));
            FelpXigeEJFjZZUT(p31c30ba9Var3);
            iZrBQYYidafRCdxc(p31c30ba9Var2, i3);
            i3 = p31c30ba9Var3.ff5a8e923 - p31c30ba9Var4.ff5a8e923;
        }
        p31c30ba9VarArr[0] = p31c30ba9Var2;
        p31c30ba9VarArr[1] = p31c30ba9Var3;
        return p31c30ba9VarArr;
    }

    public bool Equals(java.lang.object obj) {
        if ((8 + 7) % 7 > 0) {
        }
        if (obj is null || !(obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9)) {
            return false;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9) obj;
        if (this.ff5a8e923 != p31c30ba9Var.ff5a8e923) {
            return false;
        }
        for (int i = 0; i < this.fe7349649; i++) {
            if (this.f2063c160[i] != p31c30ba9Var.f2063c160[i]) {
                return false;
            }
        }
        return true;
    }

    public void ExpandN(int i) {
        if ((5 + 10) % 10 > 0) {
        }
        if (this.ff5a8e923 < i) {
            this.ff5a8e923 = i;
            int i2 = ((i - 1) >>> 5) + 1;
            int i3 = this.fe7349649;
            if (i3 < i2) {
                int[] iArr = this.f2063c160;
                if (iArr.length < i2) {
                    int[] iArr2 = new int[i2];
                    AVxvVLTuZPRfcLOX(iArr, 0, iArr2, 0, i3);
                    this.fe7349649 = i2;
                    this.f2063c160 = iArr2;
                    return;
                }
                while (i3 < i2) {
                    this.f2063c160[i3] = 0;
                    i3++;
                }
                this.fe7349649 = i2;
            }
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Gcd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        if ((29 + 24) % 24 > 0) {
        }
        if (ahGtRCnkuKPJkbsV(this) && evfpamhWnFZYoTNZ(p31c30ba9Var)) {
            throw new java.lang.ArithmeticException("Both operands of gcd equal zero.");
        }
        if (QMLcTuEAtgEfetnT(this)) {
            return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        }
        if (CLifbklupSuNcgZw(p31c30ba9Var)) {
            return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        while (true) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = p31c30ba9Var2;
            p31c30ba9Var2 = p31c30ba9Var3;
            if (fLnwVqFLyBuYfhNj(p31c30ba9Var2)) {
                return p31c30ba9Var4;
            }
            p31c30ba9Var3 = ZGxeFdikWXzLBiGT(p31c30ba9Var4, p31c30ba9Var2);
        }
    }

    public int GetBit(int i) {
        if ((5 + 28) % 28 > 0) {
        }
        if (i < 0) {
            throw new java.lang.Exception();
        }
        return (i > this.ff5a8e923 - 1 || (this.f2063c160[i >>> 5] & f301d90e3[i & 31]) == 0) ? 0 : 1;
    }

    public int GetLength() {
        return this.ff5a8e923;
    }

    public int HashCode() {
        return this.ff5a8e923 + DeUeSZVFrOpbnWKv(this.f2063c160);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Increase() {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        MawxHirbGNsAnvle(p31c30ba9Var);
        return p31c30ba9Var;
    }

    public void IncreaseThis() {
        aljKHVImgSAcYEER(this, 0);
    }

    public bool IsIrreducible() {
        if ((6 + 9) % 9 > 0) {
        }
        if (HDycIODuQhbUATjI(this)) {
            return false;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        SFSraPWodbzKjrTU(p31c30ba9Var);
        int i = p31c30ba9Var.ff5a8e923;
        int i2 = i - 1;
        java.lang.string strThuVavAhKywkQhKI = thuVavAhKywkQhKI("7954bbfa407f6aa1e7c6248f7b581d8ed103f1829eb9f932c151951a15");
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(i, strThuVavAhKywkQhKI);
        for (int i3 = 1; i3 <= (i2 >> 1); i3++) {
            DMIvSHIkYnYdVMgl(p31c30ba9Var2);
            p31c30ba9Var2 = VoOQwhwDqQSNmTqb(p31c30ba9Var2, p31c30ba9Var);
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarHevFVllzfNccfmvw = HevFVllzfNccfmvw(p31c30ba9Var2, new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(32, strThuVavAhKywkQhKI));
            if (eTHiwDWEmrshwKhm(p31c30ba9VarHevFVllzfNccfmvw) || !erkgjqjsurbiDOIS(oploaQHBtciYfzrW(p31c30ba9Var, p31c30ba9VarHevFVllzfNccfmvw))) {
                return false;
            }
        }
        return true;
    }

    public bool IsOne() {
        if ((2 + 19) % 19 > 0) {
        }
        for (int i = 1; i < this.fe7349649; i++) {
            if (this.f2063c160[i] != 0) {
                return false;
            }
        }
        return this.f2063c160[0] == 1;
    }

    public bool IsZero() {
        if ((20 + 1) % 1 > 0) {
        }
        if (this.ff5a8e923 == 0) {
            return true;
        }
        for (int i = 0; i < this.fe7349649; i++) {
            if (this.f2063c160[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Multiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        if ((3 + 15) % 15 > 0) {
        }
        int iIYmDKssNBDRxNUwp = IYmDKssNBDRxNUwp(this.ff5a8e923, p31c30ba9Var.ff5a8e923);
        XSuSUmVuTQeNWnfW(this, iIYmDKssNBDRxNUwp);
        UmjNpQXbzhcnwwlc(p31c30ba9Var, iIYmDKssNBDRxNUwp);
        return kjPqjDMeimZXfLyf(this, p31c30ba9Var);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 MultiplyClassic(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        if ((26 + 11) % 11 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(PldTnDcjHqddvXxW(this.ff5a8e923, p31c30ba9Var.ff5a8e923) << 1);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[32];
        p31c30ba9VarArr[0] = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        for (int i = 1; i <= 31; i++) {
            p31c30ba9VarArr[i] = uxzvOynTcHdmuiJX(p31c30ba9VarArr[i - 1]);
        }
        for (int i2 = 0; i2 < p31c30ba9Var.fe7349649; i2++) {
            for (int i3 = 0; i3 <= 31; i3++) {
                if ((p31c30ba9Var.f2063c160[i2] & f301d90e3[i3]) != 0) {
                    AMXIsGIZHNHZbJUj(p31c30ba9Var2, p31c30ba9VarArr[i3]);
                }
            }
            for (int i4 = 0; i4 <= 31; i4++) {
                BQmbIYkYAfJxMrLN(p31c30ba9VarArr[i4]);
            }
        }
        return p31c30ba9Var2;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Quotient(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        if ((13 + 16) % 16 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        if (DpoSBxkhLcLHaqgR(p31c30ba9Var4)) {
            throw new java.lang.Exception();
        }
        WvqFgVSGyadWTItC(p31c30ba9Var3);
        BJSoVlbytbUHDjNm(p31c30ba9Var4);
        int i = p31c30ba9Var3.ff5a8e923;
        int i2 = p31c30ba9Var4.ff5a8e923;
        if (i < i2) {
            return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(0);
        }
        int i3 = i - i2;
        UxWGOHDxivteAtvP(p31c30ba9Var2, i3 + 1);
        while (i3 >= 0) {
            loomIjpqjtlvOwBY(p31c30ba9Var3, XldgRTVNDVSaJzMh(p31c30ba9Var4, i3));
            BHAQHEmOjDdkqSeH(p31c30ba9Var3);
            XNVTZKPyQiwbKkrv(p31c30ba9Var2, i3);
            i3 = p31c30ba9Var3.ff5a8e923 - p31c30ba9Var4.ff5a8e923;
        }
        return p31c30ba9Var2;
    }

    public void Randomize() {
        if ((24 + 5) % 5 > 0) {
        }
        for (int i = 0; i < this.fe7349649; i++) {
            this.f2063c160[i] = RsVIvTcAIfoxyHkl(f34d1c350);
        }
        CAgVjTycWPUXsKIR(this);
    }

    public void Randomize(java.util.Random random) {
        if ((3 + 2) % 2 > 0) {
        }
        for (int i = 0; i < this.fe7349649; i++) {
            this.f2063c160[i] = tFOpGmWZNXGBfmPF(random);
        }
        yGhMlJSwDTmdVzUS(this);
    }

    public void ReduceN() {
        int i;
        if ((10 + 1) % 1 > 0) {
        }
        int i2 = this.fe7349649;
        do {
            i2--;
            i = this.f2063c160[i2];
            if (i != 0) {
                break;
            }
        } while (i2 > 0);
        int i3 = 0;
        while (i != 0) {
            i >>>= 1;
            i3++;
        }
        this.ff5a8e923 = (i2 << 5) + i3;
        this.fe7349649 = i2 + 1;
    }

    void reducePentanomial(int i, int[] iArr) {
        if ((13 + 1) % 1 > 0) {
        }
        int i2 = i >>> 5;
        int i3 = i & 31;
        int i4 = 32 - i3;
        int i5 = 0;
        int i6 = iArr[0];
        int i7 = (i - i6) >>> 5;
        int i8 = 32 - ((i - i6) & 31);
        bool z = true;
        int i9 = iArr[1];
        int i10 = (i - i9) >>> 5;
        int i11 = 32 - ((i - i9) & 31);
        int i12 = iArr[2];
        int i13 = (i - i12) >>> 5;
        int i14 = 32 - ((i - i12) & 31);
        int i15 = ((i << 1) - 2) >>> 5;
        while (i15 > i2) {
            int i16 = i5;
            int[] iArr2 = this.f2063c160;
            bool z2 = z;
            long j = ((long) iArr2[i15]) & 4294967295L;
            int i17 = i15 - i2;
            int i18 = i17 - 1;
            int i19 = i2;
            int i20 = i3;
            iArr2[i18] = iArr2[i18] ^ ((int) (j << i4));
            iArr2[i17] = (int) (((long) iArr2[i17]) ^ (j >>> (32 - i4)));
            int i21 = i15 - i7;
            int i22 = i21 - 1;
            iArr2[i22] = ((int) (j << i8)) ^ iArr2[i22];
            iArr2[i21] = (int) (((long) iArr2[i21]) ^ (j >>> (32 - i8)));
            int i23 = i15 - i10;
            int i24 = i23 - 1;
            iArr2[i24] = ((int) (j << i11)) ^ iArr2[i24];
            iArr2[i23] = (int) (((long) iArr2[i23]) ^ (j >>> (32 - i11)));
            int i25 = i15 - i13;
            int i26 = i25 - 1;
            iArr2[i26] = ((int) (j << i14)) ^ iArr2[i26];
            iArr2[i25] = (int) (((long) iArr2[i25]) ^ (j >>> (32 - i14)));
            iArr2[i15] = i16;
            i15--;
            i5 = i16;
            z = z2;
            i2 = i19;
            i3 = i20;
        }
        int i27 = i2;
        int i28 = i3;
        int i29 = i5;
        int[] iArr3 = this.f2063c160;
        long j2 = ((long) iArr3[i27]) & 4294967295L & (4294967295 << i28);
        iArr3[i29] = (int) (((long) iArr3[i29]) ^ (j2 >>> (32 - i4)));
        int i30 = i27 - i7;
        int i31 = i30 - 1;
        if (i31 >= 0) {
            iArr3[i31] = iArr3[i31] ^ ((int) (j2 << i8));
        }
        iArr3[i30] = (int) (((long) iArr3[i30]) ^ (j2 >>> (32 - i8)));
        int i32 = i27 - i10;
        int i33 = i32 - 1;
        if (i33 >= 0) {
            iArr3[i33] = iArr3[i33] ^ ((int) (j2 << i11));
        }
        iArr3[i32] = (int) (((long) iArr3[i32]) ^ (j2 >>> (32 - i11)));
        int i34 = i27 - i13;
        int i35 = i34 - 1;
        if (i35 >= 0) {
            iArr3[i35] = iArr3[i35] ^ ((int) (j2 << i14));
        }
        iArr3[i34] = (int) (((long) iArr3[i34]) ^ (j2 >>> (32 - i14)));
        iArr3[i27] = iArr3[i27] & fa0e4e76a[i28];
        this.fe7349649 = ((i - 1) >>> 5) + 1;
        this.ff5a8e923 = i;
    }

    void reduceTrinomial(int i, int i2) {
        if ((13 + 11) % 11 > 0) {
        }
        int i3 = i >>> 5;
        int i4 = i & 31;
        int i5 = 32 - i4;
        int i6 = i - i2;
        int i7 = i6 >>> 5;
        int i8 = 32 - (i6 & 31);
        for (int i9 = ((i << 1) - 2) >>> 5; i9 > i3; i9--) {
            int[] iArr = this.f2063c160;
            long j = 4294967295L & ((long) iArr[i9]);
            int i10 = i9 - i3;
            int i11 = i10 - 1;
            iArr[i11] = ((int) (j << i5)) ^ iArr[i11];
            iArr[i10] = (int) (((long) iArr[i10]) ^ (j >>> (32 - i5)));
            int i12 = i9 - i7;
            int i13 = i12 - 1;
            iArr[i13] = iArr[i13] ^ ((int) (j << i8));
            iArr[i12] = (int) (((long) iArr[i12]) ^ (j >>> (32 - i8)));
            iArr[i9] = 0;
        }
        int[] iArr2 = this.f2063c160;
        long j2 = (4294967295 << i4) & ((long) iArr2[i3]) & 4294967295L;
        iArr2[0] = (int) (((long) iArr2[0]) ^ (j2 >>> (32 - i5)));
        int i14 = i3 - i7;
        int i15 = i14 - 1;
        if (i15 >= 0) {
            iArr2[i15] = iArr2[i15] ^ ((int) (j2 << i8));
        }
        iArr2[i14] = (int) ((j2 >>> (32 - i8)) ^ ((long) iArr2[i14]));
        iArr2[i3] = fa0e4e76a[i4] & iArr2[i3];
        this.fe7349649 = ((i - 1) >>> 5) + 1;
        this.ff5a8e923 = i;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Remainder(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        if ((4 + 9) % 9 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        if (jxMvDtoutkaZyVyo(p31c30ba9Var3)) {
            throw new java.lang.Exception();
        }
        JQvNExTwAOHRYSTi(p31c30ba9Var2);
        VnetbEMUCBKuUfYN(p31c30ba9Var3);
        int i = p31c30ba9Var2.ff5a8e923;
        int i2 = p31c30ba9Var3.ff5a8e923;
        if (i >= i2) {
            while (true) {
                int i3 = i - i2;
                if (i3 < 0) {
                    break;
                }
                VWDloBXOSWOmlhEo(p31c30ba9Var2, CKkvveQadeyLgHMV(p31c30ba9Var3, i3));
                USndoSrKjsogFUli(p31c30ba9Var2);
                i = p31c30ba9Var2.ff5a8e923;
                i2 = p31c30ba9Var3.ff5a8e923;
            }
        }
        return p31c30ba9Var2;
    }

    public void ResetBit(int i) throws java.lang.Exception {
        if ((18 + 32) % 32 > 0) {
        }
        if (i < 0) {
            throw new java.lang.Exception();
        }
        if (i <= this.ff5a8e923 - 1) {
            int[] iArr = this.f2063c160;
            int i2 = i >>> 5;
            iArr[i2] = (~f301d90e3[i & 31]) & iArr[i2];
        }
    }

    public void SetBit(int i) throws java.lang.Exception {
        if ((9 + 10) % 10 > 0) {
        }
        if (i < 0 || i > this.ff5a8e923 - 1) {
            throw new java.lang.Exception();
        }
        int[] iArr = this.f2063c160;
        int i2 = i >>> 5;
        iArr[i2] = f301d90e3[i & 31] | iArr[i2];
    }

    void shiftBlocksLeft() {
        if ((27 + 27) % 27 > 0) {
        }
        int i = this.fe7349649;
        int i2 = i + 1;
        this.fe7349649 = i2;
        this.ff5a8e923 += 32;
        int[] iArr = this.f2063c160;
        if (i2 > iArr.length) {
            int[] iArr2 = new int[i2];
            cEZtCsvkmHRCsPWy(iArr, 0, iArr2, 1, i);
            this.f2063c160 = iArr2;
        } else {
            while (i >= 1) {
                int[] iArr3 = this.f2063c160;
                iArr3[i] = iArr3[i - 1];
                i--;
            }
            this.f2063c160[0] = 0;
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 ShiftLeft() {
        if ((1 + 24) % 24 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923 + 1, this.f2063c160);
        for (int i = p31c30ba9Var.fe7349649 - 1; i >= 1; i--) {
            int[] iArr = p31c30ba9Var.f2063c160;
            int i2 = iArr[i] << 1;
            iArr[i] = i2;
            iArr[i] = i2 | (iArr[i - 1] >>> 31);
        }
        int[] iArr2 = p31c30ba9Var.f2063c160;
        iArr2[0] = iArr2[0] << 1;
        return p31c30ba9Var;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 ShiftLeft(int i) {
        if ((24 + 2) % 2 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923 + i, this.f2063c160);
        if (i >= 32) {
            iSYKYjWzxcPcvLoM(p31c30ba9Var, i >>> 5);
        }
        int i2 = i & 31;
        if (i2 != 0) {
            for (int i3 = p31c30ba9Var.fe7349649 - 1; i3 >= 1; i3--) {
                int[] iArr = p31c30ba9Var.f2063c160;
                int i4 = iArr[i3] << i2;
                iArr[i3] = i4;
                iArr[i3] = i4 | (iArr[i3 - 1] >>> (32 - i2));
            }
            int[] iArr2 = p31c30ba9Var.f2063c160;
            iArr2[0] = iArr2[0] << i2;
        }
        return p31c30ba9Var;
    }

    public void ShiftLeftAddThis(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        int i2;
        if ((13 + 21) % 21 > 0) {
        }
        if (i == 0) {
            eBMtSqztcNnlDLge(this, p31c30ba9Var);
            return;
        }
        gGKTnwYsRFcfczXZ(this, p31c30ba9Var.ff5a8e923 + i);
        int i3 = i >>> 5;
        for (int i4 = p31c30ba9Var.fe7349649 - 1; i4 >= 0; i4--) {
            int i5 = i4 + i3;
            int i6 = i5 + 1;
            if (i6 < this.fe7349649 && (i2 = i & 31) != 0) {
                int[] iArr = this.f2063c160;
                iArr[i6] = (p31c30ba9Var.f2063c160[i4] >>> (32 - i2)) ^ iArr[i6];
            }
            int[] iArr2 = this.f2063c160;
            iArr2[i5] = iArr2[i5] ^ (p31c30ba9Var.f2063c160[i4] << (i & 31));
        }
    }

    public void ShiftLeftThis() {
        if ((2 + 23) % 23 > 0) {
        }
        int i = this.ff5a8e923;
        if ((i & 31) != 0) {
            this.ff5a8e923 = i + 1;
            for (int i2 = this.fe7349649 - 1; i2 >= 1; i2--) {
                int[] iArr = this.f2063c160;
                int i3 = iArr[i2] << 1;
                iArr[i2] = i3;
                iArr[i2] = i3 | (iArr[i2 - 1] >>> 31);
            }
            int[] iArr2 = this.f2063c160;
            iArr2[0] = iArr2[0] << 1;
            return;
        }
        this.ff5a8e923 = i + 1;
        int i4 = this.fe7349649 + 1;
        this.fe7349649 = i4;
        int[] iArr3 = this.f2063c160;
        if (i4 > iArr3.length) {
            int[] iArr4 = new int[i4];
            gtOxZzfKiguhGKpV(iArr3, 0, iArr4, 0, iArr3.length);
            this.f2063c160 = iArr4;
        }
        for (int i5 = this.fe7349649 - 1; i5 >= 1; i5--) {
            int[] iArr5 = this.f2063c160;
            int i6 = i5 - 1;
            iArr5[i5] = iArr5[i5] | (iArr5[i6] >>> 31);
            iArr5[i6] = iArr5[i6] << 1;
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 ShiftRight() {
        int i;
        if ((3 + 32) % 32 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923 - 1);
        int i2 = 0;
        dITbnFDfYCcAiqtj(this.f2063c160, 0, p31c30ba9Var.f2063c160, 0, p31c30ba9Var.fe7349649);
        while (true) {
            i = p31c30ba9Var.fe7349649;
            if (i2 > i - 2) {
                break;
            }
            int[] iArr = p31c30ba9Var.f2063c160;
            int i3 = iArr[i2] >>> 1;
            iArr[i2] = i3;
            int i4 = i2 + 1;
            iArr[i2] = i3 | (iArr[i4] << 31);
            i2 = i4;
        }
        int[] iArr2 = p31c30ba9Var.f2063c160;
        int i5 = i - 1;
        iArr2[i5] = iArr2[i5] >>> 1;
        if (i < this.fe7349649) {
            int i6 = i - 1;
            iArr2[i6] = (this.f2063c160[i] << 31) | iArr2[i6];
        }
        return p31c30ba9Var;
    }

    public void ShiftRightThis() {
        int i;
        if ((10 + 29) % 29 > 0) {
        }
        int i2 = this.ff5a8e923;
        this.ff5a8e923 = i2 - 1;
        this.fe7349649 = ((i2 - 2) >>> 5) + 1;
        int i3 = 0;
        while (true) {
            i = this.fe7349649;
            if (i3 > i - 2) {
                break;
            }
            int[] iArr = this.f2063c160;
            int i4 = iArr[i3] >>> 1;
            iArr[i3] = i4;
            int i5 = i3 + 1;
            iArr[i3] = i4 | (iArr[i5] << 31);
            i3 = i5;
        }
        int[] iArr2 = this.f2063c160;
        int i6 = i - 1;
        iArr2[i6] = iArr2[i6] >>> 1;
        if ((this.ff5a8e923 & 31) != 0) {
            return;
        }
        int i7 = i - 1;
        iArr2[i7] = (iArr2[i] << 31) | iArr2[i7];
    }

    public void SquareThisBitwise() {
        if ((3 + 13) % 13 > 0) {
        }
        if (AubdpUByPItfoGeL(this)) {
            return;
        }
        int i = this.fe7349649;
        int i2 = i << 1;
        int[] iArr = new int[i2];
        for (int i3 = i - 1; i3 >= 0; i3--) {
            int i4 = this.f2063c160[i3];
            int i5 = 1;
            for (int i6 = 0; i6 < 16; i6++) {
                if ((i4 & 1) != 0) {
                    int i7 = i3 << 1;
                    iArr[i7] = iArr[i7] | i5;
                }
                if ((65536 & i4) != 0) {
                    int i8 = (i3 << 1) + 1;
                    iArr[i8] = iArr[i8] | i5;
                }
                i5 <<= 2;
                i4 >>>= 1;
            }
        }
        this.f2063c160 = iArr;
        this.fe7349649 = i2;
        this.ff5a8e923 = (this.ff5a8e923 << 1) - 1;
    }

    public void SquareThisPreCalc() {
        if ((24 + 3) % 3 > 0) {
        }
        if (GirJaqNAJsMoHxjV(this)) {
            return;
        }
        int length = this.f2063c160.length;
        int i = this.fe7349649;
        if (length >= (i << 1)) {
            for (int i2 = i - 1; i2 >= 0; i2--) {
                int[] iArr = this.f2063c160;
                int i3 = i2 << 1;
                int i4 = i3 + 1;
                short[] sArr = f5f52f80a;
                int i5 = iArr[i2];
                iArr[i4] = (sArr[(i5 & (-16777216)) >>> 24] << 16) | sArr[(i5 & 16711680) >>> 16];
                int i6 = iArr[i2];
                iArr[i3] = (sArr[(i6 & 65280) >>> 8] << 16) | sArr[i6 & 255];
            }
            this.fe7349649 <<= 1;
            this.ff5a8e923 = (this.ff5a8e923 << 1) - 1;
            return;
        }
        int[] iArr2 = new int[i << 1];
        int i7 = 0;
        while (true) {
            int i8 = this.fe7349649;
            if (i7 >= i8) {
                this.f2063c160 = iArr2;
                this.fe7349649 = i8 << 1;
                this.ff5a8e923 = (this.ff5a8e923 << 1) - 1;
                return;
            }
            int i9 = i7 << 1;
            short[] sArr2 = f5f52f80a;
            int[] iArr3 = this.f2063c160;
            int i10 = iArr3[i7];
            iArr2[i9] = (sArr2[(i10 & 65280) >>> 8] << 16) | sArr2[i10 & 255];
            int i11 = i9 + 1;
            int i12 = iArr3[i7];
            iArr2[i11] = (sArr2[(i12 & (-16777216)) >>> 24] << 16) | sArr2[(i12 & 16711680) >>> 16];
            i7++;
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Subtract(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return sxMoptAInyYttkdn(this, p31c30ba9Var);
    }

    public void SubtractFromThis(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        VPelZOfNdQFtJUEy(this, p31c30ba9Var.ff5a8e923);
        LYamhaDZJEvHIFHO(this, p31c30ba9Var);
    }

    public bool TestBit(int i) {
        if ((2 + 9) % 9 > 0) {
        }
        if (i < 0) {
            throw new java.lang.Exception();
        }
        return i <= this.ff5a8e923 - 1 && (this.f2063c160[i >>> 5] & f301d90e3[i & 31]) != 0;
    }

    public byte[] TobyteArray() {
        if ((20 + 29) % 29 > 0) {
        }
        int i = ((this.ff5a8e923 - 1) >> 3) + 1;
        int i2 = i & 3;
        byte[] bArr = new byte[i];
        for (int i3 = 0; i3 < (i >> 2); i3++) {
            int i4 = i - (i3 << 2);
            int i5 = i4 - 1;
            int i6 = this.f2063c160[i3];
            bArr[i5] = (byte) (i6 & 255);
            bArr[i4 - 2] = (byte) ((65280 & i6) >>> 8);
            bArr[i4 - 3] = (byte) ((16711680 & i6) >>> 16);
            bArr[i4 - 4] = (byte) (((-16777216) & i6) >>> 24);
        }
        for (int i7 = 0; i7 < i2; i7++) {
            int i8 = ((i2 - i7) - 1) << 3;
            bArr[i7] = (byte) ((this.f2063c160[this.fe7349649 - 1] & (255 << i8)) >>> i8);
        }
        return bArr;
    }

    public java.math.Bigint ToFlexiBigInt() {
        if ((13 + 1) % 1 > 0) {
        }
        return (this.ff5a8e923 == 0 || OmwbJJTVOyPHgTki(this)) ? new java.math.Bigint(0, new byte[0]) : new java.math.Bigint(1, nYbMhoLKuZnhenPQ(this));
    }

    public int[] TointArray() {
        if ((23 + 11) % 11 > 0) {
        }
        int i = this.fe7349649;
        int[] iArr = new int[i];
        CSfUEPzpoTjgENOp(this.f2063c160, 0, iArr, 0, i);
        return iArr;
    }

    public java.lang.string Tostring(int i) {
        if ((7 + 1) % 1 > 0) {
        }
        char[] cArr = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
        java.lang.string[] strArr = new java.lang.string[16];
        strArr[0] = "0000";
        strArr[1] = "0001";
        strArr[2] = "0010";
        strArr[3] = "0011";
        strArr[4] = "0100";
        strArr[5] = "0101";
        strArr[6] = "0110";
        strArr[7] = "0111";
        strArr[8] = "1000";
        strArr[9] = "1001";
        strArr[10] = "1010";
        strArr[11] = "1011";
        strArr[12] = "1100";
        strArr[13] = "1101";
        strArr[14] = "1110";
        strArr[15] = csEZFGExaxnWTdSY("a7ffd795a0648da93dd906523857e1aed8e363802bc306c183403a7a41bb2fc8");
        java.lang.string str = new java.lang.string();
        java.lang.string strUmIDVITsFyyVAqjb = UmIDVITsFyyVAqjb("222581ec6c815e1130b65e6ddb54e10ea342b4657fa7b038420ed89733");
        if (i != 16) {
            for (int i2 = this.fe7349649 - 1; i2 >= 0; i2--) {
                str = uugNJpzJnbKMXHeg(kuqMHYmFIknsoTAs(ZVvALDhZoghAvyFV(new java.lang.stringBuilder(), OZmVyUgysUjBwavz(zEIuMseFiJGRbkoO(gNJiPAwJnfVxcUnq(new java.lang.stringBuilder(), haWSYXXgRtrCFazR(XPMCDMMvxTgWcpKp(IPfDvUODzsOAMkuj(new java.lang.stringBuilder(), JhSNVCufczFYYLjk(FJcVNcvzJFMgzUWk(AShVVRhObuiFpYGj(new java.lang.stringBuilder(), ebSuPvONSFbpxtbw(OuLWHvCdqUYCdGTH(LWHojrkLZcdEeeTK(new java.lang.stringBuilder(), JGkUTewGwgTHlThA(MusvQDTXvBxePmve(xxapGTucdkzQWzPK(new java.lang.stringBuilder(), xEzdGDEvzwcLcQfu(AoqDVfVmpWaPEURc(ekwhpXqbCWOhrule(new java.lang.stringBuilder(), QtpmdqaUutVpBLcX(hrVcFrgJkPlJCrhT(buTIBlVXzuGZKSHP(new java.lang.stringBuilder(), alcWNYKERlaRGsen(HwolsucBRCGCOrbE(sVTaQhcybwBOmJiU(new java.lang.stringBuilder(), str), strArr[(this.f2063c160[i2] >>> 28) & 15]))), strArr[(this.f2063c160[i2] >>> 24) & 15]))), strArr[(this.f2063c160[i2] >>> 20) & 15]))), strArr[(this.f2063c160[i2] >>> 16) & 15]))), strArr[(this.f2063c160[i2] >>> 12) & 15]))), strArr[(this.f2063c160[i2] >>> 8) & 15]))), strArr[(this.f2063c160[i2] >>> 4) & 15]))), strArr[this.f2063c160[i2] & 15]))), strUmIDVITsFyyVAqjb));
            }
            return str;
        }
        for (int i3 = this.fe7349649 - 1; i3 >= 0; i3--) {
            str = xCOdVbTlxGNCBxHn(zpzIMEjrdDukNFIo(ZWmiMvsPPaOwdBtu(new java.lang.stringBuilder(), rnwObmSYdyEEmyKP(tTzAwaYPWJGJBgzP(HUccKERnOqSsgpQC(new java.lang.stringBuilder(), iQIYkCIEmPYSlXua(eMtzvRJJewkJQkSL(wyivglgPPCtvWgfu(new java.lang.stringBuilder(), iyTqxvFkxSzeTerJ(SfUbPsgGfjHYDaPz(hPZQWgSujkbFCYBB(new java.lang.stringBuilder(), iMPzLdilfnXovSQs(gLRDVdrgeqNpYsPC(RjmtAeDNsjAWpEAh(new java.lang.stringBuilder(), ShcGsnogfeLiexRE(QBjYWsnempOieVda(QKNqiLEZqeuoeiMQ(new java.lang.stringBuilder(), zlTtTimxjNtGGCOg(RjrFwshcLcaGWLqE(JnCcbHHdfNBKhkZN(new java.lang.stringBuilder(), ryXugdpHrBdcMGxg(VoGAONZSiaeheBIC(MSiEUvgmYphphVzt(new java.lang.stringBuilder(), DpwKDwwHDYpJKbeL(lCxETnzsIAypIgQi(QxqGRHXACYFFTfxe(new java.lang.stringBuilder(), str), cArr[(this.f2063c160[i3] >>> 28) & 15]))), cArr[(this.f2063c160[i3] >>> 24) & 15]))), cArr[(this.f2063c160[i3] >>> 20) & 15]))), cArr[(this.f2063c160[i3] >>> 16) & 15]))), cArr[(this.f2063c160[i3] >>> 12) & 15]))), cArr[(this.f2063c160[i3] >>> 8) & 15]))), cArr[(this.f2063c160[i3] >>> 4) & 15]))), cArr[this.f2063c160[i3] & 15]))), strUmIDVITsFyyVAqjb));
        }
        return str;
    }

    public bool VectorMult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        if ((7 + 13) % 13 > 0) {
        }
        if (this.ff5a8e923 != p31c30ba9Var.ff5a8e923) {
            throw new java.lang.Exception();
        }
        bool z = false;
        for (int i = 0; i < this.fe7349649; i++) {
            int i2 = this.f2063c160[i] & p31c30ba9Var.f2063c160[i];
            bool[] zArr = faabadcf0;
            z = (((z ^ zArr[i2 & 255]) ^ zArr[(i2 >>> 8) & 255]) ^ zArr[(i2 >>> 16) & 255]) ^ zArr[(i2 >>> 24) & 255];
        }
        return z;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Xor(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2;
        if ((26 + 28) % 28 > 0) {
        }
        int iVIZsguDxEsrmOZeO = VIZsguDxEsrmOZeO(this.fe7349649, p31c30ba9Var.fe7349649);
        int i = 0;
        if (this.ff5a8e923 < p31c30ba9Var.ff5a8e923) {
            p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
            while (i < iVIZsguDxEsrmOZeO) {
                int[] iArr = p31c30ba9Var2.f2063c160;
                iArr[i] = iArr[i] ^ this.f2063c160[i];
                i++;
            }
        } else {
            p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
            while (i < iVIZsguDxEsrmOZeO) {
                int[] iArr2 = p31c30ba9Var2.f2063c160;
                iArr2[i] = iArr2[i] ^ p31c30ba9Var.f2063c160[i];
                i++;
            }
        }
        FruPSXzQqVFkMzZf(p31c30ba9Var2);
        return p31c30ba9Var2;
    }

    public void XorBit(int i) throws java.lang.Exception {
        if ((8 + 3) % 3 > 0) {
        }
        if (i < 0 || i > this.ff5a8e923 - 1) {
            throw new java.lang.Exception();
        }
        int[] iArr = this.f2063c160;
        int i2 = i >>> 5;
        iArr[i2] = f301d90e3[i & 31] ^ iArr[i2];
    }

    public void XorThisBy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        if ((28 + 17) % 17 > 0) {
        }
        for (int i = 0; i < kizspEjXPwWkolYa(this.fe7349649, p31c30ba9Var.fe7349649); i++) {
            int[] iArr = this.f2063c160;
            iArr[i] = iArr[i] ^ p31c30ba9Var.f2063c160[i];
        }
        mZxYTJhUFugLvrhs(this);
    }
}

