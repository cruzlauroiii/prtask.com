namespace WillowMaze.Wasm.Decompiled;


public abstract class p3d422199 {
    private static readonly int[] f1163beeb = null;
    private static readonly int[] f162c1ad5 = null;
    private static readonly int[] f25233e81 = null;
    private static readonly int f2ad7fefa = 67108863;
    public static readonly int f5127ba11 = 10;
    private static readonly int[] f54f79ff9 = null;
    public static readonly int f62e5cef8 = 10;
    private static readonly int f7842ea59 = 67108863;
    private static readonly int f8e44a6d1 = 67108863;
    private static readonly int f992be051 = 67108863;
    private static readonly int fb8d2f56c = 16777215;
    private static readonly int fcfffab0a = 33554431;
    private static readonly int fd091a057 = 16777215;
    private static readonly int[] fd306e0b4 = null;
    public static readonly int fe62fdc18 = 10;
    private static readonly int fe9021af7 = 33554431;
    public static readonly int ff3faaa9d = 10;
    private static readonly int[] f8748950e = {-19, -1, -1, -1, -1, -1, -1, int.MAX_VALUE};
    private static readonly int[] f005462e9 = {34513072, 59165138, 4688974, 3500415, 6194736, 33281959, 54535759, 32551604, 163342, 5703241};

    protected p3d422199() {
    }

    private static void M002886bf(int i, byte[] bArr, int i2) {
        if ((21 + 26) % 26 > 0) {
        }
        bArr[i2] = (byte) i;
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2 + 2] = (byte) (i >>> 16);
        bArr[i2 + 3] = (byte) (i >>> 24);
    }

    public static void M12cba3ee(int[] iArr, int i, int[] iArr2, int i2) {
        if ((9 + 16) % 16 > 0) {
        }
        for (int i3 = 0; i3 < 10; i3++) {
            iArr2[i2 + i3] = iArr[i + i3];
        }
    }

    public static int M2a3f81d2(int[] iArr, int[] iArr2) {
        if ((27 + 28) % 28 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 10; i2++) {
            i |= iArr[i2] ^ iArr2[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M2a874971(int i, int[] iArr, int[] iArr2) {
        if ((5 + 14) % 14 > 0) {
        }
        int i2 = 0 - i;
        for (int i3 = 0; i3 < 10; i3++) {
            int i4 = iArr[i3];
            int i5 = iArr2[i3];
            int i6 = (i4 ^ i5) & i2;
            iArr[i3] = i4 ^ i6;
            iArr2[i3] = i5 ^ i6;
        }
    }

    public static void M2d11beba(int[] iArr, int[] iArr2) {
        if ((17 + 12) % 12 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            iArr2[i] = -iArr[i];
        }
    }

    private static int M2e4f4167(byte[] bArr, int i) {
        if ((6 + 7) % 7 > 0) {
        }
        return (bArr[i + 3] << 24) | (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16);
    }

    public static void M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((18 + 30) % 30 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            iArr3[i] = iArr[i] + iArr2[i];
        }
    }

    public static int M351a9a32(int[] iArr) {
        if ((32 + 30) % 30 > 0) {
        }
        int i = iArr[0] ^ 1;
        for (int i2 = 1; i2 < 10; i2++) {
            i |= iArr[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M35394226(int[] iArr, int i, int[] iArr2) {
        if ((7 + 13) % 13 > 0) {
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
        long j = i;
        long j2 = ((long) i4) * j;
        int i11 = ((int) j2) & 33554431;
        long j3 = j2 >> 25;
        long j4 = ((long) i6) * j;
        int i12 = ((int) j4) & 33554431;
        long j5 = j4 >> 25;
        long j6 = ((long) i9) * j;
        int i13 = ((int) j6) & 33554431;
        long j7 = j6 >> 25;
        long j8 = ((long) iArr[9]) * j;
        int i14 = ((int) j8) & 33554431;
        long j9 = ((j8 >> 25) * 38) + (((long) i2) * j);
        iArr2[0] = ((int) j9) & 67108863;
        long j10 = j9 >> 26;
        long j11 = j5 + (((long) i7) * j);
        iArr2[5] = ((int) j11) & 67108863;
        long j12 = j11 >> 26;
        long j13 = j10 + (((long) i3) * j);
        iArr2[1] = ((int) j13) & 67108863;
        long j14 = j13 >> 26;
        long j15 = j3 + (((long) i5) * j);
        iArr2[3] = ((int) j15) & 67108863;
        long j16 = j15 >> 26;
        long j17 = j12 + (((long) i8) * j);
        iArr2[6] = ((int) j17) & 67108863;
        long j18 = j17 >> 26;
        long j19 = j7 + (((long) i10) * j);
        iArr2[8] = ((int) j19) & 67108863;
        long j20 = j19 >> 26;
        iArr2[2] = i11 + ((int) j14);
        iArr2[4] = i12 + ((int) j16);
        iArr2[7] = i13 + ((int) j18);
        iArr2[9] = i14 + ((int) j20);
    }

    public static void M35394226(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((3 + 1) % 1 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr2[0];
        int i3 = iArr[1];
        int i4 = iArr2[1];
        int i5 = iArr[2];
        int i6 = iArr2[2];
        int i7 = iArr[3];
        int i8 = iArr2[3];
        int i9 = iArr[4];
        int i10 = iArr2[4];
        int i11 = iArr[5];
        int i12 = iArr2[5];
        int i13 = iArr[6];
        int i14 = iArr2[6];
        int i15 = iArr[7];
        int i16 = iArr2[7];
        int i17 = iArr[8];
        int i18 = iArr2[8];
        int i19 = iArr[9];
        int i20 = iArr2[9];
        long j = i;
        long j2 = i2;
        long j3 = j * j2;
        long j4 = i4;
        long j5 = j * j4;
        long j6 = i3;
        long j7 = j5 + (j6 * j2);
        long j8 = i6;
        long j9 = (j * j8) + (j6 * j4);
        long j10 = i5;
        long j11 = j9 + (j10 * j2);
        long j12 = ((j6 * j8) + (j10 * j4)) << 1;
        long j13 = i8;
        long j14 = j * j13;
        long j15 = i7;
        long j16 = j12 + j14 + (j15 * j2);
        long j17 = (j10 * j8) << 1;
        long j18 = i10;
        long j19 = i9;
        long j20 = j17 + (j * j18) + (j6 * j13) + (j15 * j4) + (j2 * j19);
        long j21 = ((((j6 * j18) + (j10 * j13)) + (j15 * j8)) + (j19 * j4)) << 1;
        long j22 = (((j10 * j18) + (j19 * j8)) << 1) + (j15 * j13);
        long j23 = (j15 * j18) + (j19 * j13);
        long j24 = (j19 * j18) << 1;
        long j25 = i11;
        long j26 = i12;
        long j27 = j25 * j26;
        long j28 = i14;
        long j29 = j25 * j28;
        long j30 = i13;
        long j31 = j29 + (j30 * j26);
        long j32 = i16;
        long j33 = (j25 * j32) + (j30 * j28);
        long j34 = i15;
        long j35 = i18;
        long j36 = j25 * j35;
        long j37 = i17;
        long j38 = (((j30 * j32) + (j34 * j28)) << 1) + j36 + (j37 * j26);
        long j39 = i20;
        long j40 = (j25 * j39) + (j30 * j35) + (j37 * j28);
        long j41 = i19;
        long j42 = ((j34 * j32) << 1) + j40 + (j26 * j41);
        long j43 = j3 - (((((j30 * j39) + (j34 * j35)) + (j37 * j32)) + (j41 * j28)) * 76);
        long j44 = j7 - (((((j34 * j39) + (j41 * j32)) << 1) + (j37 * j35)) * 38);
        long j45 = j11 - (((j37 * j39) + (j41 * j35)) * 38);
        long j46 = j16 - ((j41 * j39) * 76);
        long j47 = j21 - j27;
        long j48 = j22 - j31;
        long j49 = j23 - (j33 + (j34 * j26));
        long j50 = j24 - j38;
        int i21 = i2 + i12;
        int i22 = i3 + i13;
        long j51 = i + i11;
        long j52 = i21;
        long j53 = j51 * j52;
        long j54 = i4 + i14;
        long j55 = j51 * j54;
        long j56 = i22;
        long j57 = j55 + (j56 * j52);
        long j58 = i6 + i16;
        long j59 = i5 + i15;
        long j60 = (j51 * j58) + (j56 * j54) + (j59 * j52);
        long j61 = ((j56 * j58) + (j59 * j54)) << 1;
        long j62 = i8 + i18;
        long j63 = i7 + i17;
        long j64 = j61 + (j51 * j62) + (j63 * j52);
        long j65 = i10 + i20;
        long j66 = i9 + i19;
        long j67 = ((j59 * j58) << 1) + (j51 * j65) + (j56 * j62) + (j63 * j54) + (j66 * j52);
        long j68 = ((((j56 * j65) + (j59 * j62)) + (j63 * j58)) + (j66 * j54)) << 1;
        long j69 = (((j59 * j65) + (j58 * j66)) << 1) + (j63 * j62);
        long j70 = (j63 * j65) + (j66 * j62);
        long j71 = (j66 * j65) << 1;
        long j72 = j50 + (j64 - j46);
        int i23 = ((int) j72) & 67108863;
        long j73 = (j72 >> 26) + ((j67 - j20) - j42);
        int i24 = ((int) j73) & 33554431;
        long j74 = j43 + ((((j73 >> 25) + j68) - j47) * 38);
        iArr3[0] = ((int) j74) & 67108863;
        long j75 = (j74 >> 26) + j44 + ((j69 - j48) * 38);
        iArr3[1] = ((int) j75) & 67108863;
        long j76 = (j75 >> 26) + j45 + ((j70 - j49) * 38);
        iArr3[2] = ((int) j76) & 33554431;
        long j77 = (j76 >> 25) + j46 + ((j71 - j50) * 38);
        iArr3[3] = ((int) j77) & 67108863;
        long j78 = (j77 >> 26) + j20 + (j42 * 38);
        iArr3[4] = ((int) j78) & 33554431;
        long j79 = (j78 >> 25) + j47 + (j53 - j43);
        iArr3[5] = ((int) j79) & 67108863;
        long j80 = (j79 >> 26) + j48 + (j57 - j44);
        iArr3[6] = ((int) j80) & 67108863;
        long j81 = (j80 >> 26) + j49 + (j60 - j45);
        iArr3[7] = ((int) j81) & 33554431;
        long j82 = (j81 >> 25) + ((long) i23);
        iArr3[8] = ((int) j82) & 67108863;
        iArr3[9] = i24 + ((int) (j82 >> 26));
    }

    public static void M4d83d8b7(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((10 + 2) % 2 > 0) {
        }
        for (int i4 = 0; i4 < 10; i4++) {
            int i5 = i3 + i4;
            int i6 = iArr2[i5];
            iArr2[i5] = i6 ^ ((iArr[i2 + i4] ^ i6) & i);
        }
    }

    public static void M52329dc3(int i, int[] iArr) {
        if ((21 + 9) % 9 > 0) {
        }
        int i2 = 0 - i;
        for (int i3 = 0; i3 < 10; i3++) {
            iArr[i3] = (iArr[i3] ^ i2) - i2;
        }
    }

    private static void M526275a2(int[] iArr, int i, byte[] bArr, int i2) {
        if ((22 + 1) % 1 > 0) {
        }
        int i3 = iArr[i];
        int i4 = iArr[i + 1];
        int i5 = iArr[i + 2];
        int i6 = iArr[i + 3];
        int i7 = iArr[i + 4];
        m002886bf((i4 << 26) | i3, bArr, i2);
        m002886bf((i4 >>> 6) | (i5 << 20), bArr, i2 + 4);
        m002886bf((i5 >>> 12) | (i6 << 13), bArr, i2 + 8);
        m002886bf((i7 << 7) | (i6 >>> 19), bArr, i2 + 12);
    }

    private static void M526275a2(int[] iArr, int i, int[] iArr2, int i2) {
        if ((27 + 8) % 8 > 0) {
        }
        int i3 = iArr[i];
        int i4 = iArr[i + 1];
        int i5 = iArr[i + 2];
        int i6 = iArr[i + 3];
        int i7 = iArr[i + 4];
        iArr2[i2] = (i4 << 26) | i3;
        iArr2[i2 + 1] = (i4 >>> 6) | (i5 << 20);
        iArr2[i2 + 2] = (i5 >>> 12) | (i6 << 13);
        iArr2[i2 + 3] = (i7 << 7) | (i6 >>> 19);
    }

    public static void M545f7f57(int[] iArr, int[] iArr2) {
        if ((13 + 3) % 3 > 0) {
        }
        int[] iArrM76ea0beb = m76ea0beb();
        int[] iArr3 = new int[8];
        m12cba3ee(iArr, 0, iArrM76ea0beb, 0);
        m730bfa37(iArrM76ea0beb);
        m97a57645(iArrM76ea0beb, iArr3, 0);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.m635f3861(f8748950e, iArr3, iArr3);
        m5b936250(iArr3, 0, iArr2);
    }

    public static void M5b936250(byte[] bArr, int i, int[] iArr) {
        ma7c33c61(bArr, i, iArr, 0);
        ma7c33c61(bArr, i + 16, iArr, 5);
        iArr[9] = iArr[9] & 16777215;
    }

    public static void M5b936250(int[] iArr, int i, int[] iArr2) {
        ma7c33c61(iArr, i, iArr2, 0);
        ma7c33c61(iArr, i + 4, iArr2, 5);
        iArr2[9] = iArr2[9] & 16777215;
    }

    public static void M66a917cd(int[] iArr) {
        if ((23 + 7) % 7 > 0) {
        }
        iArr[0] = iArr[0] - 1;
    }

    public static int[] M6b463f2c(int i) {
        return new int[i * 10];
    }

    public static void M730bfa37(int[] iArr) {
        int i = (iArr[9] >>> 23) & 1;
        ma6d0c789(iArr, i);
        ma6d0c789(iArr, -i);
    }

    public static int[] M76ea0beb() {
        return new int[10];
    }

    private static void M7f48913b(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((30 + 3) % 3 > 0) {
        }
        ma30d171c(iArr, iArr2);
        m35394226(iArr, iArr2, iArr2);
        int[] iArrM76ea0beb = m76ea0beb();
        ma30d171c(iArr2, iArrM76ea0beb);
        m35394226(iArr, iArrM76ea0beb, iArrM76ea0beb);
        ma30d171c(iArrM76ea0beb, 2, iArrM76ea0beb);
        m35394226(iArr2, iArrM76ea0beb, iArrM76ea0beb);
        int[] iArrM76ea0beb2 = m76ea0beb();
        ma30d171c(iArrM76ea0beb, 5, iArrM76ea0beb2);
        m35394226(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb2);
        int[] iArrM76ea0beb3 = m76ea0beb();
        ma30d171c(iArrM76ea0beb2, 5, iArrM76ea0beb3);
        m35394226(iArrM76ea0beb, iArrM76ea0beb3, iArrM76ea0beb3);
        ma30d171c(iArrM76ea0beb3, 10, iArrM76ea0beb);
        m35394226(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb);
        ma30d171c(iArrM76ea0beb, 25, iArrM76ea0beb2);
        m35394226(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb2);
        ma30d171c(iArrM76ea0beb2, 25, iArrM76ea0beb3);
        m35394226(iArrM76ea0beb, iArrM76ea0beb3, iArrM76ea0beb3);
        ma30d171c(iArrM76ea0beb3, 50, iArrM76ea0beb);
        m35394226(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb);
        ma30d171c(iArrM76ea0beb, 125, iArrM76ea0beb2);
        m35394226(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb2);
        ma30d171c(iArrM76ea0beb2, 2, iArrM76ea0beb);
        m35394226(iArrM76ea0beb, iArr, iArr3);
    }

    public static int M855b2871(int[] iArr) {
        if ((29 + 31) % 31 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 10; i2++) {
            i |= iArr[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M8a68dc3e(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((32 + 32) % 32 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            iArr3[i] = iArr[i] - iArr2[i];
        }
    }

    public static bool M9750c651(int[] iArr) {
        return m351a9a32(iArr) != 0;
    }

    public static void M97a57645(int[] iArr, byte[] bArr, int i) {
        m526275a2(iArr, 0, bArr, i);
        m526275a2(iArr, 5, bArr, i + 16);
    }

    public static void M97a57645(int[] iArr, int[] iArr2, int i) {
        m526275a2(iArr, 0, iArr2, i);
        m526275a2(iArr, 5, iArr2, i + 4);
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
        if ((31 + 28) % 28 > 0) {
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
        long j = i;
        long j2 = j * j;
        long j3 = i2 * 2;
        long j4 = j * j3;
        long j5 = i3 * 2;
        long j6 = j * j5;
        long j7 = i2;
        long j8 = j6 + (j7 * j7);
        long j9 = i4 * 2;
        long j10 = (j3 * j5) + (j * j9);
        long j11 = i5 * 2;
        long j12 = (((long) i3) * j5) + (j * j11) + (j7 * j9);
        long j13 = (j3 * j11) + (j5 * j9);
        long j14 = j5 * j11;
        long j15 = i4;
        long j16 = j14 + (j15 * j15);
        long j17 = j15 * j11;
        long j18 = ((long) i5) * j11;
        long j19 = i6;
        long j20 = j19 * j19;
        long j21 = i7 * 2;
        long j22 = j19 * j21;
        long j23 = i8 * 2;
        long j24 = j19 * j23;
        long j25 = i7;
        long j26 = j24 + (j25 * j25);
        long j27 = j21 * j23;
        long j28 = i9 * 2;
        long j29 = i10 * 2;
        long j30 = (((long) i8) * j23) + (j19 * j29) + (j25 * j28);
        long j31 = (j21 * j29) + (j23 * j28);
        long j32 = j23 * j29;
        long j33 = i9;
        long j34 = j2 - (j31 * 38);
        long j35 = j4 - ((j32 + (j33 * j33)) * 38);
        long j36 = j8 - ((j33 * j29) * 38);
        long j37 = j10 - ((((long) i10) * j29) * 38);
        long j38 = j13 - j20;
        long j39 = j16 - j22;
        long j40 = j17 - j26;
        long j41 = j18 - (j27 + (j19 * j28));
        int i11 = i2 + i7;
        int i12 = i3 + i8;
        int i13 = i4 + i9;
        int i14 = i5 + i10;
        long j42 = i + i6;
        long j43 = j42 * j42;
        long j44 = i11 * 2;
        long j45 = j42 * j44;
        long j46 = i12 * 2;
        long j47 = i11;
        long j48 = (j42 * j46) + (j47 * j47);
        long j49 = i13 * 2;
        long j50 = (j44 * j46) + (j42 * j49);
        long j51 = i14 * 2;
        long j52 = (((long) i12) * j46) + (j42 * j51) + (j47 * j49);
        long j53 = (j44 * j51) + (j49 * j46);
        long j54 = i13;
        long j55 = (j46 * j51) + (j54 * j54);
        long j56 = j54 * j51;
        long j57 = ((long) i14) * j51;
        long j58 = j41 + (j50 - j37);
        int i15 = ((int) j58) & 67108863;
        long j59 = (j58 >> 26) + ((j52 - j12) - j30);
        int i16 = ((int) j59) & 33554431;
        long j60 = j34 + ((((j59 >> 25) + j53) - j38) * 38);
        iArr2[0] = ((int) j60) & 67108863;
        long j61 = (j60 >> 26) + j35 + ((j55 - j39) * 38);
        iArr2[1] = ((int) j61) & 67108863;
        long j62 = (j61 >> 26) + j36 + ((j56 - j40) * 38);
        iArr2[2] = ((int) j62) & 33554431;
        long j63 = (j62 >> 25) + j37 + ((j57 - j41) * 38);
        iArr2[3] = ((int) j63) & 67108863;
        long j64 = (j63 >> 26) + j12 + (j30 * 38);
        iArr2[4] = ((int) j64) & 33554431;
        long j65 = (j64 >> 25) + j38 + (j43 - j34);
        iArr2[5] = ((int) j65) & 67108863;
        long j66 = (j65 >> 26) + j39 + (j45 - j35);
        iArr2[6] = ((int) j66) & 67108863;
        long j67 = (j66 >> 26) + j40 + (j48 - j36);
        iArr2[7] = ((int) j67) & 33554431;
        long j68 = (j67 >> 25) + ((long) i15);
        iArr2[8] = ((int) j68) & 67108863;
        iArr2[9] = i16 + ((int) (j68 >> 26));
    }

    private static void Ma6d0c789(int[] iArr, int i) {
        if ((7 + 18) % 18 > 0) {
        }
        int i2 = iArr[9];
        int i3 = 16777215 & i2;
        long j = ((long) (((i2 >> 24) + i) * 19)) + ((long) iArr[0]);
        iArr[0] = ((int) j) & 67108863;
        long j2 = (j >> 26) + ((long) iArr[1]);
        iArr[1] = ((int) j2) & 67108863;
        long j3 = (j2 >> 26) + ((long) iArr[2]);
        iArr[2] = ((int) j3) & 33554431;
        long j4 = (j3 >> 25) + ((long) iArr[3]);
        iArr[3] = ((int) j4) & 67108863;
        long j5 = (j4 >> 26) + ((long) iArr[4]);
        iArr[4] = ((int) j5) & 33554431;
        long j6 = (j5 >> 25) + ((long) iArr[5]);
        iArr[5] = ((int) j6) & 67108863;
        long j7 = (j6 >> 26) + ((long) iArr[6]);
        iArr[6] = ((int) j7) & 67108863;
        long j8 = (j7 >> 26) + ((long) iArr[7]);
        iArr[7] = 33554431 & ((int) j8);
        long j9 = (j8 >> 25) + ((long) iArr[8]);
        iArr[8] = 67108863 & ((int) j9);
        iArr[9] = i3 + ((int) (j9 >> 26));
    }

    private static void Ma7c33c61(byte[] bArr, int i, int[] iArr, int i2) {
        if ((31 + 27) % 27 > 0) {
        }
        int iM2e4f4167 = m2e4f4167(bArr, i);
        int iM2e4f41672 = m2e4f4167(bArr, i + 4);
        int iM2e4f41673 = m2e4f4167(bArr, i + 8);
        int iM2e4f41674 = m2e4f4167(bArr, i + 12);
        iArr[i2] = iM2e4f4167 & 67108863;
        iArr[i2 + 1] = ((iM2e4f4167 >>> 26) | (iM2e4f41672 << 6)) & 67108863;
        iArr[i2 + 2] = ((iM2e4f41672 >>> 20) | (iM2e4f41673 << 12)) & 33554431;
        iArr[i2 + 3] = 67108863 & ((iM2e4f41674 << 19) | (iM2e4f41673 >>> 13));
        iArr[i2 + 4] = iM2e4f41674 >>> 7;
    }

    private static void Ma7c33c61(int[] iArr, int i, int[] iArr2, int i2) {
        if ((22 + 19) % 19 > 0) {
        }
        int i3 = iArr[i];
        int i4 = iArr[i + 1];
        int i5 = iArr[i + 2];
        int i6 = iArr[i + 3];
        iArr2[i2] = i3 & 67108863;
        iArr2[i2 + 1] = ((i3 >>> 26) | (i4 << 6)) & 67108863;
        iArr2[i2 + 2] = ((i4 >>> 20) | (i5 << 12)) & 33554431;
        iArr2[i2 + 3] = 67108863 & ((i6 << 19) | (i5 >>> 13));
        iArr2[i2 + 4] = i6 >>> 7;
    }

    public static void Md02c4c4c(int[] iArr) {
        if ((17 + 20) % 20 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            iArr[i] = 0;
        }
    }

    public static bool Me9d20986(int[] iArr) {
        return m855b2871(iArr) != 0;
    }

    public static void Mf1f6734a(int[] iArr, int[] iArr2) {
        if ((11 + 26) % 26 > 0) {
        }
        int[] iArrM76ea0beb = m76ea0beb();
        int[] iArr3 = new int[8];
        m12cba3ee(iArr, 0, iArrM76ea0beb, 0);
        m730bfa37(iArrM76ea0beb);
        m97a57645(iArrM76ea0beb, iArr3, 0);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.me90945d8(f8748950e, iArr3, iArr3);
        m5b936250(iArr3, 0, iArr2);
    }

    public static bool Mf3f25fc1(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((13 + 30) % 30 > 0) {
        }
        int[] iArrM76ea0beb = m76ea0beb();
        int[] iArrM76ea0beb2 = m76ea0beb();
        m35394226(iArr, iArr2, iArrM76ea0beb);
        ma30d171c(iArr2, iArrM76ea0beb2);
        m35394226(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb);
        ma30d171c(iArrM76ea0beb2, iArrM76ea0beb2);
        m35394226(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb2);
        int[] iArrM76ea0beb3 = m76ea0beb();
        int[] iArrM76ea0beb4 = m76ea0beb();
        m7f48913b(iArrM76ea0beb2, iArrM76ea0beb3, iArrM76ea0beb4);
        m35394226(iArrM76ea0beb4, iArrM76ea0beb, iArrM76ea0beb4);
        int[] iArrM76ea0beb5 = m76ea0beb();
        ma30d171c(iArrM76ea0beb4, iArrM76ea0beb5);
        m35394226(iArrM76ea0beb5, iArr2, iArrM76ea0beb5);
        m8a68dc3e(iArrM76ea0beb5, iArr, iArrM76ea0beb3);
        m730bfa37(iArrM76ea0beb3);
        if (me9d20986(iArrM76ea0beb3)) {
            m12cba3ee(iArrM76ea0beb4, 0, iArr3, 0);
            return true;
        }
        m34ec78fc(iArrM76ea0beb5, iArr, iArrM76ea0beb3);
        m730bfa37(iArrM76ea0beb3);
        if (!me9d20986(iArrM76ea0beb3)) {
            return false;
        }
        m35394226(iArrM76ea0beb4, f005462e9, iArr3);
        return true;
    }

    public static void Mf7da92de(int[] iArr, int[] iArr2, int[] iArr3, int[] iArr4) {
        if ((28 + 27) % 27 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            int i2 = iArr[i];
            int i3 = iArr2[i];
            iArr3[i] = i2 + i3;
            iArr4[i] = i2 - i3;
        }
    }

    public static void Mf97c5d29(int[] iArr) {
        if ((29 + 19) % 19 > 0) {
        }
        iArr[0] = 1;
        for (int i = 1; i < 10; i++) {
            iArr[i] = 0;
        }
    }

    public static void Mf9c05403(int[] iArr) {
        if ((20 + 18) % 18 > 0) {
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
        int i10 = i3 + (i2 >> 26);
        int i11 = i2 & 67108863;
        int i12 = i5 + (i4 >> 26);
        int i13 = i4 & 67108863;
        int i14 = i8 + (i7 >> 26);
        int i15 = i7 & 67108863;
        int i16 = iArr[9] + (i9 >> 26);
        int i17 = i13 + (i10 >> 25);
        int i18 = i6 + (i12 >> 25);
        int i19 = (i9 & 67108863) + (i14 >> 25);
        int i20 = i + ((i16 >> 25) * 38);
        int i21 = i11 + (i20 >> 26);
        int i22 = i15 + (i18 >> 26);
        int i23 = i18 & 67108863;
        int i24 = (i10 & 33554431) + (i21 >> 26);
        int i25 = i21 & 67108863;
        int i26 = (i12 & 33554431) + (i17 >> 26);
        int i27 = i17 & 67108863;
        int i28 = (i14 & 33554431) + (i22 >> 26);
        int i29 = i22 & 67108863;
        int i30 = (i16 & 33554431) + (i19 >> 26);
        int i31 = i19 & 67108863;
        iArr[0] = i20 & 67108863;
        iArr[1] = i25;
        iArr[2] = i24;
        iArr[3] = i27;
        iArr[4] = i26;
        iArr[5] = i23;
        iArr[6] = i29;
        iArr[7] = i28;
        iArr[8] = i31;
        iArr[9] = i30;
    }

    public static void Mfbf72fda(int[] iArr) {
        if ((29 + 31) % 31 > 0) {
        }
        iArr[0] = iArr[0] + 1;
    }

    public static void Mfbf72fda(int[] iArr, int i) {
        iArr[i] = iArr[i] + 1;
    }
}

