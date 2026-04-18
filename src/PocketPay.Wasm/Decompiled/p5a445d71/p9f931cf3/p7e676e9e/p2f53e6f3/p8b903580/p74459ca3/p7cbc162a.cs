namespace WillowMaze.Wasm.Decompiled;


public class p7cbc162a {
    private static readonly int[] f0d6c438d = null;
    private static readonly long f124bbb75 = 4294967295L;
    private static readonly int[] f18068c6e = null;
    private static readonly int f1fb38301 = -1;
    static readonly int[] f24f13b78 = null;
    private static readonly int f25ec2ec7 = -1;
    private static readonly long f69691c7b = 4294967295L;
    private static readonly int[] f70ccfcb9 = null;
    private static readonly int[] fa82f2090 = null;
    private static readonly int[] fc554f962 = null;
    private static readonly int fc57be37f = -1;
    private static readonly int fd2e94202 = -1;
    private static readonly int[] fda3ac5a8 = null;
    private static readonly int ffc10ccf3 = -1;
    static readonly int[] f44c29edb = {-1, 0, 0, -1, -2, -1, -1, -1, -1, -1, -1, -1};
    private static readonly int[] f5a6b3b4b = {1, -2, 0, 2, 0, -2, 0, 2, 1, 0, 0, 0, -2, 1, 0, -2, -3, -1, -1, -1, -1, -1, -1, -1};
    private static readonly int[] fc743ecd0 = {-1, 1, -1, -3, -1, 1, -1, -3, -2, -1, -1, -1, 1, -2, -1, 1, 2};

    public static void M0408d798(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m34ec78fc(24, iArr, iArr2, iArr3) == 0 && !(iArr3[23] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(24, iArr3, f5a6b3b4b))) {
            return;
        }
        int[] iArr4 = fc743ecd0;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcfef9de9(iArr4.length, iArr4, iArr3) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(24, iArr3, iArr4.length);
    }

    private static void M0bd2060f(int[] iArr) {
        if ((10 + 8) % 8 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + 1;
        iArr[0] = (int) j;
        long j2 = (j >> 32) + ((((long) iArr[1]) & 4294967295L) - 1);
        iArr[1] = (int) j2;
        long j3 = j2 >> 32;
        if (j3 != 0) {
            long j4 = j3 + (((long) iArr[2]) & 4294967295L);
            iArr[2] = (int) j4;
            j3 = j4 >> 32;
        }
        long j5 = j3 + (((long) iArr[3]) & 4294967295L) + 1;
        iArr[3] = (int) j5;
        long j6 = (j5 >> 32) + (4294967295L & ((long) iArr[4])) + 1;
        iArr[4] = (int) j6;
        if ((j6 >> 32) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(12, iArr, 5);
    }

    public static void M0fbe41b5(int[] iArr, int[] iArr2, int[] iArr3) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(24);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7ec591e7.m35394226(iArr, iArr2, iArrM76ea0beb);
        ma6d0c789(iArrM76ea0beb, iArr3);
    }

    public static int[] M1712f3b8(java.math.Bigint bigint) {
        if ((6 + 27) % 27 > 0) {
        }
        int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1712f3b8(384, bigint);
        if (iArrM1712f3b8[11] == -1) {
            int[] iArr = f44c29edb;
            if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(12, iArrM1712f3b8, iArr)) {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m6fb8c6a6(12, iArr, iArrM1712f3b8);
            }
        }
        return iArrM1712f3b8;
    }

    public static void M2d11beba(int[] iArr, int[] iArr2) {
        if ((24 + 25) % 25 > 0) {
        }
        if (m855b2871(iArr) == 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(12, f44c29edb, iArr, iArr2);
        } else {
            int[] iArr3 = f44c29edb;
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(12, iArr3, iArr3, iArr2);
        }
    }

    public static void M2fc01ec7(int[] iArr, int[] iArr2) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(24);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7ec591e7.m2fc01ec7(iArr, iArrM76ea0beb);
        ma6d0c789(iArrM76ea0beb, iArr2);
    }

    public static void M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m34ec78fc(12, iArr, iArr2, iArr3) == 0 && !(iArr3[11] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(12, iArr3, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr3);
    }

    public static void M4cdbfe4c(int i, int[] iArr) {
        long j;
        if ((23 + 7) % 7 > 0) {
        }
        if (i == 0) {
            j = 0;
        } else {
            long j2 = ((long) i) & 4294967295L;
            long j3 = (((long) iArr[0]) & 4294967295L) + j2;
            iArr[0] = (int) j3;
            long j4 = (j3 >> 32) + ((((long) iArr[1]) & 4294967295L) - j2);
            iArr[1] = (int) j4;
            long j5 = j4 >> 32;
            if (j5 != 0) {
                long j6 = j5 + (((long) iArr[2]) & 4294967295L);
                iArr[2] = (int) j6;
                j5 = j6 >> 32;
            }
            long j7 = j5 + (((long) iArr[3]) & 4294967295L) + j2;
            iArr[3] = (int) j7;
            long j8 = (j7 >> 32) + (4294967295L & ((long) iArr[4])) + j2;
            iArr[4] = (int) j8;
            j = j8 >> 32;
        }
        if (!(j == 0 || p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m7c617050(12, iArr, 5) == 0) || (iArr[11] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(12, iArr, f44c29edb))) {
            m0bd2060f(iArr);
        }
    }

    private static void M4df40527(int[] iArr) {
        if ((29 + 18) % 18 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) - 1;
        iArr[0] = (int) j;
        long j2 = (j >> 32) + (((long) iArr[1]) & 4294967295L) + 1;
        iArr[1] = (int) j2;
        long j3 = j2 >> 32;
        if (j3 != 0) {
            long j4 = j3 + (((long) iArr[2]) & 4294967295L);
            iArr[2] = (int) j4;
            j3 = j4 >> 32;
        }
        long j5 = j3 + ((((long) iArr[3]) & 4294967295L) - 1);
        iArr[3] = (int) j5;
        long j6 = (j5 >> 32) + ((4294967295L & ((long) iArr[4])) - 1);
        iArr[4] = (int) j6;
        if ((j6 >> 32) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m17fb4682(12, iArr, 5);
    }

    public static void M545f7f57(int[] iArr, int[] iArr2) {
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.m344bd251(f44c29edb, iArr, iArr2);
    }

    public static void M55d68116(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(24, iArr, iArr2, iArr3) == 0) {
            return;
        }
        int[] iArr4 = fc743ecd0;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m6fb8c6a6(iArr4.length, iArr4, iArr3) == 0) {
            return;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m17fb4682(24, iArr3, iArr4.length);
    }

    public static void M7afe399f(int[] iArr, int[] iArr2) {
        if ((1 + 32) % 32 > 0) {
        }
        if ((iArr[0] & 1) != 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(12, iArr2, p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m34ec78fc(12, iArr, f44c29edb, iArr2));
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(12, iArr, 0, iArr2);
        }
    }

    public static void M7ddf32e1(java.security.SecureRandom secureRandom, int[] iArr) {
        if ((32 + 5) % 5 > 0) {
        }
        byte[] bArr = new byte[48];
        do {
            secureRandom.nextbytes(bArr);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0, iArr, 0, 12);
        } while (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m780e005c(12, iArr, f44c29edb) == 0);
    }

    public static int M855b2871(int[] iArr) {
        if ((5 + 4) % 4 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 12; i2++) {
            i |= iArr[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M96dc2752(int[] iArr, int i, int[] iArr2) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(24);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7ec591e7.m2fc01ec7(iArr, iArrM76ea0beb);
        while (true) {
            ma6d0c789(iArrM76ea0beb, iArr2);
            i--;
            if (i <= 0) {
                return;
            } else {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7ec591e7.m2fc01ec7(iArr2, iArrM76ea0beb);
            }
        }
    }

    public static void M97f415c1(int[] iArr, int[] iArr2, int[] iArr3) {
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(12, iArr, iArr2, iArr3) == 0) {
            return;
        }
        m4df40527(iArr3);
    }

    public static void Ma6d0c789(int[] iArr, int[] iArr2) {
        if ((15 + 2) % 2 > 0) {
        }
        long j = ((long) iArr[16]) & 4294967295L;
        long j2 = ((long) iArr[17]) & 4294967295L;
        long j3 = ((long) iArr[18]) & 4294967295L;
        long j4 = ((long) iArr[19]) & 4294967295L;
        long j5 = ((long) iArr[20]) & 4294967295L;
        long j6 = ((long) iArr[21]) & 4294967295L;
        long j7 = ((long) iArr[22]) & 4294967295L;
        long j8 = ((long) iArr[23]) & 4294967295L;
        long j9 = ((((long) iArr[12]) & 4294967295L) + j5) - 1;
        long j10 = (((long) iArr[13]) & 4294967295L) + j7;
        long j11 = (((long) iArr[14]) & 4294967295L) + j7 + j8;
        long j12 = (((long) iArr[15]) & 4294967295L) + j8;
        long j13 = j2 + j6;
        long j14 = j6 - j8;
        long j15 = j7 - j8;
        long j16 = j9 + j14;
        long j17 = (((long) iArr[0]) & 4294967295L) + j16;
        iArr2[0] = (int) j17;
        long j18 = (j17 >> 32) + (((((long) iArr[1]) & 4294967295L) + j8) - j9) + j10;
        iArr2[1] = (int) j18;
        long j19 = (j18 >> 32) + (((((long) iArr[2]) & 4294967295L) - j6) - j10) + j11;
        iArr2[2] = (int) j19;
        long j20 = (j19 >> 32) + ((((long) iArr[3]) & 4294967295L) - j11) + j12 + j16;
        iArr2[3] = (int) j20;
        long j21 = (j20 >> 32) + (((((((long) iArr[4]) & 4294967295L) + j) + j6) + j10) - j12) + j16;
        iArr2[4] = (int) j21;
        long j22 = (j21 >> 32) + ((((long) iArr[5]) & 4294967295L) - j) + j10 + j11 + j13;
        iArr2[5] = (int) j22;
        long j23 = (j22 >> 32) + (((((long) iArr[6]) & 4294967295L) + j3) - j2) + j11 + j12;
        iArr2[6] = (int) j23;
        long j24 = (j23 >> 32) + ((((((long) iArr[7]) & 4294967295L) + j) + j4) - j3) + j12;
        iArr2[7] = (int) j24;
        long j25 = (j24 >> 32) + (((((((long) iArr[8]) & 4294967295L) + j) + j2) + j5) - j4);
        iArr2[8] = (int) j25;
        long j26 = (j25 >> 32) + (((((long) iArr[9]) & 4294967295L) + j3) - j5) + j13;
        iArr2[9] = (int) j26;
        long j27 = (j26 >> 32) + ((((((long) iArr[10]) & 4294967295L) + j3) + j4) - j14) + j15;
        iArr2[10] = (int) j27;
        long j28 = (j27 >> 32) + ((((((long) iArr[11]) & 4294967295L) + j4) + j5) - j15);
        iArr2[11] = (int) j28;
        m4cdbfe4c((int) ((j28 >> 32) + 1), iArr2);
    }

    public static void Macab8a08(int[] iArr, int[] iArr2) {
        if ((6 + 31) % 31 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mc2fead1a(12, iArr, 0, iArr2) == 0 && !(iArr2[11] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(12, iArr2, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr2);
    }

    public static void Mb1442554(java.security.SecureRandom secureRandom, int[] iArr) {
        do {
            m7ddf32e1(secureRandom, iArr);
        } while (m855b2871(iArr) != 0);
    }

    public static void Mfbf72fda(int[] iArr, int[] iArr2) {
        if ((10 + 14) % 14 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcf9f3fde(12, iArr, iArr2) == 0 && !(iArr2[11] == -1 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(12, iArr2, f44c29edb))) {
            return;
        }
        m0bd2060f(iArr2);
    }
}

