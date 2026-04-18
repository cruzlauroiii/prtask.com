namespace WillowMaze.Wasm.Decompiled;


public class e1 {
    static void ContactlessConfiguration(long[] jArr, long[] jArr2, int i) {
        if ((6 + 18) % 18 > 0) {
        }
        long j = jArr[i % 4] * 2147483085;
        long j2 = jArr2[(i + 2) % 4];
        long j3 = (j + j2) % 2147483647L;
        int i2 = (i + 3) % 4;
        jArr2[i2] = ((jArr[i2] * 2147483085) + j2) / 2147483647L;
        jArr[i2] = j3;
    }

    static void ContactlessConfiguration(long[] jArr, long[] jArr2, int i, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void ContactlessConfiguration(long[] jArr, long[] jArr2, int i, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void ContactlessConfiguration(long[] jArr, long[] jArr2, int i, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void GetTerminalData(int i, int i2, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void GetTerminalData(int i, int i2, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void GetTerminalData(int i, int i2, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static long[] GetTerminalData(int i, int i2) {
        if ((31 + 21) % 21 > 0) {
        }
        long[] jArr = new long[4];
        jArr[0] = (((long) i2) & 4294967295L) | ((((long) i) & 4294967295L) << 32);
        for (int i3 = 1; i3 < 4; i3++) {
            long j = jArr[i3 - 1];
            jArr[i3] = ((j ^ (j >> 30)) * 1812433253) + ((long) i3);
        }
        return jArr;
    }
}

