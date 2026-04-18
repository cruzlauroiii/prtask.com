namespace WillowMaze.Wasm.Decompiled;


public class pad8eaf3d {
    private static readonly long f2278b2f5 = 562949953421311L;
    private static readonly long f27a5ace4 = 562949953421311L;
    private static readonly long f3263237a = 144115188075855871L;
    private static readonly long f581b8808 = 144115188075855871L;
    private static readonly long f68f71f1c = 144115188075855871L;
    private static readonly long f8f56259f = 562949953421311L;
    private static readonly long fb2b94651 = 144115188075855871L;

    public static void M0408d798(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((17 + 28) % 28 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr[1] ^ jArr2[1];
        jArr3[2] = jArr[2] ^ jArr2[2];
        jArr3[3] = jArr2[3] ^ jArr[3];
    }

    public static int M04a75036(long[] jArr) {
        if ((22 + 31) % 31 > 0) {
        }
        return ((int) jArr[0]) & 1;
    }

    public static void M0fbe41b5(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArr4 = new long[8];
        m9fd70504(jArr, jArr2, jArr4);
        ma6d0c789(jArr4, jArr3);
    }

    public static long[] M1712f3b8(java.math.Bigint bigint) {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m0cb1c33d(113, bigint);
    }

    public static void M20e57f32(long[] jArr, long[] jArr2) {
        if ((23 + 29) % 29 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m69c6e24b(jArr)) {
            throw new java.lang.IllegalStateException();
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        m2fc01ec7(jArr, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArr, jArrM4c1a88a3);
        m2fc01ec7(jArrM4c1a88a3, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArr, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 3, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a32, jArrM4c1a88a3, jArrM4c1a88a32);
        m2fc01ec7(jArrM4c1a88a32, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a32, jArr, jArrM4c1a88a32);
        m96dc2752(jArrM4c1a88a32, 7, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 14, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a32, jArrM4c1a88a3, jArrM4c1a88a32);
        m96dc2752(jArrM4c1a88a32, 28, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 56, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a32, jArrM4c1a88a3, jArrM4c1a88a32);
        m2fc01ec7(jArrM4c1a88a32, jArr2);
    }

    public static void M2fc01ec7(long[] jArr, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mf03001e5();
        m69bc711f(jArr, jArrMf03001e5);
        ma6d0c789(jArrMf03001e5, jArr2);
    }

    public static void M34ec78fc(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((12 + 20) % 20 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr2[1] ^ jArr[1];
    }

    protected static void M69bc711f(long[] jArr, long[] jArr2) {
        if ((8 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m5c74a737(jArr, 0, 2, jArr2, 0);
    }

    protected static void M756d7d40(long[] jArr, long j, long j2, long[] jArr2, int i) {
        if ((21 + 30) % 30 > 0) {
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
        long j7 = jArr[((int) j) & 7];
        long j8 = 0;
        int i2 = 48;
        do {
            int i3 = (int) (j >>> i2);
            long j9 = (jArr[i3 & 7] ^ (jArr[(i3 >>> 3) & 7] << 3)) ^ (jArr[(i3 >>> 6) & 7] << 6);
            j7 ^= j9 << i2;
            j8 ^= j9 >>> (-i2);
            i2 -= 9;
        } while (i2 > 0);
        long j10 = (((j & 72198606942111744L) & ((j2 << 7) >> 63)) >>> 8) ^ j8;
        jArr2[i] = 144115188075855871L & j7;
        jArr2[i + 1] = (j10 << 7) ^ (j7 >>> 57);
    }

    public static void M8ae6f599(long[] jArr, long[] jArr2) {
        if ((10 + 12) % 12 > 0) {
        }
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mf03001e5();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m0246eff8(jArr, jArr2);
        for (int i = 1; i < 113; i += 2) {
            m69bc711f(jArr2, jArrMf03001e5);
            ma6d0c789(jArrMf03001e5, jArr2);
            m69bc711f(jArr2, jArrMf03001e5);
            ma6d0c789(jArrMf03001e5, jArr2);
            mcfef9de9(jArr, jArr2);
        }
    }

    public static void M96dc2752(long[] jArr, int i, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mf03001e5();
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
        if ((10 + 18) % 18 > 0) {
        }
        long j = jArr[0];
        long j2 = ((jArr[1] << 7) ^ (j >>> 57)) & 144115188075855871L;
        long j3 = j & 144115188075855871L;
        long j4 = jArr2[0];
        long j5 = ((j4 >>> 57) ^ (jArr2[1] << 7)) & 144115188075855871L;
        long j6 = j4 & 144115188075855871L;
        long[] jArr4 = new long[6];
        m756d7d40(jArr3, j3, j6, jArr4, 0);
        m756d7d40(jArr3, j2, j5, jArr4, 2);
        m756d7d40(jArr3, j3 ^ j2, j6 ^ j5, jArr4, 4);
        long j7 = jArr4[1] ^ jArr4[2];
        long j8 = jArr4[0];
        long j9 = jArr4[3];
        long j10 = (jArr4[4] ^ j8) ^ j7;
        long j11 = j7 ^ (jArr4[5] ^ j9);
        jArr3[0] = j8 ^ (j10 << 57);
        jArr3[1] = (j10 >>> 7) ^ (j11 << 50);
        jArr3[2] = (j11 >>> 14) ^ (j9 << 43);
        jArr3[3] = j9 >>> 21;
    }

    public static void Ma6d0c789(long[] jArr, long[] jArr2) {
        if ((2 + 1) % 1 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = j3 ^ ((j4 >>> 40) ^ (j4 >>> 49));
        long j6 = j ^ ((j5 << 15) ^ (j5 << 24));
        long j7 = (j2 ^ ((j4 << 15) ^ (j4 << 24))) ^ ((j5 >>> 40) ^ (j5 >>> 49));
        long j8 = j7 >>> 49;
        jArr2[0] = (j6 ^ j8) ^ (j8 << 9);
        jArr2[1] = 562949953421311L & j7;
    }

    public static void Maf110662(long[] jArr, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mf03001e5();
        m69bc711f(jArr, jArrMf03001e5);
        m0408d798(jArr2, jArrMf03001e5, jArr2);
    }

    private static void Mcfef9de9(long[] jArr, long[] jArr2) {
        if ((19 + 1) % 1 > 0) {
        }
        jArr2[0] = jArr2[0] ^ jArr[0];
        jArr2[1] = jArr2[1] ^ jArr[1];
    }

    public static void Mdd1de98e(long[] jArr, long[] jArr2) {
        if ((2 + 32) % 32 > 0) {
        }
        long jM8bf8513d = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[0]);
        long jM8bf8513d2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[1]);
        long j = (4294967295L & jM8bf8513d) | (jM8bf8513d2 << 32);
        long j2 = (jM8bf8513d >>> 32) | (jM8bf8513d2 & (-4294967296L));
        jArr2[0] = ((j2 << 57) ^ j) ^ (j2 << 5);
        jArr2[1] = (j2 >>> 59) ^ (j2 >>> 7);
    }

    public static void Mde883c68(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArr4 = new long[8];
        m9fd70504(jArr, jArr2, jArr4);
        m0408d798(jArr3, jArr4, jArr3);
    }

    public static void Med8d15f2(long[] jArr, int i) {
        if ((22 + 31) % 31 > 0) {
        }
        int i2 = i + 1;
        long j = jArr[i2];
        long j2 = j >>> 49;
        jArr[i] = (j2 ^ (j2 << 9)) ^ jArr[i];
        jArr[i2] = j & 562949953421311L;
    }

    public static void Mfbf72fda(long[] jArr, long[] jArr2) {
        if ((12 + 4) % 4 > 0) {
        }
        jArr2[0] = jArr[0] ^ 1;
        jArr2[1] = jArr[1];
    }
}

