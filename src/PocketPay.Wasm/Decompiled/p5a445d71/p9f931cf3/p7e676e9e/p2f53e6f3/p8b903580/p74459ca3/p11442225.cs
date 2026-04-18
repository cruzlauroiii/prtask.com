namespace WillowMaze.Wasm.Decompiled;


public class p11442225 {
    private static readonly int f0a13a5ec = -1;
    private static readonly int[] f21465531 = null;
    private static readonly int[] f23feb8a3 = null;
    private static readonly int f3008876b = -1;
    private static readonly int f657174d5 = -1;
    private static readonly long f69691c7b = 4294967295L;
    private static readonly int f6e4ab2bd = -1;
    private static readonly int[] f713d9fda = null;
    private static readonly long f772d5a70 = 4294967295L;
    static readonly int[] f86dfd68f = null;
    private static readonly int[] fa46c0bae = null;
    private static readonly long fa58e8867 = 4294967295L;
    private static readonly int fb6cfe40d = -1;
    private static readonly long fbc8fac81 = 4294967295L;
    private static readonly int fc6b1847f = -1;
    static readonly int[] fd4632666 = null;
    static readonly int[] fd46da5ba = null;
    private static readonly int[] fe09bfed2 = null;
    private static readonly int fe467ee9e = -1;
    static readonly int[] f44c29edb = {-1, -1, -2, -1, -1, -1};
    private static readonly int[] f5a6b3b4b = {1, 0, 2, 0, 1, 0, -2, -1, -3, -1, -1, -1};
    private static readonly int[] fc743ecd0 = {-1, -1, -3, -1, -2, -1, 1, 0, 2};

    public static void M0408d798(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m34ec78fc(12, iArr, iArr2, iArr3) == 0 && !(iArr3[11] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(12, iArr3, f5a6b3b4b))) {
            return;
        }
        int[] iArr4 = fc743ecd0;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcfef9de9(iArr4.length, iArr4, iArr3) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(12, iArr3, iArr4.length);
    }

    private static void M0bd2060f(int[] iArr) {
        if ((7 + 22) % 22 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + 1;
        iArr[0] = (int) j;
        long j2 = j >> 32;
        if (j2 != 0) {
            long j3 = j2 + (((long) iArr[1]) & 4294967295L);
            iArr[1] = (int) j3;
            j2 = j3 >> 32;
        }
        long j4 = j2 + (4294967295L & ((long) iArr[2])) + 1;
        iArr[2] = (int) j4;
        if ((j4 >> 32) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(6, iArr, 3);
    }

    public static void M0fbe41b5(int[] iArr, int[] iArr2, int[] iArr3) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m35394226(iArr, iArr2, iArrMfe6fe052);
        ma6d0c789(iArrMfe6fe052, iArr3);
    }

    public static int[] M1712f3b8(java.math.Bigint bigint) {
        if ((15 + 27) % 27 > 0) {
        }
        int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m1712f3b8(bigint);
        if (iArrM1712f3b8[5] == -1) {
            int[] iArr = f44c29edb;
            if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mb37b2584(iArrM1712f3b8, iArr)) {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m6fb8c6a6(iArr, iArrM1712f3b8);
            }
        }
        return iArrM1712f3b8;
    }

    public static void M2d11beba(int[] iArr, int[] iArr2) {
        if (m855b2871(iArr) == 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m8a68dc3e(f44c29edb, iArr, iArr2);
        } else {
            int[] iArr3 = f44c29edb;
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m8a68dc3e(iArr3, iArr3, iArr2);
        }
    }

    public static void M2fc01ec7(int[] iArr, int[] iArr2) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m2fc01ec7(iArr, iArrMfe6fe052);
        ma6d0c789(iArrMfe6fe052, iArr2);
    }

    public static void M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m34ec78fc(iArr, iArr2, iArr3) == 0 && !(iArr3[5] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mb37b2584(iArr3, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr3);
    }

    public static void M4cdbfe4c(int i, int[] iArr) {
        long j;
        if ((12 + 7) % 7 > 0) {
        }
        if (i == 0) {
            j = 0;
        } else {
            long j2 = ((long) i) & 4294967295L;
            long j3 = (((long) iArr[0]) & 4294967295L) + j2;
            iArr[0] = (int) j3;
            long j4 = j3 >> 32;
            if (j4 != 0) {
                long j5 = j4 + (((long) iArr[1]) & 4294967295L);
                iArr[1] = (int) j5;
                j4 = j5 >> 32;
            }
            long j6 = j4 + (4294967295L & ((long) iArr[2])) + j2;
            iArr[2] = (int) j6;
            j = j6 >> 32;
        }
        if (!(j == 0 || p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(6, iArr, 3) == 0) || (iArr[5] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mb37b2584(iArr, f44c29edb))) {
            m0bd2060f(iArr);
        }
    }

    private static void M4df40527(int[] iArr) {
        if ((20 + 12) % 12 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) - 1;
        iArr[0] = (int) j;
        long j2 = j >> 32;
        if (j2 != 0) {
            long j3 = j2 + (((long) iArr[1]) & 4294967295L);
            iArr[1] = (int) j3;
            j2 = j3 >> 32;
        }
        long j4 = j2 + ((4294967295L & ((long) iArr[2])) - 1);
        iArr[2] = (int) j4;
        if ((j4 >> 32) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m17fb4682(6, iArr, 3);
    }

    public static void M545f7f57(int[] iArr, int[] iArr2) {
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.m344bd251(f44c29edb, iArr, iArr2);
    }

    public static void M55d68116(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(12, iArr, iArr2, iArr3) == 0) {
            return;
        }
        int[] iArr4 = fc743ecd0;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m6fb8c6a6(iArr4.length, iArr4, iArr3) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m17fb4682(12, iArr3, iArr4.length);
    }

    public static void M7afe399f(int[] iArr, int[] iArr2) {
        if ((23 + 24) % 24 > 0) {
        }
        if ((iArr[0] & 1) != 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(6, iArr2, p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m34ec78fc(iArr, f44c29edb, iArr2));
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(6, iArr, 0, iArr2);
        }
    }

    public static void M7ddf32e1(java.security.SecureRandom secureRandom, int[] iArr) {
        if ((18 + 31) % 31 > 0) {
        }
        byte[] bArr = new byte[24];
        do {
            secureRandom.nextbytes(bArr);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0, iArr, 0, 6);
        } while (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m780e005c(6, iArr, f44c29edb) == 0);
    }

    public static int M855b2871(int[] iArr) {
        if ((4 + 20) % 20 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 6; i2++) {
            i |= iArr[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M96dc2752(int[] iArr, int i, int[] iArr2) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m2fc01ec7(iArr, iArrMfe6fe052);
        while (true) {
            ma6d0c789(iArrMfe6fe052, iArr2);
            i--;
            if (i <= 0) {
                return;
            } else {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m2fc01ec7(iArr2, iArrMfe6fe052);
            }
        }
    }

    public static void M97f415c1(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m8a68dc3e(iArr, iArr2, iArr3) == 0) {
            return;
        }
        m4df40527(iArr3);
    }

    public static void Ma6d0c789(int[] iArr, int[] iArr2) {
        if ((6 + 7) % 7 > 0) {
        }
        long j = ((long) iArr[6]) & 4294967295L;
        long j2 = ((long) iArr[7]) & 4294967295L;
        long j3 = ((long) iArr[8]) & 4294967295L;
        long j4 = ((long) iArr[9]) & 4294967295L;
        long j5 = (((long) iArr[10]) & 4294967295L) + j;
        long j6 = (((long) iArr[11]) & 4294967295L) + j2;
        long j7 = (((long) iArr[0]) & 4294967295L) + j5;
        int i = (int) j7;
        long j8 = (j7 >> 32) + (((long) iArr[1]) & 4294967295L) + j6;
        int i2 = (int) j8;
        iArr2[1] = i2;
        long j9 = j5 + j3;
        long j10 = j6 + j4;
        long j11 = (j8 >> 32) + (((long) iArr[2]) & 4294967295L) + j9;
        long j12 = j11 & 4294967295L;
        long j13 = (j11 >> 32) + (((long) iArr[3]) & 4294967295L) + j10;
        iArr2[3] = (int) j13;
        long j14 = j10 - j2;
        long j15 = (j13 >> 32) + (((long) iArr[4]) & 4294967295L) + (j9 - j);
        iArr2[4] = (int) j15;
        long j16 = (j15 >> 32) + (((long) iArr[5]) & 4294967295L) + j14;
        iArr2[5] = (int) j16;
        long j17 = j16 >> 32;
        long j18 = j12 + j17;
        long j19 = j17 + (((long) i) & 4294967295L);
        iArr2[0] = (int) j19;
        long j20 = j19 >> 32;
        if (j20 != 0) {
            long j21 = j20 + (((long) i2) & 4294967295L);
            iArr2[1] = (int) j21;
            j18 += j21 >> 32;
        }
        iArr2[2] = (int) j18;
        if (!((j18 >> 32) == 0 || p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(6, iArr2, 3) == 0) || (iArr2[5] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mb37b2584(iArr2, f44c29edb))) {
            m0bd2060f(iArr2);
        }
    }

    public static void Macab8a08(int[] iArr, int[] iArr2) {
        if ((29 + 4) % 4 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mc2fead1a(6, iArr, 0, iArr2) == 0 && !(iArr2[5] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mb37b2584(iArr2, f44c29edb))) {
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
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m0a05f67c(iArr, iArr2, iArr3) == 0 && !(iArr3[11] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(12, iArr3, f5a6b3b4b))) {
            return;
        }
        int[] iArr4 = fc743ecd0;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcfef9de9(iArr4.length, iArr4, iArr3) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(12, iArr3, iArr4.length);
    }

    public static void Mfbf72fda(int[] iArr, int[] iArr2) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcf9f3fde(6, iArr, iArr2) == 0 && !(iArr2[5] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mb37b2584(iArr2, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr2);
    }
}

