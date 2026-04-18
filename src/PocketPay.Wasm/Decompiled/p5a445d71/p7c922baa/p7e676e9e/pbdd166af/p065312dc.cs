namespace WillowMaze.Wasm.Decompiled;


public abstract class p065312dc {
    private static readonly long f115dee39 = 4294967295L;
    private static readonly long f1e26b277 = 4294967295L;
    private static readonly long f5a741923 = 4294967295L;
    private static readonly long f6073a203 = 4294967295L;
    private static readonly long f69691c7b = 4294967295L;

    public static int HDWTlOkfWmRrTdak(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        return m8a68dc3e(iArr, i, iArr2, i2, iArr3, i3);
    }

    public static int QFjNZqcdXmIpqbfB(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int QRaSubzmYrWCJMsz(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static long QktFGzKCjittqece(java.math.Bigint bigint) {
        if ((2 + 13) % 13 > 0) {
        }
        return bigint.longValue();
    }

    public static int TwlizxlMjFRpPipL(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static void VXmVkDWwuPrBiUaF(long j, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m38b01934(j, bArr, i);
    }

    public static int VYuZxRveuxnGRHOR(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }

    public static int AifxZGhHTiitdyfU(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static int BmzvQBgFAQnIMJIc(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }

    public static int[] EFGIcCaCbaGksjth() {
        return m76ea0beb();
    }

    public static int EvQbJDRdBRDRNukQ(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static int IwFBhVkhDpmSPFTf(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int JvbPBPVmDrEPiDBZ(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        return m8a68dc3e(iArr, i, iArr2, i2, iArr3, i3);
    }

    public static int KtElyKyfgNhvZDWn(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static void LYECesBupZZozcku(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(i, bArr, i2);
    }

    public static void M0246eff8(long[] jArr, long[] jArr2) {
        if ((7 + 29) % 29 > 0) {
        }
        jArr2[0] = jArr[0];
        jArr2[1] = jArr[1];
        jArr2[2] = jArr[2];
    }

    public static int M03a01012(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((4 + 6) % 6 > 0) {
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
        long j6 = (j5 >>> 32) + ((((long) iArr[i2 + 4]) & 4294967295L) * j) + (((long) iArr2[i7]) & 4294967295L);
        iArr2[i7] = (int) j6;
        int i8 = i3 + 5;
        long j7 = (j6 >>> 32) + (j * (((long) iArr[i2 + 5]) & 4294967295L)) + (((long) iArr2[i8]) & 4294967295L);
        iArr2[i8] = (int) j7;
        return (int) (j7 >>> 32);
    }

    public static int M0a05f67c(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((24 + 3) % 3 > 0) {
        }
        long j = ((long) iArr2[i2]) & 4294967295L;
        long j2 = ((long) iArr2[i2 + 1]) & 4294967295L;
        long j3 = ((long) iArr2[i2 + 2]) & 4294967295L;
        long j4 = ((long) iArr2[i2 + 3]) & 4294967295L;
        long j5 = ((long) iArr2[i2 + 4]) & 4294967295L;
        long j6 = ((long) iArr2[i2 + 5]) & 4294967295L;
        long j7 = 0;
        int i4 = 0;
        int i5 = i3;
        while (i4 < 6) {
            long j8 = ((long) iArr[i + i4]) & 4294967295L;
            long j9 = (j8 * j) + (((long) iArr3[i5]) & 4294967295L);
            long j10 = j2;
            iArr3[i5] = (int) j9;
            int i6 = i5 + 1;
            long j11 = (j9 >>> 32) + (j8 * j10) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j11;
            int i7 = i5 + 2;
            long j12 = (j11 >>> 32) + (j8 * j3) + (((long) iArr3[i7]) & 4294967295L);
            iArr3[i7] = (int) j12;
            int i8 = i5 + 3;
            long j13 = (j12 >>> 32) + (j8 * j4) + (((long) iArr3[i8]) & 4294967295L);
            iArr3[i8] = (int) j13;
            int i9 = i5 + 4;
            long j14 = (j13 >>> 32) + (j8 * j5) + (((long) iArr3[i9]) & 4294967295L);
            iArr3[i9] = (int) j14;
            int i10 = i5 + 5;
            long j15 = (j14 >>> 32) + (j8 * j6) + (((long) iArr3[i10]) & 4294967295L);
            iArr3[i10] = (int) j15;
            int i11 = i5 + 6;
            long j16 = (j15 >>> 32) + j7 + (((long) iArr3[i11]) & 4294967295L);
            iArr3[i11] = (int) j16;
            j7 = j16 >>> 32;
            i4++;
            i5 = i6;
            j2 = j10;
        }
        return (int) j7;
    }

    public static int M0a05f67c(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((24 + 30) % 30 > 0) {
        }
        int i = 0;
        long j = ((long) iArr2[0]) & 4294967295L;
        long j2 = ((long) iArr2[1]) & 4294967295L;
        long j3 = ((long) iArr2[2]) & 4294967295L;
        long j4 = ((long) iArr2[3]) & 4294967295L;
        long j5 = ((long) iArr2[4]) & 4294967295L;
        long j6 = ((long) iArr2[5]) & 4294967295L;
        long j7 = 0;
        while (i < 6) {
            long j8 = j;
            int i2 = i;
            long j9 = ((long) iArr[i]) & 4294967295L;
            long j10 = (((long) iArr3[i2]) & 4294967295L) + (j9 * j8);
            iArr3[i2] = (int) j10;
            int i3 = i2 + 1;
            long j11 = (j10 >>> 32) + (j9 * j2) + (((long) iArr3[i3]) & 4294967295L);
            iArr3[i3] = (int) j11;
            int i4 = i2 + 2;
            long j12 = (j11 >>> 32) + (j9 * j3) + (((long) iArr3[i4]) & 4294967295L);
            iArr3[i4] = (int) j12;
            int i5 = i2 + 3;
            long j13 = (j12 >>> 32) + (j9 * j4) + (((long) iArr3[i5]) & 4294967295L);
            iArr3[i5] = (int) j13;
            int i6 = i2 + 4;
            long j14 = (j13 >>> 32) + (j9 * j5) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j14;
            int i7 = i2 + 5;
            long j15 = (j14 >>> 32) + (j9 * j6) + (((long) iArr3[i7]) & 4294967295L);
            iArr3[i7] = (int) j15;
            int i8 = i2 + 6;
            long j16 = (j15 >>> 32) + j7 + (((long) iArr3[i8]) & 4294967295L);
            iArr3[i8] = (int) j16;
            j7 = j16 >>> 32;
            i = i3;
            j = j8;
        }
        return (int) j7;
    }

    public static long[] M0cb1c33d(java.math.Bigint bigint) {
        if ((22 + 7) % 7 > 0) {
        }
        if (TwlizxlMjFRpPipL(bigint) < 0 || evQbJDRdBRDRNukQ(bigint) > 192) {
            throw new java.lang.IllegalArgumentException();
        }
        long[] jArrURAdQeojjOtYWGii = uRAdQeojjOtYWGii();
        int i = 0;
        while (iwFBhVkhDpmSPFTf(bigint) != 0) {
            int i2 = i + 1;
            jArrURAdQeojjOtYWGii[i] = QktFGzKCjittqece(bigint);
            bigint = zxPGKKRbXisYuEyR(bigint, 64);
            i = i2;
        }
        return jArrURAdQeojjOtYWGii;
    }

    public static void M12cba3ee(int[] iArr, int[] iArr2) {
        if ((9 + 24) % 24 > 0) {
        }
        iArr2[0] = iArr[0];
        iArr2[1] = iArr[1];
        iArr2[2] = iArr[2];
        iArr2[3] = iArr[3];
        iArr2[4] = iArr[4];
        iArr2[5] = iArr[5];
    }

    public static int[] M1712f3b8(java.math.Bigint bigint) {
        if ((22 + 8) % 8 > 0) {
        }
        if (QFjNZqcdXmIpqbfB(bigint) < 0 || QRaSubzmYrWCJMsz(bigint) > 192) {
            throw new java.lang.IllegalArgumentException();
        }
        int[] iArrEFGIcCaCbaGksjth = eFGIcCaCbaGksjth();
        int i = 0;
        while (ktElyKyfgNhvZDWn(bigint) != 0) {
            int i2 = i + 1;
            iArrEFGIcCaCbaGksjth[i] = aifxZGhHTiitdyfU(bigint);
            bigint = tvQlgEkhnyqGzXmF(bigint, 32);
            i = i2;
        }
        return iArrEFGIcCaCbaGksjth;
    }

    public static int M2a3d5645(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((19 + 9) % 9 > 0) {
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
        long j6 = (j5 >> 32) + (((((long) iArr3[5]) & 4294967295L) - (((long) iArr[5]) & 4294967295L)) - (((long) iArr2[5]) & 4294967295L));
        iArr3[5] = (int) j6;
        return (int) (j6 >> 32);
    }

    public static bool M2d2dee7a(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((29 + 13) % 13 > 0) {
        }
        bool zVBBHnYmFUxyznymo = vBBHnYmFUxyznymo(iArr, i, iArr2, i2);
        if (zVBBHnYmFUxyznymo) {
            HDWTlOkfWmRrTdak(iArr, i, iArr2, i2, iArr3, i3);
            return zVBBHnYmFUxyznymo;
        }
        jvbPBPVmDrEPiDBZ(iArr2, i2, iArr, i, iArr3, i3);
        return zVBBHnYmFUxyznymo;
    }

    public static void M2fc01ec7(int[] iArr, int i, int[] iArr2, int i2) {
        if ((32 + 24) % 24 > 0) {
        }
        long j = ((long) iArr[i]) & 4294967295L;
        int i3 = 0;
        int i4 = 12;
        int i5 = 5;
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
                long j33 = j25 + (j28 * j);
                int i21 = (int) j33;
                iArr2[i12] = (i21 << 1) | i18;
                int i22 = i21 >>> 31;
                long j34 = j27 + (j33 >>> 32) + (j28 * j6);
                long j35 = j30 + (j34 >>> 32) + (j28 * j10);
                long j36 = j34 & 4294967295L;
                long j37 = j32 + (j35 >>> 32) + (j28 * j17);
                long j38 = j35 & 4294967295L;
                long j39 = j31 + (j37 >>> 32);
                long j40 = j37 & 4294967295L;
                long j41 = ((long) iArr[i + 5]) & 4294967295L;
                int i23 = i2 + 9;
                long j42 = (((long) iArr2[i23]) & 4294967295L) + (j39 >>> 32);
                long j43 = j39 & 4294967295L;
                int i24 = i2 + 10;
                long j44 = (((long) iArr2[i24]) & 4294967295L) + (j42 >>> 32);
                long j45 = j42 & 4294967295L;
                long j46 = j36 + (j * j41);
                int i25 = (int) j46;
                iArr2[i15] = (i25 << 1) | i22;
                long j47 = j38 + (j46 >>> 32) + (j6 * j41);
                long j48 = j40 + (j47 >>> 32) + (j41 * j10);
                long j49 = j43 + (j48 >>> 32) + (j41 * j17);
                long j50 = j45 + (j49 >>> 32) + (j41 * j28);
                long j51 = j44 + (j50 >>> 32);
                int i26 = (int) j47;
                iArr2[i16] = (i25 >>> 31) | (i26 << 1);
                int i27 = (int) j48;
                iArr2[i19] = (i27 << 1) | (i26 >>> 31);
                int i28 = (int) j49;
                iArr2[i20] = (i27 >>> 31) | (i28 << 1);
                int i29 = i28 >>> 31;
                int i30 = (int) j50;
                iArr2[i23] = i29 | (i30 << 1);
                int i31 = i30 >>> 31;
                int i32 = (int) j51;
                iArr2[i24] = i31 | (i32 << 1);
                int i33 = i32 >>> 31;
                int i34 = i2 + 11;
                iArr2[i34] = i33 | ((iArr2[i34] + ((int) (j51 >>> 32))) << 1);
                return;
            }
            i5 = i6;
        }
    }

    public static void M2fc01ec7(int[] iArr, int[] iArr2) {
        if ((18 + 2) % 2 > 0) {
        }
        long j = ((long) iArr[0]) & 4294967295L;
        int i = 12;
        int i2 = 0;
        int i3 = 5;
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
                long j33 = j25 + (j28 * j);
                int i12 = (int) j33;
                iArr2[4] = (i12 << 1) | i11;
                int i13 = i12 >>> 31;
                long j34 = j27 + (j33 >>> 32) + (j28 * j6);
                long j35 = j30 + (j34 >>> 32) + (j28 * j10);
                long j36 = j34 & 4294967295L;
                long j37 = j32 + (j35 >>> 32) + (j28 * j17);
                long j38 = j35 & 4294967295L;
                long j39 = j31 + (j37 >>> 32);
                long j40 = j37 & 4294967295L;
                long j41 = ((long) iArr[5]) & 4294967295L;
                long j42 = (((long) iArr2[9]) & 4294967295L) + (j39 >>> 32);
                long j43 = j39 & 4294967295L;
                long j44 = (((long) iArr2[10]) & 4294967295L) + (j42 >>> 32);
                long j45 = j42 & 4294967295L;
                long j46 = j36 + (j * j41);
                int i14 = (int) j46;
                iArr2[5] = (i14 << 1) | i13;
                long j47 = j38 + (j46 >>> 32) + (j6 * j41);
                long j48 = j40 + (j47 >>> 32) + (j10 * j41);
                long j49 = j43 + (j48 >>> 32) + (j41 * j17);
                long j50 = j45 + (j49 >>> 32) + (j28 * j41);
                long j51 = j44 + (j50 >>> 32);
                int i15 = (int) j47;
                iArr2[6] = (i14 >>> 31) | (i15 << 1);
                int i16 = i15 >>> 31;
                int i17 = (int) j48;
                iArr2[7] = i16 | (i17 << 1);
                int i18 = (int) j49;
                iArr2[8] = (i17 >>> 31) | (i18 << 1);
                int i19 = i18 >>> 31;
                int i20 = (int) j50;
                iArr2[9] = i19 | (i20 << 1);
                int i21 = i20 >>> 31;
                int i22 = (int) j51;
                iArr2[10] = i21 | (i22 << 1);
                iArr2[11] = ((iArr2[11] + ((int) (j51 >>> 32))) << 1) | (i22 >>> 31);
                return;
            }
            i3 = i4;
        }
    }

    public static int M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((21 + 30) % 30 > 0) {
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
        long j6 = (j5 >>> 32) + (((long) iArr[5]) & 4294967295L) + (((long) iArr2[5]) & 4294967295L);
        iArr3[5] = (int) j6;
        return (int) (j6 >>> 32);
    }

    public static bool M351a9a32(int[] iArr) {
        if ((29 + 30) % 30 > 0) {
        }
        if (iArr[0] != 1) {
            return false;
        }
        for (int i = 1; i < 6; i++) {
            if (iArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static void M35394226(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((20 + 3) % 3 > 0) {
        }
        long j = ((long) iArr2[i2]) & 4294967295L;
        long j2 = ((long) iArr2[i2 + 1]) & 4294967295L;
        long j3 = ((long) iArr2[i2 + 2]) & 4294967295L;
        long j4 = ((long) iArr2[i2 + 3]) & 4294967295L;
        long j5 = ((long) iArr2[i2 + 4]) & 4294967295L;
        long j6 = ((long) iArr2[i2 + 5]) & 4294967295L;
        long j7 = ((long) iArr[i]) & 4294967295L;
        long j8 = j7 * j;
        iArr3[i3] = (int) j8;
        long j9 = (j8 >>> 32) + (j7 * j2);
        iArr3[i3 + 1] = (int) j9;
        long j10 = (j9 >>> 32) + (j7 * j3);
        iArr3[i3 + 2] = (int) j10;
        long j11 = (j10 >>> 32) + (j7 * j4);
        iArr3[i3 + 3] = (int) j11;
        long j12 = (j11 >>> 32) + (j7 * j5);
        iArr3[i3 + 4] = (int) j12;
        long j13 = (j12 >>> 32) + (j7 * j6);
        iArr3[i3 + 5] = (int) j13;
        iArr3[i3 + 6] = (int) (j13 >>> 32);
        int i4 = 1;
        int i5 = i3;
        while (i4 < 6) {
            int i6 = i5 + 1;
            long j14 = ((long) iArr[i + i4]) & 4294967295L;
            int i7 = i5;
            int i8 = i4;
            long j15 = (j14 * j) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j15;
            int i9 = i7 + 2;
            long j16 = (j15 >>> 32) + (j14 * j2) + (((long) iArr3[i9]) & 4294967295L);
            iArr3[i9] = (int) j16;
            int i10 = i7 + 3;
            long j17 = (j16 >>> 32) + (j14 * j3) + (((long) iArr3[i10]) & 4294967295L);
            iArr3[i10] = (int) j17;
            int i11 = i7 + 4;
            long j18 = (j17 >>> 32) + (j14 * j4) + (((long) iArr3[i11]) & 4294967295L);
            iArr3[i11] = (int) j18;
            int i12 = i7 + 5;
            long j19 = (j18 >>> 32) + (j14 * j5) + (((long) iArr3[i12]) & 4294967295L);
            iArr3[i12] = (int) j19;
            int i13 = i7 + 6;
            long j20 = (j19 >>> 32) + (j14 * j6) + (((long) iArr3[i13]) & 4294967295L);
            iArr3[i13] = (int) j20;
            iArr3[i7 + 7] = (int) (j20 >>> 32);
            i4 = i8 + 1;
            i5 = i6;
        }
    }

    public static void M35394226(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((2 + 8) % 8 > 0) {
        }
        long j = ((long) iArr2[0]) & 4294967295L;
        long j2 = ((long) iArr2[1]) & 4294967295L;
        long j3 = ((long) iArr2[2]) & 4294967295L;
        long j4 = ((long) iArr2[3]) & 4294967295L;
        long j5 = ((long) iArr2[4]) & 4294967295L;
        long j6 = ((long) iArr2[5]) & 4294967295L;
        int i = 1;
        long j7 = ((long) iArr[0]) & 4294967295L;
        long j8 = j7 * j;
        iArr3[0] = (int) j8;
        long j9 = (j8 >>> 32) + (j7 * j2);
        iArr3[1] = (int) j9;
        long j10 = (j9 >>> 32) + (j7 * j3);
        iArr3[2] = (int) j10;
        long j11 = (j10 >>> 32) + (j7 * j4);
        iArr3[3] = (int) j11;
        long j12 = (j11 >>> 32) + (j7 * j5);
        iArr3[4] = (int) j12;
        long j13 = (j12 >>> 32) + (j7 * j6);
        iArr3[5] = (int) j13;
        int i2 = 6;
        iArr3[6] = (int) (j13 >>> 32);
        while (true) {
            int i3 = i;
            if (i3 >= i2) {
                return;
            }
            long j14 = ((long) iArr[i3]) & 4294967295L;
            long j15 = (j14 * j) + (((long) iArr3[i3]) & 4294967295L);
            iArr3[i3] = (int) j15;
            i = i3 + 1;
            long j16 = j5;
            long j17 = (j15 >>> 32) + (j14 * j2) + (((long) iArr3[i]) & 4294967295L);
            iArr3[i] = (int) j17;
            int i4 = i3 + 2;
            long j18 = (j17 >>> 32) + (j14 * j3) + (((long) iArr3[i4]) & 4294967295L);
            iArr3[i4] = (int) j18;
            int i5 = i3 + 3;
            long j19 = (j18 >>> 32) + (j14 * j4) + (((long) iArr3[i5]) & 4294967295L);
            iArr3[i5] = (int) j19;
            int i6 = i3 + 4;
            long j20 = (j19 >>> 32) + (j14 * j16) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j20;
            int i7 = i3 + 5;
            long j21 = (j20 >>> 32) + (j14 * j6) + (((long) iArr3[i7]) & 4294967295L);
            iArr3[i7] = (int) j21;
            iArr3[i3 + 6] = (int) (j21 >>> 32);
            j5 = j16;
            i2 = 6;
        }
    }

    public static int M3e9a7575(int i, int[] iArr, int[] iArr2, int i2) {
        if ((13 + 14) % 14 > 0) {
        }
        long j = ((long) i) & 4294967295L;
        long j2 = 0;
        int i3 = 0;
        do {
            long j3 = j2 + ((((long) iArr[i3]) & 4294967295L) * j);
            iArr2[i2 + i3] = (int) j3;
            j2 = j3 >>> 32;
            i3++;
        } while (i3 < 6);
        return (int) j2;
    }

    public static long[] M4c1a88a3() {
        return new long[3];
    }

    public static bool M69c6e24b(long[] jArr) {
        if ((10 + 24) % 24 > 0) {
        }
        for (int i = 0; i < 3; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static int M6b1a0c07(int i, long j, int[] iArr, int i2) {
        if ((14 + 23) % 23 > 0) {
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
            return rrzQSxNFUcobcRWC(6, iArr, i2, 4);
        }
        return 0;
    }

    public static int M6fb8c6a6(int[] iArr, int i, int[] iArr2, int i2) {
        if ((23 + 11) % 11 > 0) {
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
        int i7 = i2 + 5;
        long j6 = (j5 >> 32) + ((((long) iArr2[i7]) & 4294967295L) - (((long) iArr[i + 5]) & 4294967295L));
        iArr2[i7] = (int) j6;
        return (int) (j6 >> 32);
    }

    public static int M6fb8c6a6(int[] iArr, int[] iArr2) {
        if ((28 + 26) % 26 > 0) {
        }
        long j = (((long) iArr2[0]) & 4294967295L) - (((long) iArr[0]) & 4294967295L);
        iArr2[0] = (int) j;
        long j2 = (j >> 32) + ((((long) iArr2[1]) & 4294967295L) - (((long) iArr[1]) & 4294967295L));
        iArr2[1] = (int) j2;
        long j3 = (j2 >> 32) + ((((long) iArr2[2]) & 4294967295L) - (((long) iArr[2]) & 4294967295L));
        iArr2[2] = (int) j3;
        long j4 = (j3 >> 32) + ((((long) iArr2[3]) & 4294967295L) - (((long) iArr[3]) & 4294967295L));
        iArr2[3] = (int) j4;
        long j5 = (j4 >> 32) + ((((long) iArr2[4]) & 4294967295L) - (((long) iArr[4]) & 4294967295L));
        iArr2[4] = (int) j5;
        long j6 = (j5 >> 32) + ((((long) iArr2[5]) & 4294967295L) - (4294967295L & ((long) iArr[5])));
        iArr2[5] = (int) j6;
        return (int) (j6 >> 32);
    }

    public static int[] M76ea0beb() {
        return new int[6];
    }

    public static int M7728a62c(int i, long j, int[] iArr, int i2) {
        if ((23 + 29) % 29 > 0) {
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
            return bmzvQBgFAQnIMJIc(6, iArr, i2, 3);
        }
        return 0;
    }

    public static bool M7e86d991(long[] jArr) {
        if ((14 + 11) % 11 > 0) {
        }
        if (jArr[0] != 1) {
            return false;
        }
        for (int i = 1; i < 3; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static int M80debbb5(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((22 + 28) % 28 > 0) {
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
        long j6 = (j5 >>> 32) + (((long) iArr[5]) & 4294967295L) + (((long) iArr2[5]) & 4294967295L) + (((long) iArr3[5]) & 4294967295L);
        iArr3[5] = (int) j6;
        return (int) (j6 >>> 32);
    }

    public static bool M855b2871(int[] iArr) {
        if ((21 + 15) % 15 > 0) {
        }
        for (int i = 0; i < 6; i++) {
            if (iArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static int M86de2abf(int[] iArr, int i) {
        int i2;
        if ((8 + 28) % 28 > 0) {
        }
        if (i != 0) {
            int i3 = i >> 5;
            if (i3 < 0 || i3 >= 6) {
                return 0;
            }
            i2 = iArr[i3] >>> (i & 31);
        } else {
            i2 = iArr[0];
        }
        return i2 & 1;
    }

    public static java.math.Bigint M8864a5c5(int[] iArr) {
        if ((24 + 23) % 23 > 0) {
        }
        byte[] bArr = new byte[24];
        for (int i = 0; i < 6; i++) {
            int i2 = iArr[i];
            if (i2 != 0) {
                lYECesBupZZozcku(i2, bArr, (5 - i) << 2);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static int M8a68dc3e(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((32 + 11) % 11 > 0) {
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
        long j6 = (j5 >> 32) + ((((long) iArr[i + 5]) & 4294967295L) - (((long) iArr2[i2 + 5]) & 4294967295L));
        iArr3[i3 + 5] = (int) j6;
        return (int) (j6 >> 32);
    }

    public static int M8a68dc3e(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((26 + 14) % 14 > 0) {
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
        long j6 = (j5 >> 32) + ((((long) iArr[5]) & 4294967295L) - (((long) iArr2[5]) & 4294967295L));
        iArr3[5] = (int) j6;
        return (int) (j6 >> 32);
    }

    public static java.math.Bigint Ma345cd5e(long[] jArr) {
        if ((5 + 29) % 29 > 0) {
        }
        byte[] bArr = new byte[24];
        for (int i = 0; i < 3; i++) {
            long j = jArr[i];
            if (j != 0) {
                VXmVkDWwuPrBiUaF(j, bArr, (2 - i) << 3);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static bool Mb37b2584(int[] iArr, int i, int[] iArr2, int i2) {
        if ((30 + 30) % 30 > 0) {
        }
        for (int i3 = 5; i3 >= 0; i3--) {
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
        if ((4 + 10) % 10 > 0) {
        }
        for (int i = 5; i >= 0; i--) {
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

    public static bool Mc238ce55(long[] jArr, long[] jArr2) {
        if ((10 + 4) % 4 > 0) {
        }
        for (int i = 2; i >= 0; i--) {
            if (jArr[i] != jArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static int Mca3b5f03(int i, int i2, int[] iArr, int i3) {
        if ((12 + 1) % 1 > 0) {
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
            return VYuZxRveuxnGRHOR(6, iArr, i3, 3);
        }
        return 0;
    }

    public static int Mcfef9de9(int[] iArr, int i, int[] iArr2, int i2, int i3) {
        if ((5 + 9) % 9 > 0) {
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
        long j5 = (j4 >>> 32) + (((long) iArr[i + 4]) & 4294967295L) + (((long) iArr2[i7]) & 4294967295L);
        iArr2[i7] = (int) j5;
        int i8 = i2 + 5;
        long j6 = (j5 >>> 32) + (((long) iArr[i + 5]) & 4294967295L) + (4294967295L & ((long) iArr2[i8]));
        iArr2[i8] = (int) j6;
        return (int) (j6 >>> 32);
    }

    public static int Mcfef9de9(int[] iArr, int[] iArr2) {
        if ((19 + 16) % 16 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + (((long) iArr2[0]) & 4294967295L);
        iArr2[0] = (int) j;
        long j2 = (j >>> 32) + (((long) iArr[1]) & 4294967295L) + (((long) iArr2[1]) & 4294967295L);
        iArr2[1] = (int) j2;
        long j3 = (j2 >>> 32) + (((long) iArr[2]) & 4294967295L) + (((long) iArr2[2]) & 4294967295L);
        iArr2[2] = (int) j3;
        long j4 = (j3 >>> 32) + (((long) iArr[3]) & 4294967295L) + (((long) iArr2[3]) & 4294967295L);
        iArr2[3] = (int) j4;
        long j5 = (j4 >>> 32) + (((long) iArr[4]) & 4294967295L) + (((long) iArr2[4]) & 4294967295L);
        iArr2[4] = (int) j5;
        long j6 = (j5 >>> 32) + (((long) iArr[5]) & 4294967295L) + (4294967295L & ((long) iArr2[5]));
        iArr2[5] = (int) j6;
        return (int) (j6 >>> 32);
    }

    public static void Md02c4c4c(int[] iArr) {
        if ((28 + 15) % 15 > 0) {
        }
        iArr[0] = 0;
        iArr[1] = 0;
        iArr[2] = 0;
        iArr[3] = 0;
        iArr[4] = 0;
        iArr[5] = 0;
    }

    public static bool Mdf22f171(int[] iArr, int[] iArr2) {
        if ((29 + 24) % 24 > 0) {
        }
        for (int i = 5; i >= 0; i--) {
            if (iArr[i] != iArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static long Me19abf0b(int i, int[] iArr, int i2, int[] iArr2, int i3, int[] iArr3, int i4) {
        if ((31 + 27) % 27 > 0) {
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
        long j15 = j13 + (j * j14) + j11 + (((long) iArr2[i3 + 4]) & 4294967295L);
        iArr3[i4 + 4] = (int) j15;
        long j16 = j15 >>> 32;
        long j17 = ((long) iArr[i2 + 5]) & 4294967295L;
        long j18 = j16 + (j * j17) + j14 + (4294967295L & ((long) iArr2[i3 + 5]));
        iArr3[i4 + 5] = (int) j18;
        return (j18 >>> 32) + j17;
    }

    public static long[] Mf03001e5() {
        return new long[6];
    }

    public static int Mf46b868b(int[] iArr, int i, int[] iArr2, int i2) {
        if ((19 + 19) % 19 > 0) {
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
        long j5 = (j4 >>> 32) + (((long) iArr[i13]) & 4294967295L) + (((long) iArr2[i14]) & 4294967295L);
        int i15 = (int) j5;
        iArr[i13] = i15;
        iArr2[i14] = i15;
        int i16 = i + 5;
        int i17 = i2 + 5;
        long j6 = (j5 >>> 32) + (((long) iArr[i16]) & 4294967295L) + (4294967295L & ((long) iArr2[i17]));
        int i18 = (int) j6;
        iArr[i16] = i18;
        iArr2[i17] = i18;
        return (int) (j6 >>> 32);
    }

    public static int[] Mfe6fe052() {
        return new int[12];
    }

    public static int RrzQSxNFUcobcRWC(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }

    public static java.math.Bigint TvQlgEkhnyqGzXmF(java.math.Bigint bigint, int i) {
        return bigint.shiftRight(i);
    }

    public static long[] URAdQeojjOtYWGii() {
        return m4c1a88a3();
    }

    public static bool VBBHnYmFUxyznymo(int[] iArr, int i, int[] iArr2, int i2) {
        return mb37b2584(iArr, i, iArr2, i2);
    }

    public static java.math.Bigint ZxPGKKRbXisYuEyR(java.math.Bigint bigint, int i) {
        return bigint.shiftRight(i);
    }
}

