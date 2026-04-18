namespace WillowMaze.Wasm.Decompiled;


public abstract class p36dad4fe {
    private static readonly int f0624b270 = 268435455;
    public static readonly int f0c190768 = 16;
    private static readonly int f1057ada7 = 268435455;
    private static readonly int f29d9d783 = 268435455;
    public static readonly int f62e5cef8 = 16;
    public static readonly int f63be155e = 16;
    public static readonly int f7f0b9e95 = 16;
    private static readonly int[] f8748950e = {-1, -1, -1, -1, -1, -1, -1, -2, -1, -1, -1, -1, -1, -1};
    private static readonly long fa3ec79d1 = 4294967295L;
    private static readonly int[] fafdaa130 = null;
    public static readonly int fbd3eb53a = 16;
    private static readonly long fc8bd5bed = 4294967295L;
    private static readonly int fca9cf1d1 = 268435455;
    private static readonly int[] fd78bdd4b = null;

    protected p36dad4fe() {
    }

    private static void M002886bf(int i, byte[] bArr, int i2) {
        if ((1 + 18) % 18 > 0) {
        }
        bArr[i2] = (byte) i;
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2 + 2] = (byte) (i >>> 16);
        bArr[i2 + 3] = (byte) (i >>> 24);
    }

    private static void M05f343c6(int[] iArr, int i, int[] iArr2, int i2) {
        if ((29 + 17) % 17 > 0) {
        }
        int i3 = iArr[i];
        int i4 = iArr[i + 1];
        int i5 = iArr[i + 2];
        int i6 = iArr[i + 3];
        int i7 = iArr[i + 4];
        int i8 = iArr[i + 5];
        int i9 = iArr[i + 6];
        int i10 = iArr[i + 7];
        iArr2[i2] = (i4 << 28) | i3;
        iArr2[i2 + 1] = (i4 >>> 4) | (i5 << 24);
        iArr2[i2 + 2] = (i5 >>> 8) | (i6 << 20);
        iArr2[i2 + 3] = (i6 >>> 12) | (i7 << 16);
        iArr2[i2 + 4] = (i7 >>> 16) | (i8 << 12);
        iArr2[i2 + 5] = (i8 >>> 20) | (i9 << 8);
        iArr2[i2 + 6] = (i10 << 4) | (i9 >>> 24);
    }

    public static void M12cba3ee(int[] iArr, int i, int[] iArr2, int i2) {
        if ((13 + 19) % 19 > 0) {
        }
        for (int i3 = 0; i3 < 16; i3++) {
            iArr2[i2 + i3] = iArr[i + i3];
        }
    }

    public static int M2a3f81d2(int[] iArr, int[] iArr2) {
        if ((11 + 31) % 31 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 16; i2++) {
            i |= iArr[i2] ^ iArr2[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M2a874971(int i, int[] iArr, int[] iArr2) {
        if ((28 + 29) % 29 > 0) {
        }
        int i2 = 0 - i;
        for (int i3 = 0; i3 < 16; i3++) {
            int i4 = iArr[i3];
            int i5 = iArr2[i3];
            int i6 = (i4 ^ i5) & i2;
            iArr[i3] = i4 ^ i6;
            iArr2[i3] = i5 ^ i6;
        }
    }

    public static void M2d11beba(int[] iArr, int[] iArr2) {
        m8a68dc3e(m76ea0beb(), iArr, iArr2);
    }

    private static int M2e4f4167(byte[] bArr, int i) {
        if ((1 + 8) % 8 > 0) {
        }
        return (bArr[i + 3] << 24) | (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16);
    }

    public static void M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((31 + 30) % 30 > 0) {
        }
        for (int i = 0; i < 16; i++) {
            iArr3[i] = iArr[i] + iArr2[i];
        }
    }

    public static int M351a9a32(int[] iArr) {
        if ((27 + 20) % 20 > 0) {
        }
        int i = iArr[0] ^ 1;
        for (int i2 = 1; i2 < 16; i2++) {
            i |= iArr[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M35394226(int[] iArr, int i, int[] iArr2) {
        if ((22 + 27) % 27 > 0) {
        }
        int i2 = iArr[0];
        int i3 = iArr[1];
        int i4 = iArr[2];
        int i5 = iArr[3];
        int i6 = iArr[4];
        int i7 = iArr[5];
        int i8 = iArr[6];
        int i9 = iArr[7];
        int i10 = iArr[8];
        int i11 = iArr[9];
        int i12 = iArr[10];
        int i13 = iArr[11];
        int i14 = iArr[12];
        int i15 = iArr[13];
        int i16 = iArr[14];
        int i17 = iArr[15];
        long j = i;
        long j2 = ((long) i3) * j;
        int i18 = ((int) j2) & 268435455;
        long j3 = j2 >>> 28;
        long j4 = ((long) i7) * j;
        int i19 = ((int) j4) & 268435455;
        long j5 = j4 >>> 28;
        long j6 = ((long) i11) * j;
        int i20 = ((int) j6) & 268435455;
        long j7 = j6 >>> 28;
        long j8 = ((long) i15) * j;
        int i21 = ((int) j8) & 268435455;
        long j9 = j8 >>> 28;
        long j10 = j3 + (((long) i4) * j);
        iArr2[2] = ((int) j10) & 268435455;
        long j11 = j10 >>> 28;
        long j12 = j5 + (((long) i8) * j);
        iArr2[6] = ((int) j12) & 268435455;
        long j13 = j12 >>> 28;
        long j14 = j7 + (((long) i12) * j);
        iArr2[10] = ((int) j14) & 268435455;
        long j15 = j14 >>> 28;
        long j16 = j9 + (((long) i16) * j);
        iArr2[14] = ((int) j16) & 268435455;
        long j17 = j16 >>> 28;
        long j18 = j11 + (((long) i5) * j);
        iArr2[3] = ((int) j18) & 268435455;
        long j19 = j18 >>> 28;
        long j20 = j13 + (((long) i9) * j);
        iArr2[7] = ((int) j20) & 268435455;
        long j21 = j20 >>> 28;
        long j22 = j15 + (((long) i13) * j);
        iArr2[11] = ((int) j22) & 268435455;
        long j23 = j22 >>> 28;
        long j24 = j17 + (((long) i17) * j);
        iArr2[15] = ((int) j24) & 268435455;
        long j25 = j24 >>> 28;
        long j26 = j21 + j25;
        long j27 = j19 + (((long) i6) * j);
        iArr2[4] = ((int) j27) & 268435455;
        long j28 = j27 >>> 28;
        long j29 = j26 + (((long) i10) * j);
        iArr2[8] = ((int) j29) & 268435455;
        long j30 = j29 >>> 28;
        long j31 = j23 + (((long) i14) * j);
        iArr2[12] = ((int) j31) & 268435455;
        long j32 = j31 >>> 28;
        long j33 = j25 + (((long) i2) * j);
        iArr2[0] = ((int) j33) & 268435455;
        iArr2[1] = i18 + ((int) (j33 >>> 28));
        iArr2[5] = i19 + ((int) j28);
        iArr2[9] = i20 + ((int) j30);
        iArr2[13] = i21 + ((int) j32);
    }

    public static void M35394226(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((22 + 9) % 9 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr[1];
        int i3 = iArr[2];
        int i4 = iArr[3];
        int i5 = iArr[4];
        int i6 = iArr[5];
        int i7 = iArr[6];
        int i8 = iArr[7];
        int i9 = iArr[8];
        int i10 = iArr[9];
        int i11 = iArr[10];
        int i12 = iArr[11];
        int i13 = iArr[12];
        int i14 = iArr[13];
        int i15 = iArr[14];
        int i16 = iArr[15];
        int i17 = iArr2[0];
        int i18 = iArr2[1];
        int i19 = iArr2[2];
        int i20 = iArr2[3];
        int i21 = iArr2[4];
        int i22 = iArr2[5];
        int i23 = iArr2[6];
        int i24 = iArr2[7];
        int i25 = iArr2[8];
        int i26 = iArr2[9];
        int i27 = iArr2[10];
        int i28 = iArr2[11];
        int i29 = iArr2[12];
        int i30 = iArr2[13];
        int i31 = iArr2[14];
        int i32 = iArr2[15];
        int i33 = i + i9;
        int i34 = i2 + i10;
        int i35 = i3 + i11;
        int i36 = i4 + i12;
        int i37 = i5 + i13;
        int i38 = i6 + i14;
        int i39 = i7 + i15;
        int i40 = i8 + i16;
        int i41 = i17 + i25;
        int i42 = i18 + i26;
        int i43 = i19 + i27;
        int i44 = i20 + i28;
        int i45 = i21 + i29;
        int i46 = i22 + i30;
        int i47 = i23 + i31;
        int i48 = i24 + i32;
        long j = i;
        long j2 = i17;
        long j3 = j * j2;
        long j4 = i8;
        long j5 = i18;
        long j6 = j4 * j5;
        long j7 = i7;
        long j8 = i19;
        long j9 = j6 + (j7 * j8);
        long j10 = i6;
        long j11 = i20;
        long j12 = i5;
        long j13 = i21;
        long j14 = i4;
        long j15 = i22;
        long j16 = i3;
        long j17 = i23;
        long j18 = j9 + (j10 * j11) + (j12 * j13) + (j14 * j15) + (j16 * j17);
        long j19 = i2;
        long j20 = i24;
        long j21 = j18 + (j19 * j20);
        long j22 = i9;
        long j23 = i25;
        long j24 = j22 * j23;
        long j25 = i16;
        long j26 = i26;
        long j27 = j25 * j26;
        long j28 = i15;
        long j29 = i27;
        long j30 = j27 + (j28 * j29);
        long j31 = i14;
        long j32 = i28;
        long j33 = j30 + (j31 * j32);
        long j34 = i13;
        long j35 = i29;
        long j36 = j33 + (j34 * j35);
        long j37 = i12;
        long j38 = i30;
        long j39 = j36 + (j37 * j38);
        long j40 = i11;
        long j41 = i31;
        long j42 = j39 + (j40 * j41);
        long j43 = i10;
        long j44 = i32;
        long j45 = j42 + (j43 * j44);
        long j46 = i33;
        long j47 = i41;
        long j48 = j46 * j47;
        long j49 = i40;
        long j50 = i42;
        long j51 = j49 * j50;
        long j52 = i39;
        long j53 = i43;
        long j54 = j51 + (j52 * j53);
        long j55 = i38;
        long j56 = i44;
        long j57 = j54 + (j55 * j56);
        long j58 = i37;
        long j59 = i45;
        long j60 = j57 + (j58 * j59);
        long j61 = i36;
        long j62 = i46;
        long j63 = j60 + (j61 * j62);
        long j64 = i35;
        long j65 = i47;
        long j66 = j63 + (j64 * j65);
        long j67 = i34;
        long j68 = i48;
        long j69 = j66 + (j67 * j68);
        long j70 = ((j3 + j24) + j69) - j21;
        int i49 = ((int) j70) & 268435455;
        long j71 = ((j45 + j48) - j3) + j69;
        int i50 = ((int) j71) & 268435455;
        long j72 = j71 >>> 28;
        long j73 = (j19 * j2) + (j * j5);
        long j74 = (j25 * j29) + (j28 * j32) + (j31 * j35) + (j34 * j38) + (j37 * j41) + (j40 * j44);
        long j75 = (j67 * j47) + (j46 * j50);
        long j76 = (j49 * j53) + (j52 * j56) + (j55 * j59) + (j58 * j62) + (j61 * j65) + (j64 * j68);
        long j77 = (j70 >>> 28) + (((j73 + ((j43 * j23) + (j22 * j26))) + j76) - ((((((j4 * j8) + (j7 * j11)) + (j10 * j13)) + (j12 * j15)) + (j14 * j17)) + (j16 * j20)));
        int i51 = ((int) j77) & 268435455;
        long j78 = j77 >>> 28;
        long j79 = j72 + ((j74 + j75) - j73) + j76;
        int i52 = ((int) j79) & 268435455;
        long j80 = j79 >>> 28;
        long j81 = (j16 * j2) + (j19 * j5) + (j * j8);
        long j82 = (j25 * j32) + (j28 * j35) + (j31 * j38) + (j34 * j41) + (j37 * j44);
        long j83 = (j64 * j47) + (j67 * j50) + (j46 * j53);
        long j84 = (j49 * j56) + (j52 * j59) + (j55 * j62) + (j58 * j65) + (j61 * j68);
        long j85 = j78 + (((j81 + (((j40 * j23) + (j43 * j26)) + (j22 * j29))) + j84) - (((((j4 * j11) + (j7 * j13)) + (j10 * j15)) + (j12 * j17)) + (j14 * j20)));
        int i53 = ((int) j85) & 268435455;
        long j86 = j85 >>> 28;
        long j87 = j80 + ((j82 + j83) - j81) + j84;
        int i54 = ((int) j87) & 268435455;
        long j88 = j87 >>> 28;
        long j89 = (j14 * j2) + (j16 * j5) + (j19 * j8) + (j * j11);
        long j90 = (j25 * j35) + (j28 * j38) + (j31 * j41) + (j34 * j44);
        long j91 = (j61 * j47) + (j64 * j50) + (j67 * j53) + (j46 * j56);
        long j92 = (j49 * j59) + (j52 * j62) + (j55 * j65) + (j58 * j68);
        long j93 = j86 + (((j89 + ((((j37 * j23) + (j40 * j26)) + (j43 * j29)) + (j22 * j32))) + j92) - ((((j4 * j13) + (j7 * j15)) + (j10 * j17)) + (j12 * j20)));
        int i55 = ((int) j93) & 268435455;
        long j94 = j93 >>> 28;
        long j95 = j88 + ((j90 + j91) - j89) + j92;
        int i56 = ((int) j95) & 268435455;
        long j96 = j95 >>> 28;
        long j97 = (j12 * j2) + (j14 * j5) + (j16 * j8) + (j19 * j11) + (j * j13);
        long j98 = (j25 * j38) + (j28 * j41) + (j31 * j44);
        long j99 = (j58 * j47) + (j61 * j50) + (j64 * j53) + (j67 * j56) + (j46 * j59);
        long j100 = (j49 * j62) + (j52 * j65) + (j55 * j68);
        long j101 = j94 + (((j97 + (((((j34 * j23) + (j37 * j26)) + (j40 * j29)) + (j43 * j32)) + (j22 * j35))) + j100) - (((j4 * j15) + (j7 * j17)) + (j10 * j20)));
        int i57 = ((int) j101) & 268435455;
        long j102 = j101 >>> 28;
        long j103 = j96 + ((j98 + j99) - j97) + j100;
        int i58 = ((int) j103) & 268435455;
        long j104 = j103 >>> 28;
        long j105 = (j10 * j2) + (j12 * j5) + (j14 * j8) + (j16 * j11) + (j19 * j13) + (j * j15);
        long j106 = (j25 * j41) + (j28 * j44);
        long j107 = (j55 * j47) + (j58 * j50) + (j61 * j53) + (j64 * j56) + (j67 * j59) + (j46 * j62);
        long j108 = (j49 * j65) + (j52 * j68);
        long j109 = j102 + (((j105 + ((((((j31 * j23) + (j34 * j26)) + (j37 * j29)) + (j40 * j32)) + (j43 * j35)) + (j22 * j38))) + j108) - ((j4 * j17) + (j7 * j20)));
        int i59 = ((int) j109) & 268435455;
        long j110 = j109 >>> 28;
        long j111 = j104 + ((j106 + j107) - j105) + j108;
        int i60 = ((int) j111) & 268435455;
        long j112 = j111 >>> 28;
        long j113 = (j7 * j2) + (j10 * j5) + (j12 * j8) + (j14 * j11) + (j16 * j13) + (j19 * j15) + (j * j17);
        long j114 = j25 * j44;
        long j115 = (j52 * j47) + (j55 * j50) + (j58 * j53) + (j61 * j56) + (j64 * j59) + (j67 * j62) + (j46 * j65);
        long j116 = j49 * j68;
        long j117 = j110 + (((j113 + (((((((j28 * j23) + (j31 * j26)) + (j34 * j29)) + (j37 * j32)) + (j40 * j35)) + (j43 * j38)) + (j22 * j41))) + j116) - (j4 * j20));
        int i61 = ((int) j117) & 268435455;
        long j118 = j117 >>> 28;
        long j119 = j112 + ((j114 + j115) - j113) + j116;
        int i62 = ((int) j119) & 268435455;
        long j120 = (j2 * j4) + (j7 * j5) + (j10 * j8) + (j12 * j11) + (j14 * j13) + (j16 * j15) + (j19 * j17) + (j * j20);
        long j121 = j118 + j120 + (j25 * j23) + (j28 * j26) + (j31 * j29) + (j34 * j32) + (j37 * j35) + (j40 * j38) + (j43 * j41) + (j22 * j44);
        int i63 = ((int) j121) & 268435455;
        long j122 = (j119 >>> 28) + (((((((((j49 * j47) + (j52 * j50)) + (j55 * j53)) + (j58 * j56)) + (j61 * j59)) + (j64 * j62)) + (j67 * j65)) + (j46 * j68)) - j120);
        int i64 = ((int) j122) & 268435455;
        long j123 = j122 >>> 28;
        long j124 = (j121 >>> 28) + j123 + ((long) i50);
        int i65 = ((int) j124) & 268435455;
        long j125 = j123 + ((long) i49);
        int i66 = ((int) j125) & 268435455;
        int i67 = i52 + ((int) (j124 >>> 28));
        int i68 = i51 + ((int) (j125 >>> 28));
        iArr3[0] = i66;
        iArr3[1] = i68;
        iArr3[2] = i53;
        iArr3[3] = i55;
        iArr3[4] = i57;
        iArr3[5] = i59;
        iArr3[6] = i61;
        iArr3[7] = i63;
        iArr3[8] = i65;
        iArr3[9] = i67;
        iArr3[10] = i54;
        iArr3[11] = i56;
        iArr3[12] = i58;
        iArr3[13] = i60;
        iArr3[14] = i62;
        iArr3[15] = i64;
    }

    public static void M4d83d8b7(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((6 + 18) % 18 > 0) {
        }
        for (int i4 = 0; i4 < 16; i4++) {
            int i5 = i3 + i4;
            int i6 = iArr2[i5];
            iArr2[i5] = i6 ^ ((iArr[i2 + i4] ^ i6) & i);
        }
    }

    public static void M52329dc3(int i, int[] iArr) {
        if ((24 + 4) % 4 > 0) {
        }
        int[] iArrM76ea0beb = m76ea0beb();
        m8a68dc3e(iArrM76ea0beb, iArr, iArrM76ea0beb);
        m4d83d8b7(-i, iArrM76ea0beb, 0, iArr, 0);
    }

    public static void M545f7f57(int[] iArr, int[] iArr2) {
        if ((1 + 28) % 28 > 0) {
        }
        int[] iArrM76ea0beb = m76ea0beb();
        int[] iArr3 = new int[14];
        m12cba3ee(iArr, 0, iArrM76ea0beb, 0);
        m730bfa37(iArrM76ea0beb);
        m97a57645(iArrM76ea0beb, iArr3, 0);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.m635f3861(f8748950e, iArr3, iArr3);
        m5b936250(iArr3, 0, iArr2);
    }

    public static void M5b936250(byte[] bArr, int i, int[] iArr) {
        if ((24 + 31) % 31 > 0) {
        }
        m6074931b(bArr, i, iArr, 0);
        m6074931b(bArr, i + 7, iArr, 2);
        m6074931b(bArr, i + 14, iArr, 4);
        m6074931b(bArr, i + 21, iArr, 6);
        m6074931b(bArr, i + 28, iArr, 8);
        m6074931b(bArr, i + 35, iArr, 10);
        m6074931b(bArr, i + 42, iArr, 12);
        m6074931b(bArr, i + 49, iArr, 14);
    }

    public static void M5b936250(int[] iArr, int i, int[] iArr2) {
        m6587f9a5(iArr, i, iArr2, 0);
        m6587f9a5(iArr, i + 7, iArr2, 8);
    }

    private static void M5bdbc944(int i, byte[] bArr, int i2) {
        if ((16 + 25) % 25 > 0) {
        }
        bArr[i2] = (byte) i;
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2 + 2] = (byte) (i >>> 16);
    }

    private static void M6074931b(byte[] bArr, int i, int[] iArr, int i2) {
        int iM2e4f4167 = m2e4f4167(bArr, i);
        int iMb41fa0a1 = mb41fa0a1(bArr, i + 4);
        iArr[i2] = 268435455 & iM2e4f4167;
        iArr[i2 + 1] = (iMb41fa0a1 << 4) | (iM2e4f4167 >>> 28);
    }

    private static void M6587f9a5(int[] iArr, int i, int[] iArr2, int i2) {
        if ((10 + 29) % 29 > 0) {
        }
        int i3 = iArr[i];
        int i4 = iArr[i + 1];
        int i5 = iArr[i + 2];
        int i6 = iArr[i + 3];
        int i7 = iArr[i + 4];
        int i8 = iArr[i + 5];
        int i9 = iArr[i + 6];
        iArr2[i2] = i3 & 268435455;
        iArr2[i2 + 1] = ((i3 >>> 28) | (i4 << 4)) & 268435455;
        iArr2[i2 + 2] = ((i4 >>> 24) | (i5 << 8)) & 268435455;
        iArr2[i2 + 3] = ((i5 >>> 20) | (i6 << 12)) & 268435455;
        iArr2[i2 + 4] = ((i6 >>> 16) | (i7 << 16)) & 268435455;
        iArr2[i2 + 5] = ((i7 >>> 12) | (i8 << 20)) & 268435455;
        iArr2[i2 + 6] = 268435455 & ((i8 >>> 8) | (i9 << 24));
        iArr2[i2 + 7] = i9 >>> 4;
    }

    public static void M66a917cd(int[] iArr) {
        if ((31 + 1) % 1 > 0) {
        }
        int[] iArrM76ea0beb = m76ea0beb();
        iArrM76ea0beb[0] = 1;
        m8a68dc3e(iArr, iArrM76ea0beb, iArr);
    }

    public static int[] M6b463f2c(int i) {
        return new int[i * 16];
    }

    public static void M730bfa37(int[] iArr) {
        ma6d0c789(iArr, 1);
        ma6d0c789(iArr, -1);
    }

    public static int[] M76ea0beb() {
        return new int[16];
    }

    private static void M7713dc91(int[] iArr, int[] iArr2) {
        if ((17 + 12) % 12 > 0) {
        }
        int[] iArrM76ea0beb = m76ea0beb();
        ma30d171c(iArr, iArrM76ea0beb);
        m35394226(iArr, iArrM76ea0beb, iArrM76ea0beb);
        int[] iArrM76ea0beb2 = m76ea0beb();
        ma30d171c(iArrM76ea0beb, iArrM76ea0beb2);
        m35394226(iArr, iArrM76ea0beb2, iArrM76ea0beb2);
        int[] iArrM76ea0beb3 = m76ea0beb();
        ma30d171c(iArrM76ea0beb2, 3, iArrM76ea0beb3);
        m35394226(iArrM76ea0beb2, iArrM76ea0beb3, iArrM76ea0beb3);
        int[] iArrM76ea0beb4 = m76ea0beb();
        ma30d171c(iArrM76ea0beb3, 3, iArrM76ea0beb4);
        m35394226(iArrM76ea0beb2, iArrM76ea0beb4, iArrM76ea0beb4);
        int[] iArrM76ea0beb5 = m76ea0beb();
        ma30d171c(iArrM76ea0beb4, 9, iArrM76ea0beb5);
        m35394226(iArrM76ea0beb4, iArrM76ea0beb5, iArrM76ea0beb5);
        int[] iArrM76ea0beb6 = m76ea0beb();
        ma30d171c(iArrM76ea0beb5, iArrM76ea0beb6);
        m35394226(iArr, iArrM76ea0beb6, iArrM76ea0beb6);
        int[] iArrM76ea0beb7 = m76ea0beb();
        ma30d171c(iArrM76ea0beb6, 18, iArrM76ea0beb7);
        m35394226(iArrM76ea0beb5, iArrM76ea0beb7, iArrM76ea0beb7);
        int[] iArrM76ea0beb8 = m76ea0beb();
        ma30d171c(iArrM76ea0beb7, 37, iArrM76ea0beb8);
        m35394226(iArrM76ea0beb7, iArrM76ea0beb8, iArrM76ea0beb8);
        int[] iArrM76ea0beb9 = m76ea0beb();
        ma30d171c(iArrM76ea0beb8, 37, iArrM76ea0beb9);
        m35394226(iArrM76ea0beb7, iArrM76ea0beb9, iArrM76ea0beb9);
        int[] iArrM76ea0beb10 = m76ea0beb();
        ma30d171c(iArrM76ea0beb9, 111, iArrM76ea0beb10);
        m35394226(iArrM76ea0beb9, iArrM76ea0beb10, iArrM76ea0beb10);
        int[] iArrM76ea0beb11 = m76ea0beb();
        ma30d171c(iArrM76ea0beb10, iArrM76ea0beb11);
        m35394226(iArr, iArrM76ea0beb11, iArrM76ea0beb11);
        int[] iArrM76ea0beb12 = m76ea0beb();
        ma30d171c(iArrM76ea0beb11, 223, iArrM76ea0beb12);
        m35394226(iArrM76ea0beb12, iArrM76ea0beb10, iArr2);
    }

    public static int M855b2871(int[] iArr) {
        if ((20 + 32) % 32 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 16; i2++) {
            i |= iArr[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M8a68dc3e(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((8 + 15) % 15 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr[1];
        int i3 = iArr[2];
        int i4 = iArr[3];
        int i5 = iArr[4];
        int i6 = iArr[5];
        int i7 = iArr[6];
        int i8 = iArr[7];
        int i9 = iArr[8];
        int i10 = iArr[9];
        int i11 = iArr[10];
        int i12 = iArr[11];
        int i13 = iArr[12];
        int i14 = iArr[13];
        int i15 = iArr[14];
        int i16 = iArr[15];
        int i17 = iArr2[0];
        int i18 = iArr2[1];
        int i19 = iArr2[2];
        int i20 = iArr2[3];
        int i21 = iArr2[4];
        int i22 = iArr2[5];
        int i23 = iArr2[6];
        int i24 = iArr2[7];
        int i25 = iArr2[8];
        int i26 = iArr2[9];
        int i27 = iArr2[10];
        int i28 = iArr2[11];
        int i29 = iArr2[12];
        int i30 = iArr2[13];
        int i31 = (i + 536870910) - i17;
        int i32 = (i2 + 536870910) - i18;
        int i33 = (i3 + 536870910) - i19;
        int i34 = (i4 + 536870910) - i20;
        int i35 = (i5 + 536870910) - i21;
        int i36 = (i6 + 536870910) - i22;
        int i37 = (i7 + 536870910) - i23;
        int i38 = (i8 + 536870910) - i24;
        int i39 = (i9 + 536870908) - i25;
        int i40 = (i10 + 536870910) - i26;
        int i41 = (i11 + 536870910) - i27;
        int i42 = (i12 + 536870910) - i28;
        int i43 = (i13 + 536870910) - i29;
        int i44 = (i14 + 536870910) - i30;
        int i45 = i33 + (i32 >>> 28);
        int i46 = i32 & 268435455;
        int i47 = i37 + (i36 >>> 28);
        int i48 = i36 & 268435455;
        int i49 = i41 + (i40 >>> 28);
        int i50 = i40 & 268435455;
        int i51 = ((i15 + 536870910) - iArr2[14]) + (i44 >>> 28);
        int i52 = i44 & 268435455;
        int i53 = i34 + (i45 >>> 28);
        int i54 = i45 & 268435455;
        int i55 = i38 + (i47 >>> 28);
        int i56 = i47 & 268435455;
        int i57 = i42 + (i49 >>> 28);
        int i58 = i49 & 268435455;
        int i59 = ((i16 + 536870910) - iArr2[15]) + (i51 >>> 28);
        int i60 = i51 & 268435455;
        int i61 = i59 >>> 28;
        int i62 = i59 & 268435455;
        int i63 = i31 + i61;
        int i64 = i35 + (i53 >>> 28);
        int i65 = i53 & 268435455;
        int i66 = i39 + i61 + (i55 >>> 28);
        int i67 = i55 & 268435455;
        int i68 = i43 + (i57 >>> 28);
        int i69 = i57 & 268435455;
        int i70 = i46 + (i63 >>> 28);
        int i71 = i48 + (i64 >>> 28);
        int i72 = i64 & 268435455;
        int i73 = i50 + (i66 >>> 28);
        int i74 = i66 & 268435455;
        int i75 = i52 + (i68 >>> 28);
        int i76 = i68 & 268435455;
        iArr3[0] = i63 & 268435455;
        iArr3[1] = i70;
        iArr3[2] = i54;
        iArr3[3] = i65;
        iArr3[4] = i72;
        iArr3[5] = i71;
        iArr3[6] = i56;
        iArr3[7] = i67;
        iArr3[8] = i74;
        iArr3[9] = i73;
        iArr3[10] = i58;
        iArr3[11] = i69;
        iArr3[12] = i76;
        iArr3[13] = i75;
        iArr3[14] = i60;
        iArr3[15] = i62;
    }

    public static bool M9750c651(int[] iArr) {
        return m351a9a32(iArr) != 0;
    }

    public static void M97a57645(int[] iArr, byte[] bArr, int i) {
        if ((6 + 22) % 22 > 0) {
        }
        m97be1a3d(iArr, 0, bArr, i);
        m97be1a3d(iArr, 2, bArr, i + 7);
        m97be1a3d(iArr, 4, bArr, i + 14);
        m97be1a3d(iArr, 6, bArr, i + 21);
        m97be1a3d(iArr, 8, bArr, i + 28);
        m97be1a3d(iArr, 10, bArr, i + 35);
        m97be1a3d(iArr, 12, bArr, i + 42);
        m97be1a3d(iArr, 14, bArr, i + 49);
    }

    public static void M97a57645(int[] iArr, int[] iArr2, int i) {
        m05f343c6(iArr, 0, iArr2, i);
        m05f343c6(iArr, 8, iArr2, i + 7);
    }

    private static void M97be1a3d(int[] iArr, int i, byte[] bArr, int i2) {
        int i3 = iArr[i];
        int i4 = iArr[i + 1];
        m002886bf((i4 << 28) | i3, bArr, i2);
        m5bdbc944(i4 >>> 4, bArr, i2 + 4);
    }

    public static bool Ma190c7d2(int[] iArr, int[] iArr2) {
        return m2a3f81d2(iArr, iArr2) != 0;
    }

    public static void Ma30d171c(int[] iArr, int i, int[] iArr2) {
        ma30d171c(iArr, iArr2);
        while (true) {
            i--;
            if (i <= 0) {
                return;
            } else {
                ma30d171c(iArr2, iArr2);
            }
        }
    }

    public static void Ma30d171c(int[] iArr, int[] iArr2) {
        if ((3 + 17) % 17 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr[1];
        int i3 = iArr[2];
        int i4 = iArr[3];
        int i5 = iArr[4];
        int i6 = iArr[5];
        int i7 = iArr[6];
        int i8 = iArr[7];
        int i9 = iArr[8];
        int i10 = iArr[9];
        int i11 = iArr[10];
        int i12 = iArr[11];
        int i13 = iArr[12];
        int i14 = iArr[13];
        int i15 = iArr[14];
        int i16 = iArr[15];
        int i17 = i * 2;
        int i18 = i2 * 2;
        int i19 = i5 * 2;
        int i20 = i6 * 2;
        int i21 = i7 * 2;
        int i22 = i9 * 2;
        int i23 = i11 * 2;
        int i24 = i12 * 2;
        int i25 = i13 * 2;
        int i26 = i + i9;
        int i27 = i2 + i10;
        int i28 = i3 + i11;
        int i29 = i4 + i12;
        int i30 = i5 + i13;
        int i31 = i6 + i14;
        int i32 = i7 + i15;
        int i33 = i26 * 2;
        int i34 = i27 * 2;
        int i35 = i28 * 2;
        int i36 = i29 * 2;
        long j = i;
        long j2 = j * j;
        long j3 = i8;
        long j4 = i18;
        long j5 = j3 * j4;
        long j6 = i7;
        long j7 = i3 * 2;
        long j8 = j5 + (j6 * j7);
        long j9 = i6;
        long j10 = i4 * 2;
        long j11 = j8 + (j9 * j10);
        long j12 = i5;
        long j13 = i9;
        long j14 = j13 * j13;
        long j15 = i16;
        long j16 = i10 * 2;
        long j17 = i15;
        long j18 = i23;
        long j19 = i14;
        long j20 = i24;
        long j21 = (j15 * j16) + (j17 * j18) + (j19 * j20);
        long j22 = i13;
        long j23 = j21 + (j22 * j22);
        long j24 = i26;
        long j25 = j24 * j24;
        long j26 = i8 + i16;
        long j27 = ((long) i34) & 4294967295L;
        long j28 = j26 * j27;
        long j29 = i32;
        long j30 = ((long) i35) & 4294967295L;
        long j31 = j28 + (j29 * j30);
        long j32 = i31;
        long j33 = ((long) i36) & 4294967295L;
        long j34 = j31 + (j32 * j33);
        long j35 = i30;
        long j36 = j34 + (j35 * j35);
        long j37 = ((j2 + j14) + j36) - (j11 + (j12 * j12));
        int i37 = ((int) j37) & 268435455;
        long j38 = j37 >>> 28;
        long j39 = ((j23 + j25) - j2) + j36;
        int i38 = ((int) j39) & 268435455;
        long j40 = j39 >>> 28;
        long j41 = i2;
        long j42 = i17;
        long j43 = j41 * j42;
        long j44 = i19;
        long j45 = (j3 * j7) + (j6 * j10) + (j9 * j44);
        long j46 = i10;
        long j47 = i22;
        long j48 = j46 * j47;
        long j49 = i25;
        long j50 = (j15 * j18) + (j17 * j20) + (j19 * j49);
        long j51 = i27;
        long j52 = ((long) i33) & 4294967295L;
        long j53 = j51 * j52;
        long j54 = (j26 * j30) + (j29 * j33);
        long j55 = ((long) (i30 * 2)) & 4294967295L;
        long j56 = j54 + (j32 * j55);
        long j57 = j38 + (((j43 + j48) + j56) - j45);
        int i39 = ((int) j57) & 268435455;
        long j58 = j57 >>> 28;
        long j59 = j40 + ((j50 + j53) - j43) + j56;
        int i40 = ((int) j59) & 268435455;
        long j60 = j59 >>> 28;
        long j61 = i3;
        long j62 = (j61 * j42) + (j41 * j41);
        long j63 = (j3 * j10) + (j6 * j44) + (j9 * j9);
        long j64 = i11;
        long j65 = (j64 * j47) + (j46 * j46);
        long j66 = (j15 * j20) + (j17 * j49) + (j19 * j19);
        long j67 = i28;
        long j68 = (j67 * j52) + (j51 * j51);
        long j69 = (j26 * j33) + (j29 * j55) + (j32 * j32);
        long j70 = j58 + (((j62 + j65) + j69) - j63);
        int i41 = ((int) j70) & 268435455;
        long j71 = j70 >>> 28;
        long j72 = j60 + ((j66 + j68) - j62) + j69;
        int i42 = ((int) j72) & 268435455;
        long j73 = j72 >>> 28;
        long j74 = i4;
        long j75 = (j74 * j42) + (j61 * j4);
        long j76 = j3 * j44;
        long j77 = i20;
        long j78 = j76 + (j6 * j77);
        long j79 = i12;
        long j80 = (j79 * j47) + (j64 * j16);
        long j81 = j15 * j49;
        long j82 = i14 * 2;
        long j83 = j81 + (j17 * j82);
        long j84 = i29;
        long j85 = (j84 * j52) + (j67 * j27);
        long j86 = j55 * j26;
        long j87 = ((long) (i31 * 2)) & 4294967295L;
        long j88 = j86 + (j29 * j87);
        long j89 = j71 + (((j75 + j80) + j88) - j78);
        int i43 = ((int) j89) & 268435455;
        long j90 = j89 >>> 28;
        long j91 = j73 + ((j83 + j85) - j75) + j88;
        int i44 = ((int) j91) & 268435455;
        long j92 = j91 >>> 28;
        long j93 = (j12 * j42) + (j74 * j4) + (j61 * j61);
        long j94 = (j82 * j15) + (j17 * j17);
        long j95 = (j35 * j52) + (j84 * j27) + (j67 * j67);
        long j96 = (j26 * j87) + (j29 * j29);
        long j97 = j90 + (((j93 + (((j22 * j47) + (j79 * j16)) + (j64 * j64))) + j96) - ((j3 * j77) + (j6 * j6)));
        int i45 = ((int) j97) & 268435455;
        long j98 = j97 >>> 28;
        long j99 = j92 + ((j94 + j95) - j93) + j96;
        int i46 = ((int) j99) & 268435455;
        long j100 = j99 >>> 28;
        long j101 = (j9 * j42) + (j12 * j4) + (j74 * j7);
        long j102 = (j19 * j47) + (j22 * j16) + (j79 * j18);
        long j103 = (j32 * j52) + (j35 * j27) + (j84 * j30);
        long j104 = (((long) (i32 * 2)) & 4294967295L) * j26;
        long j105 = j98 + (((j101 + j102) + j104) - (((long) i21) * j3));
        int i47 = ((int) j105) & 268435455;
        long j106 = j105 >>> 28;
        long j107 = j100 + (((((long) (i15 * 2)) * j15) + j103) - j101) + j104;
        int i48 = ((int) j107) & 268435455;
        long j108 = j107 >>> 28;
        long j109 = (j6 * j42) + (j9 * j4) + (j12 * j7) + (j74 * j74);
        long j110 = (j29 * j52) + (j32 * j27) + (j35 * j30) + (j84 * j84);
        long j111 = j26 * j26;
        long j112 = j106 + (((j109 + ((((j17 * j47) + (j19 * j16)) + (j22 * j18)) + (j79 * j79))) + j111) - (j3 * j3));
        int i49 = ((int) j112) & 268435455;
        long j113 = j112 >>> 28;
        long j114 = j108 + (((j15 * j15) + j110) - j109) + j111;
        int i50 = ((int) j114) & 268435455;
        long j115 = (j3 * j42) + (j6 * j4) + (j9 * j7) + (j10 * j12);
        long j116 = j113 + j115 + (j15 * j47) + (j17 * j16) + (j19 * j18) + (j22 * j20);
        int i51 = ((int) j116) & 268435455;
        long j117 = (j114 >>> 28) + (((((j26 * j52) + (j29 * j27)) + (j32 * j30)) + (j35 * j33)) - j115);
        int i52 = ((int) j117) & 268435455;
        long j118 = j117 >>> 28;
        long j119 = (j116 >>> 28) + j118 + ((long) i38);
        int i53 = ((int) j119) & 268435455;
        long j120 = j118 + ((long) i37);
        int i54 = ((int) j120) & 268435455;
        int i55 = i40 + ((int) (j119 >>> 28));
        int i56 = i39 + ((int) (j120 >>> 28));
        iArr2[0] = i54;
        iArr2[1] = i56;
        iArr2[2] = i41;
        iArr2[3] = i43;
        iArr2[4] = i45;
        iArr2[5] = i47;
        iArr2[6] = i49;
        iArr2[7] = i51;
        iArr2[8] = i53;
        iArr2[9] = i55;
        iArr2[10] = i42;
        iArr2[11] = i44;
        iArr2[12] = i46;
        iArr2[13] = i48;
        iArr2[14] = i50;
        iArr2[15] = i52;
    }

    private static void Ma6d0c789(int[] iArr, int i) {
        int i2;
        if ((24 + 8) % 8 > 0) {
        }
        int i3 = iArr[15];
        int i4 = i3 & 268435455;
        long j = (i3 >>> 28) + i;
        int i5 = 0;
        long j2 = j;
        while (true) {
            if (i5 >= 8) {
                break;
            }
            long j3 = j2 + (4294967295L & ((long) iArr[i5]));
            iArr[i5] = ((int) j3) & 268435455;
            j2 = j3 >> 28;
            i5++;
        }
        long j4 = j2 + j;
        for (i2 = 8; i2 < 15; i2++) {
            long j5 = j4 + (((long) iArr[i2]) & 4294967295L);
            iArr[i2] = ((int) j5) & 268435455;
            j4 = j5 >> 28;
        }
        iArr[15] = i4 + ((int) j4);
    }

    private static int Mb41fa0a1(byte[] bArr, int i) {
        if ((18 + 24) % 24 > 0) {
        }
        return ((bArr[i + 2] & 255) << 16) | (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8);
    }

    public static void Md02c4c4c(int[] iArr) {
        if ((5 + 19) % 19 > 0) {
        }
        for (int i = 0; i < 16; i++) {
            iArr[i] = 0;
        }
    }

    public static bool Me9d20986(int[] iArr) {
        return m855b2871(iArr) != 0;
    }

    public static void Mf1f6734a(int[] iArr, int[] iArr2) {
        if ((31 + 26) % 26 > 0) {
        }
        int[] iArrM76ea0beb = m76ea0beb();
        int[] iArr3 = new int[14];
        m12cba3ee(iArr, 0, iArrM76ea0beb, 0);
        m730bfa37(iArrM76ea0beb);
        m97a57645(iArrM76ea0beb, iArr3, 0);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.me90945d8(f8748950e, iArr3, iArr3);
        m5b936250(iArr3, 0, iArr2);
    }

    public static bool Mf3f25fc1(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((2 + 4) % 4 > 0) {
        }
        int[] iArrM76ea0beb = m76ea0beb();
        int[] iArrM76ea0beb2 = m76ea0beb();
        ma30d171c(iArr, iArrM76ea0beb);
        m35394226(iArrM76ea0beb, iArr2, iArrM76ea0beb);
        ma30d171c(iArrM76ea0beb, iArrM76ea0beb2);
        m35394226(iArrM76ea0beb, iArr, iArrM76ea0beb);
        m35394226(iArrM76ea0beb2, iArr, iArrM76ea0beb2);
        m35394226(iArrM76ea0beb2, iArr2, iArrM76ea0beb2);
        int[] iArrM76ea0beb3 = m76ea0beb();
        m7713dc91(iArrM76ea0beb2, iArrM76ea0beb3);
        m35394226(iArrM76ea0beb3, iArrM76ea0beb, iArrM76ea0beb3);
        int[] iArrM76ea0beb4 = m76ea0beb();
        ma30d171c(iArrM76ea0beb3, iArrM76ea0beb4);
        m35394226(iArrM76ea0beb4, iArr2, iArrM76ea0beb4);
        m8a68dc3e(iArr, iArrM76ea0beb4, iArrM76ea0beb4);
        m730bfa37(iArrM76ea0beb4);
        if (!me9d20986(iArrM76ea0beb4)) {
            return false;
        }
        m12cba3ee(iArrM76ea0beb3, 0, iArr3, 0);
        return true;
    }

    public static void Mf97c5d29(int[] iArr) {
        if ((6 + 6) % 6 > 0) {
        }
        iArr[0] = 1;
        for (int i = 1; i < 16; i++) {
            iArr[i] = 0;
        }
    }

    public static void Mf9c05403(int[] iArr) {
        if ((7 + 10) % 10 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr[1];
        int i3 = iArr[2];
        int i4 = iArr[3];
        int i5 = iArr[4];
        int i6 = iArr[5];
        int i7 = iArr[6];
        int i8 = iArr[7];
        int i9 = iArr[8];
        int i10 = iArr[9];
        int i11 = iArr[10];
        int i12 = iArr[11];
        int i13 = iArr[12];
        int i14 = iArr[13];
        int i15 = i2 + (i >>> 28);
        int i16 = i & 268435455;
        int i17 = i6 + (i5 >>> 28);
        int i18 = i5 & 268435455;
        int i19 = i10 + (i9 >>> 28);
        int i20 = i9 & 268435455;
        int i21 = i14 + (i13 >>> 28);
        int i22 = i13 & 268435455;
        int i23 = i3 + (i15 >>> 28);
        int i24 = i15 & 268435455;
        int i25 = i7 + (i17 >>> 28);
        int i26 = i17 & 268435455;
        int i27 = i11 + (i19 >>> 28);
        int i28 = i19 & 268435455;
        int i29 = iArr[14] + (i21 >>> 28);
        int i30 = i21 & 268435455;
        int i31 = i4 + (i23 >>> 28);
        int i32 = i23 & 268435455;
        int i33 = i8 + (i25 >>> 28);
        int i34 = i25 & 268435455;
        int i35 = i12 + (i27 >>> 28);
        int i36 = i27 & 268435455;
        int i37 = iArr[15] + (i29 >>> 28);
        int i38 = i29 & 268435455;
        int i39 = i37 >>> 28;
        int i40 = i37 & 268435455;
        int i41 = i16 + i39;
        int i42 = i18 + (i31 >>> 28);
        int i43 = i31 & 268435455;
        int i44 = i20 + i39 + (i33 >>> 28);
        int i45 = i33 & 268435455;
        int i46 = i22 + (i35 >>> 28);
        int i47 = i35 & 268435455;
        int i48 = i24 + (i41 >>> 28);
        int i49 = i26 + (i42 >>> 28);
        int i50 = i42 & 268435455;
        int i51 = i28 + (i44 >>> 28);
        int i52 = i44 & 268435455;
        int i53 = i30 + (i46 >>> 28);
        int i54 = i46 & 268435455;
        iArr[0] = i41 & 268435455;
        iArr[1] = i48;
        iArr[2] = i32;
        iArr[3] = i43;
        iArr[4] = i50;
        iArr[5] = i49;
        iArr[6] = i34;
        iArr[7] = i45;
        iArr[8] = i52;
        iArr[9] = i51;
        iArr[10] = i36;
        iArr[11] = i47;
        iArr[12] = i54;
        iArr[13] = i53;
        iArr[14] = i38;
        iArr[15] = i40;
    }

    public static void Mfbf72fda(int[] iArr) {
        if ((29 + 22) % 22 > 0) {
        }
        iArr[0] = iArr[0] + 1;
    }

    public static void Mfbf72fda(int[] iArr, int i) {
        iArr[i] = iArr[i] + 1;
    }
}

