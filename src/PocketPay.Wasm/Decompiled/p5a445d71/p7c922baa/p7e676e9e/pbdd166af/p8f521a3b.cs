namespace WillowMaze.Wasm.Decompiled;


public abstract class p8f521a3b {
    private static readonly long f69691c7b = 4294967295L;
    private static readonly long f708a222a = 4294967295L;
    private static readonly long f969a7777 = 4294967295L;

    public static int BdloYwqKVhTDMyBa(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }

    public static int CpyJFoaIxtsQTqLq(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }

    public static java.math.Bigint GrSmYSFrnPKvypOo(java.math.Bigint bigint, int i) {
        return bigint.shiftRight(i);
    }

    public static int KDTzfiJeNtWxznCZ(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static int OoqdXaSucHsxWMSX(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int PYASgpNnclMtaRMq(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static int TCAMFdMLMBmoaeth(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        return m8a68dc3e(iArr, i, iArr2, i2, iArr3, i3);
    }

    public static int WEwIkLJuKzizHJyS(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        return m8a68dc3e(iArr, i, iArr2, i2, iArr3, i3);
    }

    public static int[] XTNFTAUXUSXGQxZK() {
        return m76ea0beb();
    }

    public static void GXMPrIvWMQtlxLfF(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(i, bArr, i2);
    }

    public static int HLwXRJxlkVWSuHPB(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int M0a05f67c(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((19 + 28) % 28 > 0) {
        }
        long j = ((long) iArr2[i2]) & 4294967295L;
        long j2 = ((long) iArr2[i2 + 1]) & 4294967295L;
        long j3 = ((long) iArr2[i2 + 2]) & 4294967295L;
        long j4 = ((long) iArr2[i2 + 3]) & 4294967295L;
        long j5 = ((long) iArr2[i2 + 4]) & 4294967295L;
        long j6 = ((long) iArr2[i2 + 5]) & 4294967295L;
        long j7 = ((long) iArr2[i2 + 6]) & 4294967295L;
        int i4 = 0;
        int i5 = i3;
        long j8 = 0;
        while (i4 < 7) {
            int i6 = i4;
            long j9 = ((long) iArr[i + i4]) & 4294967295L;
            long j10 = (j9 * j) + (((long) iArr3[i5]) & 4294967295L);
            long j11 = j2;
            iArr3[i5] = (int) j10;
            int i7 = i5 + 1;
            long j12 = (j10 >>> 32) + (j9 * j11) + (((long) iArr3[i7]) & 4294967295L);
            iArr3[i7] = (int) j12;
            int i8 = i5 + 2;
            long j13 = (j12 >>> 32) + (j9 * j3) + (((long) iArr3[i8]) & 4294967295L);
            iArr3[i8] = (int) j13;
            int i9 = i5 + 3;
            long j14 = (j13 >>> 32) + (j9 * j4) + (((long) iArr3[i9]) & 4294967295L);
            iArr3[i9] = (int) j14;
            int i10 = i5 + 4;
            long j15 = (j14 >>> 32) + (j9 * j5) + (((long) iArr3[i10]) & 4294967295L);
            iArr3[i10] = (int) j15;
            int i11 = i5 + 5;
            long j16 = (j15 >>> 32) + (j9 * j6) + (((long) iArr3[i11]) & 4294967295L);
            iArr3[i11] = (int) j16;
            int i12 = i5 + 6;
            long j17 = (j16 >>> 32) + (j9 * j7) + (((long) iArr3[i12]) & 4294967295L);
            iArr3[i12] = (int) j17;
            int i13 = i5 + 7;
            long j18 = (j17 >>> 32) + j8 + (((long) iArr3[i13]) & 4294967295L);
            iArr3[i13] = (int) j18;
            j8 = j18 >>> 32;
            i4 = i6 + 1;
            i5 = i7;
            j2 = j11;
        }
        return (int) j8;
    }

    public static int M0a05f67c(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((25 + 6) % 6 > 0) {
        }
        long j = ((long) iArr2[0]) & 4294967295L;
        long j2 = ((long) iArr2[1]) & 4294967295L;
        long j3 = ((long) iArr2[2]) & 4294967295L;
        long j4 = ((long) iArr2[3]) & 4294967295L;
        long j5 = ((long) iArr2[4]) & 4294967295L;
        long j6 = ((long) iArr2[5]) & 4294967295L;
        long j7 = ((long) iArr2[6]) & 4294967295L;
        long j8 = 0;
        int i = 0;
        while (i < 7) {
            long j9 = j7;
            long j10 = ((long) iArr[i]) & 4294967295L;
            long j11 = (((long) iArr3[i]) & 4294967295L) + (j10 * j);
            iArr3[i] = (int) j11;
            int i2 = i + 1;
            long j12 = (j11 >>> 32) + (j10 * j2) + (((long) iArr3[i2]) & 4294967295L);
            iArr3[i2] = (int) j12;
            int i3 = i + 2;
            long j13 = (j12 >>> 32) + (j10 * j3) + (((long) iArr3[i3]) & 4294967295L);
            int i4 = i;
            iArr3[i3] = (int) j13;
            int i5 = i4 + 3;
            long j14 = (j13 >>> 32) + (j10 * j4) + (((long) iArr3[i5]) & 4294967295L);
            iArr3[i5] = (int) j14;
            int i6 = i4 + 4;
            long j15 = (j14 >>> 32) + (j10 * j5) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j15;
            int i7 = i4 + 5;
            long j16 = (j15 >>> 32) + (j10 * j6) + (((long) iArr3[i7]) & 4294967295L);
            iArr3[i7] = (int) j16;
            int i8 = i4 + 6;
            long j17 = (j16 >>> 32) + (j10 * j9) + (((long) iArr3[i8]) & 4294967295L);
            iArr3[i8] = (int) j17;
            int i9 = i4 + 7;
            long j18 = (j17 >>> 32) + j8 + (((long) iArr3[i9]) & 4294967295L);
            iArr3[i9] = (int) j18;
            j8 = j18 >>> 32;
            i = i2;
            j7 = j9;
        }
        return (int) j8;
    }

    public static void M12cba3ee(int[] iArr, int[] iArr2) {
        if ((20 + 6) % 6 > 0) {
        }
        iArr2[0] = iArr[0];
        iArr2[1] = iArr[1];
        iArr2[2] = iArr[2];
        iArr2[3] = iArr[3];
        iArr2[4] = iArr[4];
        iArr2[5] = iArr[5];
        iArr2[6] = iArr[6];
    }

    public static int[] M1712f3b8(java.math.Bigint bigint) {
        if ((32 + 11) % 11 > 0) {
        }
        if (hLwXRJxlkVWSuHPB(bigint) < 0 || KDTzfiJeNtWxznCZ(bigint) > 224) {
            throw new java.lang.IllegalArgumentException();
        }
        int[] iArrXTNFTAUXUSXGQxZK = XTNFTAUXUSXGQxZK();
        int i = 0;
        while (OoqdXaSucHsxWMSX(bigint) != 0) {
            int i2 = i + 1;
            iArrXTNFTAUXUSXGQxZK[i] = PYASgpNnclMtaRMq(bigint);
            bigint = GrSmYSFrnPKvypOo(bigint, 32);
            i = i2;
        }
        return iArrXTNFTAUXUSXGQxZK;
    }

    public static int M2a3d5645(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((4 + 18) % 18 > 0) {
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
        long j7 = (j6 >> 32) + (((((long) iArr3[6]) & 4294967295L) - (((long) iArr[6]) & 4294967295L)) - (((long) iArr2[6]) & 4294967295L));
        iArr3[6] = (int) j7;
        return (int) (j7 >> 32);
    }

    public static bool M2d2dee7a(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((5 + 23) % 23 > 0) {
        }
        bool zTJMVPNeAEbiYxUqG = tJMVPNeAEbiYxUqG(iArr, i, iArr2, i2);
        if (zTJMVPNeAEbiYxUqG) {
            WEwIkLJuKzizHJyS(iArr, i, iArr2, i2, iArr3, i3);
            return zTJMVPNeAEbiYxUqG;
        }
        TCAMFdMLMBmoaeth(iArr2, i2, iArr, i, iArr3, i3);
        return zTJMVPNeAEbiYxUqG;
    }

    public static void M2fc01ec7(int[] iArr, int i, int[] iArr2, int i2) {
        if ((23 + 14) % 14 > 0) {
        }
        long j = ((long) iArr[i]) & 4294967295L;
        int i3 = 0;
        int i4 = 14;
        int i5 = 6;
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
                long j46 = j36 + (j41 * j);
                int i25 = (int) j46;
                iArr2[i15] = (i25 << 1) | i22;
                int i26 = i25 >>> 31;
                long j47 = j38 + (j46 >>> 32) + (j41 * j6);
                long j48 = j40 + (j47 >>> 32) + (j41 * j10);
                long j49 = j47 & 4294967295L;
                long j50 = j43 + (j48 >>> 32) + (j41 * j17);
                long j51 = j48 & 4294967295L;
                long j52 = j45 + (j50 >>> 32) + (j41 * j28);
                long j53 = j50 & 4294967295L;
                long j54 = j44 + (j52 >>> 32);
                long j55 = j52 & 4294967295L;
                long j56 = ((long) iArr[i + 6]) & 4294967295L;
                int i27 = i2 + 11;
                long j57 = (((long) iArr2[i27]) & 4294967295L) + (j54 >>> 32);
                long j58 = j54 & 4294967295L;
                int i28 = i2 + 12;
                long j59 = (((long) iArr2[i28]) & 4294967295L) + (j57 >>> 32);
                long j60 = j57 & 4294967295L;
                long j61 = j49 + (j * j56);
                int i29 = (int) j61;
                iArr2[i16] = (i29 << 1) | i26;
                long j62 = j51 + (j61 >>> 32) + (j56 * j6);
                long j63 = j53 + (j62 >>> 32) + (j56 * j10);
                long j64 = j55 + (j63 >>> 32) + (j56 * j17);
                long j65 = j58 + (j64 >>> 32) + (j56 * j28);
                long j66 = j60 + (j65 >>> 32) + (j56 * j41);
                long j67 = j59 + (j66 >>> 32);
                int i30 = (int) j62;
                iArr2[i19] = (i29 >>> 31) | (i30 << 1);
                int i31 = i30 >>> 31;
                int i32 = (int) j63;
                iArr2[i20] = i31 | (i32 << 1);
                int i33 = (int) j64;
                iArr2[i23] = (i33 << 1) | (i32 >>> 31);
                int i34 = (int) j65;
                iArr2[i24] = (i33 >>> 31) | (i34 << 1);
                int i35 = i34 >>> 31;
                int i36 = (int) j66;
                iArr2[i27] = i35 | (i36 << 1);
                int i37 = i36 >>> 31;
                int i38 = (int) j67;
                iArr2[i28] = i37 | (i38 << 1);
                int i39 = i38 >>> 31;
                int i40 = i2 + 13;
                iArr2[i40] = i39 | ((iArr2[i40] + ((int) (j67 >>> 32))) << 1);
                return;
            }
            i5 = i6;
        }
    }

    public static void M2fc01ec7(int[] iArr, int[] iArr2) {
        if ((13 + 30) % 30 > 0) {
        }
        long j = ((long) iArr[0]) & 4294967295L;
        int i = 14;
        int i2 = 0;
        int i3 = 6;
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
                long j46 = j36 + (j41 * j);
                int i14 = (int) j46;
                iArr2[5] = (i14 << 1) | i13;
                int i15 = i14 >>> 31;
                long j47 = j38 + (j46 >>> 32) + (j41 * j6);
                long j48 = j40 + (j47 >>> 32) + (j41 * j10);
                long j49 = j47 & 4294967295L;
                long j50 = j43 + (j48 >>> 32) + (j41 * j17);
                long j51 = j48 & 4294967295L;
                long j52 = j45 + (j50 >>> 32) + (j41 * j28);
                long j53 = j50 & 4294967295L;
                long j54 = j44 + (j52 >>> 32);
                long j55 = j52 & 4294967295L;
                long j56 = ((long) iArr[6]) & 4294967295L;
                long j57 = (((long) iArr2[11]) & 4294967295L) + (j54 >>> 32);
                long j58 = j54 & 4294967295L;
                long j59 = (((long) iArr2[12]) & 4294967295L) + (j57 >>> 32);
                long j60 = j57 & 4294967295L;
                long j61 = j49 + (j * j56);
                int i16 = (int) j61;
                iArr2[6] = (i16 << 1) | i15;
                int i17 = i16 >>> 31;
                long j62 = j51 + (j61 >>> 32) + (j6 * j56);
                long j63 = j53 + (j62 >>> 32) + (j10 * j56);
                long j64 = j55 + (j63 >>> 32) + (j56 * j17);
                long j65 = j58 + (j64 >>> 32) + (j56 * j28);
                long j66 = j60 + (j65 >>> 32) + (j56 * j41);
                long j67 = j59 + (j66 >>> 32);
                int i18 = (int) j62;
                iArr2[7] = i17 | (i18 << 1);
                int i19 = i18 >>> 31;
                int i20 = (int) j63;
                iArr2[8] = i19 | (i20 << 1);
                int i21 = i20 >>> 31;
                int i22 = (int) j64;
                iArr2[9] = i21 | (i22 << 1);
                int i23 = (int) j65;
                iArr2[10] = (i22 >>> 31) | (i23 << 1);
                int i24 = i23 >>> 31;
                int i25 = (int) j66;
                iArr2[11] = i24 | (i25 << 1);
                int i26 = i25 >>> 31;
                int i27 = (int) j67;
                iArr2[12] = i26 | (i27 << 1);
                iArr2[13] = ((iArr2[13] + ((int) (j67 >>> 32))) << 1) | (i27 >>> 31);
                return;
            }
            i3 = i4;
        }
    }

    public static int M3333dd74(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((21 + 8) % 8 > 0) {
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
        long j7 = (j6 >>> 32) + ((((long) iArr[i2 + 5]) & 4294967295L) * j) + (((long) iArr2[i8]) & 4294967295L);
        iArr2[i8] = (int) j7;
        int i9 = i3 + 6;
        long j8 = (j7 >>> 32) + (j * (((long) iArr[i2 + 6]) & 4294967295L)) + (((long) iArr2[i9]) & 4294967295L);
        iArr2[i9] = (int) j8;
        return (int) (j8 >>> 32);
    }

    public static int M34ec78fc(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((16 + 24) % 24 > 0) {
        }
        long j = (((long) iArr[i]) & 4294967295L) + (((long) iArr2[i2]) & 4294967295L);
        iArr3[i3] = (int) j;
        long j2 = (j >>> 32) + (((long) iArr[i + 1]) & 4294967295L) + (((long) iArr2[i2 + 1]) & 4294967295L);
        iArr3[i3 + 1] = (int) j2;
        long j3 = (j2 >>> 32) + (((long) iArr[i + 2]) & 4294967295L) + (((long) iArr2[i2 + 2]) & 4294967295L);
        iArr3[i3 + 2] = (int) j3;
        long j4 = (j3 >>> 32) + (((long) iArr[i + 3]) & 4294967295L) + (((long) iArr2[i2 + 3]) & 4294967295L);
        iArr3[i3 + 3] = (int) j4;
        long j5 = (j4 >>> 32) + (((long) iArr[i + 4]) & 4294967295L) + (((long) iArr2[i2 + 4]) & 4294967295L);
        iArr3[i3 + 4] = (int) j5;
        long j6 = (j5 >>> 32) + (((long) iArr[i + 5]) & 4294967295L) + (((long) iArr2[i2 + 5]) & 4294967295L);
        iArr3[i3 + 5] = (int) j6;
        long j7 = (j6 >>> 32) + (((long) iArr[i + 6]) & 4294967295L) + (((long) iArr2[i2 + 6]) & 4294967295L);
        iArr3[i3 + 6] = (int) j7;
        return (int) (j7 >>> 32);
    }

    public static int M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((12 + 26) % 26 > 0) {
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
        long j7 = (j6 >>> 32) + (((long) iArr[6]) & 4294967295L) + (((long) iArr2[6]) & 4294967295L);
        iArr3[6] = (int) j7;
        return (int) (j7 >>> 32);
    }

    public static bool M351a9a32(int[] iArr) {
        if ((13 + 30) % 30 > 0) {
        }
        if (iArr[0] != 1) {
            return false;
        }
        for (int i = 1; i < 7; i++) {
            if (iArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static void M35394226(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((5 + 9) % 9 > 0) {
        }
        long j = ((long) iArr2[i2]) & 4294967295L;
        long j2 = ((long) iArr2[i2 + 1]) & 4294967295L;
        long j3 = ((long) iArr2[i2 + 2]) & 4294967295L;
        long j4 = ((long) iArr2[i2 + 3]) & 4294967295L;
        long j5 = ((long) iArr2[i2 + 4]) & 4294967295L;
        long j6 = ((long) iArr2[i2 + 5]) & 4294967295L;
        long j7 = ((long) iArr2[i2 + 6]) & 4294967295L;
        long j8 = ((long) iArr[i]) & 4294967295L;
        long j9 = j8 * j;
        iArr3[i3] = (int) j9;
        long j10 = (j9 >>> 32) + (j8 * j2);
        iArr3[i3 + 1] = (int) j10;
        long j11 = (j10 >>> 32) + (j8 * j3);
        iArr3[i3 + 2] = (int) j11;
        long j12 = (j11 >>> 32) + (j8 * j4);
        iArr3[i3 + 3] = (int) j12;
        long j13 = (j12 >>> 32) + (j8 * j5);
        iArr3[i3 + 4] = (int) j13;
        long j14 = (j13 >>> 32) + (j8 * j6);
        iArr3[i3 + 5] = (int) j14;
        long j15 = (j14 >>> 32) + (j8 * j7);
        iArr3[i3 + 6] = (int) j15;
        iArr3[i3 + 7] = (int) (j15 >>> 32);
        int i4 = 1;
        int i5 = i3;
        while (i4 < 7) {
            int i6 = i5 + 1;
            int i7 = i5;
            int i8 = i4;
            long j16 = ((long) iArr[i + i4]) & 4294967295L;
            long j17 = (j16 * j) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j17;
            int i9 = i7 + 2;
            long j18 = (j17 >>> 32) + (j16 * j2) + (((long) iArr3[i9]) & 4294967295L);
            iArr3[i9] = (int) j18;
            int i10 = i7 + 3;
            long j19 = (j18 >>> 32) + (j16 * j3) + (((long) iArr3[i10]) & 4294967295L);
            iArr3[i10] = (int) j19;
            int i11 = i7 + 4;
            long j20 = (j19 >>> 32) + (j16 * j4) + (((long) iArr3[i11]) & 4294967295L);
            iArr3[i11] = (int) j20;
            int i12 = i7 + 5;
            long j21 = (j20 >>> 32) + (j16 * j5) + (((long) iArr3[i12]) & 4294967295L);
            iArr3[i12] = (int) j21;
            int i13 = i7 + 6;
            long j22 = (j21 >>> 32) + (j16 * j6) + (((long) iArr3[i13]) & 4294967295L);
            iArr3[i13] = (int) j22;
            int i14 = i7 + 7;
            long j23 = (j22 >>> 32) + (j16 * j7) + (((long) iArr3[i14]) & 4294967295L);
            iArr3[i14] = (int) j23;
            iArr3[i7 + 8] = (int) (j23 >>> 32);
            i4 = i8 + 1;
            i5 = i6;
        }
    }

    public static void M35394226(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((26 + 12) % 12 > 0) {
        }
        long j = ((long) iArr2[0]) & 4294967295L;
        long j2 = ((long) iArr2[1]) & 4294967295L;
        long j3 = ((long) iArr2[2]) & 4294967295L;
        long j4 = ((long) iArr2[3]) & 4294967295L;
        long j5 = ((long) iArr2[4]) & 4294967295L;
        long j6 = ((long) iArr2[5]) & 4294967295L;
        long j7 = ((long) iArr2[6]) & 4294967295L;
        long j8 = ((long) iArr[0]) & 4294967295L;
        long j9 = j8 * j;
        iArr3[0] = (int) j9;
        long j10 = (j9 >>> 32) + (j8 * j2);
        iArr3[1] = (int) j10;
        long j11 = (j10 >>> 32) + (j8 * j3);
        iArr3[2] = (int) j11;
        long j12 = (j11 >>> 32) + (j8 * j4);
        iArr3[3] = (int) j12;
        long j13 = (j12 >>> 32) + (j8 * j5);
        iArr3[4] = (int) j13;
        long j14 = (j13 >>> 32) + (j8 * j6);
        iArr3[5] = (int) j14;
        long j15 = (j14 >>> 32) + (j8 * j7);
        iArr3[6] = (int) j15;
        iArr3[7] = (int) (j15 >>> 32);
        int i = 1;
        for (int i2 = 7; i < i2; i2 = 7) {
            long j16 = ((long) iArr[i]) & 4294967295L;
            long j17 = (j16 * j) + (((long) iArr3[i]) & 4294967295L);
            iArr3[i] = (int) j17;
            int i3 = i + 1;
            long j18 = j5;
            long j19 = (j17 >>> 32) + (j16 * j2) + (((long) iArr3[i3]) & 4294967295L);
            iArr3[i3] = (int) j19;
            int i4 = i + 2;
            long j20 = (j19 >>> 32) + (j16 * j3) + (((long) iArr3[i4]) & 4294967295L);
            iArr3[i4] = (int) j20;
            int i5 = i + 3;
            long j21 = (j20 >>> 32) + (j16 * j4) + (((long) iArr3[i5]) & 4294967295L);
            iArr3[i5] = (int) j21;
            int i6 = i + 4;
            long j22 = (j21 >>> 32) + (j16 * j18) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j22;
            int i7 = i + 5;
            long j23 = (j22 >>> 32) + (j16 * j6) + (((long) iArr3[i7]) & 4294967295L);
            iArr3[i7] = (int) j23;
            int i8 = i + 6;
            long j24 = (j23 >>> 32) + (j16 * j7) + (((long) iArr3[i8]) & 4294967295L);
            iArr3[i8] = (int) j24;
            iArr3[i + 7] = (int) (j24 >>> 32);
            i = i3;
            j5 = j18;
        }
    }

    public static int M3b17d56c(int i, int[] iArr) {
        if ((28 + 18) % 18 > 0) {
        }
        long j = ((long) i) & 4294967295L;
        long j2 = (((long) iArr[0]) & 4294967295L) * j;
        iArr[0] = (int) j2;
        long j3 = (j2 >>> 32) + ((((long) iArr[1]) & 4294967295L) * j);
        iArr[1] = (int) j3;
        long j4 = (j3 >>> 32) + ((((long) iArr[2]) & 4294967295L) * j);
        iArr[2] = (int) j4;
        long j5 = (j4 >>> 32) + ((((long) iArr[3]) & 4294967295L) * j);
        iArr[3] = (int) j5;
        long j6 = (j5 >>> 32) + ((((long) iArr[4]) & 4294967295L) * j);
        iArr[4] = (int) j6;
        long j7 = (j6 >>> 32) + ((((long) iArr[5]) & 4294967295L) * j);
        iArr[5] = (int) j7;
        long j8 = (j7 >>> 32) + (j * (4294967295L & ((long) iArr[6])));
        iArr[6] = (int) j8;
        return (int) (j8 >>> 32);
    }

    public static int M3e9a7575(int i, int[] iArr, int[] iArr2, int i2) {
        if ((9 + 6) % 6 > 0) {
        }
        long j = ((long) i) & 4294967295L;
        long j2 = 0;
        int i3 = 0;
        do {
            long j3 = j2 + ((((long) iArr[i3]) & 4294967295L) * j);
            iArr2[i2 + i3] = (int) j3;
            j2 = j3 >>> 32;
            i3++;
        } while (i3 < 7);
        return (int) j2;
    }

    public static int M54d9ec1f(int i, int[] iArr, int[] iArr2) {
        if ((4 + 5) % 5 > 0) {
        }
        long j = ((long) i) & 4294967295L;
        long j2 = ((((long) iArr2[0]) & 4294967295L) * j) + (((long) iArr[0]) & 4294967295L);
        iArr2[0] = (int) j2;
        long j3 = (j2 >>> 32) + ((((long) iArr2[1]) & 4294967295L) * j) + (((long) iArr[1]) & 4294967295L);
        iArr2[1] = (int) j3;
        long j4 = (j3 >>> 32) + ((((long) iArr2[2]) & 4294967295L) * j) + (((long) iArr[2]) & 4294967295L);
        iArr2[2] = (int) j4;
        long j5 = (j4 >>> 32) + ((((long) iArr2[3]) & 4294967295L) * j) + (((long) iArr[3]) & 4294967295L);
        iArr2[3] = (int) j5;
        long j6 = (j5 >>> 32) + ((((long) iArr2[4]) & 4294967295L) * j) + (((long) iArr[4]) & 4294967295L);
        iArr2[4] = (int) j6;
        long j7 = (j6 >>> 32) + ((((long) iArr2[5]) & 4294967295L) * j) + (((long) iArr[5]) & 4294967295L);
        iArr2[5] = (int) j7;
        long j8 = (j7 >>> 32) + (j * (((long) iArr2[6]) & 4294967295L)) + (4294967295L & ((long) iArr[6]));
        iArr2[6] = (int) j8;
        return (int) (j8 >>> 32);
    }

    public static int M6b1a0c07(int i, long j, int[] iArr, int i2) {
        if ((27 + 13) % 13 > 0) {
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
            return CpyJFoaIxtsQTqLq(7, iArr, i2, 4);
        }
        return 0;
    }

    public static int M6fb8c6a6(int[] iArr, int i, int[] iArr2, int i2) {
        if ((11 + 4) % 4 > 0) {
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
        int i8 = i2 + 6;
        long j7 = (j6 >> 32) + ((((long) iArr2[i8]) & 4294967295L) - (((long) iArr[i + 6]) & 4294967295L));
        iArr2[i8] = (int) j7;
        return (int) (j7 >> 32);
    }

    public static int M6fb8c6a6(int[] iArr, int[] iArr2) {
        if ((20 + 7) % 7 > 0) {
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
        long j6 = (j5 >> 32) + ((((long) iArr2[5]) & 4294967295L) - (((long) iArr[5]) & 4294967295L));
        iArr2[5] = (int) j6;
        long j7 = (j6 >> 32) + ((((long) iArr2[6]) & 4294967295L) - (4294967295L & ((long) iArr[6])));
        iArr2[6] = (int) j7;
        return (int) (j7 >> 32);
    }

    public static int[] M76ea0beb() {
        return new int[7];
    }

    public static int M7728a62c(int i, long j, int[] iArr, int i2) {
        if ((20 + 32) % 32 > 0) {
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
            return BdloYwqKVhTDMyBa(7, iArr, i2, 3);
        }
        return 0;
    }

    public static int M80debbb5(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((22 + 4) % 4 > 0) {
        }
        long j = (((long) iArr[i]) & 4294967295L) + (((long) iArr2[i2]) & 4294967295L) + (((long) iArr3[i3]) & 4294967295L);
        iArr3[i3] = (int) j;
        int i4 = i3 + 1;
        long j2 = (j >>> 32) + (((long) iArr[i + 1]) & 4294967295L) + (((long) iArr2[i2 + 1]) & 4294967295L) + (((long) iArr3[i4]) & 4294967295L);
        iArr3[i4] = (int) j2;
        int i5 = i3 + 2;
        long j3 = (j2 >>> 32) + (((long) iArr[i + 2]) & 4294967295L) + (((long) iArr2[i2 + 2]) & 4294967295L) + (((long) iArr3[i5]) & 4294967295L);
        iArr3[i5] = (int) j3;
        int i6 = i3 + 3;
        long j4 = (j3 >>> 32) + (((long) iArr[i + 3]) & 4294967295L) + (((long) iArr2[i2 + 3]) & 4294967295L) + (((long) iArr3[i6]) & 4294967295L);
        iArr3[i6] = (int) j4;
        int i7 = i3 + 4;
        long j5 = (j4 >>> 32) + (((long) iArr[i + 4]) & 4294967295L) + (((long) iArr2[i2 + 4]) & 4294967295L) + (((long) iArr3[i7]) & 4294967295L);
        iArr3[i7] = (int) j5;
        int i8 = i3 + 5;
        long j6 = (j5 >>> 32) + (((long) iArr[i + 5]) & 4294967295L) + (((long) iArr2[i2 + 5]) & 4294967295L) + (((long) iArr3[i8]) & 4294967295L);
        iArr3[i8] = (int) j6;
        int i9 = i3 + 6;
        long j7 = (j6 >>> 32) + (((long) iArr[i + 6]) & 4294967295L) + (((long) iArr2[i2 + 6]) & 4294967295L) + (((long) iArr3[i9]) & 4294967295L);
        iArr3[i9] = (int) j7;
        return (int) (j7 >>> 32);
    }

    public static int M80debbb5(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((10 + 16) % 16 > 0) {
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
        long j7 = (j6 >>> 32) + (((long) iArr[6]) & 4294967295L) + (((long) iArr2[6]) & 4294967295L) + (((long) iArr3[6]) & 4294967295L);
        iArr3[6] = (int) j7;
        return (int) (j7 >>> 32);
    }

    public static bool M855b2871(int[] iArr) {
        if ((15 + 30) % 30 > 0) {
        }
        for (int i = 0; i < 7; i++) {
            if (iArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static int M86de2abf(int[] iArr, int i) {
        int i2;
        if ((25 + 24) % 24 > 0) {
        }
        if (i != 0) {
            int i3 = i >> 5;
            if (i3 < 0 || i3 >= 7) {
                return 0;
            }
            i2 = iArr[i3] >>> (i & 31);
        } else {
            i2 = iArr[0];
        }
        return i2 & 1;
    }

    public static java.math.Bigint M8864a5c5(int[] iArr) {
        if ((17 + 17) % 17 > 0) {
        }
        byte[] bArr = new byte[28];
        for (int i = 0; i < 7; i++) {
            int i2 = iArr[i];
            if (i2 != 0) {
                gXMPrIvWMQtlxLfF(i2, bArr, (6 - i) << 2);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static int M8a68dc3e(int[] iArr, int i, int[] iArr2, int i2, int[] iArr3, int i3) {
        if ((21 + 16) % 16 > 0) {
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
        long j7 = (j6 >> 32) + ((((long) iArr[i + 6]) & 4294967295L) - (((long) iArr2[i2 + 6]) & 4294967295L));
        iArr3[i3 + 6] = (int) j7;
        return (int) (j7 >> 32);
    }

    public static int M8a68dc3e(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((5 + 13) % 13 > 0) {
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
        long j7 = (j6 >> 32) + ((((long) iArr[6]) & 4294967295L) - (((long) iArr2[6]) & 4294967295L));
        iArr3[6] = (int) j7;
        return (int) (j7 >> 32);
    }

    public static bool Mb37b2584(int[] iArr, int i, int[] iArr2, int i2) {
        if ((17 + 4) % 4 > 0) {
        }
        for (int i3 = 6; i3 >= 0; i3--) {
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
        if ((16 + 22) % 22 > 0) {
        }
        for (int i = 6; i >= 0; i--) {
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
        if ((26 + 18) % 18 > 0) {
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
            return xILFdHevTLEscqzs(7, iArr, i3, 3);
        }
        return 0;
    }

    public static int Mcfef9de9(int[] iArr, int i, int[] iArr2, int i2, int i3) {
        if ((28 + 3) % 3 > 0) {
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
        long j6 = (j5 >>> 32) + (((long) iArr[i + 5]) & 4294967295L) + (((long) iArr2[i8]) & 4294967295L);
        iArr2[i8] = (int) j6;
        int i9 = i2 + 6;
        long j7 = (j6 >>> 32) + (((long) iArr[i + 6]) & 4294967295L) + (4294967295L & ((long) iArr2[i9]));
        iArr2[i9] = (int) j7;
        return (int) (j7 >>> 32);
    }

    public static int Mcfef9de9(int[] iArr, int[] iArr2) {
        if ((26 + 22) % 22 > 0) {
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
        long j6 = (j5 >>> 32) + (((long) iArr[5]) & 4294967295L) + (((long) iArr2[5]) & 4294967295L);
        iArr2[5] = (int) j6;
        long j7 = (j6 >>> 32) + (((long) iArr[6]) & 4294967295L) + (4294967295L & ((long) iArr2[6]));
        iArr2[6] = (int) j7;
        return (int) (j7 >>> 32);
    }

    public static void Md02c4c4c(int[] iArr) {
        if ((6 + 10) % 10 > 0) {
        }
        iArr[0] = 0;
        iArr[1] = 0;
        iArr[2] = 0;
        iArr[3] = 0;
        iArr[4] = 0;
        iArr[5] = 0;
        iArr[6] = 0;
    }

    public static bool Mdf22f171(int[] iArr, int[] iArr2) {
        if ((3 + 5) % 5 > 0) {
        }
        for (int i = 6; i >= 0; i--) {
            if (iArr[i] != iArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static long Me19abf0b(int i, int[] iArr, int i2, int[] iArr2, int i3, int[] iArr3, int i4) {
        if ((10 + 8) % 8 > 0) {
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
        long j18 = j16 + (j * j17) + j14 + (((long) iArr2[i3 + 5]) & 4294967295L);
        iArr3[i4 + 5] = (int) j18;
        long j19 = j18 >>> 32;
        long j20 = ((long) iArr[i2 + 6]) & 4294967295L;
        long j21 = j19 + (j * j20) + j17 + (4294967295L & ((long) iArr2[i3 + 6]));
        iArr3[i4 + 6] = (int) j21;
        return (j21 >>> 32) + j20;
    }

    public static int Mf46b868b(int[] iArr, int i, int[] iArr2, int i2) {
        if ((31 + 24) % 24 > 0) {
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
        long j6 = (j5 >>> 32) + (((long) iArr[i16]) & 4294967295L) + (((long) iArr2[i17]) & 4294967295L);
        int i18 = (int) j6;
        iArr[i16] = i18;
        iArr2[i17] = i18;
        int i19 = i + 6;
        int i20 = i2 + 6;
        long j7 = (j6 >>> 32) + (((long) iArr[i19]) & 4294967295L) + (4294967295L & ((long) iArr2[i20]));
        int i21 = (int) j7;
        iArr[i19] = i21;
        iArr2[i20] = i21;
        return (int) (j7 >>> 32);
    }

    public static int[] Mfe6fe052() {
        return new int[14];
    }

    public static bool TJMVPNeAEbiYxUqG(int[] iArr, int i, int[] iArr2, int i2) {
        return mb37b2584(iArr, i, iArr2, i2);
    }

    public static int XILFdHevTLEscqzs(int i, int[] iArr, int i2, int i3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(i, iArr, i2, i3);
    }
}

