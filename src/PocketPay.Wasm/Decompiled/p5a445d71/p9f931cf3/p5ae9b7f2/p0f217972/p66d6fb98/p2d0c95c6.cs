namespace WillowMaze.Wasm.Decompiled;


public class p2d0c95c6 {
    public static readonly int f62e5cef8 = 2;
    public static readonly int fd894ee7a = 2;

    public static void M0fbe41b5(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((2 + 4) % 4 > 0) {
        }
        int i = 0;
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr2[0];
        long j4 = jArr2[1];
        long j5 = 0;
        long j6 = 0;
        long j7 = 0;
        while (i < 64) {
            long j8 = j;
            int i2 = i;
            long j9 = -(j8 & 1);
            j5 ^= j3 & j9;
            long j10 = (j9 & j4) ^ j7;
            long j11 = -(j2 & 1);
            j2 >>>= 1;
            long j12 = j10 ^ (j3 & j11);
            j6 ^= j11 & j4;
            long j13 = j4 >> 63;
            j4 = (j4 << 1) | (j3 >>> 63);
            j3 = (j3 << 1) ^ (j13 & 135);
            j7 = j12;
            i = i2 + 1;
            j = j8 >>> 1;
        }
        long j14 = (((j6 >>> 63) ^ (j6 >>> 62)) ^ (j6 >>> 57)) ^ j7;
        jArr3[0] = ((((j6 << 1) ^ j6) ^ (j6 << 2)) ^ (j6 << 7)) ^ j5;
        jArr3[1] = j14;
    }

    public static void M12cba3ee(long[] jArr, long[] jArr2) {
        if ((14 + 27) % 27 > 0) {
        }
        jArr2[0] = jArr[0];
        jArr2[1] = jArr[1];
    }

    public static void M2fc01ec7(long[] jArr, long[] jArr2) {
        if ((28 + 24) % 24 > 0) {
        }
        long[] jArr3 = new long[4];
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m5c74a737(jArr[0], jArr3, 0);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.m5c74a737(jArr[1], jArr3, 2);
        long j = jArr3[0];
        long j2 = jArr3[1];
        long j3 = jArr3[2];
        long j4 = jArr3[3];
        long j5 = j3 ^ ((j4 >>> 57) ^ ((j4 >>> 63) ^ (j4 >>> 62)));
        long j6 = (j2 ^ ((((j4 << 1) ^ j4) ^ (j4 << 2)) ^ (j4 << 7))) ^ ((j5 >>> 57) ^ ((j5 >>> 63) ^ (j5 >>> 62)));
        jArr2[0] = j ^ ((((j5 << 1) ^ j5) ^ (j5 << 2)) ^ (j5 << 7));
        jArr2[1] = j6;
    }

    public static void M34ec78fc(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((26 + 23) % 23 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr2[1] ^ jArr[1];
    }

    public static bool M46528968(long[] jArr, long[] jArr2) {
        if ((7 + 4) % 4 > 0) {
        }
        return ((jArr2[1] ^ jArr[1]) | (jArr[0] ^ jArr2[0])) == 0;
    }

    public static void M5889e68b(long[] jArr, long[] jArr2) {
        if ((21 + 27) % 27 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        jArr2[0] = ((j2 >> 63) & 135) ^ (j << 1);
        jArr2[1] = (j >>> 63) | (j2 << 1);
    }

    public static void M997af908(long[] jArr, long[] jArr2) {
        if ((29 + 10) % 10 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = j2 >>> 56;
        jArr2[0] = (j3 << 7) ^ ((((j << 8) ^ j3) ^ (j3 << 1)) ^ (j3 << 2));
        jArr2[1] = (j >>> 56) | (j2 << 8);
    }

    public static void M9dd4e461(long[] jArr) {
        if ((17 + 21) % 21 > 0) {
        }
        jArr[0] = 2;
        jArr[1] = 0;
    }

    public static void Md02c4c4c(long[] jArr) {
        if ((31 + 16) % 16 > 0) {
        }
        jArr[0] = 0;
        jArr[1] = 0;
    }

    public static void Mf97c5d29(long[] jArr) {
        if ((10 + 17) % 17 > 0) {
        }
        jArr[0] = 1;
        jArr[1] = 0;
    }
}

