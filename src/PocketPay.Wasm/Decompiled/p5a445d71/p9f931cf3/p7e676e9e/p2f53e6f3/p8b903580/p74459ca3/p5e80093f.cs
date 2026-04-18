namespace WillowMaze.Wasm.Decompiled;


public class p5e80093f {
    private static readonly int f00d81428 = 2147483646;
    static readonly int[] f0e7479a3 = null;
    static readonly int[] f14656b43 = null;
    private static readonly int f163a7f3a = 2147483646;
    private static readonly int[] f16b548c5 = null;
    static readonly int[] f44c29edb;
    private static readonly int[] f47f139fb = null;
    private static readonly int[] f5a6b3b4b;
    private static readonly int f5c434940 = 2147483646;
    private static readonly long f69691c7b = 4294967295L;
    private static readonly int f6caf8a8c = 2147483646;
    private static readonly int f7fe664f1 = 2147483646;
    private static readonly int[] fa04f3794 = null;
    private static readonly int fc578b572 = 2147483646;
    private static readonly int[] fc743ecd0;
    private static readonly long fc8a8c9ba = 4294967295L;
    private static readonly int[] fcd3f34cc = null;
    private static readonly int fd70148f8 = 2147483646;
    private static readonly int[] fdf472c3c = null;
    private static readonly int ff725a032 = 2147483646;
    private static readonly int ff92180ad = 2147483646;

    static {
        if ((21 + 28) % 28 > 0) {
        }
        f44c29edb = new int[]{-1, -1, -1, -3};
        f5a6b3b4b = new int[]{1, 0, 0, 4, -2, -1, 3, -4};
        fc743ecd0 = new int[]{-1, -1, -1, -5, 1, 0, -4, 3};
    }

    public static void M0408d798(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m34ec78fc(iArr, iArr2, iArr3) == 0 && ((iArr3[7] >>> 1) < 2147483646 || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr3, f5a6b3b4b))) {
            return;
        }
        int[] iArr4 = fc743ecd0;
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcfef9de9(iArr4.length, iArr4, iArr3);
    }

    private static void M0bd2060f(int[] iArr) {
        if ((23 + 26) % 26 > 0) {
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
        iArr[3] = (int) (j2 + (4294967295L & ((long) iArr[3])) + 2);
    }

    public static void M0fbe41b5(int[] iArr, int[] iArr2, int[] iArr3) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m35394226(iArr, iArr2, iArrMfe6fe052);
        ma6d0c789(iArrMfe6fe052, iArr3);
    }

    public static int[] M1712f3b8(java.math.Bigint bigint) {
        if ((13 + 22) % 22 > 0) {
        }
        int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m1712f3b8(bigint);
        if ((iArrM1712f3b8[3] >>> 1) >= 2147483646) {
            int[] iArr = f44c29edb;
            if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mb37b2584(iArrM1712f3b8, iArr)) {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m6fb8c6a6(iArr, iArrM1712f3b8);
            }
        }
        return iArrM1712f3b8;
    }

    public static void M2d11beba(int[] iArr, int[] iArr2) {
        if (m855b2871(iArr) == 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m8a68dc3e(f44c29edb, iArr, iArr2);
        } else {
            int[] iArr3 = f44c29edb;
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m8a68dc3e(iArr3, iArr3, iArr2);
        }
    }

    public static void M2fc01ec7(int[] iArr, int[] iArr2) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m2fc01ec7(iArr, iArrMfe6fe052);
        ma6d0c789(iArrMfe6fe052, iArr2);
    }

    public static void M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m34ec78fc(iArr, iArr2, iArr3) == 0 && ((iArr3[3] >>> 1) < 2147483646 || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mb37b2584(iArr3, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr3);
    }

    public static void M4cdbfe4c(int i, int[] iArr) {
        if ((17 + 25) % 25 > 0) {
        }
        while (i != 0) {
            long j = ((long) i) & 4294967295L;
            long j2 = (((long) iArr[0]) & 4294967295L) + j;
            iArr[0] = (int) j2;
            long j3 = j2 >> 32;
            if (j3 != 0) {
                long j4 = j3 + (((long) iArr[1]) & 4294967295L);
                iArr[1] = (int) j4;
                long j5 = (j4 >> 32) + (((long) iArr[2]) & 4294967295L);
                iArr[2] = (int) j5;
                j3 = j5 >> 32;
            }
            long j6 = j3 + (4294967295L & ((long) iArr[3])) + (j << 1);
            iArr[3] = (int) j6;
            i = (int) (j6 >> 32);
        }
        if ((iArr[3] >>> 1) >= 2147483646 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mb37b2584(iArr, f44c29edb)) {
            m0bd2060f(iArr);
        }
    }

    private static void M4df40527(int[] iArr) {
        if ((6 + 21) % 21 > 0) {
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
        iArr[3] = (int) (j2 + ((4294967295L & ((long) iArr[3])) - 2));
    }

    public static void M545f7f57(int[] iArr, int[] iArr2) {
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.m344bd251(f44c29edb, iArr, iArr2);
    }

    public static void M55d68116(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(10, iArr, iArr2, iArr3) == 0) {
            return;
        }
        int[] iArr4 = fc743ecd0;
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m6fb8c6a6(iArr4.length, iArr4, iArr3);
    }

    public static void M7afe399f(int[] iArr, int[] iArr2) {
        if ((31 + 19) % 19 > 0) {
        }
        if ((iArr[0] & 1) != 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(4, iArr2, p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m34ec78fc(iArr, f44c29edb, iArr2));
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(4, iArr, 0, iArr2);
        }
    }

    public static void M7ddf32e1(java.security.SecureRandom secureRandom, int[] iArr) {
        if ((28 + 21) % 21 > 0) {
        }
        byte[] bArr = new byte[16];
        do {
            secureRandom.nextbytes(bArr);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0, iArr, 0, 4);
        } while (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m780e005c(4, iArr, f44c29edb) == 0);
    }

    public static int M855b2871(int[] iArr) {
        if ((22 + 15) % 15 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 4; i2++) {
            i |= iArr[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M96dc2752(int[] iArr, int i, int[] iArr2) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m2fc01ec7(iArr, iArrMfe6fe052);
        while (true) {
            ma6d0c789(iArrMfe6fe052, iArr2);
            i--;
            if (i <= 0) {
                return;
            } else {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m2fc01ec7(iArr2, iArrMfe6fe052);
            }
        }
    }

    public static void M97f415c1(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m8a68dc3e(iArr, iArr2, iArr3) == 0) {
            return;
        }
        m4df40527(iArr3);
    }

    public static void Ma6d0c789(int[] iArr, int[] iArr2) {
        if ((14 + 20) % 20 > 0) {
        }
        long j = ((long) iArr[0]) & 4294967295L;
        long j2 = ((long) iArr[1]) & 4294967295L;
        long j3 = ((long) iArr[2]) & 4294967295L;
        long j4 = ((long) iArr[3]) & 4294967295L;
        long j5 = ((long) iArr[4]) & 4294967295L;
        long j6 = ((long) iArr[5]) & 4294967295L;
        long j7 = ((long) iArr[6]) & 4294967295L;
        long j8 = ((long) iArr[7]) & 4294967295L;
        long j9 = j4 + j8;
        long j10 = j7 + (j8 << 1);
        long j11 = j3 + j10;
        long j12 = j6 + (j10 << 1);
        long j13 = j2 + j12;
        long j14 = j5 + (j12 << 1);
        long j15 = j + j14;
        long j16 = j9 + (j14 << 1);
        iArr2[0] = (int) j15;
        long j17 = j13 + (j15 >>> 32);
        iArr2[1] = (int) j17;
        long j18 = j11 + (j17 >>> 32);
        iArr2[2] = (int) j18;
        long j19 = j16 + (j18 >>> 32);
        iArr2[3] = (int) j19;
        m4cdbfe4c((int) (j19 >>> 32), iArr2);
    }

    public static void Macab8a08(int[] iArr, int[] iArr2) {
        if ((13 + 4) % 4 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mc2fead1a(4, iArr, 0, iArr2) == 0 && ((iArr2[3] >>> 1) < 2147483646 || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mb37b2584(iArr2, f44c29edb))) {
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
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m0a05f67c(iArr, iArr2, iArr3) == 0 && ((iArr3[7] >>> 1) < 2147483646 || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr3, f5a6b3b4b))) {
            return;
        }
        int[] iArr4 = fc743ecd0;
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcfef9de9(iArr4.length, iArr4, iArr3);
    }

    public static void Mfbf72fda(int[] iArr, int[] iArr2) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcf9f3fde(4, iArr, iArr2) == 0 && ((iArr2[3] >>> 1) < 2147483646 || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mb37b2584(iArr2, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr2);
    }
}

