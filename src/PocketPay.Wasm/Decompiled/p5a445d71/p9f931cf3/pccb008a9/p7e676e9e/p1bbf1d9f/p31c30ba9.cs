namespace WillowMaze.Wasm.Decompiled;


public class p31c30ba9 {
    private static readonly short[] f10605318 = null;
    private static java.util.Random f18beb2df;
    private static readonly int[] f301d90e3;
    private static readonly bool[] f31832fc5 = null;
    private static java.util.Random f34d1c350;
    private static readonly short[] f5c656c05 = null;
    private static readonly short[] f5f52f80a;
    private static readonly int[] f614920b6 = null;
    private static readonly int[] f67aa1ba7 = null;
    private static readonly bool[] f75b49248 = null;
    private static readonly short[] f79b4dd58 = null;
    private static readonly int[] f84ff8088 = null;
    private static java.util.Random f8afe5737;
    private static java.util.Random f8d8176e7;
    private static readonly int[] fa0e4e76a;
    private static readonly bool[] faabadcf0;
    private static readonly bool[] fb5be88f3 = null;
    private static readonly int[] fbe1a19a9 = null;
    private static readonly int[] fc511a82b = null;
    private static readonly bool[] fcc9329b1 = null;
    private static java.util.Random fdc27f801;
    private static readonly int[] fe6636b72 = null;
    private static readonly short[] fe90370cb = null;
    private static readonly int[] ff1912249 = null;
    private int[] f05328026;
    private int[] f2063c160;
    private int f2310ef46;
    private int[] f23ba3f98;
    private int[] f2d0db341;
    private int f42d4c8f6;
    private int[] f813619da;
    private int fe5b3aefa;
    private int fe7349649;
    private int ff5a8e923;

    static {
        if ((4 + 14) % 14 > 0) {
        }
        f34d1c350 = new java.util.Random();
        faabadcf0 = new bool[]{false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false, false, true, true, false, true, false, false, true, false, true, true, false, true, false, false, true, true, false, false, true, false, true, true, false};
        f5f52f80a = new short[]{0, 1, 4, 5, 16, 17, 20, 21, 64, 65, 68, 69, 80, 81, 84, 85, 256, 257, 260, 261, 272, 273, 276, 277, 320, 321, 324, 325, 336, 337, 340, 341, 1024, 1025, 1028, 1029, 1040, 1041, 1044, 1045, 1088, 1089, 1092, 1093, 1104, 1105, 1108, 1109, 1280, 1281, 1284, 1285, 1296, 1297, 1300, 1301, 1344, 1345, 1348, 1349, 1360, 1361, 1364, 1365, 4096, 4097, 4100, 4101, 4112, 4113, 4116, 4117, 4160, 4161, 4164, 4165, 4176, 4177, 4180, 4181, 4352, 4353, 4356, 4357, 4368, 4369, 4372, 4373, 4416, 4417, 4420, 4421, 4432, 4433, 4436, 4437, 5120, 5121, 5124, 5125, 5136, 5137, 5140, 5141, 5184, 5185, 5188, 5189, 5200, 5201, 5204, 5205, 5376, 5377, 5380, 5381, 5392, 5393, 5396, 5397, 5440, 5441, 5444, 5445, 5456, 5457, 5460, 5461, 16384, 16385, 16388, 16389, 16400, 16401, 16404, 16405, 16448, 16449, 16452, 16453, 16464, 16465, 16468, 16469, 16640, 16641, 16644, 16645, 16656, 16657, 16660, 16661, 16704, 16705, 16708, 16709, 16720, 16721, 16724, 16725, 17408, 17409, 17412, 17413, 17424, 17425, 17428, 17429, 17472, 17473, 17476, 17477, 17488, 17489, 17492, 17493, 17664, 17665, 17668, 17669, 17680, 17681, 17684, 17685, 17728, 17729, 17732, 17733, 17744, 17745, 17748, 17749, 20480, 20481, 20484, 20485, 20496, 20497, 20500, 20501, 20544, 20545, 20548, 20549, 20560, 20561, 20564, 20565, 20736, 20737, 20740, 20741, 20752, 20753, 20756, 20757, 20800, 20801, 20804, 20805, 20816, 20817, 20820, 20821, 21504, 21505, 21508, 21509, 21520, 21521, 21524, 21525, 21568, 21569, 21572, 21573, 21584, 21585, 21588, 21589, 21760, 21761, 21764, 21765, 21776, 21777, 21780, 21781, 21824, 21825, 21828, 21829, 21840, 21841, 21844, 21845};
        f301d90e3 = new int[]{1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824, int.MIN_VALUE, 0};
        fa0e4e76a = new int[]{0, 1, 3, 7, 15, 31, 63, 127, 255, 511, 1023, 2047, 4095, 8191, 16383, 32767, 65535, 131071, 262143, 524287, 1048575, 2097151, 4194303, 8388607, 16777215, 33554431, 67108863, 134217727, 268435455, 536870911, 1073741823, int.MAX_VALUE, -1};
    }

    public p31c30ba9(int i) {
        if ((29 + 1) % 1 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i2 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i2;
        this.f2063c160 = new int[i2];
        this.ff5a8e923 = i;
    }

    public p31c30ba9(int i, java.lang.string str) {
        if ((1 + 31) % 31 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i2 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i2;
        this.f2063c160 = new int[i2];
        this.ff5a8e923 = i;
        if (str.equalsIgnoreCase("ZERO")) {
            assignZero();
            return;
        }
        if (str.equalsIgnoreCase("ONE")) {
            assignOne();
            return;
        }
        if (str.equalsIgnoreCase("RANDOM")) {
            randomize();
        } else if (str.equalsIgnoreCase(com.decryptstringmanager.Decryptstring.decryptstring("bdc693dff4afd863da2024a6a7d371e7d2787822664bd7b28970a4f065"))) {
            assignX();
        } else {
            if (!str.equalsIgnoreCase("ALL")) {
                throw new java.lang.IllegalArgumentException("Error: GF2Polynomial was called using " + str + " as value!");
            }
            assignAll();
        }
    }

    public p31c30ba9(int i, java.math.Bigint bigint) {
        if ((28 + 29) % 29 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i2 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i2;
        this.f2063c160 = new int[i2];
        this.ff5a8e923 = i;
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray[0] == 0) {
            int length = byteArray.length - 1;
            byte[] bArr = new byte[length];
            java.lang.System.arraycopy(byteArray, 1, bArr, 0, length);
            byteArray = bArr;
        }
        int length2 = byteArray.length & 3;
        int length3 = (byteArray.length - 1) >> 2;
        for (int i3 = 0; i3 < length2; i3++) {
            int[] iArr = this.f2063c160;
            iArr[length3] = iArr[length3] | ((byteArray[i3] & 255) << (((length2 - 1) - i3) << 3));
        }
        for (int i4 = 0; i4 <= ((byteArray.length - 4) >> 2); i4++) {
            int length4 = (byteArray.length - 1) - (i4 << 2);
            int[] iArr2 = this.f2063c160;
            int i5 = byteArray[length4] & 255;
            iArr2[i4] = i5;
            int i6 = i5 | ((byteArray[length4 - 1] << 8) & 65280);
            iArr2[i4] = i6;
            int i7 = i6 | ((byteArray[length4 - 2] << 16) & 16711680);
            iArr2[i4] = i7;
            iArr2[i4] = ((byteArray[length4 - 3] << 24) & (-16777216)) | i7;
        }
        int i8 = this.ff5a8e923;
        if ((i8 & 31) != 0) {
            int[] iArr3 = this.f2063c160;
            int i9 = this.fe7349649 - 1;
            iArr3[i9] = fa0e4e76a[i8 & 31] & iArr3[i9];
        }
        reduceN();
    }

    public p31c30ba9(int i, java.util.Random random) {
        if ((31 + 8) % 8 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i2 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i2;
        this.f2063c160 = new int[i2];
        this.ff5a8e923 = i;
        randomize(random);
    }

    public p31c30ba9(int i, byte[] bArr) {
        int i2;
        if ((2 + 10) % 10 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i3 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i3;
        this.f2063c160 = new int[i3];
        this.ff5a8e923 = i;
        int iMin = java.lang.Math.min(((bArr.length - 1) >> 2) + 1, i3);
        int i4 = 0;
        while (true) {
            i2 = iMin - 1;
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
        m604595a9();
        reduceN();
    }

    public p31c30ba9(int i, int[] iArr) {
        if ((29 + 6) % 6 > 0) {
        }
        i = i < 1 ? 1 : i;
        int i2 = ((i - 1) >> 5) + 1;
        this.fe7349649 = i2;
        this.f2063c160 = new int[i2];
        this.ff5a8e923 = i;
        java.lang.System.arraycopy(iArr, 0, this.f2063c160, 0, java.lang.Math.min(i2, iArr.length));
        m604595a9();
    }

    public p31c30ba9(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        this.ff5a8e923 = p31c30ba9Var.ff5a8e923;
        this.fe7349649 = p31c30ba9Var.fe7349649;
        this.f2063c160 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(p31c30ba9Var.f2063c160);
    }

    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 M0122b4c2(int i) {
        if ((16 + 1) % 1 > 0) {
        }
        int iMin = java.lang.Math.min(i, this.fe7349649 - i);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(iMin << 5);
        if (this.fe7349649 >= i) {
            java.lang.System.arraycopy(this.f2063c160, i, p31c30ba9Var.f2063c160, 0, iMin);
        }
        return p31c30ba9Var;
    }

    private void M1e048a41(int i) {
        if ((4 + 19) % 19 > 0) {
        }
        int i2 = this.fe7349649;
        int[] iArr = this.f2063c160;
        if (i2 > iArr.length) {
            int[] iArr2 = new int[i2];
            java.lang.System.arraycopy(iArr, 0, iArr2, i, i2 - i);
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
        if ((9 + 15) % 15 > 0) {
        }
        int[] iArr3 = new int[16];
        int[] iArr4 = new int[4];
        java.lang.System.arraycopy(iArr, 0, iArr4, 0, java.lang.Math.min(4, iArr.length));
        int[] iArr5 = new int[4];
        if (iArr.length > 4) {
            java.lang.System.arraycopy(iArr, 4, iArr5, 0, java.lang.Math.min(4, iArr.length - 4));
        }
        int[] iArr6 = new int[4];
        java.lang.System.arraycopy(iArr2, 0, iArr6, 0, java.lang.Math.min(4, iArr2.length));
        int[] iArr7 = new int[4];
        if (iArr2.length > 4) {
            java.lang.System.arraycopy(iArr2, 4, iArr7, 0, java.lang.Math.min(4, iArr2.length - 4));
        }
        if (iArr5[3] != 0 || iArr5[2] != 0 || iArr7[3] != 0 || iArr7[2] != 0) {
            c = 3;
            int[] iArrM5d7001a8 = m5d7001a8(iArr5, iArr7);
            int i = iArr3[15];
            int i2 = iArrM5d7001a8[7];
            iArr3[15] = i ^ i2;
            int i3 = iArr3[14];
            int i4 = iArrM5d7001a8[6];
            iArr3[14] = i3 ^ i4;
            int i5 = iArr3[13];
            int i6 = iArrM5d7001a8[5];
            iArr3[13] = i5 ^ i6;
            int i7 = iArr3[12];
            int i8 = iArrM5d7001a8[4];
            iArr3[12] = i7 ^ i8;
            int i9 = iArr3[11];
            int i10 = iArrM5d7001a8[3];
            iArr3[11] = i9 ^ (i10 ^ i2);
            int i11 = iArr3[10];
            int i12 = iArrM5d7001a8[2];
            iArr3[10] = i11 ^ (i12 ^ i4);
            int i13 = iArr3[9];
            int i14 = iArrM5d7001a8[1];
            iArr3[9] = i13 ^ (i14 ^ i6);
            int i15 = iArr3[8];
            int i16 = iArrM5d7001a8[0];
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
                int[] iArrM95dc2b7a = m95dc2b7a(i17, iArr7[0]);
                int i18 = iArr3[9];
                int i19 = iArrM95dc2b7a[1];
                iArr3[9] = i18 ^ i19;
                int i20 = iArr3[8];
                int i21 = iArrM95dc2b7a[0];
                iArr3[8] = i20 ^ i21;
                iArr3[5] = iArr3[5] ^ i19;
                iArr3[4] = i21 ^ iArr3[4];
            }
        } else {
            c = 3;
            int[] iArrM9d4b8699 = m9d4b8699(iArr5, iArr7);
            int i22 = iArr3[11];
            int i23 = iArrM9d4b8699[3];
            iArr3[11] = i22 ^ i23;
            int i24 = iArr3[10];
            int i25 = iArrM9d4b8699[2];
            iArr3[10] = i24 ^ i25;
            int i26 = iArr3[9];
            int i27 = iArrM9d4b8699[1];
            iArr3[9] = i26 ^ i27;
            int i28 = iArr3[8];
            int i29 = iArrM9d4b8699[0];
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
        int[] iArrM5d7001a82 = m5d7001a8(iArr5, iArr7);
        iArr3[11] = iArr3[11] ^ iArrM5d7001a82[7];
        iArr3[10] = iArr3[10] ^ iArrM5d7001a82[6];
        iArr3[9] = iArr3[9] ^ iArrM5d7001a82[5];
        iArr3[8] = iArr3[8] ^ iArrM5d7001a82[4];
        iArr3[7] = iArr3[7] ^ iArrM5d7001a82[c];
        iArr3[6] = iArr3[6] ^ iArrM5d7001a82[2];
        iArr3[5] = iArr3[5] ^ iArrM5d7001a82[1];
        iArr3[4] = iArrM5d7001a82[0] ^ iArr3[4];
        int[] iArrM5d7001a83 = m5d7001a8(iArr4, iArr6);
        int i30 = iArr3[11];
        int i31 = iArrM5d7001a83[7];
        iArr3[11] = i30 ^ i31;
        int i32 = iArr3[10];
        int i33 = iArrM5d7001a83[6];
        iArr3[10] = i32 ^ i33;
        int i34 = iArr3[9];
        int i35 = iArrM5d7001a83[5];
        iArr3[9] = i34 ^ i35;
        int i36 = iArr3[8];
        int i37 = iArrM5d7001a83[4];
        iArr3[8] = i36 ^ i37;
        int i38 = iArr3[7];
        int i39 = iArrM5d7001a83[c];
        iArr3[7] = i38 ^ (i31 ^ i39);
        int i40 = iArr3[6];
        int i41 = iArrM5d7001a83[2];
        iArr3[6] = i40 ^ (i33 ^ i41);
        int i42 = iArr3[5];
        int i43 = iArrM5d7001a83[1];
        iArr3[5] = i42 ^ (i35 ^ i43);
        int i44 = iArr3[4];
        int i45 = iArrM5d7001a83[0];
        iArr3[4] = i44 ^ (i45 ^ i37);
        iArr3[c] = iArr3[c] ^ i39;
        iArr3[2] = iArr3[2] ^ i41;
        iArr3[1] = iArr3[1] ^ i43;
        iArr3[0] = i45 ^ iArr3[0];
        return iArr3;
    }

    private static int[] M2bb3e9f2(int[] iArr, int[] iArr2) {
        if ((1 + 11) % 11 > 0) {
        }
        int[] iArr3 = new int[32];
        int[] iArr4 = new int[8];
        java.lang.System.arraycopy(iArr, 0, iArr4, 0, java.lang.Math.min(8, iArr.length));
        int[] iArr5 = new int[8];
        if (iArr.length > 8) {
            java.lang.System.arraycopy(iArr, 8, iArr5, 0, java.lang.Math.min(8, iArr.length - 8));
        }
        int[] iArr6 = new int[8];
        java.lang.System.arraycopy(iArr2, 0, iArr6, 0, java.lang.Math.min(8, iArr2.length));
        int[] iArr7 = new int[8];
        if (iArr2.length > 8) {
            java.lang.System.arraycopy(iArr2, 8, iArr7, 0, java.lang.Math.min(8, iArr2.length - 8));
        }
        int[] iArrM24b9c245 = m24b9c245(iArr5, iArr7);
        int i = iArr3[31];
        int i2 = iArrM24b9c245[15];
        iArr3[31] = i ^ i2;
        int i3 = iArr3[30];
        int i4 = iArrM24b9c245[14];
        iArr3[30] = i3 ^ i4;
        int i5 = iArr3[29];
        int i6 = iArrM24b9c245[13];
        iArr3[29] = i5 ^ i6;
        int i7 = iArr3[28];
        int i8 = iArrM24b9c245[12];
        iArr3[28] = i7 ^ i8;
        int i9 = iArr3[27];
        int i10 = iArrM24b9c245[11];
        iArr3[27] = i9 ^ i10;
        int i11 = iArr3[26];
        int i12 = iArrM24b9c245[10];
        iArr3[26] = i11 ^ i12;
        int i13 = iArr3[25];
        int i14 = iArrM24b9c245[9];
        iArr3[25] = i13 ^ i14;
        int i15 = iArr3[24];
        int i16 = iArrM24b9c245[8];
        iArr3[24] = i15 ^ i16;
        int i17 = iArr3[23];
        int i18 = iArrM24b9c245[7];
        iArr3[23] = i17 ^ (i18 ^ i2);
        int i19 = iArr3[22];
        int i20 = iArrM24b9c245[6];
        iArr3[22] = i19 ^ (i20 ^ i4);
        int i21 = iArr3[21];
        int i22 = iArrM24b9c245[5];
        iArr3[21] = i21 ^ (i22 ^ i6);
        int i23 = iArr3[20];
        int i24 = iArrM24b9c245[4];
        iArr3[20] = i23 ^ (i24 ^ i8);
        int i25 = iArr3[19];
        int i26 = iArrM24b9c245[3];
        iArr3[19] = i25 ^ (i26 ^ i10);
        int i27 = iArr3[18];
        int i28 = iArrM24b9c245[2];
        iArr3[18] = i27 ^ (i28 ^ i12);
        int i29 = iArr3[17];
        int i30 = iArrM24b9c245[1];
        iArr3[17] = i29 ^ (i30 ^ i14);
        int i31 = iArr3[16];
        int i32 = iArrM24b9c245[0];
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
        int[] iArrM24b9c2452 = m24b9c245(iArr5, iArr7);
        iArr3[23] = iArr3[23] ^ iArrM24b9c2452[15];
        iArr3[22] = iArr3[22] ^ iArrM24b9c2452[14];
        iArr3[21] = iArr3[21] ^ iArrM24b9c2452[13];
        iArr3[20] = iArr3[20] ^ iArrM24b9c2452[12];
        iArr3[19] = iArr3[19] ^ iArrM24b9c2452[11];
        iArr3[18] = iArr3[18] ^ iArrM24b9c2452[10];
        iArr3[17] = iArr3[17] ^ iArrM24b9c2452[9];
        iArr3[16] = iArr3[16] ^ iArrM24b9c2452[8];
        iArr3[15] = iArr3[15] ^ iArrM24b9c2452[7];
        iArr3[14] = iArr3[14] ^ iArrM24b9c2452[6];
        iArr3[13] = iArr3[13] ^ iArrM24b9c2452[5];
        iArr3[12] = iArr3[12] ^ iArrM24b9c2452[4];
        iArr3[11] = iArr3[11] ^ iArrM24b9c2452[3];
        iArr3[10] = iArr3[10] ^ iArrM24b9c2452[2];
        iArr3[9] = iArr3[9] ^ iArrM24b9c2452[1];
        iArr3[8] = iArrM24b9c2452[0] ^ iArr3[8];
        int[] iArrM24b9c2453 = m24b9c245(iArr4, iArr6);
        int i33 = iArr3[23];
        int i34 = iArrM24b9c2453[15];
        iArr3[23] = i33 ^ i34;
        int i35 = iArr3[22];
        int i36 = iArrM24b9c2453[14];
        iArr3[22] = i35 ^ i36;
        int i37 = iArr3[21];
        int i38 = iArrM24b9c2453[13];
        iArr3[21] = i37 ^ i38;
        int i39 = iArr3[20];
        int i40 = iArrM24b9c2453[12];
        iArr3[20] = i39 ^ i40;
        int i41 = iArr3[19];
        int i42 = iArrM24b9c2453[11];
        iArr3[19] = i41 ^ i42;
        int i43 = iArr3[18];
        int i44 = iArrM24b9c2453[10];
        iArr3[18] = i43 ^ i44;
        int i45 = iArr3[17];
        int i46 = iArrM24b9c2453[9];
        iArr3[17] = i45 ^ i46;
        int i47 = iArr3[16];
        int i48 = iArrM24b9c2453[8];
        iArr3[16] = i47 ^ i48;
        int i49 = iArr3[15];
        int i50 = iArrM24b9c2453[7];
        iArr3[15] = i49 ^ (i34 ^ i50);
        int i51 = iArr3[14];
        int i52 = iArrM24b9c2453[6];
        iArr3[14] = i51 ^ (i36 ^ i52);
        int i53 = iArr3[13];
        int i54 = iArrM24b9c2453[5];
        iArr3[13] = i53 ^ (i38 ^ i54);
        int i55 = iArr3[12];
        int i56 = iArrM24b9c2453[4];
        iArr3[12] = i55 ^ (i40 ^ i56);
        int i57 = iArr3[11];
        int i58 = iArrM24b9c2453[3];
        iArr3[11] = i57 ^ (i42 ^ i58);
        int i59 = iArr3[10];
        int i60 = iArrM24b9c2453[2];
        iArr3[10] = i59 ^ (i60 ^ i44);
        int i61 = iArr3[9];
        int i62 = iArrM24b9c2453[1];
        iArr3[9] = i61 ^ (i62 ^ i46);
        int i63 = iArr3[8];
        int i64 = iArrM24b9c2453[0];
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
        if ((16 + 22) % 22 > 0) {
        }
        int[] iArr3 = new int[8];
        int[] iArr4 = new int[2];
        java.lang.System.arraycopy(iArr, 0, iArr4, 0, java.lang.Math.min(2, iArr.length));
        int[] iArr5 = new int[2];
        if (iArr.length > 2) {
            java.lang.System.arraycopy(iArr, 2, iArr5, 0, java.lang.Math.min(2, iArr.length - 2));
        }
        int[] iArr6 = new int[2];
        java.lang.System.arraycopy(iArr2, 0, iArr6, 0, java.lang.Math.min(2, iArr2.length));
        int[] iArr7 = new int[2];
        if (iArr2.length > 2) {
            java.lang.System.arraycopy(iArr2, 2, iArr7, 0, java.lang.Math.min(2, iArr2.length - 2));
        }
        if (iArr5[1] == 0 && iArr7[1] == 0) {
            int i = iArr5[0];
            if (i != 0 || iArr7[0] != 0) {
                int[] iArrM95dc2b7a = m95dc2b7a(i, iArr7[0]);
                int i2 = iArr3[5];
                int i3 = iArrM95dc2b7a[1];
                iArr3[5] = i2 ^ i3;
                int i4 = iArr3[4];
                int i5 = iArrM95dc2b7a[0];
                iArr3[4] = i4 ^ i5;
                iArr3[3] = iArr3[3] ^ i3;
                iArr3[2] = i5 ^ iArr3[2];
            }
        } else {
            int[] iArrM9d4b8699 = m9d4b8699(iArr5, iArr7);
            int i6 = iArr3[7];
            int i7 = iArrM9d4b8699[3];
            iArr3[7] = i6 ^ i7;
            int i8 = iArr3[6];
            int i9 = iArrM9d4b8699[2];
            iArr3[6] = i8 ^ i9;
            int i10 = iArr3[5];
            int i11 = iArrM9d4b8699[1];
            iArr3[5] = i10 ^ (i7 ^ i11);
            int i12 = iArr3[4];
            int i13 = iArrM9d4b8699[0];
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
            int[] iArrM95dc2b7a2 = m95dc2b7a(iArr5[0], i14);
            iArr3[3] = iArr3[3] ^ iArrM95dc2b7a2[1];
            iArr3[2] = iArrM95dc2b7a2[0] ^ iArr3[2];
        } else {
            int[] iArrM9d4b86992 = m9d4b8699(iArr5, iArr7);
            iArr3[5] = iArr3[5] ^ iArrM9d4b86992[3];
            iArr3[4] = iArr3[4] ^ iArrM9d4b86992[2];
            iArr3[3] = iArr3[3] ^ iArrM9d4b86992[1];
            iArr3[2] = iArrM9d4b86992[0] ^ iArr3[2];
        }
        if (iArr4[1] == 0 && iArr6[1] == 0) {
            int[] iArrM95dc2b7a3 = m95dc2b7a(iArr4[0], iArr6[0]);
            int i16 = iArr3[3];
            int i17 = iArrM95dc2b7a3[1];
            iArr3[3] = i16 ^ i17;
            int i18 = iArr3[2];
            int i19 = iArrM95dc2b7a3[0];
            iArr3[2] = i18 ^ i19;
            iArr3[1] = iArr3[1] ^ i17;
            iArr3[0] = i19 ^ iArr3[0];
            return iArr3;
        }
        int[] iArrM9d4b86993 = m9d4b8699(iArr4, iArr6);
        int i20 = iArr3[5];
        int i21 = iArrM9d4b86993[3];
        iArr3[5] = i20 ^ i21;
        int i22 = iArr3[4];
        int i23 = iArrM9d4b86993[2];
        iArr3[4] = i22 ^ i23;
        int i24 = iArr3[3];
        int i25 = iArrM9d4b86993[1];
        iArr3[3] = i24 ^ (i21 ^ i25);
        int i26 = iArr3[2];
        int i27 = iArrM9d4b86993[0];
        iArr3[2] = i26 ^ (i27 ^ i23);
        iArr3[1] = iArr3[1] ^ i25;
        iArr3[0] = i27 ^ iArr3[0];
        return iArr3;
    }

    private void M604595a9() {
        if ((16 + 3) % 3 > 0) {
        }
        int i = this.ff5a8e923;
        if ((i & 31) == 0) {
            return;
        }
        int[] iArr = this.f2063c160;
        int i2 = this.fe7349649 - 1;
        iArr[i2] = fa0e4e76a[i & 31] & iArr[i2];
    }

    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 M81e073b4(int i) {
        if ((27 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(i << 5);
        java.lang.System.arraycopy(this.f2063c160, 0, p31c30ba9Var.f2063c160, 0, java.lang.Math.min(i, this.fe7349649));
        return p31c30ba9Var;
    }

    private static int[] M95dc2b7a(int i, int i2) {
        if ((31 + 19) % 19 > 0) {
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
        if ((30 + 18) % 18 > 0) {
        }
        int[] iArr3 = new int[4];
        int i = iArr[0];
        int i2 = iArr.length <= 1 ? 0 : iArr[1];
        int i3 = iArr2[0];
        int i4 = iArr2.length <= 1 ? 0 : iArr2[1];
        if (i2 != 0 || i4 != 0) {
            int[] iArrM95dc2b7a = m95dc2b7a(i2, i4);
            int i5 = iArr3[3];
            int i6 = iArrM95dc2b7a[1];
            iArr3[3] = i5 ^ i6;
            int i7 = iArr3[2];
            int i8 = iArrM95dc2b7a[0];
            iArr3[2] = i7 ^ (i8 ^ i6);
            iArr3[1] = i8 ^ iArr3[1];
        }
        int[] iArrM95dc2b7a2 = m95dc2b7a(i2 ^ i, i4 ^ i3);
        iArr3[2] = iArr3[2] ^ iArrM95dc2b7a2[1];
        iArr3[1] = iArrM95dc2b7a2[0] ^ iArr3[1];
        int[] iArrM95dc2b7a3 = m95dc2b7a(i, i3);
        int i9 = iArr3[2];
        int i10 = iArrM95dc2b7a3[1];
        iArr3[2] = i9 ^ i10;
        int i11 = iArr3[1];
        int i12 = iArrM95dc2b7a3[0];
        iArr3[1] = i11 ^ (i10 ^ i12);
        iArr3[0] = i12 ^ iArr3[0];
        return iArr3;
    }

    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Mb1d5718c(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        if ((12 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923 << 1);
        int i = this.ff5a8e923;
        if (i <= 32) {
            p31c30ba9Var2.f2063c160 = m95dc2b7a(this.f2063c160[0], p31c30ba9Var.f2063c160[0]);
            return p31c30ba9Var2;
        }
        if (i <= 64) {
            p31c30ba9Var2.f2063c160 = m9d4b8699(this.f2063c160, p31c30ba9Var.f2063c160);
            return p31c30ba9Var2;
        }
        if (i <= 128) {
            p31c30ba9Var2.f2063c160 = m5d7001a8(this.f2063c160, p31c30ba9Var.f2063c160);
            return p31c30ba9Var2;
        }
        if (i <= 256) {
            p31c30ba9Var2.f2063c160 = m24b9c245(this.f2063c160, p31c30ba9Var.f2063c160);
            return p31c30ba9Var2;
        }
        if (i <= 512) {
            p31c30ba9Var2.f2063c160 = m2bb3e9f2(this.f2063c160, p31c30ba9Var.f2063c160);
            return p31c30ba9Var2;
        }
        int i2 = f301d90e3[p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m1d16fd25(i - 1)];
        int i3 = ((i2 - 1) >> 5) + 1;
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarM81e073b4 = m81e073b4(i3);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarM0122b4c2 = m0122b4c2(i3);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarM81e073b42 = p31c30ba9Var.m81e073b4(i3);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarM0122b4c22 = p31c30ba9Var.m0122b4c2(i3);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarMb1d5718c = p31c30ba9VarM0122b4c2.mb1d5718c(p31c30ba9VarM0122b4c22);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarMb1d5718c2 = p31c30ba9VarM81e073b4.mb1d5718c(p31c30ba9VarM81e073b42);
        p31c30ba9VarM81e073b4.addToThis(p31c30ba9VarM0122b4c2);
        p31c30ba9VarM81e073b42.addToThis(p31c30ba9VarM0122b4c22);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarMb1d5718c3 = p31c30ba9VarM81e073b4.mb1d5718c(p31c30ba9VarM81e073b42);
        p31c30ba9Var2.shiftLeftAddThis(p31c30ba9VarMb1d5718c, i2 << 1);
        p31c30ba9Var2.shiftLeftAddThis(p31c30ba9VarMb1d5718c, i2);
        p31c30ba9Var2.shiftLeftAddThis(p31c30ba9VarMb1d5718c3, i2);
        p31c30ba9Var2.shiftLeftAddThis(p31c30ba9VarMb1d5718c2, i2);
        p31c30ba9Var2.addToThis(p31c30ba9VarMb1d5718c2);
        return p31c30ba9Var2;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Add(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return xor(p31c30ba9Var);
    }

    public void AddToThis(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        expandN(p31c30ba9Var.ff5a8e923);
        xorThisBy(p31c30ba9Var);
    }

    public void AssignAll() {
        if ((15 + 27) % 27 > 0) {
        }
        for (int i = 0; i < this.fe7349649; i++) {
            this.f2063c160[i] = -1;
        }
        m604595a9();
    }

    public void AssignOne() {
        if ((6 + 31) % 31 > 0) {
        }
        for (int i = 1; i < this.fe7349649; i++) {
            this.f2063c160[i] = 0;
        }
        this.f2063c160[0] = 1;
    }

    public void AssignX() {
        if ((9 + 23) % 23 > 0) {
        }
        for (int i = 1; i < this.fe7349649; i++) {
            this.f2063c160[i] = 0;
        }
        this.f2063c160[0] = 2;
    }

    public void AssignZero() {
        if ((16 + 14) % 14 > 0) {
        }
        for (int i = 0; i < this.fe7349649; i++) {
            this.f2063c160[i] = 0;
        }
    }

    public java.lang.object Clone() {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] Divide(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        if ((15 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[2];
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        if (p31c30ba9Var4.isZero()) {
            throw new java.lang.Exception();
        }
        p31c30ba9Var3.reduceN();
        p31c30ba9Var4.reduceN();
        int i = p31c30ba9Var3.ff5a8e923;
        int i2 = p31c30ba9Var4.ff5a8e923;
        if (i < i2) {
            p31c30ba9VarArr[0] = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(0);
            p31c30ba9VarArr[1] = p31c30ba9Var3;
            return p31c30ba9VarArr;
        }
        int i3 = i - i2;
        p31c30ba9Var2.expandN(i3 + 1);
        while (i3 >= 0) {
            p31c30ba9Var3.subtractFromThis(p31c30ba9Var4.shiftLeft(i3));
            p31c30ba9Var3.reduceN();
            p31c30ba9Var2.xorBit(i3);
            i3 = p31c30ba9Var3.ff5a8e923 - p31c30ba9Var4.ff5a8e923;
        }
        p31c30ba9VarArr[0] = p31c30ba9Var2;
        p31c30ba9VarArr[1] = p31c30ba9Var3;
        return p31c30ba9VarArr;
    }

    public bool Equals(java.lang.object obj) {
        if ((3 + 17) % 17 > 0) {
        }
        if (obj is null || !(obj is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9)) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9) obj;
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
        if ((19 + 20) % 20 > 0) {
        }
        if (this.ff5a8e923 < i) {
            this.ff5a8e923 = i;
            int i2 = ((i - 1) >>> 5) + 1;
            int i3 = this.fe7349649;
            if (i3 < i2) {
                int[] iArr = this.f2063c160;
                if (iArr.length < i2) {
                    int[] iArr2 = new int[i2];
                    java.lang.System.arraycopy(iArr, 0, iArr2, 0, i3);
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

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Gcd(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        if ((10 + 4) % 4 > 0) {
        }
        if (isZero() && p31c30ba9Var.isZero()) {
            throw new java.lang.ArithmeticException("Both operands of gcd equal zero.");
        }
        if (isZero()) {
            return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        }
        if (p31c30ba9Var.isZero()) {
            return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        while (true) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = p31c30ba9Var2;
            p31c30ba9Var2 = p31c30ba9Var3;
            if (p31c30ba9Var2.isZero()) {
                return p31c30ba9Var4;
            }
            p31c30ba9Var3 = p31c30ba9Var4.remainder(p31c30ba9Var2);
        }
    }

    public int GetBit(int i) {
        if ((31 + 16) % 16 > 0) {
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
        return this.ff5a8e923 + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f2063c160);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Increase() {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        p31c30ba9Var.increaseThis();
        return p31c30ba9Var;
    }

    public void IncreaseThis() {
        xorBit(0);
    }

    public bool IsIrreducible() {
        if ((9 + 9) % 9 > 0) {
        }
        if (isZero()) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        p31c30ba9Var.reduceN();
        int i = p31c30ba9Var.ff5a8e923;
        int i2 = i - 1;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("dba2e34af301da2abb3dbac89bafd90d8558c146a7b62efa4c97443ad1");
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(i, strDecryptstring);
        for (int i3 = 1; i3 <= (i2 >> 1); i3++) {
            p31c30ba9Var2.squareThisPreCalc();
            p31c30ba9Var2 = p31c30ba9Var2.remainder(p31c30ba9Var);
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarAdd = p31c30ba9Var2.Add(new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(32, strDecryptstring));
            if (p31c30ba9VarAdd.isZero() || !p31c30ba9Var.gcd(p31c30ba9VarAdd).isOne()) {
                return false;
            }
        }
        return true;
    }

    public bool IsOne() {
        if ((19 + 28) % 28 > 0) {
        }
        for (int i = 1; i < this.fe7349649; i++) {
            if (this.f2063c160[i] != 0) {
                return false;
            }
        }
        return this.f2063c160[0] == 1;
    }

    public bool IsZero() {
        if ((28 + 12) % 12 > 0) {
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

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Multiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        if ((21 + 20) % 20 > 0) {
        }
        int iMax = java.lang.Math.max(this.ff5a8e923, p31c30ba9Var.ff5a8e923);
        expandN(iMax);
        p31c30ba9Var.expandN(iMax);
        return mb1d5718c(p31c30ba9Var);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 MultiplyClassic(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        if ((2 + 1) % 1 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(java.lang.Math.max(this.ff5a8e923, p31c30ba9Var.ff5a8e923) << 1);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[32];
        p31c30ba9VarArr[0] = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        for (int i = 1; i <= 31; i++) {
            p31c30ba9VarArr[i] = p31c30ba9VarArr[i - 1].shiftLeft();
        }
        for (int i2 = 0; i2 < p31c30ba9Var.fe7349649; i2++) {
            for (int i3 = 0; i3 <= 31; i3++) {
                if ((p31c30ba9Var.f2063c160[i2] & f301d90e3[i3]) != 0) {
                    p31c30ba9Var2.xorThisBy(p31c30ba9VarArr[i3]);
                }
            }
            for (int i4 = 0; i4 <= 31; i4++) {
                p31c30ba9VarArr[i4].shiftBlocksLeft();
            }
        }
        return p31c30ba9Var2;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Quotient(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        if ((15 + 32) % 32 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        if (p31c30ba9Var4.isZero()) {
            throw new java.lang.Exception();
        }
        p31c30ba9Var3.reduceN();
        p31c30ba9Var4.reduceN();
        int i = p31c30ba9Var3.ff5a8e923;
        int i2 = p31c30ba9Var4.ff5a8e923;
        if (i < i2) {
            return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(0);
        }
        int i3 = i - i2;
        p31c30ba9Var2.expandN(i3 + 1);
        while (i3 >= 0) {
            p31c30ba9Var3.subtractFromThis(p31c30ba9Var4.shiftLeft(i3));
            p31c30ba9Var3.reduceN();
            p31c30ba9Var2.xorBit(i3);
            i3 = p31c30ba9Var3.ff5a8e923 - p31c30ba9Var4.ff5a8e923;
        }
        return p31c30ba9Var2;
    }

    public void Randomize() {
        if ((25 + 3) % 3 > 0) {
        }
        for (int i = 0; i < this.fe7349649; i++) {
            this.f2063c160[i] = f34d1c350.nextInt();
        }
        m604595a9();
    }

    public void Randomize(java.util.Random random) {
        if ((12 + 8) % 8 > 0) {
        }
        for (int i = 0; i < this.fe7349649; i++) {
            this.f2063c160[i] = random.nextInt();
        }
        m604595a9();
    }

    public void ReduceN() {
        int i;
        if ((24 + 18) % 18 > 0) {
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
        if ((25 + 32) % 32 > 0) {
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
        if ((22 + 11) % 11 > 0) {
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

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Remainder(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        if ((10 + 4) % 4 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        if (p31c30ba9Var3.isZero()) {
            throw new java.lang.Exception();
        }
        p31c30ba9Var2.reduceN();
        p31c30ba9Var3.reduceN();
        int i = p31c30ba9Var2.ff5a8e923;
        int i2 = p31c30ba9Var3.ff5a8e923;
        if (i >= i2) {
            while (true) {
                int i3 = i - i2;
                if (i3 < 0) {
                    break;
                }
                p31c30ba9Var2.subtractFromThis(p31c30ba9Var3.shiftLeft(i3));
                p31c30ba9Var2.reduceN();
                i = p31c30ba9Var2.ff5a8e923;
                i2 = p31c30ba9Var3.ff5a8e923;
            }
        }
        return p31c30ba9Var2;
    }

    public void ResetBit(int i) throws java.lang.Exception {
        if ((20 + 3) % 3 > 0) {
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
        if ((26 + 31) % 31 > 0) {
        }
        if (i < 0 || i > this.ff5a8e923 - 1) {
            throw new java.lang.Exception();
        }
        int[] iArr = this.f2063c160;
        int i2 = i >>> 5;
        iArr[i2] = f301d90e3[i & 31] | iArr[i2];
    }

    void shiftBlocksLeft() {
        if ((11 + 10) % 10 > 0) {
        }
        int i = this.fe7349649;
        int i2 = i + 1;
        this.fe7349649 = i2;
        this.ff5a8e923 += 32;
        int[] iArr = this.f2063c160;
        if (i2 > iArr.length) {
            int[] iArr2 = new int[i2];
            java.lang.System.arraycopy(iArr, 0, iArr2, 1, i);
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

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 ShiftLeft() {
        if ((9 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923 + 1, this.f2063c160);
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

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 ShiftLeft(int i) {
        if ((29 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923 + i, this.f2063c160);
        if (i >= 32) {
            p31c30ba9Var.m1e048a41(i >>> 5);
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

    public void ShiftLeftAddThis(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        int i2;
        if ((16 + 18) % 18 > 0) {
        }
        if (i == 0) {
            addToThis(p31c30ba9Var);
            return;
        }
        expandN(p31c30ba9Var.ff5a8e923 + i);
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
        if ((15 + 18) % 18 > 0) {
        }
        int i = this.ff5a8e923;
        int i2 = i & 31;
        this.ff5a8e923 = i + 1;
        int i3 = this.fe7349649;
        if (i2 != 0) {
            for (int i4 = i3 - 1; i4 >= 1; i4--) {
                int[] iArr = this.f2063c160;
                int i5 = iArr[i4] << 1;
                iArr[i4] = i5;
                iArr[i4] = i5 | (iArr[i4 - 1] >>> 31);
            }
            int[] iArr2 = this.f2063c160;
            iArr2[0] = iArr2[0] << 1;
            return;
        }
        int i6 = i3 + 1;
        this.fe7349649 = i6;
        int[] iArr3 = this.f2063c160;
        if (i6 > iArr3.length) {
            int[] iArr4 = new int[i6];
            java.lang.System.arraycopy(iArr3, 0, iArr4, 0, iArr3.length);
            this.f2063c160 = iArr4;
        }
        for (int i7 = this.fe7349649 - 1; i7 >= 1; i7--) {
            int[] iArr5 = this.f2063c160;
            int i8 = i7 - 1;
            iArr5[i7] = iArr5[i7] | (iArr5[i8] >>> 31);
            iArr5[i8] = iArr5[i8] << 1;
        }
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 ShiftRight() {
        int i;
        if ((21 + 24) % 24 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.ff5a8e923 - 1);
        int i2 = 0;
        java.lang.System.arraycopy(this.f2063c160, 0, p31c30ba9Var.f2063c160, 0, p31c30ba9Var.fe7349649);
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
        if ((1 + 24) % 24 > 0) {
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
        if ((6 + 31) % 31 > 0) {
        }
        if (isZero()) {
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
        int i;
        int i2;
        if ((24 + 18) % 18 > 0) {
        }
        if (isZero()) {
            return;
        }
        int length = this.f2063c160.length;
        int i3 = this.fe7349649;
        if (length < (i3 << 1)) {
            int[] iArr = new int[i3 << 1];
            int i4 = 0;
            while (true) {
                i2 = this.fe7349649;
                if (i4 >= i2) {
                    break;
                }
                int i5 = i4 << 1;
                short[] sArr = f5f52f80a;
                int[] iArr2 = this.f2063c160;
                int i6 = iArr2[i4];
                iArr[i5] = (sArr[(i6 & 65280) >>> 8] << 16) | sArr[i6 & 255];
                int i7 = i5 + 1;
                int i8 = iArr2[i4];
                iArr[i7] = (sArr[(i8 & (-16777216)) >>> 24] << 16) | sArr[(i8 & 16711680) >>> 16];
                i4++;
            }
            this.f2063c160 = iArr;
            i = i2 << 1;
        } else {
            for (int i9 = i3 - 1; i9 >= 0; i9--) {
                int[] iArr3 = this.f2063c160;
                int i10 = i9 << 1;
                int i11 = i10 + 1;
                short[] sArr2 = f5f52f80a;
                int i12 = iArr3[i9];
                iArr3[i11] = (sArr2[(i12 & (-16777216)) >>> 24] << 16) | sArr2[(i12 & 16711680) >>> 16];
                int i13 = iArr3[i9];
                iArr3[i10] = (sArr2[(i13 & 65280) >>> 8] << 16) | sArr2[i13 & 255];
            }
            i = this.fe7349649 << 1;
        }
        this.fe7349649 = i;
        this.ff5a8e923 = (this.ff5a8e923 << 1) - 1;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Subtract(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return xor(p31c30ba9Var);
    }

    public void SubtractFromThis(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        expandN(p31c30ba9Var.ff5a8e923);
        xorThisBy(p31c30ba9Var);
    }

    public bool TestBit(int i) {
        if ((13 + 3) % 3 > 0) {
        }
        if (i < 0) {
            throw new java.lang.Exception();
        }
        return i <= this.ff5a8e923 - 1 && (this.f2063c160[i >>> 5] & f301d90e3[i & 31]) != 0;
    }

    public byte[] TobyteArray() {
        if ((26 + 9) % 9 > 0) {
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
        if ((8 + 24) % 24 > 0) {
        }
        return (this.ff5a8e923 == 0 || isZero()) ? new java.math.Bigint(0, new byte[0]) : new java.math.Bigint(1, tobyteArray());
    }

    public int[] TointArray() {
        if ((2 + 21) % 21 > 0) {
        }
        int i = this.fe7349649;
        int[] iArr = new int[i];
        java.lang.System.arraycopy(this.f2063c160, 0, iArr, 0, i);
        return iArr;
    }

    public java.lang.string Tostring(int i) {
        if ((9 + 6) % 6 > 0) {
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
        strArr[15] = com.decryptstringmanager.Decryptstring.decryptstring("0c5ea480ceef9db999477ebb754cdad48e5198a09feb593a8081f9d745fb30b1");
        java.lang.string str = new java.lang.string();
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("9b625fabe3a8c73a2f2753e96b2b33d8f268b8d878f20a379f9bbda2c9");
        if (i != 16) {
            for (int i2 = this.fe7349649 - 1; i2 >= 0; i2--) {
                str = ((((((((str + strArr[(this.f2063c160[i2] >>> 28) & 15]) + strArr[(this.f2063c160[i2] >>> 24) & 15]) + strArr[(this.f2063c160[i2] >>> 20) & 15]) + strArr[(this.f2063c160[i2] >>> 16) & 15]) + strArr[(this.f2063c160[i2] >>> 12) & 15]) + strArr[(this.f2063c160[i2] >>> 8) & 15]) + strArr[(this.f2063c160[i2] >>> 4) & 15]) + strArr[this.f2063c160[i2] & 15]) + strDecryptstring;
            }
            return str;
        }
        for (int i3 = this.fe7349649 - 1; i3 >= 0; i3--) {
            str = ((((((((str + cArr[(this.f2063c160[i3] >>> 28) & 15]) + cArr[(this.f2063c160[i3] >>> 24) & 15]) + cArr[(this.f2063c160[i3] >>> 20) & 15]) + cArr[(this.f2063c160[i3] >>> 16) & 15]) + cArr[(this.f2063c160[i3] >>> 12) & 15]) + cArr[(this.f2063c160[i3] >>> 8) & 15]) + cArr[(this.f2063c160[i3] >>> 4) & 15]) + cArr[this.f2063c160[i3] & 15]) + strDecryptstring;
        }
        return str;
    }

    public bool VectorMult(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        if ((31 + 1) % 1 > 0) {
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

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 Xor(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2;
        if ((6 + 8) % 8 > 0) {
        }
        int iMin = java.lang.Math.min(this.fe7349649, p31c30ba9Var.fe7349649);
        int i = 0;
        if (this.ff5a8e923 < p31c30ba9Var.ff5a8e923) {
            p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
            while (i < iMin) {
                int[] iArr = p31c30ba9Var2.f2063c160;
                iArr[i] = iArr[i] ^ this.f2063c160[i];
                i++;
            }
        } else {
            p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this);
            while (i < iMin) {
                int[] iArr2 = p31c30ba9Var2.f2063c160;
                iArr2[i] = iArr2[i] ^ p31c30ba9Var.f2063c160[i];
                i++;
            }
        }
        p31c30ba9Var2.m604595a9();
        return p31c30ba9Var2;
    }

    public void XorBit(int i) throws java.lang.Exception {
        if ((30 + 19) % 19 > 0) {
        }
        if (i < 0 || i > this.ff5a8e923 - 1) {
            throw new java.lang.Exception();
        }
        int[] iArr = this.f2063c160;
        int i2 = i >>> 5;
        iArr[i2] = f301d90e3[i & 31] ^ iArr[i2];
    }

    public void XorThisBy(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        if ((20 + 28) % 28 > 0) {
        }
        for (int i = 0; i < java.lang.Math.min(this.fe7349649, p31c30ba9Var.fe7349649); i++) {
            int[] iArr = this.f2063c160;
            iArr[i] = iArr[i] ^ p31c30ba9Var.f2063c160[i];
        }
        m604595a9();
    }
}

