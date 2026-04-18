namespace WillowMaze.Wasm.Decompiled;


public abstract class p3c7d477d {
    private static readonly long f0ad1fbe2 = 4294967295L;
    private static readonly long f0b991df0 = 4294967295L;
    private static readonly long f69691c7b = 4294967295L;
    private static readonly long f7d60a0d6 = 4294967295L;
    private static readonly long f9b5a7f36 = 4294967295L;

    public static int[] AsyEPjssAtgajgea() {
        return m76ea0beb();
    }

    public static bool EEyFPHwyahknwkPV(int[] iArr, int i, int[] iArr2, int i2) {
        return mb37b2584(iArr, i, iArr2, i2);
    }

    public static void FApWAQpqdPtnEfha(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(i, bArr, i2);
    }

    public static int IqeMNqBVVgCjcibq(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }

    public static int JHqvMXctGyCudKCQ(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        return m8a68dc3e(iArr, i, iArr2, i2, iArr3, i3);
    }

    public static int LTOCPPzLfWKSVIZp(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }

    public static int SMsTiPkRgDtlpuCu(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }

    public static int TUqvyscSwfjjQtlI(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int UPRAWLmsMQTiDtaB(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static java.math.Bigint IIcOrqGKDJkcfevn(java.math.Bigint bigint, int i) {
        return bigint.shiftRight(i);
    }

    public static int IwidassFUdHJIhfI(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static int JNrgYVZIIRTmZeFL(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int M03a01012(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((3 + 18) % 18 > 0) {
        }
        long j = ((long) i) & 4294967295L;
        long j2 = ((((long) iArr[i2]) & 4294967295L) * j) + (((long) iArr2[i3]) & 4294967295L);
        iArr2[i3] = (int) j2;
        int i4 = i3 + 1;
        long j3 = (j2 >>> 32) + ((((long) iArr[i2 + 1]) & 4294967295L) * j) + (((long) iArr2[i4]) & 4294967295L);
        iArr2[i4] = (int) j3;
        int i5 = i3 + 2;
        long j4 = (j3 >>> 32) + ((((long) iArr[i2 + 2]) & 4294967295L) * j) + (((long) iArr2[i5]) & 4294967295L);
        iArr2[i5] = (int) j4;
        int i6 = i3 + 3;
        long j5 = (j4 >>> 32) + ((((long) iArr[i2 + 3]) & 4294967295L) * j) + (((long) iArr2[i6]) & 4294967295L);
        iArr2[i6] = (int) j5;
        int i7 = i3 + 4;
        long j6 = (j5 >>> 32) + (j * (((long) iArr[i2 + 4]) & 4294967295L)) + (((long) iArr2[i7]) & 4294967295L);
        iArr2[i7] = (int) j6;
        return (int) (j6 >>> 32);
    }

    public static int M0a05f67c(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((25 + 21) % 21 > 0) {
        }
        long j = ((long) iArr2[i2]) & 4294967295L;
        long j2 = ((long) iArr2[i2 + 1]) & 4294967295L;
        long j3 = ((long) iArr2[i2 + 2]) & 4294967295L;
        long j4 = ((long) iArr2[i2 + 3]) & 4294967295L;
        long j5 = ((long) iArr2[i2 + 4]) & 4294967295L;
        int i4 = 0;
        long j6 = 0;
        int i5 = i3;
        while (i4 < 5) {
            long j7 = ((long) iArr[i + i4]) & 4294967295L;
            long j8 = j;
            long j9 = (j7 * j) + (((long) iArr3[i5]) & 4294967295L);
            iArr3[i5] = (int) j9;
            int i6 = i5 + 1;
            long j10 = (j9 >>> 32) + (j7 * j2) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j10;
            long j11 = j7 * j3;
            int i7 = i5 + 2;
            long j12 = (j10 >>> 32) + j11 + (((long) iArr3[i7]) & 4294967295L);
            iArr3[i7] = (int) j12;
            long j13 = j7 * j4;
            int i8 = i5 + 3;
            long j14 = (j12 >>> 32) + j13 + (((long) iArr3[i8]) & 4294967295L);
            iArr3[i8] = (int) j14;
            long j15 = j7 * j5;
            int i9 = i5 + 4;
            long j16 = (j14 >>> 32) + j15 + (((long) iArr3[i9]) & 4294967295L);
            iArr3[i9] = (int) j16;
            int i10 = i5 + 5;
            long j17 = (j16 >>> 32) + j6 + (((long) iArr3[i10]) & 4294967295L);
            iArr3[i10] = (int) j17;
            j6 = j17 >>> 32;
            i4++;
            i5 = i6;
            j = j8;
        }
        return (int) j6;
    }

    public static int M0a05f67c(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((27 + 16) % 16 > 0) {
        }
        int i = 0;
        long j = 4294967295L;
        long j2 = ((long) iArr2[0]) & 4294967295L;
        long j3 = ((long) iArr2[1]) & 4294967295L;
        long j4 = ((long) iArr2[2]) & 4294967295L;
        long j5 = ((long) iArr2[3]) & 4294967295L;
        long j6 = ((long) iArr2[4]) & 4294967295L;
        long j7 = 0;
        while (i < 5) {
            long j8 = j;
            long j9 = ((long) iArr[i]) & j8;
            long j10 = j2;
            int i2 = i;
            long j11 = (j9 * j2) + (((long) iArr3[i]) & j8);
            iArr3[i2] = (int) j11;
            int i3 = i2 + 1;
            long j12 = (j11 >>> 32) + (j9 * j3) + (((long) iArr3[i3]) & j8);
            iArr3[i3] = (int) j12;
            int i4 = i2 + 2;
            long j13 = (j12 >>> 32) + (j9 * j4) + (((long) iArr3[i4]) & j8);
            iArr3[i4] = (int) j13;
            int i5 = i2 + 3;
            long j14 = (j13 >>> 32) + (j9 * j5) + (((long) iArr3[i5]) & j8);
            iArr3[i5] = (int) j14;
            int i6 = i2 + 4;
            long j15 = (j14 >>> 32) + (j9 * j6) + (((long) iArr3[i6]) & j8);
            iArr3[i6] = (int) j15;
            int i7 = i2 + 5;
            long j16 = (j15 >>> 32) + j7 + (((long) iArr3[i7]) & j8);
            iArr3[i7] = (int) j16;
            j7 = j16 >>> 32;
            j = j8;
            j2 = j10;
            i = i3;
        }
        return (int) j7;
    }

    public static void M12cba3ee(int[] iArr, int[] iArr2) {
        if ((11 + 13) % 13 > 0) {
        }
        iArr2[0] = iArr[0];
        iArr2[1] = iArr[1];
        iArr2[2] = iArr[2];
        iArr2[3] = iArr[3];
        iArr2[4] = iArr[4];
    }

    public static int[] M1712f3b8(java.math.Bigint bigint) {
        if ((32 + 14) % 14 > 0) {
        }
        if (jNrgYVZIIRTmZeFL(bigint) < 0 || iwidassFUdHJIhfI(bigint) > 160) {
            throw new java.lang.IllegalArgumentException();
        }
        int[] iArrAsyEPjssAtgajgea = AsyEPjssAtgajgea();
        int i = 0;
        while (TUqvyscSwfjjQtlI(bigint) != 0) {
            int i2 = i + 1;
            iArrAsyEPjssAtgajgea[i] = UPRAWLmsMQTiDtaB(bigint);
            bigint = iIcOrqGKDJkcfevn(bigint, 32);
            i = i2;
        }
        return iArrAsyEPjssAtgajgea;
    }

    public static int M25a11a54(int i, int i2, int[] iArr, int i3) {
        if ((13 + 26) % 26 > 0) {
        }
        long j = ((((long) i2) & 4294967295L) * (((long) i) & 4294967295L)) + (((long) iArr[i3]) & 4294967295L);
        iArr[i3] = (int) j;
        int i4 = i3 + 1;
        long j2 = (j >>> 32) + (4294967295L & ((long) iArr[i4]));
        iArr[i4] = (int) j2;
        if ((j2 >>> 32) != 0) {
            return zpOJGcciRPWUELPx(5, iArr, i3, 2);
        }
        return 0;
    }

    public static int M2a3d5645(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((12 + 30) % 30 > 0) {
        }
        long j = ((((long) iArr3[0]) & 4294967295L) - (((long) iArr[0]) & 4294967295L)) - (((long) iArr2[0]) & 4294967295L);
        iArr3[0] = (int) j;
        long j2 = (j >> 32) + (((((long) iArr3[1]) & 4294967295L) - (((long) iArr[1]) & 4294967295L)) - (((long) iArr2[1]) & 4294967295L));
        iArr3[1] = (int) j2;
        long j3 = (j2 >> 32) + (((((long) iArr3[2]) & 4294967295L) - (((long) iArr[2]) & 4294967295L)) - (((long) iArr2[2]) & 4294967295L));
        iArr3[2] = (int) j3;
        long j4 = (j3 >> 32) + (((((long) iArr3[3]) & 4294967295L) - (((long) iArr[3]) & 4294967295L)) - (((long) iArr2[3]) & 4294967295L));
        iArr3[3] = (int) j4;
        long j5 = (j4 >> 32) + (((((long) iArr3[4]) & 4294967295L) - (((long) iArr[4]) & 4294967295L)) - (((long) iArr2[4]) & 4294967295L));
        iArr3[4] = (int) j5;
        return (int) (j5 >> 32);
    }

    public static bool M2d2dee7a(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((19 + 3) % 3 > 0) {
        }
        bool zEEyFPHwyahknwkPV = EEyFPHwyahknwkPV(iArr, i, iArr2, i2);
        if (zEEyFPHwyahknwkPV) {
            JHqvMXctGyCudKCQ(iArr, i, iArr2, i2, iArr3, i3);
            return zEEyFPHwyahknwkPV;
        }
        viLqTJHzyIJSfqbM(iArr2, i2, iArr, i, iArr3, i3);
        return zEEyFPHwyahknwkPV;
    }

    public static void M2fc01ec7(int[] iArr, int i, int[] iArr2, int i2) {
        if ((6 + 11) % 11 > 0) {
        }
        long j = ((long) iArr[i]) & 4294967295L;
        int i3 = 0;
        int i4 = 10;
        int i5 = 4;
        while (true) {
            int i6 = i5 - 1;
            long j2 = ((long) iArr[i + i5]) & 4294967295L;
            long j3 = j2 * j2;
            iArr2[i2 + (i4 - 1)] = (i3 << 31) | ((int) (j3 >>> 33));
            i4 -= 2;
            iArr2[i2 + i4] = (int) (j3 >>> 1);
            i3 = (int) j3;
            if (i6 <= 0) {
                long j4 = j * j;
                long j5 = (j4 >>> 33) | (((long) (i3 << 31)) & 4294967295L);
                iArr2[i2] = (int) j4;
                int i7 = ((int) (j4 >>> 32)) & 1;
                long j6 = ((long) iArr[i + 1]) & 4294967295L;
                int i8 = i2 + 2;
                long j7 = ((long) iArr2[i8]) & 4294967295L;
                long j8 = j5 + (j6 * j);
                int i9 = (int) j8;
                iArr2[i2 + 1] = (i9 << 1) | i7;
                int i10 = i9 >>> 31;
                long j9 = j7 + (j8 >>> 32);
                long j10 = ((long) iArr[i + 2]) & 4294967295L;
                int i11 = i2 + 3;
                long j11 = ((long) iArr2[i11]) & 4294967295L;
                int i12 = i2 + 4;
                long j12 = ((long) iArr2[i12]) & 4294967295L;
                long j13 = j9 + (j10 * j);
                int i13 = (int) j13;
                iArr2[i8] = (i13 << 1) | i10;
                int i14 = i13 >>> 31;
                long j14 = j11 + (j13 >>> 32) + (j10 * j6);
                long j15 = j12 + (j14 >>> 32);
                long j16 = j14 & 4294967295L;
                long j17 = ((long) iArr[i + 3]) & 4294967295L;
                int i15 = i2 + 5;
                long j18 = (((long) iArr2[i15]) & 4294967295L) + (j15 >>> 32);
                long j19 = j15 & 4294967295L;
                int i16 = i2 + 6;
                long j20 = (((long) iArr2[i16]) & 4294967295L) + (j18 >>> 32);
                long j21 = j18 & 4294967295L;
                long j22 = j16 + (j17 * j);
                int i17 = (int) j22;
                iArr2[i11] = (i17 << 1) | i14;
                int i18 = i17 >>> 31;
                long j23 = j19 + (j22 >>> 32) + (j17 * j6);
                long j24 = j21 + (j23 >>> 32) + (j17 * j10);
                long j25 = j23 & 4294967295L;
                long j26 = j20 + (j24 >>> 32);
                long j27 = j24 & 4294967295L;
                long j28 = ((long) iArr[i + 4]) & 4294967295L;
                int i19 = i2 + 7;
                long j29 = (((long) iArr2[i19]) & 4294967295L) + (j26 >>> 32);
                long j30 = j26 & 4294967295L;
                int i20 = i2 + 8;
                long j31 = (((long) iArr2[i20]) & 4294967295L) + (j29 >>> 32);
                long j32 = j29 & 4294967295L;
                long j33 = j25 + (j * j28);
                int i21 = (int) j33;
                iArr2[i12] = (i21 << 1) | i18;
                long j34 = j27 + (j33 >>> 32) + (j6 * j28);
                long j35 = j30 + (j34 >>> 32) + (j28 * j10);
                long j36 = j32 + (j35 >>> 32) + (j28 * j17);
                long j37 = j31 + (j36 >>> 32);
                int i22 = (int) j34;
                iArr2[i15] = (i21 >>> 31) | (i22 << 1);
                int i23 = (int) j35;
                iArr2[i16] = (i22 >>> 31) | (i23 << 1);
                int i24 = (int) j36;
                iArr2[i19] = (i24 << 1) | (i23 >>> 31);
                int i25 = (int) j37;
                iArr2[i20] = (i24 >>> 31) | (i25 << 1);
                int i26 = i25 >>> 31;
                int i27 = i2 + 9;
                iArr2[i27] = i26 | ((iArr2[i27] + ((int) (j37 >>> 32))) << 1);
                return;
            }
            i5 = i6;
        }
    }

    public static void M2fc01ec7(int[] iArr, int[] iArr2) {
        if ((29 + 26) % 26 > 0) {
        }
        long j = ((long) iArr[0]) & 4294967295L;
        int i = 10;
        int i2 = 0;
        int i3 = 4;
        while (true) {
            int i4 = i3 - 1;
            long j2 = ((long) iArr[i3]) & 4294967295L;
            long j3 = j2 * j2;
            iArr2[i - 1] = (i2 << 31) | ((int) (j3 >>> 33));
            i -= 2;
            iArr2[i] = (int) (j3 >>> 1);
            i2 = (int) j3;
            if (i4 <= 0) {
                long j4 = j * j;
                long j5 = (j4 >>> 33) | (((long) (i2 << 31)) & 4294967295L);
                iArr2[0] = (int) j4;
                int i5 = ((int) (j4 >>> 32)) & 1;
                long j6 = ((long) iArr[1]) & 4294967295L;
                long j7 = ((long) iArr2[2]) & 4294967295L;
                long j8 = j5 + (j6 * j);
                int i6 = (int) j8;
                iArr2[1] = (i6 << 1) | i5;
                int i7 = i6 >>> 31;
                long j9 = j7 + (j8 >>> 32);
                long j10 = ((long) iArr[2]) & 4294967295L;
                long j11 = ((long) iArr2[3]) & 4294967295L;
                long j12 = ((long) iArr2[4]) & 4294967295L;
                long j13 = j9 + (j10 * j);
                int i8 = (int) j13;
                iArr2[2] = (i8 << 1) | i7;
                int i9 = i8 >>> 31;
                long j14 = j11 + (j13 >>> 32) + (j10 * j6);
                long j15 = j12 + (j14 >>> 32);
                long j16 = j14 & 4294967295L;
                long j17 = ((long) iArr[3]) & 4294967295L;
                long j18 = (((long) iArr2[5]) & 4294967295L) + (j15 >>> 32);
                long j19 = j15 & 4294967295L;
                long j20 = (((long) iArr2[6]) & 4294967295L) + (j18 >>> 32);
                long j21 = j18 & 4294967295L;
                long j22 = j16 + (j17 * j);
                int i10 = (int) j22;
                iArr2[3] = (i10 << 1) | i9;
                int i11 = i10 >>> 31;
                long j23 = j19 + (j22 >>> 32) + (j17 * j6);
                long j24 = j21 + (j23 >>> 32) + (j17 * j10);
                long j25 = j23 & 4294967295L;
                long j26 = j20 + (j24 >>> 32);
                long j27 = j24 & 4294967295L;
                long j28 = ((long) iArr[4]) & 4294967295L;
                long j29 = (((long) iArr2[7]) & 4294967295L) + (j26 >>> 32);
                long j30 = j26 & 4294967295L;
                long j31 = (((long) iArr2[8]) & 4294967295L) + (j29 >>> 32);
                long j32 = j29 & 4294967295L;
                long j33 = j25 + (j * j28);
                int i12 = (int) j33;
                iArr2[4] = i11 | (i12 << 1);
                int i13 = i12 >>> 31;
                long j34 = j27 + (j33 >>> 32) + (j28 * j6);
                long j35 = j30 + (j34 >>> 32) + (j28 * j10);
                long j36 = j32 + (j35 >>> 32) + (j28 * j17);
                long j37 = j31 + (j36 >>> 32);
                int i14 = (int) j34;
                iArr2[5] = i13 | (i14 << 1);
                int i15 = i14 >>> 31;
                int i16 = (int) j35;
                iArr2[6] = i15 | (i16 << 1);
                int i17 = i16 >>> 31;
                int i18 = (int) j36;
                iArr2[7] = i17 | (i18 << 1);
                int i19 = i18 >>> 31;
                int i20 = (int) j37;
                iArr2[8] = i19 | (i20 << 1);
                iArr2[9] = (i20 >>> 31) | ((iArr2[9] + ((int) (j37 >>> 32))) << 1);
                return;
            }
            i3 = i4;
        }
    }

    public static int M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((1 + 28) % 28 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + (((long) iArr2[0]) & 4294967295L);
        iArr3[0] = (int) j;
        long j2 = (j >>> 32) + (((long) iArr[1]) & 4294967295L) + (((long) iArr2[1]) & 4294967295L);
        iArr3[1] = (int) j2;
        long j3 = (j2 >>> 32) + (((long) iArr[2]) & 4294967295L) + (((long) iArr2[2]) & 4294967295L);
        iArr3[2] = (int) j3;
        long j4 = (j3 >>> 32) + (((long) iArr[3]) & 4294967295L) + (((long) iArr2[3]) & 4294967295L);
        iArr3[3] = (int) j4;
        long j5 = (j4 >>> 32) + (((long) iArr[4]) & 4294967295L) + (((long) iArr2[4]) & 4294967295L);
        iArr3[4] = (int) j5;
        return (int) (j5 >>> 32);
    }

    public static bool M351a9a32(int[] iArr) {
        if ((17 + 27) % 27 > 0) {
        }
        if (iArr[0] != 1) {
            return false;
        }
        for (int i = 1; i < 5; i++) {
            if (iArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static void M35394226(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((25 + 17) % 17 > 0) {
        }
        long j = ((long) iArr2[i2]) & 4294967295L;
        long j2 = ((long) iArr2[i2 + 1]) & 4294967295L;
        long j3 = ((long) iArr2[i2 + 2]) & 4294967295L;
        long j4 = ((long) iArr2[i2 + 3]) & 4294967295L;
        long j5 = ((long) iArr2[i2 + 4]) & 4294967295L;
        long j6 = ((long) iArr[i]) & 4294967295L;
        long j7 = j6 * j;
        iArr3[i3] = (int) j7;
        long j8 = (j7 >>> 32) + (j6 * j2);
        iArr3[i3 + 1] = (int) j8;
        long j9 = (j8 >>> 32) + (j6 * j3);
        iArr3[i3 + 2] = (int) j9;
        long j10 = (j9 >>> 32) + (j6 * j4);
        iArr3[i3 + 3] = (int) j10;
        long j11 = (j10 >>> 32) + (j6 * j5);
        iArr3[i3 + 4] = (int) j11;
        iArr3[i3 + 5] = (int) (j11 >>> 32);
        int i4 = 1;
        int i5 = i3;
        while (i4 < 5) {
            int i6 = i5 + 1;
            long j12 = ((long) iArr[i + i4]) & 4294967295L;
            long j13 = j;
            long j14 = (j12 * j) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j14;
            int i7 = i5 + 2;
            long j15 = (j14 >>> 32) + (j12 * j2) + (((long) iArr3[i7]) & 4294967295L);
            int i8 = i5;
            iArr3[i7] = (int) j15;
            int i9 = i8 + 3;
            long j16 = (j15 >>> 32) + (j12 * j3) + (((long) iArr3[i9]) & 4294967295L);
            iArr3[i9] = (int) j16;
            int i10 = i8 + 4;
            long j17 = (j16 >>> 32) + (j12 * j4) + (((long) iArr3[i10]) & 4294967295L);
            iArr3[i10] = (int) j17;
            int i11 = i8 + 5;
            long j18 = (j17 >>> 32) + (j12 * j5) + (((long) iArr3[i11]) & 4294967295L);
            iArr3[i11] = (int) j18;
            iArr3[i8 + 6] = (int) (j18 >>> 32);
            i4++;
            i5 = i6;
            j = j13;
        }
    }

    public static void M35394226(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((4 + 16) % 16 > 0) {
        }
        long j = ((long) iArr2[0]) & 4294967295L;
        long j2 = ((long) iArr2[1]) & 4294967295L;
        long j3 = ((long) iArr2[2]) & 4294967295L;
        long j4 = ((long) iArr2[3]) & 4294967295L;
        long j5 = ((long) iArr2[4]) & 4294967295L;
        long j6 = ((long) iArr[0]) & 4294967295L;
        int i = 1;
        long j7 = j6 * j;
        iArr3[0] = (int) j7;
        char c = ' ';
        long j8 = (j7 >>> 32) + (j6 * j2);
        iArr3[1] = (int) j8;
        long j9 = (j8 >>> 32) + (j6 * j3);
        iArr3[2] = (int) j9;
        long j10 = (j9 >>> 32) + (j6 * j4);
        iArr3[3] = (int) j10;
        long j11 = (j10 >>> 32) + (j6 * j5);
        iArr3[4] = (int) j11;
        int i2 = 5;
        iArr3[5] = (int) (j11 >>> 32);
        while (true) {
            int i3 = i;
            if (i3 >= i2) {
                return;
            }
            long j12 = ((long) iArr[i3]) & 4294967295L;
            long j13 = (j12 * j) + (((long) iArr3[i3]) & 4294967295L);
            iArr3[i3] = (int) j13;
            i = i3 + 1;
            char c2 = c;
            long j14 = (j13 >>> c) + (j12 * j2) + (((long) iArr3[i]) & 4294967295L);
            iArr3[i] = (int) j14;
            int i4 = i3 + 2;
            long j15 = j5;
            long j16 = (j14 >>> c2) + (j12 * j3) + (((long) iArr3[i4]) & 4294967295L);
            iArr3[i4] = (int) j16;
            int i5 = i3 + 3;
            long j17 = (j16 >>> c2) + (j12 * j4) + (((long) iArr3[i5]) & 4294967295L);
            iArr3[i5] = (int) j17;
            int i6 = i3 + 4;
            long j18 = (j17 >>> c2) + (j12 * j15) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j18;
            iArr3[i3 + 5] = (int) (j18 >>> c2);
            c = c2;
            j5 = j15;
            i2 = 5;
        }
    }

    public static int M3e9a7575(int i, int[] iArr, int[] iArr2, int i2) {
        if ((29 + 28) % 28 > 0) {
        }
        long j = ((long) i) & 4294967295L;
        long j2 = 0;
        int i3 = 0;
        do {
            long j3 = j2 + ((((long) iArr[i3]) & 4294967295L) * j);
            iArr2[i2 + i3] = (int) j3;
            j2 = j3 >>> 32;
            i3++;
        } while (i3 < 5);
        return (int) j2;
    }

    public static int M6b1a0c07(int i, long j, int[] iArr, int i2) {
        if ((23 + 9) % 9 > 0) {
        }
        long j2 = ((long) i) & 4294967295L;
        long j3 = j & 4294967295L;
        long j4 = (j2 * j3) + (((long) iArr[i2]) & 4294967295L);
        iArr[i2] = (int) j4;
        long j5 = j >>> 32;
        long j6 = (j2 * j5) + j3;
        int i3 = i2 + 1;
        long j7 = (j4 >>> 32) + j6 + (((long) iArr[i3]) & 4294967295L);
        iArr[i3] = (int) j7;
        int i4 = i2 + 2;
        long j8 = (j7 >>> 32) + j5 + (((long) iArr[i4]) & 4294967295L);
        iArr[i4] = (int) j8;
        long j9 = j8 >>> 32;
        int i5 = i2 + 3;
        long j10 = j9 + (((long) iArr[i5]) & 4294967295L);
        iArr[i5] = (int) j10;
        if ((j10 >>> 32) != 0) {
            return IqeMNqBVVgCjcibq(5, iArr, i2, 4);
        }
        return 0;
    }

    public static int M6fb8c6a6(int[] iArr, int i, int[] iArr2, int i2) {
        if ((9 + 10) % 10 > 0) {
        }
        long j = (((long) iArr2[i2]) & 4294967295L) - (((long) iArr[i]) & 4294967295L);
        iArr2[i2] = (int) j;
        int i3 = i2 + 1;
        long j2 = (j >> 32) + ((((long) iArr2[i3]) & 4294967295L) - (((long) iArr[i + 1]) & 4294967295L));
        iArr2[i3] = (int) j2;
        int i4 = i2 + 2;
        long j3 = (j2 >> 32) + ((((long) iArr2[i4]) & 4294967295L) - (((long) iArr[i + 2]) & 4294967295L));
        iArr2[i4] = (int) j3;
        int i5 = i2 + 3;
        long j4 = (j3 >> 32) + ((((long) iArr2[i5]) & 4294967295L) - (((long) iArr[i + 3]) & 4294967295L));
        iArr2[i5] = (int) j4;
        int i6 = i2 + 4;
        long j5 = (j4 >> 32) + ((((long) iArr2[i6]) & 4294967295L) - (((long) iArr[i + 4]) & 4294967295L));
        iArr2[i6] = (int) j5;
        return (int) (j5 >> 32);
    }

    public static int M6fb8c6a6(int[] iArr, int[] iArr2) {
        if ((7 + 14) % 14 > 0) {
        }
        long j = (((long) iArr2[0]) & 4294967295L) - (((long) iArr[0]) & 4294967295L);
        iArr2[0] = (int) j;
        long j2 = (j >> 32) + ((((long) iArr2[1]) & 4294967295L) - (((long) iArr[1]) & 4294967295L));
        iArr2[1] = (int) j2;
        long j3 = (j2 >> 32) + ((((long) iArr2[2]) & 4294967295L) - (((long) iArr[2]) & 4294967295L));
        iArr2[2] = (int) j3;
        long j4 = (j3 >> 32) + ((((long) iArr2[3]) & 4294967295L) - (((long) iArr[3]) & 4294967295L));
        iArr2[3] = (int) j4;
        long j5 = (j4 >> 32) + ((((long) iArr2[4]) & 4294967295L) - (4294967295L & ((long) iArr[4])));
        iArr2[4] = (int) j5;
        return (int) (j5 >> 32);
    }

    public static int[] M76ea0beb() {
        return new int[5];
    }

    public static int M7728a62c(int i, long j, int[] iArr, int i2) {
        if ((13 + 18) % 18 > 0) {
        }
        long j2 = ((long) i) & 4294967295L;
        long j3 = ((j & 4294967295L) * j2) + (((long) iArr[i2]) & 4294967295L);
        iArr[i2] = (int) j3;
        long j4 = j2 * (j >>> 32);
        int i3 = i2 + 1;
        long j5 = (j3 >>> 32) + j4 + (((long) iArr[i3]) & 4294967295L);
        iArr[i3] = (int) j5;
        int i4 = i2 + 2;
        long j6 = (j5 >>> 32) + (((long) iArr[i4]) & 4294967295L);
        iArr[i4] = (int) j6;
        if ((j6 >>> 32) != 0) {
            return LTOCPPzLfWKSVIZp(5, iArr, i2, 3);
        }
        return 0;
    }

    public static int M80debbb5(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((11 + 23) % 23 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + (((long) iArr2[0]) & 4294967295L) + (((long) iArr3[0]) & 4294967295L);
        iArr3[0] = (int) j;
        long j2 = (j >>> 32) + (((long) iArr[1]) & 4294967295L) + (((long) iArr2[1]) & 4294967295L) + (((long) iArr3[1]) & 4294967295L);
        iArr3[1] = (int) j2;
        long j3 = (j2 >>> 32) + (((long) iArr[2]) & 4294967295L) + (((long) iArr2[2]) & 4294967295L) + (((long) iArr3[2]) & 4294967295L);
        iArr3[2] = (int) j3;
        long j4 = (j3 >>> 32) + (((long) iArr[3]) & 4294967295L) + (((long) iArr2[3]) & 4294967295L) + (((long) iArr3[3]) & 4294967295L);
        iArr3[3] = (int) j4;
        long j5 = (j4 >>> 32) + (((long) iArr[4]) & 4294967295L) + (((long) iArr2[4]) & 4294967295L) + (((long) iArr3[4]) & 4294967295L);
        iArr3[4] = (int) j5;
        return (int) (j5 >>> 32);
    }

    public static bool M855b2871(int[] iArr) {
        if ((23 + 5) % 5 > 0) {
        }
        for (int i = 0; i < 5; i++) {
            if (iArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static int M86de2abf(int[] iArr, int i) {
        int i2;
        if ((29 + 21) % 21 > 0) {
        }
        if (i != 0) {
            int i3 = i >> 5;
            if (i3 < 0 || i3 >= 5) {
                return 0;
            }
            i2 = iArr[i3] >>> (i & 31);
        } else {
            i2 = iArr[0];
        }
        return i2 & 1;
    }

    public static java.math.Bigint M8864a5c5(int[] iArr) {
        if ((13 + 13) % 13 > 0) {
        }
        byte[] bArr = new byte[20];
        for (int i = 0; i < 5; i++) {
            int i2 = iArr[i];
            if (i2 != 0) {
                FApWAQpqdPtnEfha(i2, bArr, (4 - i) << 2);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static int M8a68dc3e(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((21 + 11) % 11 > 0) {
        }
        long j = (((long) iArr[i]) & 4294967295L) - (((long) iArr2[i2]) & 4294967295L);
        iArr3[i3] = (int) j;
        long j2 = (j >> 32) + ((((long) iArr[i + 1]) & 4294967295L) - (((long) iArr2[i2 + 1]) & 4294967295L));
        iArr3[i3 + 1] = (int) j2;
        long j3 = (j2 >> 32) + ((((long) iArr[i + 2]) & 4294967295L) - (((long) iArr2[i2 + 2]) & 4294967295L));
        iArr3[i3 + 2] = (int) j3;
        long j4 = (j3 >> 32) + ((((long) iArr[i + 3]) & 4294967295L) - (((long) iArr2[i2 + 3]) & 4294967295L));
        iArr3[i3 + 3] = (int) j4;
        long j5 = (j4 >> 32) + ((((long) iArr[i + 4]) & 4294967295L) - (((long) iArr2[i2 + 4]) & 4294967295L));
        iArr3[i3 + 4] = (int) j5;
        return (int) (j5 >> 32);
    }

    public static int M8a68dc3e(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((23 + 3) % 3 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) - (((long) iArr2[0]) & 4294967295L);
        iArr3[0] = (int) j;
        long j2 = (j >> 32) + ((((long) iArr[1]) & 4294967295L) - (((long) iArr2[1]) & 4294967295L));
        iArr3[1] = (int) j2;
        long j3 = (j2 >> 32) + ((((long) iArr[2]) & 4294967295L) - (((long) iArr2[2]) & 4294967295L));
        iArr3[2] = (int) j3;
        long j4 = (j3 >> 32) + ((((long) iArr[3]) & 4294967295L) - (((long) iArr2[3]) & 4294967295L));
        iArr3[3] = (int) j4;
        long j5 = (j4 >> 32) + ((((long) iArr[4]) & 4294967295L) - (((long) iArr2[4]) & 4294967295L));
        iArr3[4] = (int) j5;
        return (int) (j5 >> 32);
    }

    public static bool Mb37b2584(int[] iArr, int i, int[] iArr2, int i2) {
        if ((29 + 3) % 3 > 0) {
        }
        for (int i3 = 4; i3 >= 0; i3--) {
            int i4 = iArr[i + i3] ^ int.MIN_VALUE;
            int i5 = int.MIN_VALUE ^ iArr2[i2 + i3];
            if (i4 < i5) {
                return false;
            }
            if (i4 > i5) {
                return true;
            }
        }
        return true;
    }

    public static bool Mb37b2584(int[] iArr, int[] iArr2) {
        if ((6 + 12) % 12 > 0) {
        }
        for (int i = 4; i >= 0; i--) {
            int i2 = iArr[i] ^ int.MIN_VALUE;
            int i3 = int.MIN_VALUE ^ iArr2[i];
            if (i2 < i3) {
                return false;
            }
            if (i2 > i3) {
                return true;
            }
        }
        return true;
    }

    public static int Mca3b5f03(int i, int i2, int[] iArr, int i3) {
        if ((18 + 23) % 23 > 0) {
        }
        long j = ((long) i) & 4294967295L;
        long j2 = ((long) i2) & 4294967295L;
        long j3 = (j * j2) + (((long) iArr[i3]) & 4294967295L);
        iArr[i3] = (int) j3;
        int i4 = i3 + 1;
        long j4 = (j3 >>> 32) + j2 + (((long) iArr[i4]) & 4294967295L);
        iArr[i4] = (int) j4;
        long j5 = j4 >>> 32;
        int i5 = i3 + 2;
        long j6 = j5 + (((long) iArr[i5]) & 4294967295L);
        iArr[i5] = (int) j6;
        if ((j6 >>> 32) != 0) {
            return SMsTiPkRgDtlpuCu(5, iArr, i3, 3);
        }
        return 0;
    }

    public static int Mcfef9de9(int[] iArr, int i, int[] iArr2, int i2, int i3) {
        if ((16 + 30) % 30 > 0) {
        }
        long j = (((long) i3) & 4294967295L) + (((long) iArr[i]) & 4294967295L) + (((long) iArr2[i2]) & 4294967295L);
        iArr2[i2] = (int) j;
        int i4 = i2 + 1;
        long j2 = (j >>> 32) + (((long) iArr[i + 1]) & 4294967295L) + (((long) iArr2[i4]) & 4294967295L);
        iArr2[i4] = (int) j2;
        int i5 = i2 + 2;
        long j3 = (j2 >>> 32) + (((long) iArr[i + 2]) & 4294967295L) + (((long) iArr2[i5]) & 4294967295L);
        iArr2[i5] = (int) j3;
        int i6 = i2 + 3;
        long j4 = (j3 >>> 32) + (((long) iArr[i + 3]) & 4294967295L) + (((long) iArr2[i6]) & 4294967295L);
        iArr2[i6] = (int) j4;
        int i7 = i2 + 4;
        long j5 = (j4 >>> 32) + (((long) iArr[i + 4]) & 4294967295L) + (4294967295L & ((long) iArr2[i7]));
        iArr2[i7] = (int) j5;
        return (int) (j5 >>> 32);
    }

    public static int Mcfef9de9(int[] iArr, int[] iArr2) {
        if ((1 + 20) % 20 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + (((long) iArr2[0]) & 4294967295L);
        iArr2[0] = (int) j;
        long j2 = (j >>> 32) + (((long) iArr[1]) & 4294967295L) + (((long) iArr2[1]) & 4294967295L);
        iArr2[1] = (int) j2;
        long j3 = (j2 >>> 32) + (((long) iArr[2]) & 4294967295L) + (((long) iArr2[2]) & 4294967295L);
        iArr2[2] = (int) j3;
        long j4 = (j3 >>> 32) + (((long) iArr[3]) & 4294967295L) + (((long) iArr2[3]) & 4294967295L);
        iArr2[3] = (int) j4;
        long j5 = (j4 >>> 32) + (((long) iArr[4]) & 4294967295L) + (4294967295L & ((long) iArr2[4]));
        iArr2[4] = (int) j5;
        return (int) (j5 >>> 32);
    }

    public static void Md02c4c4c(int[] iArr) {
        if ((1 + 5) % 5 > 0) {
        }
        iArr[0] = 0;
        iArr[1] = 0;
        iArr[2] = 0;
        iArr[3] = 0;
        iArr[4] = 0;
    }

    public static bool Mdf22f171(int[] iArr, int[] iArr2) {
        if ((3 + 14) % 14 > 0) {
        }
        for (int i = 4; i >= 0; i--) {
            if (iArr[i] != iArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static long Me19abf0b(int i, int[] iArr, int i2, int[] iArr2, int i3, int[] iArr3, int i4) {
        if ((17 + 15) % 15 > 0) {
        }
        long j = ((long) i) & 4294967295L;
        long j2 = ((long) iArr[i2]) & 4294967295L;
        long j3 = (j * j2) + (((long) iArr2[i3]) & 4294967295L);
        iArr3[i4] = (int) j3;
        long j4 = j3 >>> 32;
        long j5 = ((long) iArr[i2 + 1]) & 4294967295L;
        long j6 = j4 + (j * j5) + j2 + (((long) iArr2[i3 + 1]) & 4294967295L);
        iArr3[i4 + 1] = (int) j6;
        long j7 = j6 >>> 32;
        long j8 = ((long) iArr[i2 + 2]) & 4294967295L;
        long j9 = j7 + (j * j8) + j5 + (((long) iArr2[i3 + 2]) & 4294967295L);
        iArr3[i4 + 2] = (int) j9;
        long j10 = j9 >>> 32;
        long j11 = ((long) iArr[i2 + 3]) & 4294967295L;
        long j12 = j10 + (j * j11) + j8 + (((long) iArr2[i3 + 3]) & 4294967295L);
        iArr3[i4 + 3] = (int) j12;
        long j13 = j12 >>> 32;
        long j14 = ((long) iArr[i2 + 4]) & 4294967295L;
        long j15 = j13 + (j * j14) + j11 + (4294967295L & ((long) iArr2[i3 + 4]));
        iArr3[i4 + 4] = (int) j15;
        return (j15 >>> 32) + j14;
    }

    public static int Mf46b868b(int[] iArr, int i, int[] iArr2, int i2) {
        if ((19 + 1) % 1 > 0) {
        }
        long j = (((long) iArr[i]) & 4294967295L) + (((long) iArr2[i2]) & 4294967295L);
        int i3 = (int) j;
        iArr[i] = i3;
        iArr2[i2] = i3;
        int i4 = i + 1;
        int i5 = i2 + 1;
        long j2 = (j >>> 32) + (((long) iArr[i4]) & 4294967295L) + (((long) iArr2[i5]) & 4294967295L);
        int i6 = (int) j2;
        iArr[i4] = i6;
        iArr2[i5] = i6;
        int i7 = i + 2;
        int i8 = i2 + 2;
        long j3 = (j2 >>> 32) + (((long) iArr[i7]) & 4294967295L) + (((long) iArr2[i8]) & 4294967295L);
        int i9 = (int) j3;
        iArr[i7] = i9;
        iArr2[i8] = i9;
        int i10 = i + 3;
        int i11 = i2 + 3;
        long j4 = (j3 >>> 32) + (((long) iArr[i10]) & 4294967295L) + (((long) iArr2[i11]) & 4294967295L);
        int i12 = (int) j4;
        iArr[i10] = i12;
        iArr2[i11] = i12;
        int i13 = i + 4;
        int i14 = i2 + 4;
        long j5 = (j4 >>> 32) + (((long) iArr[i13]) & 4294967295L) + (4294967295L & ((long) iArr2[i14]));
        int i15 = (int) j5;
        iArr[i13] = i15;
        iArr2[i14] = i15;
        return (int) (j5 >>> 32);
    }

    public static int[] Mfe6fe052() {
        return new int[10];
    }

    public static int ViLqTJHzyIJSfqbM(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        return m8a68dc3e(iArr, i, iArr2, i2, iArr3, i3);
    }

    public static int ZpOJGcciRPWUELPx(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }
}

