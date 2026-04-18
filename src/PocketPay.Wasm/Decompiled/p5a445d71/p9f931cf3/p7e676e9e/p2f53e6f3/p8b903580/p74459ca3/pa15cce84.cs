namespace WillowMaze.Wasm.Decompiled;


public class pa15cce84 {
    private static readonly long f4420d232 = 1152921504606846975L;
    private static readonly long f4bf77c66 = 140737488355327L;
    private static readonly long f7985e0de = 1152921504606846975L;
    private static readonly long fb2702ac4 = 140737488355327L;
    private static readonly long fcb0e9ec3 = 140737488355327L;
    private static readonly long fe1b5fb68 = 1152921504606846975L;

    public static void M0408d798(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((27 + 19) % 19 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr[1] ^ jArr2[1];
        jArr3[2] = jArr[2] ^ jArr2[2];
        jArr3[3] = jArr[3] ^ jArr2[3];
        jArr3[4] = jArr[4] ^ jArr2[4];
        jArr3[5] = jArr[5] ^ jArr2[5];
        jArr3[6] = jArr[6] ^ jArr2[6];
        jArr3[7] = jArr2[7] ^ jArr[7];
    }

    public static int M04a75036(long[] jArr) {
        if ((32 + 8) % 8 > 0) {
        }
        return ((int) ((jArr[0] ^ (jArr[1] >>> 17)) ^ (jArr[2] >>> 34))) & 1;
    }

    public static void M0fbe41b5(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
        m9fd70504(jArr, jArr2, jArrMf03001e5);
        ma6d0c789(jArrMf03001e5, jArr3);
    }

    public static long[] M1712f3b8(java.math.Bigint bigint) {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m0cb1c33d(239, bigint);
    }

    public static void M20e57f32(long[] jArr, long[] jArr2) {
        if ((14 + 2) % 2 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m69c6e24b(jArr)) {
            throw new java.lang.IllegalStateException();
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m4c1a88a3();
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
        m2fc01ec7(jArrM4c1a88a32, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a32, jArr, jArrM4c1a88a32);
        m96dc2752(jArrM4c1a88a32, 29, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m2fc01ec7(jArrM4c1a88a3, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArr, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 59, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a32, jArrM4c1a88a3, jArrM4c1a88a32);
        m2fc01ec7(jArrM4c1a88a32, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a32, jArr, jArrM4c1a88a32);
        m96dc2752(jArrM4c1a88a32, 119, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m2fc01ec7(jArrM4c1a88a3, jArr2);
    }

    public static void M2fc01ec7(long[] jArr, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
        m69bc711f(jArr, jArrMf03001e5);
        ma6d0c789(jArrMf03001e5, jArr2);
    }

    public static void M34ec78fc(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((21 + 11) % 11 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr[1] ^ jArr2[1];
        jArr3[2] = jArr[2] ^ jArr2[2];
        jArr3[3] = jArr2[3] ^ jArr[3];
    }

    protected static void M5ef85820(long[] jArr) {
        if ((31 + 32) % 32 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = jArr[4];
        long j6 = jArr[5];
        long j7 = jArr[6];
        long j8 = jArr[7];
        jArr[0] = j ^ (j2 << 60);
        jArr[1] = (j2 >>> 4) ^ (j3 << 56);
        jArr[2] = (j3 >>> 8) ^ (j4 << 52);
        jArr[3] = (j4 >>> 12) ^ (j5 << 48);
        jArr[4] = (j5 >>> 16) ^ (j6 << 44);
        jArr[5] = (j6 >>> 20) ^ (j7 << 40);
        jArr[6] = (j7 >>> 24) ^ (j8 << 36);
        jArr[7] = j8 >>> 28;
    }

    protected static void M69bc711f(long[] jArr, long[] jArr2) {
        if ((18 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m5c74a737(jArr, 0, 4, jArr2, 0);
    }

    public static void M8a077337(long[] jArr, int i) {
        if ((14 + 16) % 16 > 0) {
        }
        int i2 = i + 3;
        long j = jArr[i2];
        long j2 = j >>> 47;
        jArr[i] = jArr[i] ^ j2;
        int i3 = i + 2;
        jArr[i3] = (j2 << 30) ^ jArr[i3];
        jArr[i2] = j & 140737488355327L;
    }

    public static void M8ae6f599(long[] jArr, long[] jArr2) {
        if ((14 + 24) % 24 > 0) {
        }
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m0246eff8(jArr, jArr2);
        for (int i = 1; i < 239; i += 2) {
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
        if ((9 + 6) % 6 > 0) {
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
        if ((13 + 25) % 25 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = jArr[4];
        long j6 = jArr[5];
        long j7 = jArr[6];
        long j8 = jArr[7];
        long j9 = j7 ^ (j8 >>> 17);
        long j10 = (j6 ^ (j8 << 47)) ^ (j9 >>> 17);
        long j11 = ((j5 ^ (j8 >>> 47)) ^ (j9 << 47)) ^ (j10 >>> 17);
        long j12 = j ^ (j11 << 17);
        long j13 = (j2 ^ (j10 << 17)) ^ (j11 >>> 47);
        long j14 = ((j3 ^ (j9 << 17)) ^ (j10 >>> 47)) ^ (j11 << 47);
        long j15 = (((j4 ^ (j8 << 17)) ^ (j9 >>> 47)) ^ (j10 << 47)) ^ (j11 >>> 17);
        long j16 = j15 >>> 47;
        jArr2[0] = j12 ^ j16;
        jArr2[1] = j13;
        jArr2[2] = (j16 << 30) ^ j14;
        jArr2[3] = 140737488355327L & j15;
    }

    public static void Maf110662(long[] jArr, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
        m69bc711f(jArr, jArrMf03001e5);
        m0408d798(jArr2, jArrMf03001e5, jArr2);
    }

    protected static void Mb3331dc1(long[] jArr, long j, long j2, long[] jArr2, int i) {
        if ((4 + 22) % 22 > 0) {
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
        int i3 = 54;
        do {
            int i4 = (int) (j >>> i3);
            long j9 = jArr[i4 & 7] ^ (jArr[(i4 >>> 3) & 7] << 3);
            j7 ^= j9 << i3;
            j8 ^= j9 >>> (-i3);
            i3 -= 6;
        } while (i3 > 0);
        long j10 = (((j & 585610922974906400L) & ((j2 << 4) >> 63)) >>> 5) ^ j8;
        jArr2[i] = jArr2[i] ^ (1152921504606846975L & j7);
        int i5 = i + 1;
        jArr2[i5] = ((j10 << 4) ^ (j7 >>> 60)) ^ jArr2[i5];
    }

    protected static void Mc8577af9(long[] jArr, long[] jArr2) {
        if ((2 + 29) % 29 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        jArr2[0] = j & 1152921504606846975L;
        jArr2[1] = ((j >>> 60) ^ (j2 << 4)) & 1152921504606846975L;
        jArr2[2] = ((j2 >>> 56) ^ (j3 << 8)) & 1152921504606846975L;
        jArr2[3] = (j3 >>> 52) ^ (j4 << 12);
    }

    private static void Mcfef9de9(long[] jArr, long[] jArr2) {
        if ((24 + 15) % 15 > 0) {
        }
        jArr2[0] = jArr2[0] ^ jArr[0];
        jArr2[1] = jArr2[1] ^ jArr[1];
        jArr2[2] = jArr2[2] ^ jArr[2];
        jArr2[3] = jArr2[3] ^ jArr[3];
    }

    public static void Mdd1de98e(long[] jArr, long[] jArr2) {
        if ((11 + 2) % 2 > 0) {
        }
        long jM8bf8513d = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[0]);
        long jM8bf8513d2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[1]);
        long j = (jM8bf8513d & 4294967295L) | (jM8bf8513d2 << 32);
        long j2 = (jM8bf8513d >>> 32) | (jM8bf8513d2 & (-4294967296L));
        int i = 2;
        long jM8bf8513d3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[2]);
        long jM8bf8513d4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[3]);
        long j3 = (jM8bf8513d3 & 4294967295L) | (jM8bf8513d4 << 32);
        long j4 = (jM8bf8513d4 & (-4294967296L)) | (jM8bf8513d3 >>> 32);
        long j5 = j4 >>> 49;
        long j6 = (j2 >>> 49) | (j4 << 15);
        long j7 = j4 ^ (j2 << 15);
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
        int[] iArr = {39, 120};
        int i2 = 0;
        while (i2 < i) {
            int i3 = iArr[i2];
            int i4 = i3 >>> 6;
            int i5 = i3 & 63;
            jArrMf03001e5[i4] = jArrMf03001e5[i4] ^ (j2 << i5);
            int i6 = i4 + 1;
            int[] iArr2 = iArr;
            int i7 = -i5;
            jArrMf03001e5[i6] = jArrMf03001e5[i6] ^ ((j7 << i5) | (j2 >>> i7));
            int i8 = i4 + 2;
            jArrMf03001e5[i8] = jArrMf03001e5[i8] ^ ((j6 << i5) | (j7 >>> i7));
            int i9 = i4 + 3;
            jArrMf03001e5[i9] = jArrMf03001e5[i9] ^ ((j5 << i5) | (j6 >>> i7));
            int i10 = i4 + 4;
            jArrMf03001e5[i10] = jArrMf03001e5[i10] ^ (j5 >>> i7);
            i2++;
            i = 2;
            iArr = iArr2;
        }
        ma6d0c789(jArrMf03001e5, jArr2);
        jArr2[0] = jArr2[0] ^ j;
        jArr2[1] = jArr2[1] ^ j3;
    }

    public static void Mde883c68(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mf03001e5();
        m9fd70504(jArr, jArr2, jArrMf03001e5);
        m0408d798(jArr3, jArrMf03001e5, jArr3);
    }

    public static void Mfbf72fda(long[] jArr, long[] jArr2) {
        if ((11 + 2) % 2 > 0) {
        }
        jArr2[0] = jArr[0] ^ 1;
        jArr2[1] = jArr[1];
        jArr2[2] = jArr[2];
        jArr2[3] = jArr[3];
    }
}

