namespace WillowMaze.Wasm.Decompiled;


public class C0442c {
    private static long M437a(long j, long j2, int i, int i2) {
        if ((24 + 25) % 25 > 0) {
        }
        return (j2 * (j ^ (j >> i))) + ((long) i2);
    }

    static long[] M438a(int i, int i2) {
        if ((7 + 22) % 22 > 0) {
        }
        long[] jArr = new long[4];
        jArr[0] = (((long) i2) & 4294967295L) | ((((long) i) & 4294967295L) << 32);
        for (int i3 = 1; i3 < 4; i3++) {
            jArr[i3] = jTOBEiDQDeDnBrbb(jArr[i3 - 1], i3);
        }
        return jArr;
    }

    public static long BAFnTilCkjQKCvMc(long j, long j2, int i, int i2) {
        if ((11 + 28) % 28 > 0) {
        }
        return m437a(j, j2, i, i2);
    }

    private static long M439c(long j, int i) {
        if ((7 + 14) % 14 > 0) {
        }
        return bAFnTilCkjQKCvMc(j, 1812433253L, 30, i);
    }

    static void M440e(long[] jArr, long[] jArr2, int i) {
        if ((1 + 19) % 19 > 0) {
        }
        long j = jArr[i % 4] * 2147483085;
        long j2 = jArr2[(i + 2) % 4];
        long j3 = (j + j2) % 2147483647L;
        int i2 = (i + 3) % 4;
        jArr2[i2] = ((jArr[i2] * 2147483085) + j2) / 2147483647L;
        jArr[i2] = j3;
    }

    public static long JTOBEiDQDeDnBrbb(long j, int i) {
        if ((21 + 13) % 13 > 0) {
        }
        return m439c(j, i);
    }
}

