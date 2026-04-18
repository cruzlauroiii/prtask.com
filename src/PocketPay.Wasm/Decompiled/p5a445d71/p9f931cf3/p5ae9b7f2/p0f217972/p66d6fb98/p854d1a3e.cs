namespace WillowMaze.Wasm.Decompiled;


public class p854d1a3e {
    public static readonly int f61d76a06 = 8;
    public static readonly int f62e5cef8 = 8;
    public static readonly int f8f18381e = 8;

    public static void M0fbe41b5(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((9 + 16) % 16 > 0) {
        }
        int i = 0;
        long j = jArr2[0];
        char c = 1;
        long j2 = jArr2[1];
        char c2 = 2;
        long j3 = jArr2[2];
        char c3 = 3;
        long j4 = jArr2[3];
        long j5 = jArr2[4];
        long j6 = jArr2[5];
        long j7 = jArr2[6];
        long j8 = jArr2[7];
        long j9 = 0;
        long j10 = 0;
        long j11 = 0;
        long j12 = 0;
        long j13 = 0;
        long j14 = 0;
        long j15 = 0;
        long j16 = 0;
        long j17 = 0;
        while (true) {
            char c4 = c;
            if (i >= 8) {
                char c5 = c2;
                char c6 = c3;
                long j18 = j11 ^ (((j10 >>> 62) ^ (j10 >>> 59)) ^ (j10 >>> 56));
                jArr3[0] = j9 ^ (((j10 ^ (j10 << c5)) ^ (j10 << 5)) ^ (j10 << 8));
                jArr3[c4] = j18;
                jArr3[c5] = j12;
                jArr3[c6] = j13;
                jArr3[4] = j14;
                jArr3[5] = j15;
                jArr3[6] = j16;
                jArr3[7] = j17;
                return;
            }
            long j19 = jArr[i];
            long j20 = jArr[i + 1];
            long j21 = j3;
            long j22 = j2;
            long j23 = j7;
            j7 = j6;
            j6 = j5;
            j5 = j4;
            long j24 = j21;
            char c7 = c2;
            int i2 = 0;
            while (i2 < 64) {
                char c8 = c3;
                long j25 = j24;
                long j26 = -(j19 & 1);
                j19 >>>= c4;
                j9 ^= j & j26;
                long j27 = j22;
                long j28 = -(j20 & 1);
                j20 >>>= c4;
                j11 = (j11 ^ (j22 & j26)) ^ (j & j28);
                j12 = (j12 ^ (j25 & j26)) ^ (j27 & j28);
                j13 = (j13 ^ (j5 & j26)) ^ (j25 & j28);
                j14 = (j14 ^ (j6 & j26)) ^ (j5 & j28);
                j15 = (j15 ^ (j7 & j26)) ^ (j6 & j28);
                j16 = (j16 ^ (j23 & j26)) ^ (j7 & j28);
                j17 = (j17 ^ (j8 & j26)) ^ (j23 & j28);
                j10 ^= j8 & j28;
                long j29 = j8 >> 63;
                j8 = (j8 << c4) | (j23 >>> 63);
                j23 = (j23 << c4) | (j7 >>> 63);
                j7 = (j7 << c4) | (j6 >>> 63);
                j6 = (j6 << c4) | (j5 >>> 63);
                j5 = (j5 << c4) | (j25 >>> 63);
                long j30 = (j27 << c4) | (j >>> 63);
                j = (j << c4) ^ (j29 & 293);
                i2++;
                c3 = c8;
                j24 = (j25 << c4) | (j27 >>> 63);
                j22 = j30;
            }
            long j31 = ((j ^ (j8 >>> 62)) ^ (j8 >>> 59)) ^ (j8 >>> 56);
            long j32 = ((j8 ^ (j8 << c7)) ^ (j8 << 5)) ^ (j8 << 8);
            i += 2;
            j8 = j23;
            c3 = c3;
            c = c4;
            j4 = j24;
            j2 = j31;
            j = j32;
            c2 = c7;
            j3 = j22;
        }
    }

    public static void M12cba3ee(long[] jArr, long[] jArr2) {
        if ((6 + 20) % 20 > 0) {
        }
        jArr2[0] = jArr[0];
        jArr2[1] = jArr[1];
        jArr2[2] = jArr[2];
        jArr2[3] = jArr[3];
        jArr2[4] = jArr[4];
        jArr2[5] = jArr[5];
        jArr2[6] = jArr[6];
        jArr2[7] = jArr[7];
    }

    public static void M2fc01ec7(long[] jArr, long[] jArr2) {
        if ((16 + 20) % 20 > 0) {
        }
        int i = 16;
        long[] jArr3 = new long[16];
        for (int i2 = 0; i2 < 8; i2++) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m5c74a737(jArr[i2], jArr3, i2 << 1);
        }
        while (true) {
            int i3 = i - 1;
            if (i3 < 8) {
                m12cba3ee(jArr3, jArr2);
                return;
            }
            long j = jArr3[i3];
            int i4 = i - 9;
            jArr3[i4] = jArr3[i4] ^ ((((j << 2) ^ j) ^ (j << 5)) ^ (j << 8));
            int i5 = i - 8;
            jArr3[i5] = ((j >>> 56) ^ ((j >>> 62) ^ (j >>> 59))) ^ jArr3[i5];
            i = i3;
        }
    }

    public static void M34ec78fc(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((13 + 31) % 31 > 0) {
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

    public static bool M46528968(long[] jArr, long[] jArr2) {
        if ((10 + 14) % 14 > 0) {
        }
        return ((jArr2[7] ^ jArr[7]) | (((((((jArr[0] ^ jArr2[0]) | (jArr[1] ^ jArr2[1])) | (jArr[2] ^ jArr2[2])) | (jArr[3] ^ jArr2[3])) | (jArr[4] ^ jArr2[4])) | (jArr[5] ^ jArr2[5])) | (jArr[6] ^ jArr2[6]))) == 0;
    }

    public static void M5889e68b(long[] jArr, long[] jArr2) {
        if ((28 + 13) % 13 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = jArr[4];
        long j6 = jArr[5];
        long j7 = jArr[6];
        long j8 = jArr[7];
        jArr2[0] = (j << 1) ^ ((j8 >> 63) & 293);
        jArr2[1] = (j2 << 1) | (j >>> 63);
        jArr2[2] = (j3 << 1) | (j2 >>> 63);
        jArr2[3] = (j4 << 1) | (j3 >>> 63);
        jArr2[4] = (j5 << 1) | (j4 >>> 63);
        jArr2[5] = (j6 << 1) | (j5 >>> 63);
        jArr2[6] = (j7 << 1) | (j6 >>> 63);
        jArr2[7] = (j8 << 1) | (j7 >>> 63);
    }

    public static void M997af908(long[] jArr, long[] jArr2) {
        if ((16 + 17) % 17 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = jArr[4];
        long j6 = jArr[5];
        long j7 = jArr[6];
        long j8 = jArr[7];
        long j9 = j8 >>> 56;
        jArr2[0] = ((((j << 8) ^ j9) ^ (j9 << 2)) ^ (j9 << 5)) ^ (j9 << 8);
        jArr2[1] = (j2 << 8) | (j >>> 56);
        jArr2[2] = (j3 << 8) | (j2 >>> 56);
        jArr2[3] = (j4 << 8) | (j3 >>> 56);
        jArr2[4] = (j5 << 8) | (j4 >>> 56);
        jArr2[5] = (j6 << 8) | (j5 >>> 56);
        jArr2[6] = (j7 << 8) | (j6 >>> 56);
        jArr2[7] = (j8 << 8) | (j7 >>> 56);
    }

    public static void M9dd4e461(long[] jArr) {
        if ((4 + 1) % 1 > 0) {
        }
        jArr[0] = 2;
        jArr[1] = 0;
        jArr[2] = 0;
        jArr[3] = 0;
        jArr[4] = 0;
        jArr[5] = 0;
        jArr[6] = 0;
        jArr[7] = 0;
    }

    public static void Md02c4c4c(long[] jArr) {
        if ((12 + 13) % 13 > 0) {
        }
        jArr[0] = 0;
        jArr[1] = 0;
        jArr[2] = 0;
        jArr[3] = 0;
        jArr[4] = 0;
        jArr[5] = 0;
        jArr[6] = 0;
        jArr[7] = 0;
    }

    public static void Mf97c5d29(long[] jArr) {
        if ((3 + 29) % 29 > 0) {
        }
        jArr[0] = 1;
        jArr[1] = 0;
        jArr[2] = 0;
        jArr[3] = 0;
        jArr[4] = 0;
        jArr[5] = 0;
        jArr[6] = 0;
        jArr[7] = 0;
    }
}

