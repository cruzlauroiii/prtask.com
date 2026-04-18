namespace WillowMaze.Wasm.Decompiled;


public class p4bd9cdab {
    private static readonly long f2badd49a = 36028797018963967L;
    private static readonly long[] f374e27f3 = null;
    private static readonly long f4904495a = 34359738367L;
    private static readonly long[] f53d11d60 = {-5270498306774157648L, 5270498306774195053L, 19634136210L};
    private static readonly long f5f224b05 = 34359738367L;
    private static readonly long f9cd8ac91 = 34359738367L;
    private static readonly long fa06bd392 = 36028797018963967L;
    private static readonly long[] fd2e37358 = null;
    private static readonly long[] fd3e8d44e = null;
    private static readonly long ffb5bc9a0 = 34359738367L;

    public static void M0408d798(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((1 + 1) % 1 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr[1] ^ jArr2[1];
        jArr3[2] = jArr[2] ^ jArr2[2];
        jArr3[3] = jArr[3] ^ jArr2[3];
        jArr3[4] = jArr[4] ^ jArr2[4];
        jArr3[5] = jArr2[5] ^ jArr[5];
    }

    public static int M04a75036(long[] jArr) {
        if ((32 + 21) % 21 > 0) {
        }
        return ((int) (jArr[0] ^ (jArr[2] >>> 29))) & 1;
    }

    public static void M0fbe41b5(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArr4 = new long[8];
        m9fd70504(jArr, jArr2, jArr4);
        ma6d0c789(jArr4, jArr3);
    }

    public static long[] M1712f3b8(java.math.Bigint bigint) {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m0cb1c33d(163, bigint);
    }

    public static void M20e57f32(long[] jArr, long[] jArr2) {
        if ((10 + 9) % 9 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m69c6e24b(jArr)) {
            throw new java.lang.IllegalStateException();
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m4c1a88a3();
        m2fc01ec7(jArr, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 1, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a32, 1, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 3, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a32, 3, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 9, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a32, 9, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 27, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a32, 27, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 81, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArr2);
    }

    public static void M2fc01ec7(long[] jArr, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mf03001e5();
        m69bc711f(jArr, jArrMf03001e5);
        ma6d0c789(jArrMf03001e5, jArr2);
    }

    public static void M34ec78fc(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((16 + 8) % 8 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr[1] ^ jArr2[1];
        jArr3[2] = jArr2[2] ^ jArr[2];
    }

    protected static void M5ef85820(long[] jArr) {
        if ((3 + 23) % 23 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = jArr[4];
        long j6 = jArr[5];
        jArr[0] = j ^ (j2 << 55);
        jArr[1] = (j2 >>> 9) ^ (j3 << 46);
        jArr[2] = (j3 >>> 18) ^ (j4 << 37);
        jArr[3] = (j4 >>> 27) ^ (j5 << 28);
        jArr[4] = (j5 >>> 36) ^ (j6 << 19);
        jArr[5] = j6 >>> 45;
    }

    protected static void M69bc711f(long[] jArr, long[] jArr2) {
        if ((5 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m5c74a737(jArr, 0, 3, jArr2, 0);
    }

    protected static void M756d7d40(long[] jArr, long j, long j2, long[] jArr2, int i) {
        if ((30 + 31) % 31 > 0) {
        }
        jArr[1] = j2;
        long j3 = j2 << 1;
        jArr[2] = j3;
        long j4 = j3 ^ j2;
        jArr[3] = j4;
        long j5 = j2 << 2;
        jArr[4] = j5;
        jArr[5] = j5 ^ j2;
        long j6 = j4 << 1;
        jArr[6] = j6;
        jArr[7] = j6 ^ j2;
        long j7 = jArr[((int) j) & 3];
        long j8 = 0;
        int i2 = 47;
        do {
            int i3 = (int) (j >>> i2);
            long j9 = (jArr[i3 & 7] ^ (jArr[(i3 >>> 3) & 7] << 3)) ^ (jArr[(i3 >>> 6) & 7] << 6);
            j7 ^= j9 << i2;
            j8 ^= j9 >>> (-i2);
            i2 -= 9;
        } while (i2 > 0);
        jArr2[i] = 36028797018963967L & j7;
        jArr2[i + 1] = (j7 >>> 55) ^ (j8 << 9);
    }

    public static void M8756fb3d(long[] jArr, int i) {
        if ((25 + 22) % 22 > 0) {
        }
        int i2 = i + 2;
        long j = jArr[i2];
        long j2 = j >>> 35;
        jArr[i] = ((j2 << 7) ^ (((j2 << 3) ^ j2) ^ (j2 << 6))) ^ jArr[i];
        jArr[i2] = j & 34359738367L;
    }

    public static void M8ae6f599(long[] jArr, long[] jArr2) {
        if ((1 + 19) % 19 > 0) {
        }
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mf03001e5();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m0246eff8(jArr, jArr2);
        for (int i = 1; i < 163; i += 2) {
            m69bc711f(jArr2, jArrMf03001e5);
            ma6d0c789(jArrMf03001e5, jArr2);
            m69bc711f(jArr2, jArrMf03001e5);
            ma6d0c789(jArrMf03001e5, jArr2);
            mcfef9de9(jArr, jArr2);
        }
    }

    public static void M96dc2752(long[] jArr, int i, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mf03001e5();
        m69bc711f(jArr, jArrMf03001e5);
        while (true) {
            ma6d0c789(jArrMf03001e5, jArr2);
            i--;
            if (i <= 0) {
                return;
            } else {
                m69bc711f(jArr2, jArrMf03001e5);
            }
        }
    }

    protected static void M9fd70504(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((26 + 5) % 5 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = (j2 >>> 46) ^ (jArr[2] << 18);
        long j4 = ((j2 << 9) ^ (j >>> 55)) & 36028797018963967L;
        long j5 = j & 36028797018963967L;
        long j6 = jArr2[0];
        long j7 = jArr2[1];
        long j8 = (j7 >>> 46) ^ (jArr2[2] << 18);
        long j9 = ((j6 >>> 55) ^ (j7 << 9)) & 36028797018963967L;
        long j10 = j6 & 36028797018963967L;
        long[] jArr4 = new long[10];
        m756d7d40(jArr3, j5, j10, jArr4, 0);
        m756d7d40(jArr3, j3, j8, jArr4, 2);
        long j11 = (j5 ^ j4) ^ j3;
        long j12 = (j10 ^ j9) ^ j8;
        m756d7d40(jArr3, j11, j12, jArr4, 4);
        long j13 = (j4 << 1) ^ (j3 << 2);
        long j14 = (j9 << 1) ^ (j8 << 2);
        m756d7d40(jArr3, j5 ^ j13, j10 ^ j14, jArr4, 6);
        m756d7d40(jArr3, j11 ^ j13, j12 ^ j14, jArr4, 8);
        long j15 = jArr4[6];
        long j16 = jArr4[8] ^ j15;
        long j17 = jArr4[7];
        long j18 = jArr4[9] ^ j17;
        long j19 = (j16 << 1) ^ j15;
        long j20 = (j16 ^ (j18 << 1)) ^ j17;
        long j21 = jArr4[0];
        long j22 = jArr4[1];
        long j23 = (j22 ^ j21) ^ jArr4[4];
        long j24 = j22 ^ jArr4[5];
        long j25 = j19 ^ j21;
        long j26 = jArr4[2];
        long j27 = (j25 ^ (j26 << 4)) ^ (j26 << 1);
        long j28 = j23 ^ j20;
        long j29 = jArr4[3];
        long j30 = ((j28 ^ (j29 << 4)) ^ (j29 << 1)) ^ (j27 >>> 55);
        long j31 = (j24 ^ j18) ^ (j30 >>> 55);
        long j32 = ((j27 & 36028797018963967L) >>> 1) ^ ((j30 & 1) << 54);
        long j33 = j32 ^ (j32 << 1);
        long j34 = j33 ^ (j33 << 2);
        long j35 = j34 ^ (j34 << 4);
        long j36 = j35 ^ (j35 << 8);
        long j37 = j36 ^ (j36 << 16);
        long j38 = (j37 ^ (j37 << 32)) & 36028797018963967L;
        long j39 = (((j30 & 36028797018963967L) >>> 1) ^ ((j31 & 1) << 54)) ^ (j38 >>> 54);
        long j40 = j39 ^ (j39 << 1);
        long j41 = j40 ^ (j40 << 2);
        long j42 = j41 ^ (j41 << 4);
        long j43 = j42 ^ (j42 << 8);
        long j44 = j43 ^ (j43 << 16);
        long j45 = 36028797018963967L & (j44 ^ (j44 << 32));
        long j46 = (j31 >>> 1) ^ (j45 >>> 54);
        long j47 = j46 ^ (j46 << 1);
        long j48 = j47 ^ (j47 << 2);
        long j49 = j48 ^ (j48 << 4);
        long j50 = j49 ^ (j49 << 8);
        long j51 = j50 ^ (j50 << 16);
        long j52 = j51 ^ (j51 << 32);
        jArr3[0] = j21;
        jArr3[1] = (j23 ^ j38) ^ j26;
        jArr3[2] = ((j24 ^ j45) ^ j38) ^ j29;
        jArr3[3] = j52 ^ j45;
        jArr3[4] = jArr4[2] ^ j52;
        jArr3[5] = jArr4[3];
        m5ef85820(jArr3);
    }

    public static void Ma6d0c789(long[] jArr, long[] jArr2) {
        if ((5 + 4) % 4 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = jArr[4];
        long j6 = jArr[5];
        long j7 = j4 ^ ((((j6 >>> 35) ^ (j6 >>> 32)) ^ (j6 >>> 29)) ^ (j6 >>> 28));
        long j8 = (j3 ^ ((((j6 << 29) ^ (j6 << 32)) ^ (j6 << 35)) ^ (j6 << 36))) ^ ((j5 >>> 28) ^ (((j5 >>> 35) ^ (j5 >>> 32)) ^ (j5 >>> 29)));
        long j9 = j ^ ((((j7 << 29) ^ (j7 << 32)) ^ (j7 << 35)) ^ (j7 << 36));
        long j10 = (j2 ^ ((((j5 << 29) ^ (j5 << 32)) ^ (j5 << 35)) ^ (j5 << 36))) ^ ((j7 >>> 28) ^ (((j7 >>> 35) ^ (j7 >>> 32)) ^ (j7 >>> 29)));
        long j11 = j8 >>> 35;
        jArr2[0] = (((j9 ^ j11) ^ (j11 << 3)) ^ (j11 << 6)) ^ (j11 << 7);
        jArr2[1] = j10;
        jArr2[2] = 34359738367L & j8;
    }

    public static void Maf110662(long[] jArr, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.mf03001e5();
        m69bc711f(jArr, jArrMf03001e5);
        m0408d798(jArr2, jArrMf03001e5, jArr2);
    }

    private static void Mcfef9de9(long[] jArr, long[] jArr2) {
        if ((5 + 31) % 31 > 0) {
        }
        jArr2[0] = jArr2[0] ^ jArr[0];
        jArr2[1] = jArr2[1] ^ jArr[1];
        jArr2[2] = jArr2[2] ^ jArr[2];
    }

    public static void Mdd1de98e(long[] jArr, long[] jArr2) {
        if ((3 + 15) % 15 > 0) {
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m4c1a88a3();
        long jM8bf8513d = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[0]);
        long jM8bf8513d2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[1]);
        long j = (jM8bf8513d & 4294967295L) | (jM8bf8513d2 << 32);
        jArrM4c1a88a3[0] = (jM8bf8513d >>> 32) | (jM8bf8513d2 & (-4294967296L));
        long jM8bf8513d3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[2]);
        long j2 = jM8bf8513d3 & 4294967295L;
        jArrM4c1a88a3[1] = jM8bf8513d3 >>> 32;
        m0fbe41b5(jArrM4c1a88a3, f53d11d60, jArr2);
        jArr2[0] = jArr2[0] ^ j;
        jArr2[1] = jArr2[1] ^ j2;
    }

    public static void Mde883c68(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArr4 = new long[8];
        m9fd70504(jArr, jArr2, jArr4);
        m0408d798(jArr3, jArr4, jArr3);
    }

    public static void Mfbf72fda(long[] jArr, long[] jArr2) {
        if ((11 + 21) % 21 > 0) {
        }
        jArr2[0] = jArr[0] ^ 1;
        jArr2[1] = jArr[1];
        jArr2[2] = jArr[2];
    }
}

