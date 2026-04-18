namespace WillowMaze.Wasm.Decompiled;


public class p1ff7387e {
    private static readonly long f0729b1a3 = 17592186044415L;
    private static readonly long[] f11f86680 = null;
    private static readonly long f3a9a2f66 = 17592186044415L;
    private static readonly long f40f145d9 = 7;
    private static readonly long f4ece5ec3 = 7;
    private static readonly long f50238a30 = 17592186044415L;
    private static readonly long[] f53d11d60 = {2791191049453778211L, 2791191049453778402L, 6};
    private static readonly long f5ad2fd35 = 7;
    private static readonly long f894db348 = 17592186044415L;
    private static readonly long fa33e3091 = 7;

    public static void M0408d798(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((14 + 25) % 25 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr[1] ^ jArr2[1];
        jArr3[2] = jArr[2] ^ jArr2[2];
        jArr3[3] = jArr[3] ^ jArr2[3];
        jArr3[4] = jArr2[4] ^ jArr[4];
    }

    public static int M04a75036(long[] jArr) {
        if ((27 + 32) % 32 > 0) {
        }
        return ((int) ((jArr[0] ^ (jArr[1] >>> 59)) ^ (jArr[2] >>> 1))) & 1;
    }

    public static void M0fbe41b5(long[] jArr, long[] jArr2, long[] jArr3) {
        long[] jArr4 = new long[8];
        m9fd70504(jArr, jArr2, jArr4);
        ma6d0c789(jArr4, jArr3);
    }

    public static long[] M1712f3b8(java.math.Bigint bigint) {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m0cb1c33d(131, bigint);
    }

    public static void M20e57f32(long[] jArr, long[] jArr2) {
        if ((3 + 24) % 24 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m69c6e24b(jArr)) {
            throw new java.lang.IllegalStateException();
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m4c1a88a3();
        m2fc01ec7(jArr, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArr, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 2, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a32, jArrM4c1a88a3, jArrM4c1a88a32);
        m96dc2752(jArrM4c1a88a32, 4, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 8, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a32, jArrM4c1a88a3, jArrM4c1a88a32);
        m96dc2752(jArrM4c1a88a32, 16, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m96dc2752(jArrM4c1a88a3, 32, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a32, jArrM4c1a88a3, jArrM4c1a88a32);
        m2fc01ec7(jArrM4c1a88a32, jArrM4c1a88a32);
        m0fbe41b5(jArrM4c1a88a32, jArr, jArrM4c1a88a32);
        m96dc2752(jArrM4c1a88a32, 65, jArrM4c1a88a3);
        m0fbe41b5(jArrM4c1a88a3, jArrM4c1a88a32, jArrM4c1a88a3);
        m2fc01ec7(jArrM4c1a88a3, jArr2);
    }

    public static void M2fc01ec7(long[] jArr, long[] jArr2) {
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m4c1a88a3(5);
        m69bc711f(jArr, jArrM4c1a88a3);
        ma6d0c789(jArrM4c1a88a3, jArr2);
    }

    public static void M34ec78fc(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((17 + 5) % 5 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr[1] ^ jArr2[1];
        jArr3[2] = jArr2[2] ^ jArr[2];
    }

    public static void M5c7bf3f5(long[] jArr, int i) {
        if ((25 + 28) % 28 > 0) {
        }
        int i2 = i + 2;
        long j = jArr[i2];
        long j2 = j >>> 3;
        jArr[i] = ((j2 << 8) ^ (((j2 << 2) ^ j2) ^ (j2 << 3))) ^ jArr[i];
        int i3 = i + 1;
        jArr[i3] = jArr[i3] ^ (j >>> 59);
        jArr[i2] = j & 7;
    }

    protected static void M5ef85820(long[] jArr) {
        if ((13 + 2) % 2 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = jArr[4];
        long j6 = jArr[5];
        jArr[0] = j ^ (j2 << 44);
        jArr[1] = (j2 >>> 20) ^ (j3 << 24);
        jArr[2] = ((j3 >>> 40) ^ (j4 << 4)) ^ (j5 << 48);
        jArr[3] = ((j4 >>> 60) ^ (j6 << 28)) ^ (j5 >>> 16);
        jArr[4] = j6 >>> 36;
        jArr[5] = 0;
    }

    protected static void M69bc711f(long[] jArr, long[] jArr2) {
        if ((14 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m5c74a737(jArr, 0, 2, jArr2, 0);
        jArr2[4] = ((long) p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.ma1fa0ef9((int) jArr[2])) & 4294967295L;
    }

    protected static void M756d7d40(long[] jArr, long j, long j2, long[] jArr2, int i) {
        if ((23 + 7) % 7 > 0) {
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
        long j7 = (((jArr[i2 & 7] ^ (jArr[(i2 >>> 3) & 7] << 3)) ^ (jArr[(i2 >>> 6) & 7] << 6)) ^ (jArr[(i2 >>> 9) & 7] << 9)) ^ (jArr[(i2 >>> 12) & 7] << 12);
        long j8 = 0;
        int i3 = 30;
        do {
            int i4 = (int) (j >>> i3);
            long j9 = (((jArr[i4 & 7] ^ (jArr[(i4 >>> 3) & 7] << 3)) ^ (jArr[(i4 >>> 6) & 7] << 6)) ^ (jArr[(i4 >>> 9) & 7] << 9)) ^ (jArr[(i4 >>> 12) & 7] << 12);
            j7 ^= j9 << i3;
            j8 ^= j9 >>> (-i3);
            i3 -= 15;
        } while (i3 > 0);
        jArr2[i] = 17592186044415L & j7;
        jArr2[i + 1] = (j7 >>> 44) ^ (j8 << 20);
    }

    public static void M8ae6f599(long[] jArr, long[] jArr2) {
        if ((25 + 6) % 6 > 0) {
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m4c1a88a3(5);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m0246eff8(jArr, jArr2);
        for (int i = 1; i < 131; i += 2) {
            m69bc711f(jArr2, jArrM4c1a88a3);
            ma6d0c789(jArrM4c1a88a3, jArr2);
            m69bc711f(jArr2, jArrM4c1a88a3);
            ma6d0c789(jArrM4c1a88a3, jArr2);
            mcfef9de9(jArr, jArr2);
        }
    }

    public static void M96dc2752(long[] jArr, int i, long[] jArr2) {
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m4c1a88a3(5);
        m69bc711f(jArr, jArrM4c1a88a3);
        while (true) {
            ma6d0c789(jArrM4c1a88a3, jArr2);
            i--;
            if (i <= 0) {
                return;
            } else {
                m69bc711f(jArr2, jArrM4c1a88a3);
            }
        }
    }

    protected static void M9fd70504(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((28 + 24) % 24 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = ((jArr[2] << 40) ^ (j2 >>> 24)) & 17592186044415L;
        long j4 = ((j >>> 44) ^ (j2 << 20)) & 17592186044415L;
        long j5 = j & 17592186044415L;
        long j6 = jArr2[0];
        long j7 = jArr2[1];
        long j8 = ((j7 >>> 24) ^ (jArr2[2] << 40)) & 17592186044415L;
        long j9 = ((j6 >>> 44) ^ (j7 << 20)) & 17592186044415L;
        long j10 = j6 & 17592186044415L;
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
        long j30 = ((j28 ^ (j29 << 4)) ^ (j29 << 1)) ^ (j27 >>> 44);
        long j31 = (j24 ^ j18) ^ (j30 >>> 44);
        long j32 = ((j27 & 17592186044415L) >>> 1) ^ ((j30 & 1) << 43);
        long j33 = j32 ^ (j32 << 1);
        long j34 = j33 ^ (j33 << 2);
        long j35 = j34 ^ (j34 << 4);
        long j36 = j35 ^ (j35 << 8);
        long j37 = j36 ^ (j36 << 16);
        long j38 = (j37 ^ (j37 << 32)) & 17592186044415L;
        long j39 = (((j30 & 17592186044415L) >>> 1) ^ ((j31 & 1) << 43)) ^ (j38 >>> 43);
        long j40 = j39 ^ (j39 << 1);
        long j41 = j40 ^ (j40 << 2);
        long j42 = j41 ^ (j41 << 4);
        long j43 = j42 ^ (j42 << 8);
        long j44 = j43 ^ (j43 << 16);
        long j45 = (j44 ^ (j44 << 32)) & 17592186044415L;
        long j46 = (j45 >>> 43) ^ (j31 >>> 1);
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
        if ((32 + 9) % 9 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = jArr[4];
        long j6 = j4 ^ (j5 >>> 59);
        long j7 = j ^ ((j6 << 61) ^ (j6 << 63));
        long j8 = (j2 ^ ((j5 << 61) ^ (j5 << 63))) ^ ((((j6 >>> 3) ^ (j6 >>> 1)) ^ j6) ^ (j6 << 5));
        long j9 = (j3 ^ ((((j5 >>> 3) ^ (j5 >>> 1)) ^ j5) ^ (j5 << 5))) ^ (j6 >>> 59);
        long j10 = j9 >>> 3;
        jArr2[0] = (((j7 ^ j10) ^ (j10 << 2)) ^ (j10 << 3)) ^ (j10 << 8);
        jArr2[1] = (j9 >>> 59) ^ j8;
        jArr2[2] = 7 & j9;
    }

    public static void Maf110662(long[] jArr, long[] jArr2) {
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m4c1a88a3(5);
        m69bc711f(jArr, jArrM4c1a88a3);
        m0408d798(jArr2, jArrM4c1a88a3, jArr2);
    }

    private static void Mcfef9de9(long[] jArr, long[] jArr2) {
        if ((19 + 14) % 14 > 0) {
        }
        jArr2[0] = jArr2[0] ^ jArr[0];
        jArr2[1] = jArr2[1] ^ jArr[1];
        jArr2[2] = jArr2[2] ^ jArr[2];
    }

    public static void Mdd1de98e(long[] jArr, long[] jArr2) {
        if ((4 + 19) % 19 > 0) {
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
        if ((1 + 31) % 31 > 0) {
        }
        jArr2[0] = jArr[0] ^ 1;
        jArr2[1] = jArr[1];
        jArr2[2] = jArr[2];
    }
}

