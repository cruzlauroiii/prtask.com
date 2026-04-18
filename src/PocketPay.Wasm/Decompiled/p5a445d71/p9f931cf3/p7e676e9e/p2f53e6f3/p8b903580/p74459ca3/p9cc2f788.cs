namespace WillowMaze.Wasm.Decompiled;


public class p9cc2f788 {
    private static readonly long f07f3fc4c = 4294967295L;
    private static readonly long f17beebd0 = 4294967295L;
    private static readonly int f180ad68c = -1;
    static readonly int[] f3e06f45b = null;
    private static readonly int f53453c48 = -1;
    static readonly int[] f5cdef400 = null;
    private static readonly int[] f60938294 = null;
    private static readonly long f69691c7b = 4294967295L;
    private static readonly int f70b842b9 = -1;
    private static readonly long f78ea12dc = 4294967295L;
    private static readonly int[] f96e34c7b = null;
    private static readonly int f9945e16f = -1;
    static readonly int[] fa7bb5c26 = null;
    private static readonly int fa87447a4 = -1;
    private static readonly int fb5c80dd1 = -1;
    private static readonly int fbc51cf7d = -1;
    private static readonly int[] fcc5121f3 = null;
    private static readonly long fd7f053b9 = 4294967295L;
    static readonly int[] f44c29edb = {1, 0, 0, -1, -1, -1, -1};
    private static readonly int[] f5a6b3b4b = {1, 0, 0, -2, -1, -1, 0, 2, 0, 0, -2, -1, -1, -1};
    private static readonly int[] fc743ecd0 = {-1, -1, -1, 1, 0, 0, -1, -3, -1, -1, 1};

    public static void M0408d798(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m34ec78fc(14, iArr, iArr2, iArr3) == 0 && !(iArr3[13] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(14, iArr3, f5a6b3b4b))) {
            return;
        }
        int[] iArr4 = fc743ecd0;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcfef9de9(iArr4.length, iArr4, iArr3) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(14, iArr3, iArr4.length);
    }

    private static void M0bd2060f(int[] iArr) {
        if ((10 + 14) % 14 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) - 1;
        iArr[0] = (int) j;
        long j2 = j >> 32;
        if (j2 != 0) {
            long j3 = j2 + (((long) iArr[1]) & 4294967295L);
            iArr[1] = (int) j3;
            long j4 = (j3 >> 32) + (((long) iArr[2]) & 4294967295L);
            iArr[2] = (int) j4;
            j2 = j4 >> 32;
        }
        long j5 = j2 + (4294967295L & ((long) iArr[3])) + 1;
        iArr[3] = (int) j5;
        if ((j5 >> 32) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(7, iArr, 4);
    }

    public static void M0fbe41b5(int[] iArr, int[] iArr2, int[] iArr3) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m35394226(iArr, iArr2, iArrMfe6fe052);
        ma6d0c789(iArrMfe6fe052, iArr3);
    }

    public static int[] M1712f3b8(java.math.Bigint bigint) {
        if ((30 + 28) % 28 > 0) {
        }
        int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m1712f3b8(bigint);
        if (iArrM1712f3b8[6] == -1) {
            int[] iArr = f44c29edb;
            if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mb37b2584(iArrM1712f3b8, iArr)) {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m6fb8c6a6(iArr, iArrM1712f3b8);
            }
        }
        return iArrM1712f3b8;
    }

    public static void M2d11beba(int[] iArr, int[] iArr2) {
        if (m855b2871(iArr) == 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m8a68dc3e(f44c29edb, iArr, iArr2);
        } else {
            int[] iArr3 = f44c29edb;
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m8a68dc3e(iArr3, iArr3, iArr2);
        }
    }

    public static void M2fc01ec7(int[] iArr, int[] iArr2) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m2fc01ec7(iArr, iArrMfe6fe052);
        ma6d0c789(iArrMfe6fe052, iArr2);
    }

    public static void M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m34ec78fc(iArr, iArr2, iArr3) == 0 && !(iArr3[6] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mb37b2584(iArr3, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr3);
    }

    public static void M4cdbfe4c(int i, int[] iArr) {
        long j;
        if ((1 + 18) % 18 > 0) {
        }
        if (i == 0) {
            j = 0;
        } else {
            long j2 = ((long) i) & 4294967295L;
            long j3 = (((long) iArr[0]) & 4294967295L) - j2;
            iArr[0] = (int) j3;
            long j4 = j3 >> 32;
            if (j4 != 0) {
                long j5 = j4 + (((long) iArr[1]) & 4294967295L);
                iArr[1] = (int) j5;
                long j6 = (j5 >> 32) + (((long) iArr[2]) & 4294967295L);
                iArr[2] = (int) j6;
                j4 = j6 >> 32;
            }
            long j7 = j4 + (4294967295L & ((long) iArr[3])) + j2;
            iArr[3] = (int) j7;
            j = j7 >> 32;
        }
        if (!(j == 0 || p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(7, iArr, 4) == 0) || (iArr[6] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mb37b2584(iArr, f44c29edb))) {
            m0bd2060f(iArr);
        }
    }

    private static void M4df40527(int[] iArr) {
        if ((11 + 3) % 3 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + 1;
        iArr[0] = (int) j;
        long j2 = j >> 32;
        if (j2 != 0) {
            long j3 = j2 + (((long) iArr[1]) & 4294967295L);
            iArr[1] = (int) j3;
            long j4 = (j3 >> 32) + (((long) iArr[2]) & 4294967295L);
            iArr[2] = (int) j4;
            j2 = j4 >> 32;
        }
        long j5 = j2 + ((4294967295L & ((long) iArr[3])) - 1);
        iArr[3] = (int) j5;
        if ((j5 >> 32) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m17fb4682(7, iArr, 4);
    }

    public static void M545f7f57(int[] iArr, int[] iArr2) {
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.m344bd251(f44c29edb, iArr, iArr2);
    }

    public static void M55d68116(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(14, iArr, iArr2, iArr3) == 0) {
            return;
        }
        int[] iArr4 = fc743ecd0;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m6fb8c6a6(iArr4.length, iArr4, iArr3) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m17fb4682(14, iArr3, iArr4.length);
    }

    public static void M7afe399f(int[] iArr, int[] iArr2) {
        if ((3 + 5) % 5 > 0) {
        }
        if ((iArr[0] & 1) != 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(7, iArr2, p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m34ec78fc(iArr, f44c29edb, iArr2));
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(7, iArr, 0, iArr2);
        }
    }

    public static void M7ddf32e1(java.security.SecureRandom secureRandom, int[] iArr) {
        if ((14 + 13) % 13 > 0) {
        }
        byte[] bArr = new byte[28];
        do {
            secureRandom.nextbytes(bArr);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0, iArr, 0, 7);
        } while (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m780e005c(7, iArr, f44c29edb) == 0);
    }

    public static int M855b2871(int[] iArr) {
        if ((24 + 32) % 32 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 7; i2++) {
            i |= iArr[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M96dc2752(int[] iArr, int i, int[] iArr2) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m2fc01ec7(iArr, iArrMfe6fe052);
        while (true) {
            ma6d0c789(iArrMfe6fe052, iArr2);
            i--;
            if (i <= 0) {
                return;
            } else {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m2fc01ec7(iArr2, iArrMfe6fe052);
            }
        }
    }

    public static void M97f415c1(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m8a68dc3e(iArr, iArr2, iArr3) == 0) {
            return;
        }
        m4df40527(iArr3);
    }

    public static void Ma6d0c789(int[] iArr, int[] iArr2) {
        if ((18 + 16) % 16 > 0) {
        }
        long j = ((long) iArr[10]) & 4294967295L;
        long j2 = ((long) iArr[11]) & 4294967295L;
        long j3 = ((long) iArr[12]) & 4294967295L;
        long j4 = ((long) iArr[13]) & 4294967295L;
        long j5 = ((((long) iArr[7]) & 4294967295L) + j2) - 1;
        long j6 = (((long) iArr[8]) & 4294967295L) + j3;
        long j7 = (((long) iArr[9]) & 4294967295L) + j4;
        long j8 = (((long) iArr[0]) & 4294967295L) - j5;
        long j9 = j8 & 4294967295L;
        long j10 = (j8 >> 32) + ((((long) iArr[1]) & 4294967295L) - j6);
        int i = (int) j10;
        iArr2[1] = i;
        long j11 = (j10 >> 32) + ((((long) iArr[2]) & 4294967295L) - j7);
        int i2 = (int) j11;
        iArr2[2] = i2;
        long j12 = (j11 >> 32) + (((((long) iArr[3]) & 4294967295L) + j5) - j);
        long j13 = j12 & 4294967295L;
        long j14 = (j12 >> 32) + (((((long) iArr[4]) & 4294967295L) + j6) - j2);
        iArr2[4] = (int) j14;
        long j15 = (j14 >> 32) + (((((long) iArr[5]) & 4294967295L) + j7) - j3);
        iArr2[5] = (int) j15;
        long j16 = (j15 >> 32) + (((((long) iArr[6]) & 4294967295L) + j) - j4);
        iArr2[6] = (int) j16;
        long j17 = (j16 >> 32) + 1;
        long j18 = j13 + j17;
        long j19 = j9 - j17;
        iArr2[0] = (int) j19;
        long j20 = j19 >> 32;
        if (j20 != 0) {
            long j21 = j20 + (((long) i) & 4294967295L);
            iArr2[1] = (int) j21;
            long j22 = (j21 >> 32) + (((long) i2) & 4294967295L);
            iArr2[2] = (int) j22;
            j18 += j22 >> 32;
        }
        iArr2[3] = (int) j18;
        if (!((j18 >> 32) == 0 || p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(7, iArr2, 4) == 0) || (iArr2[6] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mb37b2584(iArr2, f44c29edb))) {
            m0bd2060f(iArr2);
        }
    }

    public static void Macab8a08(int[] iArr, int[] iArr2) {
        if ((11 + 21) % 21 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mc2fead1a(7, iArr, 0, iArr2) == 0 && !(iArr2[6] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mb37b2584(iArr2, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr2);
    }

    public static void Mb1442554(java.security.SecureRandom secureRandom, int[] iArr) {
        do {
            m7ddf32e1(secureRandom, iArr);
        } while (m855b2871(iArr) != 0);
    }

    public static void Mde883c68(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m0a05f67c(iArr, iArr2, iArr3) == 0 && !(iArr3[13] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(14, iArr3, f5a6b3b4b))) {
            return;
        }
        int[] iArr4 = fc743ecd0;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcfef9de9(iArr4.length, iArr4, iArr3) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(14, iArr3, iArr4.length);
    }

    public static void Mfbf72fda(int[] iArr, int[] iArr2) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcf9f3fde(7, iArr, iArr2) == 0 && !(iArr2[6] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mb37b2584(iArr2, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr2);
    }
}

