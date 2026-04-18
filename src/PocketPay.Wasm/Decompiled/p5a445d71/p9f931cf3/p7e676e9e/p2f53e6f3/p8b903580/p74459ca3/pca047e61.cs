namespace WillowMaze.Wasm.Decompiled;


public class pca047e61 {
    private static readonly int f172d0dd2 = int.MAX_VALUE;
    private static readonly int f26df8623 = int.MAX_VALUE;
    private static readonly int[] f298a6e8b = null;
    private static readonly int[] f359c1fe2 = null;
    static readonly int[] f3e23d136 = null;
    private static readonly long f46fa323c = 4294967295L;
    private static readonly long f69691c7b = 4294967295L;
    private static readonly int f74e4ef30 = -1;
    private static readonly int f8c572b30 = int.MAX_VALUE;
    private static readonly long faf58c5fc = 4294967295L;
    private static readonly int fbd67f405 = -1;
    private static readonly int fd5a025f5 = -1;
    private static readonly int fd8db410e = -1;
    private static readonly int[] fdd193059 = null;
    static readonly int[] f44c29edb = {-1, -1, -1, 0, 0, 0, 1, -1};
    private static readonly int[] f5a6b3b4b = {1, 0, 0, -2, -1, -1, -2, 1, -2, 1, -2, 1, 1, -2, 2, -2};

    public static void M0408d798(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m34ec78fc(16, iArr, iArr2, iArr3) == 0 && ((iArr3[15] >>> 1) < int.MAX_VALUE || !p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(16, iArr3, f5a6b3b4b))) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m6fb8c6a6(16, f5a6b3b4b, iArr3);
    }

    private static void M0bd2060f(int[] iArr) {
        if ((30 + 30) % 30 > 0) {
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
        long j5 = j2 + ((((long) iArr[3]) & 4294967295L) - 1);
        iArr[3] = (int) j5;
        long j6 = j5 >> 32;
        if (j6 != 0) {
            long j7 = j6 + (((long) iArr[4]) & 4294967295L);
            iArr[4] = (int) j7;
            long j8 = (j7 >> 32) + (((long) iArr[5]) & 4294967295L);
            iArr[5] = (int) j8;
            j6 = j8 >> 32;
        }
        long j9 = j6 + ((((long) iArr[6]) & 4294967295L) - 1);
        iArr[6] = (int) j9;
        iArr[7] = (int) ((j9 >> 32) + (4294967295L & ((long) iArr[7])) + 1);
    }

    public static void M0fbe41b5(int[] iArr, int[] iArr2, int[] iArr3) {
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m35394226(iArr, iArr2, iArrMfe6fe052);
        ma6d0c789(iArrMfe6fe052, iArr3);
    }

    public static int[] M1712f3b8(java.math.Bigint bigint) {
        if ((26 + 28) % 28 > 0) {
        }
        int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m1712f3b8(bigint);
        if (iArrM1712f3b8[7] == -1) {
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
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m34ec78fc(iArr, iArr2, iArr3) == 0 && !(iArr3[7] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr3, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr3);
    }

    public static void M4cdbfe4c(int i, int[] iArr) {
        long j;
        if ((6 + 23) % 23 > 0) {
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
                long j6 = (j5 >> 32) + (((long) iArr[2]) & 4294967295L);
                iArr[2] = (int) j6;
                j4 = j6 >> 32;
            }
            long j7 = j4 + ((((long) iArr[3]) & 4294967295L) - j2);
            iArr[3] = (int) j7;
            long j8 = j7 >> 32;
            if (j8 != 0) {
                long j9 = j8 + (((long) iArr[4]) & 4294967295L);
                iArr[4] = (int) j9;
                long j10 = (j9 >> 32) + (((long) iArr[5]) & 4294967295L);
                iArr[5] = (int) j10;
                j8 = j10 >> 32;
            }
            long j11 = j8 + ((((long) iArr[6]) & 4294967295L) - j2);
            iArr[6] = (int) j11;
            long j12 = (j11 >> 32) + (4294967295L & ((long) iArr[7])) + j2;
            iArr[7] = (int) j12;
            j = j12 >> 32;
        }
        if (j == 0 && !(iArr[7] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr);
    }

    private static void M4df40527(int[] iArr) {
        if ((4 + 29) % 29 > 0) {
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
        long j5 = j2 + (((long) iArr[3]) & 4294967295L) + 1;
        iArr[3] = (int) j5;
        long j6 = j5 >> 32;
        if (j6 != 0) {
            long j7 = j6 + (((long) iArr[4]) & 4294967295L);
            iArr[4] = (int) j7;
            long j8 = (j7 >> 32) + (((long) iArr[5]) & 4294967295L);
            iArr[5] = (int) j8;
            j6 = j8 >> 32;
        }
        long j9 = j6 + (((long) iArr[6]) & 4294967295L) + 1;
        iArr[6] = (int) j9;
        iArr[7] = (int) ((j9 >> 32) + ((4294967295L & ((long) iArr[7])) - 1));
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
        if ((11 + 28) % 28 > 0) {
        }
        if ((iArr[0] & 1) != 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(8, iArr2, p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m34ec78fc(iArr, f44c29edb, iArr2));
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(8, iArr, 0, iArr2);
        }
    }

    public static void M7ddf32e1(java.security.SecureRandom secureRandom, int[] iArr) {
        if ((32 + 3) % 3 > 0) {
        }
        byte[] bArr = new byte[32];
        do {
            secureRandom.nextbytes(bArr);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0, iArr, 0, 8);
        } while (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m780e005c(8, iArr, f44c29edb) == 0);
    }

    public static int M855b2871(int[] iArr) {
        if ((25 + 27) % 27 > 0) {
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
        if ((28 + 11) % 11 > 0) {
        }
        long j = ((long) iArr[8]) & 4294967295L;
        long j2 = ((long) iArr[9]) & 4294967295L;
        long j3 = ((long) iArr[10]) & 4294967295L;
        long j4 = ((long) iArr[11]) & 4294967295L;
        long j5 = ((long) iArr[12]) & 4294967295L;
        long j6 = ((long) iArr[13]) & 4294967295L;
        long j7 = ((long) iArr[14]) & 4294967295L;
        long j8 = ((long) iArr[15]) & 4294967295L;
        long j9 = j - 6;
        long j10 = j9 + j2;
        long j11 = j2 + j3;
        long j12 = (j3 + j4) - j8;
        long j13 = j4 + j5;
        long j14 = j5 + j6;
        long j15 = j6 + j7;
        long j16 = j7 + j8;
        long j17 = j15 - j10;
        long j18 = ((((long) iArr[0]) & 4294967295L) - j13) - j17;
        iArr2[0] = (int) j18;
        long j19 = (j18 >> 32) + ((((((long) iArr[1]) & 4294967295L) + j11) - j14) - j16);
        iArr2[1] = (int) j19;
        long j20 = (j19 >> 32) + (((((long) iArr[2]) & 4294967295L) + j12) - j15);
        iArr2[2] = (int) j20;
        long j21 = (j20 >> 32) + ((((((long) iArr[3]) & 4294967295L) + (j13 << 1)) + j17) - j16);
        iArr2[3] = (int) j21;
        long j22 = (j21 >> 32) + ((((((long) iArr[4]) & 4294967295L) + (j14 << 1)) + j7) - j11);
        iArr2[4] = (int) j22;
        long j23 = (j22 >> 32) + (((((long) iArr[5]) & 4294967295L) + (j15 << 1)) - j12);
        iArr2[5] = (int) j23;
        long j24 = (j23 >> 32) + (((long) iArr[6]) & 4294967295L) + (j16 << 1) + j17;
        iArr2[6] = (int) j24;
        long j25 = (j24 >> 32) + (((((((long) iArr[7]) & 4294967295L) + (j8 << 1)) + j9) - j12) - j14);
        iArr2[7] = (int) j25;
        m4cdbfe4c((int) ((j25 >> 32) + 6), iArr2);
    }

    public static void Macab8a08(int[] iArr, int[] iArr2) {
        if ((32 + 16) % 16 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mc2fead1a(8, iArr, 0, iArr2) == 0 && !(iArr2[7] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr2, f44c29edb))) {
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
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcf9f3fde(8, iArr, iArr2) == 0 && !(iArr2[7] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr2, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr2);
    }
}

