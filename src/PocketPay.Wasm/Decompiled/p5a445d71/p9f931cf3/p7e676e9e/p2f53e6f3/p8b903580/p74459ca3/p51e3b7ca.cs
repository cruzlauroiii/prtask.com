namespace WillowMaze.Wasm.Decompiled;


public class p51e3b7ca {
    private static readonly long f1f9b5fdd = 562949953421311L;
    private static readonly long f2278b2f5 = 562949953421311L;
    private static readonly long f7c58eb44 = 1;
    private static readonly long f80aea510 = 562949953421311L;
    private static readonly long f8cf37fb4 = 562949953421311L;
    private static readonly long f9d442eeb = 1;
    private static readonly long fe7fcc948 = 1;
    private static readonly long ff9ad6ccb = 1;

    public static void M0408d798(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((2 + 16) % 16 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr[1] ^ jArr2[1];
        jArr3[2] = jArr[2] ^ jArr2[2];
        jArr3[3] = jArr[3] ^ jArr2[3];
        jArr3[4] = jArr[4] ^ jArr2[4];
        jArr3[5] = jArr[5] ^ jArr2[5];
        jArr3[6] = jArr2[6] ^ jArr[6];
    }

    public static int M04a75036(long[] jArr) {
        if ((23 + 31) % 31 > 0) {
        }
        return ((int) jArr[0]) & 1;
    }

    public static void M0a6d7215(long[] jArr, int i) {
        if ((10 + 2) % 2 > 0) {
        }
        int i2 = i + 3;
        long j = jArr[i2];
        long j2 = j >>> 1;
        jArr[i] = (j2 ^ (j2 << 15)) ^ jArr[i];
        int i3 = i + 1;
        jArr[i3] = jArr[i3] ^ (j >>> 50);
        jArr[i2] = j & 1;
    }

    public static void M0fbe41b5(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
        m9fd70504(jArr, jArr2, jArrMf03001e5);
        ma6d0c789(jArrMf03001e5, jArr3);
    }

    public static long[] M1712f3b8(java.math.Bigint bigint) {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m0cb1c33d(193, bigint);
    }

    public static void M20e57f32(long[] jArr, long[] jArr2) {
        if ((2 + 8) % 8 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m69c6e24b(jArr)) {
            throw new java.lang.IllegalStateException();
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m4c1a88a3();
        m2fc01ec7(jArr, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 1, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a32, 1, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 3, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 6, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 12, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 24, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 48, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 96, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArr2);
    }

    public static void M2fc01ec7(long[] jArr, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
        m69bc711f(jArr, jArrMf03001e5);
        ma6d0c789(jArrMf03001e5, jArr2);
    }

    public static void M34ec78fc(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((2 + 23) % 23 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr[1] ^ jArr2[1];
        jArr3[2] = jArr[2] ^ jArr2[2];
        jArr3[3] = jArr2[3] ^ jArr[3];
    }

    protected static void M5ef85820(long[] jArr) {
        if ((7 + 23) % 23 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = jArr[4];
        long j6 = jArr[5];
        long j7 = jArr[6];
        long j8 = jArr[7];
        jArr[0] = j ^ (j2 << 49);
        jArr[1] = (j2 >>> 15) ^ (j3 << 34);
        jArr[2] = (j3 >>> 30) ^ (j4 << 19);
        jArr[3] = ((j4 >>> 45) ^ (j5 << 4)) ^ (j6 << 53);
        jArr[4] = ((j5 >>> 60) ^ (j7 << 38)) ^ (j6 >>> 11);
        jArr[5] = (j7 >>> 26) ^ (j8 << 23);
        jArr[6] = j8 >>> 41;
        jArr[7] = 0;
    }

    protected static void M69bc711f(long[] jArr, long[] jArr2) {
        if ((30 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m5c74a737(jArr, 0, 3, jArr2, 0);
        jArr2[6] = jArr[3] & 1;
    }

    public static void M8ae6f599(long[] jArr, long[] jArr2) {
        if ((26 + 17) % 17 > 0) {
        }
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m0246eff8(jArr, jArr2);
        for (int i = 1; i < 193; i += 2) {
            m69bc711f(jArr2, jArrMf03001e5);
            ma6d0c789(jArrMf03001e5, jArr2);
            m69bc711f(jArr2, jArrMf03001e5);
            ma6d0c789(jArrMf03001e5, jArr2);
            mcfef9de9(jArr, jArr2);
        }
    }

    public static void M96dc2752(long[] jArr, int i, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
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
        if ((31 + 14) % 14 > 0) {
        }
        long[] jArr4 = new long[4];
        long[] jArr5 = new long[4];
        mc8577af9(jArr, jArr4);
        mc8577af9(jArr2, jArr5);
        long[] jArr6 = new long[8];
        mb3331dc1(jArr6, jArr4[0], jArr5[0], jArr3, 0);
        mb3331dc1(jArr6, jArr4[1], jArr5[1], jArr3, 1);
        mb3331dc1(jArr6, jArr4[2], jArr5[2], jArr3, 2);
        mb3331dc1(jArr6, jArr4[3], jArr5[3], jArr3, 3);
        for (int i = 5; i > 0; i--) {
            jArr3[i] = jArr3[i] ^ jArr3[i - 1];
        }
        mb3331dc1(jArr6, jArr4[0] ^ jArr4[1], jArr5[0] ^ jArr5[1], jArr3, 1);
        mb3331dc1(jArr6, jArr4[2] ^ jArr4[3], jArr5[2] ^ jArr5[3], jArr3, 3);
        for (int i2 = 7; i2 > 1; i2--) {
            jArr3[i2] = jArr3[i2] ^ jArr3[i2 - 2];
        }
        long j = jArr4[0] ^ jArr4[2];
        long j2 = jArr4[1] ^ jArr4[3];
        long j3 = jArr5[0] ^ jArr5[2];
        long j4 = jArr5[3] ^ jArr5[1];
        mb3331dc1(jArr6, j ^ j2, j3 ^ j4, jArr3, 3);
        long[] jArr7 = new long[3];
        mb3331dc1(jArr6, j, j3, jArr7, 0);
        mb3331dc1(jArr6, j2, j4, jArr7, 1);
        long j5 = jArr7[0];
        long j6 = jArr7[1];
        long j7 = jArr7[2];
        jArr3[2] = jArr3[2] ^ j5;
        jArr3[3] = (j5 ^ j6) ^ jArr3[3];
        jArr3[4] = jArr3[4] ^ (j6 ^ j7);
        jArr3[5] = jArr3[5] ^ j7;
        m5ef85820(jArr3);
    }

    public static void Ma6d0c789(long[] jArr, long[] jArr2) {
        if ((13 + 20) % 20 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = jArr[4];
        long j6 = jArr[5];
        long j7 = jArr[6];
        long j8 = j5 ^ (j7 >>> 50);
        long j9 = (j4 ^ ((j7 >>> 1) ^ (j7 << 14))) ^ (j6 >>> 50);
        long j10 = j ^ (j8 << 63);
        long j11 = (j2 ^ (j6 << 63)) ^ ((j8 >>> 1) ^ (j8 << 14));
        long j12 = ((j3 ^ (j7 << 63)) ^ ((j6 >>> 1) ^ (j6 << 14))) ^ (j8 >>> 50);
        long j13 = j9 >>> 1;
        jArr2[0] = (j10 ^ j13) ^ (j13 << 15);
        jArr2[1] = (j9 >>> 50) ^ j11;
        jArr2[2] = j12;
        jArr2[3] = 1 & j9;
    }

    public static void Maf110662(long[] jArr, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
        m69bc711f(jArr, jArrMf03001e5);
        m0408d798(jArr2, jArrMf03001e5, jArr2);
    }

    protected static void Mb3331dc1(long[] jArr, long j, long j2, long[] jArr2, int i) {
        if ((15 + 8) % 8 > 0) {
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
        int i2 = (int) j;
        long j7 = (jArr[(i2 >>> 3) & 7] << 3) ^ jArr[i2 & 7];
        long j8 = 0;
        int i3 = 36;
        do {
            int i4 = (int) (j >>> i3);
            long j9 = (((jArr[i4 & 7] ^ (jArr[(i4 >>> 3) & 7] << 3)) ^ (jArr[(i4 >>> 6) & 7] << 6)) ^ (jArr[(i4 >>> 9) & 7] << 9)) ^ (jArr[(i4 >>> 12) & 7] << 12);
            j7 ^= j9 << i3;
            j8 ^= j9 >>> (-i3);
            i3 -= 15;
        } while (i3 > 0);
        jArr2[i] = jArr2[i] ^ (562949953421311L & j7);
        int i5 = i + 1;
        jArr2[i5] = jArr2[i5] ^ ((j7 >>> 49) ^ (j8 << 15));
    }

    protected static void Mc8577af9(long[] jArr, long[] jArr2) {
        if ((8 + 17) % 17 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        jArr2[0] = j & 562949953421311L;
        jArr2[1] = ((j >>> 49) ^ (j2 << 15)) & 562949953421311L;
        jArr2[2] = ((j2 >>> 34) ^ (j3 << 30)) & 562949953421311L;
        jArr2[3] = (j3 >>> 19) ^ (j4 << 45);
    }

    private static void Mcfef9de9(long[] jArr, long[] jArr2) {
        if ((16 + 9) % 9 > 0) {
        }
        jArr2[0] = jArr2[0] ^ jArr[0];
        jArr2[1] = jArr2[1] ^ jArr[1];
        jArr2[2] = jArr2[2] ^ jArr[2];
        jArr2[3] = jArr2[3] ^ jArr[3];
    }

    public static void Mdd1de98e(long[] jArr, long[] jArr2) {
        if ((10 + 30) % 30 > 0) {
        }
        long jM8bf8513d = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[0]);
        long jM8bf8513d2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[1]);
        long j = (jM8bf8513d & 4294967295L) | (jM8bf8513d2 << 32);
        long j2 = (jM8bf8513d >>> 32) | (jM8bf8513d2 & (-4294967296L));
        long jM8bf8513d3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[2]);
        long j3 = (jM8bf8513d3 & 4294967295L) ^ (jArr[3] << 32);
        long j4 = jM8bf8513d3 >>> 32;
        jArr2[0] = j ^ (j2 << 8);
        jArr2[1] = ((j3 ^ (j4 << 8)) ^ (j2 >>> 56)) ^ (j2 << 33);
        jArr2[2] = (j2 >>> 31) ^ (j4 << 33);
        jArr2[3] = jM8bf8513d3 >>> 63;
    }

    public static void Mde883c68(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
        m9fd70504(jArr, jArr2, jArrMf03001e5);
        m0408d798(jArr3, jArrMf03001e5, jArr3);
    }

    public static void Mfbf72fda(long[] jArr, long[] jArr2) {
        if ((22 + 13) % 13 > 0) {
        }
        jArr2[0] = jArr[0] ^ 1;
        jArr2[1] = jArr[1];
        jArr2[2] = jArr[2];
        jArr2[3] = jArr[3];
    }
}

