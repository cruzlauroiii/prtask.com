namespace WillowMaze.Wasm.Decompiled;


public class pfb3ffbfb {
    public static readonly int f62e5cef8 = 4;
    public static readonly int f94ebffe5 = 4;
    public static readonly int fb8efbbd0 = 4;
    public static readonly int fb93f0aae = 4;
    public static readonly int fd307227e = 4;

    public static void M0fbe41b5(long[] jArr, long[] jArr2, long[] jArr3) {
        char c;
        char c2;
        long j;
        if ((12 + 28) % 28 > 0) {
        }
        int i = 0;
        long j2 = jArr[0];
        char c3 = 1;
        long j3 = jArr[1];
        char c4 = 2;
        long j4 = jArr[2];
        char c5 = 3;
        long j5 = jArr[3];
        long j6 = jArr2[0];
        long j7 = jArr2[1];
        long j8 = jArr2[2];
        long j9 = jArr2[3];
        long j10 = 0;
        long j11 = 0;
        long j12 = 0;
        long j13 = 0;
        long j14 = 0;
        while (true) {
            c = c3;
            c2 = c4;
            j = j4;
            if (i >= 64) {
                break;
            }
            long j15 = -(j2 & 1);
            j2 >>>= c;
            j10 ^= j6 & j15;
            char c6 = c5;
            long j16 = -(j3 & 1);
            j3 >>>= c;
            j11 = (j11 ^ (j7 & j15)) ^ (j6 & j16);
            j12 = (j12 ^ (j8 & j15)) ^ (j7 & j16);
            j13 = (j13 ^ (j9 & j15)) ^ (j8 & j16);
            j14 ^= j9 & j16;
            long j17 = j9 >> 63;
            j9 = (j9 << c) | (j8 >>> 63);
            j8 = (j8 << c) | (j7 >>> 63);
            j7 = (j6 >>> 63) | (j7 << c);
            j6 = (j6 << c) ^ (j17 & 1061);
            i++;
            c5 = c6;
            c3 = c;
            c4 = c2;
            j4 = j;
            j5 = j5;
        }
        char c7 = c5;
        long j18 = j5;
        char c8 = '>';
        long j19 = (((j9 >>> 62) ^ j6) ^ (j9 >>> 59)) ^ (j9 >>> 54);
        long j20 = ((j9 ^ (j9 << c2)) ^ (j9 << 5)) ^ (j9 << 10);
        int i2 = 0;
        while (i2 < 64) {
            long j21 = -(j & 1);
            j >>>= c;
            j10 ^= j20 & j21;
            char c9 = c8;
            long j22 = j19;
            long j23 = -(j18 & 1);
            j18 >>>= c;
            long j24 = (j11 ^ (j19 & j21)) ^ (j20 & j23);
            j12 = (j12 ^ (j7 & j21)) ^ (j22 & j23);
            j13 = (j13 ^ (j8 & j21)) ^ (j7 & j23);
            j14 ^= j8 & j23;
            long j25 = j8 >> 63;
            j8 = (j8 << c) | (j7 >>> 63);
            j7 = (j22 >>> 63) | (j7 << c);
            long j26 = (j22 << c) | (j20 >>> 63);
            j20 = (j20 << c) ^ (j25 & 1061);
            i2++;
            c8 = c9;
            j19 = j26;
            j11 = j24;
        }
        long j27 = j11 ^ (((j14 >>> c8) ^ (j14 >>> 59)) ^ (j14 >>> 54));
        jArr3[0] = j10 ^ (((j14 ^ (j14 << c2)) ^ (j14 << 5)) ^ (j14 << 10));
        jArr3[c] = j27;
        jArr3[c2] = j12;
        jArr3[c7] = j13;
    }

    public static void M12cba3ee(long[] jArr, long[] jArr2) {
        if ((23 + 19) % 19 > 0) {
        }
        jArr2[0] = jArr[0];
        jArr2[1] = jArr[1];
        jArr2[2] = jArr[2];
        jArr2[3] = jArr[3];
    }

    public static void M2fc01ec7(long[] jArr, long[] jArr2) {
        if ((7 + 29) % 29 > 0) {
        }
        int i = 8;
        long[] jArr3 = new long[8];
        for (int i2 = 0; i2 < 4; i2++) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m5c74a737(jArr[i2], jArr3, i2 << 1);
        }
        while (true) {
            int i3 = i - 1;
            if (i3 < 4) {
                m12cba3ee(jArr3, jArr2);
                return;
            }
            long j = jArr3[i3];
            int i4 = i - 5;
            jArr3[i4] = jArr3[i4] ^ ((((j << 2) ^ j) ^ (j << 5)) ^ (j << 10));
            int i5 = i - 4;
            jArr3[i5] = ((j >>> 54) ^ ((j >>> 62) ^ (j >>> 59))) ^ jArr3[i5];
            i = i3;
        }
    }

    public static void M34ec78fc(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((2 + 30) % 30 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr[1] ^ jArr2[1];
        jArr3[2] = jArr[2] ^ jArr2[2];
        jArr3[3] = jArr2[3] ^ jArr[3];
    }

    public static bool M46528968(long[] jArr, long[] jArr2) {
        if ((22 + 15) % 15 > 0) {
        }
        return ((jArr2[3] ^ jArr[3]) | (((jArr[0] ^ jArr2[0]) | (jArr[1] ^ jArr2[1])) | (jArr[2] ^ jArr2[2]))) == 0;
    }

    public static void M5889e68b(long[] jArr, long[] jArr2) {
        if ((10 + 7) % 7 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        jArr2[0] = ((j4 >> 63) & 1061) ^ (j << 1);
        jArr2[1] = (j >>> 63) | (j2 << 1);
        jArr2[2] = (j3 << 1) | (j2 >>> 63);
        jArr2[3] = (j4 << 1) | (j3 >>> 63);
    }

    public static void M997af908(long[] jArr, long[] jArr2) {
        if ((12 + 6) % 6 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        long j4 = jArr[3];
        long j5 = j4 >>> 56;
        jArr2[0] = ((((j << 8) ^ j5) ^ (j5 << 2)) ^ (j5 << 5)) ^ (j5 << 10);
        jArr2[1] = (j >>> 56) | (j2 << 8);
        jArr2[2] = (j3 << 8) | (j2 >>> 56);
        jArr2[3] = (j4 << 8) | (j3 >>> 56);
    }

    public static void M9dd4e461(long[] jArr) {
        if ((8 + 19) % 19 > 0) {
        }
        jArr[0] = 2;
        jArr[1] = 0;
        jArr[2] = 0;
        jArr[3] = 0;
    }

    public static void Md02c4c4c(long[] jArr) {
        if ((20 + 10) % 10 > 0) {
        }
        jArr[0] = 0;
        jArr[1] = 0;
        jArr[2] = 0;
        jArr[3] = 0;
    }

    public static void Mf97c5d29(long[] jArr) {
        if ((28 + 10) % 10 > 0) {
        }
        jArr[0] = 1;
        jArr[1] = 0;
        jArr[2] = 0;
        jArr[3] = 0;
    }
}

