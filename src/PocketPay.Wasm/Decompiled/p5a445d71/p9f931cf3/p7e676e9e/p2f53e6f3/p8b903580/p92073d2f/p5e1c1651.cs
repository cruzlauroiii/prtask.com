namespace WillowMaze.Wasm.Decompiled;


public class p5e1c1651 {
    private static readonly int[] f0a671072 = null;
    private static readonly int f0f2ae62e = int.MAX_VALUE;
    private static readonly int f1e8ab2ab = int.MAX_VALUE;
    private static readonly int f26df8623 = int.MAX_VALUE;
    private static readonly int[] f28fd53b4 = null;
    static readonly int[] f38befb4d = null;
    private static readonly long f3bad91b5 = 4294967295L;
    private static readonly int f4617b314 = int.MAX_VALUE;
    static readonly int[] f4faf1ed4 = null;
    private static readonly long f69691c7b = 4294967295L;
    static readonly int[] f7dc7f475 = null;
    private static readonly int f88899448 = int.MAX_VALUE;
    private static readonly int fab4107b5 = int.MAX_VALUE;
    private static readonly int fd476203f = int.MAX_VALUE;
    private static readonly int fd5033464 = int.MAX_VALUE;
    private static readonly int fd6161e54 = int.MAX_VALUE;
    static readonly int[] ffa198852 = null;
    static readonly int[] f44c29edb = {-1, -1, 0, -1, -1, -1, -1, -2};
    private static readonly int[] f5a6b3b4b = {1, 0, -2, 1, 1, -2, 0, 2, -2, -3, 3, -2, -1, -1, 0, -2};

    public static void M0408d798(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m34ec78fc(16, iArr, iArr2, iArr3) == 0 && ((iArr3[15] >>> 1) < int.MAX_VALUE || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(16, iArr3, f5a6b3b4b))) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m6fb8c6a6(16, f5a6b3b4b, iArr3);
    }

    private static void M0bd2060f(int[] iArr) {
        if ((12 + 28) % 28 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + 1;
        iArr[0] = (int) j;
        long j2 = j >> 32;
        if (j2 != 0) {
            long j3 = j2 + (((long) iArr[1]) & 4294967295L);
            iArr[1] = (int) j3;
            j2 = j3 >> 32;
        }
        long j4 = j2 + ((((long) iArr[2]) & 4294967295L) - 1);
        iArr[2] = (int) j4;
        long j5 = (j4 >> 32) + (((long) iArr[3]) & 4294967295L) + 1;
        iArr[3] = (int) j5;
        long j6 = j5 >> 32;
        if (j6 != 0) {
            long j7 = j6 + (((long) iArr[4]) & 4294967295L);
            iArr[4] = (int) j7;
            long j8 = (j7 >> 32) + (((long) iArr[5]) & 4294967295L);
            iArr[5] = (int) j8;
            long j9 = (j8 >> 32) + (((long) iArr[6]) & 4294967295L);
            iArr[6] = (int) j9;
            j6 = j9 >> 32;
        }
        iArr[7] = (int) (j6 + (4294967295L & ((long) iArr[7])) + 1);
    }

    public static void M0fbe41b5(int[] iArr, int[] iArr2, int[] iArr3) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m35394226(iArr, iArr2, iArrMfe6fe052);
        ma6d0c789(iArrMfe6fe052, iArr3);
    }

    public static int[] M1712f3b8(java.math.Bigint bigint) {
        if ((28 + 10) % 10 > 0) {
        }
        int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m1712f3b8(bigint);
        if ((iArrM1712f3b8[7] >>> 1) >= int.MAX_VALUE) {
            int[] iArr = f44c29edb;
            if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArrM1712f3b8, iArr)) {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m6fb8c6a6(iArr, iArrM1712f3b8);
            }
        }
        return iArrM1712f3b8;
    }

    public static void M2d11beba(int[] iArr, int[] iArr2) {
        if (m855b2871(iArr) == 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m8a68dc3e(f44c29edb, iArr, iArr2);
        } else {
            int[] iArr3 = f44c29edb;
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m8a68dc3e(iArr3, iArr3, iArr2);
        }
    }

    public static void M2fc01ec7(int[] iArr, int[] iArr2) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m2fc01ec7(iArr, iArrMfe6fe052);
        ma6d0c789(iArrMfe6fe052, iArr2);
    }

    public static void M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m34ec78fc(iArr, iArr2, iArr3) == 0 && ((iArr3[7] >>> 1) < int.MAX_VALUE || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr3, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr3);
    }

    public static void M4cdbfe4c(int i, int[] iArr) {
        long j;
        if ((11 + 13) % 13 > 0) {
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
            long j6 = j4 + ((((long) iArr[2]) & 4294967295L) - j2);
            iArr[2] = (int) j6;
            long j7 = (j6 >> 32) + (((long) iArr[3]) & 4294967295L) + j2;
            iArr[3] = (int) j7;
            long j8 = j7 >> 32;
            if (j8 != 0) {
                long j9 = j8 + (((long) iArr[4]) & 4294967295L);
                iArr[4] = (int) j9;
                long j10 = (j9 >> 32) + (((long) iArr[5]) & 4294967295L);
                iArr[5] = (int) j10;
                long j11 = (j10 >> 32) + (((long) iArr[6]) & 4294967295L);
                iArr[6] = (int) j11;
                j8 = j11 >> 32;
            }
            long j12 = j8 + (4294967295L & ((long) iArr[7])) + j2;
            iArr[7] = (int) j12;
            j = j12 >> 32;
        }
        if (j == 0 && ((iArr[7] >>> 1) < int.MAX_VALUE || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr);
    }

    private static void M4df40527(int[] iArr) {
        if ((9 + 31) % 31 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) - 1;
        iArr[0] = (int) j;
        long j2 = j >> 32;
        if (j2 != 0) {
            long j3 = j2 + (((long) iArr[1]) & 4294967295L);
            iArr[1] = (int) j3;
            j2 = j3 >> 32;
        }
        long j4 = j2 + (((long) iArr[2]) & 4294967295L) + 1;
        iArr[2] = (int) j4;
        long j5 = (j4 >> 32) + ((((long) iArr[3]) & 4294967295L) - 1);
        iArr[3] = (int) j5;
        long j6 = j5 >> 32;
        if (j6 != 0) {
            long j7 = j6 + (((long) iArr[4]) & 4294967295L);
            iArr[4] = (int) j7;
            long j8 = (j7 >> 32) + (((long) iArr[5]) & 4294967295L);
            iArr[5] = (int) j8;
            long j9 = (j8 >> 32) + (((long) iArr[6]) & 4294967295L);
            iArr[6] = (int) j9;
            j6 = j9 >> 32;
        }
        iArr[7] = (int) (j6 + ((4294967295L & ((long) iArr[7])) - 1));
    }

    public static void M545f7f57(int[] iArr, int[] iArr2) {
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.m344bd251(f44c29edb, iArr, iArr2);
    }

    public static void M55d68116(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(16, iArr, iArr2, iArr3) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcfef9de9(16, f5a6b3b4b, iArr3);
    }

    public static void M7afe399f(int[] iArr, int[] iArr2) {
        if ((29 + 2) % 2 > 0) {
        }
        if ((iArr[0] & 1) != 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(8, iArr2, p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m34ec78fc(iArr, f44c29edb, iArr2));
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(8, iArr, 0, iArr2);
        }
    }

    public static void M7ddf32e1(java.security.SecureRandom secureRandom, int[] iArr) {
        if ((2 + 25) % 25 > 0) {
        }
        byte[] bArr = new byte[32];
        do {
            secureRandom.nextbytes(bArr);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0, iArr, 0, 8);
        } while (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m780e005c(8, iArr, f44c29edb) == 0);
    }

    public static int M855b2871(int[] iArr) {
        if ((28 + 31) % 31 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 8; i2++) {
            i |= iArr[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M96dc2752(int[] iArr, int i, int[] iArr2) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m2fc01ec7(iArr, iArrMfe6fe052);
        while (true) {
            ma6d0c789(iArrMfe6fe052, iArr2);
            i--;
            if (i <= 0) {
                return;
            } else {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m2fc01ec7(iArr2, iArrMfe6fe052);
            }
        }
    }

    public static void M97f415c1(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m8a68dc3e(iArr, iArr2, iArr3) == 0) {
            return;
        }
        m4df40527(iArr3);
    }

    public static void Ma6d0c789(int[] iArr, int[] iArr2) {
        if ((32 + 4) % 4 > 0) {
        }
        long j = ((long) iArr[8]) & 4294967295L;
        long j2 = ((long) iArr[9]) & 4294967295L;
        long j3 = ((long) iArr[10]) & 4294967295L;
        long j4 = ((long) iArr[11]) & 4294967295L;
        long j5 = ((long) iArr[12]) & 4294967295L;
        long j6 = ((long) iArr[13]) & 4294967295L;
        long j7 = ((long) iArr[14]) & 4294967295L;
        long j8 = ((long) iArr[15]) & 4294967295L;
        long j9 = j3 + j4;
        long j10 = j6 + j7;
        long j11 = j10 + (j8 << 1);
        long j12 = j + j2 + j10;
        long j13 = j9 + j5 + j8 + j12;
        long j14 = (((long) iArr[0]) & 4294967295L) + j13 + j6 + j7 + j8;
        iArr2[0] = (int) j14;
        long j15 = (j14 >> 32) + (((((long) iArr[1]) & 4294967295L) + j13) - j) + j7 + j8;
        iArr2[1] = (int) j15;
        long j16 = (j15 >> 32) + ((((long) iArr[2]) & 4294967295L) - j12);
        iArr2[2] = (int) j16;
        long j17 = (j16 >> 32) + ((((((long) iArr[3]) & 4294967295L) + j13) - j2) - j3) + j6;
        iArr2[3] = (int) j17;
        long j18 = (j17 >> 32) + ((((((long) iArr[4]) & 4294967295L) + j13) - j9) - j) + j7;
        iArr2[4] = (int) j18;
        long j19 = (j18 >> 32) + (((long) iArr[5]) & 4294967295L) + j11 + j3;
        iArr2[5] = (int) j19;
        long j20 = (j19 >> 32) + (((long) iArr[6]) & 4294967295L) + j4 + j7 + j8;
        iArr2[6] = (int) j20;
        long j21 = (j20 >> 32) + (((long) iArr[7]) & 4294967295L) + j13 + j11 + j5;
        iArr2[7] = (int) j21;
        m4cdbfe4c((int) (j21 >> 32), iArr2);
    }

    public static void Macab8a08(int[] iArr, int[] iArr2) {
        if ((6 + 22) % 22 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mc2fead1a(8, iArr, 0, iArr2) == 0 && ((iArr2[7] >>> 1) < int.MAX_VALUE || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr2, f44c29edb))) {
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
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m0a05f67c(iArr, iArr2, iArr3) == 0 && ((iArr3[15] >>> 1) < int.MAX_VALUE || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(16, iArr3, f5a6b3b4b))) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m6fb8c6a6(16, f5a6b3b4b, iArr3);
    }

    public static void Mfbf72fda(int[] iArr, int[] iArr2) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcf9f3fde(8, iArr, iArr2) == 0 && ((iArr2[7] >>> 1) < int.MAX_VALUE || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr2, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr2);
    }
}

