namespace WillowMaze.Wasm.Decompiled;


public class p7da5d7d9 {
    private static readonly long f06c9d7c6 = 576460752303423487L;
    private static readonly long[] f53d11d60 = {3161836309350906777L, -7642453882179322845L, -3821226941089661423L, 7312758566309945096L, -556661012383879292L, 8945041530681231562L, -4750851271514160027L, 6847946401097695794L, 541669439031730457L};
    private static readonly long[] f6babb760 = null;
    private static readonly long fdd6b9e95 = 576460752303423487L;
    private static readonly long fe9ba7273 = 576460752303423487L;
    private static readonly long ff4999c6a = 576460752303423487L;

    public static void M0408d798(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((29 + 6) % 6 > 0) {
        }
        for (int i = 0; i < 18; i++) {
            jArr3[i] = jArr[i] ^ jArr2[i];
        }
    }

    public static int M04a75036(long[] jArr) {
        if ((29 + 26) % 26 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[8];
        return ((int) ((j ^ (j2 >>> 49)) ^ (j2 >>> 57))) & 1;
    }

    public static void M0fbe41b5(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.mf03001e5();
        m9fd70504(jArr, jArr2, jArrMf03001e5);
        ma6d0c789(jArrMf03001e5, jArr3);
    }

    public static long[] M1712f3b8(java.math.Bigint bigint) {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m0cb1c33d(571, bigint);
    }

    public static void M20e57f32(long[] jArr, long[] jArr2) {
        if ((16 + 23) % 23 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m69c6e24b(jArr)) {
            throw new java.lang.IllegalStateException();
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m4c1a88a3();
        long[] jArrM4c1a88a33 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m4c1a88a3();
        m2fc01ec7(jArr, jArrM4c1a88a33);
        m2fc01ec7(jArrM4c1a88a33, jArrM4c1a88a3);
        m2fc01ec7(jArrM4c1a88a3, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 2, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a33, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 5, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a32, 5, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 15, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a33);
        m96dc2752(jArrM4c1a88a33, 30, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 30, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 60, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a32, 60, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 180, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a32, 180, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a33, jArr2);
    }

    public static void M2fc01ec7(long[] jArr, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.mf03001e5();
        m69bc711f(jArr, jArrMf03001e5);
        ma6d0c789(jArrMf03001e5, jArr2);
    }

    private static void M34ec78fc(long[] jArr, int i, long[] jArr2, int i2, long[] jArr3, int i3) {
        if ((10 + 9) % 9 > 0) {
        }
        for (int i4 = 0; i4 < 9; i4++) {
            jArr3[i3 + i4] = jArr[i + i4] ^ jArr2[i2 + i4];
        }
    }

    public static void M34ec78fc(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((4 + 22) % 22 > 0) {
        }
        for (int i = 0; i < 9; i++) {
            jArr3[i] = jArr[i] ^ jArr2[i];
        }
    }

    protected static void M35b22c7a(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((22 + 16) % 16 > 0) {
        }
        for (int i = 56; i >= 0; i -= 8) {
            for (int i2 = 1; i2 < 9; i2 += 2) {
                int i3 = (int) (jArr[i2] >>> i);
                m80debbb5(jArr2, (i3 & 15) * 9, jArr2, (((i3 >>> 4) & 15) + 16) * 9, jArr3, i2 - 1);
            }
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m0e776ce6(16, jArr3, 0, 8, 0L);
        }
        for (int i4 = 56; i4 >= 0; i4 -= 8) {
            int i5 = 0;
            while (i5 < 9) {
                int i6 = (int) (jArr[i5] >>> i4);
                int i7 = i5;
                m80debbb5(jArr2, (i6 & 15) * 9, jArr2, (((i6 >>> 4) & 15) + 16) * 9, jArr3, i7);
                i5 = i7 + 2;
            }
            if (i4 > 0) {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m0e776ce6(18, jArr3, 0, 8, 0L);
            }
        }
    }

    public static void M393068b0(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.mf03001e5();
        m35b22c7a(jArr, jArr2, jArrMf03001e5);
        m0408d798(jArr3, jArrMf03001e5, jArr3);
    }

    public static void M50c6d843(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.mf03001e5();
        m35b22c7a(jArr, jArr2, jArrMf03001e5);
        ma6d0c789(jArrMf03001e5, jArr3);
    }

    public static long[] M5307ac7c(long[] jArr) {
        if ((1 + 14) % 14 > 0) {
        }
        long[] jArr2 = new long[288];
        java.lang.System.arraycopy(jArr, 0, jArr2, 9, 9);
        int i = 7;
        int i2 = 0;
        while (i > 0) {
            int i3 = i2 + 18;
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mf610c3b4(9, jArr2, i3 >>> 1, 0L, jArr2, i3);
            m780d22cd(jArr2, i3);
            long[] jArr3 = jArr2;
            m34ec78fc(jArr3, 9, jArr3, i3, jArr3, i2 + 27);
            jArr2 = jArr3;
            i--;
            i2 = i3;
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m0e776ce6(144, jArr2, 0, 4, 0L, jArr2, 144);
        return jArr2;
    }

    protected static void M69bc711f(long[] jArr, long[] jArr2) {
        if ((22 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m5c74a737(jArr, 0, 9, jArr2, 0);
    }

    public static void M780d22cd(long[] jArr, int i) {
        if ((8 + 11) % 11 > 0) {
        }
        int i2 = i + 8;
        long j = jArr[i2];
        long j2 = j >>> 59;
        jArr[i] = ((j2 << 10) ^ (((j2 << 2) ^ j2) ^ (j2 << 5))) ^ jArr[i];
        jArr[i2] = j & 576460752303423487L;
    }

    private static void M80debbb5(long[] jArr, int i, long[] jArr2, int i2, long[] jArr3, int i3) {
        if ((18 + 6) % 6 > 0) {
        }
        for (int i4 = 0; i4 < 9; i4++) {
            int i5 = i3 + i4;
            jArr3[i5] = jArr3[i5] ^ (jArr[i + i4] ^ jArr2[i2 + i4]);
        }
    }

    public static void M80debbb5(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((6 + 28) % 28 > 0) {
        }
        for (int i = 0; i < 9; i++) {
            jArr3[i] = jArr3[i] ^ (jArr[i] ^ jArr2[i]);
        }
    }

    public static void M8ae6f599(long[] jArr, long[] jArr2) {
        if ((29 + 18) % 18 > 0) {
        }
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.mf03001e5();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m0246eff8(jArr, jArr2);
        for (int i = 1; i < 571; i += 2) {
            m69bc711f(jArr2, jArrMf03001e5);
            ma6d0c789(jArrMf03001e5, jArr2);
            m69bc711f(jArr2, jArrMf03001e5);
            ma6d0c789(jArrMf03001e5, jArr2);
            mcfef9de9(jArr, jArr2);
        }
    }

    public static void M96dc2752(long[] jArr, int i, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.mf03001e5();
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
        if ((13 + 14) % 14 > 0) {
        }
        long[] jArr4 = new long[16];
        for (int i = 0; i < 9; i++) {
            mb3331dc1(jArr4, jArr[i], jArr2[i], jArr3, i << 1);
        }
        long j = jArr3[0];
        long j2 = jArr3[1];
        long j3 = jArr3[2] ^ j;
        long j4 = j3 ^ j2;
        jArr3[1] = j4;
        long j5 = j2 ^ jArr3[3];
        long j6 = j3 ^ jArr3[4];
        long j7 = j6 ^ j5;
        jArr3[2] = j7;
        long j8 = j5 ^ jArr3[5];
        long j9 = j6 ^ jArr3[6];
        long j10 = j9 ^ j8;
        jArr3[3] = j10;
        long j11 = j8 ^ jArr3[7];
        long j12 = j9 ^ jArr3[8];
        long j13 = j12 ^ j11;
        jArr3[4] = j13;
        long j14 = j11 ^ jArr3[9];
        long j15 = j12 ^ jArr3[10];
        long j16 = j15 ^ j14;
        jArr3[5] = j16;
        long j17 = j14 ^ jArr3[11];
        long j18 = j15 ^ jArr3[12];
        long j19 = j18 ^ j17;
        jArr3[6] = j19;
        long j20 = j17 ^ jArr3[13];
        long j21 = j18 ^ jArr3[14];
        long j22 = j21 ^ j20;
        jArr3[7] = j22;
        long j23 = j20 ^ jArr3[15];
        long j24 = j21 ^ jArr3[16];
        long j25 = j24 ^ j23;
        jArr3[8] = j25;
        long j26 = (j23 ^ jArr3[17]) ^ j24;
        jArr3[9] = j ^ j26;
        jArr3[10] = j4 ^ j26;
        jArr3[11] = j7 ^ j26;
        jArr3[12] = j10 ^ j26;
        jArr3[13] = j13 ^ j26;
        jArr3[14] = j16 ^ j26;
        jArr3[15] = j19 ^ j26;
        jArr3[16] = j22 ^ j26;
        jArr3[17] = j25 ^ j26;
        mb3331dc1(jArr4, jArr[0] ^ jArr[1], jArr2[0] ^ jArr2[1], jArr3, 1);
        mb3331dc1(jArr4, jArr[0] ^ jArr[2], jArr2[0] ^ jArr2[2], jArr3, 2);
        mb3331dc1(jArr4, jArr[0] ^ jArr[3], jArr2[0] ^ jArr2[3], jArr3, 3);
        mb3331dc1(jArr4, jArr[1] ^ jArr[2], jArr2[1] ^ jArr2[2], jArr3, 3);
        mb3331dc1(jArr4, jArr[0] ^ jArr[4], jArr2[0] ^ jArr2[4], jArr3, 4);
        mb3331dc1(jArr4, jArr[1] ^ jArr[3], jArr2[1] ^ jArr2[3], jArr3, 4);
        mb3331dc1(jArr4, jArr[0] ^ jArr[5], jArr2[0] ^ jArr2[5], jArr3, 5);
        mb3331dc1(jArr4, jArr[1] ^ jArr[4], jArr2[1] ^ jArr2[4], jArr3, 5);
        mb3331dc1(jArr4, jArr[2] ^ jArr[3], jArr2[2] ^ jArr2[3], jArr3, 5);
        mb3331dc1(jArr4, jArr[0] ^ jArr[6], jArr2[0] ^ jArr2[6], jArr3, 6);
        mb3331dc1(jArr4, jArr[1] ^ jArr[5], jArr2[1] ^ jArr2[5], jArr3, 6);
        mb3331dc1(jArr4, jArr[2] ^ jArr[4], jArr2[2] ^ jArr2[4], jArr3, 6);
        mb3331dc1(jArr4, jArr[0] ^ jArr[7], jArr2[0] ^ jArr2[7], jArr3, 7);
        mb3331dc1(jArr4, jArr[1] ^ jArr[6], jArr2[1] ^ jArr2[6], jArr3, 7);
        mb3331dc1(jArr4, jArr[2] ^ jArr[5], jArr2[2] ^ jArr2[5], jArr3, 7);
        mb3331dc1(jArr4, jArr[3] ^ jArr[4], jArr2[3] ^ jArr2[4], jArr3, 7);
        mb3331dc1(jArr4, jArr[0] ^ jArr[8], jArr2[0] ^ jArr2[8], jArr3, 8);
        mb3331dc1(jArr4, jArr[1] ^ jArr[7], jArr2[1] ^ jArr2[7], jArr3, 8);
        mb3331dc1(jArr4, jArr[2] ^ jArr[6], jArr2[2] ^ jArr2[6], jArr3, 8);
        mb3331dc1(jArr4, jArr[3] ^ jArr[5], jArr2[3] ^ jArr2[5], jArr3, 8);
        mb3331dc1(jArr4, jArr[1] ^ jArr[8], jArr2[1] ^ jArr2[8], jArr3, 9);
        mb3331dc1(jArr4, jArr[2] ^ jArr[7], jArr2[2] ^ jArr2[7], jArr3, 9);
        mb3331dc1(jArr4, jArr[3] ^ jArr[6], jArr2[3] ^ jArr2[6], jArr3, 9);
        mb3331dc1(jArr4, jArr[4] ^ jArr[5], jArr2[4] ^ jArr2[5], jArr3, 9);
        mb3331dc1(jArr4, jArr[2] ^ jArr[8], jArr2[2] ^ jArr2[8], jArr3, 10);
        mb3331dc1(jArr4, jArr[3] ^ jArr[7], jArr2[3] ^ jArr2[7], jArr3, 10);
        mb3331dc1(jArr4, jArr[4] ^ jArr[6], jArr2[4] ^ jArr2[6], jArr3, 10);
        mb3331dc1(jArr4, jArr[3] ^ jArr[8], jArr2[3] ^ jArr2[8], jArr3, 11);
        mb3331dc1(jArr4, jArr[4] ^ jArr[7], jArr2[4] ^ jArr2[7], jArr3, 11);
        mb3331dc1(jArr4, jArr[5] ^ jArr[6], jArr2[5] ^ jArr2[6], jArr3, 11);
        mb3331dc1(jArr4, jArr[4] ^ jArr[8], jArr2[4] ^ jArr2[8], jArr3, 12);
        mb3331dc1(jArr4, jArr[5] ^ jArr[7], jArr2[5] ^ jArr2[7], jArr3, 12);
        mb3331dc1(jArr4, jArr[5] ^ jArr[8], jArr2[5] ^ jArr2[8], jArr3, 13);
        mb3331dc1(jArr4, jArr[6] ^ jArr[7], jArr2[6] ^ jArr2[7], jArr3, 13);
        mb3331dc1(jArr4, jArr[6] ^ jArr[8], jArr2[6] ^ jArr2[8], jArr3, 14);
        mb3331dc1(jArr4, jArr[7] ^ jArr[8], jArr2[7] ^ jArr2[8], jArr3, 15);
    }

    public static void Ma6d0c789(long[] jArr, long[] jArr2) {
        if ((31 + 11) % 11 > 0) {
        }
        long j = jArr[9];
        long j2 = jArr[17];
        long j3 = (((j ^ (j2 >>> 59)) ^ (j2 >>> 57)) ^ (j2 >>> 54)) ^ (j2 >>> 49);
        long j4 = (j2 << 15) ^ (((jArr[8] ^ (j2 << 5)) ^ (j2 << 7)) ^ (j2 << 10));
        for (int i = 16; i >= 10; i--) {
            long j5 = jArr[i];
            jArr2[i - 8] = (((j4 ^ (j5 >>> 59)) ^ (j5 >>> 57)) ^ (j5 >>> 54)) ^ (j5 >>> 49);
            j4 = (((jArr[i - 9] ^ (j5 << 5)) ^ (j5 << 7)) ^ (j5 << 10)) ^ (j5 << 15);
        }
        jArr2[1] = (((j4 ^ (j3 >>> 59)) ^ (j3 >>> 57)) ^ (j3 >>> 54)) ^ (j3 >>> 49);
        long j6 = (j3 << 15) ^ (((jArr[0] ^ (j3 << 5)) ^ (j3 << 7)) ^ (j3 << 10));
        long j7 = jArr2[8];
        long j8 = j7 >>> 59;
        jArr2[0] = (((j6 ^ j8) ^ (j8 << 2)) ^ (j8 << 5)) ^ (j8 << 10);
        jArr2[8] = 576460752303423487L & j7;
    }

    public static void Maf110662(long[] jArr, long[] jArr2) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.mf03001e5();
        m69bc711f(jArr, jArrMf03001e5);
        m0408d798(jArr2, jArrMf03001e5, jArr2);
    }

    protected static void Mb3331dc1(long[] jArr, long j, long j2, long[] jArr2, int i) {
        if ((28 + 24) % 24 > 0) {
        }
        long j3 = j;
        jArr[1] = j2;
        for (int i2 = 2; i2 < 16; i2 += 2) {
            long j4 = jArr[i2 >>> 1] << 1;
            jArr[i2] = j4;
            jArr[i2 + 1] = j4 ^ j2;
        }
        int i3 = (int) j3;
        long j5 = jArr[i3 & 15] ^ (jArr[(i3 >>> 4) & 15] << 4);
        long j6 = 0;
        int i4 = 56;
        do {
            int i5 = (int) (j3 >>> i4);
            long j7 = jArr[i5 & 15] ^ (jArr[(i5 >>> 4) & 15] << 4);
            j5 ^= j7 << i4;
            j6 ^= j7 >>> (-i4);
            i4 -= 8;
        } while (i4 > 0);
        for (int i6 = 0; i6 < 7; i6++) {
            j3 = (j3 & (-72340172838076674L)) >>> 1;
            j6 ^= ((j2 << i6) >> 63) & j3;
        }
        jArr2[i] = jArr2[i] ^ j5;
        int i7 = i + 1;
        jArr2[i7] = jArr2[i7] ^ j6;
    }

    private static void Mcfef9de9(long[] jArr, long[] jArr2) {
        if ((32 + 24) % 24 > 0) {
        }
        for (int i = 0; i < 9; i++) {
            jArr2[i] = jArr2[i] ^ jArr[i];
        }
    }

    public static void Mdd1de98e(long[] jArr, long[] jArr2) {
        if ((26 + 14) % 14 > 0) {
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m4c1a88a3();
        int i = 0;
        for (int i2 = 0; i2 < 4; i2++) {
            int i3 = i + 1;
            long jM8bf8513d = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[i]);
            i += 2;
            long jM8bf8513d2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[i3]);
            jArrM4c1a88a3[i2] = (4294967295L & jM8bf8513d) | (jM8bf8513d2 << 32);
            jArrM4c1a88a32[i2] = (jM8bf8513d >>> 32) | ((-4294967296L) & jM8bf8513d2);
        }
        long jM8bf8513d3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m8bf8513d(jArr[i]);
        jArrM4c1a88a3[4] = 4294967295L & jM8bf8513d3;
        jArrM4c1a88a32[4] = jM8bf8513d3 >>> 32;
        m0fbe41b5(jArrM4c1a88a32, f53d11d60, jArr2);
        m34ec78fc(jArr2, jArrM4c1a88a3, jArr2);
    }

    public static void Mde883c68(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.mf03001e5();
        m9fd70504(jArr, jArr2, jArrMf03001e5);
        m0408d798(jArr3, jArrMf03001e5, jArr3);
    }

    public static void Mfbf72fda(long[] jArr, long[] jArr2) {
        if ((6 + 19) % 19 > 0) {
        }
        jArr2[0] = jArr[0] ^ 1;
        for (int i = 1; i < 9; i++) {
            jArr2[i] = jArr[i];
        }
    }
}

