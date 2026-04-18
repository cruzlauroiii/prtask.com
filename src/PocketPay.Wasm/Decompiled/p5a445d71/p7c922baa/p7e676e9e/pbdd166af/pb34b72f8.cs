namespace WillowMaze.Wasm.Decompiled;


public abstract class pb34b72f8 {
    private static readonly long f69691c7b = 4294967295L;
    private static readonly long fce2772b4 = 4294967295L;

    public static void AUGSBgxFKEKRmvEc(long j, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m38b01934(j, bArr, i);
    }

    public static int[] CSTbpHyaJJdDqtQT() {
        return m76ea0beb();
    }

    public static int DYSrGAblaFQIPKft(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        return m8a68dc3e(iArr, i, iArr2, i2, iArr3, i3);
    }

    public static int ENpgBBjEFnuYgGmg(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int HryApnSsNhvpPxIA(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static bool HwTgIxSdOJVZNAFz(int[] iArr, int i, int[] iArr2, int i2) {
        return mb37b2584(iArr, i, iArr2, i2);
    }

    public static int JIjtknuDsUqgoErp(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        return m8a68dc3e(iArr, i, iArr2, i2, iArr3, i3);
    }

    public static void LNmXvouTDgfpPUnh(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(i, bArr, i2);
    }

    public static int NKjYlGaOCMMvhIFH(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static java.math.Bigint OWGKqQZTacOHldvb(java.math.Bigint bigint, int i) {
        return bigint.shiftRight(i);
    }

    public static int SgCXvyNxboJVAdkU(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static int ZHfXWvEviIXkMEDz(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }

    public static int BZStsxRNSXLsbOzr(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static long CxFMXhveoqXkQOge(java.math.Bigint bigint) {
        if ((28 + 18) % 18 > 0) {
        }
        return bigint.longValue();
    }

    public static long[] CyBIjlWkZdNiTlLG() {
        return m4c1a88a3();
    }

    public static int LaUOyruoYqMNAMAK(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }

    public static void M0246eff8(long[] jArr, long[] jArr2) {
        if ((10 + 16) % 16 > 0) {
        }
        jArr2[0] = jArr[0];
        jArr2[1] = jArr[1];
    }

    public static int M03a01012(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((16 + 10) % 10 > 0) {
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
        long j5 = (j4 >>> 32) + (j * (((long) iArr[i2 + 3]) & 4294967295L)) + (((long) iArr2[i6]) & 4294967295L);
        iArr2[i6] = (int) j5;
        return (int) (j5 >>> 32);
    }

    public static int M0a05f67c(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((29 + 31) % 31 > 0) {
        }
        long j = 4294967295L;
        long j2 = ((long) iArr2[i2]) & 4294967295L;
        long j3 = ((long) iArr2[i2 + 1]) & 4294967295L;
        long j4 = ((long) iArr2[i2 + 2]) & 4294967295L;
        long j5 = ((long) iArr2[i2 + 3]) & 4294967295L;
        int i4 = 0;
        long j6 = 0;
        while (true) {
            int i5 = i3;
            if (i4 >= 4) {
                return (int) j6;
            }
            long j7 = j;
            long j8 = ((long) iArr[i + i4]) & j7;
            long j9 = (j8 * j2) + (((long) iArr3[i5]) & j7);
            long j10 = j2;
            iArr3[i5] = (int) j9;
            int i6 = i5 + 1;
            i3 = i6;
            long j11 = (j9 >>> 32) + (j8 * j3) + (((long) iArr3[i6]) & j7);
            iArr3[i3] = (int) j11;
            int i7 = i5 + 2;
            long j12 = (j11 >>> 32) + (j8 * j4) + (((long) iArr3[i7]) & j7);
            iArr3[i7] = (int) j12;
            int i8 = i5 + 3;
            long j13 = (j12 >>> 32) + (j8 * j5) + (((long) iArr3[i8]) & j7);
            iArr3[i8] = (int) j13;
            int i9 = i5 + 4;
            long j14 = (j13 >>> 32) + j6 + (((long) iArr3[i9]) & j7);
            iArr3[i9] = (int) j14;
            j6 = j14 >>> 32;
            i4++;
            j = j7;
            j2 = j10;
        }
    }

    public static int M0a05f67c(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((19 + 5) % 5 > 0) {
        }
        int i = 0;
        long j = 4294967295L;
        long j2 = ((long) iArr2[0]) & 4294967295L;
        long j3 = ((long) iArr2[1]) & 4294967295L;
        long j4 = ((long) iArr2[2]) & 4294967295L;
        long j5 = ((long) iArr2[3]) & 4294967295L;
        long j6 = 0;
        while (i < 4) {
            long j7 = ((long) iArr[i]) & j;
            long j8 = j;
            long j9 = (((long) iArr3[i]) & j8) + (j7 * j2);
            iArr3[i] = (int) j9;
            int i2 = i + 1;
            long j10 = j2;
            int i3 = i;
            long j11 = (j9 >>> 32) + (j7 * j3) + (((long) iArr3[i2]) & j8);
            iArr3[i2] = (int) j11;
            int i4 = i3 + 2;
            long j12 = (j11 >>> 32) + (j7 * j4) + (((long) iArr3[i4]) & j8);
            iArr3[i4] = (int) j12;
            int i5 = i3 + 3;
            long j13 = (j12 >>> 32) + (j7 * j5) + (((long) iArr3[i5]) & j8);
            iArr3[i5] = (int) j13;
            int i6 = i3 + 4;
            long j14 = (j13 >>> 32) + j6 + (((long) iArr3[i6]) & j8);
            iArr3[i6] = (int) j14;
            j6 = j14 >>> 32;
            i = i2;
            j = j8;
            j2 = j10;
        }
        return (int) j6;
    }

    public static long[] M0cb1c33d(java.math.Bigint bigint) {
        if ((10 + 25) % 25 > 0) {
        }
        if (rwoNumqbKtuoZIUm(bigint) < 0 || SgCXvyNxboJVAdkU(bigint) > 128) {
            throw new java.lang.IllegalArgumentException();
        }
        long[] jArrCyBIjlWkZdNiTlLG = cyBIjlWkZdNiTlLG();
        int i = 0;
        while (ENpgBBjEFnuYgGmg(bigint) != 0) {
            int i2 = i + 1;
            jArrCyBIjlWkZdNiTlLG[i] = cxFMXhveoqXkQOge(bigint);
            bigint = rZsuwtMdYsROdtCF(bigint, 64);
            i = i2;
        }
        return jArrCyBIjlWkZdNiTlLG;
    }

    public static void M12cba3ee(int[] iArr, int[] iArr2) {
        if ((20 + 28) % 28 > 0) {
        }
        iArr2[0] = iArr[0];
        iArr2[1] = iArr[1];
        iArr2[2] = iArr[2];
        iArr2[3] = iArr[3];
    }

    public static int[] M1712f3b8(java.math.Bigint bigint) {
        if ((15 + 10) % 10 > 0) {
        }
        if (HryApnSsNhvpPxIA(bigint) < 0 || bZStsxRNSXLsbOzr(bigint) > 128) {
            throw new java.lang.IllegalArgumentException();
        }
        int[] iArrCSTbpHyaJJdDqtQT = CSTbpHyaJJdDqtQT();
        int i = 0;
        while (zhonnChsViFjejsr(bigint) != 0) {
            int i2 = i + 1;
            iArrCSTbpHyaJJdDqtQT[i] = NKjYlGaOCMMvhIFH(bigint);
            bigint = OWGKqQZTacOHldvb(bigint, 32);
            i = i2;
        }
        return iArrCSTbpHyaJJdDqtQT;
    }

    public static int M25a11a54(int i, int i2, int[] iArr, int i3) {
        if ((10 + 30) % 30 > 0) {
        }
        long j = ((((long) i2) & 4294967295L) * (((long) i) & 4294967295L)) + (((long) iArr[i3]) & 4294967295L);
        iArr[i3] = (int) j;
        int i4 = i3 + 1;
        long j2 = (j >>> 32) + (4294967295L & ((long) iArr[i4]));
        iArr[i4] = (int) j2;
        if ((j2 >>> 32) != 0) {
            return ZHfXWvEviIXkMEDz(4, iArr, i3, 2);
        }
        return 0;
    }

    public static int M2a3d5645(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((11 + 14) % 14 > 0) {
        }
        long j = ((((long) iArr3[0]) & 4294967295L) - (((long) iArr[0]) & 4294967295L)) - (((long) iArr2[0]) & 4294967295L);
        iArr3[0] = (int) j;
        long j2 = (j >> 32) + (((((long) iArr3[1]) & 4294967295L) - (((long) iArr[1]) & 4294967295L)) - (((long) iArr2[1]) & 4294967295L));
        iArr3[1] = (int) j2;
        long j3 = (j2 >> 32) + (((((long) iArr3[2]) & 4294967295L) - (((long) iArr[2]) & 4294967295L)) - (((long) iArr2[2]) & 4294967295L));
        iArr3[2] = (int) j3;
        long j4 = (j3 >> 32) + (((((long) iArr3[3]) & 4294967295L) - (((long) iArr[3]) & 4294967295L)) - (((long) iArr2[3]) & 4294967295L));
        iArr3[3] = (int) j4;
        return (int) (j4 >> 32);
    }

    public static bool M2d2dee7a(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((12 + 18) % 18 > 0) {
        }
        bool zHwTgIxSdOJVZNAFz = HwTgIxSdOJVZNAFz(iArr, i, iArr2, i2);
        if (zHwTgIxSdOJVZNAFz) {
            JIjtknuDsUqgoErp(iArr, i, iArr2, i2, iArr3, i3);
            return zHwTgIxSdOJVZNAFz;
        }
        DYSrGAblaFQIPKft(iArr2, i2, iArr, i, iArr3, i3);
        return zHwTgIxSdOJVZNAFz;
    }

    public static void M2fc01ec7(int[] iArr, int i, int[] iArr2, int i2) {
        if ((14 + 10) % 10 > 0) {
        }
        long j = ((long) iArr[i]) & 4294967295L;
        int i3 = 0;
        int i4 = 8;
        int i5 = 3;
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
                long j22 = j16 + (j * j17);
                int i17 = (int) j22;
                iArr2[i11] = (i17 << 1) | i14;
                long j23 = j19 + (j22 >>> 32) + (j6 * j17);
                long j24 = j21 + (j23 >>> 32) + (j17 * j10);
                long j25 = j20 + (j24 >>> 32);
                int i18 = (int) j23;
                iArr2[i12] = (i17 >>> 31) | (i18 << 1);
                int i19 = (int) j24;
                iArr2[i15] = (i18 >>> 31) | (i19 << 1);
                int i20 = i19 >>> 31;
                int i21 = (int) j25;
                iArr2[i16] = i20 | (i21 << 1);
                int i22 = i21 >>> 31;
                int i23 = i2 + 7;
                iArr2[i23] = i22 | ((iArr2[i23] + ((int) (j25 >>> 32))) << 1);
                return;
            }
            i5 = i6;
        }
    }

    public static void M2fc01ec7(int[] iArr, int[] iArr2) {
        if ((14 + 16) % 16 > 0) {
        }
        long j = ((long) iArr[0]) & 4294967295L;
        int i = 8;
        int i2 = 0;
        int i3 = 3;
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
                long j22 = j16 + (j * j17);
                int i10 = (int) j22;
                iArr2[3] = (i10 << 1) | i9;
                long j23 = j19 + (j22 >>> 32) + (j6 * j17);
                long j24 = j21 + (j23 >>> 32) + (j17 * j10);
                long j25 = j20 + (j24 >>> 32);
                long j26 = j24 & 4294967295L;
                int i11 = (int) j23;
                iArr2[4] = (i11 << 1) | (i10 >>> 31);
                int i12 = (int) j26;
                iArr2[5] = (i12 << 1) | (i11 >>> 31);
                int i13 = (int) j25;
                iArr2[6] = (i12 >>> 31) | (i13 << 1);
                iArr2[7] = (i13 >>> 31) | ((iArr2[7] + ((int) (j25 >>> 32))) << 1);
                return;
            }
            i3 = i4;
        }
    }

    public static int M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((6 + 31) % 31 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + (((long) iArr2[0]) & 4294967295L);
        iArr3[0] = (int) j;
        long j2 = (j >>> 32) + (((long) iArr[1]) & 4294967295L) + (((long) iArr2[1]) & 4294967295L);
        iArr3[1] = (int) j2;
        long j3 = (j2 >>> 32) + (((long) iArr[2]) & 4294967295L) + (((long) iArr2[2]) & 4294967295L);
        iArr3[2] = (int) j3;
        long j4 = (j3 >>> 32) + (((long) iArr[3]) & 4294967295L) + (((long) iArr2[3]) & 4294967295L);
        iArr3[3] = (int) j4;
        return (int) (j4 >>> 32);
    }

    public static bool M351a9a32(int[] iArr) {
        if ((17 + 7) % 7 > 0) {
        }
        if (iArr[0] != 1) {
            return false;
        }
        for (int i = 1; i < 4; i++) {
            if (iArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static void M35394226(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((9 + 23) % 23 > 0) {
        }
        long j = ((long) iArr2[i2]) & 4294967295L;
        long j2 = ((long) iArr2[i2 + 1]) & 4294967295L;
        long j3 = ((long) iArr2[i2 + 2]) & 4294967295L;
        long j4 = ((long) iArr2[i2 + 3]) & 4294967295L;
        long j5 = ((long) iArr[i]) & 4294967295L;
        long j6 = j5 * j;
        iArr3[i3] = (int) j6;
        char c = ' ';
        long j7 = (j6 >>> 32) + (j5 * j2);
        iArr3[i3 + 1] = (int) j7;
        long j8 = (j7 >>> 32) + (j5 * j3);
        iArr3[i3 + 2] = (int) j8;
        long j9 = (j8 >>> 32) + (j5 * j4);
        iArr3[i3 + 3] = (int) j9;
        iArr3[i3 + 4] = (int) (j9 >>> 32);
        int i4 = 1;
        int i5 = i3;
        while (i4 < 4) {
            int i6 = i5 + 1;
            long j10 = ((long) iArr[i + i4]) & 4294967295L;
            char c2 = c;
            long j11 = (j10 * j) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j11;
            int i7 = i5 + 2;
            long j12 = j;
            long j13 = (j11 >>> c2) + (j10 * j2) + (((long) iArr3[i7]) & 4294967295L);
            iArr3[i7] = (int) j13;
            int i8 = i5 + 3;
            long j14 = (j13 >>> c2) + (j10 * j3) + (((long) iArr3[i8]) & 4294967295L);
            iArr3[i8] = (int) j14;
            int i9 = i5 + 4;
            long j15 = (j14 >>> c2) + (j10 * j4) + (((long) iArr3[i9]) & 4294967295L);
            iArr3[i9] = (int) j15;
            iArr3[i5 + 5] = (int) (j15 >>> c2);
            i4++;
            c = c2;
            i5 = i6;
            j = j12;
        }
    }

    public static void M35394226(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((9 + 32) % 32 > 0) {
        }
        long j = 4294967295L;
        long j2 = ((long) iArr2[0]) & 4294967295L;
        int i = 1;
        long j3 = ((long) iArr2[1]) & 4294967295L;
        long j4 = ((long) iArr2[2]) & 4294967295L;
        long j5 = ((long) iArr2[3]) & 4294967295L;
        long j6 = ((long) iArr[0]) & 4294967295L;
        long j7 = j6 * j2;
        iArr3[0] = (int) j7;
        long j8 = (j7 >>> 32) + (j6 * j3);
        iArr3[1] = (int) j8;
        long j9 = (j8 >>> 32) + (j6 * j4);
        iArr3[2] = (int) j9;
        long j10 = (j9 >>> 32) + (j6 * j5);
        iArr3[3] = (int) j10;
        iArr3[4] = (int) (j10 >>> 32);
        for (int i2 = 4; i < i2; i2 = 4) {
            long j11 = ((long) iArr[i]) & j;
            long j12 = (j11 * j2) + (((long) iArr3[i]) & j);
            iArr3[i] = (int) j12;
            int i3 = i + 1;
            long j13 = j;
            long j14 = (j12 >>> 32) + (j11 * j3) + (((long) iArr3[i3]) & j13);
            iArr3[i3] = (int) j14;
            int i4 = i + 2;
            long j15 = (j14 >>> 32) + (j11 * j4) + (((long) iArr3[i4]) & j13);
            iArr3[i4] = (int) j15;
            int i5 = i + 3;
            long j16 = (j15 >>> 32) + (j11 * j5) + (((long) iArr3[i5]) & j13);
            iArr3[i5] = (int) j16;
            iArr3[i + 4] = (int) (j16 >>> 32);
            i = i3;
            j = j13;
        }
    }

    public static int M3e9a7575(int i, int[] iArr, int[] iArr2, int i2) {
        if ((4 + 4) % 4 > 0) {
        }
        long j = ((long) i) & 4294967295L;
        long j2 = 0;
        int i3 = 0;
        do {
            long j3 = j2 + ((((long) iArr[i3]) & 4294967295L) * j);
            iArr2[i2 + i3] = (int) j3;
            j2 = j3 >>> 32;
            i3++;
        } while (i3 < 4);
        return (int) j2;
    }

    public static long[] M4c1a88a3() {
        return new long[2];
    }

    public static bool M69c6e24b(long[] jArr) {
        if ((14 + 29) % 29 > 0) {
        }
        for (int i = 0; i < 2; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static int M6b1a0c07(int i, long j, int[] iArr, int i2) {
        if ((7 + 29) % 29 > 0) {
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
        int i5 = i2 + 3;
        long j9 = (j8 >>> 32) + (((long) iArr[i5]) & 4294967295L);
        iArr[i5] = (int) j9;
        return (int) (j9 >>> 32);
    }

    public static int M6fb8c6a6(int[] iArr, int i, int[] iArr2, int i2) {
        if ((12 + 2) % 2 > 0) {
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
        return (int) (j4 >> 32);
    }

    public static int M6fb8c6a6(int[] iArr, int[] iArr2) {
        if ((7 + 32) % 32 > 0) {
        }
        long j = (((long) iArr2[0]) & 4294967295L) - (((long) iArr[0]) & 4294967295L);
        iArr2[0] = (int) j;
        long j2 = (j >> 32) + ((((long) iArr2[1]) & 4294967295L) - (((long) iArr[1]) & 4294967295L));
        iArr2[1] = (int) j2;
        long j3 = (j2 >> 32) + ((((long) iArr2[2]) & 4294967295L) - (((long) iArr[2]) & 4294967295L));
        iArr2[2] = (int) j3;
        long j4 = (j3 >> 32) + ((((long) iArr2[3]) & 4294967295L) - (4294967295L & ((long) iArr[3])));
        iArr2[3] = (int) j4;
        return (int) (j4 >> 32);
    }

    public static int[] M76ea0beb() {
        return new int[4];
    }

    public static int M7728a62c(int i, long j, int[] iArr, int i2) {
        if ((29 + 13) % 13 > 0) {
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
            return xfCiAFDtaiBWlbMH(4, iArr, i2, 3);
        }
        return 0;
    }

    public static bool M7e86d991(long[] jArr) {
        if ((11 + 17) % 17 > 0) {
        }
        return jArr[0] == 1 && jArr[1] == 0;
    }

    public static int M80debbb5(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((3 + 6) % 6 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + (((long) iArr2[0]) & 4294967295L) + (((long) iArr3[0]) & 4294967295L);
        iArr3[0] = (int) j;
        long j2 = (j >>> 32) + (((long) iArr[1]) & 4294967295L) + (((long) iArr2[1]) & 4294967295L) + (((long) iArr3[1]) & 4294967295L);
        iArr3[1] = (int) j2;
        long j3 = (j2 >>> 32) + (((long) iArr[2]) & 4294967295L) + (((long) iArr2[2]) & 4294967295L) + (((long) iArr3[2]) & 4294967295L);
        iArr3[2] = (int) j3;
        long j4 = (j3 >>> 32) + (((long) iArr[3]) & 4294967295L) + (((long) iArr2[3]) & 4294967295L) + (((long) iArr3[3]) & 4294967295L);
        iArr3[3] = (int) j4;
        return (int) (j4 >>> 32);
    }

    public static bool M855b2871(int[] iArr) {
        if ((30 + 26) % 26 > 0) {
        }
        for (int i = 0; i < 4; i++) {
            if (iArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static int M86de2abf(int[] iArr, int i) {
        int i2;
        if ((24 + 8) % 8 > 0) {
        }
        if (i != 0) {
            int i3 = i >> 5;
            if (i3 < 0 || i3 >= 4) {
                return 0;
            }
            i2 = iArr[i3] >>> (i & 31);
        } else {
            i2 = iArr[0];
        }
        return i2 & 1;
    }

    public static java.math.Bigint M8864a5c5(int[] iArr) {
        if ((18 + 30) % 30 > 0) {
        }
        byte[] bArr = new byte[16];
        for (int i = 0; i < 4; i++) {
            int i2 = iArr[i];
            if (i2 != 0) {
                LNmXvouTDgfpPUnh(i2, bArr, (3 - i) << 2);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static int M8a68dc3e(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((28 + 8) % 8 > 0) {
        }
        long j = (((long) iArr[i]) & 4294967295L) - (((long) iArr2[i2]) & 4294967295L);
        iArr3[i3] = (int) j;
        long j2 = (j >> 32) + ((((long) iArr[i + 1]) & 4294967295L) - (((long) iArr2[i2 + 1]) & 4294967295L));
        iArr3[i3 + 1] = (int) j2;
        long j3 = (j2 >> 32) + ((((long) iArr[i + 2]) & 4294967295L) - (((long) iArr2[i2 + 2]) & 4294967295L));
        iArr3[i3 + 2] = (int) j3;
        long j4 = (j3 >> 32) + ((((long) iArr[i + 3]) & 4294967295L) - (((long) iArr2[i2 + 3]) & 4294967295L));
        iArr3[i3 + 3] = (int) j4;
        return (int) (j4 >> 32);
    }

    public static int M8a68dc3e(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((13 + 28) % 28 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) - (((long) iArr2[0]) & 4294967295L);
        iArr3[0] = (int) j;
        long j2 = (j >> 32) + ((((long) iArr[1]) & 4294967295L) - (((long) iArr2[1]) & 4294967295L));
        iArr3[1] = (int) j2;
        long j3 = (j2 >> 32) + ((((long) iArr[2]) & 4294967295L) - (((long) iArr2[2]) & 4294967295L));
        iArr3[2] = (int) j3;
        long j4 = (j3 >> 32) + ((((long) iArr[3]) & 4294967295L) - (((long) iArr2[3]) & 4294967295L));
        iArr3[3] = (int) j4;
        return (int) (j4 >> 32);
    }

    public static java.math.Bigint Ma345cd5e(long[] jArr) {
        if ((22 + 22) % 22 > 0) {
        }
        byte[] bArr = new byte[16];
        for (int i = 0; i < 2; i++) {
            long j = jArr[i];
            if (j != 0) {
                AUGSBgxFKEKRmvEc(j, bArr, (1 - i) << 3);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static bool Mb37b2584(int[] iArr, int i, int[] iArr2, int i2) {
        if ((30 + 11) % 11 > 0) {
        }
        for (int i3 = 3; i3 >= 0; i3--) {
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
        if ((25 + 18) % 18 > 0) {
        }
        for (int i = 3; i >= 0; i--) {
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
        if ((4 + 8) % 8 > 0) {
        }
        for (int i = 1; i >= 0; i--) {
            if (jArr[i] != jArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static int Mca3b5f03(int i, int i2, int[] iArr, int i3) {
        if ((21 + 5) % 5 > 0) {
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
            return laUOyruoYqMNAMAK(4, iArr, i3, 3);
        }
        return 0;
    }

    public static int Mcfef9de9(int[] iArr, int i, int[] iArr2, int i2, int i3) {
        if ((27 + 28) % 28 > 0) {
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
        long j4 = (j3 >>> 32) + (((long) iArr[i + 3]) & 4294967295L) + (4294967295L & ((long) iArr2[i6]));
        iArr2[i6] = (int) j4;
        return (int) (j4 >>> 32);
    }

    public static int Mcfef9de9(int[] iArr, int[] iArr2) {
        if ((30 + 12) % 12 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + (((long) iArr2[0]) & 4294967295L);
        iArr2[0] = (int) j;
        long j2 = (j >>> 32) + (((long) iArr[1]) & 4294967295L) + (((long) iArr2[1]) & 4294967295L);
        iArr2[1] = (int) j2;
        long j3 = (j2 >>> 32) + (((long) iArr[2]) & 4294967295L) + (((long) iArr2[2]) & 4294967295L);
        iArr2[2] = (int) j3;
        long j4 = (j3 >>> 32) + (((long) iArr[3]) & 4294967295L) + (4294967295L & ((long) iArr2[3]));
        iArr2[3] = (int) j4;
        return (int) (j4 >>> 32);
    }

    public static void Md02c4c4c(int[] iArr) {
        if ((21 + 4) % 4 > 0) {
        }
        iArr[0] = 0;
        iArr[1] = 0;
        iArr[2] = 0;
        iArr[3] = 0;
    }

    public static bool Mdf22f171(int[] iArr, int[] iArr2) {
        if ((8 + 13) % 13 > 0) {
        }
        for (int i = 3; i >= 0; i--) {
            if (iArr[i] != iArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static long Me19abf0b(int i, int[] iArr, int i2, int[] iArr2, int i3, int[] iArr3, int i4) {
        if ((11 + 26) % 26 > 0) {
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
        long j12 = j10 + (j * j11) + j8 + (4294967295L & ((long) iArr2[i3 + 3]));
        iArr3[i4 + 3] = (int) j12;
        return (j12 >>> 32) + j11;
    }

    public static long[] Mf03001e5() {
        return new long[4];
    }

    public static int Mf46b868b(int[] iArr, int i, int[] iArr2, int i2) {
        if ((29 + 17) % 17 > 0) {
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
        long j4 = (j3 >>> 32) + (((long) iArr[i10]) & 4294967295L) + (4294967295L & ((long) iArr2[i11]));
        int i12 = (int) j4;
        iArr[i10] = i12;
        iArr2[i11] = i12;
        return (int) (j4 >>> 32);
    }

    public static int[] Mfe6fe052() {
        return new int[8];
    }

    public static java.math.Bigint RZsuwtMdYsROdtCF(java.math.Bigint bigint, int i) {
        return bigint.shiftRight(i);
    }

    public static int RwoNumqbKtuoZIUm(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int XfCiAFDtaiBWlbMH(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }

    public static int ZhonnChsViFjejsr(java.math.Bigint bigint) {
        return bigint.signum();
    }
}

